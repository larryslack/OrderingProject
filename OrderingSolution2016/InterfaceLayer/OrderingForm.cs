using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BaseLayer;

namespace InterfaceLayer
{
    public partial class OrderingForm : Form
    {
        List<ProductPanel> listProductPanel = new List<ProductPanel>();
        List<Product> productList = Business.ProductList();


        public OrderingForm()
        {
            InitializeComponent();
        }

        private void OrderingForm_Load(object sender, EventArgs e)
        {


            int ylocation = 4;
            ProductPanel temp = new ProductPanel(panelProducts, ylocation, productList);
            temp.BringToFront();
            listProductPanel.Add(temp);



            decimal zero = 0;
            txtTotalCost.Text = zero.ToString("C");
            txtTotalQuantity.Text = zero.ToString();
            txtTotalDiscount.Text = zero.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateProductPanel();
        }
         

        public void GenerateProductPanel()
        {
            int ylocation = 4;
            foreach (ProductPanel item in listProductPanel)
            {
                ylocation += 28;
            }

            ProductPanel temp = new ProductPanel(panelProducts, ylocation, productList);
            temp.BringToFront();
            listProductPanel.Add(temp);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
