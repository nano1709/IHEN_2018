namespace SDC.BLL.Metodos
{
    public class MDB
    {
        public DAL.Interfaces.IEstudiante estu;
        public DAL.Interfaces.IProfesor profe;
        public DAL.Interfaces.ITecnico tec;
        public DAL.Interfaces.IUsuarios usu;
        public DAL.Interfaces.ICurso cur;


        public MDB()
        {
            estu = new DAL.Metodos.MEstudiante();
            profe = new DAL.Metodos.MProfesor();
            tec = new DAL.Metodos.MTecnico();
            usu = new DAL.Metodos.MUsuarios();
            cur = new DAL.Metodos.MCurso();
        }

    }
}
