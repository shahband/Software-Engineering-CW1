using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPlannerProto
{
    public partial class frmAddProject : Form
    {
        public bool WasCancelled = false;

        public string ProjectName = "";
        public string ProjectComment = "";
        public string TimeAllocation = "";
        public string Deadline = "";
        public string StartDate = "";
        public string Contingancy = "";

        public frmAddProject()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProjectName = txtProjectName.Text;
            ProjectComment = txtComment.Text;
            TimeAllocation = txtAllocationTime.Text;
            Deadline = dtePickerDeadline.Text;
            StartDate = dtePickerStartDate.Text;
            Contingancy = dbxContingency.Text;


            WasCancelled = false;
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            WasCancelled = true;
            this.Hide();
        }
    }
}
