﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class SeatingMapForm : Form
    {
        public SeatingMapForm()
        {
            InitializeComponent();
        }

        private void listInv_btn_Click(object sender, EventArgs e)
        {
            new ListInvitationsForm().ShowDialog();
        }
    }
}