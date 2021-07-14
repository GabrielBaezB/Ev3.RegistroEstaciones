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
    public partial class ActualizarPuntoCarga : System.Web.UI.Page
    {
        static PuntoCargaDAL puntoCargaDal = new PuntoCargaDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
               
                int idAEditar = Convert.ToInt32(Request.QueryString["actualizar"]);               
                PuntoCarga pc = puntoCargaDal.findById(idAEditar);             
                idTxt.Text = pc.Id + "";             
                idTxt.Enabled = false;              
                tipoRbl.SelectedValue = pc.Tipo + "";                
                capacidadTxt.Text = pc.CapacidadMax + "";                
                vidaUtilTxt.Text = Convert.ToDateTime(pc.VidaUtil) + "";
            }
        }
        protected void capacidadCV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //se obtiene el valor del textox capacidadTxt y se guarda en variable capacidad
            string capacidad = capacidadTxt.Text.Trim();
            int capacidadN;
            //si capacidad es vacio
            if (capacidad == string.Empty)
            {
                //muestra error
                capacidadCV.ErrorMessage = "Debe ingresar Capacidad Máxima de vehículos";
                args.IsValid = false;
            }
            else
            {
                //si string capacidad no se puede conevrtir a int
                if (!int.TryParse(capacidad, out capacidadN))
                {
                    //muestra error
                    capacidadCV.ErrorMessage = "Debe ser valor númerico";
                    args.IsValid = false;
                }
                else
                {
                    //en caso contrario
                    args.IsValid = true;
                }
            }
        }

        protected void vidaUtilCV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //se obtiene el valor del textox vidaUtilTxt y se guarda en variable fecha
            string fecha = vidaUtilTxt.Text.Trim();
            //si fecha es vacio
            if (fecha == string.Empty)
            {
                //muestra error
                vidaUtilCV.ErrorMessage = "Debe ingresar Fecha";
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void ActualizarBtn_Click(object sender, EventArgs e)
        {
          
            if (Page.IsValid)
            {                
                int id = Convert.ToInt32(idTxt.Text.Trim());
                PuntoCarga pca = puntoCargaDal.findById(id);
                pca.Tipo = Convert.ToInt32(tipoRbl.SelectedValue);
                pca.CapacidadMax = Convert.ToInt32(capacidadTxt.Text.Trim());
                pca.VidaUtil = Convert.ToDateTime(vidaUtilTxt.Text);
                Response.Redirect("ListPuntosCarga.aspx");
            }

        }

    }
}