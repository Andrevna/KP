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
using System.Windows.Shapes;

namespace KP_ST
{
    /// <summary>
    /// Логика взаимодействия для Vacancies.xaml
    /// </summary>
    public partial class Vacancies : Window
    {
        public Vacancies()
        {
            InitializeComponent();
        }

        private void Назад_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainMenu = new MainWindow();
            this.Close();
            mainMenu.Show();
        }
    }
}
