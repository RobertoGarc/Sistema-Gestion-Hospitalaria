using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Categorias_10_Repository
    {

        //Crear registro
        public void NewCategoria(CATEGORIAS nuevaCategoria)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CATEGORIAS.Add(nuevaCategoria);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateCategoria(CATEGORIAS atcCategoria)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CATEGORIAS.Attach(atcCategoria);
                context.Entry(atcCategoria).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteCategoria(CATEGORIAS borrarCategoria)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CATEGORIAS.Attach(borrarCategoria);
                context.Entry(borrarCategoria).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<CATEGORIAS> GetCategorias()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcategorias = from listcategoria in context.CATEGORIAS select listcategoria;
                return listcategorias.ToList();

            }
        }

        //listar registros por id

        public List<CATEGORIAS> GetCategorias_id(int id_Categoria)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcategorias = from listcategoria in context.CATEGORIAS
                                    where listcategoria.Id_categoria == id_Categoria
                                    select listcategoria;
                return listcategorias.ToList();

            }
        }

        //nombre completo
        /* public List<PacienteNombreCompleto> GetPacientes_NombreCompleto()
         {
             using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
             {
                 var listpacientes = from listpaciente in context.CATEGORIAS select new PacienteNombreCompleto(Id_paciente=listpaciente.Id_paciente;
                 return listpacientes.ToList();

             }
         }*/

    }
}
