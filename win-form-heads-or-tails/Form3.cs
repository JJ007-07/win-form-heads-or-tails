using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace win_form_heads_or_tails
{
    public partial class Form3 : Form
    {
        static float valorglobal = 0;
        bool eleccion;
        static int cantidadjugadas = 0;

        public Form3()
        {
        }

        public Form3(bool eleccion)
        {
            InitializeComponent();
            this.eleccion = eleccion;
        }

        private void btnarrojarmoneda_Click(object sender, EventArgs e)
        {
            Random arrojarmoneda = new Random();
            int resultado = arrojarmoneda.Next(1, 3);
            Form1 f1 = new Form1();
            if (resultado == 1)
            {
                coinimage.ImageLocation = @"C:\Users\SENA\Desktop\1000Cara.jpg";
                coinimage.SizeMode = PictureBoxSizeMode.StretchImage;
                if (eleccion == true)
                {
                    MessageBox.Show("Has ganado!", "Resultado de la Apuesta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valorglobal = (int.Parse(txtcantidadmostrar.Text) * 2);
                    MessageBox.Show("El total de apuesta ganado es de: " + valorglobal, "Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Has perdido!", "Resultado de la Apuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valorglobal = valorglobal + (valorglobal - int.Parse(txtcantidadmostrar.Text));
                    MessageBox.Show("El total de apuesta que debes es de: " + valorglobal, "Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Form3.cantidadjugadas ++;
                this.Hide();
                Form4 f4 = new Form4("Prueba");
                MessageBox.Show("La cantidad de veces que jugaste fue: " + cantidadjugadas, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                f4.txtfinal.Text = valorglobal + String.Empty;
                f4.Show();
            }
            //The result is tails
            else
            {
                coinimage.ImageLocation = @"C:\Users\SENA\Desktop\1000Sello.jpg";
                coinimage.SizeMode = PictureBoxSizeMode.StretchImage;
                if (eleccion == true)
                {
                    MessageBox.Show("Has perdido!", "Resultado de la Apuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valorglobal = valorglobal + (valorglobal - int.Parse(txtcantidadmostrar.Text));
                    MessageBox.Show("El total de apuesta que debes es de: " + valorglobal, "Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Has ganado!", "Resultado de la Apuesta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valorglobal = (int.Parse(txtcantidadmostrar.Text) * 2);
                    MessageBox.Show("El total de apuesta ganado es de: " + valorglobal, "Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Hide();
                Form3.cantidadjugadas++;
                //this.txtcantidadmostrar.Text = txtcantidadfinal.Text;
                Form4 f4 = new Form4("Prueba");
                MessageBox.Show("La cantidad de veces que jugaste fue: " + cantidadjugadas, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f4.txtfinal.Text = valorglobal + String.Empty;
                f4.Show();
            }
        }

        private void txtcantidadmostrar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cantidad de veces que jugaste fue: " + cantidadjugadas, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void txtcantidadfinal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void coinimage_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
