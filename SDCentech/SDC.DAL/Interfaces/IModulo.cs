using System.Collections.Generic;

namespace SDC.DAL.Interfaces
{
    public interface IModulo
    {
        List<DAL.Modulo> ListaModulo();
        void RegistroModulo(DATA.Modulo modulo);
        void ActualizarModulo(DATA.Modulo modulo);
        void EliminarModulo(DATA.Modulo modulo);
        DATA.Modulo SeleccionarModuloPorCodigo(string codigo);
    }
}