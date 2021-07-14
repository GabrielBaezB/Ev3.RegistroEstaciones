﻿using RegistroEstacionesDAL;
using RegistroEstacionesDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroEstacionesWeb
{
    public partial class AddPuntoCarga : System.Web.UI.Page
    {
        static PuntoCargaDAL puntodal = new PuntoCargaDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        protected void RegistrarBtn_Click(object sender, EventArgs e)
        {
           
            if (Page.IsValid)
            {
                int id = Convert.ToInt32(idTxt.Text.Trim());
               int tipo = Convert.ToInt32(tipoRbl.SelectedValue);
               int capacidad = Convert.ToInt32(capacidadTxt.Text.Trim());
               DateTime vidaUtil = Convert.ToDateTime(vidaUtilTxt.Text.Trim());

                PuntoCarga pc = new PuntoCarga();              
                pc.Id = id;
                pc.Tipo = tipo;
                pc.CapacidadMax = capacidad;
                pc.VidaUtil = vidaUtil;
                new PuntoCargaDAL().Add(pc);
            
                Response.Redirect("ListPuntosCarga.aspx");
            }
            else
            {

            }
        }

        protected void idCV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //se guarda en variable id, el valor obtenido del textbox idTxt
            string id = idTxt.Text.Trim();
            int idN;
            //si id es vacio
            if (id == string.Empty)
            {
                //muestra error
                idCV.ErrorMessage = "Debe ingresar ID del punto de carga";
                args.IsValid = false;
            }
            else
            {
                //si no se puede convertir la variable string id a int
                if (!int.TryParse(id, out idN))
                {
                    //muestra error
                    idCV.ErrorMessage = "El ID debe ser númerico";
                    args.IsValid = false;
                }
                else
                {
                    // si encuentra la variable id en la lista PuntosCarga
                    if (puntodal.findById(int.Parse(id)) != null)
                    {
                        //muestra error
                        idCV.ErrorMessage = "El punto de carga ya existe";
                        args.IsValid = false;
                    }
                    else
                    {
                        args.IsValid = true;
                    }
                }

            }
        }

        protected void capacidadCV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //se obtiene el valor del texbox capacidadTxt y se guarda en variable capacidad
            string capacidad = capacidadTxt.Text.Trim();
            int capacidadN;
            //si capacidad es vacio
            if (capacidad == string.Empty)
            {
                //muestra error
                capacidadCV.ErrorMessage = "Debe ingresar Capacidad Máxima vehículos";
                args.IsValid = false;
            }
            else
            {
                //si string capacidad no se puede convertir a int
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
            //se obtiene el valor del texbox vidaUtilTxt y se guarda en variable fecha
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

            }
        }


    }
}