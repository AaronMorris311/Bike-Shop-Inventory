using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorrisAaron_C968_Task1
{
    public partial class AddProduct : Form
    {

        public bool IsModify;

        public bool IsOutsourced;

        public AddProduct()
        {
            InitializeComponent();
            ACPDataGridView.DataSource = Inventory.AllParts;

        }

        private void ACPSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void ACPTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductInventoryTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductPriceTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductMaxTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductMinTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACPAddButton_Click(object sender, EventArgs e)
        {

        }

        private void AssocDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void AddProductSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void AddProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
