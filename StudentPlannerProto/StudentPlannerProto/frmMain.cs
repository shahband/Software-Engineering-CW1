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
    public partial class frmMain : Form
    {
        DBHelper dB = new DBHelper();

        public frmMain()
        {
            InitializeComponent();
            dB.InitialiseDBConnection();
            ShowProjects();
            DisplayProjectHours();
        }


        private void ShowProjects()
        {
            List<string> projects = new List<string>();
            projects = dB.GetProjects();

            lstAvailableProject.Items.Clear();

            foreach (string project in projects)
            {
                lstAvailableProject.Items.Add(project);
            }

            DisplayProjectHours();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            frmAddProject frm = new frmAddProject();
            frm.ShowDialog();



            if (frm.WasCancelled != true)
            { 
                
                string projectname = frm.ProjectName;
                string projectcomment = frm.ProjectComment;
                int timeallocation = Convert.ToInt32(frm.TimeAllocation);
                DateTime deadline = Convert.ToDateTime(frm.Deadline);
                DateTime startdate = Convert.ToDateTime(frm.StartDate);
                int contingancy = Convert.ToInt32(frm.Contingancy);

                bool exists = dB.CheckProjectExists(projectname);

                if (exists == false)
                {
                    TimeHelper th = new TimeHelper();

                    List<int> settings = dB.GetDaySettings();
                    List<DateTime> unAvailable = dB.GetUnavailableDates();
                    Dictionary<DateTime, double> projectTimeAllocated = dB.GetAllocatedProjectHours();

                    Dictionary<DateTime, double> result = th.CalculateProjectTime(startdate, deadline, timeallocation, contingancy, settings, unAvailable, projectTimeAllocated);

                    var count = result.Count();
                    if (count == 0)
                    {
                        MessageBox.Show("Not enough hours to allocate time for this project");
                    }
                    else
                    {
                        dB.AddProjectData(projectname, startdate, deadline, contingancy, timeallocation, projectcomment);
                        int projectID = dB.GetProjectID(projectname);

                        dB.AddProjectHours(projectID, result);

                    }

                    
                }
                else
                {
                    MessageBox.Show("Project name already exists needs to be unique");
                }

                ShowProjects();
            }


        }


        private void btnSetting_Click(object sender, EventArgs e)
        {

            frmSettings frm = new frmSettings();
            frm.ShowDialog();

            if (frm.BackPressed != true) 
            { 
            int sunday = Convert.ToInt32(frm.Sunday);
            int monday = Convert.ToInt32(frm.Monday);
            int tuesday = Convert.ToInt32(frm.Tuesday);
            int wednesday = Convert.ToInt32(frm.Wednesday);
            int thursday = Convert.ToInt32(frm.Thursday);
            int friday = Convert.ToInt32(frm.Friday);
            int saturday = Convert.ToInt32(frm.Saturday);

            dB.AddSettings(sunday, monday, tuesday, wednesday, thursday, friday, saturday);

            //if (sunday =! )


            }

        }

        private void DisplayProjectHours()
        {
            DateTime dte = dtePickerCurrentDate.SelectionRange.Start;
            Dictionary<string, double> result = dB.GetProjectHoursByDate(dte);

            lstCurrentProjects.Clear();
            foreach (var item in result)
            {
                lstCurrentProjects.Items.Add(item.Key + "   (" + item.Value + " Hours)");
            }

        }

        private void dtePickerCurrentDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            DisplayProjectHours();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
