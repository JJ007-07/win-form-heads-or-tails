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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btncara_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form2(true);
            form.Show();
        }
        private void btnsello_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form2(false);
            form.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcion1_TextChanged(object sender, EventArgs e)
        {

        }

        private void opcion2_TextChanged(object sender, EventArgs e)
        {

        }

        private void coinimage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
