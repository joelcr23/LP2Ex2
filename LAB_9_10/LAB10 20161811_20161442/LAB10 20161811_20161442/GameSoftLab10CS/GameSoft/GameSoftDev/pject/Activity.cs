using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.pject
{
    public class Activity : WorkUnit    
    {
        private int _id;
        private String _description;
        private DateTime _estimatedStartDate;
        private BindingList<Technique> _techniques;
        private BindingList<Task> _tasks;

        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime EstimatedStartDate { get => _estimatedStartDate; set => _estimatedStartDate = value; }
        public BindingList<Technique> Techniques { get => _techniques; set => _techniques = value; }
        public BindingList<Task> Tasks { get => _tasks; set => _tasks = value; }
    }
}
