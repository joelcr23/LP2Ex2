using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.pject
{
    public class Phase
    {
        private int _id;
        private BindingList<Activity> _activities;
        private string _name;
        private string _description;
        private bool _active;

        public Phase()
        {

        }
        public Phase(string name, string description)
        {
            _name = name;
            _description = description;
            _active = true;
        }

        public int Id { get => _id; set => _id = value; }
        public BindingList<Activity> Activities { get => _activities; set => _activities = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public bool Active { get => _active; set => _active = value; }
    }
}
