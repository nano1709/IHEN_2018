using SDC.DATA;
using System.Collections.Generic;

namespace SDC.BLL.Interfaces
{
    public interface IModulo
    {
        List<DAL.Modulo> ListaModulo();
        void RegistroModulo(Modulo modulo);
        void ActualizarModulo(DATA.Modulo modulo);
        void EliminarModulo(DATA.Modulo modulo);
        DATA.Modulo SeleccionarModuloPorCodigo(int codigo);
    }
}