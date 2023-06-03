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
   
    public partial class Jiphyeon : Page
    {
        List<string> buildingClassrooms;
        public Jiphyeon(List<string> buildingClassrooms)
        {
            this.buildingClassrooms= buildingClassrooms;
            InitializeComponent();

            UpdateLabels(); // 초기 라벨 값 업데이트
        }
        private void UpdateLabels()
        {
            int countStartsWith1 = 0;
            int countStartsWith2 = 0;
            int countStartsWith3= 0;

            foreach (string classroom in buildingClassrooms)
            {
                if (classroom.StartsWith("3"))
                {
                    countStartsWith1++;
                }
                else if (classroom.StartsWith("4"))
                {
                    countStartsWith2++;
                }
                else if (classroom.StartsWith("5"))
                {
                    countStartsWith3++;
                }
            }

            // 강의실 번호로 시작하는 개수를 라벨에 할당하여 출력
            UsingCnt1.Content = $"{countStartsWith1}"; // 1로 시작하는 개수
            UsingCnt2.Content = $"{countStartsWith2}"; // 2로 시작하는 개수
            UsingCnt3.Content = $"{countStartsWith3}"; // 3로 시작하는 개수
        }

        private void JiphyeonButton1_Click(object sender, RoutedEventArgs e)
        {

            Jiphyeon3F Jiphyeon3F = new Jiphyeon3F(buildingClassrooms);
            NavigationService.Navigate(Jiphyeon3F);

           
        }

        private void JiphyeonButton2_Click(object sender, RoutedEventArgs e)
        {
            Jiphyeon4F Jiphyeon4F = new Jiphyeon4F(buildingClassrooms);
            NavigationService.Navigate(Jiphyeon4F);
        }

        private void JiphyeonButton3_Click(object sender, RoutedEventArgs e)
        {
            Jiphyeon5F Jiphyeon5F = new Jiphyeon5F(buildingClassrooms);
            NavigationService.Navigate(Jiphyeon5F);
        }
    }
}
