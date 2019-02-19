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

            string result = "";
            result += session_length();
            textSessionLenght.Text = result;

            m_timer.Interval = TimeSpan.FromSeconds(1);
            m_timer.Tick += TimerOnTick;
            m_timer.Start();
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

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            // m_timer.Stop();
            string result = "";
            result += session_length();
            textSessionLenght.Text = result;
            textSessionLenght.UpdateLayout();
        }
    }
}
