using SDC.BLL.Interfaces;
using SDC.DATA;
using SDC.BLL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.BLL.Metodos
{
    public class MTecnico : MDB, ITecnico
    {
        public List<DAL.Tecnico> ListaTecnico()
        {
            return tec.ListaTecnico();
        }

        public void RegistroTecnico(DATA.Tecnico tecnico)
        {
            tec.RegistroTecnico(tecnico);
        }
        public void EliminarTecnico(DATA.Tecnico tecnico)
        {
            tec.EliminarTecnico(tecnico);
        }

        public void ActualizarTecnico(Tecnico tecnico)
        {
            tec.ActualizarTecnico(tecnico);
        }

        public Tecnico SeleccionarTecnicoPorCodigo(string codigo)
        {
            return tec.SeleccionarTecnicoPorCodigo(codigo);
        }
    }
}
