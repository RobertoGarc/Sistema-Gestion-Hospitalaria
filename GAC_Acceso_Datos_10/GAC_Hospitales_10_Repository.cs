using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Hospitales_10_Repository
    {

        //Crear Registro

        public void NewHospital(HOSPITALES nuevoHospital)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {

                context.HOSPITALES.Add(nuevoHospital);
                context.SaveChanges();
            }
        }

        //Actualizar Registro
        public void updateHospital(HOSPITALES actHospital)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.HOSPITALES.Attach(actHospital);
                context.Entry(actHospital).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Eliminar Registro

        public void deleteHospital(HOSPITALES borrarHospital)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.HOSPITALES.Attach(borrarHospital);
                context.Entry(borrarHospital).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }

        }

        //Listar Registro

        public List<HOSPITALES> getHospitales()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listhospitales = from listhospital in context.HOSPITALES
                                     select listhospital;
                return listhospitales.ToList();
            }
        }

        // Listar Registro por ID

        public List<HOSPITALES> getHospitales_id(int id_Hospital)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listhospitales = from listhospital in context.HOSPITALES
                                     where listhospital.Id_hospital == id_Hospital
                                     select listhospital;
                return listhospitales.ToList();
            }
        }
        // Listar Registro  de Provinicas

        
        public DataSet Consultar(string strSQL)
        {
            string strconn = "data source=ANDRES_ACURIO;initial catalog=GestionHospitalaria;user id=gh_user;password=123456";
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public HOSPITALES get_Registro_Hospitales(int registro_id)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var registros = from registro in context.HOSPITALES
                                where registro.Id_hospital == registro_id
                                select registro;
                return registros.First<HOSPITALES>();
            }

        }

      


    }
}
