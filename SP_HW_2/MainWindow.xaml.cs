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

namespace SP_HW_2
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            AppDomain secondDomain = AppDomain.CreateDomain("Second domain");
            
            string assemblyPath = secondDomain.BaseDirectory + "ConsoleApp7.exe";
            
            MessageBox.Show("Сборка загружена");
            secondDomain.ExecuteAssembly(assemblyPath);
            AppDomain.Unload(secondDomain);
            MessageBox.Show("Домен выгружен из процесса");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            AppDomain thirdDomain = AppDomain.CreateDomain("Second domain");

            string assemblyPath2 = thirdDomain.BaseDirectory + "ConsoleApp7.exe";

            int number = 9;            
            string[] arguments = new string[] { number.ToString() };
            MessageBox.Show("Сборка загружена");
            thirdDomain.ExecuteAssembly(assemblyPath2, arguments);
            AppDomain.Unload(thirdDomain);
            MessageBox.Show("Домен выгружен из процесса");
        }
    }
}
