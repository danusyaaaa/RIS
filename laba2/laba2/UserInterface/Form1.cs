using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=localhost;Initial Catalog=laba2;Integrated Security=True";
        string sql = "SELECT * FROM Groups";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["Number"].ReadOnly = true;
                dataGridView1.Columns["FIOStarosta"].ReadOnly = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Сохранить
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(ds);
                dataGridView1.Columns["Number"].ReadOnly = true;
                dataGridView1.Columns["FIOStarosta"].ReadOnly = true;
            }
        }

        //Добавить
        private void button4_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
            dataGridView1.Columns["Number"].ReadOnly = false;
            dataGridView1.Columns["FIOStarosta"].ReadOnly = false;
        }

        //Удалить
        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }

                adapter.Update(ds);
            }
        }

        //Загрузить экзамены группы
        private void button8_Click(object sender, EventArgs e)
        {
            using (laba2Entities examsContext = new laba2Entities())
            {
                var exams = examsContext.GroupsExams.ToList().Where(c => c.GroupsNumber == dataGridView1.SelectedRows[0].AccessibilityObject.Value.Split(';')[0].Trim());
                //ДОБАВИТЬ ВЫБОРКУ ПО НАЗВАНИЮ ГРУППЫ
                if (exams.Count() != 0)
                {
                    dataGridView2.DataSource = exams;
                    dataGridView2.Columns["Exams"].Visible = false;
                    dataGridView2.Columns["GroupsNumber"].ReadOnly = true;
                    dataGridView2.Columns["ExamsName"].ReadOnly = true;
                }
            }
        }

        //Загрузить все экзаменыы
        private void button12_Click(object sender, EventArgs e)
        {
            using (laba2Entities examsContext = new laba2Entities())
            {
                var exams = examsContext.Exams.ToList();

                dataGridView3.DataSource = exams;
            }
        }

        //Добавить экзамен
        private void button9_Click(object sender, EventArgs e)
        {
            using (laba2Entities examsContext = new laba2Entities())
            {
                var exams = examsContext.Exams.ToList();

                exams.Add(new Exams());

                dataGridView3.DataSource = exams;
            }
        }

        //Удаление экзамена
        private void button10_Click(object sender, EventArgs e)
        {
            var deletedExam = new Exams
            {
                Name = dataGridView3.SelectedRows[0].AccessibilityObject.Value.Split(';')[0].Trim(),
                FIOTeacher = dataGridView3.SelectedRows[0].AccessibilityObject.Value.Split(';')[1].Trim(),
                Date = DateTime.Parse(dataGridView3.SelectedRows[0].AccessibilityObject.Value.Split(';')[2].Trim()),
                Time = dataGridView3.SelectedRows[0].AccessibilityObject.Value.Split(';')[3].Trim()
            };

            using (laba2Entities examsContext = new laba2Entities())
            {
                var exams = examsContext.Exams.ToList();
                exams.Remove(exams.FirstOrDefault(c => c.Name == deletedExam.Name));

                dataGridView3.DataSource = exams;

                examsContext.SaveChanges();
            }
        }

        //Сохранить изменения
        private void button11_Click(object sender, EventArgs e)
        {
            using (laba2Entities examsContext = new laba2Entities())
            {
                var examsGrid = dataGridView3.DataSource;

                foreach (var item in (List<Exams>)examsGrid)
                {
                    examsContext.Exams.AddOrUpdate(item);
                }

                examsContext.SaveChanges();
            }
        }
    }
}
