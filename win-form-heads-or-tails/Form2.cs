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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnapostar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.txtcantidad.Text = txtcantidad.Text;
            f2.Hide();
            Form3 f3 = new Form3();
            f3.Show();
            f3.txtcantidadmostrar.Text = txtcantidad.Text;
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
