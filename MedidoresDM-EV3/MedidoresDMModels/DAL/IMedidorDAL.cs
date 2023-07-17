using MedidoresDMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDMModels.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();
        void AgregarMedidor(Medidor medidor);
    }
}