using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SDC.BLL.Metodos
{
    public class MDB
    {
        public DAL.Interfaces.IEstudiante estu;
        public DAL.Interfaces.IProfesor profe;

        public MDB()
        {
            estu = new DAL.Metodos.MEstudiante();
            profe = new DAL.Metodos.MProfesor();
        }

    }
}
