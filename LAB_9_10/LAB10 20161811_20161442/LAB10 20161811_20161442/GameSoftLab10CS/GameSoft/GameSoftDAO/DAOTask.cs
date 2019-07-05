using GameSoftDev.pject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GameSoftDAO
{
    public interface DAOTask
    {
        BindingList<Task> queryAllbyIdActivity(int idActivity);
    }
}
