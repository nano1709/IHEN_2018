using SDC.DATA;
using System.Collections.Generic;

namespace SDC.BLL.Interfaces
{
    public interface ITecnico
    {
        List<DAL.Sede> ListaSede();
        List<DAL.Tecnico> ListaTecnico();
        void RegistroTecnico(Tecnico tecnico);
        void ActualizarTecnico(DATA.Tecnico tecnico);
        void EliminarTecnico(DATA.Tecnico tecnico);
        DATA.Tecnico SeleccionarTecnicoPorCodigo(string codigo);
    }
}
