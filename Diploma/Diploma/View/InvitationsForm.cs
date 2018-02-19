using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diploma.View
{
    public partial class InvitationsForm : Form
    {
        public InvitationsForm()
        {
            InitializeComponent();
        }

        private void listInv_btn_Click(object sender, EventArgs e)
        {
            new ListInvitationsForm().ShowDialog();
        }
    }
}
