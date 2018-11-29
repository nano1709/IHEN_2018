namespace SDC.DAL.Interfaces
{
    public interface IUsuarios
    {
        void InsertUser(DATA.Usuarios user);
        void DeleteUser(DATA.Usuarios usuario);
        void UpdateUser(DATA.Usuarios user);
        DAL.Usuario LoginUser(string email, string pass);

    }
}
