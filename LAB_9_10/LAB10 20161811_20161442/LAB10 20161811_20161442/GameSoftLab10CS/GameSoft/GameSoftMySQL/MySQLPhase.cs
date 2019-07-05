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
    public class MySQLPhase : DAOPhase
    {
        public int insert(Phase phase)
        {
            int result = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
                con.Open();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO PHASE(NAME, DESCRIPTION, ACTIVE) VALUES('" + phase.Name + "','" + phase.Description + "'," + phase.Active + ");";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = con;
                result = command.ExecuteNonQuery();
                command.CommandText = "SELECT last_insert_id() as ID";
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                phase.Id = reader.GetInt32("ID");
                System.Console.WriteLine("Se ha insertado la fase " + phase.Id + ": " + phase.Name);
                con.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return result;
        }

        public List<Phase> queryAll()
        {
            throw new NotImplementedException();
        }
    }
}
