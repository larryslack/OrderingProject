using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLayer;
using BusinessLayer;
using DatabaseLayer;

namespace InterfaceLayer
{
    public partial class OrderingFormBrent : Form
    {
        string CurrentCustomer;
        int CurrentEmployee;

        List<Product> fer = DB.ProductList();

        public OrderingFormBrent()
        {
            InitializeComponent();
            //ProductBox.Items = 
        }

        public OrderingFormBrent(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            CurrentCustomer = CustomerID;
            CurrentEmployee = EmployeeID;
            //ProductBox.Items
            foreach (Product er in fer)
            {
                ProductBox.Items.Add(er.ProductName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ProductBox.SelectedIndex >= 0)
                listBox1.Items.Add(ProductBox.SelectedItem);
        }

        private void ProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thing = fer.items
        }

    }
}
