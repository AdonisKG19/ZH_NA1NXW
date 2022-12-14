using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH_NA1NXW
{
    public partial class Urlap : Form
    {
        public Urlap()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "nem lehet üres");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1,string.Empty);
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{4}$");
            if (!regex.IsMatch(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Nem 4 számjegyet adtál meg");

            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, string.Empty);
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex("^[0-9]{3,4}$");
            if (!r.IsMatch(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "nem 3 vagy 4 számjegyet adtál meg");
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox3, string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
