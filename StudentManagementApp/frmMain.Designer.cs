namespace StudentManagementApp
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlBar = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbNameApp = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlManage = new System.Windows.Forms.Panel();
            this.pnlBar.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBar.Controls.Add(this.btnMin);
            this.pnlBar.Controls.Add(this.btnInfo);
            this.pnlBar.Controls.Add(this.btnExit);
            this.pnlBar.Controls.Add(this.lbNameApp);
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(875, 33);
            this.pnlBar.TabIndex = 0;
            this.pnlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseMove);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(785, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 23);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::StudentManagementApp.Properties.Resources.info;
            this.btnInfo.Location = new System.Drawing.Point(813, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(34, 23);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::StudentManagementApp.Properties.Resources.power;
            this.btnExit.Location = new System.Drawing.Point(841, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbNameApp
            // 
            this.lbNameApp.AutoSize = true;
            this.lbNameApp.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameApp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNameApp.Location = new System.Drawing.Point(259, 7);
            this.lbNameApp.Name = "lbNameApp";
            this.lbNameApp.Size = new System.Drawing.Size(354, 19);
            this.lbNameApp.TabIndex = 0;
            this.lbNameApp.Text = "Ứng dụng Quản lý học viên Trung tâm Tiếng Anh Phiên bản 1.0";
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlButton.Controls.Add(this.btnSettings);
            this.pnlButton.Controls.Add(this.btnExam);
            this.pnlButton.Controls.Add(this.btnProcess);
            this.pnlButton.Controls.Add(this.btnClass);
            this.pnlButton.Controls.Add(this.btnStudent);
            this.pnlButton.Controls.Add(this.btnRegister);
            this.pnlButton.Location = new System.Drawing.Point(-12, 27);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(186, 487);
            this.pnlButton.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSettings.Image = global::StudentManagementApp.Properties.Resources.settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(13, 405);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSettings.Size = new System.Drawing.Size(161, 80);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "   Danh sách\r\n   Hạn chế";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExam.FlatAppearance.BorderSize = 0;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExam.Image = global::StudentManagementApp.Properties.Resources.exam;
            this.btnExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExam.Location = new System.Drawing.Point(12, 325);
            this.btnExam.Name = "btnExam";
            this.btnExam.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnExam.Size = new System.Drawing.Size(161, 80);
            this.btnExam.TabIndex = 5;
            this.btnExam.Text = "Thi cử";
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcess.Image = global::StudentManagementApp.Properties.Resources.process;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(12, 245);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnProcess.Size = new System.Drawing.Size(202, 80);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Quá trình học";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClass.Image = global::StudentManagementApp.Properties.Resources.blackboard;
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(12, 165);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnClass.Size = new System.Drawing.Size(173, 80);
            this.btnClass.TabIndex = 3;
            this.btnClass.Text = "Lớp học";
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStudent.Image = global::StudentManagementApp.Properties.Resources.student;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(12, 85);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnStudent.Size = new System.Drawing.Size(175, 80);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Học viên";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.Image = global::StudentManagementApp.Properties.Resources.note;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(12, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnRegister.Size = new System.Drawing.Size(170, 80);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlManage
            // 
            this.pnlManage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlManage.Location = new System.Drawing.Point(159, 33);
            this.pnlManage.Name = "pnlManage";
            this.pnlManage.Size = new System.Drawing.Size(716, 482);
            this.pnlManage.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 513);
            this.Controls.Add(this.pnlManage);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.pnlButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbNameApp;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlManage;
        private System.Windows.Forms.Button btnMin;
    }
}