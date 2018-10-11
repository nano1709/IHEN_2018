namespace SDC.DAL.Interfaces
{
    public interface IUsuarios
    {
        void InsertUser(DATA.Usuarios user);
        void DeleteUser(int idUser);
        void UpdateUser(DATA.Usuarios user);
        DAL.Usuario LoginUser(string email, string pass);

    }
}
