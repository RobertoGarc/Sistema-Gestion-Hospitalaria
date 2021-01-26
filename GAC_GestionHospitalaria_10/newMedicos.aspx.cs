﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GAC_Entidades_10;
using GAC_Logica_Negocio_10;

namespace GAC_GestionHospitalaria_10
{
    public partial class newMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ddl 
                List<HOSPITALES> listId_Hospital = new List<HOSPITALES>();
                GAC_Hospitales_10_Logica datos0 = new GAC_Hospitales_10_Logica();
                listId_Hospital = datos0.getHospitales();
                ddl_Id_Hospital.DataSource = listId_Hospital;
                ddl_Id_Hospital.DataTextField = "Nombre";
                ddl_Id_Hospital.DataValueField = "Id_hospital";
                ddl_Id_Hospital.DataBind();

                //ddl Cargo
                List<CARGOS> listcargo = new List<CARGOS>();
                GAC_Cargos_10_Logica datos1 = new GAC_Cargos_10_Logica();
                listcargo = datos1.getCargos();
                ddl_Cargo.DataSource = listcargo;
                ddl_Cargo.DataTextField = "Cargo";
                ddl_Cargo.DataValueField = "Id_cargo";
                ddl_Cargo.DataBind();

                //ddl Sexo
                List<SEXO> listsexo = new List<SEXO>();
                GAC_Sexo_10_Logica datos2 = new GAC_Sexo_10_Logica();
                listsexo = datos2.getSexos();
                ddl_Sexo.DataSource = listsexo;
                ddl_Sexo.DataTextField = "Sexo1";
                ddl_Sexo.DataValueField = "Id_sexo";
                ddl_Sexo.DataBind();

            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txt_FechaN.Text = Calendar1.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            MEDICOS nuevoDoctor = new MEDICOS();
            nuevoDoctor.Cedula = txt_Cedula.Text;
            nuevoDoctor.Nombres = txt_Nombres.Text;
            nuevoDoctor.Apellidos = txt_Apellidos.Text;
            nuevoDoctor.Id_hospital = Convert.ToInt32(ddl_Id_Hospital.SelectedValue);
            nuevoDoctor.Cargo = Convert.ToInt32(ddl_Cargo.SelectedValue);
            nuevoDoctor.FechaN = Convert.ToDateTime(txt_FechaN.Text);
            nuevoDoctor.Sexo = Convert.ToInt32(ddl_Sexo.SelectedValue);
            nuevoDoctor.Direccion = txt_Direccion.Text;
            nuevoDoctor.Telefono = txt_Telefono.Text;
            nuevoDoctor.Email = txt_Email.Text;
            nuevoDoctor.Login = txt_Login.Text;
            nuevoDoctor.Password = txt_Password.Text;
            nuevoDoctor.Observacion = txt_Observacion.Text;

            GAC_Medicos_10_Logica datos = new GAC_Medicos_10_Logica();
            datos.newMedicos(nuevoDoctor);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


    }
}
    