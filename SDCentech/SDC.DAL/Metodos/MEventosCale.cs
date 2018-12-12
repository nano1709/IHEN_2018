using SDC.DAL.Interface;
using SDC.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDC.DAL.Metodos
{
    public class MEventosCale : MDB, IEventosCale
    {

        DocenciaEntities sc = new DocenciaEntities();
        DAL.evento registroEvento = new DAL.evento();
        DATA.Eventos listaEventos = new DATA.Eventos();
        DATA.Eventos listaIDEventos = new DATA.Eventos();


        private static MEventosCale instancia;

        public static MEventosCale Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MEventosCale();
                }
                return instancia;
            }
            set
            {
                if (instancia == null)
                {
                    instancia = value;
                }
            }
        }

        public List<DAL.evento> ListaEvento()
        {
            List<DAL.evento> lista = new List<DAL.evento>();

            try
            {

                _db.Open();
                lista = conexion.eventos.ToList();
                _db.Close();

            }
            catch (Exception ex)
            {

                Console.Write(ex);
            }
            return lista;
        }


        public void RegistroEvento(DATA.Eventos evento)
        {
            try
            {
                sc.Database.Connection.Open();

                registroEvento.title = evento.title;
                registroEvento.start = evento.start;
                registroEvento.end = evento.end;
                registroEvento.className = evento.className;
                registroEvento.url = evento.url;


                sc.eventos.Add(registroEvento);

                sc.SaveChanges();
                sc.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void ActualizarEvento(DATA.Eventos evento)
        {
            try
            {
                sc.Database.Connection.Open();

                var actuEve = sc.eventos.Where(x => x.id == evento.id).First();
                actuEve.title = evento.title;
                actuEve.start = evento.start;
                actuEve.end = evento.end;
                actuEve.url = evento.url;
                actuEve.className = evento.className;

                sc.SaveChanges();

                sc.Database.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }


        }

        public void EliminarEvento(DATA.Eventos evento)
        {
            try
            {
                //Eventos si se elimina
                sc.Database.Connection.Open();

                var elimiEve = sc.eventos.Where(x => x.id == evento.id).First();

                sc.eventos.Remove(elimiEve);

                sc.SaveChanges();

                sc.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }


        }


        public DATA.Eventos SeleccionarEvento(int id)
        {


            try
            {
                var evento = sc.eventos.Where(x => x.id == id).First();
                listaIDEventos.id = evento.id;
                listaIDEventos.title = evento.title;
                listaIDEventos.start = Convert.ToDateTime(evento.start);
                listaIDEventos.end = Convert.ToDateTime(evento.end);
                listaIDEventos.className = evento.className;
                listaIDEventos.url = evento.url;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaIDEventos;

        }


    }
}
