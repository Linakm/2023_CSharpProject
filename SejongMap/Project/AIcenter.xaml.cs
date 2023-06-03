using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AICenter : Page
    {

        List<string> buildingClassrooms;
        public AICenter(List<string> buildingClassrooms)
        {
            this.buildingClassrooms = buildingClassrooms;
            InitializeComponent();

            List<string> fontList = new List<string>();
            foreach (FontFamily font in Fonts.SystemFontFamilies)
            {
                fontList.Add(string.Join(",", font.FamilyNames.Values));
                Debug.WriteLine(string.Join(",", font.FamilyNames.Values));
            }
        }

        private void AIButton1_Click(object sender, RoutedEventArgs e)
        {
            AICenterB1F AICenterB1F = new AICenterB1F(buildingClassrooms);
            NavigationService.Navigate(AICenterB1F);


        }

        private void AIButton2_Click(object sender, RoutedEventArgs e)
        {
            AICenterB2F AICenterB2F = new AICenterB2F(buildingClassrooms);
            NavigationService.Navigate(AICenterB2F);

           
        }
    }
}
