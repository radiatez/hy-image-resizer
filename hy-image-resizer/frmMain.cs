using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace hy_image_resizer
{
    public partial class frmMain : Form
    {
        //hySave(this.Location.X+12, this.Location.Y+12, pnlAyarPaneli.Width, pnlAyarPaneli.Height, pnlAyarPaneli.Size);

        Bitmap bmp;
        public frmMain()
        {
            InitializeComponent();
        }

        private void hySave(Int32 x, Int32 y, Int32 w, Int32 h, Size s)
        {
            Rectangle rect = new Rectangle(x, y, w, h);
            MessageBox.Show(rect.ToString());
            bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
            bmp.Save(@"D:\screen.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //pbCapture.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oFileResimEkle1.ShowDialog();
            string testhamza = "";
            //string testhamza2 = "";
            //string testhamza3 = "";
            testhamza = oFileResimEkle1.FileName;
            //testhamza2 = oFileResimEkle1.SafeFileName;


            //MessageBox.Show(testhamza);
            //MessageBox.Show(testhamza2);
            //MessageBox.Show(testhamza3);
            PictureBox pbox = new PictureBox();
            // pbox.ImageLocation = @"D:\screen.jpeg";
            pbox.ImageLocation = testhamza;
            //pbox.Location = new System.Drawing.Point(348, 268);
            pbox.Name = "pictureBox2";
            pbox.Size = new System.Drawing.Size(75, 75);
            pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbox.TabIndex = 1;
            pbox.TabStop = false;
            //this.Controls.Add(pbox);
            this.pnlAyarPaneli.Controls.Add(pbox);

        }
    }
}
