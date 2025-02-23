using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace demo_one
{
    public partial class Form6: Form
    {
        private readonly ToolTip toolTip; // Объявляем ToolTip как поле класса
        private readonly string connectionString = "Password=2264;Database=dbmasterfloor;Username=postgres;Host=localhost";
        public Form6()
        {
            InitializeComponent();
            toolTip = new ToolTip(); // Инициализируем ToolTip

            // Устанавливаем подсказки для каждого TextBox
            toolTip.SetToolTip(productTypeIdTextBox, "Введите идентификатор типа продукции");
            toolTip.SetToolTip(materialIdTextBox, "Введите идентификатор типа материала");
            toolTip.SetToolTip(quantityTextBox, "Введите количество получаемой продукции (целые числа)");
            toolTip.SetToolTip(parametersTextBox, "Введите параметры продукции (два параметра через запяпую)");
        }
        private void СalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productTypeId = int.Parse(productTypeIdTextBox.Text);
                int materialId = int.Parse(materialIdTextBox.Text);
                int quantity = int.Parse(quantityTextBox.Text);
                string[] parameters = parametersTextBox.Text.Split(',');

                if (parameters.Length != 2 ||
                    !double.TryParse(parameters[0], out double param1) ||
                    !double.TryParse(parameters[1], out double param2) ||
                    param1 <= 0 || param2 <= 0)
                {
                    MessageBox.Show("Параметры продукции должны быть положительными вещественными числами.");
                    return;
                }

                int requiredMaterial = CalculateRequiredMaterial(productTypeId, materialId, quantity, param1, param2);
                LabelResultOne.Text = $"Необходимое количество материала с учетом возможного брака материала: {requiredMaterial}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные целые числа для идентификаторов и количества.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        private int CalculateRequiredMaterial(int productTypeId, int materialId, int quantity, double param1, double param2)
        {
            double coefficient = 0;
            double defectPercentage = 0;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Получение коэффициента типа продукции
                using (var command = new NpgsqlCommand("SELECT coefficient FROM public.product_type WHERE product_type_id = @productTypeId", connection))
                {
                    command.Parameters.AddWithValue("@productTypeId", productTypeId);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        coefficient = Convert.ToDouble(result);
                    }
                    else
                    {
                        return -1; // Не существует типа продукции
                    }
                }

                // Получение процента брака материала
                using (var command = new NpgsqlCommand("SELECT procent_defectss FROM public.materials WHERE materials_id = @materialId", connection))
                {
                    command.Parameters.AddWithValue("@materialId", materialId);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        defectPercentage = Convert.ToDouble(result);
                    }
                    else
                    {
                        return -1; // Не существует типа материала
                    }
                }
            }
            // Расчет необходимого материала
            double materialPerProduct = param1 * param2 * coefficient;
            double totalMaterial = materialPerProduct * quantity;
            double totalMaterialWithDefects = totalMaterial * (1 + defectPercentage / 100);

            return (int)Math.Ceiling(totalMaterialWithDefects); // Округление вверх
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }
    }
}