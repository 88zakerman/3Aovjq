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
    public partial class Form6_orderList : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo";

        public Form6_orderList()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void Form6_orderList_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            try
            {
                connection.Open();

                string query = "SELECT id_pickup_request, customer_name, contact_email, requested_product, request_quantity, request_date, is_fulfilled, order_number FROM pickup_requests";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_orderList.DataSource = dataTable;
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

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Выполнить поиск по таблице pickup_requests по нескольким полям
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

                string searchQuery = "SELECT id_pickup_request, customer_name, contact_email, requested_product, request_quantity, request_date, is_fulfilled, order_number FROM pickup_requests " +
                                    $"WHERE customer_name LIKE @searchText OR requested_product LIKE @searchText OR order_number LIKE @searchText";
                MySqlCommand searchCmd = new MySqlCommand(searchQuery, connection);
                searchCmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_orderList.DataSource = dataTable;
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

        private void button_createOrder_Click(object sender, EventArgs e)
        {
            // Открыть форму создания заказа
            Form6_createOrder createOrderForm = new Form6_createOrder();
            DialogResult result = createOrderForm.ShowDialog();

            // Если результат - OK, перезагрузить данные
            if (result == DialogResult.OK)
            {
                LoadDataGrid();
            }
        }

        private void button_editOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView_orderList.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView_orderList.SelectedCells[0].RowIndex;
                int pickupRequestId = Convert.ToInt32(dataGridView_orderList.Rows[selectedRowIndex].Cells["id_pickup_request"].Value);

                // Открыть форму редактирования заказа
                Form6_editOrder editOrderForm = new Form6_editOrder();
                editOrderForm.PickupRequestId = pickupRequestId; // Установить идентификатор заказа
                DialogResult result = editOrderForm.ShowDialog();

                // Если результат - OK, перезагрузить данные
                if (result == DialogResult.OK)
                {
                    LoadDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_deleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView_orderList.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView_orderList.SelectedCells[0].RowIndex;
                int pickupRequestId = Convert.ToInt32(dataGridView_orderList.Rows[selectedRowIndex].Cells["id_pickup_request"].Value);

                // Удалить запись из таблицы pickup_requests
                DeleteOrder(pickupRequestId);

                // Перезагрузить данные в dataGridView_orderList
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Выберите заказ для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteOrder(int pickupRequestId)
        {
            try
            {
                connection.Open();

                string deleteQuery = "DELETE FROM pickup_requests WHERE id_pickup_request = @pickupRequestId";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@pickupRequestId", pickupRequestId);

                deleteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
