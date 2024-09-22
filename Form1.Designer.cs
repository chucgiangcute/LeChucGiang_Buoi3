namespace LeChucGiang_Buoi3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMssv = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTen = new TextBox();
            txtGioiTinh = new TextBox();
            btnnhap = new Button();
            dtNgaysinh = new DateTimePicker();
            label5 = new Label();
            txtDiaChi = new TextBox();
            dataGridView1 = new DataGridView();
            btnxoa = new Button();
            btntim = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13F);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(148, 485);
            label1.Name = "label1";
            label1.Size = new Size(106, 42);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // txtMssv
            // 
            txtMssv.Font = new Font("Tahoma", 13F);
            txtMssv.Location = new Point(401, 478);
            txtMssv.Name = "txtMssv";
            txtMssv.Size = new Size(463, 49);
            txtMssv.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13F);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(143, 563);
            label2.Name = "label2";
            label2.Size = new Size(122, 42);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(148, 628);
            label3.Name = "label3";
            label3.Size = new Size(148, 42);
            label3.TabIndex = 0;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(148, 699);
            label4.Name = "label4";
            label4.Size = new Size(170, 42);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Tahoma", 13F);
            txtTen.Location = new Point(401, 556);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(463, 49);
            txtTen.TabIndex = 1;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Font = new Font("Tahoma", 13F);
            txtGioiTinh.Location = new Point(401, 643);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(463, 49);
            txtGioiTinh.TabIndex = 1;
            // 
            // btnnhap
            // 
            btnnhap.Font = new Font("Tahoma", 13F);
            btnnhap.Location = new Point(1048, 478);
            btnnhap.Name = "btnnhap";
            btnnhap.Size = new Size(151, 76);
            btnnhap.TabIndex = 2;
            btnnhap.Text = "Nhập";
            btnnhap.UseVisualStyleBackColor = true;
            btnnhap.Click += btnnhap_Click;
            // 
            // dtNgaysinh
            // 
            dtNgaysinh.CalendarFont = new Font("Tahoma", 13F);
            dtNgaysinh.Location = new Point(401, 719);
            dtNgaysinh.Name = "dtNgaysinh";
            dtNgaysinh.Size = new Size(463, 39);
            dtNgaysinh.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13F);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(148, 776);
            label5.Name = "label5";
            label5.Size = new Size(123, 42);
            label5.TabIndex = 0;
            label5.Text = "Địa chỉ";
            label5.Click += label5_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Tahoma", 13F);
            txtDiaChi.Location = new Point(401, 769);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(463, 49);
            txtDiaChi.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(128, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1495, 327);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Tahoma", 13F);
            btnxoa.Location = new Point(1069, 744);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(150, 74);
            btnxoa.TabIndex = 5;
            btnxoa.Text = "Xoá";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btntim
            // 
            btntim.Font = new Font("Tahoma", 13F);
            btntim.Location = new Point(1048, 615);
            btntim.Name = "btntim";
            btntim.Size = new Size(211, 77);
            btntim.TabIndex = 6;
            btntim.Text = "Tìm kiếm";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2104, 962);
            Controls.Add(btntim);
            Controls.Add(btnxoa);
            Controls.Add(dataGridView1);
            Controls.Add(dtNgaysinh);
            Controls.Add(btnnhap);
            Controls.Add(txtDiaChi);
            Controls.Add(txtGioiTinh);
            Controls.Add(txtTen);
            Controls.Add(txtMssv);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMssv;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTen;
        private TextBox txtGioiTinh;
        private Button btnnhap;
        private DateTimePicker dtNgaysinh;
        private Label label5;
        private TextBox txtDiaChi;
        private DataGridView dataGridView1;
        private Button btnxoa;
        private Button btntim;
    }
}
