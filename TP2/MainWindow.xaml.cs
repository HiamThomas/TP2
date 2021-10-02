using System.Windows;
using System.Windows.Controls;

namespace TP2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void TextBox_TextChanged_Output(object sender, TextChangedEventArgs e)
        {
            
        }
        private void TextBox_TextChanged_Input(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRun(object sender, RoutedEventArgs e)
        {
            switch (comboBox.SelectionBoxItem.ToString())
            {
                case "Vigenere":
                    if (checkBox.IsChecked == true)
                        textOutput.Text = Algo1.Vigenere(textInput.Text, key.Text,false);
                    else
                        textOutput.Text = Algo1.Vigenere(textInput.Text, key.Text,true);
                    break;
                
                case "Algo 2":
                    if (checkBox.IsChecked == true)
                        textOutput.Text = Algo2.Decrypte(textInput.Text);
                    else
                        textOutput.Text = Algo2.Encrypte(textInput.Text);
                    break;

                case "Algo 3":
                    if (checkBox.IsChecked == true)
                        textOutput.Text = Algo3.Decrypte(textInput.Text);
                    else
                        textOutput.Text = Algo3.Encrypte(textInput.Text);
                    break;
            }
        }

        private void ButtonChoiceCode(object sender, RoutedEventArgs e)
        {
            
        }
    }
}