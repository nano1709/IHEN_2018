﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using SDC.DAL;
using SDC.DATA;

namespace SDC.BLL.Metodos
{
    public class MProfesor : MDB, IProfesor
    {
        public void ActualizarProfesor(DATA.Profesor profesor)
        {
            profe.ActualizarProfesor(profesor);
        }

        public void EliminarProfesor(DATA.Profesor profesor)
        {
            profe.EliminarProfesor(profesor);
        }

        public List<DAL.Profesor> ListaProfesor()
        {
            return profe.ListaProfesor();
        }

        public void RegistroProfesor(DATA.Profesor profesor)
        {
            profe.RegistroProfesor(profesor);
        }

        public DATA.Profesor SeleccionarProfesorCedula(int cedula)
        {
            return profe.SeleccionarProfesorCedula(cedula);
        }
    }
}
