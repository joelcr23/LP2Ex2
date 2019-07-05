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
    public class MSSQLGenre : DAOGenre
    {
        public int insert(Genre genre)
        {
            int result = 0;
            try
            {
                SqlConnection con = new SqlConnection(DBManager.DbManager.StringConn);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO GENRE(NAME, ACTIVE) VALUES('" + genre.Name + "'," + Convert.ToInt32(genre.Active).ToString() + ");";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = con;
                result = command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(ID_GENRE) FROM GENRE";
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                genre.Id = reader.GetInt32(0);
                System.Console.WriteLine("Se ha insertado el Genero " + genre.Id + ": " + genre.Name);
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
