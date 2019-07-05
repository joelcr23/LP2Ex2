using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.pject
{
    public class PhaseProject
    {
        private int _id;
        private Phase _phase;
        private DateTime _plannedStartDate;
        private DateTime _actualStartDate;
        private DateTime _plannedEndDate;
        private DateTime _actualEndDate;
        private bool _active;

        public PhaseProject()
        {
            _phase = new Phase();
        }
        public PhaseProject(Phase phase, DateTime plannedStartDate, DateTime plannedEndDate)
        {
            _phase = phase;
            _plannedStartDate = plannedStartDate;
            _plannedEndDate = plannedEndDate;
            _active = true;
        }

        public DateTime PlannedStartDate { get => _plannedStartDate; set => _plannedStartDate = value; }
        public DateTime ActualStartDate { get => _actualStartDate; set => _actualStartDate = value; }
        public DateTime PlannedEndDate { get => _plannedEndDate; set => _plannedEndDate = value; }
        public DateTime ActualEndDate { get => _actualEndDate; set => _actualEndDate = value; }
        public Phase Phase { get => _phase; set => _phase = value; }
        public bool Active { get => _active; set => _active = value; }

        public String PhaseName { get => _phase.Name; }
        public int Id { get => _id; set => _id = value; }
    }
}
