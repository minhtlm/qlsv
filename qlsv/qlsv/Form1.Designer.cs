namespace qlsv
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            mssv = new TextBox();
            hovaten = new TextBox();
            gioitinh = new TextBox();
            diachi = new TextBox();
            sdt = new TextBox();
            email = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ngaysinh = new DateTimePicker();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            buttonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Thông tin sinh viên";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(228, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(715, 450);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "MSSV";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Họ và tên";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Giới tính";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày sinh";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Địa chỉ";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Sđt";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.Name = "Column7";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "MSSV";
            // 
            // mssv
            // 
            mssv.Location = new Point(69, 42);
            mssv.Name = "mssv";
            mssv.Size = new Size(137, 23);
            mssv.TabIndex = 3;
            // 
            // hovaten
            // 
            hovaten.Location = new Point(69, 88);
            hovaten.Name = "hovaten";
            hovaten.Size = new Size(137, 23);
            hovaten.TabIndex = 4;
            // 
            // gioitinh
            // 
            gioitinh.Location = new Point(69, 133);
            gioitinh.Name = "gioitinh";
            gioitinh.Size = new Size(137, 23);
            gioitinh.TabIndex = 5;
            // 
            // diachi
            // 
            diachi.Location = new Point(69, 226);
            diachi.Name = "diachi";
            diachi.Size = new Size(137, 23);
            diachi.TabIndex = 7;
            // 
            // sdt
            // 
            sdt.Location = new Point(69, 272);
            sdt.Name = "sdt";
            sdt.Size = new Size(137, 23);
            sdt.TabIndex = 8;
            // 
            // email
            // 
            email.Location = new Point(69, 323);
            email.Name = "email";
            email.Size = new Size(137, 23);
            email.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 10;
            label3.Text = "Họ và tên";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 136);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 11;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 183);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 229);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 13;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 275);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 14;
            label7.Text = "Sđt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 326);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 15;
            label8.Text = "Email";
            // 
            // ngaysinh
            // 
            ngaysinh.Location = new Point(69, 177);
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Size = new Size(137, 23);
            ngaysinh.TabIndex = 16;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(12, 366);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(75, 28);
            buttonThem.TabIndex = 17;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(121, 366);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(75, 28);
            buttonSua.TabIndex = 18;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += button2_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(12, 410);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(75, 28);
            buttonXoa.TabIndex = 19;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(121, 410);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 28);
            buttonClear.TabIndex = 20;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(buttonClear);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(ngaysinh);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(email);
            Controls.Add(sdt);
            Controls.Add(diachi);
            Controls.Add(gioitinh);
            Controls.Add(hovaten);
            Controls.Add(mssv);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label label2;
        private TextBox mssv;
        private TextBox hovaten;
        private TextBox gioitinh;
        private TextBox diachi;
        private TextBox sdt;
        private TextBox email;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker ngaysinh;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonClear;
    }
}