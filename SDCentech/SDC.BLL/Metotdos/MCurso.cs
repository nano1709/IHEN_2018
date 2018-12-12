using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System.Collections.Generic;

namespace SDC.BLL.Metotdos
{
    public class MCurso : MDB, ICurso
    {
        public List<DAL.Sede> ListaSede()
        {
            return sed.ListaSede();
        }

        public void ActualizarCurso(DATA.Curso curso)
        {
            cur.ActualizarCurso(curso);
        }

        public void EliminarCursp(DATA.Curso curso)
        {
            cur.EliminarCursp(curso);
        }

        public List<DAL.Curso> ListaCurso()
        {
            return cur.ListaCurso();
        }

        public void RegistroCurso(DATA.Curso curso)
        {
            cur.RegistroCurso(curso);
        }

        public DATA.Curso SeleccionarCursoId(string Id)
        {
            return cur.SeleccionarCursoId(Id);
        }
    }
}
