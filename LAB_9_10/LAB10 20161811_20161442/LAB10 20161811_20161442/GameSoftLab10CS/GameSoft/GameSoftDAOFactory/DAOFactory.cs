using GameSoftConfig;
using GameSoftDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSoftController
{
    public abstract class DAOFactory
    {
        public static DAOFactory getDAOFactory()
        {
            if (DBManager.DbManager.Type.Contains("mysql"))
                return new MySQLDAOFactory();
            else
                return new MSSQLDAOFactory();
        }
        public abstract DAOProject ProjectDAO { get; }
        public abstract DAOPhaseProject PhaseProjectDAO { get; }
        public abstract DAOActivity ActivityDAO { get; }
        public abstract DAOTask TaskDAO { get; }
        public abstract DAOTime TimeDAO { get; }
        public abstract DAOMoney MoneyDAO { get; }

        public abstract DAOParticipant ParticipantDAO { get; }
    }
}
