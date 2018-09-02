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
    public partial class Pizzas : Form
    {
        public Pizzas()
        {
            InitializeComponent();
        }

        private void Pizzas_Load(object sender, EventArgs e)
        { 
            radioButton1.Checked = true;
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu mm = new Menu();
            mm.Show();
        }

        private void BBQ_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = comboBox1.Text.ToString();
            double price = 0;
            string name = "BBQ Pizza ";
            if (radioButton1.Checked == true)
            {
                name += " (Small)";
                price = 250;
            }
            if (radioButton2.Checked == true)
            {
                name += " (Medium)";
                price = 450;
            }
            if (radioButton3.Checked == true)
            {
                name += " (Large)";
                price = 900;
            }
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }

        private void beef_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = comboBox2.Text.ToString();
            double price = 0;
            string name = "Beef Pizza ";
            if (radioButton4.Checked == true)
            {
                name += " (Small)";
                price = 250;
            }
            if (radioButton5.Checked == true)
            {
                name += " (Medium)";
                price = 450;
            }
            if (radioButton6.Checked == true)
            {
                name += " (Large)";
                price = 900;
            }
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
       
        }

        private void arabian_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = comboBox3.Text.ToString();
            double price = 0;
            string name = "Arabian Pizza ";
            if (radioButton7.Checked == true)
            {
                name += " (Small)";
                price = 250;
            }
            if (radioButton8.Checked == true)
            {
                name += " (Medium)";
                price = 450;
            }
            if (radioButton9.Checked == true)
            {
                name += " (Large)";
                price = 900;
            }
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }

        private void chicken_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = comboBox4.Text.ToString();
            double price = 0;
            string name = "Chicken Pizza ";
            if (radioButton10.Checked == true)
            {
                name += " (Small)";
                price = 250;
            }
            if (radioButton11.Checked == true)
            {
                name += " (Medium)";
                price = 450;
            }
            if (radioButton12.Checked == true)
            {
                name += " (Large)";
                price = 900;
            }
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }

        private void fajita_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = comboBox5.Text.ToString();
            double price = 0;
            string name = "Fajita Pizza ";
            if (radioButton13.Checked == true)
            {
                name += " (Small)";
                price = 250;
            }
            if (radioButton14.Checked == true)
            {
                name += " (Medium)";
                price = 450;
            }
            if (radioButton15.Checked == true)
            {
                name += " (Large)";
                price = 900;
            }
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }

        private void pepperoni_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            string quantity = comboBox6.Text.ToString();
            double price = 0;
            string name = "Pepperoni Pizza ";
            if (radioButton16.Checked == true)
            {
                name += " (Small)";
                price = 250;
            }
            if (radioButton17.Checked == true)
            {
                name += " (Medium)";
                price = 450;
            }
            if (radioButton18.Checked == true)
            {
                name += " (Large)";
                price = 900;
            }
            lo.AddToBill(name, quantity, price);
            MessageBox.Show("Successfully Added: \n\n" + "Item Name:  " + name + "\nQuantity:  " + quantity + "\nPrice:  " + price + "/each");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            lo.Print();
            

        }

    }

        }

    
       




        

    

