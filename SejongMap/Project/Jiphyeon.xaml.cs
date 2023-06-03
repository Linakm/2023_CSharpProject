using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
namespace Project
{
    /// <summary>
    /// Jiphyeon.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Jiphyeon : Page
    {
        public Jiphyeon()
        {
            InitializeComponent();
        }

        private void JiphyeonButton1_Click(object sender, RoutedEventArgs e)
        {
            /*
            int usingCnt = 10;
            int maxCnt = 20;

            UsingCnt1.Content = usingCnt + " / ";
            MaxCnt1.Content = maxCnt;

            if (usingCnt >= maxCnt)
                UsingCnt1.Foreground = new SolidColorBrush(Colors.Red);
            else
                UsingCnt1.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
            MySqlConnection MyConnection = new MySqlConnection("Server = localhost; Port = 3307; Database = sejongmap; " +
                                                                "Uid = root; Pwd = vangogh1!");

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '집현관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '3%';";

            MyConnection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, MyConnection);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                UsingCnt1.Content = result;
            }

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Jiphyeon3F.xaml", UriKind.RelativeOrAbsolute));
        }

        private void JiphyeonButton2_Click(object sender, RoutedEventArgs e)
        {
            /*int usingCnt = 20;
            int maxCnt = 20;

            UsingCnt2.Content = usingCnt + " / ";
            MaxCnt2.Content = maxCnt;

            if (usingCnt >= maxCnt)
                UsingCnt2.Foreground = new SolidColorBrush(Colors.Red);
            else
                UsingCnt2.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
            MySqlConnection MyConnection = new MySqlConnection("Server = localhost; Port = 3307; Database = sejongmap; " +
                                                                "Uid = root; Pwd = vangogh1!");

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '집현관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '4%';";

            MyConnection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, MyConnection);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                UsingCnt2.Content = result;
            }

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Jiphyeon4F.xaml", UriKind.RelativeOrAbsolute));
        }

        private void JiphyeonButton3_Click(object sender, RoutedEventArgs e)
        {
            /*int usingCnt = 20;
            int maxCnt = 20;

            UsingCnt3.Content = usingCnt + " / ";
            MaxCnt3.Content = maxCnt;

            if (usingCnt >= maxCnt)
                UsingCnt3.Foreground = new SolidColorBrush(Colors.Red);
            else
                UsingCnt3.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
            MySqlConnection MyConnection = new MySqlConnection("Server = localhost; Port = 3307; Database = sejongmap; " +
                                                                "Uid = root; Pwd = vangogh1!");

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '집현관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '5%';";

            MyConnection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, MyConnection);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                UsingCnt3.Content = result;
            }

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Jiphyeon5F.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
