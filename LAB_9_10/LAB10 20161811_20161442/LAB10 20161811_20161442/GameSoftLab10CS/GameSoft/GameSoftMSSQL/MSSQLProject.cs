using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.pject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftMSSQL
{
    public class MSSQLProject : DAOProject
    {
        public int Add(Project project)
        {
            throw new NotImplementedException();
        }

        public BindingList<Project> queryAll()
        {
            BindingList<Project> projects = new BindingList<Project>();
            SqlConnection con = new SqlConnection(DBManager.DbManager.StringConn);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT A.ID_PROJECT, B.NAME AS GAME_NAME, C.NAME AS GENRE_NAME, D.NAME AS GAME_MODE_NAME, E.ACRONYM AS CCS_ACRONYM, F.NAME AS PLATFORM_NAME FROM PROJECT A INNER JOIN GAME B ON A.ID_PROJECT = B.FID_PROJECT INNER JOIN GENRE C ON C.ID_GENRE = B.FID_GENRE INNER JOIN GAME_MODE D ON D.ID_GAME_MODE = B.FID_GAME_MODE INNER JOIN CONTENT_CLASS_SYSTEM E ON E.ID_CONTENT_CLASS_SYSTEM = B.FID_CONTENT_CLASS_SYSTEM INNER JOIN PLATFORM F ON F.ID_PLATFORM = B.FID_PLATFORM;";
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = con;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Project p = new Project();
                p.Id = reader.GetInt32(0);
                p.Game.Name = reader.GetString(1);
                p.Game.GameMode.Name = reader.GetString(2);
                p.Game.Genre.Name = reader.GetString(3);
                p.Game.CCS.Acronym = reader.GetString(4);
                p.Game.Platform.Name = reader.GetString(5);
                projects.Add(p);
            }
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
