using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Nem adtál meg nevet");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "Nem választottál ki nyelvet");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                errorProvider1.SetError(comboBox2 ,"Nem választottál ki Várost");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text))
            {
                errorProvider1.Clear();
                MessageBox.Show("Sikeres!", "Siker");
            }

            
        }
    }
}
