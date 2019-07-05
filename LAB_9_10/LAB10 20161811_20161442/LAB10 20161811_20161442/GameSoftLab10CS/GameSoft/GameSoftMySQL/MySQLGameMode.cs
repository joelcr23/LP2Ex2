using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.opt;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftMySQL
{
    public class MySQLGameMode : DAOGameMode
    {
        public int insert(GameMode gameMode)
        {
            int result = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
                con.Open();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO GAME_MODE(NAME,ACTIVE) VALUES('" + gameMode.Name + "'," + gameMode.Active + ");";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = con;
                result = command.ExecuteNonQuery();
                command.CommandText = "SELECT last_insert_id() as ID";
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                gameMode.Id = reader.GetInt32("ID");
                System.Console.WriteLine("Se ha insertado el Modo de Juego " + gameMode.Id + ": " + gameMode.Name);
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
