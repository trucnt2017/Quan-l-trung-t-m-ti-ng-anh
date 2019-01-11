namespace StudentManagementApp
{
    partial class UserControlProcessView
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvRegisterList = new System.Windows.Forms.DataGridView();
            this.ID_Register = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ClassType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassType_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studying_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input_Date_Exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvClassList = new System.Windows.Forms.DataGridView();
            this.ID_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Receive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studying_Time_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Graduation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsertInputPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegisterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 30);
            this.label1.TabIndex = 66;
            this.label1.Text = "Xem chi tiết lịch sử đăng ký học viên";
            // 
            // dtgvRegisterList
            // 
            this.dtgvRegisterList.AllowUserToAddRows = false;
            this.dtgvRegisterList.AllowUserToDeleteRows = false;
            this.dtgvRegisterList.AllowUserToResizeColumns = false;
            this.dtgvRegisterList.AllowUserToResizeRows = false;
            this.dtgvRegisterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegisterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Register,
            this.ID_ClassType,
            this.ClassType_Name,
            this.Studying_Time,
            this.Date1,
            this.Date2,
            this.Input_Date_Exam,
            this.Fee});
            this.dtgvRegisterList.Location = new System.Drawing.Point(17, 106);
            this.dtgvRegisterList.Name = "dtgvRegisterList";
            this.dtgvRegisterList.Size = new System.Drawing.Size(680, 144);
            this.dtgvRegisterList.TabIndex = 72;
            // 
            // ID_Register
            // 
            this.ID_Register.DataPropertyName = "IdRegister";
            this.ID_Register.HeaderText = "Mã đăng ký";
            this.ID_Register.Name = "ID_Register";
            // 
            // ID_ClassType
            // 
            this.ID_ClassType.DataPropertyName = "IdClassType";
            this.ID_ClassType.HeaderText = "Mã loại lớp";
            this.ID_ClassType.Name = "ID_ClassType";
            // 
            // ClassType_Name
            // 
            this.ClassType_Name.DataPropertyName = "ClassTypeName";
            this.ClassType_Name.HeaderText = "Tên loại lớp";
            this.ClassType_Name.Name = "ClassType_Name";
            this.ClassType_Name.Width = 150;
            // 
            // Studying_Time
            // 
            this.Studying_Time.DataPropertyName = "StudyingTime";
            this.Studying_Time.HeaderText = "Thời gian học";
            this.Studying_Time.Name = "Studying_Time";
            // 
            // Date1
            // 
            this.Date1.DataPropertyName = "Date1";
            this.Date1.HeaderText = "Buổi 1";
            this.Date1.Name = "Date1";
            // 
            // Date2
            // 
            this.Date2.DataPropertyName = "Date2";
            this.Date2.HeaderText = "Buổi 2";
            this.Date2.Name = "Date2";
            // 
            // Input_Date_Exam
            // 
            this.Input_Date_Exam.DataPropertyName = "InputDateExam";
            this.Input_Date_Exam.HeaderText = "Ngày thi";
            this.Input_Date_Exam.Name = "Input_Date_Exam";
            // 
            // Fee
            // 
            this.Fee.DataPropertyName = "Fee";
            this.Fee.HeaderText = "Học phí";
            this.Fee.Name = "Fee";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(472, 53);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(225, 20);
            this.txtStudentName.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tên học viên:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(111, 53);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(225, 20);
            this.txtStudentID.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 73;
            this.label3.Text = "Mã học viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 23);
            this.label4.TabIndex = 75;
            this.label4.Text = "Danh sách đơn đăng ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 23);
            this.label5.TabIndex = 77;
            this.label5.Text = "Danh sách lớp đã học và kết quả";
            // 
            // dtgvClassList
            // 
            this.dtgvClassList.AllowUserToAddRows = false;
            this.dtgvClassList.AllowUserToDeleteRows = false;
            this.dtgvClassList.AllowUserToResizeColumns = false;
            this.dtgvClassList.AllowUserToResizeRows = false;
            this.dtgvClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClassList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Class,
            this.Class_Name,
            this.StatusExam,
            this.Date_Receive,
            this.Studying_Time_Class,
            this.Point,
            this.Graduation});
            this.dtgvClassList.Location = new System.Drawing.Point(17, 279);
            this.dtgvClassList.Name = "dtgvClassList";
            this.dtgvClassList.Size = new System.Drawing.Size(680, 144);
            this.dtgvClassList.TabIndex = 76;
            // 
            // ID_Class
            // 
            this.ID_Class.DataPropertyName = "IdClass";
            this.ID_Class.HeaderText = "Mã lớp";
            this.ID_Class.Name = "ID_Class";
            // 
            // Class_Name
            // 
            this.Class_Name.DataPropertyName = "ClassName";
            this.Class_Name.HeaderText = "Tên lớp";
            this.Class_Name.Name = "Class_Name";
            this.Class_Name.Width = 200;
            // 
            // StatusExam
            // 
            this.StatusExam.DataPropertyName = "SStatus";
            this.StatusExam.HeaderText = "Trạng thái";
            this.StatusExam.Name = "StatusExam";
            // 
            // Date_Receive
            // 
            this.Date_Receive.DataPropertyName = "DateReceive";
            this.Date_Receive.HeaderText = "Ngày nhận lớp";
            this.Date_Receive.Name = "Date_Receive";
            // 
            // Studying_Time_Class
            // 
            this.Studying_Time_Class.DataPropertyName = "StudyingTimeClass";
            this.Studying_Time_Class.HeaderText = "Thời gian học";
            this.Studying_Time_Class.Name = "Studying_Time_Class";
            // 
            // Point
            // 
            this.Point.DataPropertyName = "Point";
            this.Point.HeaderText = "Điểm";
            this.Point.Name = "Point";
            // 
            // Graduation
            // 
            this.Graduation.DataPropertyName = "Graduation";
            this.Graduation.HeaderText = "Chứng chỉ";
            this.Graduation.Name = "Graduation";
            // 
            // btnInsertInputPoint
            // 
            this.btnInsertInputPoint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertInputPoint.FlatAppearance.BorderSize = 0;
            this.btnInsertInputPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertInputPoint.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertInputPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertInputPoint.Image = global::StudentManagementApp.Properties.Resources.back;
            this.btnInsertInputPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertInputPoint.Location = new System.Drawing.Point(554, 428);
            this.btnInsertInputPoint.Name = "btnInsertInputPoint";
            this.btnInsertInputPoint.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnInsertInputPoint.Size = new System.Drawing.Size(143, 48);
            this.btnInsertInputPoint.TabIndex = 78;
            this.btnInsertInputPoint.Text = "Quay lại";
            this.btnInsertInputPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertInputPoint.UseVisualStyleBackColor = false;
            this.btnInsertInputPoint.Click += new System.EventHandler(this.btnInsertInputPoint_Click);
            // 
            // UserControlProcessView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInsertInputPoint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgvClassList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvRegisterList);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlProcessView";
            this.Size = new System.Drawing.Size(716, 482);
            this.Load += new System.EventHandler(this.UserControlProcessView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegisterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvRegisterList;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvClassList;
        private System.Windows.Forms.Button btnInsertInputPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Register;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ClassType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassType_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studying_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input_Date_Exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Receive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studying_Time_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Graduation;
    }
}
