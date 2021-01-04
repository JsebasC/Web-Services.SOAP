using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
   
    //ADD PROVEEDOR
    public void agregarProveedor(string Codigo, string Nombre, string Direccion, string Telefono)
    {
        ServiceProveedor servicio = new ServiceProveedor();
        Proveedor p = new Proveedor();
        p.Codigo = Codigo;
        p.Nombre = Nombre;
        p.Direccion = Direccion;
        p.Telefono = Telefono;
        servicio.addEntity(p);
    }

  

    public void updateProveedor(int? id, string Codigo, string Nombre, string Direccion, string Telefono)
    {
        ServiceProveedor servicio = new ServiceProveedor();
        Proveedor p = new Proveedor();
        p.Id = (int)id;
        p.Codigo = Codigo;
        p.Nombre = Nombre;
        p.Direccion = Direccion;
        p.Telefono = Telefono;
        servicio.updateEntity(p);
    }
    public void deleteProveedor(int? id)
    {
        ServiceProveedor servicio = new ServiceProveedor();
        Proveedor p = new Proveedor();
        p.Id = (int)id;
        servicio.deleteEntity(id);


    }

    //ADD PRODUCTO
    public void agregarProducto(string Codigo, string Nombre, string Descripcion, decimal PrecioVenta, int StockMinimo, int StockMaximo)
    {
        ServiceProducto servicio = new ServiceProducto();
        Producto p = new Producto();
        p.Codigo = Codigo;
        p.Nombre = Nombre;
        p.Descripcion = Descripcion;
        p.PrecioVenta = PrecioVenta;
        p.StockMinimo = StockMinimo;
        p.StockMaximo = StockMaximo;
        servicio.addEntity(p);

    }

    public void updateProducto(int? id, string Codigo, string Nombre, string Descripcion, decimal PrecioVenta, int StockMinimo, int StockMaximo)
    {
        ServiceProducto servicio = new ServiceProducto();
        Producto p = new Producto();
        p.Id = (int) id;
        p.Codigo = Codigo;
        p.Nombre = Nombre;
        p.Descripcion = Descripcion;
        p.PrecioVenta = PrecioVenta;
        p.StockMinimo = StockMinimo;
        p.StockMaximo = StockMaximo;
        servicio.updateEntity(p);
    }

    public void deleteProducto(int? id)
    {
        ServiceProducto servicio = new ServiceProducto();
       // Producto p = new Producto();
        //p.Id = (int)id;
        servicio.deleteEntity(id);


    }

 
    public void agregarRemision(string Codigo, int idProveedor, int idAlmacen, int estado)
    {
        ServiceRemision servicio = new ServiceRemision();
        RemisionEntrada r = new RemisionEntrada();

        r.Codigo = Codigo;
        r.FechaDocumento = DateTime.Now; ;
        r.IdProveedor = idProveedor;
        r.IdAlmacen = idAlmacen;
        r.Estado = estado;
        servicio.addEntity(r);
    }

    public void updateRemision(int? id, string Codigo, int idProveedor, int idAlmacen, int estado)
    {
        ServiceRemision servicio = new ServiceRemision();
        RemisionEntrada r = new RemisionEntrada();
        r.Id = (int) id;
        r.Codigo = Codigo;
        r.FechaDocumento = DateTime.Now; ;
        r.IdProveedor = idProveedor;
        r.IdAlmacen = idAlmacen;
        r.Estado = estado;
        servicio.updateEntity(r);
    }

    public void deleteRemision(int? id)
    {
        ServiceRemision servicio = new ServiceRemision();

        servicio.deleteEntity(id);

    }



    public void agregarRemisionDetalle(int idRemisionEntrada, int idProducto, int cantidad)
    {
        ServiceRemisionDetalle service = new ServiceRemisionDetalle();
        RemisionEntradaDetalle rd = new RemisionEntradaDetalle();
        rd.IdRemisionEntrada = idRemisionEntrada;
        rd.IdProducto = idProducto;
        rd.Cantidad = cantidad;
        service.addEntity(rd);
    }

    public void updateRemisionDetalle(int? id, int idRemisionEntrada, int idProducto, int cantidad)
    {
        ServiceRemisionDetalle service = new ServiceRemisionDetalle();
        RemisionEntradaDetalle rd = new RemisionEntradaDetalle();
        rd.Id = (int)id;
        rd.IdRemisionEntrada = idRemisionEntrada;
        rd.IdProducto = idProducto;
        rd.Cantidad = cantidad;
        service.updateEntity(rd);
    }

    public void deleteRemisionDetalle(int? id)
    {
        ServiceRemisionDetalle service = new ServiceRemisionDetalle();
        service.deleteEntity(id);
    }

    public void inventarioFisico(int id, int Almacen, int producto,int cantidad)
    {
        ServiceInventario service = new ServiceInventario();
        InventarioFisico f = new InventarioFisico();
        f.Id = id;
        f.IdAlmacen = Almacen;
        f.IdProducto = producto;
        f.Cantidad = cantidad;
        service.updateEntity(f);
    }



    public List<Proveedor> selectProveedor()
    {
        ServiceProveedor servicio = new ServiceProveedor();



       // List<string[]> proveedores = new List<string[]>();
        List<Proveedor> proveedoresList = servicio.getEntitys();

        //foreach (Proveedor p in proveedoresList)
        //{
        //    string[] proveedor = new string[5];
        //    proveedor[0] = Convert.ToString(p.Id);
        //    proveedor[1] = p.Codigo;
        //    proveedor[2] = p.Nombre;
        //    proveedor[3] = p.Direccion; 
        //    proveedor[4] = p.Telefono;
        //    proveedores.Add(proveedor);
        //}

        return proveedoresList;


    }

    
}
