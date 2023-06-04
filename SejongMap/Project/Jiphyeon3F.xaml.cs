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
    /// Jiphyeon3F.xaml에 대한 상호 작용 논리
    /// </saummary>
    public partial class Jiphyeon3F : Page
    {
        private List<string> buildingClassrooms;
        public Jiphyeon3F( List<string> buildingClassrooms)
        {
            this.buildingClassrooms= buildingClassrooms;
        InitializeComponent();
            UpdateButtonColors();
        }

        private void UpdateButtonColors()
        {
            if (buildingClassrooms.Contains(room1.Content.ToString()))
                room1.Background = Brushes.LightGreen;
            else
                room1.Background = Brushes.Transparent;

            if (buildingClassrooms.Contains(room2.Content.ToString()))
                room2.Background = Brushes.LightGreen;
            else
                room2.Background = Brushes.Transparent;

            if (buildingClassrooms.Contains(room3.Content.ToString()))
                room3.Background = Brushes.LightGreen;
            else
                room3.Background = Brushes.Transparent;

            if (buildingClassrooms.Contains(room4.Content.ToString()))
                room4.Background = Brushes.LightGreen;
            else
                room4.Background = Brushes.Transparent;
        }
    }
}
