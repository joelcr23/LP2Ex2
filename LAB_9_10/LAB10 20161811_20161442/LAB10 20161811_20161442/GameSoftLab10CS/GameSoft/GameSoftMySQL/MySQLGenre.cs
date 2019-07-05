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
    public class MySQLGenre : DAOGenre
    {
        public int insert(Genre genre)
        {
            int result = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
                con.Open();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO GENRE(NAME, ACTIVE) VALUES('"+genre.Name+"',"+genre.Active+");";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = con;
                result = command.ExecuteNonQuery();
                command.CommandText = "SELECT last_insert_id() as ID";
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                genre.Id = reader.GetInt32("ID");
                System.Console.WriteLine("Se ha insertado el Genero "+genre.Id+": "+genre.Name);
                con.Close();
            }catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
