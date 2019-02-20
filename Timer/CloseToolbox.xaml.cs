using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.IO;

namespace Timer
{
    /// <summary>
    /// Interaction logic for CloseToolbox.xaml.
    /// </summary>
    [ProvideToolboxControl("Timer.CloseToolbox", true)]
    public partial class CloseToolbox : Window
    {
        public CloseToolbox()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("D:\\prog\\sessions.txt", true, System.Text.Encoding.Default);

            string name = textBoxName.Text;
            string date = GeneralSettings.Default.startTime.ToString("d");
            string time = MainToolbox.session_length();

            string new_line = "Name: " + name + " Date: " + date + " Time: " + time;

            sw.WriteLine(new_line);
            sw.Close();

            Close();
        }

        private void Btn_DontSave_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
