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
    /// Gwanggaeto2F.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Gwanggaeto2F : Page
    {
        private List<string> buildingClassrooms;
        public Gwanggaeto2F(  List<string> buildingClassrooms)
        {
            this.buildingClassrooms= buildingClassrooms;
            InitializeComponent();
            UpdateButtonColors();
        }

        private void UpdateButtonColors()
        {
            if (buildingClassrooms.Contains("201"))
                room1.Background = Brushes.Transparent;
            else
                room1.Background = Brushes.Red;
            if (buildingClassrooms.Contains("202"))
                room2.Background = Brushes.Transparent;
            else
                room2.Background = Brushes.Red;
            if (buildingClassrooms.Contains("203"))
                room3.Background = Brushes.Transparent;
            else
                room3.Background = Brushes.Red;
            if (buildingClassrooms.Contains("204"))
                room4.Background = Brushes.Transparent;
            else
                room4.Background = Brushes.Red;
            if (buildingClassrooms.Contains("205"))
                room5.Background = Brushes.Transparent;
            else
                room5.Background = Brushes.Red;
            if (buildingClassrooms.Contains("206"))
                room6.Background = Brushes.Transparent;
            else
                room6.Background = Brushes.Red;
            if (buildingClassrooms.Contains("207"))
                room7.Background = Brushes.Transparent;
            else
                room7.Background = Brushes.Red;
            if (buildingClassrooms.Contains("208"))
                room8.Background = Brushes.Transparent;
            else
                room8.Background = Brushes.Red;
            if (buildingClassrooms.Contains("209"))
                room9.Background = Brushes.Transparent;
            else
                room9.Background = Brushes.Red;
            if (buildingClassrooms.Contains("211"))
                room10.Background = Brushes.Transparent;
            else
                room10.Background = Brushes.Red;



        }
    }
}
