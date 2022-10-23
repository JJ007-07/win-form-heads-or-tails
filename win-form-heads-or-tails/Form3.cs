using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_form_heads_or_tails
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void btnarrojarmoneda_Click(object sender, EventArgs e)
        {
            Random arrojarmoneda = new Random();
            int resultado = arrojarmoneda.Next(1, 3);
            Form1 f1 = new Form1();
            string opcion1 = f1.opcion1.Text;
            string opcion2 = "";
            MessageBox.Show(opcion1);

            //The result is heads
            if (resultado == 1)
            {
                coinimage.ImageLocation = @"C:\Users\juanb\Desktop\1000Cara.jpg";
                coinimage.SizeMode = PictureBoxSizeMode.StretchImage;
                if (opcion1 == "1")
                {
                   // MessageBox.Show("Ha ganado");
                }
                else
                {
                    //MessageBox.Show("Ha perdido");
                }
            }
            //The result is tails
            else
            {
                coinimage.ImageLocation = @"C:\Users\juanb\Desktop\1000Sello.jpg";
                coinimage.SizeMode = PictureBoxSizeMode.StretchImage;
                if (opcion2 == "1")
                {
                    //MessageBox.Show("Ha ganado");
                }
                else
                {
                    //MessageBox.Show("Ha perdido");
                }
            }
        }

        private void txtcantidadmostrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
