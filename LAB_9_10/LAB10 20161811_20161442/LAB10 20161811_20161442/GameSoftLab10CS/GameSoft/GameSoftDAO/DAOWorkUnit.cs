using GameSoftDev.pject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDAO
{
    public interface DAOWorkUnit
    {
        List<WorkUnit> queryActivitiesByPhaseProjectId(int phaseProjectId);
        List<WorkUnit> queryTasksByActivityId(int activityId);

    }
}
