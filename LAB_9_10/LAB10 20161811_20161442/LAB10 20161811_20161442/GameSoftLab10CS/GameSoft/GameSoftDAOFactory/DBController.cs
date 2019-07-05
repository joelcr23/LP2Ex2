using GameSoftDev.pject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace GameSoftController
{
    public abstract class DBController
    {
        private static readonly DAOFactory daoFactory = DAOFactory.getDAOFactory();

        public static BindingList<Project> queryAllProjects()
        {
            return daoFactory.ProjectDAO.queryAll();
        }

        public static BindingList<PhaseProject> queryAllPhaseProjectsbyIdProject(int idProject)
        {
            return daoFactory.PhaseProjectDAO.queryByProjectId(idProject);
        }

        public static BindingList<Activity> queryAllActivitiesbyIdPhaseProject(int idPhaseProject)
        {
            return daoFactory.ActivityDAO.queryAllbyIdPhaseProject(idPhaseProject);
        }

        public static BindingList<Task> queryAllTasksbyIdActivity(int idActivity)
        {
            return daoFactory.TaskDAO.queryAllbyIdActivity(idActivity);
        }

        public static Time queryTimebyIdTask(int idTask)
        {
            return daoFactory.TimeDAO.queryByIdTask(idTask);
        }

        public static Money queryMoneybyIdTask(int idTask)
        {
            return daoFactory.MoneyDAO.queryByIdTask(idTask);
        }

        public static BindingList<Participant> queryParticipantsbyIdTask(int idTask)
        {
            return daoFactory.ParticipantDAO.queryByIdTask(idTask);
        }
    }
}
