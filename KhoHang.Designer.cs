namespace QuanLyDT
{
    partial class khohang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmaxkho = new System.Windows.Forms.TextBox();
            this.txttenkho = new System.Windows.Forms.TextBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.dtpngaynhap = new System.Windows.Forms.DateTimePicker();
            this.dtgkho = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnfix = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgkho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "tên kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "giá nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ngày nhập";
            // 
            // txtmaxkho
            // 
            this.txtmaxkho.Location = new System.Drawing.Point(152, 128);
            this.txtmaxkho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmaxkho.Name = "txtmaxkho";
            this.txtmaxkho.Size = new System.Drawing.Size(265, 22);
            this.txtmaxkho.TabIndex = 4;
            // 
            // txttenkho
            // 
            this.txttenkho.Location = new System.Drawing.Point(156, 203);
            this.txttenkho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttenkho.Name = "txttenkho";
            this.txttenkho.Size = new System.Drawing.Size(265, 22);
            this.txttenkho.TabIndex = 5;
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(152, 266);
            this.txtgianhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(265, 22);
            this.txtgianhap.TabIndex = 6;
            // 
            // dtpngaynhap
            // 
            this.dtpngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaynhap.Location = new System.Drawing.Point(152, 334);
            this.dtpngaynhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpngaynhap.Name = "dtpngaynhap";
            this.dtpngaynhap.Size = new System.Drawing.Size(265, 22);
            this.dtpngaynhap.TabIndex = 7;
            // 
            // dtgkho
            // 
            this.dtgkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgkho.Location = new System.Drawing.Point(448, 15);
            this.dtgkho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgkho.Name = "dtgkho";
            this.dtgkho.RowHeadersWidth = 51;
            this.dtgkho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgkho.Size = new System.Drawing.Size(585, 532);
            this.dtgkho.TabIndex = 8;
            this.dtgkho.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgkho_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maKho";
            this.Column1.HeaderText = "mã kho";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenKho";
            this.Column2.HeaderText = "tên kho";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayNhap";
            this.Column3.HeaderText = "ngày nhập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "giaNhap";
            this.Column4.HeaderText = "giá nhập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(213, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "kho hàng";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(67, 395);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 28);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(241, 396);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 28);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnfix
            // 
            this.btnfix.Location = new System.Drawing.Point(67, 466);
            this.btnfix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfix.Name = "btnfix";
            this.btnfix.Size = new System.Drawing.Size(100, 28);
            this.btnfix.TabIndex = 12;
            this.btnfix.Text = "sửa";
            this.btnfix.UseVisualStyleBackColor = true;
            this.btnfix.Click += new System.EventHandler(this.btnfix_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(241, 466);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 28);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 14;
            // 
            // khohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnfix);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgkho);
            this.Controls.Add(this.dtpngaynhap);
            this.Controls.Add(this.txtgianhap);
            this.Controls.Add(this.txttenkho);
            this.Controls.Add(this.txtmaxkho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "khohang";
            this.Text = "kho hàng";
            this.Load += new System.EventHandler(this.khohang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgkho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaxkho;
        private System.Windows.Forms.TextBox txttenkho;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.DateTimePicker dtpngaynhap;
        private System.Windows.Forms.DataGridView dtgkho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnfix;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label6;
    }
}

