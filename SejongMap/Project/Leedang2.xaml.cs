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
    /// Leedang2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Leedang2 : Page
    {
        private List<string> buildingClassrooms;
        public Leedang2(List<string> buildingClassrooms)
        {
            this.buildingClassrooms = buildingClassrooms;
            InitializeComponent();

            int floor = 2;
            int count = 0;
            int otherFloorCount = 0;
            for (int i = 0; i < buildingClassrooms.Count; i++)
            {
                if ((int)Char.GetNumericValue(buildingClassrooms[i][0]) == floor)
                    count++;
                else
                    otherFloorCount++;

            }

            int[] roomNumber = new int[count];
            for (int i = otherFloorCount; i < count; i++)
            {
                roomNumber[i] = int.Parse(buildingClassrooms[i]);
                string buttonName = "room" + roomNumber[i].ToString();

                Button button = FindName(buttonName) as Button;

                Color color = (Color)ColorConverter.ConvertFromString("#B5B3A7");
                button.Background = new SolidColorBrush(color);
            }
        }
    }
}
