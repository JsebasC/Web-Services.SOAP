using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatoProducto
    {


        public IEnumerable<SearchAllProductos1_Result> MostrarProductos()
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {
  
                var query = db.SearchAllProductos1();
                return query.ToList();
            }
        }

        public List<Producto> GetByIdProducto(int? id)
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = (from e in db.Producto where e.Id == id select e);
                return query.ToList();
            }
        }
        public bool getCodigoProducto(string id)
        {

            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = (from e in db.Producto where e.Codigo == id select e).FirstOrDefault(); ;


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



    }
}
