﻿using System;
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
    public partial class DeleteConfirm : Form
    {
        public bool confirmedDelete;
        public DeleteConfirm()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            confirmedDelete = true;
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            confirmedDelete = false;
            this.Hide();
        }
    }
}
