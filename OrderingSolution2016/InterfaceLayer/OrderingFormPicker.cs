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

namespace InterfaceLayer
{
    public partial class OrderingFormPicker : Form
    {
        string CustomerID = null;
        int EmployeeID = 0;
        int OrderID;
        List<OrderDetail> detailList;
        bool isEditting = false;

        public OrderingFormPicker(string CustomerID, int EmployeeID)
        {
            InitializeComponent();

            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
        }

        public OrderingFormPicker(string CustomerID, int EmployeeID, int orderID)
        {
            InitializeComponent();

            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            this.OrderID = orderID;
            detailList = Business.OrderDetailList(orderID);

            isEditting = true;
        }

        //This will be the "real one"
        private void btnMatt_Click(object sender, EventArgs e)
        {
            OrderingForm OFB = null;
            if (isEditting)
            {
               // OFB = new OrderingForm(CustomerID, EmployeeID, OrderingID);
            }
            else
            {
                OFB = new OrderingForm(CustomerID, EmployeeID);
            }

            OFB.Show();
        }

        // these are so that each person can test their form

        private void btnBrett_Click(object sender, EventArgs e)
        {
            OrderingFormBrett OFB;

            if (isEditting)
            {
                OFB = new OrderingFormBrett(CustomerID, EmployeeID, OrderID);
            }
            else
            {
                OFB = new OrderingFormBrett(CustomerID, EmployeeID);
            }

            OFB.Show();
        }

        private void btnBrent_Click(object sender, EventArgs e)
        {
            OrderingFormBrent OFB = new OrderingFormBrent(CustomerID, EmployeeID);
            if (isEditting)
            {
                //OFB = new OrderingFormBrent(CustomerID, EmployeeID, OrderID);
                throw new Exception("Brent ordering form not yet ready for editing");
            }
            else
            {
                OFB = new OrderingFormBrent(CustomerID, EmployeeID);
            }
            OFB.Show();
 

        }

        private void brnNathan_Click(object sender, EventArgs e)
        {
            OrderingFormNathan OFB;
            if (isEditting)
            {
                OFB = new OrderingFormNathan(CustomerID, EmployeeID, OrderID);
            }
            else
            {
                OFB = new OrderingFormNathan(CustomerID, EmployeeID);
            }
            OFB.Show();

        }

        private void btnDaylend_Click(object sender, EventArgs e)
        {

            MessageBox.Show("I don't do forms I'm the GitHub man :)");
            OrderingFormDaylend OFB = new OrderingFormDaylend(CustomerID, EmployeeID);

            OFB.Show();

        }

        private void btnLinda_Click(object sender, EventArgs e)
        {
            OrderingFormLinda OFB;
            if (isEditting)
            {
                OFB = new OrderingFormLinda(CustomerID, EmployeeID, OrderID);
            }
            else
            {
                OFB = new OrderingFormLinda(CustomerID, EmployeeID);
            }
            OFB.Show();
        }

        private void btnKate_Click(object sender, EventArgs e)
        {
            OrderingFormKate OFB;
            if (isEditting)
            {
                OFB = new OrderingFormKate(CustomerID, EmployeeID, OrderID);
            }
            else
                OFB = new OrderingFormKate(CustomerID, EmployeeID);
            OFB.Show();
        }

    private void btnShohei_Click(object sender, EventArgs e)
        {
            btnProSave OFB;
            if (isEditting)
            {
                OFB = new btnProSave(CustomerID, EmployeeID, OrderID);
            }
            else
                OFB = new btnProSave(CustomerID, EmployeeID);
            OFB.Show();

        }
    }
}
