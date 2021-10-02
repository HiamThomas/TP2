using System;
using System.Linq;
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

        private void ComboBoxClick(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox.SelectedItem.ToString().Split(new string[] {": "}, StringSplitOptions.None).Last())
            {
                case "Vigenere":
                    keyCesarDecalage.Visibility = Visibility.Hidden;
                    keyCesarAlphabet.Visibility = Visibility.Hidden;
                    keyAtbashAlphabet.Visibility = Visibility.Hidden;
                    keyVigenere.Visibility = Visibility.Visible;
                    keyVigenere.Text = "key";
                    break;

                case "Cesar":
                    keyCesarDecalage.Visibility = Visibility.Visible;
                    keyCesarAlphabet.Visibility = Visibility.Visible;
                    keyVigenere.Visibility = Visibility.Hidden;
                    keyAtbashAlphabet.Visibility = Visibility.Hidden;
                    keyCesarAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    keyCesarDecalage.Text = "3";
                    break;

                case "Atbash":
                    keyCesarDecalage.Visibility = Visibility.Hidden;
                    keyCesarAlphabet.Visibility = Visibility.Hidden;
                    keyVigenere.Visibility = Visibility.Hidden;
                    keyAtbashAlphabet.Visibility = Visibility.Visible;
                    keyAtbashAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
            }
        }

        private void ButtonRun(object sender, RoutedEventArgs e)
        {
            switch (comboBox.SelectionBoxItem.ToString())
            {
                case "Vigenere":
                    if (checkBox.IsChecked == true)
                        textOutput.Text = Vigenere.run(textInput.Text, keyVigenere.Text, false);
                    else
                        textOutput.Text = Vigenere.run(textInput.Text, keyVigenere.Text, true);
                    break;

                case "Cesar":
                    if (checkBox.IsChecked == true)
                        textOutput.Text = Cesar.Dechiffrer(textInput.Text, keyCesarAlphabet.Text,
                            keyCesarDecalage.Text);
                    else
                        textOutput.Text = Cesar.Chiffrer(textInput.Text, keyCesarAlphabet.Text,
                            keyCesarDecalage.Text);
                    break;

                case "Atbash":
                    if (checkBox.IsChecked == true)
                        textOutput.Text = Atbash.Dechiffrer(textInput.Text, keyAtbashAlphabet.Text);
                    else
                        textOutput.Text = Atbash.Chiffrer(textInput.Text, keyAtbashAlphabet.Text);
                    break;
            }
        }
    }
}