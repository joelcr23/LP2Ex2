using GameSoftDev.pject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDAO
{
    public interface DAOPhase
    {
        int insert(Phase phase);
        List<Phase> queryAll();
    }
}
