using GameSoftDev.opt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.pject
{
    public class Project
    {
        private int _id;
        private BindingList<PhaseProject> _phasesProject;
        private BindingList<Participant> _participants;
        private Game _game;
        private string _name;
        private string _description;
        private DateTime _plannedStartDate;
        private DateTime _actualStartDate;
        private DateTime _plannedEndDate;
        private DateTime _actualEndDate;
        private double _totalBudget;
        private bool _active;

        public Project()
        {
            _phasesProject = new BindingList<PhaseProject>();
            _participants = new BindingList<Participant>();
            _game = new Game();
            _game.Genre = new Genre();
            _game.GameMode = new GameMode();
            _game.CCS = new ContentClassificationSystem();
            _game.Platform = new Platform();

        }

        public Project(string name, string description, DateTime plannedStartDate, DateTime plannedEndDate, double totalBudget)
        {
            _name = name;
            _description = description;
            _plannedStartDate = plannedStartDate;
            _plannedEndDate = plannedEndDate;
            _totalBudget = totalBudget;
            _phasesProject = new BindingList<PhaseProject>();
            _participants = new BindingList<Participant>();
            _active = true;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime PlannedStartDate { get => _plannedStartDate; set => _plannedStartDate = value; }
        public DateTime ActualStartDate { get => _actualStartDate; set => _actualStartDate = value; }
        public DateTime PlannedEndDate { get => _plannedEndDate; set => _plannedEndDate = value; }
        public DateTime ActualEndDate { get => _actualEndDate; set => _actualEndDate = value; }
        public double TotalBudget { get => _totalBudget; set => _totalBudget = value; }
        public bool Active { get => _active; set => _active = value; }
        public BindingList<Participant> Participants { get => _participants; set => _participants = value; }
        public Game Game { get => _game; set => _game = value; }
        public BindingList<PhaseProject> PhasesProject { get => _phasesProject; set => _phasesProject = value; }

        public string showInfo()
        {
            return "Proyecto: " + _id + ": " + _game.Name + "-" + _game.Genre.Name + "-" + _game.GameMode.Name + "-" + _game.CCS.Acronym + "-" + _game.Platform.Name + "\n"; 
        }
    }
}
