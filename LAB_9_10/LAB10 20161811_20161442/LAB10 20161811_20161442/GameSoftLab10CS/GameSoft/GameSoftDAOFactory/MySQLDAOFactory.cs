using GameSoftDAO;
using GameSoftMySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSoftController
{
    public class MySQLDAOFactory : DAOFactory
    {
        public override DAOProject ProjectDAO => new MySQLProject();
        public override DAOPhaseProject PhaseProjectDAO => new MySQLPhaseProject();
        public override DAOActivity ActivityDAO => new MySQLActivity();
        public override DAOTask TaskDAO => new MySQLTask();
        public override DAOTime TimeDAO => new MySQLTime();

        public override DAOParticipant ParticipantDAO => new MySQLParticipant();
        public override DAOMoney MoneyDAO => new MySQLMoney();
    }
}
