using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------
using System.Data; // ADO.NET
using System.Data.SqlClient; // оптимиз для MS SQL Server
using System.Windows.Forms;

namespace ProjectDatabaseByCode
{
    public class DatabaseManager
    {
        /// <summary>
        /// соединение с сервером
        /// </summary>
        protected SqlConnection _sqlConnection;

        /// <summary>
        /// посредник для загрузки и отправки данные
        /// </summary>
        protected SqlDataAdapter _sqlDataAdapter;

        /// <summary>
        /// локальный кэш
        /// </summary>
        protected DataSet _dataSet;

        public DatabaseManager(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
            _sqlDataAdapter = new SqlDataAdapter();
            _dataSet = new DataSet();
        }

        public void LoadTable(EnumTable enumTable)
        {
            string tableName = enumTable.ToString();

            _dataSet.Tables[tableName]?.Clear();
            try
            {
                // 1) открываем соедниение с сервером
                _sqlConnection.Open();
                // 2) формируем запрос к серверу
                string sqlText = $"select *from {tableName}";
                var sqlCommand = new SqlCommand(sqlText, _sqlConnection);
                _sqlDataAdapter.SelectCommand = sqlCommand;
                // 3) отправляем запрос и сохраняем данные в локальный кэш
                _sqlDataAdapter.Fill(_dataSet, tableName);
                // 4) закрываем канал связи
                _sqlConnection.Close();
            }
            catch(Exception e)
            {
                // логгировать!
                // сообщить юзеру
                MessageBox.Show(e.ToString());
            }
        }

        public void RemoveAcademicGroup(string id)
        {
            var table = _dataSet
                .Tables[EnumTable.AcademicGroup.ToString()];

            var row = table
                .AsEnumerable()
                .FirstOrDefault(x => x["AcademicGroupId"].ToString() == id);

            row?.Delete();
        }

        // DataView - упрощённая DataTable
        public DataView ViewTable(EnumTable enumTable)
        {
            string tableName = enumTable.ToString();

            // из хранилища берём таблицу
            // и преобразуем для Просмотра
            return _dataSet
                .Tables[tableName]
                .AsDataView();
        }
    }

}
