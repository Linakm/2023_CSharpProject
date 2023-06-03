using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AICenter : Page
    {

        List<string> buildingClassrooms;
        public AICenter(List<string> buildingClassrooms)
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
                if (classroom.StartsWith("B1"))
                {
                    countStartsWith1++;
                }
                else if (classroom.StartsWith("B2"))
                {
                    countStartsWith2++;
                }
            }

            // 강의실 번호로 시작하는 개수를 라벨에 할당하여 출력
            UsingCnt1.Content = $"{countStartsWith1}"; // 1로 시작하는 개수
            UsingCnt2.Content = $"{countStartsWith2}"; // 2로 시작하는 개수
        }

        private void AIButton1_Click(object sender, RoutedEventArgs e)
        {
            AICenterB1F AICenterB1F = new AICenterB1F(buildingClassrooms);
            NavigationService.Navigate(AICenterB1F);


        }

        private void AIButton2_Click(object sender, RoutedEventArgs e)
        {
            AICenterB2F AICenterB2F = new AICenterB2F(buildingClassrooms);
            NavigationService.Navigate(AICenterB2F);

           
        }
    }
}
