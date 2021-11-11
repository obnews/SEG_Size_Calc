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
            long noStreamers = Convert.ToInt32(textBoxNoStreamers.Text);
            long chanPerStreamer = Convert.ToInt32(textBoxChannelsPerStreamer.Text);
            long noAuxChannels = Convert.ToInt32(textBoxNoAuxChannels.Text);
            long generalHeaderLength = Convert.ToInt32(textBoxNoGeneralHeader.Text);
            long extendedHeaderLength = Convert.ToInt32(textBoxExtendedHeaderLength.Text);
            long externalHeaderLength = Convert.ToInt32(textBoxExternalHeaderLength.Text);
            long noChannelSet = Convert.ToInt32(textBoxNoChannelSets.Text);
            long noShots = Convert.ToInt32(textBoxNoShots.Text);
            long noSamples =Convert.ToInt64( recordingLength / sampleRate);
            long filesize;
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

        string FileSizeReadable(long fileLengthInByte)
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
