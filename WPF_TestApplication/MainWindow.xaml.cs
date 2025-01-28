using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_TestApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button_ShowName.IsEnabled = false;

            ComboBox_AccountRole.Itmes.Add("Student");
            ComboBox_AccountRole.Itmes.Add("Student");




        }

        private void button_Click_ShowName(object sender, RoutedEventArgs e)
        {
            var inputName = Textbox_InputFirstName.Text;
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            var inputName = textBox.Text;
            Label_FirstName.Content = inputName;
        }

        private void CheckBox_AcceptRules_Checked(object sender, RoutedEventArgs e)
        {
            bool acceptRules = CheckBox_AcceptRules.Value;
            if (acceptRules)
            {
                button.IsEnabled = true;

            }
            else
            {
                button.IsEnabled = false;
            }
        }








        private void CheckBox_AcceptRules_Click(object sender, RoutedEventArgs e)
        {
         Button
        }






