using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.DATA;

namespace SDC.DAL.Interfaces
{
    public interface ITecnico
    {
        List<DAL.Tecnico> ListaTecnico();
        void RegistroTecnico(DATA.Tecnico tecnico);
        void ActualizarTecnico(DATA.Tecnico tecnico);
        void EliminarTecnico(DATA.Tecnico tecnico);
        DATA.Tecnico SeleccionarTecnicoPorCodigo(string codigo);
    }
}
