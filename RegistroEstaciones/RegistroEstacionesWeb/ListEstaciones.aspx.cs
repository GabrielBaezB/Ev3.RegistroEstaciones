using RegistroEstacionesDAL;
using RegistroEstacionesDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroEstacionesWeb
{
    public partial class ListEstaciones : System.Web.UI.Page
    {
        EstacionDAL estacionDAL = new EstacionDAL();

        private void CargarTabla(List<Estacion> estaciones)
        {
            EstacionesGrid.DataSource = estaciones;
            EstacionesGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(estacionDAL.GetAll());
            }
        }

        protected void EstacionesGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string idAEliminar = e.CommandArgument.ToString();
                estacionDAL.Remove(Convert.ToInt32(idAEliminar));

                CargarTabla(estacionDAL.GetAll());
            }
        }

        protected void AñadirNBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEstacion.aspx");
        }
    }
}