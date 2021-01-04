using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ServiceProveedor
/// </summary>
public class ServiceProveedor : AbstractService<Proveedor>
{
    public ServiceProveedor()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public override void addEntity(Proveedor Entity)
    {
        entidades.Proveedor.Add(Entity);
        entidades.SaveChanges();
    }


    public override void updateEntity(Proveedor Entity)
    {
       
        entidades.Entry(Entity).State = EntityState.Modified;
        entidades.SaveChanges();
    }


    public override void deleteEntity(int? id)
    {
        if (id != null)
        {
            var ProveedorId = entidades.Proveedor.Find(id);
            entidades.Proveedor.Remove(ProveedorId);
            entidades.SaveChanges();
        }
      
    }

    
    public override List<Proveedor> getEntitys()
    {
        return entidades.Proveedor.ToList<Proveedor>();
    }
    
}