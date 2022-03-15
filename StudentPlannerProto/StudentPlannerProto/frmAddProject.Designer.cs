namespace StudentPlannerProto
{
    partial class frmAddProject
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAllocation = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblContingency = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtAllocationTime = new System.Windows.Forms.TextBox();
            this.dbxContingency = new System.Windows.Forms.ComboBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.dtePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.gbxAddProject = new System.Windows.Forms.GroupBox();
            this.gbxAddProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Project Name:";
            // 
            // lblAllocation
            // 
            this.lblAllocation.AutoSize = true;
            this.lblAllocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocation.Location = new System.Drawing.Point(6, 70);
            this.lblAllocation.Name = "lblAllocation";
            this.lblAllocation.Size = new System.Drawing.Size(137, 16);
            this.lblAllocation.TabIndex = 1;
            this.lblAllocation.Text = "Allocation Time (HR): ";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(6, 109);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(65, 16);
            this.lblDeadline.TabIndex = 2;
            this.lblDeadline.Text = "Deadline:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(8, 146);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(72, 16);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Start Date: ";
            // 
            // lblContingency
            // 
            this.lblContingency.AutoSize = true;
            this.lblContingency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContingency.Location = new System.Drawing.Point(6, 185);
            this.lblContingency.Name = "lblContingency";
            this.lblContingency.Size = new System.Drawing.Size(153, 16);
            this.lblContingency.TabIndex = 4;
            this.lblContingency.Text = "Contingency Time (WK): ";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(173, 30);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(272, 22);
            this.txtProjectName.TabIndex = 5;
            // 
            // txtAllocationTime
            // 
            this.txtAllocationTime.Location = new System.Drawing.Point(173, 67);
            this.txtAllocationTime.Name = "txtAllocationTime";
            this.txtAllocationTime.Size = new System.Drawing.Size(272, 22);
            this.txtAllocationTime.TabIndex = 6;
            // 
            // dbxContingency
            // 
            this.dbxContingency.FormattingEnabled = true;
            this.dbxContingency.Location = new System.Drawing.Point(173, 182);
            this.dbxContingency.Name = "dbxContingency";
            this.dbxContingency.Size = new System.Drawing.Size(272, 24);
            this.dbxContingency.TabIndex = 13;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(6, 232);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(74, 16);
            this.lblComment.TabIndex = 14;
            this.lblComment.Text = "Comments:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(9, 252);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(436, 184);
            this.txtComment.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 34);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(201, 34);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtePickerDeadline
            // 
            this.dtePickerDeadline.Location = new System.Drawing.Point(173, 104);
            this.dtePickerDeadline.Name = "dtePickerDeadline";
            this.dtePickerDeadline.Size = new System.Drawing.Size(272, 22);
            this.dtePickerDeadline.TabIndex = 18;
            // 
            // dtePickerStartDate
            // 
            this.dtePickerStartDate.Location = new System.Drawing.Point(173, 141);
            this.dtePickerStartDate.Name = "dtePickerStartDate";
            this.dtePickerStartDate.Size = new System.Drawing.Size(272, 22);
            this.dtePickerStartDate.TabIndex = 19;
            // 
            // gbxAddProject
            // 
            this.gbxAddProject.BackColor = System.Drawing.SystemColors.Control;
            this.gbxAddProject.Controls.Add(this.dtePickerStartDate);
            this.gbxAddProject.Controls.Add(this.dtePickerDeadline);
            this.gbxAddProject.Controls.Add(this.btnCancel);
            this.gbxAddProject.Controls.Add(this.btnSave);
            this.gbxAddProject.Controls.Add(this.txtComment);
            this.gbxAddProject.Controls.Add(this.lblComment);
            this.gbxAddProject.Controls.Add(this.dbxContingency);
            this.gbxAddProject.Controls.Add(this.txtAllocationTime);
            this.gbxAddProject.Controls.Add(this.txtProjectName);
            this.gbxAddProject.Controls.Add(this.lblContingency);
            this.gbxAddProject.Controls.Add(this.lblStart);
            this.gbxAddProject.Controls.Add(this.lblDeadline);
            this.gbxAddProject.Controls.Add(this.lblAllocation);
            this.gbxAddProject.Controls.Add(this.lblName);
            this.gbxAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddProject.Location = new System.Drawing.Point(12, 12);
            this.gbxAddProject.Name = "gbxAddProject";
            this.gbxAddProject.Size = new System.Drawing.Size(451, 483);
            this.gbxAddProject.TabIndex = 0;
            this.gbxAddProject.TabStop = false;
            this.gbxAddProject.Text = "Add Project";
            // 
            // frmAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 503);
            this.Controls.Add(this.gbxAddProject);
            this.Name = "frmAddProject";
            this.Text = "Form2";
            this.gbxAddProject.ResumeLayout(false);
            this.gbxAddProject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAllocation;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblContingency;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtAllocationTime;
        private System.Windows.Forms.ComboBox dbxContingency;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtePickerDeadline;
        private System.Windows.Forms.DateTimePicker dtePickerStartDate;
        private System.Windows.Forms.GroupBox gbxAddProject;
    }
}