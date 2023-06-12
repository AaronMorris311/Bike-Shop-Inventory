
namespace MorrisAaron_C968_Task1
{
    partial class MainScreen
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
            this.PartsGridView = new System.Windows.Forms.DataGridView();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchPartButton = new System.Windows.Forms.Button();
            this.SearchPartTextBox = new System.Windows.Forms.TextBox();
            this.SearchProductTextBox = new System.Windows.Forms.TextBox();
            this.SearchProductButton = new System.Windows.Forms.Button();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.IMSLabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsGridView
            // 
            this.PartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.PartsGridView.Location = new System.Drawing.Point(35, 100);
            this.PartsGridView.Name = "PartsGridView";
            this.PartsGridView.RowHeadersVisible = false;
            this.PartsGridView.RowHeadersWidth = 82;
            this.PartsGridView.Size = new System.Drawing.Size(380, 258);
            this.PartsGridView.TabIndex = 0;
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Location = new System.Drawing.Point(461, 100);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.RowHeadersWidth = 82;
            this.ProductsGridView.Size = new System.Drawing.Size(382, 258);
            this.ProductsGridView.TabIndex = 1;
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(176, 375);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 23);
            this.AddPartButton.TabIndex = 2;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Location = new System.Drawing.Point(257, 375);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyPartButton.TabIndex = 3;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Location = new System.Drawing.Point(338, 375);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePartButton.TabIndex = 4;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(761, 375);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductButton.TabIndex = 7;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Location = new System.Drawing.Point(680, 375);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyProductButton.TabIndex = 6;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(599, 375);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProductButton.TabIndex = 5;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(768, 410);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchPartButton
            // 
            this.SearchPartButton.Location = new System.Drawing.Point(193, 71);
            this.SearchPartButton.Name = "SearchPartButton";
            this.SearchPartButton.Size = new System.Drawing.Size(75, 23);
            this.SearchPartButton.TabIndex = 9;
            this.SearchPartButton.Text = "Search";
            this.SearchPartButton.UseVisualStyleBackColor = true;
            this.SearchPartButton.Click += new System.EventHandler(this.SearchPartButton_Click);
            // 
            // SearchPartTextBox
            // 
            this.SearchPartTextBox.Location = new System.Drawing.Point(274, 71);
            this.SearchPartTextBox.Name = "SearchPartTextBox";
            this.SearchPartTextBox.Size = new System.Drawing.Size(139, 20);
            this.SearchPartTextBox.TabIndex = 10;
            this.SearchPartTextBox.TextChanged += new System.EventHandler(this.SearchPartTextBox_TextChanged);
            // 
            // SearchProductTextBox
            // 
            this.SearchProductTextBox.Location = new System.Drawing.Point(704, 71);
            this.SearchProductTextBox.Name = "SearchProductTextBox";
            this.SearchProductTextBox.Size = new System.Drawing.Size(139, 20);
            this.SearchProductTextBox.TabIndex = 12;
            this.SearchProductTextBox.TextChanged += new System.EventHandler(this.SearchProductTextBox_TextChanged);
            // 
            // SearchProductButton
            // 
            this.SearchProductButton.Location = new System.Drawing.Point(623, 71);
            this.SearchProductButton.Name = "SearchProductButton";
            this.SearchProductButton.Size = new System.Drawing.Size(75, 23);
            this.SearchProductButton.TabIndex = 11;
            this.SearchProductButton.Text = "Search";
            this.SearchProductButton.UseVisualStyleBackColor = true;
            this.SearchProductButton.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(457, 68);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(92, 24);
            this.ProductsLabel.TabIndex = 13;
            this.ProductsLabel.Text = "Products";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLabel.Location = new System.Drawing.Point(31, 66);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(56, 24);
            this.PartsLabel.TabIndex = 14;
            this.PartsLabel.Text = "Parts";
            this.PartsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // IMSLabel
            // 
            this.IMSLabel.AutoSize = true;
            this.IMSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMSLabel.Location = new System.Drawing.Point(31, 9);
            this.IMSLabel.Name = "IMSLabel";
            this.IMSLabel.Size = new System.Drawing.Size(295, 24);
            this.IMSLabel.TabIndex = 15;
            this.IMSLabel.Text = "Inventory Management System";
            this.IMSLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "partID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.IMSLabel);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.SearchProductTextBox);
            this.Controls.Add(this.SearchProductButton);
            this.Controls.Add(this.SearchPartTextBox);
            this.Controls.Add(this.SearchPartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ModifyProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.ModifyPartButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.ProductsGridView);
            this.Controls.Add(this.PartsGridView);
            this.Name = "MainScreen";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PartsGridView;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SearchPartButton;
        private System.Windows.Forms.TextBox SearchPartTextBox;
        private System.Windows.Forms.TextBox SearchProductTextBox;
        private System.Windows.Forms.Button SearchProductButton;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label IMSLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

