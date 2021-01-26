using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GAC_Entidades_10;
using GAC_Logica_Negocio_10;
using GAC_Acceso_Datos_10;

namespace GAC_GestionHospitalaria_10
{
    public partial class updateHospital : System.Web.UI.Page
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


                // dll listar todas las Provincias
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

                //ddl Cantones
                List<CANTONES> listcantones = new List<CANTONES>();
                GAC_Cantones_10_Logica datos4 = new GAC_Cantones_10_Logica();
                listcantones = datos4.getCantones();
                ddl_Canton.DataSource = listcantones;
                ddl_Canton.DataTextField = "Canton";
                ddl_Canton.DataValueField = "Id_canton";
                ddl_Canton.DataBind();

                //ddl Parroquias
                List<PARROQUIAS> listparroquia = new List<PARROQUIAS>();
                GAC_Parroquias_10_Logica datos5 = new GAC_Parroquias_10_Logica();
                listparroquia = datos5.getParroquias();
                ddl_Parroquia.DataSource = listparroquia;
                ddl_Parroquia.DataTextField = "Parroquia";
                ddl_Parroquia.DataValueField = "Id_parroquia";
                ddl_Parroquia.DataBind();*/


                int idhospital = Convert.ToInt32(Session["id_hospital"]);
                GAC_Hospitales_10_Logica datos6 = new GAC_Hospitales_10_Logica();
                HOSPITALES registro_hospital = new HOSPITALES();
                registro_hospital = datos6.get_Registro_Hospital(idhospital);

                txt_Id_Hospital.Text = registro_hospital.Id_hospital.ToString();
                txt_Nombre.Text = registro_hospital.Nombre.ToString();
                ddl_Tipo.SelectedValue = registro_hospital.ToString();
                ddl_Categorias.SelectedValue = registro_hospital.ToString();
                ddl_area.SelectedValue = registro_hospital.ToString();
                ddl_Provincia.SelectedValue = registro_hospital.ToString();
                ddl_Canton.SelectedValue = registro_hospital.ToString();
                ddl_Parroquia.SelectedValue = registro_hospital.ToString();
                txt_Direccion.Text = registro_hospital.Direccion.ToString();
                txt_Fecha_Creacion.Text = registro_hospital.Fecha_Creacion.ToString();
                txt_Gerente.Text = registro_hospital.Gerente.ToString();
                txt_Observacion.Text = registro_hospital.Observacion.ToString();
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txt_Fecha_Creacion.Text = Calendar1.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Actualizar_Click(object sender, EventArgs e)
        {

            HOSPITALES nuevoHospital = new HOSPITALES();
            nuevoHospital.Id_hospital = Convert.ToInt32(txt_Id_Hospital.Text);
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
            datos.updateHospital(nuevoHospital);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("SerchHospital.aspx");
        }

        protected void ddl_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idprovincia = Convert.ToInt32(ddl_Provincia.SelectedValue);
            GAC_Hospitales_10_Repository datos3 = new GAC_Hospitales_10_Repository();
            ddl_Canton.DataSource = datos3.Consultar("SELECT * FROM CANTONES WHERE Id_provincia=" + idprovincia);
            ddl_Canton.DataTextField = "Canton";
            ddl_Canton.DataValueField = "Id_canton";
            ddl_Canton.DataBind();
            ddl_Canton.Items.Insert(0, new ListItem("[Selecionar]", "0"));
        }

        protected void ddl_Canton_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idcantones = Convert.ToInt32(ddl_Canton.SelectedValue);
            GAC_Hospitales_10_Repository datos3 = new GAC_Hospitales_10_Repository();
            ddl_Parroquia.DataSource = datos3.Consultar("SELECT * FROM PARROQUIAS WHERE Id_canton=" + idcantones);
            ddl_Parroquia.DataTextField = "Parroquia";
            ddl_Parroquia.DataValueField = "Id_parroquia";
            ddl_Parroquia.DataBind();
            ddl_Parroquia.Items.Insert(0, new ListItem("[Selecionar]", "0"));

        }
    }
    
}