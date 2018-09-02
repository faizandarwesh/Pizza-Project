using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BbqPizza : Form
    {
        public BbqPizza()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu mm = new Menu();
            mm.Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = Saladsmall.Text.ToString();
            double price = 0;
            string name = "Salad ";
            if (checkBox1.Checked == true)
            {
                name += " (Small)";
                price = 100;
            }
            
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }

        private void Saladsmall_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = SaladLarge.Text.ToString();
            double price = 0;
            string name = " Salad ";
            if (checkBox2.Checked == true)
            {
                name += " (Large)";
                price = 200;
            }

            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }
    }
}
