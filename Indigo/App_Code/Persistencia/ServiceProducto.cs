using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ServiceProducto
/// </summary>
public class ServiceProducto : AbstractService<Producto>
{
    public ServiceProducto()
    {
       
    }

    public override void addEntity(Producto Entity)
    {
        entidades.Producto.Add(Entity);
        entidades.SaveChanges();
    }

    public override void deleteEntity(int? id)
    {
       
        if (id != null)
        {
            var ProductoId = entidades.Producto.Find(id);
            entidades.Producto.Remove(ProductoId);
            entidades.SaveChanges();
        }

    }

    public override List<Producto> getEntitys()
    {
        throw new NotImplementedException();
    }

    public override void updateEntity(Producto Entity)
    {
        entidades.Entry(Entity).State = EntityState.Modified;
        entidades.SaveChanges();
    }
}