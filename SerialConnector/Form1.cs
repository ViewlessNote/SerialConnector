using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialConnector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                Serial_Connect_Box.Items.Add(port);
            }
            Serial_Connect_Box.SelectedIndex = 0;
        }

        StreamWriter sw = new StreamWriter("Logs.log");

        private void Connect_Disconnect_btn_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = Serial_Connect_Box.Text;
                serialPort1.Open();
                Connect_Disconnect_btn.Text = "Disconnect";
                //Hir den Thread Starten der Lesen soll; 
            }
            else {                 
                serialPort1.Close();
                Connect_Disconnect_btn.Text = "Connect";
            }
        }

        private void Form1_Load(object sender, EventArgs e) {      

        }

        private void output_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void input_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(input_box.Text);
            }else
            {
                MessageBox.Show("Serial Port is closed: PS Start the Port !!!");
            }
        }
        private void Click_Panel(object sender, EventArgs e)
        {
            try{
                Panel p = (Panel)sender;

                string s = p.Name.Substring(1);
                if (p.BackColor == Color.Olive)
                {
                    p.BackColor = Color.Salmon;
                    s = "unsetLED " + s;
                }
                else
                {
                    p.BackColor = Color.Olive;
                    s = "setLED " + s;
                }
                serialPort1.WriteLine(s);
            }
            catch
                (Exception ex) {  MessageBox.Show(ex.Message); }
        }

        private void Serial_Connect_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_leds_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("rst");
           for (int i = 0; i < 24; i++)
            {
                try
                {
                    Panel p = (Panel)this.Controls.Find("p" + i.ToString(), true).First();
                    if (p != null)
                    {
                        p.BackColor = Color.Salmon;
                    }
                }
                catch { }
            }
        }
    }
}
