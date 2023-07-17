using MedidoresDMModels.DAL;
using MedidoresDMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MedidorDALObjetos : IMedidorDAL
{
    private static List<Medidor> medidores = new List<Medidor>();

    public List<Medidor> ObtenerMedidores()
    {
        return medidores;
    }

    public void AgregarMedidor(Medidor medidor)
    {
        if (medidores.Exists(m => m.NumeroSerie == medidor.NumeroSerie))
        {
            throw new Exception("Ya existe un medidor con ese número de serie.");
        }

        medidores.Add(medidor);
    }
}