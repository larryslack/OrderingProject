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

            detailList = Business.OrderDetailList(orderID);

            isEditting = true;
        }
        
        //This will be the "real one"
        private void btnMatt_Click(object sender, EventArgs e)
        {
            OrderingForm OFM = new OrderingForm(CustomerID, EmployeeID);
            OFM.Show();
        }

        // these are so that each person can test their form

        private void btnBrett_Click(object sender, EventArgs e)
        {
            OrderingFormBrett OFB;

            if (isEditting)
            {
                OFB = new OrderingFormBrett(CustomerID, EmployeeID, detailList);
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
            OFB.Show();

        }

        private void brnNathan_Click(object sender, EventArgs e)
        {
            OrderingFormNathan OFB = new OrderingFormNathan(CustomerID, EmployeeID);
            OFB.Show();

        }

        private void btnDaylend_Click(object sender, EventArgs e)
        {
            OrderingFormDaylend OFB = new OrderingFormDaylend(CustomerID, EmployeeID);
            OFB.Show();

        }

        private void btnLinda_Click(object sender, EventArgs e)
        {
            OrderingFormLinda OFB = new OrderingFormLinda(CustomerID, EmployeeID);
            OFB.Show();
        }

        private void btnKate_Click(object sender, EventArgs e)
        {
            OrderingFormKate OFB = new OrderingFormKate(CustomerID, EmployeeID);
            OFB.Show();

        }

        private void btnShohei_Click(object sender, EventArgs e)
        {
            btnProSave OFB = new btnProSave(CustomerID, EmployeeID);
            OFB.Show();

        }
    }
}
