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
    /// Jiphyeon4F.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Jiphyeon4F : Page
    {
        private List<string> buildingClassrooms;
        public Jiphyeon4F(List<string> buildingClassrooms)
        {
            InitializeComponent();
            this.buildingClassrooms = buildingClassrooms;
            UpdateButtonColors();
        }

        private void UpdateButtonColors()
        {
            if (buildingClassrooms.Contains(room1.Content.ToString()))
                room1.Background = Brushes.Transparent;
            else
                room1.Background = Brushes.Red;

            if (buildingClassrooms.Contains(room2.Content.ToString()))
                room2.Background = Brushes.Transparent;
            else
                room2.Background = Brushes.Red;

        }
    }
}
