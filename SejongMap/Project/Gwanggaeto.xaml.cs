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
using System.Windows. Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;


namespace Project
{
    
    public partial class Gwanggaeto : Window
    {
        List<string> buildingClassrooms;
        public Gwanggaeto(List<string> buildingClassrooms)
        {
            this.buildingClassrooms = buildingClassrooms;
            InitializeComponent();
        }

        private void GwanggaetoButton1_Click(object sender, RoutedEventArgs e)
        {

            Gwanggaeto1F Gwanggaeto1F = new Gwanggaeto1F(buildingClassrooms);
           // NavigationService.Navigate(Gwanggaeto1F);

           
        }

        private void GwanggaetoButton2_Click(object sender, RoutedEventArgs e)
        {

            Gwanggaeto2F Gwanggaeto2F = new Gwanggaeto2F(buildingClassrooms);
           // NavigationService.Navigate(Gwanggaeto2F);

           
        }

        private void GwanggaetoButton3_Click(object sender, RoutedEventArgs e)
        {


            Gwanggaeto4F Gwanggaeto4F = new Gwanggaeto4F(buildingClassrooms);
           // NavigationService.Navigate(Gwanggaeto4F);
           
        }

        private void GwanggaetoButton4_Click(object sender, RoutedEventArgs e)
        {

            Gwanggaeto6F Gwanggaeto6F = new Gwanggaeto6F(buildingClassrooms);
           // NavigationService.Navigate(Gwanggaeto6F);
        }

        private void GwanggaetoButton5_Click(object sender, RoutedEventArgs e)
        {
            Gwanggaeto7F Gwanggaeto7F = new Gwanggaeto7F(buildingClassrooms);
           // NavigationService.Navigate(Gwanggaeto7F);

        }

        private void GwanggaetoButton6_Click(object sender, RoutedEventArgs e)
        {

            Gwanggaeto8F Gwanggaeto8F = new Gwanggaeto8F(buildingClassrooms);
           // NavigationService.Navigate(Gwanggaeto8F);
         
        }
    }
}
