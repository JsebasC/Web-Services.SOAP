using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaNegocio
{
    public class NegocioRemisionEntrada
    {

        DatoRemision metodosRemision = new DatoRemision();

        public IEnumerable<SearchAllRemisionEntrada1_Result> MostrarRemisionesEntrada()
        {
            return metodosRemision.MostrarRemisionesEntrada();
           
        }

        public List<RemisionEntrada> MostrarByIdRemision(int? id)
        {
            return metodosRemision.MostrarByIdRemision(id);
        }

        
        public List<RemisionEntrada> GetByIdRemision(int? id)
        {
            return metodosRemision.GetByIdRemision(id);
        }



        public IEnumerable<SearchAllRemisionEntradaDetalleByRIdRemisionEntrada_Result> MostrarRemisionDetalleByRemision(int? id)
        {
            return metodosRemision.MostrarRemisionDetalleByRemision(id);

        }

        public List<RemisionEntradaDetalle> getById(int? id)
        {
            return metodosRemision.GetById(id);
        }


        public bool getCodigoRemision(string codigo)
        {
            
            return metodosRemision.getCodigoRemision(codigo);
        }

        public bool ProductoYRemision(int id, int producto)
        {
            return metodosRemision.ProductoYRemision(id,producto);
        }

        public List<InventarioFisico> GetByInventarioFisico(int idAlmacen, int idProducto)
        {
            return metodosRemision.GetByInventarioFisico(idAlmacen, idProducto);
        }



    }


}
