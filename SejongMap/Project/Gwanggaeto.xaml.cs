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
using System.Windows. Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;




namespace Project
{
    
    public partial class Gwanggaeto : Page
    {
        List<string> buildingClassrooms;
        public Gwanggaeto(List<string> buildingClassrooms)
        {
            this.buildingClassrooms = buildingClassrooms;
            InitializeComponent();
            UpdateLabels(); // 초기 라벨 값 업데이트
        }
        private void UpdateLabels()
        {
            int countStartsWith1 = 0;
            int countStartsWith2 = 0;

            int countStartsWith3 = 0;
            int countStartsWith4 = 0;

            int countStartsWith5 = 0;
            int countStartsWith6 = 0;

            foreach (string classroom in buildingClassrooms)
            {
                if (classroom.StartsWith("1"))
                {
                    countStartsWith1++;
                }
                else if (classroom.StartsWith("2"))
                {
                    countStartsWith2++;
                }
                else if (classroom.StartsWith("4"))
                {
                    countStartsWith3++;
                }
                else if (classroom.StartsWith("6"))
                {
                    countStartsWith4++;
                }
                else if (classroom.StartsWith("7")) { 
               
                    countStartsWith5++;
                }
                else if (classroom.StartsWith("8"))
                 {
                countStartsWith6++;
                   }
                 }

            // 강의실 번호로 시작하는 개수를 라벨에 할당하여 출력
            G_UsingCnt1.Content = $"{countStartsWith1}"; // 1로 시작하는 개수
            G_UsingCnt2.Content = $"{countStartsWith2}"; // 2로 시작하는 개수
            G_UsingCnt3.Content = $"{countStartsWith3}"; // 4로 시작하는 개수
            G_UsingCnt4.Content = $"{countStartsWith4}"; // 6로 시작하는 개수
            G_UsingCnt5.Content = $"{countStartsWith5}"; // 7로 시작하는 개수
            G_UsingCnt6.Content = $"{countStartsWith6}"; // 8로 시작하는 개수
        }

        private void GwanggaetoButton1_Click(object sender, RoutedEventArgs e)
        {

            Gwanggaeto1F Gwanggaeto1F = new Gwanggaeto1F(buildingClassrooms);
            NavigationService.Navigate(Gwanggaeto1F);

           
        }

        private void GwanggaetoButton2_Click(object sender, RoutedEventArgs e)
        {

            Gwanggaeto2F Gwanggaeto2F = new Gwanggaeto2F(buildingClassrooms);
            NavigationService.Navigate(Gwanggaeto2F);

           
        }

        private void GwanggaetoButton3_Click(object sender, RoutedEventArgs e)
        {


            Gwanggaeto4F Gwanggaeto4F = new Gwanggaeto4F(buildingClassrooms);
           NavigationService.Navigate(Gwanggaeto4F);
           
        }

        private void GwanggaetoButton4_Click(object sender, RoutedEventArgs e)
        {

            Gwanggaeto6F Gwanggaeto6F = new Gwanggaeto6F(buildingClassrooms);
           NavigationService.Navigate(Gwanggaeto6F);
        }

        private void GwanggaetoButton5_Click(object sender, RoutedEventArgs e)
        {
            Gwanggaeto7F Gwanggaeto7F = new Gwanggaeto7F(buildingClassrooms);
            NavigationService.Navigate(Gwanggaeto7F);

        }

        private void GwanggaetoButton6_Click(object sender, RoutedEventArgs e)
        {

            Gwanggaeto8F Gwanggaeto8F = new Gwanggaeto8F(buildingClassrooms);
           NavigationService.Navigate(Gwanggaeto8F);
         
        }
    }
}
