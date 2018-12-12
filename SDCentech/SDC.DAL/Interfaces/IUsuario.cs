using System.Collections.Generic;
namespace SDC.DAL.Interfaces
{
    public interface IUsuarios
    {
        void InsertUser(SDC.DATA.Usuarios user);
        void DeleteUser(SDC.DATA.Usuarios usuarios);
        void UpdateUser(SDC.DATA.Usuarios user);
        SDC.DAL.Usuario LoginUser(string email, string pass);
        List<SDC.DAL.Usuario> ListUser();
    }
}
