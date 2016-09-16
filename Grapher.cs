using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleController
{
    public partial class Grapher : Form
    {
        Form1 parent;
        SerialPort port;
        ManualResetEvent end;
        Thread sampler;
        bool quitsampler = false;
        int samplerSleep = 100;
        int commandIndex1 = 0;
        int commandIndex2 = 0;
        bool convert1 = false;
        bool convert2 = false;
        int adcMin = 0;
        int adcMax = 0;

        double graphMax1 = double.MinValue;
        double graphMax2 = double.MinValue;
        double graphMin1 = double.MaxValue;
        double graphMin2 = double.MaxValue;

        string[] signals =
        {
            "A-B",
            "C-D",
            "SUM",
            "A",
            "B",
            "C",
            "D"
        };
        string[] commands =
        {
            "DIFFADC::GET 0;",
            "DIFFADC::GET 1;",
            "DIFFADC::GET 2;",
            "SIGADC::GET 0;",
            "SIGADC::GET 1;",
            "SIGADC::GET 2;",
            "SIGADC::GET 3;"
        };

        public Grapher(Form1 parent, SerialPort port)
        {
            this.parent = parent;
            this.port = port;
            InitializeComponent();
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            end = new ManualResetEvent(false);

            numericConvertMin.Value = 0;
            numericConvertMax.Value = 1664;

            parent.RegisterListener(false);


        }

        private void Grapher_Load(object sender, EventArgs e)
        {
            comboSource1.Items.AddRange(signals);
            comboSource2.Items.AddRange(signals);
            comboSource1.SelectedIndex = 0;
            comboSource2.SelectedIndex = 0;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (sampler == null)
            {
                sampler = new Thread((ThreadStart)sample);
                quitsampler = false;
                sampler.Start();
                buttonGo.Text = "Stop";
            }
            else
            {
                quitsampler = true;
                //end.WaitOne();
                end.Reset();
                sampler = null;
                buttonGo.Text = "Go";
            }
        }

        void sample()
        {
            string toSend1;
            string toSend2;
            string response;
            double point1;
            double point2;
            bool parsed1;
            bool parsed2;
            try {

                while (!quitsampler)
                {
                    toSend1 = commands[commandIndex1];
                    toSend2 = commands[commandIndex2];

                    lock(port)
                    {
                        port.Write(toSend1);
                        response = port.ReadLine();
                        //response = parent.ReadLine();
                    }
                    parsed1 = Double.TryParse(response, out point1);
                    Console.WriteLine(response);

                    lock (port)
                    {
                        port.Write(toSend2);
                        response = port.ReadLine();
                        //response = parent.ReadLine();
                    }
                    parsed2 = Double.TryParse(response, out point2);
                    Console.WriteLine(response);

                    // convert?
                    if (convert1)
                    {
                        point1 = 5.0 * (point1 - adcMin) / (adcMax - adcMin);
                    }
                    if (convert2)
                    {
                        point2 = 5.0 * (point2 - adcMin) / (adcMax - adcMin);
                    }

                    Invoke((Action)(() =>
                        {
                            if (parsed1) chart1.Series[0].Points.Add(point1);
                            if (point1 > graphMax1) graphMax1 = point1;
                            if (point1 < graphMin1) graphMin1 = point1;

                            if (parsed2) chart2.Series[0].Points.Add(point2);
                            if (point2 > graphMax2) graphMax2 = point2;
                            if (point2 < graphMin2) graphMin2 = point2;

                            chart1.ChartAreas[0].AxisY.Maximum = graphMax1;
                            chart1.ChartAreas[0].AxisY.Minimum = (graphMax1 == graphMin1 ? graphMin1 - 1 : graphMin1);

                            chart2.ChartAreas[0].AxisY.Maximum = graphMax2;
                            chart2.ChartAreas[0].AxisY.Minimum = (graphMax2 == graphMin2 ? graphMin2 - 1 : graphMin2);

                            textValue1.Text = convert1 ? point1.ToString("F3") : point1.ToString("F0");
                            textValue2.Text = convert2 ? point2.ToString("F3") : point2.ToString("F0");
                        }));

                    Thread.Sleep(samplerSleep);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            end.Set();
        }

        private void comboSource1_SelectedIndexChanged(object sender, EventArgs e)
        {
            commandIndex1 = comboSource1.SelectedIndex;
        }

        private void comboSource2_SelectedIndexChanged(object sender, EventArgs e)
        {
            commandIndex2 = comboSource2.SelectedIndex;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();

            graphMax1 = double.MinValue;
            graphMax2 = double.MinValue;
            graphMin1 = double.MaxValue;
            graphMin2 = double.MaxValue;
        }

        private void Grapher_FormClosing(object sender, FormClosingEventArgs e)
        {
            quitsampler = true;
            //end.WaitOne();
            end.Reset();
            sampler = null;

            parent.RegisterListener(true);
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            buttonClear.PerformClick();
            if (sender == checkConvert1)
            {
                convert1 = checkConvert1.Checked;
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = (convert1 ? "F3" : "F0");
            }
            if (sender == checkConvert2)
            {
                convert2 = checkConvert2.Checked;
                chart2.ChartAreas[0].AxisY.LabelStyle.Format = (convert2 ? "F3" : "F0");
            }
        }
        
        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            if (sender == numericConvertMin)
            {
                adcMin = (int)numericConvertMin.Value;
            } else if (sender == numericConvertMax)
            {
                adcMax = (int)numericConvertMax.Value;
            }
        }
    }
}
