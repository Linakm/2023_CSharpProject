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
    /// Gwanggaeto4F.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Gwanggaeto4F : Page
    {
        private List<string> buildingClassrooms;
        public Gwanggaeto4F(  List<string> buildingClassrooms)
        {
            this.buildingClassrooms= buildingClassrooms;
            InitializeComponent();
            UpdateButtonColors();
        }

        private void UpdateButtonColors()
        {
            if (buildingClassrooms.Contains("428"))
                room1.Background = Brushes.Transparent;
            else
                room1.Background = Brushes.Red;




        }
    }
}
