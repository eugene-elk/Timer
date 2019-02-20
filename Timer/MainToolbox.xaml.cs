using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Windows.Threading;

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainToolbox.xaml.
    /// </summary>
    [ProvideToolboxControl("Timer.MainToolbox", true)]
    public partial class MainToolbox : Window
    {
        readonly DispatcherTimer m_timer = new DispatcherTimer();

        public MainToolbox()
        {
            InitializeComponent();

            update_time_in_text();

            m_timer.Interval = TimeSpan.FromSeconds(1);
            m_timer.Tick += TimerOnTick;
            m_timer.Start();
        }

        private void update_time_in_text()
        {
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

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
            // update_time_in_text();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            update_time_in_text();
            textSessionLenght.UpdateLayout();
        }
    }
}
