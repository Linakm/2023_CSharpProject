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
    /// Newday.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Saenal : Page
    {
        public Saenal()
        {
            InitializeComponent();
        }

        private void SaenalButton1_Click(object sender, RoutedEventArgs e)
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

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '새날관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '1%';";

            MyConnection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, MyConnection);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                UsingCnt1.Content = result;
            }

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Saenal1F.xaml", UriKind.RelativeOrAbsolute));
        }
    }


}
