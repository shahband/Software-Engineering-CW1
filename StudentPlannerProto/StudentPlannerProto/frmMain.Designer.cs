namespace StudentPlannerProto
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
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.dtePickerCurrentDate = new System.Windows.Forms.MonthCalendar();
            this.lstCurrentProjects = new System.Windows.Forms.ListView();
            this.lstAvailableProject = new System.Windows.Forms.ListBox();
            this.lblAvailableProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddProject
            // 
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.Location = new System.Drawing.Point(14, 449);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(90, 42);
            this.btnAddProject.TabIndex = 0;
            this.btnAddProject.Text = "ADD";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(192, 449);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 42);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(367, 449);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(90, 42);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "SETTINGS";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // dtePickerCurrentDate
            // 
            this.dtePickerCurrentDate.Location = new System.Drawing.Point(230, 24);
            this.dtePickerCurrentDate.Name = "dtePickerCurrentDate";
            this.dtePickerCurrentDate.TabIndex = 4;
            this.dtePickerCurrentDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dtePickerCurrentDate_DateChanged);
            // 
            // lstCurrentProjects
            // 
            this.lstCurrentProjects.HideSelection = false;
            this.lstCurrentProjects.Location = new System.Drawing.Point(230, 198);
            this.lstCurrentProjects.Name = "lstCurrentProjects";
            this.lstCurrentProjects.Size = new System.Drawing.Size(227, 234);
            this.lstCurrentProjects.TabIndex = 5;
            this.lstCurrentProjects.UseCompatibleStateImageBehavior = false;
            this.lstCurrentProjects.View = System.Windows.Forms.View.List;
            // 
            // lstAvailableProject
            // 
            this.lstAvailableProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAvailableProject.FormattingEnabled = true;
            this.lstAvailableProject.ItemHeight = 18;
            this.lstAvailableProject.Location = new System.Drawing.Point(14, 51);
            this.lstAvailableProject.Name = "lstAvailableProject";
            this.lstAvailableProject.Size = new System.Drawing.Size(204, 382);
            this.lstAvailableProject.TabIndex = 6;
            // 
            // lblAvailableProject
            // 
            this.lblAvailableProject.AutoSize = true;
            this.lblAvailableProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableProject.Location = new System.Drawing.Point(12, 24);
            this.lblAvailableProject.Name = "lblAvailableProject";
            this.lblAvailableProject.Size = new System.Drawing.Size(176, 24);
            this.lblAvailableProject.TabIndex = 7;
            this.lblAvailableProject.Text = "Available Projects";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 503);
            this.Controls.Add(this.lblAvailableProject);
            this.Controls.Add(this.lstAvailableProject);
            this.Controls.Add(this.lstCurrentProjects);
            this.Controls.Add(this.dtePickerCurrentDate);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddProject);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.MonthCalendar dtePickerCurrentDate;
        private System.Windows.Forms.ListView lstCurrentProjects;
        private System.Windows.Forms.ListBox lstAvailableProject;
        private System.Windows.Forms.Label lblAvailableProject;
    }
}

