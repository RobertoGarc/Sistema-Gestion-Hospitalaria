using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_PARENTESCOS_10_Repository
    {
        //Crear registro
        public void NewParentesco(PARENTESCOS nuevoParentesco)
        {
            using (GestionHospitalariaEntities context=new GestionHospitalariaEntities())
            {
                context.PARENTESCOS.Add(nuevoParentesco);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateParentesco(PARENTESCOS atcParentesco)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.PARENTESCOS.Attach(atcParentesco);
                context.Entry(atcParentesco).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeletePaciente(PARENTESCOS borrarParentesco)
        {
            using(GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.PARENTESCOS.Attach(borrarParentesco);
                context.Entry(borrarParentesco).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            } 
        }

        //listar registros
        public List<PARENTESCOS> GetParentescos()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listparentescos = from listparentesco in context.PARENTESCOS select listparentesco;
                return listparentescos.ToList();

            }
        }

        //listar registros por id

        public List<PARENTESCOS> GetParentescos_id(int id_Parentesco)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listparentescos = from listparentesco in context.PARENTESCOS where listparentesco.Id_Parentesco == id_Parentesco
                                     select listparentesco;
                return listparentescos.ToList();
            }
        }

    }
}
