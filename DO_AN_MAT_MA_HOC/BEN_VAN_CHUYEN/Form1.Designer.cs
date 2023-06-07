namespace BEN_VAN_CHUYEN
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
            this.start = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.choosefile = new System.Windows.Forms.Button();
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            this.signPdfFile = new System.Windows.Forms.Button();
            this.extractSignatureFromPdfFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(72, 60);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 22);
            this.port.TabIndex = 0;
            this.port.Text = "8080";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(229, 60);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(419, 60);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 2;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "server: nguyen duc vuong";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(229, 89);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 4;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(341, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 22);
            this.textBox2.TabIndex = 5;
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(80, 125);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 23);
            this.encrypt.TabIndex = 6;
            this.encrypt.Text = "encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 373);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(364, 130);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(419, 373);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(366, 130);
            this.textBox4.TabIndex = 8;
            // 
            // choosefile
            // 
            this.choosefile.Location = new System.Drawing.Point(709, 279);
            this.choosefile.Name = "choosefile";
            this.choosefile.Size = new System.Drawing.Size(131, 23);
            this.choosefile.TabIndex = 10;
            this.choosefile.Text = "choosefile";
            this.choosefile.UseVisualStyleBackColor = true;
            this.choosefile.Click += new System.EventHandler(this.choosefile_Click);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer1.FormFillEnabled = false;
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = true;
            this.pdfViewer1.Location = new System.Drawing.Point(29, 195);
            this.pdfViewer1.MultiPagesThreshold = 60;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OnRenderPageExceptionEvent = null;
            this.pdfViewer1.Size = new System.Drawing.Size(654, 308);
            this.pdfViewer1.TabIndex = 12;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.Threshold = 60;
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // signPdfFile
            // 
            this.signPdfFile.Location = new System.Drawing.Point(645, 103);
            this.signPdfFile.Name = "signPdfFile";
            this.signPdfFile.Size = new System.Drawing.Size(140, 23);
            this.signPdfFile.TabIndex = 13;
            this.signPdfFile.Text = "signPdfFile";
            this.signPdfFile.UseVisualStyleBackColor = true;
            this.signPdfFile.Click += new System.EventHandler(this.signPdfFile_Click);
            // 
            // extractSignatureFromPdfFile
            // 
            this.extractSignatureFromPdfFile.Location = new System.Drawing.Point(629, 152);
            this.extractSignatureFromPdfFile.Name = "extractSignatureFromPdfFile";
            this.extractSignatureFromPdfFile.Size = new System.Drawing.Size(211, 23);
            this.extractSignatureFromPdfFile.TabIndex = 14;
            this.extractSignatureFromPdfFile.Text = "extractSignatureFromPdfFile";
            this.extractSignatureFromPdfFile.UseVisualStyleBackColor = true;
            this.extractSignatureFromPdfFile.Click += new System.EventHandler(this.extractSignatureFromPdfFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 515);
            this.Controls.Add(this.extractSignatureFromPdfFile);
            this.Controls.Add(this.signPdfFile);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.choosefile);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.start);
            this.Controls.Add(this.port);
            this.Name = "Form1";
            this.Text = "BEN_VAN_CHUYEN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button choosefile;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
        private System.Windows.Forms.Button signPdfFile;
        private System.Windows.Forms.Button extractSignatureFromPdfFile;
    }
}

