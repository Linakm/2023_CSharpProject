using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
//using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Leedang.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Leedang : Page
    {
        private List<string> buildingClassrooms;// 건물 강의실 리스트 변수
        public Leedang(List<string> buildingClassrooms)
        {
            InitializeComponent();
            this.buildingClassrooms = buildingClassrooms; // 건물 강의실 리스트 할당
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
                else if (classroom.StartsWith("2"))
                {
                    countStartsWith2++;
                }
            }

            // 강의실 번호로 시작하는 개수를 라벨에 할당하여 출력
            UsingCnt1.Content = $"{countStartsWith1}"; // 1로 시작하는 개수
            UsingCnt2.Content = $"{countStartsWith2}"; // 2로 시작하는 개수
        }

        private void LeedangButton1_Click(object sender, RoutedEventArgs e)
        {

            Leedang1F Leedang1F = new Leedang1F(buildingClassrooms);
            NavigationService.Navigate(Leedang1F);
           
        }

        private void LeedangButton2_Click(object sender, RoutedEventArgs e)
        {
            Leedang2 Leedang2 = new Leedang2(buildingClassrooms);
            NavigationService.Navigate(Leedang2);
        }
    }
}
