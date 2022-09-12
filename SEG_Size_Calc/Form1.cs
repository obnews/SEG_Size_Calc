using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEG_Size_Calc
{
    public partial class segFileSizeCalculation : Form
    {
        public segFileSizeCalculation()
        {
            InitializeComponent();
        }
        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            double recordingLength = Convert.ToDouble(textBoxRecordingLength.Text);
            double sampleRate = Convert.ToDouble(textBoxSampleRate.Text);
            ulong noStreamers = Convert.ToUInt64(textBoxNoStreamers.Text);
            ulong chanPerStreamer = Convert.ToUInt64(textBoxChannelsPerStreamer.Text);
            ulong noAuxChannels = Convert.ToUInt64(textBoxNoAuxChannels.Text);
            ulong generalHeaderLength = Convert.ToUInt64(textBoxNoGeneralHeader.Text);
            ulong extendedHeaderLength = Convert.ToUInt64(textBoxExtendedHeaderLength.Text);
            ulong externalHeaderLength = Convert.ToUInt64(textBoxExternalHeaderLength.Text);
            ulong noChannelSet = Convert.ToUInt64(textBoxNoChannelSets.Text);
            ulong noShots = Convert.ToUInt64(textBoxNoShots.Text);
            ulong noSamples =Convert.ToUInt64( recordingLength / sampleRate);
            ulong filesize;
            if (radioButton1.Checked)
            {
                filesize = noShots * (((noSamples + 1) * 4 + 20 + 32 * 7) * (chanPerStreamer * noStreamers + noAuxChannels) + generalHeaderLength * 32 + extendedHeaderLength + externalHeaderLength + noChannelSet * 32);
            }
            else
            {
                if (checkBoxIncludeEBCDICBinHdr.Checked)
                {
                    filesize = 3200 + 400 + noShots * ((noSamples + 1) * 4 + 240) * (chanPerStreamer * noStreamers + noAuxChannels);
                }
                else
                {
                    filesize = noShots * ((noSamples + 1) * 4 + 240) * (chanPerStreamer * noStreamers + noAuxChannels);
                }
            }
            textBoxFileSize.Text = filesize.ToString();
            textBoxFileSizeReadable.Text = FileSizeReadable(filesize);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNoGeneralHeader.Visible = false;
            textBoxExtendedHeaderLength.Visible = false;
            textBoxExternalHeaderLength.Visible = false;
            textBoxNoChannelSets.Visible = false;
            checkBoxIncludeEBCDICBinHdr.Visible = true;
            textBoxNoAuxChannels.Text = "0";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNoGeneralHeader.Visible = true;
            textBoxExtendedHeaderLength.Visible = true;
            textBoxExternalHeaderLength.Visible = true;
            textBoxNoChannelSets.Visible = true;
            checkBoxIncludeEBCDICBinHdr.Visible = false;
            textBoxNoAuxChannels.Text = "7";

        }
        string FileSizeReadable(ulong fileLengthInByte)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            uint place = Convert.ToUInt32(Math.Floor(Math.Log(fileLengthInByte, 1024)));
            double fileLengthReadable = Math.Round(fileLengthInByte / Math.Pow(1024, place), 3);//3位小数
            return fileLengthReadable + " " + suf[place];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wen Bo <wenbo222@gmail.com>\nv0.1, 20200816", "About");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the default value if you don't know the meaning of that entry.", "Readme211dev");
        }
    }
}
