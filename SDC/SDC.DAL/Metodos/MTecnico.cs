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
        DocenciaEntities2 sc = new DocenciaEntities2();
        DAL.Tecnico registroTec = new DAL.Tecnico();
        DATA.Tecnico listaTecnicoCod = new DATA.Tecnico();


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

        public void ActualizarTecnico(DATA.Tecnico tecnico)
        {

            try
            {
                sc.Database.Connection.Open();

                var actuTec = sc.Tecnicoes.Where(x => x.CodigoTecnico == tecnico.CodigoTecnico).First();
                actuTec.Nombre = tecnico.NombreTecnico;
                actuTec.CodigoTecnico = Convert.ToInt32(tecnico.CodigoTecnico);
                actuTec.PerfilOcupacional = tecnico.PerfilOcupacional;
                actuTec.Duracion = tecnico.Duracion;
                actuTec.Requisitos = tecnico.Requisitos;
                actuTec.Estado = tecnico.Estado;
                actuTec.PracticaProf = tecnico.PracticaProf;



                sc.SaveChanges();

                sc.Database.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public void EliminarTecnico(DATA.Tecnico tecnico)
        {
            try
            {
                
                sc.Database.Connection.Open();

                var EliminarTecnico = sc.Tecnicoes.Where(x => x.CodigoTecnico == tecnico.CodigoTecnico).First();
                EliminarTecnico.Estado = false;

                sc.SaveChanges();

                sc.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

        }

        

        public DATA.Tecnico SeleccionarTecnicoPorCodigo(int codigo)
        {


            try
            {
                var tecnico = sc.Tecnicoes.Where(x => x.CodigoTecnico == codigo).First();
                listaTecnicoCod.NombreTecnico = tecnico.NombreTecnico;
                listaTecnicoCod.PerfilOcupacional = tecnico.PerfilOcupacional;
                listaTecnicoCod.Duracion = tecnico.Duracion;
                listaTecnicoCod.PracticaProf = tecnico.PracticaProf;
                listaTecnicoCod.Requisitos = tecnico.Requisitos;
                listaTecnicoCod.Estado = Convert.ToByte(tecnico.Estado);

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return listaTecnicoCod;

        }

    }
}
