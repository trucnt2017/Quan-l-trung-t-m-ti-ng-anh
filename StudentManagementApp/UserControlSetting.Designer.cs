namespace StudentManagementApp
{
    partial class UserControlSetting
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
            this.ID_Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvBlackList = new System.Windows.Forms.DataGridView();
            this.ID_BlackList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBlackList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 66;
            this.label1.Text = "Danh sách học viên hạn chế";
            // 
            // ID_Student
            // 
            this.ID_Student.DataPropertyName = "IdStudent";
            this.ID_Student.HeaderText = "Mã học viên";
            this.ID_Student.Name = "ID_Student";
            this.ID_Student.Width = 215;
            // 
            // Student_Name
            // 
            this.Student_Name.DataPropertyName = "StudentName";
            this.Student_Name.HeaderText = "Tên học viên";
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Width = 216;
            // 
            // IDClass
            // 
            this.IDClass.DataPropertyName = "IdClass";
            this.IDClass.HeaderText = "Mã lớp";
            this.IDClass.Name = "IDClass";
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Tên lớp";
            this.ClassName.Name = "ClassName";
            // 
            // dtgvBlackList
            // 
            this.dtgvBlackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBlackList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_BlackList,
            this.StudentID,
            this.StudentName,
            this.ClassID,
            this.Class_Name,
            this.SReason});
            this.dtgvBlackList.Location = new System.Drawing.Point(14, 36);
            this.dtgvBlackList.Name = "dtgvBlackList";
            this.dtgvBlackList.Size = new System.Drawing.Size(686, 435);
            this.dtgvBlackList.TabIndex = 67;
            // 
            // ID_BlackList
            // 
            this.ID_BlackList.DataPropertyName = "IdBlackList";
            this.ID_BlackList.HeaderText = "Mã hạn chế";
            this.ID_BlackList.Name = "ID_BlackList";
            this.ID_BlackList.Width = 70;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "IdStudent";
            this.StudentID.HeaderText = "Mã học viên";
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 70;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Tên học viên";
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 140;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "IdClass";
            this.ClassID.HeaderText = "Mã lớp";
            this.ClassID.Name = "ClassID";
            this.ClassID.Width = 70;
            // 
            // Class_Name
            // 
            this.Class_Name.DataPropertyName = "ClassName";
            this.Class_Name.HeaderText = "Tên lớp";
            this.Class_Name.Name = "Class_Name";
            this.Class_Name.Width = 190;
            // 
            // SReason
            // 
            this.SReason.DataPropertyName = "Reason";
            this.SReason.HeaderText = "Lý do";
            this.SReason.Name = "SReason";
            // 
            // UserControlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvBlackList);
            this.Controls.Add(this.label1);
            this.Name = "UserControlSetting";
            this.Size = new System.Drawing.Size(716, 482);
            this.Load += new System.EventHandler(this.UserControlSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBlackList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridView dtgvBlackList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BlackList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SReason;
    }
}
