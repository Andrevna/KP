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
using System.Data.Sql;
using System.Data.SqlClient;

namespace KP_ST
{
    /// <summary>
    /// Логика взаимодействия для Authentication.xaml
    /// </summary>
    public partial class Authentication : Window
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Отмена_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainMenu = new MainWindow();
            this.Close();
            mainMenu.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                //StaffEntities1 staffEntities1 = new StaffEntities1();
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-VG2JUP5S\SQLEXPRESS;Initial Catalog=Staff;Integrated Security=True");
                connection.Open();
                string loginStaff = Логин.Text;
                string passwordStaff = Пароль.Password;
                string cmd = "SELECT * FROM Staff  WHERE Login='" + loginStaff + "' AND Password='" + passwordStaff + "' ";
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                _ = createCommand.ExecuteNonQuery();
                SqlDataReader dr = createCommand.ExecuteReader();
                int count = 0;
                int trysign = 0;
                while (dr.Read())
                {
                    trysign++;
                    count++;
                }

                // Проверки ввода логина и пароля


                var ps = Пароль.Password.Trim();
                var lg = Логин.Text.Trim();

                if (string.IsNullOrEmpty(lg))
                {
                    MessageBox.Show("Введите логин");
                    return;
                }
                if (string.IsNullOrEmpty(ps))
                {
                    MessageBox.Show("Введите пароль");
                    return;
                }

                if (count == 1)
                {
                    MessageBox.Show($"Добро Пожаловать!");

                    MainMenu mainMenu = new MainMenu();
                    this.Close();
                    mainMenu.Show();
                }
                if (count < 1)
                {
                    MessageBox.Show("Ошибка ввода! Неправильный логин или пароль.");

                }
                if (count > 1)
                {

                    MessageBox.Show("Ошибка ввода! Неправильный логин или пароль.");

                }


            }
        }
    }
}
