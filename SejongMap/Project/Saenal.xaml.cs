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
using Project;


namespace Project
{
    /// <summary>
    /// Newday.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Saenal : Page
    {
        private int usingCount = 10; // 사용 중인 개수 변수
        private int maxCount = 20; // 최대 개수 변수
        private List<string> buildingClassrooms;// 건물 강의실 리스트 변수
        public Saenal(List<string> buildingClassrooms)
        {
            InitializeComponent();
            this.buildingClassrooms = buildingClassrooms; // 건물 강의실 리스트 할당
            UpdateLabels(); // 초기 라벨 값 업데이트
        }
        private void UpdateLabels()
        {
            int num = buildingClassrooms.Count;
            // 라벨에 값을 할당하여 출력
            UsingCnt1.Content = $"{num}";
            //MaxCnt1.Content = maxCount.ToString();
        }
        private void SaenalButton1_Click(object sender, RoutedEventArgs e)
        {

            Saenal1F Saenal1F = new Saenal1F(buildingClassrooms);
            NavigationService.Navigate(Saenal1F);

        }
    }


}
