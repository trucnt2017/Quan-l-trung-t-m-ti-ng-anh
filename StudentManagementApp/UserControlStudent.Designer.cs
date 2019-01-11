namespace StudentManagementApp
{
    partial class UserControlStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvStudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnProcessView = new System.Windows.Forms.Button();
            this.btnInsertInputPoint = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.ID_Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvStudent
            // 
            this.dtgvStudent.AllowUserToAddRows = false;
            this.dtgvStudent.AllowUserToResizeColumns = false;
            this.dtgvStudent.AllowUserToResizeRows = false;
            this.dtgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Student,
            this.StudentName,
            this.Gender,
            this.Birthday,
            this.PhoneNumber,
            this.SAddress});
            this.dtgvStudent.Location = new System.Drawing.Point(8, 63);
            this.dtgvStudent.Name = "dtgvStudent";
            this.dtgvStudent.Size = new System.Drawing.Size(700, 333);
            this.dtgvStudent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 30);
            this.label1.TabIndex = 65;
            this.label1.Text = "Danh sách học viên trung tâm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tìm kiếm học viên:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(233, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 20);
            this.txtSearch.TabIndex = 69;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnProcessView
            // 
            this.btnProcessView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProcessView.FlatAppearance.BorderSize = 0;
            this.btnProcessView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessView.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcessView.Image = global::StudentManagementApp.Properties.Resources.process;
            this.btnProcessView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessView.Location = new System.Drawing.Point(298, 402);
            this.btnProcessView.Name = "btnProcessView";
            this.btnProcessView.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnProcessView.Size = new System.Drawing.Size(143, 71);
            this.btnProcessView.TabIndex = 67;
            this.btnProcessView.Text = "Lịch sử\r\nđăng ký";
            this.btnProcessView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessView.UseVisualStyleBackColor = false;
            this.btnProcessView.Click += new System.EventHandler(this.btnProcessView_Click);
            // 
            // btnInsertInputPoint
            // 
            this.btnInsertInputPoint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertInputPoint.FlatAppearance.BorderSize = 0;
            this.btnInsertInputPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertInputPoint.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertInputPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertInputPoint.Image = global::StudentManagementApp.Properties.Resources.note;
            this.btnInsertInputPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertInputPoint.Location = new System.Drawing.Point(124, 402);
            this.btnInsertInputPoint.Name = "btnInsertInputPoint";
            this.btnInsertInputPoint.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnInsertInputPoint.Size = new System.Drawing.Size(168, 71);
            this.btnInsertInputPoint.TabIndex = 66;
            this.btnInsertInputPoint.Text = "Nhập điểm\r\nđầu vào";
            this.btnInsertInputPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertInputPoint.UseVisualStyleBackColor = false;
            this.btnInsertInputPoint.Click += new System.EventHandler(this.btnInsertInputPoint_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeInfo.FlatAppearance.BorderSize = 0;
            this.btnChangeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeInfo.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeInfo.Image = global::StudentManagementApp.Properties.Resources.edit;
            this.btnChangeInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeInfo.Location = new System.Drawing.Point(447, 402);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnChangeInfo.Size = new System.Drawing.Size(155, 71);
            this.btnChangeInfo.TabIndex = 64;
            this.btnChangeInfo.Text = "Thay đổi\r\nthông tin";
            this.btnChangeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeInfo.UseVisualStyleBackColor = false;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // ID_Student
            // 
            this.ID_Student.DataPropertyName = "ID_Student";
            this.ID_Student.FillWeight = 182.7411F;
            this.ID_Student.HeaderText = "Mã học viên";
            this.ID_Student.Name = "ID_Student";
            this.ID_Student.Width = 80;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.FillWeight = 83.45177F;
            this.StudentName.HeaderText = "Tên học viên";
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 180;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.FillWeight = 83.45177F;
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            this.Gender.Width = 92;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.FillWeight = 83.45177F;
            this.Birthday.HeaderText = "Ngày sinh";
            this.Birthday.Name = "Birthday";
            this.Birthday.Width = 91;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.FillWeight = 83.45177F;
            this.PhoneNumber.HeaderText = "Số điện thoại";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 92;
            // 
            // SAddress
            // 
            this.SAddress.DataPropertyName = "SAddress";
            this.SAddress.FillWeight = 83.45177F;
            this.SAddress.HeaderText = "Địa chỉ";
            this.SAddress.Name = "SAddress";
            this.SAddress.Width = 120;
            // 
            // UserControlStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcessView);
            this.Controls.Add(this.btnInsertInputPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.dtgvStudent);
            this.Name = "UserControlStudent";
            this.Size = new System.Drawing.Size(716, 482);
            this.Load += new System.EventHandler(this.UserControlStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvStudent;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertInputPoint;
        private System.Windows.Forms.Button btnProcessView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAddress;
    }
}
