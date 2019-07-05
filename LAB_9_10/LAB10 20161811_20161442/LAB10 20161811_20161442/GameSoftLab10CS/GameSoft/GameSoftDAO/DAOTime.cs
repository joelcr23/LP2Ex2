using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameSoftDev.pject;

namespace GameSoftDAO
{
    public interface DAOTime
    {
        Time queryByIdTask(int idTask);
    }
}
