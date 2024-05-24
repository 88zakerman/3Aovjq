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
    public partial class Form4_Sell : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo";

        public Form4_Sell()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void Form4_Sell_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_sell.DataSource = dataTable;
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

        private void button_Sell_Click(object sender, EventArgs e)
        {
            if (dataGridView_sell.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView_sell.SelectedCells[0].RowIndex;
                int productId = Convert.ToInt32(dataGridView_sell.Rows[selectedRowIndex].Cells["id_products"].Value);

                // Уменьшить значение in_stock_products на 1 для выбранного продукта
                SellProduct(productId);

                // Перезагрузить данные в dataGridView_order
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Выберите продукт для продажи.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SellProduct(int productId)
        {
            try
            {
                connection.Open();

                string updateQuery = "UPDATE products SET in_stock_products = in_stock_products - 1 WHERE id_products = @productId";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@productId", productId);

                updateCmd.ExecuteNonQuery();

                // Удалить запись, если in_stock_products стало равно 0
                string deleteQuery = "DELETE FROM products WHERE id_products = @productId AND in_stock_products = 0";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@productId", productId);

                deleteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при продаже продукта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Выполнить поиск по таблице products по полю, например, по product_name
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

                string searchQuery = "SELECT * FROM products WHERE name_products LIKE @searchText";
                MySqlCommand searchCmd = new MySqlCommand(searchQuery, connection);
                searchCmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_sell.DataSource = dataTable;
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
