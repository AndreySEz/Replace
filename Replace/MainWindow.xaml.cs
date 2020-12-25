using System;
using System.Collections.Generic;
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

namespace Replace
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            btn.Content = Result(txtBoxWord.Text);
        }

        private string Result(string String)
        {
            string outString="";
            char[] chars = String.ToCharArray();
            for (int i=1; i < chars.Length; i++)
            {
                outString += chars[i];
            }
            outString += chars[0];
            return outString;
        }
    }
}
