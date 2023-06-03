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
namespace Project
{
   
    public partial class Jiphyeon : Page
    {
        List<string> buildingClassrooms;
        public Jiphyeon(List<string> buildingClassrooms)
        {
            this.buildingClassrooms= buildingClassrooms;
            InitializeComponent();
        }

        private void JiphyeonButton1_Click(object sender, RoutedEventArgs e)
        {

            Jiphyeon3F Jiphyeon3F = new Jiphyeon3F(buildingClassrooms);
            NavigationService.Navigate(Jiphyeon3F);

           
        }

        private void JiphyeonButton2_Click(object sender, RoutedEventArgs e)
        {
            Jiphyeon4F Jiphyeon4F = new Jiphyeon4F(buildingClassrooms);
            NavigationService.Navigate(Jiphyeon4F);
        }

        private void JiphyeonButton3_Click(object sender, RoutedEventArgs e)
        {
            Jiphyeon5F Jiphyeon5F = new Jiphyeon5F(buildingClassrooms);
            NavigationService.Navigate(Jiphyeon5F);
        }
    }
}
