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
    /// Goonja.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Goonja : Page
    {
        List<string> buildingClassrooms;
        public Goonja(List<string> buildingClassrooms)
        {
            this.buildingClassrooms = buildingClassrooms;
            InitializeComponent();
            UpdateLabels(); // 초기 라벨 값 업데이트
        }
        private void UpdateLabels()
        {
            int countStartsWith1 = 0;
            int countStartsWith2 = 0;

            foreach (string classroom in buildingClassrooms)
            {
                if (classroom.StartsWith("1"))
                {
                    countStartsWith1++;
                }
                else if (classroom.StartsWith("3"))
                {
                    countStartsWith2++;
                }
            }

            // 강의실 번호로 시작하는 개수를 라벨에 할당하여 출력
            UsingCnt1.Content = $"{countStartsWith1}"; // 1로 시작하는 개수
            UsingCnt2.Content = $"{countStartsWith2}"; // 2로 시작하는 개수
        }
        private void GoonjaButton1_Click(object sender, RoutedEventArgs e)
        {

            Goonja1F Goonja1F = new Goonja1F(buildingClassrooms);
            NavigationService.Navigate(Goonja1F);

           
        }

        private void GoonjaButton2_Click(object sender, RoutedEventArgs e)
        {

            Goonja3F Goonja3F = new Goonja3F(buildingClassrooms);
            NavigationService.Navigate(Goonja3F);

        }
    }
}
