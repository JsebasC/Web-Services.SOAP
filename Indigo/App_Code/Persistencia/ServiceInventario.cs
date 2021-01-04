using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ServiceInventario
/// </summary>
public class ServiceInventario : AbstractService<InventarioFisico>
{
    public ServiceInventario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public override void addEntity(InventarioFisico Entity)
    {
       
    }

    public override void deleteEntity(int? id)
    {
       
    }

    public override List<InventarioFisico> getEntitys()
    {
        throw new NotImplementedException();
    }

    public override void updateEntity(InventarioFisico Entity)
    {
        entidades.Entry(Entity).State = EntityState.Modified;
        entidades.SaveChanges();
    }
}