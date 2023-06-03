using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
//using System.Text.Encoding.CodePages;
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
        public static Encoding EUCKREncoding()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding euckr = Encoding.GetEncoding(949);
            return euckr;
        }

        public List<ScheduleItem> ReadCSV(string filePath)
        {
            List<ScheduleItem> scheduleItems = new List<ScheduleItem>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath, EUCKREncoding()))
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
                        Console.WriteLine(line);
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
