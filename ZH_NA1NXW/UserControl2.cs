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
    public partial class UserControl2 : UserControl
    {
        TkContext context = new TkContext();
        public UserControl2()
        {
            InitializeComponent();
            StudentSzures();
            TextbookSzures();
            ListOrders();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StudentSzures();
        }

        private void StudentSzures()
        {
            var students = from x in context.Students
                           where x.Name.Contains(textBox1.Text)
                           select x;
            listBox1.DataSource = students.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextbookSzures();
        }

        private void TextbookSzures()
        {
            var textbooks = from x in context.Textbooks
                            where x.Title.Contains(textBox2.Text)
                            select x;
            listBox2.DataSource = textbooks.ToList();
            listBox2.DisplayMember = "Title";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOrders();
        }

        private void ListOrders()
        {
            var selectedstudent = (Student)listBox1.SelectedItem;
            var orders = from x in context.Orders
                         where x.StudentFk == selectedstudent.StudentId
                         select new Class1
                         {
                             OrderSk = x.OrderSk,
                             Title = x.TextbookFkNavigation.Title,
                             Price = x.TextbookFkNavigation.Price
                         };
            listBox3.DataSource = orders.ToList();
            listBox3.DisplayMember = "Title";

            var Total = (from x in orders
                         select x.Price).Sum();
            var Min = (from x in orders
                       select x.Price).Min();
            var Max = (from x in orders
                       select x.Price).Max();

            textBox3.Text = Total.ToString();
            textBox4.Text = Min.ToString();
            textBox5.Text = Max.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztossan hozzáadod?", "hozzáadás", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedstudent = (Student)listBox1.SelectedItem;
                var selectedtextbook = (Textbook)listBox2.SelectedItem;

                Order newOrder = new Order()
                {
                    StudentFk = selectedstudent.StudentId,
                    TextbookFk = selectedtextbook.TextbookId
                };
                context.Orders.Add(newOrder);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                ListOrders();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztossan törlöd?", "törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedorder = (Class1)listBox3.SelectedItem;
                var ordertobedeleted = (from x in context.Orders
                                        where x.OrderSk == selectedorder.OrderSk
                                        select x).FirstOrDefault();
                context.Orders.Remove(ordertobedeleted);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                ListOrders();
            }
        }
    }
}
