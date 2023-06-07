namespace NGUOI_BAN
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.head = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.getkey = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.ip = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.contract = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Panel();
            this.right = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.head.SuspendLayout();
            this.body.SuspendLayout();
            this.right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(917, 424);
            this.textBox.TabIndex = 0;
            // 
            // head
            // 
            this.head.Controls.Add(this.button1);
            this.head.Controls.Add(this.getkey);
            this.head.Controls.Add(this.add);
            this.head.Controls.Add(this.save);
            this.head.Controls.Add(this.disconnect);
            this.head.Controls.Add(this.connect);
            this.head.Controls.Add(this.ip);
            this.head.Controls.Add(this.port);
            this.head.Controls.Add(this.contract);
            this.head.Controls.Add(this.send);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(917, 120);
            this.head.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "temp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // getkey
            // 
            this.getkey.Location = new System.Drawing.Point(776, 31);
            this.getkey.Name = "getkey";
            this.getkey.Size = new System.Drawing.Size(129, 37);
            this.getkey.TabIndex = 1;
            this.getkey.Text = "lấy key";
            this.getkey.UseVisualStyleBackColor = true;
            this.getkey.Click += new System.EventHandler(this.getkey_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(624, 74);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(146, 40);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(453, 74);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(150, 40);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(166, 82);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(102, 32);
            this.disconnect.TabIndex = 4;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(166, 46);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(102, 30);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(12, 12);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(331, 22);
            this.ip.TabIndex = 3;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(12, 46);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 22);
            this.port.TabIndex = 2;
            // 
            // contract
            // 
            this.contract.Location = new System.Drawing.Point(453, 31);
            this.contract.Name = "contract";
            this.contract.Size = new System.Drawing.Size(150, 37);
            this.contract.TabIndex = 1;
            this.contract.Text = "Hợp đồng";
            this.contract.UseVisualStyleBackColor = true;
            this.contract.Click += new System.EventHandler(this.button1_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(624, 31);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(146, 37);
            this.send.TabIndex = 0;
            this.send.Text = "Gửi";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // body
            // 
            this.body.Controls.Add(this.textBox);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 120);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(917, 424);
            this.body.TabIndex = 0;
            // 
            // right
            // 
            this.right.Controls.Add(this.dataGridView);
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(638, 120);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(279, 424);
            this.right.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(279, 424);
            this.dataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 544);
            this.Controls.Add(this.right);
            this.Controls.Add(this.body);
            this.Controls.Add(this.head);
            this.Name = "Form1";
            this.Text = "Form1";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Button contract;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel right;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button getkey;
        public System.Windows.Forms.Button button1;
    }
}

