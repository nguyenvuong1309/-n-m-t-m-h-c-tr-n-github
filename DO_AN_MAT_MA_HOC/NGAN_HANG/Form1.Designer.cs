namespace NGAN_HANG
{
    partial class Form1
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
            this.port = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.verify = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(61, 33);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 22);
            this.port.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.verify);
            this.panel1.Controls.Add(this.send);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.sign);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.port);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 116);
            this.panel1.TabIndex = 1;
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(387, 60);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(93, 34);
            this.verify.TabIndex = 6;
            this.verify.Text = "verify";
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(504, 33);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(104, 31);
            this.send.TabIndex = 4;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(223, 61);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(105, 33);
            this.stop.TabIndex = 3;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(387, 23);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(93, 31);
            this.sign.TabIndex = 0;
            this.sign.Text = "Sign";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(223, 23);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(105, 32);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 334);
            this.panel2.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(800, 334);
            this.textBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button verify;
    }
}

