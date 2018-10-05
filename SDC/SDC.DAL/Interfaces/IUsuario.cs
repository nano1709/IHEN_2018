using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.DATA;

namespace SDC.DAL.Interfaces
{
    public interface IUsuario
    {
        void InsertUser(DATA.Usuario user);
        void DeleteUser(int idUser);
        void UpdateUser(DATA.Usuario user);
        DAL.Usuario LoginUser(string email, string pass);
    }
}
