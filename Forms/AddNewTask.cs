using Spisok_Del_TryToDo.Class;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spisok_Del_TryToDo.Forms
{
    public partial class AddNewTask : Form
    {

        private SqlConnection sqlconnection = null;
        public AddNewTask()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            label1.BackColor = Color.Transparent;
        }
        private async void Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем команду для выполнения INSERT запроса
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [MyList](TaskName,Description,Priority,DueDate,Category) VALUES (@TaskName,@Description,@Priority,@DueDate,@Category)", sqlconnection))
                {
                    // Устанавливаем параметры для команды
                    cmd.Parameters.AddWithValue("@TaskName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Description", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Priority", numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@DueDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());

                    // Открываем соединение, если оно еще не открыто
                    if (sqlconnection.State != System.Data.ConnectionState.Open)
                    {
                        await sqlconnection.OpenAsync();
                    }
                    // Выполняем команду
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();

                    // Проверяем количество затронутых строк
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Задача успешно добавлена!"); 
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при добавлении задачи: ни одна строка не была изменена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при добавлении задачи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Закрываем соединение после завершения операции
                if (sqlconnection.State == System.Data.ConnectionState.Open)
                {
                    sqlconnection.Close();
                }
            }
            this.Close();
        }

        private void AddNewTask_Load(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyList"].ConnectionString);
            
        }
    }
}
