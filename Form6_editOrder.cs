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
    public partial class Form6_editOrder : Form
    {
        public int PickupRequestId { get; set; }
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo";


        public Form6_editOrder()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void Form6_editOrder_Load(object sender, EventArgs e)
        {
            // Загрузка данных заказа по PickupRequestId
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo");
                connection.Open();

                string query = "SELECT customer_name, contact_email, requested_product, request_quantity, request_date, order_number FROM pickup_requests WHERE id_pickup_request = @pickupRequestId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@pickupRequestId", PickupRequestId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox_customer_name.Text = reader["customer_name"].ToString();
                    textBox_contact_email.Text = reader["contact_email"].ToString();
                    textBox_requested_product.Text = reader["requested_product"].ToString();
                    textBox_request_quantity.Text = reader["request_quantity"].ToString();
                    dateTimePicker_request_date.Value = Convert.ToDateTime(reader["request_date"]);
                    textBox_order_number.Text = reader["order_number"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_saveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string updateQuery = "UPDATE pickup_requests SET customer_name = @customerName, contact_email = @contactEmail, " +
                                     "requested_product = @requestedProduct, request_quantity = @requestQuantity, " +
                                     "request_date = @requestDate, order_number = @orderNumber " +
                                     "WHERE id_pickup_request = @pickupRequestId";

                MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@customerName", textBox_customer_name.Text);
                updateCmd.Parameters.AddWithValue("@contactEmail", textBox_contact_email.Text);
                updateCmd.Parameters.AddWithValue("@requestedProduct", textBox_requested_product.Text);
                updateCmd.Parameters.AddWithValue("@requestQuantity", textBox_request_quantity.Text);
                updateCmd.Parameters.AddWithValue("@requestDate", dateTimePicker_request_date.Value);
                updateCmd.Parameters.AddWithValue("@orderNumber", textBox_order_number.Text);
                updateCmd.Parameters.AddWithValue("@pickupRequestId", PickupRequestId);

                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Заказ успешно обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK; // Устанавливаем результат для вызывающей формы
                    Close();
                }
                else
                {
                    MessageBox.Show("Не удалось обновить заказ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        
        }
    }
}
