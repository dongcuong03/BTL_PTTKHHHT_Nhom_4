namespace Dự_án_QLSV_KTX
{
    partial class frmQL_SinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQL_SinhVien));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuanLySinhVien = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnQuanLySinhVien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnQLSV, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(338, 135);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 221);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btnQuanLySinhVien
            // 
            this.btnQuanLySinhVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuanLySinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuanLySinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLySinhVien.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySinhVien.Location = new System.Drawing.Point(0, 173);
            this.btnQuanLySinhVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuanLySinhVien.Name = "btnQuanLySinhVien";
            this.btnQuanLySinhVien.Size = new System.Drawing.Size(207, 48);
            this.btnQuanLySinhVien.TabIndex = 6;
            this.btnQuanLySinhVien.Text = "Quản lý sinh viên";
            this.btnQuanLySinhVien.UseVisualStyleBackColor = false;
            // 
            // btnQLSV
            // 
            this.btnQLSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLSV.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQLSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLSV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQLSV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV.Image")));
            this.btnQLSV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLSV.Location = new System.Drawing.Point(3, 3);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnQLSV.Size = new System.Drawing.Size(201, 167);
            this.btnQLSV.TabIndex = 2;
            this.btnQLSV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLSV.UseVisualStyleBackColor = false;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Location = new System.Drawing.Point(706, 470);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(179, 42);
            this.btnDangXuat.TabIndex = 12;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // frmQL_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 514);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmQL_SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ Quản lý sinh viên";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnQuanLySinhVien;
        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Button btnDangXuat;
    }
}