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
    public class MSSQLContentClassificationSystem : DAOContentClassificationSystem
    {
        public int insert(ContentClassificationSystem ccs)
        {
            int result = 0;
            try
            {
                SqlConnection con = new SqlConnection(DBManager.DbManager.StringConn);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO CONTENT_CLASS_SYSTEM(ACRONYM, DESCRIPTION,ACTIVE) VALUES('" + ccs.Acronym + "','" + ccs.Description + "',"+ Convert.ToInt32(ccs.Active).ToString()+");";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = con;
                result = command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(ID_CONTENT_CLASS_SYSTEM) FROM CONTENT_CLASS_SYSTEM;";
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                ccs.Id = reader.GetInt32(0);
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
