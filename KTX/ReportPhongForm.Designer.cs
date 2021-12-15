
namespace KTX
{
    partial class ReportPhongForm
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
            this.btnNam = new FontAwesome.Sharp.IconButton();
            this.btnNu = new FontAwesome.Sharp.IconButton();
            this.btnAll = new FontAwesome.Sharp.IconButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnAll, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNam, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNam
            // 
            this.btnNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnNam.IconColor = System.Drawing.Color.Black;
            this.btnNam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNam.Location = new System.Drawing.Point(3, 3);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(350, 64);
            this.btnNam.TabIndex = 4;
            this.btnNam.Text = "Nam";
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnNu
            // 
            this.btnNu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnNu.IconColor = System.Drawing.Color.Black;
            this.btnNu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNu.Location = new System.Drawing.Point(359, 3);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(350, 64);
            this.btnNu.TabIndex = 5;
            this.btnNu.Text = "Nữ";
            this.btnNu.UseVisualStyleBackColor = true;
            this.btnNu.Click += new System.EventHandler(this.btnNu_Click);
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAll.IconColor = System.Drawing.Color.Black;
            this.btnAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(715, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(351, 64);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 70);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1069, 445);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // ReportPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 515);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportPhongForm";
            this.Text = "ReportPhongForm";
            this.Load += new System.EventHandler(this.ReportPhongForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnAll;
        private FontAwesome.Sharp.IconButton btnNu;
        private FontAwesome.Sharp.IconButton btnNam;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}