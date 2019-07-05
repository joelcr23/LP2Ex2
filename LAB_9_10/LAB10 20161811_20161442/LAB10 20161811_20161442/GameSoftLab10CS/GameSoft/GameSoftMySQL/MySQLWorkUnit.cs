using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSoftConfig;
using GameSoftDAO;
using GameSoftDev.pject;
using MySql.Data.MySqlClient;

namespace GameSoftMySQL
{
    class MySQLWorkUnit : DAOWorkUnit
    {
        private static MySqlConnection conn = null;
        public List<WorkUnit> queryActivitiesByPhaseProjectId(int phaseProjectId)
        {            
            List<WorkUnit> activities = new List<WorkUnit>();
            MySqlDataReader myReader = null;
            try
            {
                //2. Abrimos la conexion			
                conn = new MySqlConnection(DBManager.DbManager.StringConn);

                using (MySqlCommand cmd = new MySqlCommand("QUERY_ACTIVITIES_BY_ID_PHASE_PROJECT", conn))
                {
                    // set up the parameters
                    cmd.Parameters.Add("@product_name", MySqlDbType.VarChar, 50);

                    cmd.CommandType = CommandType.StoredProcedure;

                    // set parameter values
                    cmd.Parameters["@_ID_PHASE_PROJECT"].Value = phaseProjectId;

                    conn.Open();
                    myReader = cmd.ExecuteReader();
                    //5. Procesamos los resultados
                    while (myReader.Read())
                    {
                        if (DBNull.Value.Equals(myReader["FID_ACTIVITY"]))
                        {
                            Activity p = new Activity();
                            p.Id = (Int32.Parse(myReader["id"].ToString()));
                            p.Name = (myReader["name"].ToString());
                            p.Description = (myReader["description"].ToString());
                            activities.Add(p);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                //6. CERRAMOS LOS OBJETOS DE CONEXION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                if (conn != null) try { conn.Close(); } catch (Exception e) { Console.Error.WriteLine(e.StackTrace); }
            }
            return activities;

        }

        public List<WorkUnit> queryTasksByActivityId(int activityId)
        {
            throw new NotImplementedException();
        }
    }
}
