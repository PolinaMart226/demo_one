using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace demo_one
{
    public partial class Form3: Form
    {
        private readonly System.Windows.Forms.ToolTip toolTip; // Объявляем ToolTip как поле класса
        public Form3()
        {
            InitializeComponent();

            toolTip = new System.Windows.Forms.ToolTip(); // Инициализируем ToolTip

            // Устанавливаем подсказки для каждого TextBox
            toolTip.SetToolTip(textBoxPartnerId_r, "Введите ID партнера для поиска");
            toolTip.SetToolTip(comboBoxTypeCompany_r, "Выберите тип компании");
            toolTip.SetToolTip(textBoxNameCompany_r, "Введите название партнера (компании)");
            toolTip.SetToolTip(textBoxFullnameDirector_r, "Введите полное ФИО директора");
            toolTip.SetToolTip(textBoxContactNumber_r, "Введите контактный номер (телефон)");
            toolTip.SetToolTip(textBoxRating_r, "Введите рейтинг");
            toolTip.SetToolTip(textBoxAddress_r, "Введите адрес компании");
            toolTip.SetToolTip(textBoxSale_red, "Введите сумму  для скидки");
            toolTip.SetToolTip(textBoxEmail_r, "Введите email компании");
            toolTip.SetToolTip(textBoxInn_red, "Введите ИНН компании");
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // Проверка на корректность partner_id
            if (!int.TryParse(textBoxPartnerId_r.Text, out int partnerId) || partnerId < 0)
            {
                MessageBox.Show("Введите корректный ID партнера.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var connectionString = "Password=2264;Database=dbmasterfloor;Username=postgres;Host=localhost";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM partners WHERE partner_id = @partner_id", connection))
                {
                    command.Parameters.AddWithValue("partner_id", partnerId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Заполнение текстовых полей данными из базы
                            textBoxNameCompany_r.Text = reader["name_company"].ToString();
                            textBoxFullnameDirector_r.Text = reader["fullname_director"].ToString();
                            textBoxContactNumber_r.Text = reader["contact_number"].ToString();
                            textBoxEmail_r.Text = reader["email"].ToString();
                            textBoxAddress_r.Text = reader["adress"].ToString();
                            textBoxInn_red.Text = reader["inn"].ToString();
                            textBoxRating_r.Text = reader["rating"].ToString();
                            textBoxSale_red.Text = reader["sale"].ToString();
                            comboBoxTypeCompany_r.SelectedItem = reader["type_company"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Партнер не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }


        }
        private void ButtonSavee_Click(object sender, EventArgs e)
        {
            // Проверка на заполнение полей
            if (string.IsNullOrWhiteSpace(textBoxNameCompany_r.Text) ||
                string.IsNullOrWhiteSpace(textBoxRating_r.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress_r.Text) ||
                string.IsNullOrWhiteSpace(textBoxFullnameDirector_r.Text) ||
                string.IsNullOrWhiteSpace(textBoxContactNumber_r.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail_r.Text) ||
                string.IsNullOrWhiteSpace(textBoxInn_red.Text) ||
                string.IsNullOrWhiteSpace(textBoxSale_red.Text) ||
                comboBoxTypeCompany_r.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на неотрицательный рейтинг
            if (!int.TryParse(textBoxRating_r.Text, out int rating) || rating < 0)
            {
                MessageBox.Show("Рейтинг должен быть целым неотрицательным числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на корректность partner_id
            if (!int.TryParse(textBoxPartnerId_r.Text, out int partnerId) || partnerId < 0)
            {
                MessageBox.Show("Введите корректный ID партнера.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на нашу скидку, что ввели число
            if (!int.TryParse(textBoxSale_red.Text, out int sale))
            {
                MessageBox.Show("Введите сумму числом, проверьте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var connectionString = "Password=2264;Database=dbmasterfloor;Username=postgres;Host=localhost";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("UPDATE partners SET type_company = @type_company, name_company = @name_company, fullname_director = @fullname_director, contact_number = @contact_number, email = @email, adress = @adress, inn = @inn, rating = @rating, sale = @sale WHERE partner_id = @partner_id", connection))
                {
                    command.Parameters.AddWithValue("partner_id", partnerId);
                    command.Parameters.AddWithValue("type_company", comboBoxTypeCompany_r.SelectedItem.ToString());
                    command.Parameters.AddWithValue("name_company", textBoxNameCompany_r.Text);
                    command.Parameters.AddWithValue("fullname_director", textBoxFullnameDirector_r.Text);
                    command.Parameters.AddWithValue("contact_number", textBoxContactNumber_r.Text);
                    command.Parameters.AddWithValue("email", textBoxEmail_r.Text);
                    command.Parameters.AddWithValue("adress", textBoxAddress_r.Text);
                    command.Parameters.AddWithValue("inn", textBoxInn_red.Text);
                    command.Parameters.AddWithValue("rating", rating);
                    command.Parameters.AddWithValue("sale", sale);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
