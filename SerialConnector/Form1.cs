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

namespace SerialConnector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            
            System.Drawing.Rectangle workingRectangel = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(Convert.ToInt32( 0.5 * workingRectangel.Width), Convert.ToInt32(0.5 * workingRectangel.Height));
            this.Location = new System.Drawing.Point(10,10);
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
            Panel p = (Panel)sender;
            

        }

        private void Serial_Connect_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
