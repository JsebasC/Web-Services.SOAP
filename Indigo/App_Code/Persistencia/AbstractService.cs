using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de AbstractService
/// </summary>
public abstract class AbstractService<T>
{

    protected indigoDBEntities entidades;
    public AbstractService()
    {
        Init();
    }

    private void Init()
    {
        entidades = new indigoDBEntities();
    }

    public abstract void addEntity(T Entity);
    public abstract void updateEntity(T Entity);
    public abstract void deleteEntity(int? id);

    public abstract List<T> getEntitys();




}