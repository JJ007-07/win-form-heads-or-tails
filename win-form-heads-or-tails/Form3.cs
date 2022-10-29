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
        static int valorglobal = 0;
        bool eleccion;
        static int cantidadjugadas = 0;
        static int dineroacumulado = 0;

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
                //Por medio de la función ImageLocation las imagenes se buscan por medio de dirección URL
                //Por las URL personales y no por medio de los recursos que tiene el modelo y diseño de la App
                //Por dada razón, es recomendable que se cambie el dueño o usuario al agregar la dirección de las imagenes
                //Incluyendo la ubicación de las imagenes 1000Cara.jpg y 1000Sello.jpg, preferiblemente en el escritorio
                coinimage.ImageLocation = @"C:\Users\juanb\Desktop\1000Cara.jpg";
                coinimage.SizeMode = PictureBoxSizeMode.StretchImage;
                if (eleccion == true)
                {
                    //Ganar
                    MessageBox.Show("Has ganado!", "Resultado de la Apuesta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                  
                    valorglobal = (int.Parse(txtcantidadmostrar.Text) * 2);
                    dineroacumulado = dineroacumulado+valorglobal;
                    MessageBox.Show("El total de apuesta ganado es de: " + valorglobal, "Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("La cantidad de dinero total que tienes es de: " + dineroacumulado, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Perder
                    MessageBox.Show("Has perdido!", "Resultado de la Apuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valorglobal = int.Parse(txtcantidadmostrar.Text);
                    dineroacumulado = dineroacumulado - valorglobal;
                    MessageBox.Show("El total de apuesta que debes es de: " + valorglobal, "Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("La cantidad de dinero total que debes es de: " + dineroacumulado, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Form3.cantidadjugadas ++;
                this.Hide();
                MessageBox.Show("La cantidad de veces que jugaste fue: " + cantidadjugadas, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Form4 f4 = new Form4("Prueba");
                f4.txtfinal.Text = valorglobal + String.Empty;
                f4.Show();
            }
            //The result is tails
            else
            {
                coinimage.ImageLocation = @"C:\Users\juanb\Desktop\1000Sello.jpg";
                coinimage.SizeMode = PictureBoxSizeMode.StretchImage;
                if (eleccion == true)
                {
                    //Perder
                    MessageBox.Show("Has perdido!", "Resultado de la Apuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valorglobal =  int.Parse(txtcantidadmostrar.Text);
                    dineroacumulado = dineroacumulado - valorglobal;
                    MessageBox.Show("El total de apuesta que debes es de: " + valorglobal, "Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("La cantidad de dinero total que debes es de: " + dineroacumulado, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Ganar
                    MessageBox.Show("Has ganado!", "Resultado de la Apuesta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valorglobal = (int.Parse(txtcantidadmostrar.Text) * 2);
                    dineroacumulado = dineroacumulado + valorglobal;
                    MessageBox.Show("El total de apuesta ganado es de: " + valorglobal, "Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("La cantidad de dinero total que tienes es de: " + dineroacumulado, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Hide();
                Form3.cantidadjugadas++;
                //this.txtcantidadmostrar.Text = txtcantidadfinal.Text;
                MessageBox.Show("La cantidad de veces que jugaste fue: " + cantidadjugadas, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("La cantidad de dinero total que tienes es de: " + dineroacumulado, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Form4 f4 = new Form4("Prueba");
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
