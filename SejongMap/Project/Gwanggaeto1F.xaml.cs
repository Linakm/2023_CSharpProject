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
    /// Gwanggaeto1F.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Gwanggaeto1F : Page
    {
        private List<string> buildingClassrooms;
        public Gwanggaeto1F(  List<string> buildingClassrooms)
        {this.buildingClassrooms = buildingClassrooms;
            InitializeComponent();
            UpdateButtonColors();
        }

        private void UpdateButtonColors()
        {
            if (buildingClassrooms.Contains("102"))
                room1.Background = Brushes.LightGreen;
            else
                room1.Background = Brushes.Transparent;
            if (buildingClassrooms.Contains("106"))
                room2.Background = Brushes.LightGreen;
            else
                room2.Background = Brushes.Transparent;
            if (buildingClassrooms.Contains("110"))
                room3.Background = Brushes.LightGreen;
            else
                room3.Background = Brushes.Transparent;
            if (buildingClassrooms.Contains("1120B"))
                room4.Background = Brushes.LightGreen;
            else
                room4.Background = Brushes.Transparent;




        }
    }
}
