using SDC.DAL.Interface;
using SDC.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDC.DAL.Metodos
{
    public class MModulo : MDB, IModulo
    {
        DocenciaEntities sc = new DocenciaEntities();
        DAL.Modulo registroMod = new DAL.Modulo();
        DATA.Modulo listaModuloCod = new DATA.Modulo();


        private static MModulo instancia;

        public static MModulo Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MModulo();
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

        public List<Modulo> ListaModulo()
        {
            List<DAL.Modulo> lista = new List<DAL.Modulo>();

            try
            {

                _db.Open();
                lista = conexion.Moduloes.ToList();
                _db.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public void RegistroModulo(DATA.Modulo modulo)
        {

            try
            {
                sc.Database.Connection.Open();

                registroMod.NombreModulo = modulo.NombreModulo;
                registroMod.CodigoModulo = modulo.CodigoModulo;
                registroMod.Creditos = modulo.Creditos;
                registroMod.Duracion = modulo.Duracion;
                registroMod.Estado = Convert.ToBoolean(modulo.Estado);

                sc.Moduloes.Add(registroMod);

                sc.SaveChanges();
                sc.Database.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void ActualizarModulo(DATA.Modulo modulo)
        {

            try
            {
                sc.Database.Connection.Open();

                var actuMod = sc.Moduloes.Where(x => x.CodigoModulo == modulo.CodigoModulo).First();
                actuMod.NombreModulo = modulo.NombreModulo;
                actuMod.CodigoModulo = modulo.CodigoModulo;
                actuMod.Duracion = modulo.Duracion;
                actuMod.Creditos = modulo.Creditos;
                actuMod.Estado = Convert.ToBoolean(modulo.Estado);




                sc.SaveChanges();

                sc.Database.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public void EliminarModulo(DATA.Modulo modulo)
        {
            try
            {

                sc.Database.Connection.Open();

                var EliminarModulo = sc.Moduloes.Where(x => x.CodigoModulo == modulo.CodigoModulo).First();
                EliminarModulo.Estado = false;

                sc.SaveChanges();

                sc.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

        }



        public DATA.Modulo SeleccionarModuloPorCodigo(int codigo)
        {


            try
            {
                var modulo = sc.Moduloes.Where(x => Convert.ToInt32(x.CodigoModulo) == codigo).First();
                listaModuloCod.NombreModulo = modulo.NombreModulo;
                listaModuloCod.Creditos = Convert.ToInt16(modulo.Creditos);
                listaModuloCod.Duracion = modulo.Duracion;


            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return listaModuloCod;

        }

    }
}
