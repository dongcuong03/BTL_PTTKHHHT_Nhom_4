namespace Dự_án_QLSV_KTX
{
    partial class Quan_TK_BC
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
            this.btdssv = new System.Windows.Forms.Button();
            this.btdscsvc = new System.Windows.Forms.Button();
            this.bttkshp = new System.Windows.Forms.Button();
            this.btdsphongtrong = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btdssv
            // 
            this.btdssv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btdssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdssv.Location = new System.Drawing.Point(49, 24);
            this.btdssv.Name = "btdssv";
            this.btdssv.Size = new System.Drawing.Size(701, 85);
            this.btdssv.TabIndex = 0;
            this.btdssv.Text = "Danh sách sinh viên đang sinh hoạt tại ký túc xá";
            this.btdssv.UseVisualStyleBackColor = true;
            this.btdssv.Click += new System.EventHandler(this.button6_Click);
            // 
            // btdscsvc
            // 
            this.btdscsvc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btdscsvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdscsvc.Location = new System.Drawing.Point(49, 136);
            this.btdscsvc.Name = "btdscsvc";
            this.btdscsvc.Size = new System.Drawing.Size(701, 85);
            this.btdscsvc.TabIndex = 1;
            this.btdscsvc.Text = "Danh sách tình trạng CSVC theo phòng";
            this.btdscsvc.UseVisualStyleBackColor = true;
            this.btdscsvc.Click += new System.EventHandler(this.button7_Click);
            // 
            // bttkshp
            // 
            this.bttkshp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttkshp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttkshp.Location = new System.Drawing.Point(49, 248);
            this.bttkshp.Name = "bttkshp";
            this.bttkshp.Size = new System.Drawing.Size(701, 85);
            this.bttkshp.TabIndex = 2;
            this.bttkshp.Text = "Thống kê chi tiết sinh hoạt phí theo phòng";
            this.bttkshp.UseVisualStyleBackColor = true;
            this.bttkshp.Click += new System.EventHandler(this.bttkshp_Click);
            // 
            // btdsphongtrong
            // 
            this.btdsphongtrong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btdsphongtrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdsphongtrong.Location = new System.Drawing.Point(49, 362);
            this.btdsphongtrong.Name = "btdsphongtrong";
            this.btdsphongtrong.Size = new System.Drawing.Size(701, 85);
            this.btdsphongtrong.TabIndex = 3;
            this.btdsphongtrong.Text = "Danh sách phòng đang trống";
            this.btdsphongtrong.UseVisualStyleBackColor = true;
            this.btdsphongtrong.Click += new System.EventHandler(this.btdsphongtrong_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btdsphongtrong, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btdscsvc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttkshp, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btdssv, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Quan_TK_BC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dự_án_QLSV_KTX.Properties.Resources.pexels_josh_sorenson_1714205;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Quan_TK_BC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê - Báo cáo";
            this.Load += new System.EventHandler(this.Quan_TK_BC_Load);
            this.TextChanged += new System.EventHandler(this.Quan_TK_BC_TextChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btdssv;
        private System.Windows.Forms.Button btdscsvc;
        private System.Windows.Forms.Button bttkshp;
        private System.Windows.Forms.Button btdsphongtrong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

