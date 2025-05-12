using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }
    }
}
