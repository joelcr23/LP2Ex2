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
    public class MySQLParticipant : DAOParticipant
    {
        public BindingList<Participant> queryByIdTask(int idTask)
        {
            BindingList<Participant> participants = new BindingList<Participant>();
            MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM PARTICIPANT P INNER JOIN RESOURCE R ON R.ID_RESOURCE = P.ID_PARTICIPANT WHERE R.ACTIVE = 1 AND R.FID_WORK_UNIT = "+idTask.ToString();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = con;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Participant p = new Participant();
                p.FullName = reader.GetString("FULL_NAME");
                p.SignupDate = reader.GetDateTime("SIGNUP_DATE");
                participants.Add(p);
            }
            con.Close();
            return participants;
        }
    }
}
