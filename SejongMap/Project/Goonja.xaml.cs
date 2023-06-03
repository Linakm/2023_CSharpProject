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
    /// <summary>
    /// Goonja.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Goonja : Page
    {
        List<string> buildingClassrooms;
        public Goonja(List<string> buildingClassrooms)
        {
            this.buildingClassrooms = buildingClassrooms;
            InitializeComponent();
        }

        private void GoonjaButton1_Click(object sender, RoutedEventArgs e)
        {

            Goonja1F Goonja1F = new Goonja1F(buildingClassrooms);
            NavigationService.Navigate(Goonja1F);

           
        }

        private void GoonjaButton2_Click(object sender, RoutedEventArgs e)
        {

            Goonja3F Goonja3F = new Goonja3F(buildingClassrooms);
            NavigationService.Navigate(Goonja3F);

        }
    }
}
