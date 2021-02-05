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
    /// Логика взаимодействия для Employees.xaml
    /// </summary>
    public partial class Employees : Window
    {
        public Employees()
        {
            InitializeComponent();
            Сотрудники.ItemsSource = St_E.GetContext().Staff.ToList();
        }

        private void Назад_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Close();
            mainMenu.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var removeShoppingCenter = Сотрудники.SelectedItems.Cast<Staff>().ToList();

            try
            {
                St_E.GetContext().Staff.RemoveRange(removeShoppingCenter);
                St_E.GetContext().SaveChanges();
                MessageBox.Show("Данные удалены.");

                Сотрудники.ItemsSource = St_E.GetContext().Staff.ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
