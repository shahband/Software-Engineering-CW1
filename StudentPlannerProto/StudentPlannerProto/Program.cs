using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPlannerProto
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        
        
        
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}



//namespace ConsoleApp1
//{
//    internal class Program
//    {

//        static void Main(string[] args)
//        {
//            DBHelper db = new DBHelper();
//            db.InitialiseDBConnection();

//            ////---------------------------------------------------------------------------PROJECT DATA INPUT

//            //Console.Write("Add Project Name      :");
//            //string projectname = Console.ReadLine();

//            //Console.Write("Add Startdate   :");
//            //string startdate = Console.ReadLine();

//            //Console.Write("Add Deadline   :");
//            //string deadline = Console.ReadLine();

//            //Console.Write("Add Time Allocation (Hrs)   :");
//            //int timeallocation = Int32.Parse(Console.ReadLine());

//            //Console.Write("Add Contingency Time (Weeks)   :");
//            //int contingency = Int32.Parse(Console.ReadLine());

//            ////---------------------------------------------------------------------------AVAILIBILITY INPUT

//            //Console.Write("Do You Wish To Enter / Change Day Availiblity (Y/N)    :");
//            //string input = Console.ReadLine();

//            //if (input == "Y")
//            //{

//            //}


//            string projectname = "Test";
//            DateTime startdate = DateTime.Parse("2022-02-01");
//            DateTime deadline = DateTime.Parse("2022-03-16");
//            int timeallocation = 100;
//            int contingency = 2;





//            ////---------------------------------------------------------------------------ADD DATA           

//            //db.AddData(projectname, startdate, deadline, timeallocation, contingency);

//            //Console.WriteLine("*************************");
//            //db.ShowStudentData();
//            //db.ShowAvailabilitytData();

//            TimeHelper timehelper = new TimeHelper();
//            List<DateTime> unavailableDates = new List<DateTime>();
//            unavailableDates.Add(DateTime.Parse("2022-02-14"));

//            List<Tuple<DateTime, double>> calculatedDates = timehelper.CalculateHoursPerDay(startdate, deadline, timeallocation, contingency, unavailableDates);

//            Console.ReadLine();
//        }
//    }
//}
