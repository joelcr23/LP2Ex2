using GameSoftDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSoftMSSQL;

namespace GameSoftController
{
    public class MSSQLDAOFactory : DAOFactory
    {
        public override DAOProject ProjectDAO => new MSSQLProject();
        public override DAOPhaseProject PhaseProjectDAO => new MSSQLPhaseProject();
        public override DAOActivity ActivityDAO => throw new NotImplementedException();
        public override DAOTask TaskDAO => throw new NotImplementedException();
        public override DAOTime TimeDAO => throw new NotImplementedException();

        public override DAOMoney MoneyDAO => throw new NotImplementedException();

        public override DAOParticipant ParticipantDAO => throw new NotImplementedException();
    }
}
