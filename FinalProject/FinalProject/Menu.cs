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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Pizzas pizza = new Pizzas();
            pizza.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            BbqPizza salad = new BbqPizza();
            salad.Show();
        }

                private void SubmitButton_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            bill.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
                Beverages beverages = new Beverages();
                beverages.Show();

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {

            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
