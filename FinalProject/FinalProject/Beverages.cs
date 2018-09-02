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
    public partial class Beverages : Form
    {
        public Beverages()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu mm = new Menu();
            mm.Show();
        
        }

        
        private void Beverages_Load(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {

            LinkOrders lo = new LinkOrders();
            string quantity = comboBoxcolddrink.Text.ToString();
            double price = 0;
            string name = "Cold Drink";
            if (radioButtona.Checked == true)
            {
                name += " (1 Litre)";
                price = 80;
            }
            if (radioButtonb.Checked == true)
            {
                name += " (1.5 Litre)";
                price = 120;
            }
            if (radioButtonc.Checked == true)
            {
                name += " (2.5 Litre)";
                price = 170;
            }
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
                                                                                                                                                                                                
            LinkOrders lo = new LinkOrders();
            string quantity = comboBoxDrink.Text.ToString();
            double price = 0;
            string name = "Drink";
            if (radioButtong.Checked == true)
            {
                name += " (500 ml)";
                price = 50;
            }
            if (radioButtonh.Checked == true)
            {
                name += " (1 Litre)";
                price = 80;
            }
            if (radioButtoni.Checked == true)
            {
                name += " (1.5 )";
                price = 120;
            }
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        
        }

        private void buttonB_Click(object sender, EventArgs e)
        {

            LinkOrders lo = new LinkOrders();
            string quantity = comboBoxTea.Text.ToString();
            double price = 0;
            string name = "Coffee ";
            if (radioButtond.Checked == true)
            {
                name += " (Small)";
                price = 50;
            }
            if (radioButtone.Checked == true)
            {
                name += " (Medium)";
                price = 90;
            }
            if (radioButtonf.Checked == true)
            {
                name += " (Large)";
                price = 120;
            }
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        
        }

        private void buttonD_Click(object sender, EventArgs e)
        {

            LinkOrders lo = new LinkOrders();
            string quantity = comboBoxShakes.Text.ToString();
            double price = 0;
            string name = "Shake ";
            if (radioButtonj.Checked == true)
            {
                name += " (Small)";
                price = 100;
            }
            if (radioButtonk.Checked == true)
            {
                name += " (Medium)";
                price = 150;
            }
            if (radioButtonl.Checked == true)
            {
                name += " (Large)";
                price = 200;
            }
            lo.AddToBill(name, quantity, price);

            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }

    }
}
