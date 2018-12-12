using SDC.BLL.Interfaces;
using SDC.DATA;
using System.Collections.Generic;

namespace SDC.BLL.Metodos
{
    public class MModulo : MDB, IModulo
    {

        public List<DAL.Sede> ListaSede()
        {
            return sed.ListaSede();
        }

        public List<DAL.Modulo> ListaModulo()
        {
            return mod.ListaModulo();
        }

        public void RegistroModulo(DATA.Modulo modulo)
        {
            mod.RegistroModulo(modulo);
        }
        public void EliminarModulo(DATA.Modulo modulo)
        {
            mod.EliminarModulo(modulo);
        }

        public void ActualizarModulo(Modulo modulo)
        {
            mod.ActualizarModulo(modulo);
        }

        public Modulo SeleccionarModuloPorCodigo(string codigo)
        {
            return mod.SeleccionarModuloPorCodigo(codigo);
        }
    }
}

