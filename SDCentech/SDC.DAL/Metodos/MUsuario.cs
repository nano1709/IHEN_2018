using SDC.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDC.DAL.Metodos
{
    public class MUsuarios : IUsuarios
    {

        DAL.Usuario us = new DAL.Usuario();
        DATA.Usuarios Dusu = new DATA.Usuarios();

        DocenciaEntities sc = new DocenciaEntities();

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

        public void DeleteUser(DATA.Usuarios usuario)
        {
            try
            {
                //Usuario si se elimina
                sc.Database.Connection.Open();

                var elimiUsu = sc.Usuarios.Where(x => x.IDUser == usuario.IDUser).First();

                sc.Usuarios.Remove(elimiUsu);

                sc.SaveChanges();

                sc.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

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
                us.Password = user.Password;

                sc.Usuarios.Add(us);
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
            List<DAL.Usuario> lista = new List<Usuario>();
            try
            {
                sc.Database.Connection.Open();
                lista = sc.Usuarios.ToList();

                sc.Database.Connection.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }

        public DAL.Usuario LoginUser(string email, string pass)
        {
            DAL.Usuario select = new DAL.Usuario();
            DAL.Usuario sUsuario = new DAL.Usuario();


            try
            {

                using (DocenciaEntities contexto = new DocenciaEntities())
                {
                    contexto.Database.Connection.Open();

                    sUsuario = contexto.Usuarios.Where(c => c.NombreUsuario == email && c.Password == pass).First();

                    select.IDUser = sUsuario.IDUser;
                    select.NombreUsuario = sUsuario.NombreUsuario;
                    select.Rol = sUsuario.Rol;
                    contexto.Database.Connection.Close();



                    return select;

                }
            }
            catch (Exception ex)
            {
                return select;
            }


        }

        public DATA.Usuarios Select(int id)
        {


            try
            {
                sc.Database.Connection.Open();
                us = sc.Usuarios.Where(x => x.IDUser == id).First();

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
                us = sc.Usuarios.Where(x => x.IDUser == user.IDUser).First();

                us.NombreUsuario = user.NombreUsuario;
                us.Rol = Convert.ToString(user.Rol);
                us.Password = user.Password;
                us.Code = user.code;
                us.Email = user.Email;
                us.Estado = user.Estado;
                us.IDUser = user.IDUser;
                sc.SaveChanges();
                sc.Database.Connection.Close();



            }
            catch (Exception)
            {



            }




        }

    }


}
