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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            LinkOrders link = new LinkOrders();
            link.OrderProgessSet(true);
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
            
        
        {
            this.Hide();
            LinkOrders link = new LinkOrders();
            link.OrderProgessSet(true);
            Deals deals = new Deals();
            deals.Show();

        }

        private void billing_Click(object sender, EventArgs e)
        {
            this.Hide();
            LinkOrders link = new LinkOrders();
            link.OrderProgessSet(true);
            Billing billing = new Billing();
            billing.Show();

        }

        private void Aboutus_Click(object sender, EventArgs e)
        {
            About_us about = new About_us();
            about.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkOrders link = new LinkOrders();
            if (link.OrderProgess() == false)
            {
                label2.Text = "Order Now..!!!";
            }
            else
                label2.Text = "Order In Progress....";

        }
    }
}
