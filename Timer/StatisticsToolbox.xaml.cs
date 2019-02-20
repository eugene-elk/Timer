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
            try
            {
                StreamReader sr = new StreamReader(GeneralSettings.Default.path);
                while (!sr.EndOfStream)
                {
                    string readedLine = sr.ReadLine();
                    sessionsList.Items.Add(readedLine);
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Статистика пока пуста");
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
