using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.pject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftMySQL
{
    public class MySQLProject : DAOProject
    {
        public int Add(Project project)
        {
            throw new NotImplementedException();
        }

        public BindingList<Project> queryAll()
        {
            BindingList<Project> projects = new BindingList<Project>();
            MySqlConnection con = new MySqlConnection(DBManager.DbManager.StringConn);
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "QUERY_ALL_PROJECTS";
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = con;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Project p = new Project();
                p.Id = reader.GetInt32("ID_PROJECT");
                p.Name = reader.GetString("NAME");
                p.Description = reader.GetString("DESCRIPTION");
                p.PlannedStartDate = reader.GetDateTime("PLANNED_START_DATE");
                p.PlannedEndDate = reader.GetDateTime("PLANNED_END_DATE");
                if(reader["ACTUAL_START_DATE"] != DBNull.Value)
                    p.ActualStartDate = reader.GetDateTime("ACTUAL_START_DATE");
                if (reader["ACTUAL_END_DATE"] != DBNull.Value)
                    p.ActualEndDate = reader.GetDateTime("ACTUAL_END_DATE");
                p.TotalBudget = reader.GetDouble("TOTAL_BUDGET");
                p.Active = reader.GetBoolean("ACTIVE");
                projects.Add(p);
            }
            con.Close();
            return projects;
        }

        public Project QueryProjectById(int projectId)
        {
            throw new NotImplementedException();
        }

        public void Update(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
