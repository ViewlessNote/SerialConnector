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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(260, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(134, 260);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.Click_Panel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 59);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(69, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 59);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(3, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 59);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(69, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 59);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(3, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 59);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Location = new System.Drawing.Point(69, 133);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 59);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Location = new System.Drawing.Point(3, 198);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(60, 59);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Location = new System.Drawing.Point(69, 198);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(60, 59);
            this.panel8.TabIndex = 5;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel24.Location = new System.Drawing.Point(69, 198);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(60, 59);
            this.panel24.TabIndex = 5;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel23.Location = new System.Drawing.Point(3, 198);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(60, 59);
            this.panel23.TabIndex = 4;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel22.Location = new System.Drawing.Point(69, 133);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(60, 59);
            this.panel22.TabIndex = 3;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel21.Location = new System.Drawing.Point(3, 133);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(60, 59);
            this.panel21.TabIndex = 2;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel20.Location = new System.Drawing.Point(69, 68);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(60, 59);
            this.panel20.TabIndex = 3;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel19.Location = new System.Drawing.Point(3, 68);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(60, 59);
            this.panel19.TabIndex = 2;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel18.Location = new System.Drawing.Point(69, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(60, 59);
            this.panel18.TabIndex = 1;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(60, 59);
            this.panel17.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.panel17);
            this.flowLayoutPanel3.Controls.Add(this.panel18);
            this.flowLayoutPanel3.Controls.Add(this.panel19);
            this.flowLayoutPanel3.Controls.Add(this.panel20);
            this.flowLayoutPanel3.Controls.Add(this.panel21);
            this.flowLayoutPanel3.Controls.Add(this.panel22);
            this.flowLayoutPanel3.Controls.Add(this.panel23);
            this.flowLayoutPanel3.Controls.Add(this.panel24);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(540, 116);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(134, 260);
            this.flowLayoutPanel3.TabIndex = 6;
            this.flowLayoutPanel3.Click += new System.EventHandler(this.Click_Panel);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel16.Location = new System.Drawing.Point(69, 198);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(60, 59);
            this.panel16.TabIndex = 5;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel15.Location = new System.Drawing.Point(3, 198);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(60, 59);
            this.panel15.TabIndex = 4;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel14.Location = new System.Drawing.Point(69, 133);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(60, 59);
            this.panel14.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel13.Location = new System.Drawing.Point(3, 133);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(60, 59);
            this.panel13.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel12.Location = new System.Drawing.Point(69, 68);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(60, 59);
            this.panel12.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Location = new System.Drawing.Point(3, 68);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(60, 59);
            this.panel11.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.Location = new System.Drawing.Point(69, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(60, 59);
            this.panel10.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(60, 59);
            this.panel9.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel9);
            this.flowLayoutPanel2.Controls.Add(this.panel10);
            this.flowLayoutPanel2.Controls.Add(this.panel11);
            this.flowLayoutPanel2.Controls.Add(this.panel12);
            this.flowLayoutPanel2.Controls.Add(this.panel13);
            this.flowLayoutPanel2.Controls.Add(this.panel14);
            this.flowLayoutPanel2.Controls.Add(this.panel15);
            this.flowLayoutPanel2.Controls.Add(this.panel16);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(400, 116);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(134, 260);
            this.flowLayoutPanel2.TabIndex = 6;
            this.flowLayoutPanel2.Click += new System.EventHandler(this.Click_Panel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

