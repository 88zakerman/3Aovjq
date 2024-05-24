using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualExam_Bingo_Bongo
{
    public partial class Form8_createProduct : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo");

        public Form8_createProduct()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Создаем SQL-запрос для вставки новой записи в таблицу products
                string query = "INSERT INTO products (name_products, type_products, in_stock_products, price_products) " +
                "VALUES (@nameProducts, @typeProducts, @inStockProducts, @priceProducts)";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Замените параметры на значения из текстовых полей формы
                cmd.Parameters.AddWithValue("@nameProducts", textBox_name_products.Text);
                cmd.Parameters.AddWithValue("@typeProducts", textBox_type_products.Text);
                cmd.Parameters.AddWithValue("@inStockProducts", Convert.ToInt32(textBox_in_stock_products.Text));
                cmd.Parameters.AddWithValue("@priceProducts", Convert.ToDecimal(textBox_price_products.Text));

                // Выполняем SQL-запрос
                cmd.ExecuteNonQuery();

                MessageBox.Show("Продукт успешно создан.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Закрываем соединение с базой данных
                connection.Close();

                // Закрываем текущую форму после успешного создания продукта
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании продукта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Убедитесь, что соединение с базой данных закрыто, даже если возникла ошибка
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void textBox_in_stock_products_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
