namespace SerialConnector
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Connect_Disconnect_btn = new System.Windows.Forms.Button();
            this.Serial_Connect_Box = new System.Windows.Forms.ComboBox();
            this.output_box = new System.Windows.Forms.ListBox();
            this.input_box = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.p23 = new System.Windows.Forms.Panel();
            this.p19 = new System.Windows.Forms.Panel();
            this.p22 = new System.Windows.Forms.Panel();
            this.p18 = new System.Windows.Forms.Panel();
            this.p21 = new System.Windows.Forms.Panel();
            this.p17 = new System.Windows.Forms.Panel();
            this.p20 = new System.Windows.Forms.Panel();
            this.p16 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.p0 = new System.Windows.Forms.Panel();
            this.p4 = new System.Windows.Forms.Panel();
            this.p1 = new System.Windows.Forms.Panel();
            this.p5 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.p6 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.p7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.p8 = new System.Windows.Forms.Panel();
            this.p12 = new System.Windows.Forms.Panel();
            this.p9 = new System.Windows.Forms.Panel();
            this.p13 = new System.Windows.Forms.Panel();
            this.p10 = new System.Windows.Forms.Panel();
            this.p14 = new System.Windows.Forms.Panel();
            this.p11 = new System.Windows.Forms.Panel();
            this.p15 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reset_leds = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect_Disconnect_btn
            // 
            this.Connect_Disconnect_btn.Location = new System.Drawing.Point(139, 12);
            this.Connect_Disconnect_btn.Name = "Connect_Disconnect_btn";
            this.Connect_Disconnect_btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_Disconnect_btn.TabIndex = 0;
            this.Connect_Disconnect_btn.Text = "Connect";
            this.Connect_Disconnect_btn.UseVisualStyleBackColor = true;
            this.Connect_Disconnect_btn.Click += new System.EventHandler(this.Connect_Disconnect_btn_Click);
            // 
            // Serial_Connect_Box
            // 
            this.Serial_Connect_Box.FormattingEnabled = true;
            this.Serial_Connect_Box.Location = new System.Drawing.Point(12, 12);
            this.Serial_Connect_Box.Name = "Serial_Connect_Box";
            this.Serial_Connect_Box.Size = new System.Drawing.Size(121, 21);
            this.Serial_Connect_Box.TabIndex = 1;
            this.Serial_Connect_Box.SelectedIndexChanged += new System.EventHandler(this.Serial_Connect_Box_SelectedIndexChanged);
            // 
            // output_box
            // 
            this.output_box.FormattingEnabled = true;
            this.output_box.Location = new System.Drawing.Point(12, 154);
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(202, 264);
            this.output_box.TabIndex = 2;
            this.output_box.SelectedIndexChanged += new System.EventHandler(this.output_box_SelectedIndexChanged);
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(12, 51);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(202, 58);
            this.input_box.TabIndex = 3;
            this.input_box.Text = "";
            this.input_box.TextChanged += new System.EventHandler(this.input_box_TextChanged);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(12, 116);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(202, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Senden";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.p23);
            this.flowLayoutPanel1.Controls.Add(this.p19);
            this.flowLayoutPanel1.Controls.Add(this.p22);
            this.flowLayoutPanel1.Controls.Add(this.p18);
            this.flowLayoutPanel1.Controls.Add(this.p21);
            this.flowLayoutPanel1.Controls.Add(this.p17);
            this.flowLayoutPanel1.Controls.Add(this.p20);
            this.flowLayoutPanel1.Controls.Add(this.p16);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(260, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(134, 260);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // p23
            // 
            this.p23.BackColor = System.Drawing.Color.Salmon;
            this.p23.Location = new System.Drawing.Point(3, 3);
            this.p23.Name = "p23";
            this.p23.Size = new System.Drawing.Size(60, 59);
            this.p23.TabIndex = 0;
            this.p23.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p19
            // 
            this.p19.BackColor = System.Drawing.Color.Salmon;
            this.p19.Location = new System.Drawing.Point(69, 3);
            this.p19.Name = "p19";
            this.p19.Size = new System.Drawing.Size(60, 59);
            this.p19.TabIndex = 1;
            this.p19.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p22
            // 
            this.p22.BackColor = System.Drawing.Color.Salmon;
            this.p22.Location = new System.Drawing.Point(3, 68);
            this.p22.Name = "p22";
            this.p22.Size = new System.Drawing.Size(60, 59);
            this.p22.TabIndex = 2;
            this.p22.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p18
            // 
            this.p18.BackColor = System.Drawing.Color.Salmon;
            this.p18.Location = new System.Drawing.Point(69, 68);
            this.p18.Name = "p18";
            this.p18.Size = new System.Drawing.Size(60, 59);
            this.p18.TabIndex = 3;
            this.p18.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p21
            // 
            this.p21.BackColor = System.Drawing.Color.Salmon;
            this.p21.Location = new System.Drawing.Point(3, 133);
            this.p21.Name = "p21";
            this.p21.Size = new System.Drawing.Size(60, 59);
            this.p21.TabIndex = 2;
            this.p21.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p17
            // 
            this.p17.BackColor = System.Drawing.Color.Salmon;
            this.p17.Location = new System.Drawing.Point(69, 133);
            this.p17.Name = "p17";
            this.p17.Size = new System.Drawing.Size(60, 59);
            this.p17.TabIndex = 3;
            this.p17.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p20
            // 
            this.p20.BackColor = System.Drawing.Color.Salmon;
            this.p20.Location = new System.Drawing.Point(3, 198);
            this.p20.Name = "p20";
            this.p20.Size = new System.Drawing.Size(60, 59);
            this.p20.TabIndex = 4;
            this.p20.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p16
            // 
            this.p16.BackColor = System.Drawing.Color.Salmon;
            this.p16.Location = new System.Drawing.Point(69, 198);
            this.p16.Name = "p16";
            this.p16.Size = new System.Drawing.Size(60, 59);
            this.p16.TabIndex = 5;
            this.p16.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p0
            // 
            this.p0.BackColor = System.Drawing.Color.Salmon;
            this.p0.Location = new System.Drawing.Point(69, 198);
            this.p0.Name = "p0";
            this.p0.Size = new System.Drawing.Size(60, 59);
            this.p0.TabIndex = 5;
            this.p0.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.Salmon;
            this.p4.Location = new System.Drawing.Point(3, 198);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(60, 59);
            this.p4.TabIndex = 4;
            this.p4.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Salmon;
            this.p1.Location = new System.Drawing.Point(69, 133);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(60, 59);
            this.p1.TabIndex = 3;
            this.p1.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.Color.Salmon;
            this.p5.Location = new System.Drawing.Point(3, 133);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(60, 59);
            this.p5.TabIndex = 2;
            this.p5.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Salmon;
            this.p2.Location = new System.Drawing.Point(69, 68);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(60, 59);
            this.p2.TabIndex = 3;
            this.p2.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p6
            // 
            this.p6.BackColor = System.Drawing.Color.Salmon;
            this.p6.Location = new System.Drawing.Point(3, 68);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(60, 59);
            this.p6.TabIndex = 2;
            this.p6.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Salmon;
            this.p3.Location = new System.Drawing.Point(69, 3);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(60, 59);
            this.p3.TabIndex = 1;
            this.p3.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p7
            // 
            this.p7.BackColor = System.Drawing.Color.Salmon;
            this.p7.Location = new System.Drawing.Point(3, 3);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(60, 59);
            this.p7.TabIndex = 0;
            this.p7.Click += new System.EventHandler(this.Click_Panel);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel3.Controls.Add(this.p7);
            this.flowLayoutPanel3.Controls.Add(this.p3);
            this.flowLayoutPanel3.Controls.Add(this.p6);
            this.flowLayoutPanel3.Controls.Add(this.p2);
            this.flowLayoutPanel3.Controls.Add(this.p5);
            this.flowLayoutPanel3.Controls.Add(this.p1);
            this.flowLayoutPanel3.Controls.Add(this.p4);
            this.flowLayoutPanel3.Controls.Add(this.p0);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(540, 116);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(134, 260);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // p8
            // 
            this.p8.BackColor = System.Drawing.Color.Salmon;
            this.p8.Location = new System.Drawing.Point(69, 198);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(60, 59);
            this.p8.TabIndex = 5;
            this.p8.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p12
            // 
            this.p12.BackColor = System.Drawing.Color.Salmon;
            this.p12.Location = new System.Drawing.Point(3, 198);
            this.p12.Name = "p12";
            this.p12.Size = new System.Drawing.Size(60, 59);
            this.p12.TabIndex = 4;
            this.p12.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p9
            // 
            this.p9.BackColor = System.Drawing.Color.Salmon;
            this.p9.Location = new System.Drawing.Point(69, 133);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(60, 59);
            this.p9.TabIndex = 3;
            this.p9.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p13
            // 
            this.p13.BackColor = System.Drawing.Color.Salmon;
            this.p13.Location = new System.Drawing.Point(3, 133);
            this.p13.Name = "p13";
            this.p13.Size = new System.Drawing.Size(60, 59);
            this.p13.TabIndex = 2;
            this.p13.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p10
            // 
            this.p10.BackColor = System.Drawing.Color.Salmon;
            this.p10.Location = new System.Drawing.Point(69, 68);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(60, 59);
            this.p10.TabIndex = 3;
            this.p10.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p14
            // 
            this.p14.BackColor = System.Drawing.Color.Salmon;
            this.p14.Location = new System.Drawing.Point(3, 68);
            this.p14.Name = "p14";
            this.p14.Size = new System.Drawing.Size(60, 59);
            this.p14.TabIndex = 2;
            this.p14.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p11
            // 
            this.p11.BackColor = System.Drawing.Color.Salmon;
            this.p11.Location = new System.Drawing.Point(69, 3);
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(60, 59);
            this.p11.TabIndex = 1;
            this.p11.Click += new System.EventHandler(this.Click_Panel);
            // 
            // p15
            // 
            this.p15.BackColor = System.Drawing.Color.Salmon;
            this.p15.Location = new System.Drawing.Point(3, 3);
            this.p15.Name = "p15";
            this.p15.Size = new System.Drawing.Size(60, 59);
            this.p15.TabIndex = 0;
            this.p15.Click += new System.EventHandler(this.Click_Panel);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Controls.Add(this.p15);
            this.flowLayoutPanel2.Controls.Add(this.p11);
            this.flowLayoutPanel2.Controls.Add(this.p14);
            this.flowLayoutPanel2.Controls.Add(this.p10);
            this.flowLayoutPanel2.Controls.Add(this.p13);
            this.flowLayoutPanel2.Controls.Add(this.p9);
            this.flowLayoutPanel2.Controls.Add(this.p12);
            this.flowLayoutPanel2.Controls.Add(this.p8);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(400, 116);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(134, 260);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sekunden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Minuten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hours";
            // 
            // btn_reset_leds
            // 
            this.btn_reset_leds.Location = new System.Drawing.Point(599, 379);
            this.btn_reset_leds.Name = "btn_reset_leds";
            this.btn_reset_leds.Size = new System.Drawing.Size(75, 23);
            this.btn_reset_leds.TabIndex = 10;
            this.btn_reset_leds.Text = "Reset LED\'s";
            this.btn_reset_leds.UseVisualStyleBackColor = true;
            this.btn_reset_leds.Click += new System.EventHandler(this.btn_reset_leds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset_leds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.Serial_Connect_Box);
            this.Controls.Add(this.Connect_Disconnect_btn);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Connect_Disconnect_btn;
        private System.Windows.Forms.ComboBox Serial_Connect_Box;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox output_box;
        private System.Windows.Forms.RichTextBox input_box;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel p23;
        private System.Windows.Forms.Panel p19;
        private System.Windows.Forms.Panel p22;
        private System.Windows.Forms.Panel p18;
        private System.Windows.Forms.Panel p21;
        private System.Windows.Forms.Panel p17;
        private System.Windows.Forms.Panel p20;
        private System.Windows.Forms.Panel p16;
        private System.Windows.Forms.Panel p0;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p5;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel p6;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel p7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel p8;
        private System.Windows.Forms.Panel p12;
        private System.Windows.Forms.Panel p9;
        private System.Windows.Forms.Panel p13;
        private System.Windows.Forms.Panel p10;
        private System.Windows.Forms.Panel p14;
        private System.Windows.Forms.Panel p11;
        private System.Windows.Forms.Panel p15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reset_leds;
    }
}

