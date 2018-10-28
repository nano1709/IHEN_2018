﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.BLL.Interfaces;
using SDC.DAL;
using SDC.DATA;

namespace SDC.BLL.Metodos
{
    public class MUsuarios : MDB, IUsuarios
    {
        public void DeleteUser(int idUser)
        {
            usu.DeleteUser(idUser);
        }

        public void InsertUser(DATA.Usuarios user)
        {
            usu.InsertUser(user);
        }

        public DAL.Usuario LoginUser(string email, string pass)
        {
            BLL.Seguridad seg = new BLL.Seguridad();
            string  pass2 = seg.Decriptar(pass);
            return usu.LoginUser(email, pass2);
        }

        public void UpdateUser(DATA.Usuarios user)
        {
            usu.UpdateUser(user);
        }
    }
}
