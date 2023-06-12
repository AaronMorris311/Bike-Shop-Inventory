
namespace MorrisAaron_C968_Task1
{
    partial class DeleteConfirm
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
            this.DeleteText = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.DeleteCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteText
            // 
            this.DeleteText.AutoSize = true;
            this.DeleteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteText.Location = new System.Drawing.Point(12, 49);
            this.DeleteText.Name = "DeleteText";
            this.DeleteText.Size = new System.Drawing.Size(306, 20);
            this.DeleteText.TabIndex = 0;
            this.DeleteText.Text = "Are you sure you want to delete this?";
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(65, 105);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // DeleteCancelButton
            // 
            this.DeleteCancelButton.Location = new System.Drawing.Point(187, 105);
            this.DeleteCancelButton.Name = "DeleteCancelButton";
            this.DeleteCancelButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCancelButton.TabIndex = 2;
            this.DeleteCancelButton.Text = "Cancel";
            this.DeleteCancelButton.UseVisualStyleBackColor = true;
            this.DeleteCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 160);
            this.Controls.Add(this.DeleteCancelButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.DeleteText);
            this.Name = "DeleteConfirm";
            this.Text = "DeleteConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteText;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button DeleteCancelButton;
    }
}