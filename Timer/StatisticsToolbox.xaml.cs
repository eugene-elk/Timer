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
            string flex = "loveflex";
            sessionsList.Items.Add(flex);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
