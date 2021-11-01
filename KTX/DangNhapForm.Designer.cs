
namespace KTX
{
    partial class DangNhapForm
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
            this.chboxNhoTaiKhoan = new System.Windows.Forms.CheckBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangNhap = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // chboxNhoTaiKhoan
            // 
            this.chboxNhoTaiKhoan.AutoSize = true;
            this.chboxNhoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxNhoTaiKhoan.Location = new System.Drawing.Point(268, 271);
            this.chboxNhoTaiKhoan.Name = "chboxNhoTaiKhoan";
            this.chboxNhoTaiKhoan.Size = new System.Drawing.Size(142, 24);
            this.chboxNhoTaiKhoan.TabIndex = 2;
            this.chboxNhoTaiKhoan.Text = "Nhớ tài khoản?";
            this.chboxNhoTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(268, 217);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(399, 34);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(268, 145);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(399, 34);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tài Khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Ký Túc Xá";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DangNhapForm_MouseDown);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnDangNhap.IconColor = System.Drawing.Color.Blue;
            this.btnDangNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(143, 317);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(213, 84);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnThoat.IconColor = System.Drawing.Color.LightSteelBlue;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 50;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(521, 317);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(196, 84);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(895, 487);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.chboxNhoTaiKhoan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhapForm";
            this.Text = "DangNhapForm";
            this.Load += new System.EventHandler(this.DangNhapForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DangNhapForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chboxNhoTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnDangNhap;
        private FontAwesome.Sharp.IconButton btnThoat;
    }
}

