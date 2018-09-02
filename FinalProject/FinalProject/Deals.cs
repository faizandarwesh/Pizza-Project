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
    public partial class Deals : Form
    {
        public Deals()
        {
            InitializeComponent();
        }

        private void Deals_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = comboBox1.Text.ToString();
            double price = 1750;
            string name = "Dinner Deal ";
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price  + "/each");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = comboBox3.Text.ToString();
            double price = 350;
            string name = "Happy Hours Deal ";
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = comboBox4.Text.ToString();
            double price = 1000;
            string name = "Pair Deal ";
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = comboBox1.Text.ToString();
            double price = 650;
            string name = "Midnight Deal ";
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }

    }
}
