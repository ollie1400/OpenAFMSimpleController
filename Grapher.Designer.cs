namespace simpleController
{
    partial class Grapher
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboSource1 = new System.Windows.Forms.ComboBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboSource2 = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textValue1 = new System.Windows.Forms.TextBox();
            this.textValue2 = new System.Windows.Forms.TextBox();
            this.checkConvert1 = new System.Windows.Forms.CheckBox();
            this.checkConvert2 = new System.Windows.Forms.CheckBox();
            this.numericConvertMax = new System.Windows.Forms.NumericUpDown();
            this.numericConvertMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConvertMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConvertMin)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(22, 35);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(608, 246);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboSource1
            // 
            this.comboSource1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSource1.FormattingEnabled = true;
            this.comboSource1.Location = new System.Drawing.Point(196, 574);
            this.comboSource1.Name = "comboSource1";
            this.comboSource1.Size = new System.Drawing.Size(121, 21);
            this.comboSource1.TabIndex = 2;
            this.comboSource1.SelectedIndexChanged += new System.EventHandler(this.comboSource1_SelectedIndexChanged);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(25, 572);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(106, 572);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboSource2
            // 
            this.comboSource2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSource2.FormattingEnabled = true;
            this.comboSource2.Location = new System.Drawing.Point(332, 574);
            this.comboSource2.Name = "comboSource2";
            this.comboSource2.Size = new System.Drawing.Size(121, 21);
            this.comboSource2.TabIndex = 5;
            this.comboSource2.SelectedIndexChanged += new System.EventHandler(this.comboSource2_SelectedIndexChanged);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(25, 313);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(608, 246);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // textValue1
            // 
            this.textValue1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textValue1.Location = new System.Drawing.Point(22, 9);
            this.textValue1.Name = "textValue1";
            this.textValue1.ReadOnly = true;
            this.textValue1.Size = new System.Drawing.Size(100, 20);
            this.textValue1.TabIndex = 7;
            // 
            // textValue2
            // 
            this.textValue2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textValue2.Location = new System.Drawing.Point(25, 287);
            this.textValue2.Name = "textValue2";
            this.textValue2.ReadOnly = true;
            this.textValue2.Size = new System.Drawing.Size(100, 20);
            this.textValue2.TabIndex = 8;
            // 
            // checkConvert1
            // 
            this.checkConvert1.AutoSize = true;
            this.checkConvert1.Location = new System.Drawing.Point(129, 11);
            this.checkConvert1.Name = "checkConvert1";
            this.checkConvert1.Size = new System.Drawing.Size(85, 17);
            this.checkConvert1.TabIndex = 9;
            this.checkConvert1.Text = "Convert to V";
            this.checkConvert1.UseVisualStyleBackColor = true;
            this.checkConvert1.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // checkConvert2
            // 
            this.checkConvert2.AutoSize = true;
            this.checkConvert2.Location = new System.Drawing.Point(131, 290);
            this.checkConvert2.Name = "checkConvert2";
            this.checkConvert2.Size = new System.Drawing.Size(85, 17);
            this.checkConvert2.TabIndex = 10;
            this.checkConvert2.Text = "Convert to V";
            this.checkConvert2.UseVisualStyleBackColor = true;
            this.checkConvert2.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // numericConvertMax
            // 
            this.numericConvertMax.Location = new System.Drawing.Point(333, 8);
            this.numericConvertMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericConvertMax.Name = "numericConvertMax";
            this.numericConvertMax.Size = new System.Drawing.Size(93, 20);
            this.numericConvertMax.TabIndex = 11;
            this.numericConvertMax.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // numericConvertMin
            // 
            this.numericConvertMin.Location = new System.Drawing.Point(242, 8);
            this.numericConvertMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericConvertMin.Name = "numericConvertMin";
            this.numericConvertMin.Size = new System.Drawing.Size(85, 20);
            this.numericConvertMin.TabIndex = 12;
            this.numericConvertMin.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // Grapher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 622);
            this.Controls.Add(this.numericConvertMin);
            this.Controls.Add(this.numericConvertMax);
            this.Controls.Add(this.checkConvert2);
            this.Controls.Add(this.checkConvert1);
            this.Controls.Add(this.textValue2);
            this.Controls.Add(this.textValue1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.comboSource2);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.comboSource1);
            this.Controls.Add(this.chart1);
            this.Name = "Grapher";
            this.Text = "Grapher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Grapher_FormClosing);
            this.Load += new System.EventHandler(this.Grapher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConvertMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConvertMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboSource1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboSource2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox textValue1;
        private System.Windows.Forms.TextBox textValue2;
        private System.Windows.Forms.CheckBox checkConvert1;
        private System.Windows.Forms.CheckBox checkConvert2;
        private System.Windows.Forms.NumericUpDown numericConvertMax;
        private System.Windows.Forms.NumericUpDown numericConvertMin;
    }
}