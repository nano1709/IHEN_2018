using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.DATA;

namespace SDC.BLL.Interfaces
{
    public interface IEstudiante
    {
        List<DAL.Estudiante> ListaEstudiante();
        void RegistroEstudiante(Estudiante estudiante);
    }
}
