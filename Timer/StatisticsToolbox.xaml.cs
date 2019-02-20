using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System;

namespace Timer
{
    /// <summary>
    /// Interaction logic for StatisticsToolbox.xaml.
    /// </summary>
    [ProvideToolboxControl("Timer.StatisticsToolbox", true)]
    public partial class StatisticsToolbox : Window
    {
        public StatisticsToolbox()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(CultureInfo.CurrentUICulture, "We are inside {0}.Button1_Click()", this.ToString()));
        }
    }
}
