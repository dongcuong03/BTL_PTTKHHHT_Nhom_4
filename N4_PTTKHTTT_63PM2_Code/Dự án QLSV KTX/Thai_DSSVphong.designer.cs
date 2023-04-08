namespace Dự_án_QLSV_KTX
{
    partial class Thai_DSSVphong
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
            this.button1 = new System.Windows.Forms.Button();
            this.bttenphong = new System.Windows.Forms.Button();
            this.dgvdssvphong = new System.Windows.Forms.DataGridView();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdssvphong)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(597, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Danh sách sinh viên";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bttenphong
            // 
            this.bttenphong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttenphong.Location = new System.Drawing.Point(277, 4);
            this.bttenphong.Margin = new System.Windows.Forms.Padding(4);
            this.bttenphong.Name = "bttenphong";
            this.bttenphong.Size = new System.Drawing.Size(376, 53);
            this.bttenphong.TabIndex = 31;
            this.bttenphong.Text = "P101";
            this.bttenphong.UseVisualStyleBackColor = false;
            // 
            // dgvdssvphong
            // 
            this.dgvdssvphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdssvphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdssvphong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdssvphong.Location = new System.Drawing.Point(0, 162);
            this.dgvdssvphong.Name = "dgvdssvphong";
            this.dgvdssvphong.RowHeadersWidth = 51;
            this.dgvdssvphong.RowTemplate.Height = 24;
            this.dgvdssvphong.Size = new System.Drawing.Size(861, 291);
            this.dgvdssvphong.TabIndex = 32;
            // 
            // btthoat
            // 
            this.btthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btthoat.Location = new System.Drawing.Point(752, 4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(109, 53);
            this.btthoat.TabIndex = 33;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Thai_DSSVphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dự_án_QLSV_KTX.Properties.Resources.pexels_josh_sorenson_1714205;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 453);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.dgvdssvphong);
            this.Controls.Add(this.bttenphong);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Thai_DSSVphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên phòng";
            this.Load += new System.EventHandler(this.Thai_DSSVphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdssvphong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttenphong;
        private System.Windows.Forms.DataGridView dgvdssvphong;
        private System.Windows.Forms.Button btthoat;
    }
}