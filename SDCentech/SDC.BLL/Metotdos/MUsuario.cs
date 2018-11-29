using SDC.BLL.Interfaces;

namespace SDC.BLL.Metodos
{
    public class MUsuarios : MDB, IUsuarios
    {
        public void DeleteUser(DATA.Usuarios usuarios)
        {
            usu.DeleteUser(usuarios);
        }

        public void InsertUser(DATA.Usuarios user)
        {
            usu.InsertUser(user);
        }

        public DAL.Usuario LoginUser(string email, string pass)
        {
            return usu.LoginUser(email, pass);
        }

        public void UpdateUser(DATA.Usuarios user)
        {
            usu.UpdateUser(user);
        }
    }
}
