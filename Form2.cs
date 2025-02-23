using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demo_one
{
    public partial class Form2 : Form
    {
        private readonly System.Windows.Forms.ToolTip toolTip; // Объявляем ToolTip как поле класса
        public Form2()
        {
            InitializeComponent();
            // Загрузка партнеров при открытии формы
            LoadPartners();
            toolTip = new System.Windows.Forms.ToolTip(); // Инициализируем ToolTip

            // Устанавливаем подсказки для каждого TextBox
            toolTip.SetToolTip(textBoxId, "Введите ID партнера");
            toolTip.SetToolTip(textBoxType, "Введите тип компании");
            toolTip.SetToolTip(textBoxName, "Введите название партнера (компании)");
            toolTip.SetToolTip(textBoxDirector, "Введите полное ФИО директора");
            toolTip.SetToolTip(textBoxContact, "Введите контактный номер (телефон)");
            toolTip.SetToolTip(textBoxRating, "Введите рейтинг");
            toolTip.SetToolTip(textBoxSale, "Введите сумму  для скидки");
        }
        // Метод для загрузки партнеров
        private void LoadPartners()
        {
            // Получаем список партнеров
            var partners = GetPartners();
            // Отображаем их на форме
            DisplayPartners(partners);
        }
        // Метод для расчета скидки на основе объема продаж
        private decimal CalculateDiscount(long sale)
        {
            if (sale < 10000)
            {
                return 0m; // 0% скидка
            }
            else if (sale >= 10000 && sale < 50000)
            {
                return 5m; // 5% скидка
            }
            else if (sale >= 50000 && sale < 300000)
            {
                return 10m; // 10% скидка
            }
            else
            {
                return 15m; // 15% скидка
            }
        }
        // Метод для получения партнеров
        private List<Partner> GetPartners()
        {
            var partners = new List<Partner>();
            var connectionString = "Password=2264;Database=dbmasterfloor;Username=postgres;Host=localhost";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT partner_id, type_company, name_company, fullname_director, contact_number, rating, sale FROM partners", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        partners.Add(new Partner
                        {
                            ID = reader.GetInt32(0),
                            Type = reader.GetString(1),
                            Name = reader.GetString(2),
                            Director = reader.GetString(3),
                            ContactNumber = reader.GetString(4),
                            Rating = reader.GetInt32(5),
                            Sale = reader.GetInt32(6),
                        });
                    }
                }
            }

            return partners;
        }
        // Метод для отображения партнеров в виде карточек
        private void DisplayPartners(List<Partner> partners)
        {
            // Очищаем предыдущие карточки
            panel.Controls.Clear();

            foreach (var partner in partners)
            {
                var card = new Panel
                {
                    Size = new System.Drawing.Size(900, 170),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                var labelID = new Label { Text = $"ID: {partner.ID}", Dock = DockStyle.Top };
                var labelType = new Label { Text = $"Тип: {partner.Type}", Dock = DockStyle.Top };
                var labelName = new Label { Text = $"|  Наименование: {partner.Name}", Dock = DockStyle.Top };
                var labelDirector = new Label { Text = $"Директор: {partner.Director}", Dock = DockStyle.Top };
                var labelContact = new Label { Text = $"Контакт: {partner.ContactNumber}", Dock = DockStyle.Top };
                var labelRating = new Label { Text = $"Рейтинг: {partner.Rating}", Dock = DockStyle.Top };

                // Рассчитываем скидку
                decimal discount = CalculateDiscount(partner.Sale);
                var labelSale = new Label
                {
                    Text = $"Скидка: {discount}%",
                    Dock = DockStyle.Top
                };

                card.Controls.Add(labelSale);
                card.Controls.Add(labelRating);
                card.Controls.Add(labelContact);
                card.Controls.Add(labelDirector);
                card.Controls.Add(labelName);
                card.Controls.Add(labelType);
                card.Controls.Add(labelID);

                panel.Controls.Add(card); // Добавляем карточку в панель
            }
        }
        // Метод для добавления нового партнера
        private void ButtonAdd_Click_1(object sender, EventArgs e)
        {

            // Получаем данные из текстовых полей
            if (ValidateInputs())
            {
                var partner = new Partner
                {
                    ID = int.Parse(textBoxId.Text),
                    Type = textBoxType.Text,
                    Name = textBoxName.Text,
                    Director = textBoxDirector.Text,
                    ContactNumber = textBoxContact.Text,
                    Rating = int.Parse(textBoxRating.Text),
                    Sale = int.Parse(textBoxSale.Text) // Валидация должна подтверждать, что это число
                };

                {
                    MessageBox.Show("Данные успешно сохранены!", "Данные введены корректно", MessageBoxButtons.OK, MessageBoxIcon.Information); // Уведомление об успешном сохранении
                } 
                // Добавление партнера
                AddPartner(partner);
                // Перезагрузка списка партнеров
                LoadPartners();
            }
        }
        // Метод для обновления списка партнеров
        public void UpdatePartners()
        {
            LoadPartners(); // Перезагружаем список партнеров
            MessageBox.Show("Список партнеров обновлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Метод для добавления партнера в БД
        private void AddPartner(Partner partner)
        {
            var connectionString = "Password=2264;Database=dbmasterfloor;Username=postgres;Host=localhost";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("INSERT INTO partners( partner_id, type_company, name_company, fullname_director, contact_number, rating, sale) VALUES (@id, @type, @name, @director, @contact, @rating, @sale)", connection);
                command.Parameters.AddWithValue("id", partner.ID);
                command.Parameters.AddWithValue("type", partner.Type);
                command.Parameters.AddWithValue("name", partner.Name);
                command.Parameters.AddWithValue("director", partner.Director);
                command.Parameters.AddWithValue("contact", partner.ContactNumber);
                command.Parameters.AddWithValue("rating", partner.Rating);
                command.Parameters.AddWithValue("sale", partner.Sale);
                command.ExecuteNonQuery(); // Выполнение команды

                
            }
        }
        // Метод валидации входных данных
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text) // Проверка на корректность ввода id
                || string.IsNullOrWhiteSpace(textBoxType.Text)
                || string.IsNullOrWhiteSpace(textBoxName.Text)
                || string.IsNullOrWhiteSpace(textBoxDirector.Text)
                || string.IsNullOrWhiteSpace(textBoxContact.Text)
                || string.IsNullOrWhiteSpace(textBoxSale.Text)
                || !int.TryParse(textBoxRating.Text, out _) // Проверка на корректность ввода рейтинга
                || !int.TryParse(textBoxId.Text, out _) // Проверка на корректность ввода id
                || !int.TryParse(textBoxSale.Text, out _)) // Проверка на корректность ввода скидка
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        // Переход на форму 1 с помощью кнопки "Назад" и остальные переходы
        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form1 fr2 = new Form1();
            fr2.Show();
            Hide();
        }
        private void ButtonAdd_two_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }
        private void ButtonModule_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
            Hide();
        }

        private void Button_rkm_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.Show();
            Hide();
        }
    }
}
