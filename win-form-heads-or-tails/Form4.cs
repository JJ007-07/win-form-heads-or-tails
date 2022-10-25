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
    public partial class Form4 : Form
    {
        static String valorglobal;

        public Form4(String valorglobal)
        {
            InitializeComponent();
            Form4.valorglobal = valorglobal;
        }

        private void txtcantidadfinal_TextChanged(object sender, EventArgs e)
        {
            txtfinal.Text = valorglobal;            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtresultado_Click(object sender, EventArgs e)
        {

        }

        private void txtfinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrepetir_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnrepetir_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            txtfinal.Text = valorglobal+valorglobal;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtfinal_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
