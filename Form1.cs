using Newtonsoft.Json;
using Spisok_Del_TryToDo.Class;
using Spisok_Del_TryToDo.Forms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Spisok_Del_TryToDo
{
    public partial class Spisok : Form
    {
        private EventsPanel eventsPanel = new EventsPanel();
        private Color initialForeColor;
        private const string APIKEY = "172d1c124a3733480763b3b8fc663133";
        private SqlConnection sqlconnection = null;

        public Spisok()
        {
            InitializeComponent();
            #region load
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            LableDate date = new LableDate();
            label2.Text = date.LableDateSet();
            pictureBox1.BackColor = Color.Transparent;
            Temperature.BackColor = Color.Transparent;
            humidity.BackColor = Color.Transparent;
            description.BackColor = Color.Transparent;

            #endregion
        }

        #region Panel
        private void panel12_MouseEnter(object sender, EventArgs e)
        {

            eventsPanel.CommonMouseEnter(sender, e);
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(sender, e);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            initialForeColor = label4.ForeColor;
            eventsPanel.CommonMouseEnter(panel12, e);
            label4.ForeColor = Color.Black;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {

            eventsPanel.CommonMouseLeave(panel12, e);
            label4.ForeColor = initialForeColor; // Возвращаем начальный цвет текста
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel12, e);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel12, e);
        }

        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel13, e);
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel13, e);
        }




        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel14, e);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            initialForeColor = label5.ForeColor;
            eventsPanel.CommonMouseEnter(panel13, e);
            label5.ForeColor = Color.Black;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel13, e);
            label5.ForeColor = initialForeColor;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel13, e);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel13, e);
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel14, e);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            initialForeColor = label6.ForeColor;
            eventsPanel.CommonMouseEnter(panel14, e);
            label6.ForeColor = Color.Black;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel14, e);
            label6.ForeColor = initialForeColor;
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel14, e);
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel14, e);
        }

        private void panel15_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel15, e);
        }
        private void panel15_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel15, e);
        }
        private void label7_MouseEnter(object sender, EventArgs e)
        {
            initialForeColor = label7.ForeColor;
            eventsPanel.CommonMouseEnter(panel15, e);
            label7.ForeColor = Color.Black;
        }
        private void label7_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel15, e);
            label7.ForeColor = initialForeColor;
        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel15, e);
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel15, e);
        }
        private void panel16_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel16, e);
        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel16, e);
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            initialForeColor = label8.ForeColor;
            eventsPanel.CommonMouseEnter(panel16, e);
            label8.ForeColor = Color.Black;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel16, e);
            label8.ForeColor = initialForeColor;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel16, e);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel16, e);
        }

        private void panel17_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel17, e);
        }

        private void panel17_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel17, e);
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            initialForeColor = label9.ForeColor;
            eventsPanel.CommonMouseEnter(panel17, e);
            label9.ForeColor = Color.Black;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel17, e);
            label9.ForeColor = initialForeColor;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel17, e);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel17, e);
        }

        private void panel18_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel18, e);
        }

        private void panel18_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel18, e);
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            initialForeColor = label10.ForeColor;
            eventsPanel.CommonMouseEnter(panel18, e);
            label10.ForeColor = Color.Black;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel18, e);
            label10.ForeColor = initialForeColor;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel18, e);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel18, e);
        }

        private void panel19_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel19, e);
        }

        private void panel19_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel19, e);
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            initialForeColor = label11.ForeColor;
            eventsPanel.CommonMouseEnter(panel19, e);
            label11.ForeColor = Color.Black;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel19, e);
            label11.ForeColor = initialForeColor;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseEnter(panel19, e);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            eventsPanel.CommonMouseLeave(panel19, e);
        }

        #endregion
        #region pogoda
        private async void Spisok_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 136;
            await LoadWeatherDataAsync(comboBox1.Text);

            sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyList"].ConnectionString);
            sqlconnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM MyList", sqlconnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 40;
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[5].Width = 55;


        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBox1.SelectedItem.ToString();
            await LoadWeatherDataAsync(selectedCity);
        }
        private void DisplayWeatherData(WeatherData weatherData)
        {
            Temperature.Text = $"Температура: {weatherData.Main.Temp}°C";
            humidity.Text = $"Влажность: {weatherData.Main.Humidity}%";
            description.Text = $"Описание: {weatherData.Weather[0].Description}";
        }
        private async Task LoadWeatherDataAsync(string city)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(city))
                {
                    MessageBox.Show("Please select a city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var httpClient = new HttpClient())
                {
                    string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={APIKEY}&units=metric";
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);
                    DisplayWeatherData(weatherData);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
        #region AddNewTask
        private void label11_Click(object sender, EventArgs e)
        {
            AddNewTask addNewTaskForm = new AddNewTask();
            addNewTaskForm.Show();
        }
        #endregion

        #region Task
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DeliteTask deltsk=new DeliteTask(); 
            deltsk.Show();  
        }
        
        #endregion
        #region SqlSort
        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM MyList", sqlconnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM MyList WHERE Priority=3", sqlconnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                int priority;
                if (int.TryParse(e.Value.ToString(), out priority))
                {
                    if (priority == 3)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White; // Устанавливаем белый цвет текста для лучшей видимости
                    }
                    else if (priority == 2)
                    {
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
            // Проверяем, что текущая ячейка принадлежит столбцу с датой
            if (e.ColumnIndex == 4 && e.Value != null && e.Value is DateTime)
            {
                // Получаем значение ячейки (должно быть DateTime)
                DateTime dueDate = (DateTime)e.Value;

                // Сравниваем с текущей датой
                if (dueDate < DateTime.Today)
                {
                    // Если прошла дата, устанавливаем красный цвет фона ячейки
                    e.CellStyle.BackColor = Color.Red;

                }
                else
                {
                    // В противном случае, устанавливаем цвет фона по умолчанию
                    e.CellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM MyList WHERE Category ='Planned'", sqlconnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM MyList WHERE Category ='Tasks' ", sqlconnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM MyList WHERE Category ='Helth'", sqlconnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM MyList WHERE Category ='Travel'", sqlconnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM MyList WHERE Category ='Shopping'", sqlconnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }



}
