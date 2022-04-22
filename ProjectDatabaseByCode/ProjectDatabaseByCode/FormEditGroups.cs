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
    public partial class FormEditGroups : Form
    {
        private DatabaseManager _dbManager;
        private string id;

        public FormEditGroups(DatabaseManager dbManager)
        {
            InitializeComponent();
            _dbManager = dbManager;

            dataGridView1.DataSource = 
                _dbManager
                .ViewTable(EnumTable.AcademicGroup);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var selectedRow = dataGridView1.SelectedRows[0];

            // идишник группы, выбранный в данный момент!
            id = selectedRow
                .Cells["AcademicGroupId"]
                .Value
                .ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Выберите сначала группу для удаления");
                return;
            }

            _dbManager.RemoveAcademicGroup(id);
            id = string.Empty;
        }
    }
}
