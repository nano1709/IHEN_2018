using SDC.DAL.Interface;
using SDC.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDC.DAL.Metodos
{
    public class MSede : MDB, ISede
    {
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
