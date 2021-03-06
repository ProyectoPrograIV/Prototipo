﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace CascaronPrograIV.Archivos.WebForms
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SP_INICIO_SESION_Result sesion = (SP_INICIO_SESION_Result)Session["sesion"];


                if (sesion.ID_ROL == 11) //El 11 corresponde a administrador
                {
                    hlParametrizaciones.Visible = true;
                    hlSolicitud.Visible = true;
                    hlOrden.Visible = true;
                    hlLiquidacion.Visible = true;
                    hlReportes.Visible = true;
                    hlRegistro.Visible = true;

                }

                if (sesion.ID_ROL == 10) //El 10 corresponde a jefatura
                {
                    hlParametrizaciones.Visible = true;
                    hlOrden.Visible = true;
                    hlReportes.Visible = true;
                }

                if (sesion.ID_ROL == 9) //El 9 corresponde a funcionario
                {
                    hlSolicitud.Visible = true;
                    hlLiquidacion.Visible = true;
                    hlReportes.Visible = true;
                }
            }
           
        }
        
    }
}