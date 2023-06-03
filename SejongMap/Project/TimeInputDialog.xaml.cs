using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Project
{
    public partial class TimeInputDialog : Page
    {
        private string[] daysOfWeek = { "월요일", "화요일", "수요일", "목요일", "금요일", "토요일" };

        public TimeInputDialog()
        {
            InitializeComponent();

            // 시작 시간
            for (int hour = 9; hour <= 22; hour++)
            {
                for (int minute = 0; minute <= 30; minute += 30)
                {
                    string startTime = $"{hour:D2}:{minute:D2}";
                    startTimeComboBox.Items.Add(startTime);
                }
            }

            // 사용 시간
            for (int hour = 9; hour <= 22; hour++)
            {
                for (int minute = 0; minute <= 30; minute += 30)
                {
                    string usageTime = $"{hour:D2}:{minute:D2}";
                    usageTimeComboBox.Items.Add(usageTime);
                }
            }

            // 요일
            foreach (string day in daysOfWeek)
            {
                dayOfWeekComboBox.Items.Add(day);
            }

            // 이벤트 핸들러 등록 (필요에 따라 추가)
            // startTimeComboBox.SelectionChanged += StartTimeComboBox_SelectionChanged;
            // usageTimeComboBox.SelectionChanged += UsageTimeComboBox_SelectionChanged;
        }

        private void StartTimeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedStartTime = ((ComboBoxItem)startTimeComboBox.SelectedItem).Content.ToString();
            // 선택된 항목에 대한 작업 수행
        }

        private void UsageTimeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedUsageTime = ((ComboBoxItem)usageTimeComboBox.SelectedItem).Content.ToString();
            // 선택된 항목에 대한 작업 수행
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (startTimeComboBox.SelectedItem != null && usageTimeComboBox.SelectedItem != null && dayOfWeekComboBox.SelectedItem != null)
            {
                string startTime = startTimeComboBox.SelectedItem.ToString();
                string usageTime = usageTimeComboBox.SelectedItem.ToString();
                string dayOfWeek = dayOfWeekComboBox.SelectedItem.ToString();

                if (TimeSpan.TryParse(startTime, out TimeSpan startTimeSpan) && TimeSpan.TryParse(usageTime, out TimeSpan usageTimeSpan))
                {
                    Page3 page3 = new Page3(startTimeSpan, usageTimeSpan, dayOfWeek);
                    NavigationService.Navigate(page3);
                }
                else
                {
                    MessageBox.Show("Please select a valid start time, usage time, and day of week.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid start time, usage time, and day of week.");
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
