
namespace ThuatToanCanny
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnCanny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrewitt = new System.Windows.Forms.Button();
            this.btnLaplace = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbRed = new System.Windows.Forms.RichTextBox();
            this.rtbGreen = new System.Windows.Forms.RichTextBox();
            this.rtbBlue = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSizeImage = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.picRed = new System.Windows.Forms.PictureBox();
            this.picGreen = new System.Windows.Forms.PictureBox();
            this.picBlue = new System.Windows.Forms.PictureBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(21, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(616, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 329);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mở ảnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSobel
            // 
            this.btnSobel.AutoSize = true;
            this.btnSobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobel.Location = new System.Drawing.Point(463, 90);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(123, 35);
            this.btnSobel.TabIndex = 3;
            this.btnSobel.Text = "Sobel";
            this.btnSobel.UseVisualStyleBackColor = true;
            this.btnSobel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCanny
            // 
            this.btnCanny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanny.Location = new System.Drawing.Point(463, 306);
            this.btnCanny.Name = "btnCanny";
            this.btnCanny.Size = new System.Drawing.Size(123, 32);
            this.btnCanny.TabIndex = 4;
            this.btnCanny.Text = "Canny";
            this.btnCanny.UseVisualStyleBackColor = true;
            this.btnCanny.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Threshold";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtThreshold
            // 
            this.txtThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThreshold.Location = new System.Drawing.Point(557, 354);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(53, 30);
            this.txtThreshold.TabIndex = 6;
            this.txtThreshold.Text = "80";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ảnh nguồn ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(769, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ảnh đích";
            // 
            // btnPrewitt
            // 
            this.btnPrewitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrewitt.Location = new System.Drawing.Point(463, 138);
            this.btnPrewitt.Name = "btnPrewitt";
            this.btnPrewitt.Size = new System.Drawing.Size(123, 30);
            this.btnPrewitt.TabIndex = 10;
            this.btnPrewitt.Text = "Prewitt";
            this.btnPrewitt.UseVisualStyleBackColor = true;
            this.btnPrewitt.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnLaplace
            // 
            this.btnLaplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaplace.Location = new System.Drawing.Point(463, 183);
            this.btnLaplace.Name = "btnLaplace";
            this.btnLaplace.Size = new System.Drawing.Size(123, 31);
            this.btnLaplace.TabIndex = 11;
            this.btnLaplace.Text = "Laplace";
            this.btnLaplace.UseVisualStyleBackColor = true;
            this.btnLaplace.Click += new System.EventHandler(this.btnLaplace_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(923, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = " Lưu ảnh";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(25, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Red";
            // 
            // rtbRed
            // 
            this.rtbRed.Location = new System.Drawing.Point(30, 472);
            this.rtbRed.Name = "rtbRed";
            this.rtbRed.Size = new System.Drawing.Size(324, 143);
            this.rtbRed.TabIndex = 14;
            this.rtbRed.Text = "";
            // 
            // rtbGreen
            // 
            this.rtbGreen.Location = new System.Drawing.Point(372, 472);
            this.rtbGreen.Name = "rtbGreen";
            this.rtbGreen.Size = new System.Drawing.Size(311, 143);
            this.rtbGreen.TabIndex = 15;
            this.rtbGreen.Text = "";
            // 
            // rtbBlue
            // 
            this.rtbBlue.Location = new System.Drawing.Point(705, 472);
            this.rtbBlue.Name = "rtbBlue";
            this.rtbBlue.Size = new System.Drawing.Size(324, 143);
            this.rtbBlue.TabIndex = 16;
            this.rtbBlue.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(367, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Green";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(700, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Blue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kích thước ảnh:";
            // 
            // lblSizeImage
            // 
            this.lblSizeImage.AutoSize = true;
            this.lblSizeImage.Location = new System.Drawing.Point(208, 418);
            this.lblSizeImage.Name = "lblSizeImage";
            this.lblSizeImage.Size = new System.Drawing.Size(24, 17);
            this.lblSizeImage.TabIndex = 20;
            this.lblSizeImage.Text = "....";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHelp.Image = global::ThuatToanCanny.Properties.Resources.Actions_help_about_icon_16;
            this.lblHelp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHelp.Location = new System.Drawing.Point(944, 9);
            this.lblHelp.MinimumSize = new System.Drawing.Size(110, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Padding = new System.Windows.Forms.Padding(0, 0, 30, 10);
            this.lblHelp.Size = new System.Drawing.Size(110, 27);
            this.lblHelp.TabIndex = 21;
            this.lblHelp.Text = "Trợ giúp";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // btnRed
            // 
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(87, 632);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(178, 37);
            this.btnRed.TabIndex = 22;
            this.btnRed.Text = "Ảnh dải màu Đỏ";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGreen.Location = new System.Drawing.Point(433, 632);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(199, 37);
            this.btnGreen.TabIndex = 23;
            this.btnGreen.Text = "Ảnh dải màu Xanh lá";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(754, 632);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(236, 37);
            this.btnBlue.TabIndex = 24;
            this.btnBlue.Text = "Ảnh dải màu Xanh dương";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // picRed
            // 
            this.picRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picRed.Location = new System.Drawing.Point(30, 675);
            this.picRed.Name = "picRed";
            this.picRed.Size = new System.Drawing.Size(324, 307);
            this.picRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRed.TabIndex = 25;
            this.picRed.TabStop = false;
            // 
            // picGreen
            // 
            this.picGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGreen.Location = new System.Drawing.Point(372, 675);
            this.picGreen.Name = "picGreen";
            this.picGreen.Size = new System.Drawing.Size(311, 307);
            this.picGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGreen.TabIndex = 26;
            this.picGreen.TabStop = false;
            // 
            // picBlue
            // 
            this.picBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBlue.Location = new System.Drawing.Point(705, 675);
            this.picBlue.Name = "picBlue";
            this.picBlue.Size = new System.Drawing.Size(324, 307);
            this.picBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBlue.TabIndex = 27;
            this.picBlue.TabStop = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(1043, 9);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 118);
            this.hScrollBar1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 1011);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.picBlue);
            this.Controls.Add(this.picGreen);
            this.Controls.Add(this.picRed);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblSizeImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbBlue);
            this.Controls.Add(this.rtbGreen);
            this.Controls.Add(this.rtbRed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLaplace);
            this.Controls.Add(this.btnPrewitt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThreshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCanny);
            this.Controls.Add(this.btnSobel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuật toán Canny 70DCHT23";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.Button btnCanny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrewitt;
        private System.Windows.Forms.Button btnLaplace;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbRed;
        private System.Windows.Forms.RichTextBox rtbGreen;
        private System.Windows.Forms.RichTextBox rtbBlue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSizeImage;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.PictureBox picRed;
        private System.Windows.Forms.PictureBox picGreen;
        private System.Windows.Forms.PictureBox picBlue;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

