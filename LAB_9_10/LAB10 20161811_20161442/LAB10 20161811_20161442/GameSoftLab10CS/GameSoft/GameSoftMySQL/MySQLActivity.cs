using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.pject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftMySQL
{
    public class MySQLActivity : DAOActivity
    {
        public BindingList<Activity> queryAllbyIdPhaseProject(int idPhaseProject)
        {
            BindingList<Activity> activities = new BindingList<Activity>();
            MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "QUERY_ACTIVITIES_BY_ID_PHASE_PROJECT";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Connection = con;
            command.Parameters.AddWithValue("_ID_PHASE_PROJECT", idPhaseProject);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Activity activity = new Activity();
                activity.Id = reader.GetInt32("ID_WORK_UNIT");
                activity.Name = reader.GetString("NAME");
                activity.Description = reader.GetString("DESCRIPTION");
                activities.Add(activity);
            }
            con.Close();
            return activities;
        }
    }
}
