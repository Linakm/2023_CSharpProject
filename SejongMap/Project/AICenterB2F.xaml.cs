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
    /// AICenterB2F.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AICenterB2F : Page
    {
        private List<string> buildingClassrooms;
        public AICenterB2F(  List<string> buildingClassrooms)
        {
             this.buildingClassrooms=  buildingClassrooms;
        InitializeComponent();
            UpdateButtonColors();
        }

        private void UpdateButtonColors()
        {
            if (buildingClassrooms.Contains("B205"))
                room1.Background = Brushes.Transparent;
            else
                room1.Background = Brushes.Red;

            if (buildingClassrooms.Contains("B209"))
                room2.Background = Brushes.Transparent;
            else
                room2.Background = Brushes.Red;

         
        }
    }
}
