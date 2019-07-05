﻿using GameSoftDev.pject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDAO
{
    public interface DAOPhaseProject
    {
        int insert(PhaseProject phaseProject);
        BindingList<PhaseProject> queryByProjectId(int projectId);

    }
}
