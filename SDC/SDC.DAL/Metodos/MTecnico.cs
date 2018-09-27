using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.DAL.Interface;
using SDC.DAL.Interfaces;
using SDC.DATA;

namespace SDC.DAL.Metodos
{
    public class MTecnico : MDB, ITecnico
    {
        DocenciaEntities1 sc = new DocenciaEntities1();
        DAL.Tecnico registroTec = new DAL.Tecnico();

        private static MTecnico instancia;

        public static MTecnico Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MTecnico();
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

        public List<Tecnico> ListaTecnico()
        {
            List<DAL.Tecnico> lista = new List<DAL.Tecnico>();

            try
            {

                _db.Open();
                lista = conexion.Tecnicoes.ToList();
                _db.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public void RegistroTecnico(DATA.Tecnico tecnico)
        {

            try
            {
                sc.Database.Connection.Open();

                registroTec.NombreTecnico = tecnico.NombreTecnico;
                registroTec.CodigoTecnico = tecnico.CodigoTecnico;
                registroTec.Duracion = tecnico.Duracion;
                registroTec.PerfilOcupacional = tecnico.PerfilOcupacional;
                registroTec.PracticaProf = tecnico.PracticaProf;
                registroTec.Requisitos = tecnico.Requisitos;
                registroTec.Estado = Convert.ToBoolean(tecnico.Estado);



                sc.Tecnicoes.Add(registroTec);

                sc.SaveChanges();
                sc.Database.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}