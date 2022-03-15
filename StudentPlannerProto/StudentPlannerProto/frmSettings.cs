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
    public partial class frmSettings : Form
    {
        public bool BackPressed = false;

        DBHelper dB = new DBHelper();

        public string Sunday = "";
        public string Monday = "";
        public string Tuesday = "";
        public string Wednesday = "";
        public string Thursday = "";
        public string Friday = "";
        public string Saturday = "";

        public List<DateTime> UnavailableDates = new List<DateTime>();

        public frmSettings()
        {
            InitializeComponent();
            dB.InitialiseDBConnection();
            UpdateDisplay();

        }

        public void UpdateDisplay()
        {
            List<int> settings = dB.GetDaySettings();
            List<DateTime> unavailDates = dB.GetUnavailableDates();

            Sunday = settings[0].ToString();
            Monday = settings[1].ToString();
            Tuesday = settings[2].ToString();
            Wednesday = settings[3].ToString();
            Thursday = settings[4].ToString();
            Friday = settings[5].ToString();
            Saturday = settings[6].ToString();

            dbxSunday.Text = Sunday;
            dbxMonday.Text = Monday;
            dbxTuesday.Text = Tuesday;
            dbxWednesday.Text = Wednesday;
            dbxThursday.Text = Thursday;
            dbxFriday.Text = Friday;
            dbxSaturday.Text = Saturday;

            lstUnavailable.Items.Clear();
            foreach (var item in unavailDates)
            {
                lstUnavailable.Items.Add(item.ToString("yyyy-MM-dd"));
            }

        }


        public void frmSaveAvailableHours() 
        {
            
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Sunday = dbxSaturday.Text;
            Monday = dbxMonday.Text;
            Tuesday = dbxTuesday.Text;
            Wednesday = dbxWednesday.Text;
            Thursday = dbxThursday.Text;
            Friday = dbxFriday.Text;
            Saturday = dbxSaturday.Text;

            dB.AddSettings(Convert.ToInt32(Sunday), Convert.ToInt32(Monday), Convert.ToInt32(Tuesday), Convert.ToInt32(Wednesday), Convert.ToInt32(Thursday), Convert.ToInt32(Friday), Convert.ToInt32(Saturday));
            UpdateDisplay();
        }

        private void btnSettingBack_Click(object sender, EventArgs e)
        {
            BackPressed = true;
            this.Hide();
        }

        public void frmUnavailableDate() 
        {
            
        }

        private void btnSettingsAdd_Click(object sender, EventArgs e)
        {
            DateTime dte = dtePickerUnavailable.Value;
            dB.AddUnavailableDate(dte);
            UpdateDisplay();
        }

        private void btnSettingRemove_Click(object sender, EventArgs e)
        {
            DateTime dte = Convert.ToDateTime(lstUnavailable.SelectedItem);
            dB.RemoveUnavailableDate(dte);
            UpdateDisplay();
        }
    }
}
