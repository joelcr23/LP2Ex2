using GameSoftDev.pject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDAO
{
    public interface DAOActivity
    {
        BindingList<Activity> queryAllbyIdPhaseProject(int idPhaseProject);
    }
}
