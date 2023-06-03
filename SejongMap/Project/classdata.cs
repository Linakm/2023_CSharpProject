using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    public class ScheduleItem
    {
        public int ID { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string BuildingName { get; set; }
        public string RoomNumber { get; set; }
        public string DayOfWeek { get; set; }
    }

    public class CSVReader
    {
        public List<ScheduleItem> ReadCSV(string filePath)
        {
            List<ScheduleItem> scheduleItems = new List<ScheduleItem>();
// 다시 생각을 해보자입니다. 그럼 이만...입니다. 생각을 더 잘 해보자.  // 진짜변수때문이었네
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] rowData = line.Split(',');

                        ScheduleItem scheduleItem = new ScheduleItem
                        {
                            ID = int.Parse(rowData[0]),
                            StartTime = TimeSpan.Parse(rowData[1]),
                            EndTime = TimeSpan.Parse(rowData[2]),
                            BuildingName = rowData[3],
                            RoomNumber = rowData[4],
                            DayOfWeek = rowData[5]
                        };

                        scheduleItems.Add(scheduleItem);
                       
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the CSV file: " + ex.Message);
            }

            return scheduleItems;
        }




    }
}
