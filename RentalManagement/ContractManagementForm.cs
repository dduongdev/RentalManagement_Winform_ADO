using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalManagement.DAO;

namespace RentalManagement
{
    public partial class ContractManagementForm : Form
    {
        private ContractDAO contractDAO = new ContractDAO();

        public ContractManagementForm()
        {
            InitializeComponent();
            this.Load += ContractManagementForm_Load;
        }

        private void ContractManagementForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            try
            {
                DataTable dt = contractDAO.getAll();
                DataTable highestRevenueContracts = dt.Clone();
                double highestRevenue = dt.AsEnumerable().Max(r => r.Field<double>("ThanhTien"));
                foreach(DataRow row in dt.Rows)
                {
                    if((double)row["ThanhTien"] == highestRevenue)
                    {
                        highestRevenueContracts.ImportRow(row);
                    }
                }

                dgvHighestRevenueContracts.DataSource = highestRevenueContracts;
                dgvContracts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
