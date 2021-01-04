using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
namespace CapaNegocio
{
    public class NegocioProveedor
    {

        DatoProveedor metodos = new DatoProveedor();
        public IEnumerable<SearchAllProveedores1_Result> MostrarDatos()
        {
            return metodos.MostrarProvedores();
        }

        public List<Proveedor> GetById(int? id)
        {
            return metodos.GetById(id);
        }

        public bool getCodigo(string codigo)
        {
            return metodos.getCodigoProveedor(codigo);
        }

    }
}
