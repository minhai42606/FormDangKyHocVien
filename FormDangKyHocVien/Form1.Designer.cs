namespace FormDangKyHocVien
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
            lblFullName = new Label();
            txtFullName = new TextBox();
            mtxtPhone = new MaskedTextBox();
            lblPhone = new Label();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblSex = new Label();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            lblHobby = new Label();
            chkHobby1 = new CheckBox();
            chkHobby2 = new CheckBox();
            chkHobby3 = new CheckBox();
            lblCourse = new Label();
            cboCourse = new ComboBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(218, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Họ và tên:";
            lblFullName.Click += lblFullName_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(303, 17);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(255, 23);
            txtFullName.TabIndex = 1;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(303, 68);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(255, 23);
            mtxtPhone.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(218, 71);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(79, 15);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Số điện thoại:";
            lblPhone.Click += lblFullName_Click;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(218, 119);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(63, 15);
            lblBirthDate.TabIndex = 0;
            lblBirthDate.Text = "Ngày sinh:";
            lblBirthDate.Click += lblFullName_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(303, 113);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(255, 23);
            dtpBirthDate.TabIndex = 3;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(218, 162);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(55, 15);
            lblSex.TabIndex = 0;
            lblSex.Text = "Giới tính:";
            lblSex.Click += lblFullName_Click;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(462, 162);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(41, 19);
            rdoFemale.TabIndex = 4;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(362, 162);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 4;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblHobby
            // 
            lblHobby.AutoSize = true;
            lblHobby.Location = new Point(218, 203);
            lblHobby.Name = "lblHobby";
            lblHobby.Size = new Size(53, 15);
            lblHobby.TabIndex = 0;
            lblHobby.Text = "Sở thích:";
            lblHobby.Click += lblFullName_Click;
            // 
            // chkHobby1
            // 
            chkHobby1.AutoSize = true;
            chkHobby1.Location = new Point(303, 199);
            chkHobby1.Name = "chkHobby1";
            chkHobby1.Size = new Size(63, 19);
            chkHobby1.TabIndex = 5;
            chkHobby1.Text = "Tư duy";
            chkHobby1.UseVisualStyleBackColor = true;
            // 
            // chkHobby2
            // 
            chkHobby2.AutoSize = true;
            chkHobby2.Location = new Point(385, 199);
            chkHobby2.Name = "chkHobby2";
            chkHobby2.Size = new Size(76, 19);
            chkHobby2.TabIndex = 5;
            chkHobby2.Text = "Phân tích";
            chkHobby2.UseVisualStyleBackColor = true;
            chkHobby2.CheckedChanged += lblHobby2_CheckedChanged;
            // 
            // chkHobby3
            // 
            chkHobby3.AutoSize = true;
            chkHobby3.Location = new Point(486, 199);
            chkHobby3.Name = "chkHobby3";
            chkHobby3.Size = new Size(72, 19);
            chkHobby3.TabIndex = 5;
            chkHobby3.Text = "Sáng tạo";
            chkHobby3.UseVisualStyleBackColor = true;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(218, 245);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(60, 15);
            lblCourse.TabIndex = 0;
            lblCourse.Text = "Khóa học:";
            lblCourse.Click += lblFullName_Click;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(303, 237);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(255, 23);
            cboCourse.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(362, 287);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(cboCourse);
            Controls.Add(chkHobby3);
            Controls.Add(chkHobby2);
            Controls.Add(chkHobby1);
            Controls.Add(rdoMale);
            Controls.Add(rdoFemale);
            Controls.Add(dtpBirthDate);
            Controls.Add(mtxtPhone);
            Controls.Add(txtFullName);
            Controls.Add(lblCourse);
            Controls.Add(lblHobby);
            Controls.Add(lblSex);
            Controls.Add(lblBirthDate);
            Controls.Add(lblPhone);
            Controls.Add(lblFullName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private TextBox txtFullName;
        private MaskedTextBox mtxtPhone;
        private Label lblPhone;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblSex;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label lblHobby;
        private CheckBox chkHobby1;
        private CheckBox chkHobby2;
        private CheckBox chkHobby3;
        private Label lblCourse;
        private ComboBox cboCourse;
        private Button btnRegister;
    }
}
