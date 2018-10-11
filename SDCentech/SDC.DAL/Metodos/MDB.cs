using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.DAL.Interface
{
    public class MDB
    {
        public DocenciaEntities conexion;
        public IDbConnection _db;

        public MDB()
        {
            conexion = new DocenciaEntities();
            _db = conexion.Database.Connection;
            _db.Open();
            _db.Close();
        }
    }
}
