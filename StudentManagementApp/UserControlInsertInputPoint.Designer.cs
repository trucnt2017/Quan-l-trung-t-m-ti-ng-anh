namespace StudentManagementApp
{
    partial class UserControlInsertInputPoint
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvClassFilter = new System.Windows.Forms.DataGridView();
            this.ID_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ClassLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassLevel_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studying_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_Week_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_Week_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsertInputPoint = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nhập điểm thi đầu vào";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(99, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 20);
            this.txtID.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Mã học viên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(257, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 83;
            this.label4.Text = "Họ tên học viên:";
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(505, 45);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(103, 20);
            this.txtPoint.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "Điểm thi:";
            // 
            // dtgvClassFilter
            // 
            this.dtgvClassFilter.AllowUserToAddRows = false;
            this.dtgvClassFilter.AllowUserToDeleteRows = false;
            this.dtgvClassFilter.AllowUserToResizeColumns = false;
            this.dtgvClassFilter.AllowUserToResizeRows = false;
            this.dtgvClassFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClassFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Class,
            this.Class_Name,
            this.ID_ClassLevel,
            this.ClassLevel_Name,
            this.Studying_Time,
            this.Date_of_Week_1,
            this.Date_of_Week_2});
            this.dtgvClassFilter.Location = new System.Drawing.Point(18, 111);
            this.dtgvClassFilter.Name = "dtgvClassFilter";
            this.dtgvClassFilter.ReadOnly = true;
            this.dtgvClassFilter.Size = new System.Drawing.Size(682, 281);
            this.dtgvClassFilter.TabIndex = 87;
            // 
            // ID_Class
            // 
            this.ID_Class.DataPropertyName = "IDClass";
            this.ID_Class.FillWeight = 32.7863F;
            this.ID_Class.HeaderText = "Mã Lớp";
            this.ID_Class.Name = "ID_Class";
            this.ID_Class.ReadOnly = true;
            this.ID_Class.Width = 60;
            // 
            // Class_Name
            // 
            this.Class_Name.DataPropertyName = "ClassName";
            this.Class_Name.FillWeight = 593.401F;
            this.Class_Name.HeaderText = "Tên Lớp";
            this.Class_Name.Name = "Class_Name";
            this.Class_Name.ReadOnly = true;
            this.Class_Name.Width = 200;
            // 
            // ID_ClassLevel
            // 
            this.ID_ClassLevel.DataPropertyName = "ClassLevelID";
            this.ID_ClassLevel.FillWeight = 26.76681F;
            this.ID_ClassLevel.HeaderText = "Mã cấp độ";
            this.ID_ClassLevel.Name = "ID_ClassLevel";
            this.ID_ClassLevel.ReadOnly = true;
            this.ID_ClassLevel.Width = 70;
            // 
            // ClassLevel_Name
            // 
            this.ClassLevel_Name.DataPropertyName = "ClassLevelName";
            this.ClassLevel_Name.FillWeight = 26.76681F;
            this.ClassLevel_Name.HeaderText = "Tên cấp độ";
            this.ClassLevel_Name.Name = "ClassLevel_Name";
            this.ClassLevel_Name.ReadOnly = true;
            // 
            // Studying_Time
            // 
            this.Studying_Time.DataPropertyName = "StudyingTime";
            this.Studying_Time.FillWeight = 6.759696F;
            this.Studying_Time.HeaderText = "Thời gian học";
            this.Studying_Time.Name = "Studying_Time";
            this.Studying_Time.ReadOnly = true;
            this.Studying_Time.Width = 88;
            // 
            // Date_of_Week_1
            // 
            this.Date_of_Week_1.DataPropertyName = "Date1";
            this.Date_of_Week_1.FillWeight = 6.759696F;
            this.Date_of_Week_1.HeaderText = "Buổi 1";
            this.Date_of_Week_1.Name = "Date_of_Week_1";
            this.Date_of_Week_1.ReadOnly = true;
            this.Date_of_Week_1.Width = 60;
            // 
            // Date_of_Week_2
            // 
            this.Date_of_Week_2.DataPropertyName = "Date2";
            this.Date_of_Week_2.FillWeight = 6.759696F;
            this.Date_of_Week_2.HeaderText = "Buổi 2";
            this.Date_of_Week_2.Name = "Date_of_Week_2";
            this.Date_of_Week_2.ReadOnly = true;
            this.Date_of_Week_2.Width = 60;
            // 
            // btnInsertInputPoint
            // 
            this.btnInsertInputPoint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertInputPoint.FlatAppearance.BorderSize = 0;
            this.btnInsertInputPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertInputPoint.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertInputPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertInputPoint.Image = global::StudentManagementApp.Properties.Resources.plus;
            this.btnInsertInputPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertInputPoint.Location = new System.Drawing.Point(198, 398);
            this.btnInsertInputPoint.Name = "btnInsertInputPoint";
            this.btnInsertInputPoint.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnInsertInputPoint.Size = new System.Drawing.Size(172, 69);
            this.btnInsertInputPoint.TabIndex = 78;
            this.btnInsertInputPoint.Text = "Đăng ký lớp";
            this.btnInsertInputPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertInputPoint.UseVisualStyleBackColor = false;
            this.btnInsertInputPoint.Click += new System.EventHandler(this.btnInsertInputPoint_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilter.Location = new System.Drawing.Point(614, 40);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(86, 28);
            this.btnFilter.TabIndex = 90;
            this.btnFilter.Text = "Lưu điểm";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(290, 72);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(182, 20);
            this.txtClassName.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 93;
            this.label5.Text = "Tên lớp:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(105, 72);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(103, 20);
            this.txtClassID.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "Đang học lớp:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(568, 74);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(132, 20);
            this.txtStatus.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(492, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 95;
            this.label7.Text = "Trạng thái:";
            // 
            // btnReRegister
            // 
            this.btnReRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReRegister.FlatAppearance.BorderSize = 0;
            this.btnReRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReRegister.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReRegister.Image = global::StudentManagementApp.Properties.Resources.arrange;
            this.btnReRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReRegister.Location = new System.Drawing.Point(386, 398);
            this.btnReRegister.Name = "btnReRegister";
            this.btnReRegister.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnReRegister.Size = new System.Drawing.Size(176, 69);
            this.btnReRegister.TabIndex = 97;
            this.btnReRegister.Text = "Đăng Ký Lớp\r\n(học viên cũ)";
            this.btnReRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReRegister.UseVisualStyleBackColor = false;
            this.btnReRegister.Click += new System.EventHandler(this.btnReRegister_Click);
            // 
            // UserControlInsertInputPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReRegister);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtgvClassFilter);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsertInputPoint);
            this.Controls.Add(this.label1);
            this.Name = "UserControlInsertInputPoint";
            this.Size = new System.Drawing.Size(716, 482);
            this.Load += new System.EventHandler(this.UserControlInsertInputPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertInputPoint;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvClassFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ClassLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassLevel_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studying_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_Week_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_Week_2;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReRegister;
    }
}
