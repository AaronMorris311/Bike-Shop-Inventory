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
    public partial class AddPart : Form
    {
        public bool IsModify;

        public bool IsOutsourced;
        public AddPart()
        {
            InitializeComponent();
            IsOutsourced = false;
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
            if (IsOutsourced == true)
            {
                IsOutsourced = false;
            }

        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
            if (IsOutsourced == false)
            {
                IsOutsourced = true;
            }
        }

        private void IDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    

        private void AddPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Inhouse inhousePart;
            Outsourced outsourcedPart;

                int newPartID = Inventory.AllParts.Count;
            
            if (IsOutsourced == false)
            {
                inhousePart = new Inhouse { 
                    partID = newPartID, 
                    name = NameTextbox.Text, 
                    inStock = Convert.ToInt32(InventoryTextBox.Text), 
                    price = Convert.ToDouble(PriceTextBox.Text), 
                    max = Convert.ToInt32(MaxTextBox.Text), 
                    min = Convert.ToInt32(MinTextBox.Text), 
                    machineID = Convert.ToInt32(MachineIDTextBox.Text) 
                };
            Inventory.addPart(inhousePart);
                this.Hide();
            }
            else
            {
                outsourcedPart = new Outsourced
                {
                    partID = newPartID,
                    name = NameTextbox.Text,
                    inStock = Convert.ToInt32(InventoryTextBox.Text),
                    price = Convert.ToDouble(PriceTextBox.Text),
                    max = Convert.ToInt32(MaxTextBox.Text),
                    min = Convert.ToInt32(MinTextBox.Text),
                    companyName = MachineIDTextBox.Text
                };
                Inventory.addPart(outsourcedPart);
                this.Hide();
            }
            }
    }
}
