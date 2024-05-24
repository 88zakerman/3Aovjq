using MySql.Data.MySqlClient;

namespace QualExam_Bingo_Bongo
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server = 127.0.0.1; port = 3306; username = root; password =; database = qualexam_bingobongo";


        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;

            if (AuthenticateUser(login, password, out string accessLevel))
            {
                // Авторизация прошла успешно
                OpenFormByAccessLevel(accessLevel);
            }
            else
            {
                // Ошибка авторизации
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string login, string password, out string accessLevel)
        {
            accessLevel = "";

            try
            {
                connection.Open();

                string query = "SELECT access_employee FROM employee_accounts WHERE login_employee = @login AND password_employee = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    accessLevel = result.ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        private void OpenFormByAccessLevel(string accessLevel)
        {
            switch (accessLevel)
            {
                case "lvl_M":
                    // Открыть форму для Менеджера
                    Form2_lvl_M formManager = new Form2_lvl_M();
                    formManager.Show();
                    break;

                case "lvl_SM":
                    // Открыть форму для Старшего Менеджера
                    Form2_1_lvlSM formSeniorManager = new Form2_1_lvlSM();
                    formSeniorManager.Show();
                    break;

                default:
                    MessageBox.Show("Неизвестный уровень доступа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
