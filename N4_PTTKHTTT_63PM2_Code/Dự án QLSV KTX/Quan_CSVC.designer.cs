namespace Dự_án_QLSV_KTX
{
    partial class Quan_CSVC
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
            this.dgvcsvc = new System.Windows.Forms.DataGridView();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcsvc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách tình trạng CSVC theo phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvcsvc
            // 
            this.dgvcsvc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcsvc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcsvc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcsvc.Location = new System.Drawing.Point(2, 132);
            this.dgvcsvc.Name = "dgvcsvc";
            this.dgvcsvc.RowHeadersWidth = 51;
            this.dgvcsvc.RowTemplate.Height = 24;
            this.dgvcsvc.Size = new System.Drawing.Size(798, 317);
            this.dgvcsvc.TabIndex = 1;
            // 
            // btthoat
            // 
            this.btthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btthoat.Location = new System.Drawing.Point(636, 27);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(106, 75);
            this.btthoat.TabIndex = 2;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Quan_CSVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dự_án_QLSV_KTX.Properties.Resources.pexels_josh_sorenson_1714205;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.dgvcsvc);
            this.Controls.Add(this.label1);
            this.Name = "Quan_CSVC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách tình trạng CSVC theo phòng";
            this.Load += new System.EventHandler(this.Quan_CSDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcsvc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcsvc;
        private System.Windows.Forms.Button btthoat;
    }
}