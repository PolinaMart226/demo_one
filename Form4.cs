using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace demo_one
{
    public partial class Form4: Form
    {
        private readonly ToolTip toolTip; // Объявляем ToolTip как поле класса
        public Form4()
        {
            InitializeComponent();
            LoadCompanyTypes();
            toolTip = new ToolTip(); // Инициализируем ToolTip

            // Устанавливаем подсказки для каждого TextBox
            toolTip.SetToolTip(textBoxPartnerId, "Введите ID партнера (целое число)");
            toolTip.SetToolTip(textBoxNameCompany, "Введите название папртнера (компании)");
            toolTip.SetToolTip(comboBoxTypeCompany, "Выберите тип компании");
            toolTip.SetToolTip(textBoxRating, "Введите рейтинг (целое неотрицательное число)");
            toolTip.SetToolTip(textBoxAddress, "Введите адрес компании");
            toolTip.SetToolTip(textBoxFullnameDirector, "Введите полное ФИО директора");
            toolTip.SetToolTip(textBoxContactNumber, "Введите контактный номер (телефон)");
            toolTip.SetToolTip(textBoxEmail, "Введите адрес электронной почты");
            toolTip.SetToolTip(textBoxInn, "Введите ИНН компании");
            toolTip.SetToolTip(textBoxSale, "Введите сумму для скидки (целое число)");
        }
        private void LoadCompanyTypes()
        {
            var connectionString = "Password=2264;Database=dbmasterfloor;Username=postgres;Host=localhost";
            // Загрузка типов компаний из базы данных
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT DISTINCT type_company FROM partners", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxTypeCompany.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }
        private void ButtonSave_one_Click(object sender, EventArgs e)
        {
            // Проверка на заполнение полей
            if (string.IsNullOrWhiteSpace(this.textBoxPartnerId.Text) || // Добавлено поле partner_id
                string.IsNullOrWhiteSpace(textBoxNameCompany.Text) ||
                string.IsNullOrWhiteSpace(textBoxRating.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text) ||
                string.IsNullOrWhiteSpace(textBoxFullnameDirector.Text) ||
                string.IsNullOrWhiteSpace(textBoxContactNumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxInn.Text) ||
                string.IsNullOrWhiteSpace(textBoxSale.Text) ||
                comboBoxTypeCompany.SelectedItem == null)

            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Проверка на неотрицательный рейтинг
            if (!int.TryParse(textBoxRating.Text, out int rating) || rating < 0)
            {
                MessageBox.Show("Рейтинг должен быть целым неотрицательным числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Проверка на нашу скидку,что ввели число
            if (!int.TryParse(textBoxSale.Text, out int sale))
            {
                MessageBox.Show("Введите сумму числом,проверьте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Проверка на корректность partner_id
            if (!int.TryParse(textBoxPartnerId.Text, out int partnerId) || partnerId < 0) // Изменено на partnerId
            {
                MessageBox.Show("ID должен быть целым неотрицательным числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Предупреждение о SQL-инъекциях
            { 
                MessageBox.Show("Пожалуйста, используйте безопасные методы для работы с базой данных, чтобы избежать SQL-инъекций.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            var connectionString = "Password=2264;Database=dbmasterfloor;Username=postgres;Host=localhost";
            // Сохранение данных в базу
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("INSERT INTO partners (partner_id, type_company, name_company, fullname_director, contact_number, email, adress, inn, rating, sale) VALUES (@partner_id, @type_company, @name_company, @fullname_director, @contact_number, @email, @adress, @inn, @rating, @sale)", connection))
                {
                    command.Parameters.AddWithValue("partner_id", partnerId);
                    command.Parameters.AddWithValue("type_company", comboBoxTypeCompany.SelectedItem.ToString());
                    command.Parameters.AddWithValue("name_company", textBoxNameCompany.Text);
                    command.Parameters.AddWithValue("fullname_director", textBoxFullnameDirector.Text);
                    command.Parameters.AddWithValue("contact_number", textBoxContactNumber.Text);
                    command.Parameters.AddWithValue("email", textBoxEmail.Text);
                    command.Parameters.AddWithValue("adress", textBoxAddress.Text);
                    command.Parameters.AddWithValue("inn", textBoxInn.Text);
                    command.Parameters.AddWithValue("rating", rating);
                    command.Parameters.AddWithValue("sale", sale);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbmasterfloorDataSet.partners". При необходимости она может быть перемещена или удалена.
            this.partnersTableAdapter.Fill(this.dbmasterfloorDataSet.partners);

        }
    }
}