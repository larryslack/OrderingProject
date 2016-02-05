using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceLayer
{
    public partial class OrderingForm : Form
    {
        List<ProductPanel> listProductPanel = new List<ProductPanel>();

        public OrderingForm()
        {
            InitializeComponent();
        }

        private void OrderingForm_Load(object sender, EventArgs e)
        {

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

            ProductPanel temp = new ProductPanel(panelProducts, ylocation);
            temp.BringToFront();
            listProductPanel.Add(temp);
        }
    }
}
