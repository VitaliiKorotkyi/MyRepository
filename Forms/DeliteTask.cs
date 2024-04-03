using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Spisok_Del_TryToDo.Forms
{
    public partial class DeliteTask : Form
    {
        private SqlConnection sqlconnection = null;
        public event EventHandler DataUpdated;
        public DeliteTask()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            label2.BackColor = Color.Transparent;
            sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyList"].ConnectionString);
            sqlconnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eventIDToDelete = Convert.ToInt32(textBox1.Text); // Предполагая, что ID события находится в textBox1
            string deleteQuery = "DELETE FROM MyList WHERE TaskID = @EventID";

            using (SqlCommand command = new SqlCommand(deleteQuery, sqlconnection))
            {
                command.Parameters.AddWithValue("@EventID", eventIDToDelete);
                command.ExecuteNonQuery();
            }

            // Вызываем событие обновления данных
            DataUpdated?.Invoke(this, EventArgs.Empty);

            // Закрываем форму удаления
            this.Close();
        }
    }
}
