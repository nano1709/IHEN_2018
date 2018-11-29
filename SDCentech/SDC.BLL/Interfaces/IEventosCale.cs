using System.Collections.Generic;

namespace SDC.BLL.Interfaces
{
    public interface IEventosCale
    {
        List<DAL.evento> ListaEvento();
        void RegistroEvento(DATA.Eventos evento);
        void ActualizarEvento(DATA.Eventos evento);
        void EliminarEvento(DATA.Eventos evento);
        DATA.Eventos SeleccionarEvento(int id);
    }
}
