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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LinkOrders link = new LinkOrders();
            link.OrderProgessSet(false);
            link.DeleteAllOrders();
            Form1 form = new Form1();
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Your Order Successfully Placed");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            LinkOrders lo = new LinkOrders();
            lo.setHead();

            bool check = true;
            int serial_no = 0;
            while (check == true)
            {
                string x = lo.Item_name();
                string y = lo.Quantity();
                double z = lo.Price();
                serial_no++;
                this.Ferrari.Rows.Add(serial_no,x,y,z);
                check = lo.getCheck();
                if (check == true)
                    lo.ordernext();

            }
        }
    }
}
