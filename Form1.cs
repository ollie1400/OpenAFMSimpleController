using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleController
{
    public partial class Form1 : Form
    {
        SerialPort port;
        Grapher grapher;

        int bufferLength = 2048;
        byte[] serialBuffer;
        int bytesToRead;

        public byte[] ReadBytes(int numBytes)
        {
            int num = Math.Min(numBytes, bytesToRead);
            byte[] ret = new byte[num];
            Array.Copy(serialBuffer, 0, ret, 0, num);
            if (num < bytesToRead)
            {
                Array.Copy(serialBuffer, num, serialBuffer, 0, bytesToRead - num);
                bytesToRead = bytesToRead - num;
            }
            return ret;
        }

        public string ReadLine()
        {
            // search for end of line
            int i;
            bool found = false;
            for (i=0; i< bytesToRead; i++)
            {
                if (serialBuffer[i] == (char)'\r')
                {
                    found = true;
                    break;
                }
            }
            if (!found) return null;

            // skip \c if it's also there
            int numTerm = 1;
            if (i + 1 < bytesToRead && serialBuffer[i + 1] == 10)
            {
                i += 1;
                numTerm = 2;
            }
            byte[] part = ReadBytes(i + 1);
            // remove last two
            return Encoding.ASCII.GetString(part, 0, i - numTerm + 1);
        }



        public Form1()
        {
            port = null;
            InitializeComponent();
            panelCommands.Enabled = false;
            panelCommands2.Enabled = false;

            comboSigADCGain.SelectedIndex = 0;
            comboDiffADCGain.SelectedIndex = 0;

            serialBuffer = new byte[bufferLength];
            bytesToRead = 0;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {

                if (port == null)
                {
                    port = new SerialPort("COM" + numericPort.Value, 115200);
                    port.Open();
                    port.DiscardInBuffer();

                    port.DataReceived += Port_DataReceived;

                    buttonConnect.Text = "Disconnect";
                    panelCommands.Enabled = true;
                    panelCommands2.Enabled = true;

                    SetEcho(false);
                    SetReply(false);
                } else
                {
                    port.Close();
                    port = null;
                    buttonConnect.Text = "Connect";
                    panelCommands.Enabled = false;
                    panelCommands2.Enabled = false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (port.IsOpen) port.Close();
                port = null;
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int btr;
            byte[] buffer;

            //lock(port)
            //{
                btr = port.BytesToRead;
                buffer = new byte[btr];
                port.Read(buffer, 0, btr);

                // copy to input buffer
                //Array.Copy(buffer, 0, serialBuffer, bytesToRead, btr);
                //bytesToRead += btr;
            //}

            Invoke((Action)(() =>
            {
                textComms.AppendText(Encoding.ASCII.GetString(buffer));
            }));
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            lock(port) port.Write("PING;");
        }

        private void buttonReadSig_Click(object sender, EventArgs e)
        {
            lock (port) port.Write("SIG?;");
        }

        private void buttonGrapher_Click(object sender, EventArgs e)
        {
            //lock (port) port.DataReceived -= Port_DataReceived;

            if (grapher == null || grapher.IsDisposed) grapher = new Grapher(this, port);
            grapher.Show();

            //lock (port) port.DataReceived += Port_DataReceived;
        }

        public void RegisterListener(bool register)
        {
            try
            {
                if (register)
                {
                    port.DataReceived += Port_DataReceived;
                }
                else
                {
                    port.DataReceived -= Port_DataReceived;
                }
            }
            catch (Exception ex)
            { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SetEcho(bool on)
        {
            lock (port) port.Write("ECHO " + (on ? "1;" : "0;"));
        }
        public void SetReply(bool on)
        {
            lock (port) port.Write("REPLY " + (on ? "1;" : "0;"));
        }

        private void checkEcho_CheckedChanged(object sender, EventArgs e)
        {
            SetEcho(checkEcho.Checked);
        }

        private void checkReply_CheckedChanged(object sender, EventArgs e)
        {
            SetReply(checkReply.Checked);
        }

        List<string> sendHistory = new List<string>();
        int historyIndex = -1;
        private void buttonSend_Click(object sender, EventArgs e)
        {
            string str = textSend.Text;
            lock (port) port.Write(str);
            sendHistory.Add(str);
        }

        private void textSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                historyIndex = historyIndex > 0 ? historyIndex - 1 : 0;
                if (historyIndex < sendHistory.Count && historyIndex >= 0) textSend.Text = sendHistory[sendHistory.Count - 1 - historyIndex];
            }
            else if (e.KeyCode == Keys.Up)
            {
                historyIndex = historyIndex < sendHistory.Count - 1 ? historyIndex + 1 : sendHistory.Count - 1;
                if (historyIndex < sendHistory.Count && historyIndex >= 0) textSend.Text = sendHistory[sendHistory.Count - 1 - historyIndex];
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonSend.PerformClick();
            }
            else
            {
                historyIndex = -1;
            }
        }

        bool sentFromtrackVCz = false;
        private void trackVCz_Scroll(object sender, EventArgs e)
        {
            sentFromtrackVCz = true;
            double min = trackVCz.Minimum;
            double max = trackVCz.Maximum;
            double val = trackVCz.Value;
            double voltage = 5.0 * (val - min) / (max - min);
            //lock (port) port.Write("VCDAC::SET 8 " + voltage.ToString("F4") + ";");
            lock (port) port.Write("VCDAC::SETV 8 " + val + ";");
            numericFocusCurrent.Value = trackVCz.Value;
            sentFromtrackVCz = false;
        }

        private void trackVCt_Scroll_1(object sender, EventArgs e)
        {
            double min = trackVCt.Minimum;
            double max = trackVCt.Maximum;
            double val = trackVCt.Value;
            double voltage = 5.0 * (val - min) / (max - min);
            lock (port) port.Write("VCDAC::SET 1 " + voltage.ToString("F4") + ";");
        }

        private void trackVCt_Scroll(object sender, EventArgs e)
        {
            double min = trackVCtasd.Minimum;
            double max = trackVCtasd.Maximum;
            double val = trackVCtasd.Value;
            double voltage = 5.0 * (val - min) / (max - min);
            lock (port) port.Write("PZDAC::SET " + textMask.Text + " " + voltage.ToString("F4") + ";");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = ReadLine();
        }

        bool sentFromNumeric = false;
        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            sentFromNumeric = true;
            if (sender == numericFocusMin)
            {
                trackVCz.Minimum = (int)numericFocusMin.Value;
            }
            else if (sender == numericFocusMax)
            {
                trackVCz.Maximum = (int)numericFocusMax.Value;
            }
            else if (sender == numericFocusCurrent)
            {
                if (!sentFromtrackVCz) trackVCz.Value = (int)numericFocusCurrent.Value;
            }
            sentFromNumeric = false;
        }

        private void buttonSendSetup_Click(object sender, EventArgs e)
        {
            try
            {
                lock (port)
                {
                    port.Write("SETUP;");
                    port.Write("" + numericStepSize.Value + ";");
                    port.Write("" + numericLineLength.Value + ";");
                    port.Write("" + numericSampleSize.Value + ";");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textComms.Text = "";
        }

        private void combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (sender == comboSigADCGain)
            {
                lock (port) port.Write("SIGADC::GAIN " + comboSigADCGain.SelectedIndex + ";");
            }
            else if (sender == comboDiffADCGain)
            {
                lock (port) port.Write("DIFFADC::GAIN " + comboDiffADCGain.SelectedIndex + ";");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (grapher != null && !grapher.IsDisposed) grapher.Close();
        }


        // move the stage
        int posX = 0;
        int posY = 0;
        int posZ = 0;
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string msg = "GOTO";
            int steps = 0;

            // X
            if (sender == buttonMoveXPlus)
            {
                steps = (int)numericXSteps.Value;
                msg += "X " + steps + ";";
                posX += steps;
            }
            else if (sender == buttonMoveXMinus)
            {
                steps = -(int)numericXSteps.Value;
                msg += "X " + steps + ";";
                posX += steps;
            }

            // Y
            else if (sender == buttonMoveYPlus)
            {
                steps = (int)numericYSteps.Value;
                msg += "Y " + steps + ";";
                posY += steps;
            }
            else if (sender == buttonMoveYMinus)
            {
                steps = -(int)numericYSteps.Value;
                msg += "Y " + steps + ";";
                posY += steps;
            }

            // Z
            else if (sender == buttonMoveZPlus)
            {
                steps = (int)numericZSteps.Value;
                msg += "Z " + steps + ";";
                posZ += steps;
            }
            else if (sender == buttonMoveZMinus)
            {
                steps = -(int)numericZSteps.Value;
                msg += "Z " + steps + ";";
                posZ += steps;
            }
            
            //lock(port) port.Write(msg);
            lock (port)
            {
                port.Write("GOTO;");
                port.Write("" + posX + ";");
                port.Write("" + posY + ";");
                port.Write("" + posZ + ";");
            }

            if (checkGetPosAfterMove.Checked) buttonGetPos.PerformClick();
        }

        private void buttonGetPos_Click(object sender, EventArgs e)
        {
            lock (port)
            {
                port.Write("POS? 1;");
                port.Write("POS? 2;");
                port.Write("POS? 3;");
            }
        }
    }
}
