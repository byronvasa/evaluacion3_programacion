using MedidoresDMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDMModels.DAL
{
    public class LecturasDALObjetos : ILecturasDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }

        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);
        }
    }
}
