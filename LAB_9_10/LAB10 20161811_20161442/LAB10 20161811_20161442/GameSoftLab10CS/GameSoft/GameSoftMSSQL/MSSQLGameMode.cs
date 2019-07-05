using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.opt;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftMSSQL
{
    public class MSSQLGameMode : DAOGameMode
    {
        public int insert(GameMode gameMode)
        {
            int result = 0;
            try
            {
                SqlConnection con = new SqlConnection(DBManager.DbManager.StringConn);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO GAME_MODE(NAME,ACTIVE) VALUES('" + gameMode.Name + "', "+ Convert.ToInt32(gameMode.Active).ToString()+");";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = con;
                result = command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(ID_GAME_MODE) FROM GAME_MODE;";
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                gameMode.Id = reader.GetInt32(0);
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
