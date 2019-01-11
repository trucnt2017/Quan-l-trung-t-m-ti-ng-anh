namespace StudentManagementApp
{
    partial class UserControlExam
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
            this.cbClassList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvOutputExam = new System.Windows.Forms.DataGridView();
            this.ID_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.Graduation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuitExam = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbClassType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertOutputPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOutputExam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 30);
            this.label1.TabIndex = 67;
            this.label1.Text = "Quản lý đầu ra trung tâm";
            // 
            // cbClassList
            // 
            this.cbClassList.FormattingEnabled = true;
            this.cbClassList.Location = new System.Drawing.Point(431, 33);
            this.cbClassList.Name = "cbClassList";
            this.cbClassList.Size = new System.Drawing.Size(267, 21);
            this.cbClassList.TabIndex = 71;
            this.cbClassList.SelectedIndexChanged += new System.EventHandler(this.cbClassList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Lớp học :";
            // 
            // dtgvOutputExam
            // 
            this.dtgvOutputExam.AllowUserToAddRows = false;
            this.dtgvOutputExam.AllowUserToDeleteRows = false;
            this.dtgvOutputExam.AllowUserToResizeColumns = false;
            this.dtgvOutputExam.AllowUserToResizeRows = false;
            this.dtgvOutputExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOutputExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Class,
            this.ID_Student,
            this.Student_Name,
            this.Point,
            this.Graduation,
            this.QuitExam});
            this.dtgvOutputExam.Location = new System.Drawing.Point(11, 63);
            this.dtgvOutputExam.Name = "dtgvOutputExam";
            this.dtgvOutputExam.Size = new System.Drawing.Size(687, 345);
            this.dtgvOutputExam.TabIndex = 77;
            this.dtgvOutputExam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOutputExam_CellContentClick);
            // 
            // ID_Class
            // 
            this.ID_Class.DataPropertyName = "IdClass";
            this.ID_Class.HeaderText = "Mã lớp";
            this.ID_Class.Name = "ID_Class";
            this.ID_Class.Width = 80;
            // 
            // ID_Student
            // 
            this.ID_Student.DataPropertyName = "IdStudent";
            this.ID_Student.HeaderText = "Mã học viên";
            this.ID_Student.Name = "ID_Student";
            this.ID_Student.Width = 88;
            // 
            // Student_Name
            // 
            this.Student_Name.DataPropertyName = "StudentName";
            this.Student_Name.HeaderText = "Tên học viên";
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Width = 186;
            // 
            // Point
            // 
            this.Point.DataPropertyName = "Point";
            this.Point.HeaderText = "Điểm thi";
            this.Point.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Point.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Point.Name = "Point";
            this.Point.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Point.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Graduation
            // 
            this.Graduation.DataPropertyName = "Graduation";
            this.Graduation.HeaderText = "Xếp loại";
            this.Graduation.Name = "Graduation";
            this.Graduation.Width = 120;
            // 
            // QuitExam
            // 
            this.QuitExam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.QuitExam.HeaderText = "Bỏ thi";
            this.QuitExam.Name = "QuitExam";
            this.QuitExam.Text = "X";
            this.QuitExam.UseColumnTextForButtonValue = true;
            this.QuitExam.Width = 70;
            // 
            // cbClassType
            // 
            this.cbClassType.FormattingEnabled = true;
            this.cbClassType.Location = new System.Drawing.Point(76, 34);
            this.cbClassType.Name = "cbClassType";
            this.cbClassType.Size = new System.Drawing.Size(263, 21);
            this.cbClassType.TabIndex = 81;
            this.cbClassType.SelectedIndexChanged += new System.EventHandler(this.cbClassType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 80;
            this.label3.Text = "Loại lớp :";
            // 
            // btnInsertOutputPoint
            // 
            this.btnInsertOutputPoint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertOutputPoint.FlatAppearance.BorderSize = 0;
            this.btnInsertOutputPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertOutputPoint.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertOutputPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertOutputPoint.Image = global::StudentManagementApp.Properties.Resources.note;
            this.btnInsertOutputPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertOutputPoint.Location = new System.Drawing.Point(284, 414);
            this.btnInsertOutputPoint.Name = "btnInsertOutputPoint";
            this.btnInsertOutputPoint.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnInsertOutputPoint.Size = new System.Drawing.Size(181, 58);
            this.btnInsertOutputPoint.TabIndex = 79;
            this.btnInsertOutputPoint.Text = "Lưu điểm thi\r\n";
            this.btnInsertOutputPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertOutputPoint.UseVisualStyleBackColor = false;
            this.btnInsertOutputPoint.Click += new System.EventHandler(this.btnInsertOutputPoint_Click);
            // 
            // UserControlExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbClassType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertOutputPoint);
            this.Controls.Add(this.dtgvOutputExam);
            this.Controls.Add(this.cbClassList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlExam";
            this.Size = new System.Drawing.Size(716, 482);
            this.Load += new System.EventHandler(this.UserControlExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOutputExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClassList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvOutputExam;
        private System.Windows.Forms.Button btnInsertOutputPoint;
        private System.Windows.Forms.ComboBox cbClassType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Graduation;
        private System.Windows.Forms.DataGridViewButtonColumn QuitExam;
    }
}
