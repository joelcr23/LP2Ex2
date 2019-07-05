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
    public class MySQLMoney : DAOMoney
    {
        public Money queryByIdTask(int idTask)
        {
            Money money = new Money();
            MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM MONEY M INNER JOIN RESOURCE R ON R.ID_RESOURCE = M.ID_MONEY WHERE R.ACTIVE = 1 AND R.FID_WORK_UNIT = " + idTask.ToString();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = con;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                money.Currency = reader.GetString("CURRENCY");
                money.Quantity = reader.GetFloat("QUANTITY");
            }
            con.Close();
            return money;
        }
    }
}
