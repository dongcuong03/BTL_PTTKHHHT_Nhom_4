namespace Dự_án_QLSV_KTX
{
    partial class Quan_TKSHP
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvshp = new System.Windows.Forms.DataGridView();
            this.bttongdien = new System.Windows.Forms.Button();
            this.bttongnuoc = new System.Windows.Forms.Button();
            this.bttongwifi = new System.Windows.Forms.Button();
            this.bttongshp = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê chi tiết sinh hoạt phí theo phòng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvshp
            // 
            this.dgvshp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvshp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvshp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshp.Location = new System.Drawing.Point(1, 196);
            this.dgvshp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvshp.Name = "dgvshp";
            this.dgvshp.RowHeadersWidth = 62;
            this.dgvshp.RowTemplate.Height = 28;
            this.dgvshp.Size = new System.Drawing.Size(799, 258);
            this.dgvshp.TabIndex = 1;
            // 
            // bttongdien
            // 
            this.bttongdien.Location = new System.Drawing.Point(15, 52);
            this.bttongdien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttongdien.Name = "bttongdien";
            this.bttongdien.Size = new System.Drawing.Size(379, 35);
            this.bttongdien.TabIndex = 2;
            this.bttongdien.Text = "Tổng tiền điện: 0";
            this.bttongdien.UseVisualStyleBackColor = true;
            this.bttongdien.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttongnuoc
            // 
            this.bttongnuoc.Location = new System.Drawing.Point(15, 91);
            this.bttongnuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttongnuoc.Name = "bttongnuoc";
            this.bttongnuoc.Size = new System.Drawing.Size(379, 35);
            this.bttongnuoc.TabIndex = 2;
            this.bttongnuoc.Text = "Tổng tiền nước: 0";
            this.bttongnuoc.UseVisualStyleBackColor = true;
            this.bttongnuoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttongwifi
            // 
            this.bttongwifi.Location = new System.Drawing.Point(15, 130);
            this.bttongwifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttongwifi.Name = "bttongwifi";
            this.bttongwifi.Size = new System.Drawing.Size(379, 35);
            this.bttongwifi.TabIndex = 2;
            this.bttongwifi.Text = "Tổng tiền wifi: 0";
            this.bttongwifi.UseVisualStyleBackColor = true;
            this.bttongwifi.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttongshp
            // 
            this.bttongshp.Location = new System.Drawing.Point(400, 157);
            this.bttongshp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttongshp.Name = "bttongshp";
            this.bttongshp.Size = new System.Drawing.Size(388, 35);
            this.bttongshp.TabIndex = 2;
            this.bttongshp.Text = "Tổng chi theo tháng: 0";
            this.bttongshp.UseVisualStyleBackColor = true;
            this.bttongshp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(700, 2);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(100, 65);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tháng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "Tất cả"});
            this.comboBox1.Location = new System.Drawing.Point(459, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Quan_TKSHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dự_án_QLSV_KTX.Properties.Resources.pexels_josh_sorenson_1714205;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.bttongshp);
            this.Controls.Add(this.bttongwifi);
            this.Controls.Add(this.bttongnuoc);
            this.Controls.Add(this.bttongdien);
            this.Controls.Add(this.dgvshp);
            this.Controls.Add(this.label1);
            this.Name = "Quan_TKSHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sinh hoạt phí";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvshp;
        private System.Windows.Forms.Button bttongdien;
        private System.Windows.Forms.Button bttongnuoc;
        private System.Windows.Forms.Button bttongwifi;
        private System.Windows.Forms.Button bttongshp;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}