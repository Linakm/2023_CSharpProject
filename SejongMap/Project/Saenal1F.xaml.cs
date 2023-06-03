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
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Saenal1F.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Saenal1F : Page
    {
       
        private List<string> buildingClassrooms; // 건물 강의실 리스트 변수
        
        public Saenal1F(List<string> buildingClassrooms)
        {
            InitializeComponent();
            this.buildingClassrooms = buildingClassrooms; // 건물 강의실 리스트 할당
            ShowClassroomNumbers(); // 강의실 번호 표시
        }

        private void ShowClassroomNumbers()
        {
            for (int i = 0; i < buildingClassrooms.Count; i++)
            {
               
            }
        }
    }
}
