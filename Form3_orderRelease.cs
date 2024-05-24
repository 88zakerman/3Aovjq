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
    public partial class Form3_orderRelease : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo";

        public Form3_orderRelease()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void Form3_orderRelease_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM pickup_requests WHERE is_fulfilled = 0"; // Выбрать невыполненные заказы
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_order.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button_giveOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView_order.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView_order.SelectedCells[0].RowIndex;
                int orderId = Convert.ToInt32(dataGridView_order.Rows[selectedRowIndex].Cells["id_pickup_request"].Value);

                // Обновить значение is_fulfilled на 1 (TRUE) для выбранного заказа
                UpdateOrderFulfillmentStatus(orderId);

                // Перезагрузить данные в dataGridView_order
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Выберите заказ для выдачи.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateOrderFulfillmentStatus(int orderId)
        {
            try
            {
                connection.Open();

                string updateQuery = "UPDATE pickup_requests SET is_fulfilled = 1 WHERE id_pickup_request = @orderId";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@orderId", orderId);

                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении статуса выполнения заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Выполнить поиск по таблице pickup_requests по полю
                SearchInTable(searchText);
            }
            else
            {
                // Если текстовое поле пустое, загрузить все данные
                LoadDataGrid();
            }
        }

        private void SearchInTable(string searchText)
        {
            try
            {
                connection.Open();

                string searchQuery = "SELECT * FROM pickup_requests WHERE customer_name LIKE @searchText AND is_fulfilled = 0";
                MySqlCommand searchCmd = new MySqlCommand(searchQuery, connection);
                searchCmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_order.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении поиска: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
