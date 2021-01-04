using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ServiceRemision
/// </summary>
public class ServiceRemision : AbstractService<RemisionEntrada>
{
    public ServiceRemision()
    {
    
    }

    public override void addEntity(RemisionEntrada Entity)
    {
        entidades.RemisionEntrada.Add(Entity);
        entidades.SaveChanges();
    }

    public override void deleteEntity(int? id)
    {
        if (id != null)
        {
            var RemisionEntradaId = entidades.RemisionEntrada.Find(id);
            entidades.RemisionEntrada.Remove(RemisionEntradaId);
            entidades.SaveChanges();
        }
    }

    public override List<RemisionEntrada> getEntitys()
    {
        throw new NotImplementedException();
    }

    public override void updateEntity(RemisionEntrada Entity)
    {
        entidades.Entry(Entity).State = EntityState.Modified;
        entidades.SaveChanges();
    }
}