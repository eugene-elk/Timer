using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System;

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainToolbox.xaml.
    /// </summary>
    [ProvideToolboxControl("Timer.MainToolbox", true)]
    public partial class MainToolbox : Window
    {
        public MainToolbox()
        {
            InitializeComponent();
            string result = "";
            result += session_length();
            textSessionLenght.Text = result;
        }

        private TimeSpan session_length()
        {
            GeneralSettings.Default.nowTime = DateTime.Now;
            TimeSpan difference = GeneralSettings.Default.nowTime.Subtract(GeneralSettings.Default.startTime);
            return difference;
        }

        private void Upd_Click(object sender, RoutedEventArgs e)
        {
            string result = "";
            result += session_length();
            textSessionLenght.Text = result;
        }


    }
}
