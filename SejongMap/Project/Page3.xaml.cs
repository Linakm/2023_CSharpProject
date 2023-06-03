
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO; // File 클래스를 사용하기 위해 추가
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Project;
namespace Project
{

    // 지도창서만 사이즈  바꾸는 것 어떨까요?
    public partial class Page3 : Page
    {
        private TimeSpan StartTime;
        private TimeSpan UsageTime; // 사용시간이 아니라 끝나는 시간인데 변수 이름을 안바꿨습니다. 
        private string DayOfWeek;
        private const string csvFilePath = "classdata.csv";
        List<ScheduleItem> scheduleItems;
        public Page3(TimeSpan startTime, TimeSpan usageTime, string dayOfWeek)
        {
            InitializeComponent();

            // startTime과 usageTime 값을 멤버 변수에 저장
            this.StartTime = startTime;
            this.UsageTime = usageTime;
            this.DayOfWeek = dayOfWeek;
            CSVReader csvReader = new CSVReader();
            scheduleItems = csvReader.ReadCSV(csvFilePath);
            DisplayAvailableRoomCounts();
        }
       

        private void SaenalClick(object sender, RoutedEventArgs e)
        {
            NavigateToRoomPage("Saenal");
        }

        private void JiphyeonClick(object sender, RoutedEventArgs e)
        {
            NavigateToRoomPage("Jiphyeon");
        }

        private void GoonjaClick(object sender, RoutedEventArgs e)
        {
            NavigateToRoomPage("Goonja");
        }

        private void GwanggaetoClick(object sender, RoutedEventArgs e)
        {
            NavigateToRoomPage("Gwanggaeto");
        }

        private void LeedangClick(object sender, RoutedEventArgs e)
        {
            NavigateToRoomPage("Leedang");
        }

        private void AicenterClick(object sender, RoutedEventArgs e)
        {
            NavigateToRoomPage("AIcenter");
        }

        private void NavigateToRoomPage(string roomName)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri($"/{roomName}.xaml", UriKind.RelativeOrAbsolute));
        }
      


        private void DisplayAvailableRoomCounts()
        {

            List<string>[] buildingClassrooms = new List<string>[6];

            // 건물별 사용 가능한 강의실 추가
            buildingClassrooms[0] = new List<string>(); // 새날관
            buildingClassrooms[1] = new List<string>(); // 집현관
            buildingClassrooms[2] = new List<string>(); // 군자관
            buildingClassrooms[3] = new List<string>(); // 광개토관
            buildingClassrooms[4] = new List<string>(); // 이당관
            buildingClassrooms[5] = new List<string>(); // 대양AI센터

            // 강의실 번호 추가
           


            string[] strings = new string[6] { "새날관", "집현관", "군자관", "광개토관", "이당관", "대양AI센터" };
            int[] classroomCounts = new int[6];
            string dayOfWeek = DayOfWeek;
             TimeSpan startTime = this.StartTime;
             TimeSpan endTime = this.UsageTime;


            TimeSpan timeDifference = endTime - startTime;
            int num = (int)(timeDifference.TotalMinutes / 30);// 30분이 몇번 있는지이다. 
            
            for (int j = 0; j < 6; j++)
            {
                
                for (int i = 0; i < 2811; i++) //2811개이다. 
                {
                    if (i + num - 1 >= 2811) break;
                    var currentItem = scheduleItems[i];
                    string buildingName = currentItem.BuildingName;

                    if (currentItem.DayOfWeek == dayOfWeek && currentItem.StartTime == startTime && buildingName==strings[j])
                    {
                        if (scheduleItems[i + num - 1].EndTime == endTime)// 
                        {

                            buildingClassrooms[j].Add(scheduleItems[i].RoomNumber); // j는 건물에 해당하는 인덱스
                            i += num-1; // 뒤에서 하나더 추가를 하기 때문에
                        }
                        
                      
                    }
                   
                }
                classroomCounts[j] = buildingClassrooms[j].Count;
            }
        


        // UI 요소에 개수와 강의실 목록을 표시
        SaenalCountLabel.Content = buildingClassrooms[0].Count;


        JiphyeonCountLabel.Content = buildingClassrooms[1].Count;
           

           GoonjaCountLabel.Content = buildingClassrooms[2].Count;
          

           GwanggaetoCountLabel.Content = buildingClassrooms[3].Count;
           

            LeedangCountLabel.Content = buildingClassrooms[4].Count;
         

            AIcenterCountLabel.Content = buildingClassrooms[5].Count;
           



        }
            private void DisplayRoomCount(string building, int count)
        {
            // 건물별로 예약 가능한 강의실 개수를 표시
            switch (building)
            {
                case "Saenal":
                    SaenalCountLabel.Content = count;
                    break;
                case "Jiphyeon":
                    JiphyeonCountLabel.Content = count;
                    break;
                case "Goonja":
                    GoonjaCountLabel.Content = count;
                    break;
                case "Gwanggaeto":
                    GwanggaetoCountLabel.Content = count;
                    break;
                case "Leedang":
                    LeedangCountLabel.Content = count;
                    break;
                case "AIcenter":
                    AIcenterCountLabel.Content = count;
                    break;
                default:
                    break;
            }
        }

    
    }
}
