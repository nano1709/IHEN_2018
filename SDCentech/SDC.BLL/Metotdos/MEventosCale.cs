using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using SDC.DATA;

namespace SDC.BLL.Metotdos
{
    public class MEventosCale : MDB, IEventosCale
    {
        public List<DAL.evento> ListaEvento()
        {
            return eve.ListaEvento();
        }

        public void RegistroEvento(DATA.Eventos evento)
        {
            eve.RegistroEvento(evento);
        }

        public void ActualizarEvento(DATA.Eventos evento)
        {
            eve.ActualizarEvento(evento);
        }

        public void EliminarEvento(DATA.Eventos evento)
        {
            eve.EliminarEvento(evento);
        }

        public DATA.Eventos SeleccionarEvento(int id)
        {
            return eve.SeleccionarEvento(id); ;
        }
    }
}
