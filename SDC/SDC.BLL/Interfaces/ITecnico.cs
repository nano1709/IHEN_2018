using SDC.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.BLL.Interfaces
{
    public interface ITecnico
    {
        List<DAL.Tecnico> ListaTecnico();
        void RegistroTecnico(Tecnico tecnico);
    }
}
