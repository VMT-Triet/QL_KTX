
namespace KTX
{
    partial class PhongForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.chboxTinhTrang = new System.Windows.Forms.CheckBox();
            this.txtNuoc = new System.Windows.Forms.TextBox();
            this.txtDien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgv_Phong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.chboxTinhTrang);
            this.panel.Controls.Add(this.txtNuoc);
            this.panel.Controls.Add(this.txtDien);
            this.panel.Controls.Add(this.txtSoLuong);
            this.panel.Controls.Add(this.txtSoPhong);
            this.panel.Controls.Add(this.btnRefresh);
            this.panel.Controls.Add(this.btnSearch);
            this.panel.Controls.Add(this.txtSearch);
            this.panel.Controls.Add(this.btnLuu);
            this.panel.Controls.Add(this.btnXoa);
            this.panel.Controls.Add(this.btnThem);
            this.panel.Controls.Add(this.dgv_Phong);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(2, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1336, 669);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // chboxTinhTrang
            // 
            this.chboxTinhTrang.AutoSize = true;
            this.chboxTinhTrang.Location = new System.Drawing.Point(646, 92);
            this.chboxTinhTrang.Name = "chboxTinhTrang";
            this.chboxTinhTrang.Size = new System.Drawing.Size(53, 21);
            this.chboxTinhTrang.TabIndex = 5;
            this.chboxTinhTrang.Text = "đầy";
            this.chboxTinhTrang.UseVisualStyleBackColor = true;
            // 
            // txtNuoc
            // 
            this.txtNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuoc.Location = new System.Drawing.Point(1183, 88);
            this.txtNuoc.Name = "txtNuoc";
            this.txtNuoc.Size = new System.Drawing.Size(100, 27);
            this.txtNuoc.TabIndex = 4;
            // 
            // txtDien
            // 
            this.txtDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDien.Location = new System.Drawing.Point(892, 88);
            this.txtDien.Name = "txtDien";
            this.txtDien.Size = new System.Drawing.Size(100, 27);
            this.txtDien.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(372, 87);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 27);
            this.txtSoLuong.TabIndex = 4;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhong.Location = new System.Drawing.Point(128, 84);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(100, 27);
            this.txtSoPhong.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 35;
            this.btnRefresh.Location = new System.Drawing.Point(1236, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 44);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1101, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1092, 30);
            this.txtSearch.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLuu.IconColor = System.Drawing.Color.Black;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(523, 160);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(151, 64);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(284, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 64);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(35, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 64);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgv_Phong
            // 
            this.dgv_Phong.AllowUserToAddRows = false;
            this.dgv_Phong.AllowUserToDeleteRows = false;
            this.dgv_Phong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_Phong.Location = new System.Drawing.Point(0, 246);
            this.dgv_Phong.Name = "dgv_Phong";
            this.dgv_Phong.ReadOnly = true;
            this.dgv_Phong.RowHeadersWidth = 51;
            this.dgv_Phong.RowTemplate.Height = 24;
            this.dgv_Phong.Size = new System.Drawing.Size(1333, 420);
            this.dgv_Phong.TabIndex = 2;
            this.dgv_Phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Phong_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SOPHONG";
            this.Column1.HeaderText = "Số Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SOLUONG";
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TINHTRANG";
            this.Column3.HeaderText = "Tình Trạng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DONGHODIEN";
            this.Column4.HeaderText = "Đồng Hồ Điện";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DONGHONUOC";
            this.Column5.HeaderText = "Đồng Hồ Nước";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1019, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đồng hồ nước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(734, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đồng hồ điện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tình Trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số phòng:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1330, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 668);
            this.Controls.Add(this.panel);
            this.Name = "PhongForm";
            this.Text = "PhongForm";
            this.Load += new System.EventHandler(this.PhongForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.CheckBox chboxTinhTrang;
        private System.Windows.Forms.TextBox txtNuoc;
        private System.Windows.Forms.TextBox txtDien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtSoPhong;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DataGridView dgv_Phong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private FontAwesome.Sharp.IconButton btnLuu;
    }
}