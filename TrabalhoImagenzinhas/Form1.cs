using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoImagenzinhas
{
    public partial class Form1 : Form



    {
        public Form1()
        {
            InitializeComponent();
        }

        string Caminho = "";


        void PictureBoxJuanClick(object sender, EventArgs e)
        {

            Caminho = (sender as PictureBox).ImageLocation;

        }

        void PictureBoxLucasClick(object sender, EventArgs e)
        {

            (sender as PictureBox).Load(Caminho);

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox[,] picbox = new PictureBox[8, 8];
            int[,] m = new int[8, 8];
            int[,] vm = new int[8, 8];
            int[,] vertical = new int[8, 1];
            


            for (int col = 0; col < 8; col++)
                for (int lin = 0; lin < 8; lin++)
                {
                    picbox[col, lin] = new PictureBox();
                    picbox[col, lin].Parent = this;
                    picbox[col, lin].Width = 50;
                    picbox[col, lin].Height = 50;
                    picbox[col, lin].Left = 100 + col * 52;
                    picbox[col, lin].Top = 30 + lin * 52;
                    picbox[col, lin].SizeMode = PictureBoxSizeMode.StretchImage;
                    picbox[col, lin].BorderStyle = BorderStyle.FixedSingle;
                    picbox[col, lin].Click += PictureBoxLucasClick;
                    picbox[col, lin].Name = col.ToString() + "x" + lin.ToString();
                }

            for (int col = 0; col < 2; col++)
                for (int lin = 0; lin < 8; lin++)
                {

                    picbox[col, lin] = new PictureBox();
                    picbox[col, lin].Parent = this;
                    picbox[col, lin].Width = 50;
                    picbox[col, lin].Height = 50;
                    picbox[col, lin].Left = 600 + col * 52;
                    picbox[col, lin].Top = 30 + lin * 52;
                    picbox[col, lin].SizeMode = PictureBoxSizeMode.StretchImage;
                    picbox[col, lin].BorderStyle = BorderStyle.FixedSingle;
                    picbox[col, lin].Click += PictureBoxJuanClick;
                    picbox[col, lin].Name = col.ToString() + "x" + lin.ToString();
                    picbox[col, lin].Load("img" + lin + ".jpg");
                }
        }
    }
}
