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
using RentalManagement.Entities;
using RentalManagement.Utils;

namespace RentalManagement
{
    public partial class HomeManagementForm : Form
    {
        private HomeDAO homeDAO = new HomeDAO();

        public HomeManagementForm()
        {
            InitializeComponent();
            this.Load += HomeManagementForm_Load;
        }

        private void HomeManagementForm_Load(object sender, EventArgs e)
        {
            loadHomes();

            dgvHomes.SelectionChanged += DgvHomes_SelectionChanged;
            btnHomeSave.Click += BtnHomeSave_Click;
            btnHomeUpdate.Click += btnHomeUpdate_Click;
            btnHomeDelete.Click += btnHomeDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtHomeId.Clear();
            txtHomeId.Focus();
            txtHomeOwnerName.Clear();
            txtHomeRentalPrice.Clear();
            chkHomeIsRenting.Checked = false;

            loadHomes();
        }

        private void BtnHomeSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (homeDAO.isExist(txtHomeId.Text))
                {
                    MessageBox.Show("Mã nhà đã tồn tại.", "Error");
                    return;
                }

                if (!string.IsNullOrEmpty(txtHomeOwnerName.Text))
                {
                    MessageBox.Show("Tên chủ nhà không được trống.", "Error");
                    return;
                }

                if (!Validator.IsNumeric(txtHomeRentalPrice.Text))
                {
                    MessageBox.Show("Giá thuê phải là giá trị số.", "Error");
                    return;
                }

                double rentalPrice = double.Parse(txtHomeRentalPrice.Text);
                bool isRenting = chkHomeIsRenting.Checked;
                if(homeDAO.saveHome(new Home(txtHomeId.Text, txtHomeOwnerName.Text, rentalPrice, isRenting)))
                {
                    MessageBox.Show("Thêm nhà thành công!", "Quản lý nhà.");
                }
                else
                {
                    MessageBox.Show("Thêm nhà không thành công!", "Quản lý nhà.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DgvHomes_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHomes.CurrentRow != null)
            {
                txtHomeId.Text = dgvHomes.CurrentRow.Cells[0].Value.ToString();
                txtHomeOwnerName.Text = dgvHomes.CurrentRow.Cells[1].Value.ToString();
                txtHomeRentalPrice.Text = dgvHomes.CurrentRow.Cells[2].Value.ToString();
                if(dgvHomes.CurrentRow.Cells[3].Value.ToString() == "True")
                {
                    chkHomeIsRenting.Checked = true;
                }
                else
                {
                    chkHomeIsRenting.Checked = false;
                }
            }
        }

        private void loadHomes()
        {
            dgvHomes.DataSource = homeDAO.getAll();
        }

        private void btnHomeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtHomeOwnerName.Text))
                {
                    MessageBox.Show("Tên chủ nhà không được trống.", "Error");
                    return;
                }

                if (!Validator.IsNumeric(txtHomeRentalPrice.Text))
                {
                    MessageBox.Show("Giá thuê phải là giá trị số.", "Error");
                    return;
                }

                double rentalPrice = double.Parse(txtHomeRentalPrice.Text);
                bool isRenting = chkHomeIsRenting.Checked;
                if (homeDAO.updateHome(new Home(txtHomeId.Text, txtHomeOwnerName.Text, rentalPrice, isRenting)))
                {
                    MessageBox.Show("Cập nhật thông tin nhà thành công!", "Quản lý nhà");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhà không thành công.", "Quản lý nhà");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnHomeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (homeDAO.deleteHome(txtHomeId.Text))
                {
                    MessageBox.Show("Xoá nhà thành công!", "Quản lý nhà");
                }
                else
                {
                    MessageBox.Show("Xoá nhà không thành công.", "Quản lý nhà");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
