using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System;
using System.IO;

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

            StreamReader sr = new StreamReader("D:\\prog\\sessions.txt");
            while(!sr.EndOfStream)
            {
                string readedLine = sr.ReadLine();
                sessionsList.Items.Add(readedLine);
            }
            sr.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
