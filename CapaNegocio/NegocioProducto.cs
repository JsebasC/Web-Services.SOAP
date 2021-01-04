using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaNegocio
{
    public class NegocioProducto
    {

        DatoProducto metodos = new DatoProducto();
        public IEnumerable<SearchAllProductos1_Result> MostrarDatos()
        {
            return metodos.MostrarProductos();
        }

        public List<Producto> GetByIdProducto(int? id)
        {
            return metodos.GetByIdProducto(id);
        }

        public bool getCodigoProducto(string codigo)
        {
            return metodos.getCodigoProducto(codigo);
        }

    }
}
