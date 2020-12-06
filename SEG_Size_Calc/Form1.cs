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
            long recordingLength = Convert.ToInt32(textBoxRecordingLength.Text);
            long sampleRate = Convert.ToInt32(textBoxSampleRate.Text);
            long noStreamers = Convert.ToInt32(textBoxNoStreamers.Text);
            long chanPerStreamer = Convert.ToInt32(textBoxChannelsPerStreamer.Text);
            long noAuxChannels = Convert.ToInt32(textBoxNoAuxChannels.Text);
            long generalHeaderLength = Convert.ToInt32(textBoxNoGeneralHeader.Text);
            long extendedHeaderLength = Convert.ToInt32(textBoxExtendedHeaderLength.Text);
            long externalHeaderLength = Convert.ToInt32(textBoxExternalHeaderLength.Text);
            long noChannelSet = Convert.ToInt32(textBoxNoChannelSets.Text);
            long noShots = Convert.ToInt32(textBoxNoShots.Text);
            long filesize;
            if (radioButton1.Checked)
            {
                filesize = noShots * (((recordingLength / sampleRate + 1) * 4 + 20 + 32 * 7) * (chanPerStreamer * noStreamers + noAuxChannels) + generalHeaderLength * 32 + extendedHeaderLength + externalHeaderLength + noChannelSet * 32);
            }
            else
            {
                filesize = 3200 + 400 + noShots * ((recordingLength / sampleRate + 1) * 4 + 240) * (chanPerStreamer * noStreamers + noAuxChannels);
            }
            textBoxFileSize.Text = filesize.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNoGeneralHeader.Visible = false;
            textBoxExtendedHeaderLength.Visible = false;
            textBoxExternalHeaderLength.Visible = false;
            textBoxNoChannelSets.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNoGeneralHeader.Visible = true;
            textBoxExtendedHeaderLength.Visible = true;
            textBoxExternalHeaderLength.Visible = true;
            textBoxNoChannelSets.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wen Bo <wenbo222@gmail.com>\nv0.1, 20200816", "About");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the default value if you don't know the meaning of that entry.", "Readme1");
        }
    }
}
