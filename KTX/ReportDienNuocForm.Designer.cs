
namespace KTX
{
    partial class ReportDienNuocForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDaThanhToan = new FontAwesome.Sharp.IconButton();
            this.btnChuaThanhToan = new FontAwesome.Sharp.IconButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChuaThanhToan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDaThanhToan, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1171, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDaThanhToan
            // 
            this.btnDaThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaThanhToan.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnDaThanhToan.IconColor = System.Drawing.Color.Black;
            this.btnDaThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDaThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDaThanhToan.Location = new System.Drawing.Point(3, 3);
            this.btnDaThanhToan.Name = "btnDaThanhToan";
            this.btnDaThanhToan.Size = new System.Drawing.Size(286, 64);
            this.btnDaThanhToan.TabIndex = 16;
            this.btnDaThanhToan.Text = "Đã Thanh Toán";
            this.btnDaThanhToan.UseVisualStyleBackColor = true;
            this.btnDaThanhToan.Click += new System.EventHandler(this.btnDaThanhToan_Click);
            // 
            // btnChuaThanhToan
            // 
            this.btnChuaThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChuaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuaThanhToan.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnChuaThanhToan.IconColor = System.Drawing.Color.Black;
            this.btnChuaThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChuaThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuaThanhToan.Location = new System.Drawing.Point(295, 3);
            this.btnChuaThanhToan.Name = "btnChuaThanhToan";
            this.btnChuaThanhToan.Size = new System.Drawing.Size(286, 64);
            this.btnChuaThanhToan.TabIndex = 17;
            this.btnChuaThanhToan.Text = "Chưa Thanh Toán";
            this.btnChuaThanhToan.UseVisualStyleBackColor = true;
            this.btnChuaThanhToan.Click += new System.EventHandler(this.btnChuaThanhToan_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 70);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1171, 478);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(587, 11);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(581, 41);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // ReportDienNuocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 548);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportDienNuocForm";
            this.Text = "ReportDienNuocForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnChuaThanhToan;
        private FontAwesome.Sharp.IconButton btnDaThanhToan;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}