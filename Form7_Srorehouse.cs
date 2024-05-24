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
    public partial class Form7_Storehouse : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo");
        private DataTable originalDataTable; // Для хранения исходных данных
        private bool changesMade; // Флаг, указывающий на наличие изменений

        public Form7_Storehouse()
        {
            InitializeComponent();
        }

        private void Form7_Storehouse_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo");
                connection.Open();

                string query = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                originalDataTable = new DataTable(); // Сохраняем исходные данные
                adapter.Fill(originalDataTable);

                // Добавляем столбец для отслеживания изменений
                originalDataTable.Columns.Add("IsChanged", typeof(bool));

                dataGridView_storehouse.DataSource = originalDataTable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Выполнить поиск по таблице products
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
                DataView dataView = originalDataTable.DefaultView;
                dataView.RowFilter = $"name_products LIKE '%{searchText}%' OR type_products LIKE '%{searchText}%' OR id_products LIKE '%{searchText}%'";
                dataGridView_storehouse.DataSource = dataView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении поиска: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView_storehouse_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Пометить ячейку как измененную
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                originalDataTable.Rows[e.RowIndex]["IsChanged"] = true;
                changesMade = true;
            }
        }

        /*private void dataGridView_storehouse_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Пометить ячейку как измененную
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                originalDataTable.Rows[e.RowIndex]["IsChanged"] = true;
                changesMade = true;
            }
        }
         */

        private void button_saveChanges_Click(object sender, EventArgs e)
        {
            if (changesMade)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveChanges();
                    LoadDataGrid(); // Обновляем таблицу после сохранения изменений
                }
            }
            else
            {
                MessageBox.Show("Нет внесенных изменений для сохранения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveChanges()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=127.0.0.1; port=3306; username=root; password=; database=qualexam_bingobongo");
                connection.Open();

                MySqlCommand updateCmd = new MySqlCommand("UPDATE products SET name_products = @productName, type_products = @typeProducts, " +
                                                         "in_stock_products = @inStockProducts, price_products = @priceProducts " +
                                                         "WHERE id_products = @idProducts", connection);

                updateCmd.Parameters.Add("@productName", MySqlDbType.VarChar, 255, "name_products");
                updateCmd.Parameters.Add("@typeProducts", MySqlDbType.VarChar, 255, "type_products");
                updateCmd.Parameters.Add("@inStockProducts", MySqlDbType.Int32, 0, "in_stock_products");
                updateCmd.Parameters.Add("@priceProducts", MySqlDbType.Decimal, 0, "price_products");
                updateCmd.Parameters.Add("@idProducts", MySqlDbType.Int32, 0, "id_products");

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.UpdateCommand = updateCmd;
                adapter.Update(originalDataTable);

                MessageBox.Show("Изменения успешно сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                changesMade = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_deleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView_storehouse.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранные записи?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteSelectedRows();
                    LoadDataGrid(); // Обновляем таблицу после удаления записей
                }
            }
            else
            {
                MessageBox.Show("Выберите записи для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteSelectedRows()
        {
            try
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView_storehouse.SelectedRows)
                {
                    int idProduct = Convert.ToInt32(row.Cells["id_products"].Value);

                    MySqlCommand deleteCmd = new MySqlCommand("DELETE FROM products WHERE id_products = @idProduct", connection);
                    deleteCmd.Parameters.AddWithValue("@idProduct", idProduct);

                    deleteCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Выбранные записи успешно удалены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении записей: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button_createPosition_Click(object sender, EventArgs e)
        {
            using (Form8_createProduct createProductForm = new Form8_createProduct())
            {
                DialogResult result = createProductForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Обработка данных, полученных из Form8_createProduct после закрытия диалогового окна
                    // Например, можно обновить таблицу с продуктами после добавления нового продукта.
                    LoadDataGrid();
                }
            }
        }
    }
}
