using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuatToanCanny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string filePath;
        Bitmap anhnguon = null, anhdich = null;
        //Form1 fr0;


        Color c;
        StringBuilder c1 = new StringBuilder();
        StringBuilder c2 = new StringBuilder();
        StringBuilder c3 = new StringBuilder();
        
        private void button1_Click(object sender, EventArgs e)
        {
            MoAnh();
        }

        private void MoAnh()
        {
            OpenFileDialog dOpen = new OpenFileDialog();
            dOpen.Filter = "Image .png, .jpg, .bmp, .jpeg, .gif|*.png;*.jpg;*.bmp;*.jpeg;*.gif";
            if (dOpen.ShowDialog() == DialogResult.OK)
            {
                filePath = dOpen.FileName;
                pictureBox1.Image = new Bitmap(dOpen.OpenFile());

                anhnguon = new Bitmap(dOpen.FileName);
                pictureBox1.Image = anhnguon;
                //pictureBox1.Refresh();
                load();

                anhdich = new Bitmap(anhnguon);
                lblSizeImage.Text = (anhnguon.Height + " x" + anhnguon.Width);
                for (int i = 0; i < anhnguon.Width; i++)
                {
                    for (int j = 0; j < anhnguon.Height; j++)
                    {
                        c = anhnguon.GetPixel(i, j);
                        c1.Append(c.R); c1.Append(" ");
                        c2.Append(c.G); c2.Append(" ");
                        c3.Append(c.B); c3.Append(" ");
                    }
                }
                rtbRed.Text = c1.ToString();
                rtbGreen.Text = c2.ToString();
                rtbBlue.Text = c3.ToString();
            }

            
        }

        public void load()
        {
            c1.Clear();c2.Clear();c3.Clear();
            picBlue.Image = null;picGreen.Image = null;picRed.Image = null;
            rtbBlue.Text = "";rtbGreen.Text = " ";rtbRed.Text = " ";
            pictureBox2.Image = null;

        }
        private void getPixelanhdich()
        {
            //anhdich = new Bitmap(anhnguon);
            //for (int i = 0; i < anhdich.Width; i++)
            //{
            //    for (int j = 0; j < anhdich.Height; j++)
            //    {
            //        //c = anhdich.GetPixel(i, j);
            //        //c4.Append(c.R); c4.Append(" ");
            //        //c5.Append(c.G); c5.Append(" ");
            //        //c6.Append(c.B); c6.Append(" ");
            //    }
            //}
            //rtbRedEquals.Text = c4.ToString();
            //rtbGreenEquals.Text = c5.ToString();
            //rtbBlueEquals.Text = c6.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sobel sobel = new Sobel();
            sobel.SobelEdgeDetection(pictureBox1, pictureBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtThreshold.Text=="")
            {
                MessageBox.Show("Phải nhập Threshold");
                txtThreshold.Focus();
                return;
            }
            int threshold = Convert.ToInt16(txtThreshold.Text);
            Canny canny = new Canny();
            canny.CannyEdgeDetection(threshold, pictureBox1, pictureBox2);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLaplace_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Mời bạn chọn ảnh");
                MoAnh();
                return;
            }
            int x;
            int y;
            Color mau;
            for (y = 0; y < anhnguon.Height - 2; y++)
                for (x = 0; x < anhnguon.Width - 2; x++)
                {
                    int gx = 0;
                    int g = 0;
                    gx = -anhnguon.GetPixel(x + 1, y).R - anhnguon.GetPixel(x, y + 1).R
                         + 4 * anhnguon.GetPixel(x + 1, y + 1).R - anhnguon.GetPixel(x + 2, y + 1).R
                         - anhnguon.GetPixel(x + 1, y + 2).R;
                    g = Math.Abs(gx);
                    if (g > 200)
                        g = 255;
                    if (g < 0)
                        g = 0;
                    mau = Color.FromArgb(g, g, g);
                    anhdich.SetPixel(x, y, mau);
                }
            pictureBox2.Image = anhdich;
            getPixelanhdich();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            ////saveanh.Title = "Lưu Ảnh";
            //SaveFileDialog saveanh = new SaveFileDialog();
            //saveanh.Title = "lưu ảnh";
            //if (saveanh.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox2.Image.Save(saveanh.FileName, ImageFormat.Png);
            //    return;
            //}
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Ảnh chưa đựơc xử lý!", "Image Null");
            }
            else
            {
                SaveFileDialog saveimg = new SaveFileDialog();
                saveimg.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                saveimg.Title = "Save an Image File";
                saveimg.InitialDirectory = @"D:\Documents";

                if (saveimg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image.Save(saveimg.FileName);
                    MessageBox.Show("Ảnh đã được lưu!", "Save Image");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            help f2 = new help();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Mời bạn chọn ảnh");
                MoAnh();
                return;
            }
            Bitmap red = new Bitmap(anhnguon.Width, anhnguon.Height);
            for(int x=0;x<anhnguon.Width;x++)
                for(int y=0; y < anhnguon.Height; y++) {

                    Color pixel = anhnguon.GetPixel(x, y);
                    byte R = pixel.R;
                    byte A = pixel.A;

                    red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                }
            picRed.Image = red;
        }
       



        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Mời bạn chọn ảnh");
                MoAnh();
                return;
            }
            Bitmap green = new Bitmap(anhnguon.Width, anhnguon.Height);
            for (int x = 0; x < anhnguon.Width; x++)
                for (int y = 0; y < anhnguon.Height; y++)
                {
                    Color pixel = anhnguon.GetPixel(x, y);
                    byte G = pixel.G;
                    byte A = pixel.A;

                    green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                   
                }
            picGreen.Image = green;
           
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Mời bạn chọn ảnh");
                MoAnh();
                return;
            }
          
            Bitmap blue = new Bitmap(anhnguon.Width, anhnguon.Height);
            for (int x = 0; x < anhnguon.Width; x++)
                for (int y = 0; y < anhnguon.Height; y++)
                {
                    Color pixel = anhnguon.GetPixel(x, y);
                    byte B = pixel.B;
                    byte A = pixel.A;

                    
                    blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));
                }
            picBlue.Image = blue;
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Mời bạn chọn ảnh");
                MoAnh();
                return;
            }
            int x;
            int y;

            Color mau;
            for (y = 0; y < anhnguon.Height - 2; y++)
                for (x = 0; x < anhnguon.Width - 2; x++)
                {
                    int gx = 0;
                    int gy = 0;
                    int g = 0;
                    gx = -anhnguon.GetPixel(x, y).R - anhnguon.GetPixel(x, y + 1).R - anhnguon.GetPixel(x, y + 2).R;

                    gx = gx + anhnguon.GetPixel(x + 2, y).R + anhnguon.GetPixel(x + 2, y + 1).R + anhnguon.GetPixel(x + 2, y + 2).R;




                    gy = -anhnguon.GetPixel(x, y).R - anhnguon.GetPixel(x + 1, y).R - anhnguon.GetPixel(x + 2, y).R;

                    gy = gy + anhnguon.GetPixel(x, y + 2).R + anhnguon.GetPixel(x + 1, y + 2).R + anhnguon.GetPixel(x + 2, y + 2).R;


                    g = Math.Abs(gx) + Math.Abs(gy);


                    if (g > 255)
                        g = 255;
                    if (g < 0)
                        g = 0;
                    mau = Color.FromArgb(g, g, g);
                    anhdich.SetPixel(x, y, mau);
                }
            pictureBox2.Image = anhdich;
            
            
        }
    }
}
