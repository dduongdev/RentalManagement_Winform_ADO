
namespace RentalManagement
{
    partial class IndexForm
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
            this.btnShowHomes = new System.Windows.Forms.Button();
            this.btnShowContracts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowHomes
            // 
            this.btnShowHomes.Location = new System.Drawing.Point(42, 95);
            this.btnShowHomes.Name = "btnShowHomes";
            this.btnShowHomes.Size = new System.Drawing.Size(184, 65);
            this.btnShowHomes.TabIndex = 0;
            this.btnShowHomes.Text = "Quản lý nhà";
            this.btnShowHomes.UseVisualStyleBackColor = true;
            this.btnShowHomes.Click += new System.EventHandler(this.btnShowHomes_Click);
            // 
            // btnShowContracts
            // 
            this.btnShowContracts.Location = new System.Drawing.Point(263, 95);
            this.btnShowContracts.Name = "btnShowContracts";
            this.btnShowContracts.Size = new System.Drawing.Size(184, 65);
            this.btnShowContracts.TabIndex = 1;
            this.btnShowContracts.Text = "Quản lý hợp đồng";
            this.btnShowContracts.UseVisualStyleBackColor = true;
            this.btnShowContracts.Click += new System.EventHandler(this.btnShowContracts_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 255);
            this.Controls.Add(this.btnShowContracts);
            this.Controls.Add(this.btnShowHomes);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IndexForm";
            this.Text = "Trang chủ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowHomes;
        private System.Windows.Forms.Button btnShowContracts;
    }
}

