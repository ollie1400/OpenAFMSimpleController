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
            this.trackVCz = new System.Windows.Forms.TrackBar();
            this.textSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.checkReply = new System.Windows.Forms.CheckBox();
            this.checkEcho = new System.Windows.Forms.CheckBox();
            this.trackVCtasd = new System.Windows.Forms.TrackBar();
            this.textMask = new System.Windows.Forms.TextBox();
            this.trackVCt = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCtasd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCt)).BeginInit();
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
            this.textComms.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textComms.Location = new System.Drawing.Point(320, 13);
            this.textComms.Multiline = true;
            this.textComms.Name = "textComms";
            this.textComms.ReadOnly = true;
            this.textComms.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textComms.Size = new System.Drawing.Size(451, 309);
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
            this.buttonGrapher.Location = new System.Drawing.Point(3, 489);
            this.buttonGrapher.Name = "buttonGrapher";
            this.buttonGrapher.Size = new System.Drawing.Size(123, 57);
            this.buttonGrapher.TabIndex = 5;
            this.buttonGrapher.Text = "Open Grapher";
            this.buttonGrapher.UseVisualStyleBackColor = true;
            this.buttonGrapher.Click += new System.EventHandler(this.buttonGrapher_Click);
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.button1);
            this.panelCommands.Controls.Add(this.label4);
            this.panelCommands.Controls.Add(this.label3);
            this.panelCommands.Controls.Add(this.label2);
            this.panelCommands.Controls.Add(this.label1);
            this.panelCommands.Controls.Add(this.trackVCt);
            this.panelCommands.Controls.Add(this.textMask);
            this.panelCommands.Controls.Add(this.trackVCtasd);
            this.panelCommands.Controls.Add(this.trackVCz);
            this.panelCommands.Controls.Add(this.textSend);
            this.panelCommands.Controls.Add(this.buttonSend);
            this.panelCommands.Controls.Add(this.checkReply);
            this.panelCommands.Controls.Add(this.checkEcho);
            this.panelCommands.Controls.Add(this.buttonReadSig);
            this.panelCommands.Controls.Add(this.buttonGrapher);
            this.panelCommands.Controls.Add(this.buttonPing);
            this.panelCommands.Location = new System.Drawing.Point(13, 52);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(289, 546);
            this.panelCommands.TabIndex = 6;
            // 
            // trackVCz
            // 
            this.trackVCz.Location = new System.Drawing.Point(18, 173);
            this.trackVCz.Maximum = 65535;
            this.trackVCz.Name = "trackVCz";
            this.trackVCz.Size = new System.Drawing.Size(256, 45);
            this.trackVCz.TabIndex = 10;
            this.trackVCz.Scroll += new System.EventHandler(this.trackVCz_Scroll);
            // 
            // textSend
            // 
            this.textSend.Location = new System.Drawing.Point(18, 108);
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(205, 20);
            this.textSend.TabIndex = 9;
            this.textSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSend_KeyDown);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(229, 108);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(57, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
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
            // trackVCtasd
            // 
            this.trackVCtasd.Location = new System.Drawing.Point(18, 361);
            this.trackVCtasd.Maximum = 65535;
            this.trackVCtasd.Name = "trackVCtasd";
            this.trackVCtasd.Size = new System.Drawing.Size(256, 45);
            this.trackVCtasd.TabIndex = 11;
            this.trackVCtasd.Scroll += new System.EventHandler(this.trackVCt_Scroll);
            // 
            // textMask
            // 
            this.textMask.Location = new System.Drawing.Point(199, 335);
            this.textMask.Name = "textMask";
            this.textMask.Size = new System.Drawing.Size(63, 20);
            this.textMask.TabIndex = 12;
            this.textMask.Text = "15";
            // 
            // trackVCt
            // 
            this.trackVCt.Location = new System.Drawing.Point(18, 237);
            this.trackVCt.Maximum = 65535;
            this.trackVCt.Name = "trackVCt";
            this.trackVCt.Size = new System.Drawing.Size(256, 45);
            this.trackVCt.TabIndex = 13;
            this.trackVCt.Scroll += new System.EventHandler(this.trackVCt_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Focus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Track";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Piezo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Channel mask:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 589);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackVCz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCtasd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVCt)).EndInit();
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
    }
}

