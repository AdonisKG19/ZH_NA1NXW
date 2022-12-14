using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH_NA1NXW.Models;

namespace ZH_NA1NXW
{
    public partial class UserControl3 : UserControl
    {
        TkContext context = new TkContext();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urlap urlap = new Urlap();
            if (urlap.ShowDialog() == DialogResult.OK)
            {
                Textbook textbook = new Textbook()
                {
                    Title = urlap.textBox1.Text,
                    TextbookId = int.Parse(urlap.textBox2.Text),
                    Price = double.Parse(urlap.textBox3.Text)
                };
                context.Textbooks.Add(textbook);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }

                textbookBindingSource.DataSource=context.Textbooks.ToList();
            }
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            textbookBindingSource.DataSource = context.Textbooks.ToList();
        }
    }
}
