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
        public Form1()
        {
            port = null;
            InitializeComponent();
            panelCommands.Enabled = false;

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

                    SetEcho(false);
                    SetReply(false);
                } else
                {
                    port.Close();
                    port = null;
                    buttonConnect.Text = "Connect";
                    panelCommands.Enabled = false;
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
            Invoke((Action)(() =>
            {
                int btr = port.BytesToRead;
                byte[] buffer = new byte[btr];
                port.Read(buffer, 0, btr);
                textComms.AppendText(Encoding.ASCII.GetString(buffer));
            }));
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            port.Write("PING;");
        }

        private void buttonReadSig_Click(object sender, EventArgs e)
        {
            port.Write("SIG?;");
        }

        private void buttonGrapher_Click(object sender, EventArgs e)
        {
            port.DataReceived -= Port_DataReceived;

            Grapher grapher = new Grapher(port);
            grapher.ShowDialog();

            port.DataReceived += Port_DataReceived;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SetEcho(bool on)
        {
            port.Write("ECHO " + (on ? "1;" : "0;"));
        }
        public void SetReply(bool on)
        {
            port.Write("REPLY " + (on ? "1;" : "0;"));
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
            port.Write(str);
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

        private void trackVCz_Scroll(object sender, EventArgs e)
        {
            double min = trackVCz.Minimum;
            double max = trackVCz.Maximum;
            double val = trackVCz.Value;
            double voltage = 5.0 * (val - min) / (max - min);
            port.Write("VCDAC::SET 8 " + voltage.ToString("F4") + ";");
        }

        private void trackVCt_Scroll_1(object sender, EventArgs e)
        {
            double min = trackVCt.Minimum;
            double max = trackVCt.Maximum;
            double val = trackVCt.Value;
            double voltage = 5.0 * (val - min) / (max - min);
            port.Write("VCDAC::SET 1 " + voltage.ToString("F4") + ";");
        }

        private void trackVCt_Scroll(object sender, EventArgs e)
        {
            double min = trackVCtasd.Minimum;
            double max = trackVCtasd.Maximum;
            double val = trackVCtasd.Value;
            double voltage = 5.0 * (val - min) / (max - min);
            port.Write("PZDAC::SET " + textMask.Text + " " + voltage.ToString("F4") + ";");
        }
    }
}
