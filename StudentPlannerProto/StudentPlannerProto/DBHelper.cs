using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlannerProto
{

    class DBHelper
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public void InitialiseDBConnection()
        {
            if (!File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");

                string sql = @"CREATE TABLE Projects(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT ,
                               ProjectName         TEXT       NOT NULL,
                               StartDate           DATE       NOT NULL,
                               Deadline            DATE       NOT NULL,
                               Contingency         INT        NOT NULL,  
                               TimeAllocation      INT        NOT NULL,
                               ProjectComment             VARCHAR(100)     NULL
                            );";

                string sql2 = @"CREATE TABLE UnavailableDates(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT,
                               Date                DATE             NOT NULL
                            );";
                
                string sql3 = @"CREATE TABLE Settings(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT,
                               Sunday               INT          NOT NULL,
                               Monday               INT          NOT NULL,
                               Tuesday              INT          NOT NULL,
                               Wednesday            INT          NOT NULL,
                               Thursday             INT          NOT NULL,
                               Friday               INT          NOT NULL,
                               Saturday             INT          NOT NULL
                            );";

                string sql4 = @"CREATE TABLE projectTimeAllocated(
                               ProjectID INTEGER,
                               Date                 DATE            NOT NULL,
                               Hours                NUMERIC(2,1)    NOT NULL
                            );";


                con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd = new SQLiteCommand(sql2, con);
                cmd.ExecuteNonQuery();
                cmd = new SQLiteCommand(sql3, con);
                cmd.ExecuteNonQuery();
                cmd = new SQLiteCommand(sql4, con);
                cmd.ExecuteNonQuery();
                con.Close();

                // Add default values to new database
                AddSettings(7, 7, 7, 7, 7, 7, 7);

            }
            else
            {
                con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            }
        }

        //internal void AddProjectData(string projectname, DateTime startdate, DateTime deadline, int contingancy, int timeallocation, string projectcomment)
        //{
        //    throw new NotImplementedException();
        //}

        public void AddProjectData(string projectname, DateTime startdate, DateTime deadline, int contingency, int timeallocation, string projectcomment)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Projects(ProjectName,Startdate, Deadline, Contingency, TimeAllocation, ProjectComment) values ('" + projectname + "','" + startdate + "','" + deadline + "','" + contingency + "','" + timeallocation + "','" + projectcomment + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void AddSettings(int sunday,int monday, int tuesday, int wednesday, int thursday, int friday, int saturday)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Settings";
            cmd.ExecuteNonQuery();
            con.Close();

            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Settings(Sunday , Monday, Tuesday , Wednesday, Thursday, Friday, Saturday) values ('" + sunday + "','" + monday + "','" + tuesday + "','" + wednesday + "','" + thursday + "','" + friday + "','" + saturday + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<int> GetDaySettings()
        {
            List<int> settings = new List<int>();

            int counter = 0;
            cmd = new SQLiteCommand("Select * from Settings", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                settings.Add(Convert.ToInt32(dr[1]));
                settings.Add(Convert.ToInt32(dr[2])); 
                settings.Add(Convert.ToInt32(dr[3]));
                settings.Add(Convert.ToInt32(dr[4]));
                settings.Add(Convert.ToInt32(dr[5]));
                settings.Add(Convert.ToInt32(dr[6]));
                settings.Add(Convert.ToInt32(dr[7]));

            }
            con.Close();

            return settings;
        }


        public List<string> GetProjects()
        {
            List<string> projects = new List<string>();

            int counter = 0;
            cmd = new SQLiteCommand("Select * from Projects", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                counter++;
                projects.Add((string)dr[1]);

            }
            con.Close();

            return projects;
        }

        public List<DateTime> GetUnavailableDates()
        {
            List<DateTime> unavailDates = new List<DateTime>();

            cmd = new SQLiteCommand("Select * from UnavailableDates order by Date", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                unavailDates.Add(Convert.ToDateTime(dr[1]));

            }
            con.Close();

            return unavailDates;
        }

        public void AddUnavailableDate(DateTime dte)
        {
            RemoveUnavailableDate(dte);

            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into UnavailableDates(Date) values ('" + dte.ToString("yyyy-MM-dd") + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void RemoveUnavailableDate(DateTime dte)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from UnavailableDates where date = '" + dte.ToString("yyyy-MM-dd") + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public bool CheckProjectExists(string projectName)
        {
            bool exists = false;

            cmd = new SQLiteCommand("Select * from Projects where ProjectName='"+projectName+"'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                exists = true;
            }
            con.Close();
            return exists;
        }

        public int GetProjectID(string projectName)
        {
            int ProjectID = 0;

            cmd = new SQLiteCommand("Select ID from Projects where ProjectName='" + projectName + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ProjectID = Convert.ToInt32(dr[0]);
            }
            con.Close();
            return ProjectID;
        }


        public void ShowAvailabilitytData()
        {
            int counter = 0;
            cmd = new SQLiteCommand("Select * from Availability", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                counter++;
                Console.WriteLine(dr[0] + " : " + dr[1] + " " + dr[2]);

            }
            con.Close();
        }

        public void AddProjectHours(int projectID, Dictionary<DateTime, double> projectHours) 
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            foreach (var item in projectHours)
            {
                if (item.Value > 0)
                {
                    cmd.CommandText = "insert into projectTimeAllocated(ProjectID, Date, Hours) values ('" + projectID + "','" + item.Key.ToString("yyyy-MM-dd") + "','" + item.Value + "')";
                    cmd.ExecuteNonQuery();
                }
            }

            con.Close();
        }

        public Dictionary<DateTime, double> GetAllocatedProjectHours()
        {
            Dictionary<DateTime, double> projectTimeAllocated = new Dictionary<DateTime, double>();

            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select Date, SUM(Hours) from projectTimeAllocated Group by Date ";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                projectTimeAllocated.Add(Convert.ToDateTime(dr[0]), Convert.ToDouble(dr[1]));

            }
            con.Close();

            return projectTimeAllocated;
        }

        public Dictionary<string, double> GetProjectHoursByDate(DateTime selectedDate)
        {
            Dictionary<string, double> projectHours = new Dictionary<string, double>();

            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select ProjectName, Hours from projectTimeAllocated LEFT join Projects on projectTimeAllocated.ProjectID = Projects.ID where Date = '" + selectedDate.ToString("yyyy-MM-dd") + "'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                projectHours.Add(Convert.ToString(dr[0]), Convert.ToDouble(dr[1]));

            }
            con.Close();

            return projectHours;
        }

    }
}
