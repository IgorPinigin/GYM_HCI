﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_HCI.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btAdminToTrainers_Click(object sender, EventArgs e)
        {
            TrainersInfo newForm = new TrainersInfo();
            newForm.Show();
            this.Close();
        }
    }
}
