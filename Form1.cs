using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class Form1 : Form
    {
        string[] listanh;
        public Form1()
        {
            InitializeComponent();
            listanh = Directory.GetFiles(Application.StartupPath + @"\image");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(listanh[0]);
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox1);
            loadAnh();

        }
        public void loadAnh()
        {
            anh1.Image = Image.FromFile(listanh[0]);
            anh1.SizeMode = PictureBoxSizeMode.StretchImage;

            anh2.Image = Image.FromFile(listanh[1]);
            anh2.SizeMode = PictureBoxSizeMode.StretchImage;

            anh3.Image = Image.FromFile(listanh[2]);
            anh3.SizeMode = PictureBoxSizeMode.StretchImage;

            anh4.Image = Image.FromFile(listanh[listanh.Length - 1]);
            anh4.SizeMode = PictureBoxSizeMode.StretchImage;

            anh5.Image = Image.FromFile(listanh[listanh.Length - 2]);
            anh5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            BtnNext_Click(sender, e);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Anh2_Click(sender,e);
        }

        private void Anh2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = anh2.Image;
            sapxeptoi();
        }

        private void Anh4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = anh4.Image;
            sapxeplui();
        }

        
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            Anh4_Click(sender, e);
        }

        public void sapxeptoi()
        {
            for (int i = listanh.Length-1; i >0; i--)
            {
                var temp = listanh[i];
                listanh[i] = listanh[0];
                listanh[0] = temp;
            }
            loadAnh();
        }
        public void sapxeplui()
        {
            for (int i = 0; i < listanh.Length - 1; i++)
            {
                var temp = listanh[i];
                listanh[i] = listanh[listanh.Length - 1];
                listanh[listanh.Length - 1] = temp;
            }
            loadAnh();
        }
    }
}
