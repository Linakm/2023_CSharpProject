
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
   
         
    public partial class Page3 : Page
    {
        private TimeSpan StartTime;
        private TimeSpan UsageTime; // 사용시간이 아니라 끝나는 시간인데 변수 이름을 안바꿨습니다. 
        
        private const string csvFilePath = "classdata.csv";
        List<ScheduleItem> scheduleItems;
        public Page3(TimeSpan startTime, TimeSpan usageTime)
        {
            InitializeComponent();

            // startTime과 usageTime 값을 멤버 변수에 저장
            this.StartTime = startTime;
            this.UsageTime = usageTime;
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
            // string dayOfWeek = DateTime.Now.DayOfWeek.ToString();


            Dictionary<string, int> roomCounts = new Dictionary<string, int>
    {
        { "새날관", 0 },
        { "집현관", 0 },
        { "군자관", 0 },
        { "광개토관", 0 },
        { "이당관", 0 },
        { "대양AI센터", 0 }
    };
            Dictionary<string, int> roomCounttmps = new Dictionary<string, int>
    {
        { "새날관", 0 },
        { "집현관", 0 },
        { "군자관", 0 },
        { "광개토관", 0 },
        { "이당관", 0 },
        { "대양AI센터", 0 }
    };

            CultureInfo culture = new CultureInfo("ko-KR");
            string dayOfWeek = DateTime.Now.ToString("dddd", culture);
            TimeSpan startTime = this.StartTime;
            TimeSpan endTime = this.UsageTime;

            // 여기 코드 다시 짤 예정입니다. roomcount부분이요!
            foreach (var roomCount in roomCounts)
            {
                string buildingName = roomCount.Key;
                int count = 0;
                List<string> roomNumbers = new List<string>();

                DateTime currentTime = DateTime.Today.Add(startTime); // 현재 날짜 시간
                int numIntervals = (int)Math.Ceiling((endTime - startTime).TotalMinutes / 30);

                while (startTime <= endTime)
                {
                    bool isRoomAvailable = scheduleItems.Any(item => item.BuildingName == buildingName &&
                                                                    item.StartTime <= startTime &&
                                                                    item.EndTime >= startTime.Add(new TimeSpan(0, 30, 0)) &&
                                                                    item.DayOfWeek == currentTime.DayOfWeek.ToString());

                    if (isRoomAvailable)
                    {
                        // 이미 카운트된 강의실인지 확인
                        string roomNumber = scheduleItems.First(item => item.BuildingName == buildingName &&
                                                                       item.StartTime <= startTime &&
                                                                       item.EndTime >= startTime.Add(new TimeSpan(0, 30, 0)) &&
                                                                       item.DayOfWeek == currentTime.DayOfWeek.ToString()).RoomNumber;
                        if (!roomNumbers.Contains(roomNumber))
                        {
                            roomNumbers.Add(roomNumber);
                            count++;
                        }
                    }

                    startTime = startTime.Add(new TimeSpan(0, 30, 0));
                }

                if (numIntervals == count)
                {
                    roomCounttmps[buildingName] = count;
                }
            }


            // UI 요소에 개수를 표시
            SaenalCountLabel.Content = roomCounttmps["새날관"];
            JiphyeonCountLabel.Content = roomCounttmps["집현관"];
            GoonjaCountLabel.Content = roomCounttmps["군자관"];
            GwanggaetoCountLabel.Content = roomCounttmps["광개토관"];
            LeedangCountLabel.Content = roomCounttmps["이당관"];
            AIcenterCountLabel.Content = roomCounttmps["대양AI센터"];



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
