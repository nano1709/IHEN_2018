using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.DAL.Interfaces
{
    public interface ICurso
    {
        List<DAL.Curso> ListaCurso();
        void RegistroCurso(DATA.Curso curso);
        void ActualizarCurso(DATA.Curso curso);
        void EliminarCursp(DATA.Curso curso);
        DATA.Curso SeleccionarCursoId(String Id);

    }
}
