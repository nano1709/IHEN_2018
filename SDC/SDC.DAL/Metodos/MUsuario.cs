using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.DAL.Interfaces;

namespace SDC.DAL.Metodos
{
    public class MUsuarios : IUsuario
    {

        DAL.Usuario us = new DAL.Usuario();
        DATA.Usuarios Dusu = new DATA.Usuarios();

        SDCEntities sc = new SDCEntities();

        private static MUsuarios instancia;

        public static MUsuarios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MUsuarios();
                }
                return instancia;
            }
            set
            {
                if (instancia == null)
                {
                    instancia = value;
                }
            }
        }

        public void DeleteUser(int idUser)
        {

        }

        public void InsertUser(DATA.Usuarios user)
        {
            try
            {
                sc.Database.Connection.Open();



                us.IDUser = user.IDUser;
                us.NombreUsuario = user.NombreUsuario;
                us.Rol = Convert.ToString(user.Rol);
                us.Code = user.code;
                us.Email = user.Email;
                us.Estado = user.Estado;

                sc.Usuario.Add(us);
                sc.SaveChanges();

                sc.Database.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public List<DAL.Usuario> ListUser()
        {
            // Inicializamos 
            List<DAL.Usuario> lista = new List<DAL.Usuario>();


            return lista;
        }

        public DAL.Usuario LoginUser(string email, string pass)
        {
            try
            {
                DAL.Usuario select = new DAL.Usuario();
                DAL.Usuario sUsuario = new DAL.Usuario();

                using (SDCEntities contexto = new SDCEntities())
                {
                    contexto.Database.Connection.Open();

                    sUsuario = contexto.Usuario.Where(c => c.NombreUsuario == email && c.Password == pass).First();

                    select.IDUser = sUsuario.IDUser;
                    select.NombreUsuario = sUsuario.NombreUsuario;
                    select.Rol = sUsuario.Rol;
                    contexto.Database.Connection.Close();



                    return select;

                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public DATA.Usuarios Select(int id)
        {


            try
            {
                sc.Database.Connection.Open();
                us = sc.Usuario.Where(x => x.IDUser == id).First();

                Dusu.NombreUsuario = us.NombreUsuario;
                Dusu.Rol = Convert.ToInt32(us.Rol);
                Dusu.Password = us.Password;
                Dusu.Estado = Convert.ToBoolean(us.Estado);
                Dusu.code = us.Code;
                Dusu.Email = us.Email;
                Dusu.IDUser = us.IDUser;
                sc.Database.Connection.Close();



            }
            catch (Exception)
            {

                return Dusu;

            }

            return Dusu;



        }

        public void UpdateUser(DATA.Usuarios user)
        {


            try
            {
                sc.Database.Connection.Open();
                us = sc.Usuario.Where(x => x.IDUser == user.IDUser).First();

                us.NombreUsuario = user.NombreUsuario;
                us.Rol = Convert.ToString(user.Rol);
                us.Password = user.Password;
                us.Code = user.code;
                us.Email = user.Email;
                us.Estado = user.Estado;
                us.IDUser = user.IDUser
                sc.SaveChanges();
                sc.Database.Connection.Close();



            }
            catch (Exception)
            {



            }




        }

    }


}
