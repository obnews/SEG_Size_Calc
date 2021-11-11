namespace SEG_Size_Calc {
    partial class segFileSizeCalculation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(segFileSizeCalculation));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNoGeneralHeader = new System.Windows.Forms.TextBox();
            this.textBoxNoChannelSets = new System.Windows.Forms.TextBox();
            this.textBoxExtendedHeaderLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExternalHeaderLength = new System.Windows.Forms.TextBox();
            this.textBoxNoStreamers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxChannelsPerStreamer = new System.Windows.Forms.TextBox();
            this.textBoxRecordingLength = new System.Windows.Forms.TextBox();
            this.textBoxSampleRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNoAuxChannels = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCalculation = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNoShots = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxFileSize = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxFileSizeReadable = new System.Windows.Forms.TextBox();
            this.checkBoxIncludeEBCDICBinHdr = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "8058 SEG-D rev2.1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(146, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SEGY v1.0";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "# of General Hdr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(237, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "# of Chan Sets";
            // 
            // textBoxNoGeneralHeader
            // 
            this.textBoxNoGeneralHeader.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNoGeneralHeader.Location = new System.Drawing.Point(120, 62);
            this.textBoxNoGeneralHeader.Name = "textBoxNoGeneralHeader";
            this.textBoxNoGeneralHeader.Size = new System.Drawing.Size(100, 23);
            this.textBoxNoGeneralHeader.TabIndex = 6;
            this.textBoxNoGeneralHeader.Text = "3";
            // 
            // textBoxNoChannelSets
            // 
            this.textBoxNoChannelSets.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNoChannelSets.Location = new System.Drawing.Point(336, 62);
            this.textBoxNoChannelSets.Name = "textBoxNoChannelSets";
            this.textBoxNoChannelSets.Size = new System.Drawing.Size(100, 23);
            this.textBoxNoChannelSets.TabIndex = 7;
            this.textBoxNoChannelSets.Text = "16";
            // 
            // textBoxExtendedHeaderLength
            // 
            this.textBoxExtendedHeaderLength.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxExtendedHeaderLength.Location = new System.Drawing.Point(120, 91);
            this.textBoxExtendedHeaderLength.Name = "textBoxExtendedHeaderLength";
            this.textBoxExtendedHeaderLength.Size = new System.Drawing.Size(100, 23);
            this.textBoxExtendedHeaderLength.TabIndex = 8;
            this.textBoxExtendedHeaderLength.Text = "1024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(2, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Extended Hdr Len.";
            // 
            // textBoxExternalHeaderLength
            // 
            this.textBoxExternalHeaderLength.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxExternalHeaderLength.Location = new System.Drawing.Point(336, 91);
            this.textBoxExternalHeaderLength.Name = "textBoxExternalHeaderLength";
            this.textBoxExternalHeaderLength.Size = new System.Drawing.Size(100, 23);
            this.textBoxExternalHeaderLength.TabIndex = 10;
            this.textBoxExternalHeaderLength.Text = "8192";
            // 
            // textBoxNoStreamers
            // 
            this.textBoxNoStreamers.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNoStreamers.Location = new System.Drawing.Point(120, 120);
            this.textBoxNoStreamers.Name = "textBoxNoStreamers";
            this.textBoxNoStreamers.Size = new System.Drawing.Size(100, 23);
            this.textBoxNoStreamers.TabIndex = 11;
            this.textBoxNoStreamers.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(223, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "External Hdr Len.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(19, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "# of Streamers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(223, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "# of Chan per Str.";
            // 
            // textBoxChannelsPerStreamer
            // 
            this.textBoxChannelsPerStreamer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxChannelsPerStreamer.Location = new System.Drawing.Point(336, 120);
            this.textBoxChannelsPerStreamer.Name = "textBoxChannelsPerStreamer";
            this.textBoxChannelsPerStreamer.Size = new System.Drawing.Size(100, 23);
            this.textBoxChannelsPerStreamer.TabIndex = 15;
            this.textBoxChannelsPerStreamer.Text = "636";
            // 
            // textBoxRecordingLength
            // 
            this.textBoxRecordingLength.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRecordingLength.Location = new System.Drawing.Point(120, 149);
            this.textBoxRecordingLength.Name = "textBoxRecordingLength";
            this.textBoxRecordingLength.Size = new System.Drawing.Size(100, 23);
            this.textBoxRecordingLength.TabIndex = 16;
            this.textBoxRecordingLength.Text = "10050";
            // 
            // textBoxSampleRate
            // 
            this.textBoxSampleRate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSampleRate.Location = new System.Drawing.Point(336, 149);
            this.textBoxSampleRate.Name = "textBoxSampleRate";
            this.textBoxSampleRate.Size = new System.Drawing.Size(100, 23);
            this.textBoxSampleRate.TabIndex = 17;
            this.textBoxSampleRate.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(10, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rec. Length (ms)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(220, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sample Rate (ms)";
            // 
            // textBoxNoAuxChannels
            // 
            this.textBoxNoAuxChannels.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNoAuxChannels.Location = new System.Drawing.Point(120, 178);
            this.textBoxNoAuxChannels.Name = "textBoxNoAuxChannels";
            this.textBoxNoAuxChannels.Size = new System.Drawing.Size(100, 23);
            this.textBoxNoAuxChannels.TabIndex = 20;
            this.textBoxNoAuxChannels.Text = "7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(24, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "# of Aux Chan";
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCalculation.Location = new System.Drawing.Point(336, 207);
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculation.TabIndex = 22;
            this.buttonCalculation.Text = "Calculate";
            this.buttonCalculation.UseVisualStyleBackColor = true;
            this.buttonCalculation.Click += new System.EventHandler(this.buttonCalculation_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(23, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "File Size (Byte)";
            // 
            // textBoxNoShots
            // 
            this.textBoxNoShots.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNoShots.Location = new System.Drawing.Point(336, 178);
            this.textBoxNoShots.Name = "textBoxNoShots";
            this.textBoxNoShots.Size = new System.Drawing.Size(100, 23);
            this.textBoxNoShots.TabIndex = 25;
            this.textBoxNoShots.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(262, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "# of Shots";
            // 
            // textBoxFileSize
            // 
            this.textBoxFileSize.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFileSize.Location = new System.Drawing.Point(120, 207);
            this.textBoxFileSize.Name = "textBoxFileSize";
            this.textBoxFileSize.Size = new System.Drawing.Size(210, 23);
            this.textBoxFileSize.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(363, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(282, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Readme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(2, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "File Size Readable";
            // 
            // textBoxFileSizeReadable
            // 
            this.textBoxFileSizeReadable.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFileSizeReadable.Location = new System.Drawing.Point(120, 236);
            this.textBoxFileSizeReadable.Name = "textBoxFileSizeReadable";
            this.textBoxFileSizeReadable.Size = new System.Drawing.Size(210, 23);
            this.textBoxFileSizeReadable.TabIndex = 30;
            // 
            // checkBoxIncludeEBCDICBinHdr
            // 
            this.checkBoxIncludeEBCDICBinHdr.AutoSize = true;
            this.checkBoxIncludeEBCDICBinHdr.Checked = true;
            this.checkBoxIncludeEBCDICBinHdr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeEBCDICBinHdr.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxIncludeEBCDICBinHdr.Location = new System.Drawing.Point(336, 239);
            this.checkBoxIncludeEBCDICBinHdr.Name = "checkBoxIncludeEBCDICBinHdr";
            this.checkBoxIncludeEBCDICBinHdr.Size = new System.Drawing.Size(189, 21);
            this.checkBoxIncludeEBCDICBinHdr.TabIndex = 31;
            this.checkBoxIncludeEBCDICBinHdr.Text = "Include EBCDIC and bin hdr";
            this.checkBoxIncludeEBCDICBinHdr.UseVisualStyleBackColor = true;
            this.checkBoxIncludeEBCDICBinHdr.Visible = false;
            // 
            // segFileSizeCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 264);
            this.Controls.Add(this.checkBoxIncludeEBCDICBinHdr);
            this.Controls.Add(this.textBoxFileSizeReadable);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxNoShots);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxFileSize);
            this.Controls.Add(this.buttonCalculation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNoAuxChannels);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSampleRate);
            this.Controls.Add(this.textBoxRecordingLength);
            this.Controls.Add(this.textBoxChannelsPerStreamer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNoStreamers);
            this.Controls.Add(this.textBoxExternalHeaderLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxExtendedHeaderLength);
            this.Controls.Add(this.textBoxNoChannelSets);
            this.Controls.Add(this.textBoxNoGeneralHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "segFileSizeCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEG File Size Calculation by Wen Bo <wenbo222@gmail.com>";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNoGeneralHeader;
        private System.Windows.Forms.TextBox textBoxNoChannelSets;
        private System.Windows.Forms.TextBox textBoxExtendedHeaderLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExternalHeaderLength;
        private System.Windows.Forms.TextBox textBoxNoStreamers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxChannelsPerStreamer;
        private System.Windows.Forms.TextBox textBoxRecordingLength;
        private System.Windows.Forms.TextBox textBoxSampleRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNoAuxChannels;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCalculation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNoShots;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxFileSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxFileSizeReadable;
        private System.Windows.Forms.CheckBox checkBoxIncludeEBCDICBinHdr;
    }
}

