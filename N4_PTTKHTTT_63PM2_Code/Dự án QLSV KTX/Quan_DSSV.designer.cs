namespace Dự_án_QLSV_KTX
{
    partial class Quan_DSSV
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
            this.dgvdssv = new System.Windows.Forms.DataGridView();
            this.bttongsv = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdssv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sinh viên ký túc xá";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvdssv
            // 
            this.dgvdssv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdssv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdssv.Location = new System.Drawing.Point(0, 117);
            this.dgvdssv.Name = "dgvdssv";
            this.dgvdssv.RowHeadersWidth = 51;
            this.dgvdssv.RowTemplate.Height = 24;
            this.dgvdssv.Size = new System.Drawing.Size(793, 362);
            this.dgvdssv.TabIndex = 1;
            // 
            // bttongsv
            // 
            this.bttongsv.Location = new System.Drawing.Point(326, 13);
            this.bttongsv.Name = "bttongsv";
            this.bttongsv.Size = new System.Drawing.Size(364, 41);
            this.bttongsv.TabIndex = 2;
            this.bttongsv.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btthoat.Location = new System.Drawing.Point(697, 13);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(82, 73);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Quan_DSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dự_án_QLSV_KTX.Properties.Resources.pexels_josh_sorenson_1714205;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 472);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.bttongsv);
            this.Controls.Add(this.dgvdssv);
            this.Controls.Add(this.label1);
            this.Name = "Quan_DSSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.Quan_DSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdssv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdssv;
        private System.Windows.Forms.Button bttongsv;
        private System.Windows.Forms.Button btthoat;
    }
}