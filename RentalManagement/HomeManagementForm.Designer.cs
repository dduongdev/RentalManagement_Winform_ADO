
namespace RentalManagement
{
    partial class HomeManagementForm
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
            this.grpHomeInfo = new System.Windows.Forms.GroupBox();
            this.txtHomeRentalPrice = new System.Windows.Forms.TextBox();
            this.txtHomeOwnerName = new System.Windows.Forms.TextBox();
            this.txtHomeId = new System.Windows.Forms.TextBox();
            this.chkHomeIsRenting = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFunctions = new System.Windows.Forms.GroupBox();
            this.btnHomeDelete = new System.Windows.Forms.Button();
            this.btnHomeUpdate = new System.Windows.Forms.Button();
            this.btnHomeSave = new System.Windows.Forms.Button();
            this.grpHomes = new System.Windows.Forms.GroupBox();
            this.dgvHomes = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpHomeInfo.SuspendLayout();
            this.grpFunctions.SuspendLayout();
            this.grpHomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHomeInfo
            // 
            this.grpHomeInfo.Controls.Add(this.txtHomeRentalPrice);
            this.grpHomeInfo.Controls.Add(this.txtHomeOwnerName);
            this.grpHomeInfo.Controls.Add(this.txtHomeId);
            this.grpHomeInfo.Controls.Add(this.chkHomeIsRenting);
            this.grpHomeInfo.Controls.Add(this.label3);
            this.grpHomeInfo.Controls.Add(this.label2);
            this.grpHomeInfo.Controls.Add(this.label1);
            this.grpHomeInfo.Location = new System.Drawing.Point(13, 13);
            this.grpHomeInfo.Name = "grpHomeInfo";
            this.grpHomeInfo.Size = new System.Drawing.Size(495, 165);
            this.grpHomeInfo.TabIndex = 0;
            this.grpHomeInfo.TabStop = false;
            this.grpHomeInfo.Text = "Thông tin nhà";
            // 
            // txtHomeRentalPrice
            // 
            this.txtHomeRentalPrice.Location = new System.Drawing.Point(355, 44);
            this.txtHomeRentalPrice.Name = "txtHomeRentalPrice";
            this.txtHomeRentalPrice.Size = new System.Drawing.Size(125, 26);
            this.txtHomeRentalPrice.TabIndex = 6;
            // 
            // txtHomeOwnerName
            // 
            this.txtHomeOwnerName.Location = new System.Drawing.Point(110, 99);
            this.txtHomeOwnerName.Name = "txtHomeOwnerName";
            this.txtHomeOwnerName.Size = new System.Drawing.Size(125, 26);
            this.txtHomeOwnerName.TabIndex = 5;
            // 
            // txtHomeId
            // 
            this.txtHomeId.Location = new System.Drawing.Point(110, 41);
            this.txtHomeId.Name = "txtHomeId";
            this.txtHomeId.Size = new System.Drawing.Size(125, 26);
            this.txtHomeId.TabIndex = 4;
            // 
            // chkHomeIsRenting
            // 
            this.chkHomeIsRenting.Location = new System.Drawing.Point(258, 96);
            this.chkHomeIsRenting.Name = "chkHomeIsRenting";
            this.chkHomeIsRenting.Size = new System.Drawing.Size(137, 33);
            this.chkHomeIsRenting.TabIndex = 3;
            this.chkHomeIsRenting.Text = "Đã cho thuê";
            this.chkHomeIsRenting.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(255, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá thuê";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chủ nhà";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpFunctions
            // 
            this.grpFunctions.Controls.Add(this.btnRefresh);
            this.grpFunctions.Controls.Add(this.btnHomeDelete);
            this.grpFunctions.Controls.Add(this.btnHomeUpdate);
            this.grpFunctions.Controls.Add(this.btnHomeSave);
            this.grpFunctions.Location = new System.Drawing.Point(514, 13);
            this.grpFunctions.Name = "grpFunctions";
            this.grpFunctions.Size = new System.Drawing.Size(127, 165);
            this.grpFunctions.TabIndex = 1;
            this.grpFunctions.TabStop = false;
            this.grpFunctions.Text = "Chức năng";
            // 
            // btnHomeDelete
            // 
            this.btnHomeDelete.Location = new System.Drawing.Point(6, 90);
            this.btnHomeDelete.Name = "btnHomeDelete";
            this.btnHomeDelete.Size = new System.Drawing.Size(115, 33);
            this.btnHomeDelete.TabIndex = 2;
            this.btnHomeDelete.Text = "Xoá";
            this.btnHomeDelete.UseVisualStyleBackColor = true;
            // 
            // btnHomeUpdate
            // 
            this.btnHomeUpdate.Location = new System.Drawing.Point(6, 56);
            this.btnHomeUpdate.Name = "btnHomeUpdate";
            this.btnHomeUpdate.Size = new System.Drawing.Size(115, 33);
            this.btnHomeUpdate.TabIndex = 1;
            this.btnHomeUpdate.Text = "Sửa";
            this.btnHomeUpdate.UseVisualStyleBackColor = true;
            // 
            // btnHomeSave
            // 
            this.btnHomeSave.Location = new System.Drawing.Point(6, 22);
            this.btnHomeSave.Name = "btnHomeSave";
            this.btnHomeSave.Size = new System.Drawing.Size(115, 33);
            this.btnHomeSave.TabIndex = 0;
            this.btnHomeSave.Text = "Thêm";
            this.btnHomeSave.UseVisualStyleBackColor = true;
            // 
            // grpHomes
            // 
            this.grpHomes.Controls.Add(this.dgvHomes);
            this.grpHomes.Location = new System.Drawing.Point(13, 185);
            this.grpHomes.Name = "grpHomes";
            this.grpHomes.Size = new System.Drawing.Size(628, 256);
            this.grpHomes.TabIndex = 2;
            this.grpHomes.TabStop = false;
            this.grpHomes.Text = "Danh sách nhà";
            // 
            // dgvHomes
            // 
            this.dgvHomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomes.Location = new System.Drawing.Point(13, 26);
            this.dgvHomes.Name = "dgvHomes";
            this.dgvHomes.Size = new System.Drawing.Size(609, 224);
            this.dgvHomes.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 124);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 33);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // HomeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 453);
            this.Controls.Add(this.grpHomes);
            this.Controls.Add(this.grpFunctions);
            this.Controls.Add(this.grpHomeInfo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeManagementForm";
            this.Text = "Trang chủ \\ Quản lý nhà";
            this.grpHomeInfo.ResumeLayout(false);
            this.grpHomeInfo.PerformLayout();
            this.grpFunctions.ResumeLayout(false);
            this.grpHomes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHomeInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHomeRentalPrice;
        private System.Windows.Forms.TextBox txtHomeOwnerName;
        private System.Windows.Forms.TextBox txtHomeId;
        private System.Windows.Forms.CheckBox chkHomeIsRenting;
        private System.Windows.Forms.GroupBox grpFunctions;
        private System.Windows.Forms.Button btnHomeDelete;
        private System.Windows.Forms.Button btnHomeUpdate;
        private System.Windows.Forms.Button btnHomeSave;
        private System.Windows.Forms.GroupBox grpHomes;
        private System.Windows.Forms.DataGridView dgvHomes;
        private System.Windows.Forms.Button btnRefresh;
    }
}