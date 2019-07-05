using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.opt;
using MySql.Data.MySqlClient;
using System;

namespace GameSoftMySQL
{
    public class MySQLContentClassificationSystem : DAOContentClassificationSystem
    {
        public int insert(ContentClassificationSystem ccs)
        {
            int result = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
                con.Open();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO CONTENT_CLASS_SYSTEM(ACRONYM, DESCRIPTION, ACTIVE) VALUES('" + ccs.Acronym + "','" + ccs.Description + "',1);";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = con;
                result = command.ExecuteNonQuery();
                command.CommandText = "SELECT last_insert_id() as ID";
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                ccs.Id = reader.GetInt32("ID");
                System.Console.WriteLine("Se ha insertado el tipo de clasificacion " + ccs.Id + ": " + ccs.Acronym);
                con.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
