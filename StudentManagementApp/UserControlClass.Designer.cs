namespace StudentManagementApp
{
    partial class UserControlClass
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
            this.dtgClassType = new System.Windows.Forms.DataGridView();
            this.ID_ClassType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassType_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvClass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnDeleteClassType = new System.Windows.Forms.Button();
            this.btnEditClassType = new System.Windows.Forms.Button();
            this.btnAddClassType = new System.Windows.Forms.Button();
            this.ID_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studying_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_Week_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_Week_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDClassType_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassType_Name_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDClassLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassLevel_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClassType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgClassType
            // 
            this.dtgClassType.AllowUserToAddRows = false;
            this.dtgClassType.AllowUserToDeleteRows = false;
            this.dtgClassType.AllowUserToResizeColumns = false;
            this.dtgClassType.AllowUserToResizeRows = false;
            this.dtgClassType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClassType.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dtgClassType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClassType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ClassType,
            this.ClassType_Name});
            this.dtgClassType.Location = new System.Drawing.Point(8, 38);
            this.dtgClassType.Name = "dtgClassType";
            this.dtgClassType.Size = new System.Drawing.Size(700, 160);
            this.dtgClassType.TabIndex = 0;
            this.dtgClassType.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClassType_CellEnter);
            // 
            // ID_ClassType
            // 
            this.ID_ClassType.DataPropertyName = "ID_ClassType";
            this.ID_ClassType.HeaderText = "Mã Loại Lớp";
            this.ID_ClassType.Name = "ID_ClassType";
            // 
            // ClassType_Name
            // 
            this.ClassType_Name.DataPropertyName = "ClassType_Name";
            this.ClassType_Name.HeaderText = "Tên Loại Lớp";
            this.ClassType_Name.Name = "ClassType_Name";
            // 
            // dtgvClass
            // 
            this.dtgvClass.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dtgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Class,
            this.Class_Name,
            this.Total,
            this.Studying_Time,
            this.Date_of_Week_1,
            this.Date_of_Week_2,
            this.SYear,
            this.Semester,
            this.IDClassType_Class,
            this.ClassType_Name_Class,
            this.IDClassLevel,
            this.ClassLevel_Name,
            this.Class_Level});
            this.dtgvClass.Location = new System.Drawing.Point(9, 259);
            this.dtgvClass.Name = "dtgvClass";
            this.dtgvClass.Size = new System.Drawing.Size(700, 160);
            this.dtgvClass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 30);
            this.label1.TabIndex = 64;
            this.label1.Text = "Danh sách loại lớp và lớp học";
            // 
            // btnCancelClass
            // 
            this.btnCancelClass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelClass.FlatAppearance.BorderSize = 0;
            this.btnCancelClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelClass.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelClass.Image = global::StudentManagementApp.Properties.Resources.delete;
            this.btnCancelClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelClass.Location = new System.Drawing.Point(483, 424);
            this.btnCancelClass.Name = "btnCancelClass";
            this.btnCancelClass.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnCancelClass.Size = new System.Drawing.Size(143, 49);
            this.btnCancelClass.TabIndex = 67;
            this.btnCancelClass.Text = "Hủy lớp";
            this.btnCancelClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelClass.UseVisualStyleBackColor = false;
            this.btnCancelClass.Click += new System.EventHandler(this.btnCancelClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditClass.FlatAppearance.BorderSize = 0;
            this.btnEditClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClass.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditClass.Image = global::StudentManagementApp.Properties.Resources.edit;
            this.btnEditClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditClass.Location = new System.Drawing.Point(281, 425);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnEditClass.Size = new System.Drawing.Size(160, 49);
            this.btnEditClass.TabIndex = 66;
            this.btnEditClass.Text = "Chỉnh sửa";
            this.btnEditClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditClass.UseVisualStyleBackColor = false;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddClass.FlatAppearance.BorderSize = 0;
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClass.Image = global::StudentManagementApp.Properties.Resources.plus;
            this.btnAddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClass.Location = new System.Drawing.Point(99, 424);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnAddClass.Size = new System.Drawing.Size(131, 49);
            this.btnAddClass.TabIndex = 65;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnDeleteClassType
            // 
            this.btnDeleteClassType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteClassType.FlatAppearance.BorderSize = 0;
            this.btnDeleteClassType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClassType.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClassType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteClassType.Image = global::StudentManagementApp.Properties.Resources.delete;
            this.btnDeleteClassType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClassType.Location = new System.Drawing.Point(483, 204);
            this.btnDeleteClassType.Name = "btnDeleteClassType";
            this.btnDeleteClassType.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnDeleteClassType.Size = new System.Drawing.Size(143, 49);
            this.btnDeleteClassType.TabIndex = 63;
            this.btnDeleteClassType.Text = "Xóa";
            this.btnDeleteClassType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteClassType.UseVisualStyleBackColor = false;
            this.btnDeleteClassType.Click += new System.EventHandler(this.btnDeleteClassType_Click);
            // 
            // btnEditClassType
            // 
            this.btnEditClassType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditClassType.FlatAppearance.BorderSize = 0;
            this.btnEditClassType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClassType.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClassType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditClassType.Image = global::StudentManagementApp.Properties.Resources.edit;
            this.btnEditClassType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditClassType.Location = new System.Drawing.Point(281, 205);
            this.btnEditClassType.Name = "btnEditClassType";
            this.btnEditClassType.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnEditClassType.Size = new System.Drawing.Size(160, 49);
            this.btnEditClassType.TabIndex = 62;
            this.btnEditClassType.Text = "Chỉnh sửa";
            this.btnEditClassType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditClassType.UseVisualStyleBackColor = false;
            this.btnEditClassType.Click += new System.EventHandler(this.btnEditClassType_Click);
            // 
            // btnAddClassType
            // 
            this.btnAddClassType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddClassType.FlatAppearance.BorderSize = 0;
            this.btnAddClassType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClassType.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClassType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClassType.Image = global::StudentManagementApp.Properties.Resources.plus;
            this.btnAddClassType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClassType.Location = new System.Drawing.Point(99, 204);
            this.btnAddClassType.Name = "btnAddClassType";
            this.btnAddClassType.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnAddClassType.Size = new System.Drawing.Size(131, 49);
            this.btnAddClassType.TabIndex = 61;
            this.btnAddClassType.Text = "Thêm";
            this.btnAddClassType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddClassType.UseVisualStyleBackColor = false;
            this.btnAddClassType.Click += new System.EventHandler(this.btnAddClassType_Click);
            // 
            // ID_Class
            // 
            this.ID_Class.DataPropertyName = "IDClass";
            this.ID_Class.HeaderText = "Mã Lớp";
            this.ID_Class.Name = "ID_Class";
            this.ID_Class.Width = 45;
            // 
            // Class_Name
            // 
            this.Class_Name.DataPropertyName = "ClassName";
            this.Class_Name.HeaderText = "Tên lớp";
            this.Class_Name.Name = "Class_Name";
            this.Class_Name.Width = 200;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Sĩ số";
            this.Total.Name = "Total";
            this.Total.Width = 50;
            // 
            // Studying_Time
            // 
            this.Studying_Time.DataPropertyName = "StudyingTime";
            this.Studying_Time.HeaderText = "Giờ học";
            this.Studying_Time.Name = "Studying_Time";
            this.Studying_Time.Width = 50;
            // 
            // Date_of_Week_1
            // 
            this.Date_of_Week_1.DataPropertyName = "Date1";
            this.Date_of_Week_1.HeaderText = "Ngày học 1";
            this.Date_of_Week_1.Name = "Date_of_Week_1";
            this.Date_of_Week_1.Width = 55;
            // 
            // Date_of_Week_2
            // 
            this.Date_of_Week_2.DataPropertyName = "Date2";
            this.Date_of_Week_2.HeaderText = "Ngày học 2";
            this.Date_of_Week_2.Name = "Date_of_Week_2";
            this.Date_of_Week_2.Width = 55;
            // 
            // SYear
            // 
            this.SYear.DataPropertyName = "SYear";
            this.SYear.HeaderText = "Năm học";
            this.SYear.Name = "SYear";
            this.SYear.Width = 50;
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "Semester";
            this.Semester.HeaderText = "Kỳ học";
            this.Semester.Name = "Semester";
            this.Semester.Width = 50;
            // 
            // IDClassType_Class
            // 
            this.IDClassType_Class.DataPropertyName = "ClassTypeID";
            this.IDClassType_Class.HeaderText = "Mã Loại Lớp";
            this.IDClassType_Class.Name = "IDClassType_Class";
            this.IDClassType_Class.Width = 50;
            // 
            // ClassType_Name_Class
            // 
            this.ClassType_Name_Class.DataPropertyName = "ClassTypeName";
            this.ClassType_Name_Class.HeaderText = "Tên Loại Lớp";
            this.ClassType_Name_Class.Name = "ClassType_Name_Class";
            this.ClassType_Name_Class.Width = 200;
            // 
            // IDClassLevel
            // 
            this.IDClassLevel.DataPropertyName = "ClassLevelID";
            this.IDClassLevel.HeaderText = "Mã Cấp Lớp";
            this.IDClassLevel.Name = "IDClassLevel";
            this.IDClassLevel.Width = 50;
            // 
            // ClassLevel_Name
            // 
            this.ClassLevel_Name.DataPropertyName = "ClassLevelName";
            this.ClassLevel_Name.HeaderText = "Tên Cấp Độ";
            this.ClassLevel_Name.Name = "ClassLevel_Name";
            // 
            // Class_Level
            // 
            this.Class_Level.DataPropertyName = "ClassLevel";
            this.Class_Level.HeaderText = "Cấp Độ";
            this.Class_Level.Name = "Class_Level";
            // 
            // UserControlClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelClass);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteClassType);
            this.Controls.Add(this.btnEditClassType);
            this.Controls.Add(this.btnAddClassType);
            this.Controls.Add(this.dtgvClass);
            this.Controls.Add(this.dtgClassType);
            this.Name = "UserControlClass";
            this.Size = new System.Drawing.Size(716, 482);
            this.Load += new System.EventHandler(this.UserControlClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClassType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgClassType;
        private System.Windows.Forms.DataGridView dtgvClass;
        private System.Windows.Forms.Button btnAddClassType;
        private System.Windows.Forms.Button btnEditClassType;
        private System.Windows.Forms.Button btnDeleteClassType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ClassType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassType_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Studying_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_Week_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_Week_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDClassType_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassType_Name_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDClassLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassLevel_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Level;
    }
}
