namespace StudentPlannerProto
{
    partial class frmSettings
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
            this.gbxHoursAvailable = new System.Windows.Forms.GroupBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.dbxSaturday = new System.Windows.Forms.ComboBox();
            this.dbxFriday = new System.Windows.Forms.ComboBox();
            this.dbxThursday = new System.Windows.Forms.ComboBox();
            this.dbxWednesday = new System.Windows.Forms.ComboBox();
            this.dbxTuesday = new System.Windows.Forms.ComboBox();
            this.dbxMonday = new System.Windows.Forms.ComboBox();
            this.dbxSunday = new System.Windows.Forms.ComboBox();
            this.lblSettings = new System.Windows.Forms.Label();
            this.gbxUnavailable = new System.Windows.Forms.GroupBox();
            this.btnSettingRemove = new System.Windows.Forms.Button();
            this.btnSettingsAdd = new System.Windows.Forms.Button();
            this.dtePickerUnavailable = new System.Windows.Forms.DateTimePicker();
            this.lstUnavailable = new System.Windows.Forms.ListBox();
            this.btnSettingBack = new System.Windows.Forms.Button();
            this.gbxHoursAvailable.SuspendLayout();
            this.gbxUnavailable.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHoursAvailable
            // 
            this.gbxHoursAvailable.Controls.Add(this.btnSaveSettings);
            this.gbxHoursAvailable.Controls.Add(this.lblSaturday);
            this.gbxHoursAvailable.Controls.Add(this.lblFriday);
            this.gbxHoursAvailable.Controls.Add(this.lblThursday);
            this.gbxHoursAvailable.Controls.Add(this.lblWednesday);
            this.gbxHoursAvailable.Controls.Add(this.lblTuesday);
            this.gbxHoursAvailable.Controls.Add(this.lblMonday);
            this.gbxHoursAvailable.Controls.Add(this.lblSunday);
            this.gbxHoursAvailable.Controls.Add(this.dbxSaturday);
            this.gbxHoursAvailable.Controls.Add(this.dbxFriday);
            this.gbxHoursAvailable.Controls.Add(this.dbxThursday);
            this.gbxHoursAvailable.Controls.Add(this.dbxWednesday);
            this.gbxHoursAvailable.Controls.Add(this.dbxTuesday);
            this.gbxHoursAvailable.Controls.Add(this.dbxMonday);
            this.gbxHoursAvailable.Controls.Add(this.dbxSunday);
            this.gbxHoursAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHoursAvailable.Location = new System.Drawing.Point(12, 47);
            this.gbxHoursAvailable.Name = "gbxHoursAvailable";
            this.gbxHoursAvailable.Size = new System.Drawing.Size(451, 280);
            this.gbxHoursAvailable.TabIndex = 0;
            this.gbxHoursAvailable.TabStop = false;
            this.gbxHoursAvailable.Text = "Hours Available:";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(176, 231);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(90, 42);
            this.btnSaveSettings.TabIndex = 14;
            this.btnSaveSettings.Text = "SAVE";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturday.Location = new System.Drawing.Point(5, 204);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(64, 16);
            this.lblSaturday.TabIndex = 13;
            this.lblSaturday.Text = "Saturday:";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriday.Location = new System.Drawing.Point(6, 174);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(48, 16);
            this.lblFriday.TabIndex = 12;
            this.lblFriday.Text = "Friday:";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThursday.Location = new System.Drawing.Point(6, 144);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(67, 16);
            this.lblThursday.TabIndex = 11;
            this.lblThursday.Text = "Thursday:";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWednesday.Location = new System.Drawing.Point(6, 114);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(84, 16);
            this.lblWednesday.TabIndex = 10;
            this.lblWednesday.Text = "Wednesday:";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesday.Location = new System.Drawing.Point(6, 84);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(64, 16);
            this.lblTuesday.TabIndex = 9;
            this.lblTuesday.Text = "Tuesday:";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonday.Location = new System.Drawing.Point(6, 54);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(59, 16);
            this.lblMonday.TabIndex = 8;
            this.lblMonday.Text = "Monday:";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunday.Location = new System.Drawing.Point(6, 24);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(56, 16);
            this.lblSunday.TabIndex = 7;
            this.lblSunday.Text = "Sunday:";
            // 
            // dbxSaturday
            // 
            this.dbxSaturday.FormattingEnabled = true;
            this.dbxSaturday.Location = new System.Drawing.Point(135, 201);
            this.dbxSaturday.Name = "dbxSaturday";
            this.dbxSaturday.Size = new System.Drawing.Size(308, 24);
            this.dbxSaturday.TabIndex = 6;
            // 
            // dbxFriday
            // 
            this.dbxFriday.FormattingEnabled = true;
            this.dbxFriday.Location = new System.Drawing.Point(135, 171);
            this.dbxFriday.Name = "dbxFriday";
            this.dbxFriday.Size = new System.Drawing.Size(308, 24);
            this.dbxFriday.TabIndex = 5;
            // 
            // dbxThursday
            // 
            this.dbxThursday.FormattingEnabled = true;
            this.dbxThursday.Location = new System.Drawing.Point(135, 141);
            this.dbxThursday.Name = "dbxThursday";
            this.dbxThursday.Size = new System.Drawing.Size(308, 24);
            this.dbxThursday.TabIndex = 4;
            // 
            // dbxWednesday
            // 
            this.dbxWednesday.FormattingEnabled = true;
            this.dbxWednesday.Location = new System.Drawing.Point(135, 111);
            this.dbxWednesday.Name = "dbxWednesday";
            this.dbxWednesday.Size = new System.Drawing.Size(308, 24);
            this.dbxWednesday.TabIndex = 3;
            // 
            // dbxTuesday
            // 
            this.dbxTuesday.FormattingEnabled = true;
            this.dbxTuesday.Location = new System.Drawing.Point(135, 81);
            this.dbxTuesday.Name = "dbxTuesday";
            this.dbxTuesday.Size = new System.Drawing.Size(308, 24);
            this.dbxTuesday.TabIndex = 2;
            // 
            // dbxMonday
            // 
            this.dbxMonday.FormattingEnabled = true;
            this.dbxMonday.Location = new System.Drawing.Point(135, 51);
            this.dbxMonday.Name = "dbxMonday";
            this.dbxMonday.Size = new System.Drawing.Size(308, 24);
            this.dbxMonday.TabIndex = 1;
            // 
            // dbxSunday
            // 
            this.dbxSunday.FormattingEnabled = true;
            this.dbxSunday.Location = new System.Drawing.Point(135, 21);
            this.dbxSunday.Name = "dbxSunday";
            this.dbxSunday.Size = new System.Drawing.Size(310, 24);
            this.dbxSunday.TabIndex = 0;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(184, 20);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(84, 24);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "Settings";
            // 
            // gbxUnavailable
            // 
            this.gbxUnavailable.Controls.Add(this.btnSettingRemove);
            this.gbxUnavailable.Controls.Add(this.btnSettingsAdd);
            this.gbxUnavailable.Controls.Add(this.dtePickerUnavailable);
            this.gbxUnavailable.Controls.Add(this.lstUnavailable);
            this.gbxUnavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUnavailable.Location = new System.Drawing.Point(12, 333);
            this.gbxUnavailable.Name = "gbxUnavailable";
            this.gbxUnavailable.Size = new System.Drawing.Size(451, 106);
            this.gbxUnavailable.TabIndex = 2;
            this.gbxUnavailable.TabStop = false;
            this.gbxUnavailable.Text = "Unavailable Dates";
            // 
            // btnSettingRemove
            // 
            this.btnSettingRemove.Location = new System.Drawing.Point(318, 49);
            this.btnSettingRemove.Name = "btnSettingRemove";
            this.btnSettingRemove.Size = new System.Drawing.Size(125, 42);
            this.btnSettingRemove.TabIndex = 3;
            this.btnSettingRemove.Text = "REMOVE";
            this.btnSettingRemove.UseVisualStyleBackColor = true;
            this.btnSettingRemove.Click += new System.EventHandler(this.btnSettingRemove_Click);
            // 
            // btnSettingsAdd
            // 
            this.btnSettingsAdd.Location = new System.Drawing.Point(176, 49);
            this.btnSettingsAdd.Name = "btnSettingsAdd";
            this.btnSettingsAdd.Size = new System.Drawing.Size(125, 42);
            this.btnSettingsAdd.TabIndex = 2;
            this.btnSettingsAdd.Text = "ADD";
            this.btnSettingsAdd.UseVisualStyleBackColor = true;
            this.btnSettingsAdd.Click += new System.EventHandler(this.btnSettingsAdd_Click);
            // 
            // dtePickerUnavailable
            // 
            this.dtePickerUnavailable.Location = new System.Drawing.Point(176, 21);
            this.dtePickerUnavailable.Name = "dtePickerUnavailable";
            this.dtePickerUnavailable.Size = new System.Drawing.Size(267, 22);
            this.dtePickerUnavailable.TabIndex = 1;
            // 
            // lstUnavailable
            // 
            this.lstUnavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUnavailable.FormattingEnabled = true;
            this.lstUnavailable.Location = new System.Drawing.Point(9, 21);
            this.lstUnavailable.Name = "lstUnavailable";
            this.lstUnavailable.Size = new System.Drawing.Size(155, 69);
            this.lstUnavailable.TabIndex = 0;
            // 
            // btnSettingBack
            // 
            this.btnSettingBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingBack.Location = new System.Drawing.Point(188, 449);
            this.btnSettingBack.Name = "btnSettingBack";
            this.btnSettingBack.Size = new System.Drawing.Size(90, 42);
            this.btnSettingBack.TabIndex = 3;
            this.btnSettingBack.Text = "BACK";
            this.btnSettingBack.UseVisualStyleBackColor = true;
            this.btnSettingBack.Click += new System.EventHandler(this.btnSettingBack_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 503);
            this.Controls.Add(this.btnSettingBack);
            this.Controls.Add(this.gbxUnavailable);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.gbxHoursAvailable);
            this.Name = "frmSettings";
            this.Text = "Form3";
            this.gbxHoursAvailable.ResumeLayout(false);
            this.gbxHoursAvailable.PerformLayout();
            this.gbxUnavailable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHoursAvailable;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.ComboBox dbxSaturday;
        private System.Windows.Forms.ComboBox dbxFriday;
        private System.Windows.Forms.ComboBox dbxThursday;
        private System.Windows.Forms.ComboBox dbxWednesday;
        private System.Windows.Forms.ComboBox dbxTuesday;
        private System.Windows.Forms.ComboBox dbxMonday;
        private System.Windows.Forms.ComboBox dbxSunday;
        private System.Windows.Forms.GroupBox gbxUnavailable;
        private System.Windows.Forms.Button btnSettingRemove;
        private System.Windows.Forms.Button btnSettingsAdd;
        private System.Windows.Forms.DateTimePicker dtePickerUnavailable;
        private System.Windows.Forms.ListBox lstUnavailable;
        private System.Windows.Forms.Button btnSettingBack;
    }
}