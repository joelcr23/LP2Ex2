using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.pject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GameSoftMySQL
{
    public class MySQLTask : DAOTask
    {
        public BindingList<Task> queryAllbyIdActivity(int idActivity)
        {
            BindingList<Task> tasks = new BindingList<Task>();
            MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "QUERY_TASKS_BY_ID_ACTIVITY";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = con;
            command.Parameters.AddWithValue("_ID_ACTIVITY", idActivity);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Task task = new Task();
                task.Id = reader.GetInt32("ID_WORK_UNIT");
                task.Name = reader.GetString("NAME");
                tasks.Add(task);
            }
            con.Close();
            return tasks;
        }
    }
}
