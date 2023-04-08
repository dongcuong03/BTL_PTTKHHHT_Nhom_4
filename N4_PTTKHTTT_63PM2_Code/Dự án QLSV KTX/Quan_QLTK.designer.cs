namespace Dự_án_QLSV_KTX
{
    partial class Quan_QLTK
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
            this.dgvtdstaikhoan = new System.Windows.Forms.DataGridView();
            this.ladstk = new System.Windows.Forms.Label();
            this.bttongtaikhoan = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtdstaikhoan)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtdstaikhoan
            // 
            this.dgvtdstaikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtdstaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtdstaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtdstaikhoan.Location = new System.Drawing.Point(3, 204);
            this.dgvtdstaikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvtdstaikhoan.Name = "dgvtdstaikhoan";
            this.dgvtdstaikhoan.RowHeadersWidth = 62;
            this.dgvtdstaikhoan.RowTemplate.Height = 28;
            this.dgvtdstaikhoan.Size = new System.Drawing.Size(892, 203);
            this.dgvtdstaikhoan.TabIndex = 3;
            this.dgvtdstaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtdstaikhoan_CellClick);
            // 
            // ladstk
            // 
            this.ladstk.AutoSize = true;
            this.ladstk.Location = new System.Drawing.Point(12, 27);
            this.ladstk.Name = "ladstk";
            this.ladstk.Size = new System.Drawing.Size(128, 16);
            this.ladstk.TabIndex = 2;
            this.ladstk.Text = "Danh sách tài khoản";
            // 
            // bttongtaikhoan
            // 
            this.bttongtaikhoan.Location = new System.Drawing.Point(164, 19);
            this.bttongtaikhoan.Name = "bttongtaikhoan";
            this.bttongtaikhoan.Size = new System.Drawing.Size(436, 33);
            this.bttongtaikhoan.TabIndex = 4;
            this.bttongtaikhoan.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(623, 8);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(120, 55);
            this.btxoa.TabIndex = 5;
            this.btxoa.Text = "Xóa tài khoản";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvtdstaikhoan, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.61723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.38277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 409);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tài khoản hệ thống";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tài khoản khách";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(892, 126);
            this.dataGridView1.TabIndex = 6;
            // 
            // Quan_QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dự_án_QLSV_KTX.Properties.Resources.pexels_josh_sorenson_1714205;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.bttongtaikhoan);
            this.Controls.Add(this.ladstk);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Quan_QLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.Quan_QLTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtdstaikhoan)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtdstaikhoan;
        private System.Windows.Forms.Label ladstk;
        private System.Windows.Forms.Button bttongtaikhoan;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}