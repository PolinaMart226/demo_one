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
using ToolTip = System.Windows.Forms.ToolTip;

namespace demo_one
{
    public partial class Form5: Form
    {
        private readonly ToolTip toolTip; // Объявляем ToolTip как поле класса
        private readonly string connectionString = "Password=2264;Database=dbmasterfloor;Username=postgres;Host=localhost";
        public Form5()
        {
            InitializeComponent();
            toolTip = new ToolTip(); // Инициализируем ToolTip

            toolTip.SetToolTip(comboBoxPartner, "Выберите название папртнера (компании)");
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbmasterfloorDataSet.partner_products_history". При необходимости она может быть перемещена или удалена.
            this.partner_products_historyTableAdapter.Fill(this.dbmasterfloorDataSet.partner_products_history);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }
        private void ButtonAdd_two_Click(object sender, EventArgs e)
        {
            // Получаем выбранного партнера из comboBoxPartner
            string selectedPartner = comboBoxPartner.SelectedItem.ToString();
            LoadPartnerHistory(selectedPartner);
        }
        private void LoadPartnerHistory(string partnerName)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT product_name, quantity, data_of_sale " +
                               "FROM partner_products_history " +
                               "WHERE name_partner = @partnerName";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("partnerName", partnerName);
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
    }
}