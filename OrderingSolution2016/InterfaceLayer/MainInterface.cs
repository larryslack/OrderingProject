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
    public partial class MainInterface : Form
    {
        AddingForm ad = new AddingForm();
        public MainInterface()
        {
            InitializeComponent();
            FillCombos();
        }
        void FillCombos()
        {
            cmbCustomers.DataSource = Business.CustomerList();
            cmbCustomers.DisplayMember = "CompanyName";
            cmbCustomers.ValueMember = "CustomerID";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompNameChange_Click(object sender, EventArgs e)
        {
            
            ad.ShowDialog();
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
