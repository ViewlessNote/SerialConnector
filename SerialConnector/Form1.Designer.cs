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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.output_box = new System.Windows.Forms.ListBox();
            this.input_box = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // 
            // output_box
            // 
            this.output_box.FormattingEnabled = true;
            this.output_box.Location = new System.Drawing.Point(235, 28);
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(542, 381);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.Serial_Connect_Box);
            this.Controls.Add(this.Connect_Disconnect_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
    }
}

