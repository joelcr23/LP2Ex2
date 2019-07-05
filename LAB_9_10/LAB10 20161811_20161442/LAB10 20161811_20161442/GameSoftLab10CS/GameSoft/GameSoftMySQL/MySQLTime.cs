using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.pject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftMySQL
{
    public class MySQLTime : DAOTime
    {
        public Time queryByIdTask(int idTask)
        {
            Time time = new Time();
            MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM TIME T INNER JOIN RESOURCE R ON R.ID_RESOURCE = T.ID_TIME WHERE R.ACTIVE = 1 AND R.FID_WORK_UNIT = "+idTask.ToString();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = con;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                time.MeasureUnit = reader.GetString("UNIT_MEASURE");
                time.Quantity = reader.GetFloat("QUANTITY");
            }
            con.Close();
            return time;
        }
    }
}
