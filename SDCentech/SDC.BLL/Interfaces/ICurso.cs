using System;
using System.Collections.Generic;

namespace SDC.BLL.Interfaces
{
    public interface ICurso
    {
        List<DAL.Curso> ListaCurso();
        void RegistroCurso(DATA.Curso curso);
        void ActualizarCurso(DATA.Curso curso);
        void EliminarCursp(DATA.Curso curso);
        DATA.Curso SeleccionarCursoId(String Id);
        List<DAL.Sede> ListaSede();
    }
}
