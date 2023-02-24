using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinStilqn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = txtName.Text;
            string prezime = txtPrezime.Text;
            string familia = txtFamily.Text;
            string egn=txtEgn.Text;
            string pol = checkPol.Text;
            string sera = groupBox1.Text;
            if (string.IsNullOrEmpty(txtName.Text) ) 
            {
                MessageBox.Show("Не си избрал име");
                txtName.Focus();
                return;
                ime = txtName.Text;
            }
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Не си избрал презиме");
                txtPrezime.Focus();
                return;
                prezime = txtFamily.Text;
            }
            if (string.IsNullOrEmpty(txtFamily.Text))
            {
                MessageBox.Show("Не си избрал фамилия");
                txtFamily.Focus();
                return;
                familia = txtFamily.Text;
            }

        }
    }
}
