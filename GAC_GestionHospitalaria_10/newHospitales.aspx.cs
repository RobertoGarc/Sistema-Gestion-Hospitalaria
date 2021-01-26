using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.Repository;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;
using GAC_Logica_Negocio_10;




namespace GAC_GestionHospitalaria_10
{
    public partial class newHospitales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ddl Tipos_H
                List<TIPOS_H> listtipos_h = new List<TIPOS_H>();
                GAC_Tipos_H_10_Logica datos0 = new GAC_Tipos_H_10_Logica();
                listtipos_h = datos0.getTipo_H();
                ddl_Tipo.DataSource = listtipos_h;
                ddl_Tipo.DataTextField = "Tipo";
                ddl_Tipo.DataValueField = "Id_tipoh";
                ddl_Tipo.DataBind();

                //ddl Categorias
                List<CATEGORIAS> listcategorias = new List<CATEGORIAS>();
                GAC_categorias_10_Logica datos1 = new GAC_categorias_10_Logica();
                listcategorias = datos1.getCategorias();
                ddl_Categorias.DataSource = listcategorias;
                ddl_Categorias.DataTextField = "Categoria";
                ddl_Categorias.DataValueField = "Id_categoria";
                ddl_Categorias.DataBind();

                //ddl Areas
                List<AREAS> listareas = new List<AREAS>();
                GAC_Areas_10_Logica datos2 = new GAC_Areas_10_Logica();
                listareas = datos2.getAreas();
                ddl_area.DataSource = listareas;
                ddl_area.DataTextField = "Area";
                ddl_area.DataValueField = "Id_area";
                ddl_area.DataBind();

                // dll Mostrar todas las Provincias
                List<PROVINCIAS> listprovincias = new List<PROVINCIAS>();
                GAC_Provincias_10_Logica datos3 = new GAC_Provincias_10_Logica();
                listprovincias = datos3.getProvincias();
                ddl_Provincia.DataSource = listprovincias;
                ddl_Provincia.DataTextField = "Provincia";
                ddl_Provincia.DataValueField = "Id_provincia";
                ddl_Provincia.DataBind();
                ddl_Provincia.Items.Insert(0, new ListItem("[Selecionar]", "0"));
                ddl_Canton.Items.Insert(0, new ListItem("[Selecionar]", "0"));
                ddl_Parroquia.Items.Insert(0, new ListItem("[Selecionar]", "0"));

                /*//ddl PROVINCIAS
                List<PROVINCIAS> listprovincias = new List<PROVINCIAS>();
                GAC_Provincias_10_Logica datos3 = new GAC_Provincias_10_Logica();
                listprovincias = datos3.getProvincias();
                ddl_Provincia.DataSource = listprovincias;
                ddl_Provincia.DataTextField = "Provincia";
                ddl_Provincia.DataValueField = "Id_provincia";
                ddl_Provincia.DataBind();
                ddl_Provincia.Items.Insert(0, new ListItem("[Selecionar]", "0"));
                

                //ddl Cantones
                List<CANTONES> listcantones = new List<CANTONES>();
                GAC_Cantones_10_Logica datos4 = new GAC_Cantones_10_Logica();
                listcantones = datos4.getCantones();
                ddl_Canton.DataSource = listcantones;
                ddl_Canton.DataTextField = "Canton";
                ddl_Canton.DataValueField = "Id_canton";
                ddl_Canton.DataBind();
                ddl_Canton.Items.Insert(0, new ListItem("[Selecionar]", "0"));

                //ddl Parroquias
                List<PARROQUIAS> listparroquia = new List<PARROQUIAS>();
                GAC_Parroquias_10_Logica datos5 = new GAC_Parroquias_10_Logica();
                listparroquia = datos5.getParroquias();
                ddl_Parroquia.DataSource = listparroquia;
                ddl_Parroquia.DataTextField = "Parroquia";
                ddl_Parroquia.DataValueField = "Id_parroquia";
                ddl_Parroquia.DataBind();
                ddl_Parroquia.Items.Insert(0, new ListItem("[Selecionar]", "0"));*/


            }
        }

       
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txt_Fecha_Creacion.Text = Calendar1.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {

            HOSPITALES nuevoHospital = new HOSPITALES();
            nuevoHospital.Nombre = txt_Nombre.Text;
            nuevoHospital.Tipo = Convert.ToInt32(ddl_Tipo.SelectedValue);
            nuevoHospital.Categoria = Convert.ToInt32(ddl_Categorias.SelectedValue);
            nuevoHospital.Area = Convert.ToInt32(ddl_area.SelectedValue);
            nuevoHospital.Provincia = Convert.ToInt32(ddl_Provincia.SelectedValue);
            nuevoHospital.Canton = Convert.ToInt32(ddl_Canton.SelectedValue);
            nuevoHospital.Parroquia = Convert.ToInt32(ddl_Parroquia.SelectedValue);
            nuevoHospital.Direccion = txt_Direccion.Text;
            nuevoHospital.Fecha_Creacion = Convert.ToDateTime(txt_Fecha_Creacion.Text);
            nuevoHospital.Gerente = txt_Gerente.Text;
            nuevoHospital.Observacion = txt_Observacion.Text;

            GAC_Hospitales_10_Logica datos = new GAC_Hospitales_10_Logica();
            datos.NewHospital(nuevoHospital);
        }

      

        protected void ddl_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int idprovincia = Convert.ToInt32(ddl_Provincia.SelectedValue);
            GAC_Hospitales_10_Repository datos3 = new GAC_Hospitales_10_Repository();
            ddl_Canton.DataSource = datos3.Consultar("SELECT * FROM CANTONES WHERE Id_provincia="+ idprovincia);
            ddl_Canton.DataTextField = "Canton";
            ddl_Canton.DataValueField = "Id_canton";
            ddl_Canton.DataBind();
            ddl_Canton.Items.Insert(0, new ListItem("[Selecionar]", "0"));
        }

         protected void ddl_Canton_SelectedIndexChanged(object sender, EventArgs e)
         {

             int idcantones = Convert.ToInt32(ddl_Canton.SelectedValue);
             GAC_Hospitales_10_Repository datos3 = new GAC_Hospitales_10_Repository();
             ddl_Parroquia.DataSource = datos3.Consultar("SELECT * FROM PARROQUIAS WHERE Id_canton="+ idcantones);
             ddl_Parroquia.DataTextField = "Parroquia";
             ddl_Parroquia.DataValueField = "Id_parroquia";
             ddl_Parroquia.DataBind();
             ddl_Parroquia.Items.Insert(0, new ListItem("[Selecionar]", "0"));

         }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
