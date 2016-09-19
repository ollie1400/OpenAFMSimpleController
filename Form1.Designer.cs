namespace simpleController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnect = new System.Windows.Forms.Button();
            this.numericPort = new System.Windows.Forms.NumericUpDown();
            this.buttonPing = new System.Windows.Forms.Button();
            this.textComms = new System.Windows.Forms.TextBox();
            this.buttonReadSig = new System.Windows.Forms.Button();
            this.buttonGrapher = new System.Windows.Forms.Button();
            this.panelCommands = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSendSetup = new System.Windows.Forms.Button();
            this.numericStepSize = new System.Windows.Forms.NumericUpDown();
            this.numericLineLength = new System.Windows.Forms.NumericUpDown();
            this.numericSampleSize = new System.Windows.Forms.NumericUpDown();
            this.numericFocusCurrent = new System.Windows.Forms.NumericUpDown();
            this.numericFocusMax = new System.Windows.Forms.NumericUpDown();
            this.numericFocusMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackVCt = new System.Windows.Forms.TrackBar();
            this.textMask = new System.Windows.Forms.TextBox();
            this.trackVCtasd = new System.Windows.Forms.TrackBar();
            this.trackVCz = new System.Windows.Forms.TrackBar();
            this.checkReply = new System.Windows.Forms.CheckBox();
            this.checkEcho = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.panelCommands2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.comboDiffADCGain = new System.Windows.Forms.ComboBox();
            this.comboSigADCGain = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStepSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSampleSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFocusCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFocusMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFocusMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCtasd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCz)).BeginInit();
            this.panelCommands2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(13, 23);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // numericPort
            // 
            this.numericPort.Location = new System.Drawing.Point(95, 25);
            this.numericPort.Name = "numericPort";
            this.numericPort.Size = new System.Drawing.Size(67, 20);
            this.numericPort.TabIndex = 1;
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(179, 3);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(75, 23);
            this.buttonPing.TabIndex = 2;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // textComms
            // 
            this.textComms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textComms.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textComms.Location = new System.Drawing.Point(361, 52);
            this.textComms.Multiline = true;
            this.textComms.Name = "textComms";
            this.textComms.ReadOnly = true;
            this.textComms.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textComms.Size = new System.Drawing.Size(500, 661);
            this.textComms.TabIndex = 3;
            // 
            // buttonReadSig
            // 
            this.buttonReadSig.Location = new System.Drawing.Point(3, 3);
            this.buttonReadSig.Name = "buttonReadSig";
            this.buttonReadSig.Size = new System.Drawing.Size(122, 23);
            this.buttonReadSig.TabIndex = 4;
            this.buttonReadSig.Text = "Read Signals";
            this.buttonReadSig.UseVisualStyleBackColor = true;
            this.buttonReadSig.Click += new System.EventHandler(this.buttonReadSig_Click);
            // 
            // buttonGrapher
            // 
            this.buttonGrapher.Location = new System.Drawing.Point(3, 604);
            this.buttonGrapher.Name = "buttonGrapher";
            this.buttonGrapher.Size = new System.Drawing.Size(123, 57);
            this.buttonGrapher.TabIndex = 5;
            this.buttonGrapher.Text = "Open Grapher";
            this.buttonGrapher.UseVisualStyleBackColor = true;
            this.buttonGrapher.Click += new System.EventHandler(this.buttonGrapher_Click);
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.label9);
            this.panelCommands.Controls.Add(this.label8);
            this.panelCommands.Controls.Add(this.comboSigADCGain);
            this.panelCommands.Controls.Add(this.comboDiffADCGain);
            this.panelCommands.Controls.Add(this.label7);
            this.panelCommands.Controls.Add(this.label6);
            this.panelCommands.Controls.Add(this.label5);
            this.panelCommands.Controls.Add(this.buttonSendSetup);
            this.panelCommands.Controls.Add(this.numericStepSize);
            this.panelCommands.Controls.Add(this.numericLineLength);
            this.panelCommands.Controls.Add(this.numericSampleSize);
            this.panelCommands.Controls.Add(this.numericFocusCurrent);
            this.panelCommands.Controls.Add(this.numericFocusMax);
            this.panelCommands.Controls.Add(this.numericFocusMin);
            this.panelCommands.Controls.Add(this.label4);
            this.panelCommands.Controls.Add(this.label3);
            this.panelCommands.Controls.Add(this.label2);
            this.panelCommands.Controls.Add(this.label1);
            this.panelCommands.Controls.Add(this.trackVCt);
            this.panelCommands.Controls.Add(this.textMask);
            this.panelCommands.Controls.Add(this.trackVCtasd);
            this.panelCommands.Controls.Add(this.trackVCz);
            this.panelCommands.Controls.Add(this.checkReply);
            this.panelCommands.Controls.Add(this.checkEcho);
            this.panelCommands.Controls.Add(this.buttonReadSig);
            this.panelCommands.Controls.Add(this.buttonGrapher);
            this.panelCommands.Controls.Add(this.buttonPing);
            this.panelCommands.Location = new System.Drawing.Point(13, 52);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(298, 664);
            this.panelCommands.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sample Size";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Line Length";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Step size";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSendSetup
            // 
            this.buttonSendSetup.Location = new System.Drawing.Point(25, 361);
            this.buttonSendSetup.Name = "buttonSendSetup";
            this.buttonSendSetup.Size = new System.Drawing.Size(75, 23);
            this.buttonSendSetup.TabIndex = 25;
            this.buttonSendSetup.Text = "Send Setup";
            this.buttonSendSetup.UseVisualStyleBackColor = true;
            this.buttonSendSetup.Click += new System.EventHandler(this.buttonSendSetup_Click);
            // 
            // numericStepSize
            // 
            this.numericStepSize.Location = new System.Drawing.Point(119, 361);
            this.numericStepSize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericStepSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStepSize.Name = "numericStepSize";
            this.numericStepSize.Size = new System.Drawing.Size(101, 20);
            this.numericStepSize.TabIndex = 24;
            this.numericStepSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericLineLength
            // 
            this.numericLineLength.Location = new System.Drawing.Point(119, 387);
            this.numericLineLength.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericLineLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLineLength.Name = "numericLineLength";
            this.numericLineLength.Size = new System.Drawing.Size(101, 20);
            this.numericLineLength.TabIndex = 22;
            this.numericLineLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericSampleSize
            // 
            this.numericSampleSize.Location = new System.Drawing.Point(119, 413);
            this.numericSampleSize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericSampleSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSampleSize.Name = "numericSampleSize";
            this.numericSampleSize.Size = new System.Drawing.Size(101, 20);
            this.numericSampleSize.TabIndex = 23;
            this.numericSampleSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericFocusCurrent
            // 
            this.numericFocusCurrent.Location = new System.Drawing.Point(119, 158);
            this.numericFocusCurrent.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericFocusCurrent.Name = "numericFocusCurrent";
            this.numericFocusCurrent.Size = new System.Drawing.Size(65, 20);
            this.numericFocusCurrent.TabIndex = 21;
            this.numericFocusCurrent.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // numericFocusMax
            // 
            this.numericFocusMax.Location = new System.Drawing.Point(209, 158);
            this.numericFocusMax.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericFocusMax.Name = "numericFocusMax";
            this.numericFocusMax.Size = new System.Drawing.Size(65, 20);
            this.numericFocusMax.TabIndex = 20;
            this.numericFocusMax.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericFocusMax.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // numericFocusMin
            // 
            this.numericFocusMin.Location = new System.Drawing.Point(26, 158);
            this.numericFocusMin.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericFocusMin.Name = "numericFocusMin";
            this.numericFocusMin.Size = new System.Drawing.Size(65, 20);
            this.numericFocusMin.TabIndex = 19;
            this.numericFocusMin.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Channel mask:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Piezo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Track";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Focus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackVCt
            // 
            this.trackVCt.Location = new System.Drawing.Point(26, 218);
            this.trackVCt.Maximum = 65535;
            this.trackVCt.Name = "trackVCt";
            this.trackVCt.Size = new System.Drawing.Size(256, 45);
            this.trackVCt.TabIndex = 13;
            this.trackVCt.Scroll += new System.EventHandler(this.trackVCt_Scroll_1);
            // 
            // textMask
            // 
            this.textMask.Location = new System.Drawing.Point(199, 284);
            this.textMask.Name = "textMask";
            this.textMask.Size = new System.Drawing.Size(63, 20);
            this.textMask.TabIndex = 12;
            this.textMask.Text = "15";
            // 
            // trackVCtasd
            // 
            this.trackVCtasd.Location = new System.Drawing.Point(18, 310);
            this.trackVCtasd.Maximum = 65535;
            this.trackVCtasd.Name = "trackVCtasd";
            this.trackVCtasd.Size = new System.Drawing.Size(256, 45);
            this.trackVCtasd.TabIndex = 11;
            this.trackVCtasd.Scroll += new System.EventHandler(this.trackVCt_Scroll);
            // 
            // trackVCz
            // 
            this.trackVCz.Location = new System.Drawing.Point(18, 122);
            this.trackVCz.Maximum = 65535;
            this.trackVCz.Name = "trackVCz";
            this.trackVCz.Size = new System.Drawing.Size(256, 45);
            this.trackVCz.TabIndex = 10;
            this.trackVCz.Scroll += new System.EventHandler(this.trackVCz_Scroll);
            // 
            // checkReply
            // 
            this.checkReply.AutoSize = true;
            this.checkReply.Location = new System.Drawing.Point(18, 72);
            this.checkReply.Name = "checkReply";
            this.checkReply.Size = new System.Drawing.Size(53, 17);
            this.checkReply.TabIndex = 7;
            this.checkReply.Text = "Reply";
            this.checkReply.UseVisualStyleBackColor = true;
            this.checkReply.CheckedChanged += new System.EventHandler(this.checkReply_CheckedChanged);
            // 
            // checkEcho
            // 
            this.checkEcho.AutoSize = true;
            this.checkEcho.Location = new System.Drawing.Point(18, 49);
            this.checkEcho.Name = "checkEcho";
            this.checkEcho.Size = new System.Drawing.Size(51, 17);
            this.checkEcho.TabIndex = 6;
            this.checkEcho.Text = "Echo";
            this.checkEcho.UseVisualStyleBackColor = true;
            this.checkEcho.CheckedChanged += new System.EventHandler(this.checkEcho_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSend
            // 
            this.textSend.Location = new System.Drawing.Point(3, 7);
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(205, 20);
            this.textSend.TabIndex = 9;
            this.textSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSend_KeyDown);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(214, 7);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(57, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // panelCommands2
            // 
            this.panelCommands2.Controls.Add(this.button2);
            this.panelCommands2.Controls.Add(this.textSend);
            this.panelCommands2.Controls.Add(this.buttonSend);
            this.panelCommands2.Controls.Add(this.button1);
            this.panelCommands2.Location = new System.Drawing.Point(361, 11);
            this.panelCommands2.Name = "panelCommands2";
            this.panelCommands2.Size = new System.Drawing.Size(499, 33);
            this.panelCommands2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboDiffADCGain
            // 
            this.comboDiffADCGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDiffADCGain.FormattingEnabled = true;
            this.comboDiffADCGain.Items.AddRange(new object[] {
            "2/3",
            "1",
            "2",
            "4",
            "8",
            "16"});
            this.comboDiffADCGain.Location = new System.Drawing.Point(119, 456);
            this.comboDiffADCGain.Name = "comboDiffADCGain";
            this.comboDiffADCGain.Size = new System.Drawing.Size(121, 21);
            this.comboDiffADCGain.TabIndex = 29;
            this.comboDiffADCGain.SelectionChangeCommitted += new System.EventHandler(this.combo_SelectionChangeCommitted);
            // 
            // comboSigADCGain
            // 
            this.comboSigADCGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSigADCGain.FormattingEnabled = true;
            this.comboSigADCGain.Items.AddRange(new object[] {
            "2/3",
            "1",
            "2",
            "4",
            "8",
            "16"});
            this.comboSigADCGain.Location = new System.Drawing.Point(119, 483);
            this.comboSigADCGain.Name = "comboSigADCGain";
            this.comboSigADCGain.Size = new System.Drawing.Size(121, 21);
            this.comboSigADCGain.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Diff ADC Gain";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Sig ADC Gain";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 728);
            this.Controls.Add(this.panelCommands2);
            this.Controls.Add(this.panelCommands);
            this.Controls.Add(this.textComms);
            this.Controls.Add(this.numericPort);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.panelCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStepSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSampleSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFocusCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFocusMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFocusMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCtasd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCz)).EndInit();
            this.panelCommands2.ResumeLayout(false);
            this.panelCommands2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.NumericUpDown numericPort;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.TextBox textComms;
        private System.Windows.Forms.Button buttonReadSig;
        private System.Windows.Forms.Button buttonGrapher;
        private System.Windows.Forms.Panel panelCommands;
        private System.Windows.Forms.CheckBox checkReply;
        private System.Windows.Forms.CheckBox checkEcho;
        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TrackBar trackVCz;
        private System.Windows.Forms.TrackBar trackVCtasd;
        private System.Windows.Forms.TextBox textMask;
        private System.Windows.Forms.TrackBar trackVCt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericFocusCurrent;
        private System.Windows.Forms.NumericUpDown numericFocusMax;
        private System.Windows.Forms.NumericUpDown numericFocusMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSendSetup;
        private System.Windows.Forms.NumericUpDown numericStepSize;
        private System.Windows.Forms.NumericUpDown numericLineLength;
        private System.Windows.Forms.NumericUpDown numericSampleSize;
        private System.Windows.Forms.Panel panelCommands2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboDiffADCGain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboSigADCGain;
    }
}

