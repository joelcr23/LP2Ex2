using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.pject;
using MySql.Data.MySqlClient;

namespace GameSoftMySQL
{
    public class MySQLPhaseProject : DAOPhaseProject
    {
        public int insert(PhaseProject phaseProject)
        {
            throw new NotImplementedException();
        }

        public BindingList<PhaseProject> queryByProjectId(int projectId)
        {
            BindingList<PhaseProject> phaseprojects = new BindingList<PhaseProject>();
            MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "QUERY_PHASE_PROJECTS_BY_ID_PROJECT";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_ID_PROJECT",projectId);
            command.Connection = con;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhaseProject pp = new PhaseProject();
                pp.Id = reader.GetInt32("ID_PHASE_PROJECT");
                pp.Phase.Name = reader.GetString("NAME");
                phaseprojects.Add(pp);
            }
            con.Close();
            return phaseprojects;
        }
    }
}
