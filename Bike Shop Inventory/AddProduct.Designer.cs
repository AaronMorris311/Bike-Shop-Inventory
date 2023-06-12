
namespace MorrisAaron_C968_Task1
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddProductLabel = new System.Windows.Forms.Label();
            this.ACPDataGridView = new System.Windows.Forms.DataGridView();
            this.AssocPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ACPSearchButton = new System.Windows.Forms.Button();
            this.ACPTextbox = new System.Windows.Forms.TextBox();
            this.ACPAddButton = new System.Windows.Forms.Button();
            this.AssocDeleteButton = new System.Windows.Forms.Button();
            this.AddProductCancelButton = new System.Windows.Forms.Button();
            this.AddProductSaveButton = new System.Windows.Forms.Button();
            this.AddProductIDTextBox = new System.Windows.Forms.TextBox();
            this.AddProductNameTextbox = new System.Windows.Forms.TextBox();
            this.AddProductInventoryTextbox = new System.Windows.Forms.TextBox();
            this.AddProductPriceTextbox = new System.Windows.Forms.TextBox();
            this.AddProductMaxTextbox = new System.Windows.Forms.TextBox();
            this.AddProductMinTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ACPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssocPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductLabel
            // 
            this.AddProductLabel.AutoSize = true;
            this.AddProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLabel.Location = new System.Drawing.Point(13, 25);
            this.AddProductLabel.Name = "AddProductLabel";
            this.AddProductLabel.Size = new System.Drawing.Size(97, 20);
            this.AddProductLabel.TabIndex = 1;
            this.AddProductLabel.Text = "Add Product";
            // 
            // ACPDataGridView
            // 
            this.ACPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ACPDataGridView.Location = new System.Drawing.Point(295, 70);
            this.ACPDataGridView.Name = "ACPDataGridView";
            this.ACPDataGridView.RowHeadersWidth = 82;
            this.ACPDataGridView.Size = new System.Drawing.Size(492, 141);
            this.ACPDataGridView.TabIndex = 2;
            // 
            // AssocPartsDataGridView
            // 
            this.AssocPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssocPartsDataGridView.Location = new System.Drawing.Point(298, 251);
            this.AssocPartsDataGridView.Name = "AssocPartsDataGridView";
            this.AssocPartsDataGridView.RowHeadersWidth = 82;
            this.AssocPartsDataGridView.Size = new System.Drawing.Size(492, 141);
            this.AssocPartsDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "All candidate Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parts associated with this Product";
            // 
            // ACPSearchButton
            // 
            this.ACPSearchButton.Location = new System.Drawing.Point(474, 37);
            this.ACPSearchButton.Name = "ACPSearchButton";
            this.ACPSearchButton.Size = new System.Drawing.Size(75, 23);
            this.ACPSearchButton.TabIndex = 6;
            this.ACPSearchButton.Text = "Search";
            this.ACPSearchButton.UseVisualStyleBackColor = true;
            this.ACPSearchButton.Click += new System.EventHandler(this.ACPSearchButton_Click);
            // 
            // ACPTextbox
            // 
            this.ACPTextbox.Location = new System.Drawing.Point(555, 39);
            this.ACPTextbox.Name = "ACPTextbox";
            this.ACPTextbox.Size = new System.Drawing.Size(232, 20);
            this.ACPTextbox.TabIndex = 7;
            this.ACPTextbox.TextChanged += new System.EventHandler(this.ACPTextbox_TextChanged);
            // 
            // ACPAddButton
            // 
            this.ACPAddButton.Location = new System.Drawing.Point(689, 217);
            this.ACPAddButton.Name = "ACPAddButton";
            this.ACPAddButton.Size = new System.Drawing.Size(75, 28);
            this.ACPAddButton.TabIndex = 8;
            this.ACPAddButton.Text = "Add";
            this.ACPAddButton.UseVisualStyleBackColor = true;
            this.ACPAddButton.Click += new System.EventHandler(this.ACPAddButton_Click);
            // 
            // AssocDeleteButton
            // 
            this.AssocDeleteButton.Location = new System.Drawing.Point(689, 398);
            this.AssocDeleteButton.Name = "AssocDeleteButton";
            this.AssocDeleteButton.Size = new System.Drawing.Size(75, 28);
            this.AssocDeleteButton.TabIndex = 9;
            this.AssocDeleteButton.Text = "Delete";
            this.AssocDeleteButton.UseVisualStyleBackColor = true;
            this.AssocDeleteButton.Click += new System.EventHandler(this.AssocDeleteButton_Click);
            // 
            // AddProductCancelButton
            // 
            this.AddProductCancelButton.Location = new System.Drawing.Point(715, 432);
            this.AddProductCancelButton.Name = "AddProductCancelButton";
            this.AddProductCancelButton.Size = new System.Drawing.Size(75, 28);
            this.AddProductCancelButton.TabIndex = 10;
            this.AddProductCancelButton.Text = "Cancel";
            this.AddProductCancelButton.UseVisualStyleBackColor = true;
            this.AddProductCancelButton.Click += new System.EventHandler(this.AddProductCancelButton_Click);
            // 
            // AddProductSaveButton
            // 
            this.AddProductSaveButton.Location = new System.Drawing.Point(634, 432);
            this.AddProductSaveButton.Name = "AddProductSaveButton";
            this.AddProductSaveButton.Size = new System.Drawing.Size(75, 28);
            this.AddProductSaveButton.TabIndex = 11;
            this.AddProductSaveButton.Text = "Save";
            this.AddProductSaveButton.UseVisualStyleBackColor = true;
            this.AddProductSaveButton.Click += new System.EventHandler(this.AddProductSaveButton_Click);
            // 
            // AddProductIDTextBox
            // 
            this.AddProductIDTextBox.Location = new System.Drawing.Point(66, 139);
            this.AddProductIDTextBox.Name = "AddProductIDTextBox";
            this.AddProductIDTextBox.Size = new System.Drawing.Size(153, 20);
            this.AddProductIDTextBox.TabIndex = 12;
            this.AddProductIDTextBox.TextChanged += new System.EventHandler(this.AddProductIDTextBox_TextChanged);
            // 
            // AddProductNameTextbox
            // 
            this.AddProductNameTextbox.Location = new System.Drawing.Point(66, 181);
            this.AddProductNameTextbox.Name = "AddProductNameTextbox";
            this.AddProductNameTextbox.Size = new System.Drawing.Size(153, 20);
            this.AddProductNameTextbox.TabIndex = 13;
            this.AddProductNameTextbox.TextChanged += new System.EventHandler(this.AddProductNameTextbox_TextChanged);
            // 
            // AddProductInventoryTextbox
            // 
            this.AddProductInventoryTextbox.Location = new System.Drawing.Point(66, 217);
            this.AddProductInventoryTextbox.Name = "AddProductInventoryTextbox";
            this.AddProductInventoryTextbox.Size = new System.Drawing.Size(153, 20);
            this.AddProductInventoryTextbox.TabIndex = 14;
            this.AddProductInventoryTextbox.TextChanged += new System.EventHandler(this.AddProductInventoryTextbox_TextChanged);
            // 
            // AddProductPriceTextbox
            // 
            this.AddProductPriceTextbox.Location = new System.Drawing.Point(66, 251);
            this.AddProductPriceTextbox.Name = "AddProductPriceTextbox";
            this.AddProductPriceTextbox.Size = new System.Drawing.Size(153, 20);
            this.AddProductPriceTextbox.TabIndex = 15;
            this.AddProductPriceTextbox.TextChanged += new System.EventHandler(this.AddProductPriceTextbox_TextChanged);
            // 
            // AddProductMaxTextbox
            // 
            this.AddProductMaxTextbox.Location = new System.Drawing.Point(66, 291);
            this.AddProductMaxTextbox.Name = "AddProductMaxTextbox";
            this.AddProductMaxTextbox.Size = new System.Drawing.Size(61, 20);
            this.AddProductMaxTextbox.TabIndex = 16;
            this.AddProductMaxTextbox.TextChanged += new System.EventHandler(this.AddProductMaxTextbox_TextChanged);
            // 
            // AddProductMinTextbox
            // 
            this.AddProductMinTextbox.Location = new System.Drawing.Point(195, 291);
            this.AddProductMinTextbox.Name = "AddProductMinTextbox";
            this.AddProductMinTextbox.Size = new System.Drawing.Size(66, 20);
            this.AddProductMinTextbox.TabIndex = 17;
            this.AddProductMinTextbox.TextChanged += new System.EventHandler(this.AddProductMinTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Inventory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Min";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 465);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddProductMinTextbox);
            this.Controls.Add(this.AddProductMaxTextbox);
            this.Controls.Add(this.AddProductPriceTextbox);
            this.Controls.Add(this.AddProductInventoryTextbox);
            this.Controls.Add(this.AddProductNameTextbox);
            this.Controls.Add(this.AddProductIDTextBox);
            this.Controls.Add(this.AddProductSaveButton);
            this.Controls.Add(this.AddProductCancelButton);
            this.Controls.Add(this.AssocDeleteButton);
            this.Controls.Add(this.ACPAddButton);
            this.Controls.Add(this.ACPTextbox);
            this.Controls.Add(this.ACPSearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AssocPartsDataGridView);
            this.Controls.Add(this.ACPDataGridView);
            this.Controls.Add(this.AddProductLabel);
            this.Name = "AddProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ACPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssocPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AddProductLabel;
        private System.Windows.Forms.DataGridView ACPDataGridView;
        private System.Windows.Forms.DataGridView AssocPartsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ACPSearchButton;
        private System.Windows.Forms.TextBox ACPTextbox;
        private System.Windows.Forms.Button ACPAddButton;
        private System.Windows.Forms.Button AssocDeleteButton;
        private System.Windows.Forms.Button AddProductCancelButton;
        private System.Windows.Forms.Button AddProductSaveButton;
        private System.Windows.Forms.TextBox AddProductIDTextBox;
        private System.Windows.Forms.TextBox AddProductNameTextbox;
        private System.Windows.Forms.TextBox AddProductInventoryTextbox;
        private System.Windows.Forms.TextBox AddProductPriceTextbox;
        private System.Windows.Forms.TextBox AddProductMaxTextbox;
        private System.Windows.Forms.TextBox AddProductMinTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}