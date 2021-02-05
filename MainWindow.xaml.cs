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

namespace KP_ST
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

        private void Войти_Click(object sender, RoutedEventArgs e)
        {
            Authentication authentication = new Authentication();
            this.Hide();
            authentication.ShowDialog();
            this.Show();
            Close();
        }

        private void Просмотр_вакансий_Click(object sender, RoutedEventArgs e)
        {
            Vacancies vacancies = new Vacancies();
            this.Hide();
            vacancies.ShowDialog();
            this.Show();
            Close();
        }
    }
}
