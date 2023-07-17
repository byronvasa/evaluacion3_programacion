﻿    using MedidoresDMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDMModels.DAL
{
    public interface ILecturasDAL
    {
        List<Lectura> ObtenerLecturas();
        void AgregarLectura(Lectura lectura);
    }
}