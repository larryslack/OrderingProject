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
    public partial class OrderingFormPicker : Form
    {
        public OrderingFormPicker()
        {
            InitializeComponent();
        }

        private void btnBrett_Click(object sender, EventArgs e)
        {
            OrderingFormBrett OFB = new OrderingFormBrett();
            OFB.Show();
        }
    }
}
