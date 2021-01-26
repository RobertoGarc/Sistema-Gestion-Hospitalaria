using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_SEXO_10_Repository
    {
        //Crear registro
        public void NewSexo(SEXO nuevoSexo)
        {
            using (GestionHospitalariaEntities context=new GestionHospitalariaEntities())
            {
                context.SEXO.Add(nuevoSexo);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateSexo(SEXO atcSexo)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.SEXO.Attach(atcSexo);
                context.Entry(atcSexo).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteSexo(SEXO borrarSexo)
        {
            using(GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.SEXO.Attach(borrarSexo);
                context.Entry(borrarSexo).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            } 
        }

        //listar registros
        public List<SEXO> GetSexos()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listsexos = from listsexo in context.SEXO select listsexo;
                return listsexos.ToList();

            }
        }

        //listar registros por id

        public List<SEXO> GetSexos_id(int id_Sexo)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listsexos = from listsexo in context.SEXO where listsexo.Id_sexo == id_Sexo
                                     select listsexo;
                return listsexos.ToList();

            }
        }

    }
}
