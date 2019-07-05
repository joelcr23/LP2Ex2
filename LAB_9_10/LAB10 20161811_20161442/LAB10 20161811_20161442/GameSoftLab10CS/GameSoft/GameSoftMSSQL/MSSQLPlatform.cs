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
    public class MSSQLPlatform : DAOPlatform
    {
        public int insert(Platform platform)
        {
            int result = 0;
            try
            {
                SqlConnection con = new SqlConnection(DBManager.DbManager.StringConn);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO PLATFORM(NAME,ACTIVE) VALUES('" + platform.Name + "'," + Convert.ToInt32(platform.Active).ToString() + ");";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = con;
                result = command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(ID_PLATFORM) FROM PLATFORM;";
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                platform.Id = reader.GetInt32(0);
                System.Console.WriteLine("Se ha insertado la Plataforma " + platform.Id + ": " + platform.Name);
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
