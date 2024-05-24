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
    public partial class Form6_createOrder : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo";

        public Form6_createOrder()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);

        }

        private void Form6_createOrder_Load(object sender, EventArgs e)
        {
            // Заполнение полей формы при загрузке
            dateTimePicker_request_date.Value = DateTime.Now; // Устанавливаем текущую дату
            textBox_order_number.Text = GenerateOrderNumber(); // Генерируем номер заказа
        }

        private string GenerateOrderNumber()
        {
            // Генерация уникального номера заказа, например, на основе текущей даты и времени
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string insertQuery = "INSERT INTO pickup_requests (customer_name, contact_email, requested_product, request_quantity, request_date, order_number) " +
                                     "VALUES (@customerName, @contactEmail, @requestedProduct, @requestQuantity, @requestDate, @orderNumber)";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@customerName", textBox_customer_name.Text);
                insertCmd.Parameters.AddWithValue("@contactEmail", textBox_contact_email.Text);
                insertCmd.Parameters.AddWithValue("@requestedProduct", textBox_requested_product.Text);
                insertCmd.Parameters.AddWithValue("@requestQuantity", textBox_request_quantity.Text);
                insertCmd.Parameters.AddWithValue("@requestDate", dateTimePicker_request_date.Value);
                insertCmd.Parameters.AddWithValue("@orderNumber", textBox_order_number.Text);

                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Заказ успешно создан.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK; // Устанавливаем результат для вызывающей формы
                    Close();
                }
                else
                {
                    MessageBox.Show("Не удалось создать заказ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
