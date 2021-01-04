using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
   public class DatoProveedor
    {


        public IEnumerable<SearchAllProveedores1_Result> MostrarProvedores()
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {


                var query = db.SearchAllProveedores1();
                return query.ToList();
            }
        }

        public List<Proveedor> GetById(int? id)
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = (from e in db.Proveedor where e.Id == id select e);
                return query.ToList();
            }
        }


        public bool getCodigoProveedor(string id)
        {
            
            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = (from e in db.Proveedor where e.Codigo == id select e).FirstOrDefault(); 
              

                if (query == null)
                {
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }

        public IEnumerable<Report1_Result> Reporte1()
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {


                var query = db.Report1();
                return query.ToList();
            }
        }
    }
}
