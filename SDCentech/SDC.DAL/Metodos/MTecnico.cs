﻿using SDC.DAL.Interface;
using SDC.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDC.DAL.Metodos
{
    public class MTecnico : MDB, ITecnico
    {
        DocenciaEntities sc = new DocenciaEntities();
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
                registroTec.IdSede = tecnico.IdSede;




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
                actuTec.NombreTecnico = tecnico.NombreTecnico;
                actuTec.CodigoTecnico = tecnico.CodigoTecnico;
                actuTec.PerfilOcupacional = tecnico.PerfilOcupacional;
                actuTec.Duracion = tecnico.Duracion;
                actuTec.Requisitos = tecnico.Requisitos;
                actuTec.Estado = Convert.ToBoolean(tecnico.Estado);
                actuTec.PracticaProf = tecnico.PracticaProf;
                actuTec.IdSede = tecnico.IdSede;


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



        public DATA.Tecnico SeleccionarTecnicoPorCodigo(string codigo)
        {


            try
            {
                var tecnico = sc.Tecnicoes.Where(x => x.CodigoTecnico == codigo.ToString()).First();
                listaTecnicoCod.NombreTecnico = tecnico.NombreTecnico;
                listaTecnicoCod.PerfilOcupacional = tecnico.PerfilOcupacional;
                listaTecnicoCod.Duracion = tecnico.Duracion;
                listaTecnicoCod.PracticaProf = tecnico.PracticaProf;
                listaTecnicoCod.Requisitos = tecnico.Requisitos;
                listaTecnicoCod.Estado = Convert.ToByte(tecnico.Estado);
                listaTecnicoCod.IdSede = Convert.ToInt32(tecnico.IdSede);

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return listaTecnicoCod;

        }
        public List<DAL.Sede> ListaSede()
        {
            List<DAL.Sede> lista = new List<DAL.Sede>();

            try
            {

                _db.Open();
                lista = conexion.Sedes.ToList();
                _db.Close();

            }
            catch (Exception ex)
            {

                Console.Write(ex);
            }
            return lista;
        }

    }
}
