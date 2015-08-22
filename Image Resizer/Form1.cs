using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Image_Resizer
{
    public partial class Form1 : Form
    {

        Image image;
        Image oimage;

        public Form1()
        {
            InitializeComponent();
            cb3.SelectedIndex = 0;
            cb4.SelectedIndex = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            image = null;
        }


        private static Image toGreyscale(Image srcImage)
        {
            Bitmap bitmap = new Bitmap(srcImage);
            Color c;
            int rgb;
            for(int i=0;i<bitmap.Width;i++)
            {
                for(int j=0;j<bitmap.Height;j++)
                {
                    c =bitmap.GetPixel(i,j);
                    rgb = (int)(0.299 * c.R + 0.587 * c.G + 0.114 * c.B);
                    bitmap.SetPixel(i,j,Color.FromArgb(rgb,rgb,rgb));
                }
            }
            return bitmap;
        }

        private static Image resizeImage(Image imgToResize, Size size,bool lockRatio)
        {


            int destWidth = size.Width;
            int destHeight = size.Height;

            if (lockRatio)
            {
                int sourceWidth = imgToResize.Width;
                int sourceHeight = imgToResize.Height;

                float nPercent = 0;
                float nPercentW = 0;
                float nPercentH = 0;

                nPercentW = ((float)size.Width / (float)sourceWidth);
                nPercentH = ((float)size.Height / (float)sourceHeight);

                if (nPercentH < nPercentW)
                    nPercent = nPercentH;
                else
                    nPercent = nPercentW;

                destWidth = (int)(sourceWidth * nPercent);
                destHeight = (int)(sourceHeight * nPercent);
            }

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            button2.Enabled = true;
            cb2.Enabled = true;

            ofd.Filter = "Image files(*.gif,*.jpg,*.jpeg,*.bmp,*.wmf,*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png|All Files(*.*)|*.*";
            ofd.FilterIndex = 1;

            ofd.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult click = ofd.ShowDialog();
            if (click==DialogResult.OK)
            {
                tb1.Text = ofd.FileName;
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(tb1.Text);
                String ext = fileInfo.Extension.ToLower();
                if (ext.Equals(".gif") || ext.Equals(".jpg") || ext.Equals(".jpeg") || ext.Equals(".bmp") || ext.Equals(".wmf") || ext.Equals(".png"))
                {
                    image = Image.FromFile(tb1.Text);
                    oimage = (Image)image.Clone();
                    if (image.Width <= 300 && image.Height <= 300)
                    {
                        lblp1.Text = "Original Image";
                        lblp2.Text = "Final Image";
                        pb1.Image = oimage;
                        pb2.Image = image;
                    }
                    else
                    {
                        lblp1.Text = "Original Image ( scaled down to " +
                            ((image.Width < image.Height)
                            ? (30000 / image.Height).ToString()
                            : (30000 / image.Width).ToString())
                            + "% for displaying )";

                        lblp2.Text = "Final Image ( scaled down to " +
                            ((image.Width < image.Height)
                            ? (30000 / image.Height).ToString()
                            : (30000 / image.Width).ToString())
                            + "% for displaying )";
                        pb1.Image = resizeImage(image, new Size(300, 300), true);
                        pb2.Image = resizeImage(image, new Size(300, 300), true);
                    }
                    long s = fileInfo.Length;
                    String size = "";
                    if (s > 1073741823)
                    {
                        size = ((float)s / 1073741824.0f).ToString("0.00") + "  gb";
                    }
                    else if(s>1048575)
                    {
                        size = ((float)s / 1048576.0f).ToString("0.00") + "  mb";
                    }
                    else if (s > 1023)
                    {
                        size = ((float)s / 1024.0f).ToString("0.00") + "  kb";
                    }
                    tb_spec.Text = "Image Specifications\r\n\r\n"+
                                   "Width\t:  " + image.Width.ToString() + " pixels\r\n" +
                                   "Height\t:  " + image.Height.ToString() + " pixles\r\n" +
                                   "Size\t:  "+size;
                    tb_w.Text = image.Width.ToString();
                    tb_h.Text = image.Height.ToString();
                    cb2.SelectedIndex = 0;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float w = 0;
            float h = 0;
            if (float.TryParse(tb_w.Text,out w) && float.TryParse(tb_h.Text,out h))
            {
                if (w > 0 && h > 0)
                {
                    float wi = w;
                    float hei = h;
                    switch (cb1.SelectedIndex)
                    {
                        case 0: wi = 37.795275591f * w;
                            hei = 37.795275591f * h;
                            break;
                        case 2: wi = w * 72;
                            hei = h * 72;
                            break;
                    }
                    Size sz = new Size((int)wi, (int)hei);

                    image = resizeImage(oimage, sz, false);
                    if ( !(cb4.SelectedIndex == 0 && cb3.SelectedIndex == 0))
                    {
                        RotateFlipType rtp = RotateFlipType.RotateNoneFlipNone;
                        if (cb4.SelectedIndex == 0)
                        {
                            if (cb3.SelectedIndex == 1)
                            {
                                rtp = RotateFlipType.Rotate90FlipNone;
                            }
                            else if (cb3.SelectedIndex == 2)
                            {
                                rtp = RotateFlipType.Rotate180FlipNone;
                            }
                            else if (cb3.SelectedIndex == 3)
                            {
                                rtp = RotateFlipType.Rotate270FlipNone;
                            }
                        }
                        if (cb4.SelectedIndex == 1)
                        {
                            if (cb3.SelectedIndex == 0)
                            {
                                rtp = RotateFlipType.RotateNoneFlipX;
                            }
                            else if (cb3.SelectedIndex == 1)
                            {
                                rtp = RotateFlipType.Rotate90FlipX;
                            }
                            else if (cb3.SelectedIndex == 2)
                            {
                                rtp = RotateFlipType.Rotate180FlipX;
                            }
                            else if (cb3.SelectedIndex == 3)
                            {
                                rtp = RotateFlipType.Rotate270FlipX;
                            }

                        }
                        else if (cb4.SelectedIndex == 2)
                        {
                            if (cb3.SelectedIndex == 0)
                            {
                                rtp = RotateFlipType.RotateNoneFlipY;
                            }
                            else if (cb3.SelectedIndex == 1)
                            {
                                rtp = RotateFlipType.Rotate90FlipY;
                            }
                            else if (cb3.SelectedIndex == 2)
                            {
                                rtp = RotateFlipType.Rotate180FlipY;
                            }
                            else if (cb3.SelectedIndex == 3)
                            {
                                rtp = RotateFlipType.Rotate270FlipY;
                            }
                        }
                        image.RotateFlip(rtp);
                    }
                    if (chb2.Checked)
                    {
                        image = toGreyscale(image);
                    }
                    if (image.Height <= 300 && image.Width <= 300)
                    {
                        lblp2.Text = "Final Image";
                        pb2.Image = image;
                    }
                    else
                    {
                        lblp2.Text = "Final Image ( scaled down to " +
                            ((image.Width < image.Height)
                            ? (30000 / image.Height).ToString()
                            : (30000 / image.Width).ToString())
                            + "% for displaying )";
                        pb2.Image = resizeImage(image, new Size(300, 300), true);
                    }
                    displayImageSize();
                }
                else
                {
                    MessageBox.Show("ERROR_2 : enter only positive value" , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERROR_1 : enter digits only without space", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sfd.Filter = "PNG|*.png|JPEG|*.jpeg|BITMAP|*.bmp|GIF|*.gif";
            sfd.FilterIndex = cb2.SelectedIndex+1;

            // Call the ShowDialog method to show the dialog box.
            DialogResult click = sfd.ShowDialog();
            if (click == DialogResult.OK)
            {
                image.Save(sfd.FileName);
            }
        }

        private void displayImageSize()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.Drawing.Imaging.ImageFormat imf = System.Drawing.Imaging.ImageFormat.Png;
            switch (cb2.SelectedIndex)
            {
                case 1: imf = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;
                case 2: imf = System.Drawing.Imaging.ImageFormat.Bmp;
                    break;
                case 3: imf = System.Drawing.Imaging.ImageFormat.Gif;
                    break;
            }

            image.Save(ms, imf);
            long s = ms.ToArray().Length;
            String size = "";
            if (s > 1073741823)
            {
                size = ((float)s / 1073741824.0f).ToString("0.00") + "  gb";
            }
            else if (s > 1048575)
            {
                size = ((float)s / 1048576.0f).ToString("0.00") + "  mb";
            }
            else if (s > 1023)
            {
                size = ((float)s / 1024.0f).ToString("0.00") + "  kb";
            }
            tb_s.Text = "File size : " + size;
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayImageSize();
        }
    }
}
