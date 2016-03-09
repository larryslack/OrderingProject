using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLayer;
using BusinessLayer;
using System.Drawing;

namespace InterfaceLayer
{
    public class BrettProductPanel : Panel
    {
        #region Fields

        private ComboBox cmbProducts;
        private List<Product> productList = new List<Product>();
        private static List<BrettProductPanel> panelList = new List<BrettProductPanel>();

        #endregion

        #region Properties

        public int selectedProductID { get; private set; }
        public int quantity { get; private set; }
        public int discount { get; private set; }
        public int price { get; private set; }

        #endregion

        public BrettProductPanel(List<Product> productList)
        {
            this.productList = new List<Product>(productList);
            panelList.Add(this);

            SetupComboBox();
        }

        private void SetupComboBox()
        {
            cmbProducts = new ComboBox();
            cmbProducts.DataSource = productList;
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.ValueMember = "ProductID";
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool cmbProductsSelected(object sender, EventArgs e)
        {
            bool blnAddNewPanel = false;
            int currentPanelIndex = 0;
            int panelIndexCount = panelList.Count - 1;

            if (cmbProducts.SelectedIndex == -1)
                return false;

            selectedProductID = cmbProducts.SelectedIndex;

            for (int i = 0; i < panelList.Count; i++)
            {
                if (this == panelList[i])
                {
                    currentPanelIndex = i;
                }
            }

            if (currentPanelIndex == panelIndexCount)
            {
                blnAddNewPanel = true;
            }

            return blnAddNewPanel;
        }

        public void FoundSameProduct(bool blnFoundSame)
        {
            if (blnFoundSame)
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.FromKnownColor(KnownColor.Window);

        }
    }
}
