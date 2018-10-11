using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.BLL.Interfaces
{
    public interface IUsuarios
    {

        void InsertUser(DATA.Usuarios user);
        void DeleteUser(int idUser);
        void UpdateUser(DATA.Usuarios user);
        DAL.Usuario LoginUser(string email, string pass);
    }
}
