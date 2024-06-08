using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalManagement
{
    public partial class IndexForm : Form
    {
        HomeManagementForm frmHomeManagement = null;
        ContractManagementForm frmContractManagement = null;

        public IndexForm()
        {
            InitializeComponent();
        }

        private void OtherForm_Closed(Object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            ((Form)sender).Dispose();
        }

        private void btnShowHomes_Click(object sender, EventArgs e)
        {
            frmHomeManagement = new HomeManagementForm();
            frmHomeManagement.FormClosed += OtherForm_Closed;
            this.Visible = false;
            frmHomeManagement.Show();
        }

        private void btnShowContracts_Click(object sender, EventArgs e)
        {
            frmContractManagement = new ContractManagementForm();
            frmContractManagement.FormClosed += OtherForm_Closed;
            this.Visible = false;
            frmContractManagement.Show();
        }
    }
}
