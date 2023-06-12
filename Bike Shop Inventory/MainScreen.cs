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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            //link the AllParts from Inventory to the dataview on MainScreen
            PartsGridView.DataSource = Inventory.AllParts;
            ProductsGridView.DataSource = Inventory.Products;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            AddPart AddPartForm = new AddPart();
            AddPartForm.Show();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            AddPart ModifyPart = new AddPart();
            ModifyPart.Show();
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct AddProductForm = new AddProduct();
            AddProductForm.Show();

        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            AddProduct ModifyProductForm = new AddProduct();
            ModifyProductForm.Show();
            
            
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (SearchPartTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].name.ToUpper().Contains(SearchPartTextBox.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if(found)
                {
                    PartsGridView.DataSource = TempList;
                }
            }
            if(!found)
            {
                MessageBox.Show("No Results Found!");
                PartsGridView.DataSource = Inventory.AllParts;
            }

        }

        private void SearchPartTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchProductTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
