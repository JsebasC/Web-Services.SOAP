using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ServiceRemisionDetalle
/// </summary>
public class ServiceRemisionDetalle : AbstractService<RemisionEntradaDetalle>
{
    public ServiceRemisionDetalle()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public override void addEntity(RemisionEntradaDetalle Entity)
    {
        entidades.RemisionEntradaDetalle.Add(Entity);
        entidades.SaveChanges();
    }

    public override void deleteEntity(int? id)
    {
        if (id != null)
        {
            var RemisionDetalleId = entidades.RemisionEntradaDetalle.Find(id);
            entidades.RemisionEntradaDetalle.Remove(RemisionDetalleId);
            entidades.SaveChanges();
        }
    }

    public override List<RemisionEntradaDetalle> getEntitys()
    {
        throw new NotImplementedException();
    }

    public override void updateEntity(RemisionEntradaDetalle Entity)
    {
        entidades.Entry(Entity).State = EntityState.Modified;
        entidades.SaveChanges();
    }


}