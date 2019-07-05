using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.pject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GameSoftMSSQL
{
    public class MSSQLPhase : DAOPhase
    {
        public int insert(Phase phase)
        {
            int result = 0;
            try
            {
                SqlConnection con = new SqlConnection(DBManager.DbManager.StringConn);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO PHASE(NAME, DESCRIPTION, ACTIVE) VALUES('" + phase.Name + "','" + phase.Description + "'," + Convert.ToInt32(phase.Active).ToString() + ");";
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = con;
                result = command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(ID_PHASE) FROM PHASE";
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                phase.Id = reader.GetInt32(0);
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
