using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.DATA;

namespace SDC.BLL.Interface
{
    public interface IUsuarios
    {

        void InsertUser(DATA.Usuarios user);
        void DeleteUser(DATA.Usuarios user);
        void UpdateUser(DATA.Usuarios user);
        DAL.Usuario LoginUser(string email, string pass);
        List<DAL.Usuario> ListUser();
    }
}
