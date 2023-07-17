using MedidoresDMModels.DAL;
using MedidoresDMModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MedidoresDM
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    int numeroSerie = int.Parse(txtNumeroSerie.Text);
                    string tipo = txtTipo.Text;

  
                    Medidor medidor = new Medidor
                    {
                        NumeroSerie = numeroSerie,
                        Tipo = tipo
                    };


                    IMedidorDAL medidorDAL = new MedidorDALObjetos();
                    medidorDAL.AgregarMedidor(medidor);


                    Response.Redirect("MostrarMedidores.aspx");
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}