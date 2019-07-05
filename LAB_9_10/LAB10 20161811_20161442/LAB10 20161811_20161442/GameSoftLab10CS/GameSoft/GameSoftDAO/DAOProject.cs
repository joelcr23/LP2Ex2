using GameSoftDev.pject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDAO
{
    public interface DAOProject
    {
        /* Retorna los proyectos activos */
        BindingList<Project> queryAll();

        /* Retorna el id del proyecto insertado */
        int Add(Project project);

        /* Actualiza en la BD el proyecto enviado */
        void Update(Project project);

        /* Retorna el proyecto según el id del proyecto */
        Project QueryProjectById(int projectId);
    }
}
