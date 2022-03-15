using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlannerProto
{
    class TimeHelper
    {

        public Dictionary<DateTime, double> CalculateProjectTime(DateTime startdate, DateTime deadline, double timeallocation, int contingency, List<int> DAvail, List<DateTime> unAvailible, Dictionary<DateTime, double> projectTimeAllocated)
        {
            Dictionary<DateTime, double> result = new Dictionary<DateTime, double>();

            //List<int> DAvail = new List<int> { 7, 3, 3, 7, 7, 7, 7 };

            //List<DateTime> unAvailible = new List<DateTime> { DateTime.Parse("2022-02-05"), DateTime.Parse("2022-03-01") };

            //List<DateTime> unAvailible = new List<DateTime>();

            //Dictionary<DateTime, double> projectTimeAllocated = new Dictionary<DateTime, double>();
            //projectTimeAllocated.Add(DateTime.Parse("2022-02-03"), 5);
            //projectTimeAllocated.Add(DateTime.Parse("2022-02-08"), 6);
            //projectTimeAllocated.Add(DateTime.Parse("2022-02-11"), 8);


            //DateTime startdate = DateTime.Parse("2022-02-01");
            //DateTime deadline = DateTime.Parse("2022-03-16");
            //double timeallocation = 100;
            //int contingency = 1;

            int TimePerWeek = 0;

            for (int i = 0; i < DAvail.Count; i++)
            {
                TimePerWeek = TimePerWeek + DAvail[i];
            }

            int DaysSD = (int)(deadline - startdate).TotalDays;
            int WeeksAvail = DaysSD / 7;
            int WeeksAvailC = WeeksAvail - contingency;
            int DaysC = WeeksAvailC * 7;
            double HoursAvail = TimePerWeek * WeeksAvailC;
            double HoursPercent = Math.Round((timeallocation / HoursAvail), 2);



            double runningTotal = 0;

            DateTime currentDay = startdate;

            while ((runningTotal != timeallocation) && (currentDay <= deadline))
            {
                int workHoursToday = DAvail[(int)currentDay.DayOfWeek];

                double projectedHours = (Math.Ceiling(workHoursToday * HoursPercent * 2) / 2);

                projectedHours = Math.Min(workHoursToday, projectedHours);

                double allocatedHoursToday = projectedHours;

                DateTime findDate = unAvailible.Find(x => x == currentDay);
                if (findDate == currentDay)
                {
                    allocatedHoursToday = 0;
                }
                else
                {
                    if (projectTimeAllocated.ContainsKey(currentDay))
                    {
                        double timeAlreadyAllocated = projectTimeAllocated[currentDay];
                        allocatedHoursToday = Math.Min(projectedHours, Math.Max(0, workHoursToday - timeAlreadyAllocated));
                    }

                }

                if (runningTotal + allocatedHoursToday > timeallocation)
                {
                    allocatedHoursToday = timeallocation - runningTotal;
                }


                runningTotal = runningTotal + allocatedHoursToday;
                Console.WriteLine("{0:ddd dd/MM/yyyy} - {1} - {2}", currentDay, allocatedHoursToday, runningTotal);
                result.Add(currentDay, allocatedHoursToday);

                currentDay = currentDay.AddDays(1);

            }

            if (runningTotal < timeallocation)
            {
                Console.WriteLine("Can't allocate not enough time");
                result.Clear();
            }



            Console.Write("\n\n\n\n");
            return result;
        }
    }
}
