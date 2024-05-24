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
    public partial class Form5_viewStore : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo";

        public Form5_viewStore()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void Form5_viewStore_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            try
            {
                connection.Open();

                // Выбрать данные из таблицы products
                string productsQuery = "SELECT id_products, type_products AS Type_Name, name_products AS Type_Name, in_stock_products AS In_Stock, null AS Last_Stock_Update, price_products AS Price, 'STORE' AS Location FROM products";

                // Выбрать данные из таблицы storage
                string storageQuery = "SELECT id_product AS id_products, product_name AS Type_Name, product_name AS Type_Name, quantity_in_stock AS In_Stock, last_stock_update AS Last_Stock_Update, price_per_unit AS Price, 'WAREHOUSE' AS Location FROM storage";

                string unionQuery = $"({productsQuery}) UNION ({storageQuery})";

                MySqlCommand cmd = new MySqlCommand(unionQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_viewStore.DataSource = dataTable;
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
                // Выполнить поиск по таблицам products и storage по нескольким полям
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

                // Выполнить поиск по таблицам products и storage по нескольким полям
                string searchQuery = $"SELECT * FROM ((SELECT id_products, type_products AS Type_Name, name_products AS Type_Name, in_stock_products AS In_Stock, null AS Last_Stock_Update, price_products AS Price, 'STORE' AS Location FROM products) " +
                    $"UNION (SELECT id_product AS id_products, product_name AS Type_Name, product_name AS Type_Name, quantity_in_stock AS In_Stock, last_stock_update AS Last_Stock_Update, price_per_unit AS Price, 'WAREHOUSE' AS Location FROM storage)) AS UnionTable " +
                    $"WHERE Type_Name LIKE @searchText OR In_Stock LIKE @searchText OR Last_Stock_Update LIKE @searchText OR Price LIKE @searchText OR Location LIKE @searchText";

                MySqlCommand searchCmd = new MySqlCommand(searchQuery, connection);
                searchCmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_viewStore.DataSource = dataTable;
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
