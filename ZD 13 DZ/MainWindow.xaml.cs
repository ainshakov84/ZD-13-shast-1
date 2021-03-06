using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZD_13_DZ
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

            public MainWindow()
            {
                InitializeComponent();
                List<string> styles = new List<string>() { "Светлая тема", "Темная тема" };
                styleBox.ItemsSource = styles;
                styleBox.SelectionChanged += ThemeChenge;
                styleBox.SelectedIndex = 0;

            }
            private void ThemeChenge(object sender, SelectionChangedEventArgs e)
            {
                int styleIndex = styleBox.SelectedIndex;
                Uri uri = new Uri("Light.xaml", UriKind.Relative);
                if (styleIndex == 1)
                {
                    uri = new Uri("Dark.xaml", UriKind.Relative);
                }
                ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resource);
            }
            /* private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
             {
                 string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
                 if (textBox != null)
                     textBox.FontFamily = new FontFamily(fontName);

             }*/

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                if (textBox.FontWeight == FontWeights.Normal)
                {
                    textBox.FontWeight = FontWeights.Bold;
                }
                else
                {
                    textBox.FontWeight = FontWeights.Normal;
                }
            }

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                if (textBox.FontStyle == FontStyles.Normal)
                {
                    textBox.FontStyle = FontStyles.Italic;
                }
                else
                {
                    textBox.FontStyle = FontStyles.Normal;
                }
            }

            private void Button_Click_2(object sender, RoutedEventArgs e)
            {
                if (textBox.TextDecorations == null)
                {
                    textBox.TextDecorations = TextDecorations.Underline;
                }
                else
                {
                    textBox.TextDecorations = null;
                }
            }

            /*private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
            {
                string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
                if (textBox != null)
                    textBox.FontSize = Convert.ToDouble(fontSize);
            }*/


            private void RadioButton_Checked(object sender, RoutedEventArgs e)
            {
                textBox.Foreground = Brushes.Black;
            }

            private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
            {
                textBox.Foreground = Brushes.Red;
            }



            /* private void MenuItem_Click_1(object sender, RoutedEventArgs e)
             {
                 SaveFileDialog saveFileDialog = new SaveFileDialog();
                 saveFileDialog.Filter = "Тектовые файлы (*.txt)|*.txt| все файлы(*.*) | *.*";
                 if (saveFileDialog.ShowDialog() == true)
                 {
                     File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                 }
             }


             private void MenuItem_Click(object sender, RoutedEventArgs e)
             {
                 OpenFileDialog openFileDialog = new OpenFileDialog();
                 openFileDialog.Filter = "Тектовые файлы (*.txt)|*.txt| все файлы(*.*) | *.*";
                 if (openFileDialog.ShowDialog() == true)
                 {
                     textBox.Text = File.ReadAllText(openFileDialog.FileName);
                 }
             }*/
            private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
            {
                Application.Current.Shutdown();
            }



            private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Тектовые файлы (*.txt)|*.txt| все файлы(*.*) | *.*";
                if (openFileDialog.ShowDialog() == true)
                {
                    textBox.Text = File.ReadAllText(openFileDialog.FileName);
                }


            }

            private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Тектовые файлы (*.txt)|*.txt| все файлы(*.*) | *.*";
                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                }
            }

            private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                string fName = (sender as ComboBox).SelectedItem.ToString();
                if (textBox != null)
                {
                    textBox.FontFamily = new FontFamily(fName);
                }
            }

            private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
            {
                string fontSize = (sender as ComboBox).SelectedItem.ToString();
                if (textBox != null)
                {
                    textBox.FontSize = Convert.ToDouble(fontSize);
                }
            }
        }
    }

