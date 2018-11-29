namespace SDC.BLL.Interfaces
{
    public interface IUsuarios
    {
        void InsertUser(DATA.Usuarios user);
        void DeleteUser(DATA.Usuarios usuarios);
        void UpdateUser(DATA.Usuarios user);
        DAL.Usuario LoginUser(string email, string pass);
    }
}
