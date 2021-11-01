
namespace KTX
{
    partial class LoaiViPhamForm
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
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.txtTenLoaiViPham = new System.Windows.Forms.TextBox();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgv_LoaiViPham = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiViPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.btnLuu);
            this.panel.Controls.Add(this.txtMaLoaiViPham);
            this.panel.Controls.Add(this.txtMucDo);
            this.panel.Controls.Add(this.txtTenLoaiViPham);
            this.panel.Controls.Add(this.btnRefresh);
            this.panel.Controls.Add(this.btnSearch);
            this.panel.Controls.Add(this.txtSearch);
            this.panel.Controls.Add(this.btnSua);
            this.panel.Controls.Add(this.btnXoa);
            this.panel.Controls.Add(this.btnThem);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.dgv_LoaiViPham);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(1, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1336, 665);
            this.panel.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLuu.IconColor = System.Drawing.Color.Black;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(760, 160);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(151, 64);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenLoaiViPham
            // 
            this.txtTenLoaiViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiViPham.Location = new System.Drawing.Point(1038, 84);
            this.txtTenLoaiViPham.Multiline = true;
            this.txtTenLoaiViPham.Name = "txtTenLoaiViPham";
            this.txtTenLoaiViPham.Size = new System.Drawing.Size(260, 130);
            this.txtTenLoaiViPham.TabIndex = 4;
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
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.btnSua.IconColor = System.Drawing.Color.Black;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(534, 160);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(151, 64);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            // dgv_LoaiViPham
            // 
            this.dgv_LoaiViPham.AllowUserToAddRows = false;
            this.dgv_LoaiViPham.AllowUserToDeleteRows = false;
            this.dgv_LoaiViPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LoaiViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiViPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_LoaiViPham.Location = new System.Drawing.Point(0, 246);
            this.dgv_LoaiViPham.Name = "dgv_LoaiViPham";
            this.dgv_LoaiViPham.ReadOnly = true;
            this.dgv_LoaiViPham.RowHeadersWidth = 51;
            this.dgv_LoaiViPham.RowTemplate.Height = 24;
            this.dgv_LoaiViPham.Size = new System.Drawing.Size(1326, 384);
            this.dgv_LoaiViPham.TabIndex = 2;
            this.dgv_LoaiViPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiViPham_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(801, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Loại Vi Phạm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Loại Vi Phạm:";
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
            this.label1.Text = "Loại vi phạm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaLoaiViPham
            // 
            this.txtMaLoaiViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiViPham.Location = new System.Drawing.Point(207, 87);
            this.txtMaLoaiViPham.Name = "txtMaLoaiViPham";
            this.txtMaLoaiViPham.Size = new System.Drawing.Size(127, 27);
            this.txtMaLoaiViPham.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mức Độ:";
            // 
            // txtMucDo
            // 
            this.txtMucDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucDo.Location = new System.Drawing.Point(585, 87);
            this.txtMucDo.Name = "txtMucDo";
            this.txtMucDo.Size = new System.Drawing.Size(100, 27);
            this.txtMucDo.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOAIVP";
            this.Column1.HeaderText = "Mã Loại Vi Phạm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENLOAIVP";
            this.Column2.HeaderText = "Tên Loại Vi Phạm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MUCDO";
            this.Column3.HeaderText = "Mức Độ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // LoaiViPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 668);
            this.Controls.Add(this.panel);
            this.Name = "LoaiViPhamForm";
            this.Text = "LoaiViPhamForm";
            this.Load += new System.EventHandler(this.LoaiViPhamForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiViPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.TextBox txtTenLoaiViPham;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DataGridView dgv_LoaiViPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiViPham;
        private System.Windows.Forms.TextBox txtMucDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}