namespace StudentManagementApp
{
    partial class UserControlProcess
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClassList = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.dtgvStudyingProcess = new System.Windows.Forms.DataGridView();
            this.btnInsertProcessPoint = new System.Windows.Forms.Button();
            this.btnHardPoint = new System.Windows.Forms.Button();
            this.ID_Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hard_Point = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.Listening = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.Reading = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.Writing = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.Speaking = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.SMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudyingProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 30);
            this.label1.TabIndex = 66;
            this.label1.Text = "Chi tiết quá trình học theo lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "Danh sách lớp học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "Thời gian (tháng) :";
            // 
            // cbClassList
            // 
            this.cbClassList.FormattingEnabled = true;
            this.cbClassList.Location = new System.Drawing.Point(115, 42);
            this.cbClassList.Name = "cbClassList";
            this.cbClassList.Size = new System.Drawing.Size(275, 21);
            this.cbClassList.TabIndex = 69;
            this.cbClassList.SelectedIndexChanged += new System.EventHandler(this.cbClassList_SelectedIndexChanged);
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbMonth.Location = new System.Drawing.Point(517, 42);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(103, 21);
            this.cbMonth.TabIndex = 70;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // dtgvStudyingProcess
            // 
            this.dtgvStudyingProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStudyingProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Student,
            this.ID_StudentName,
            this.Hard_Point,
            this.Listening,
            this.Reading,
            this.Writing,
            this.Speaking,
            this.SMonth});
            this.dtgvStudyingProcess.Location = new System.Drawing.Point(9, 74);
            this.dtgvStudyingProcess.Name = "dtgvStudyingProcess";
            this.dtgvStudyingProcess.Size = new System.Drawing.Size(695, 335);
            this.dtgvStudyingProcess.TabIndex = 71;
            // 
            // btnInsertProcessPoint
            // 
            this.btnInsertProcessPoint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertProcessPoint.FlatAppearance.BorderSize = 0;
            this.btnInsertProcessPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertProcessPoint.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertProcessPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertProcessPoint.Image = global::StudentManagementApp.Properties.Resources.note;
            this.btnInsertProcessPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertProcessPoint.Location = new System.Drawing.Point(381, 415);
            this.btnInsertProcessPoint.Name = "btnInsertProcessPoint";
            this.btnInsertProcessPoint.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnInsertProcessPoint.Size = new System.Drawing.Size(154, 58);
            this.btnInsertProcessPoint.TabIndex = 73;
            this.btnInsertProcessPoint.Text = "Lưu điểm\r\nquá trình\r\n";
            this.btnInsertProcessPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertProcessPoint.UseVisualStyleBackColor = false;
            this.btnInsertProcessPoint.Click += new System.EventHandler(this.btnInsertProcessPoint_Click);
            // 
            // btnHardPoint
            // 
            this.btnHardPoint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHardPoint.FlatAppearance.BorderSize = 0;
            this.btnHardPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardPoint.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHardPoint.Image = global::StudentManagementApp.Properties.Resources.hard;
            this.btnHardPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHardPoint.Location = new System.Drawing.Point(192, 415);
            this.btnHardPoint.Name = "btnHardPoint";
            this.btnHardPoint.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnHardPoint.Size = new System.Drawing.Size(164, 58);
            this.btnHardPoint.TabIndex = 72;
            this.btnHardPoint.Text = "Lưu điểm\r\nchuyên cần\r\n\r\n";
            this.btnHardPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHardPoint.UseVisualStyleBackColor = false;
            this.btnHardPoint.Click += new System.EventHandler(this.btnHardPoint_Click);
            // 
            // ID_Student
            // 
            this.ID_Student.DataPropertyName = "IdStudent";
            this.ID_Student.HeaderText = "Mã học viên";
            this.ID_Student.Name = "ID_Student";
            this.ID_Student.Width = 60;
            // 
            // ID_StudentName
            // 
            this.ID_StudentName.DataPropertyName = "StudentName";
            this.ID_StudentName.HeaderText = "Mã Lớp";
            this.ID_StudentName.Name = "ID_StudentName";
            this.ID_StudentName.Width = 200;
            // 
            // Hard_Point
            // 
            this.Hard_Point.DataPropertyName = "HardPoint";
            this.Hard_Point.HeaderText = "Điểm chuyên cần";
            this.Hard_Point.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Hard_Point.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Hard_Point.Name = "Hard_Point";
            this.Hard_Point.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hard_Point.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Hard_Point.Width = 80;
            // 
            // Listening
            // 
            this.Listening.DataPropertyName = "Listening";
            this.Listening.HeaderText = "Điểm nghe";
            this.Listening.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Listening.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.Listening.Name = "Listening";
            this.Listening.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Listening.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Listening.Width = 65;
            // 
            // Reading
            // 
            this.Reading.DataPropertyName = "Reading";
            this.Reading.HeaderText = "Điểm đọc";
            this.Reading.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Reading.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.Reading.Name = "Reading";
            this.Reading.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reading.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reading.Width = 65;
            // 
            // Writing
            // 
            this.Writing.DataPropertyName = "Writing";
            this.Writing.HeaderText = "Điểm viết";
            this.Writing.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Writing.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.Writing.Name = "Writing";
            this.Writing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Writing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Writing.Width = 65;
            // 
            // Speaking
            // 
            this.Speaking.DataPropertyName = "Speaking";
            this.Speaking.HeaderText = "Điểm nói";
            this.Speaking.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Speaking.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.Speaking.Name = "Speaking";
            this.Speaking.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Speaking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Speaking.Width = 65;
            // 
            // SMonth
            // 
            this.SMonth.DataPropertyName = "SMonth";
            this.SMonth.HeaderText = "Tháng";
            this.SMonth.Name = "SMonth";
            this.SMonth.Width = 50;
            // 
            // UserControlProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInsertProcessPoint);
            this.Controls.Add(this.btnHardPoint);
            this.Controls.Add(this.dtgvStudyingProcess);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbClassList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlProcess";
            this.Size = new System.Drawing.Size(716, 482);
            this.Load += new System.EventHandler(this.UserControlProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudyingProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClassList;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.DataGridView dtgvStudyingProcess;
        private System.Windows.Forms.Button btnHardPoint;
        private System.Windows.Forms.Button btnInsertProcessPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_StudentName;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn Hard_Point;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn Listening;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn Reading;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn Writing;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn Speaking;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMonth;
    }
}
