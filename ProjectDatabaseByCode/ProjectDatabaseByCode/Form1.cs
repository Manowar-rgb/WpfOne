using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabaseByCode
{
    public partial class Form1 : Form
    {
        private DatabaseManager _dbManager;
        private string connectionString 
            = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=StudentsDb;Integrated Security=True";

        private DataView studentsView;

        public Form1()
        {
            InitializeComponent();
            _dbManager = new DatabaseManager(connectionString);

            dataGridView1.SelectionMode = 
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var selectedRow = dataGridView1.SelectedRows[0];

            // идишник группы, выбранный в данный момент!
            string id = selectedRow
                .Cells["AcademicGroupId"]
                .Value
                .ToString();

            if (studentsView == null || string.IsNullOrEmpty(id))
                return;

            // применим фильрацию данных - синтаксис SQL
            studentsView.RowFilter = $"AcademicGroupId = {id}";
        }

        private void btnLoadGroups_Click(object sender, EventArgs e)
        {
            _dbManager.LoadTable(EnumTable.AcademicGroup);
            dataGridView1.DataSource = _dbManager.ViewTable(EnumTable.AcademicGroup);

            dataGridView1
                .Columns["AcademicGroupId"]
                .Visible = false;
            dataGridView1
                .Columns["Name"]
                .HeaderText = "Название группы";
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            _dbManager.LoadTable(EnumTable.Student);
            studentsView = _dbManager.ViewTable(EnumTable.Student);
            dataGridView2.DataSource = studentsView;

            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2
                .Columns["StudentId"]
                .Visible = false;

            dataGridView2
                .Columns["AcademicGroupId"]
                .HeaderText = "Ид группы";
            dataGridView2
                .Columns["Firstname"]
                .HeaderText = "Имя";
            dataGridView2
                .Columns["Lastname"]
                .HeaderText = "Фамилия";
            dataGridView2
                .Columns["Middlename"]
                .HeaderText = "Отчество";
        }

        // фильтрация студентов по ФИО
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (studentsView == null) return;
            string textFilter = textBox1.Text;

            studentsView.RowFilter = 
                $"Firstname like '%{textFilter}%' or " +
                $"Lastname like '%{textFilter}%'";
        }

        private void btnEditGroups_Click(object sender, EventArgs e)
        {
            var window = new FormEditGroups(_dbManager);
            window.ShowDialog();
        }
    }
}
