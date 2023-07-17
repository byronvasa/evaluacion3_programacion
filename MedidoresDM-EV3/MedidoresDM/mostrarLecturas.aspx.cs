using MedidoresDMModels.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MedidoresDM
{
    public partial class MostrarLecturas : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                CargarMedidores();

                CargarLecturas();
            }
        }

        protected void ddlMedidor_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargarLecturas();
        }

        private void CargarMedidores()
        {

            IMedidorDAL medidorDAL = new MedidorDALObjetos();
            var medidores = medidorDAL.ObtenerMedidores();


            ddlMedidor.DataSource = medidores;
            ddlMedidor.DataTextField = "NumeroSerie";
            ddlMedidor.DataValueField = "NumeroSerie";
            ddlMedidor.DataBind();
        }

        private void CargarLecturas()
        {

            ILecturasDAL lecturasDAL = new LecturasDALObjetos();
            var lecturas = lecturasDAL.ObtenerLecturas();


            if (!string.IsNullOrEmpty(ddlMedidor.SelectedValue))
            {
                int medidorNumeroSerie = int.Parse(ddlMedidor.SelectedValue);
                lecturas = lecturas.Where(l => l.MedidorNumeroSerie == medidorNumeroSerie).ToList();
            }

            gridLecturas.DataSource = lecturas;
            gridLecturas.DataBind();
        }
    }
}