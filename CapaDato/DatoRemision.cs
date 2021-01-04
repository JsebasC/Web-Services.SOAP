using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatoRemision
    {

        public IEnumerable<SearchAllRemisionEntrada1_Result> MostrarRemisionesEntrada()
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {

                var query = db.SearchAllRemisionEntrada1().OrderByDescending(e =>e.Id);
                return query.ToList();
            }
        }

        public List<RemisionEntrada> MostrarByIdRemision(int? id)
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = (from e in db.RemisionEntrada where e.Id == id select e);
                return query.ToList();
            }
        }


        
         public List<RemisionEntrada> GetByIdRemision(int? id)
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = (from e in db.RemisionEntrada where e.Id == id select e);
                return query.ToList();
            }
        }


        public IEnumerable<SearchAllRemisionEntradaDetalleByRIdRemisionEntrada_Result> MostrarRemisionDetalleByRemision(int? id)
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = db.SearchAllRemisionEntradaDetalleByRIdRemisionEntrada(id);
                return query.ToList();
             
             
            }
        }

        public List<RemisionEntradaDetalle> GetById(int? id)
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = (from e in db.RemisionEntradaDetalle where e.Id == id select e);
                return query.ToList();
            }
        }

        public bool getCodigoRemision(string codigo)
        {

            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = (from e in db.RemisionEntrada where e.Codigo == codigo select e).FirstOrDefault(); ;


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

        public bool ProductoYRemision(int id, int producto)
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = db.SearchProductoYRemisionEntrada(id,producto).FirstOrDefault();
                // var query = (from e in db.RemisionEntradaDetalle where e.IdRemisionEntrada == id && e.IdProducto == producto select e);

                if (query==null)
                {
                    return false;
                }
                else
                {
                    return true;
                    
                }

            }
        }

        public List<InventarioFisico> GetByInventarioFisico(int idAlmacen,int idProducto)
        {
            using (indigoDBEntities db = new indigoDBEntities())
            {
                var query = (from e in db.InventarioFisico where e.IdAlmacen == idAlmacen && e.IdProducto == idProducto select e);
                return query.ToList();
            }
        }


    }
}