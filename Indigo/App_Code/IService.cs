using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{


	//AGREGAR PROVEEDOR
	[OperationContract]
	void agregarProveedor(string Codigo, string Nombre, string Direccion, string Telefono);

	[OperationContract]
	void updateProveedor(int? id,string Codigo, string Nombre, string Direccion, string Telefono);
	[OperationContract]
	List<Proveedor> selectProveedor();



	//AGREGAR PRODUCTO

	[OperationContract]
	void agregarProducto(string Codigo, string Nombre, string Descripcion, decimal PrecioVenta, int StockMinimo, int StockMaximo);

	[OperationContract]
	void updateProducto(int ? id, string Codigo, string Nombre, string Descripcion, decimal PrecioVenta, int StockMinimo, int StockMaximo);

	[OperationContract]
	void deleteProducto(int ? id);

	//AGREGAR REMISION

	[OperationContract]
	void agregarRemision(string Codigo, int idProveedor, int idAlmacen,int estado);

	[OperationContract]
	void updateRemision(int? id,string Codigo, int idProveedor, int idAlmacen, int estado);

	[OperationContract]
	void deleteRemision(int? id);

	//AGREGAR REMISION DETALLE

	[OperationContract]
	void agregarRemisionDetalle(int idRemisionEntrada, int idProducto,int cantidad);

	[OperationContract]
	void updateRemisionDetalle(int? id,int idRemisionEntrada, int idProducto, int cantidad);

	[OperationContract]
	void deleteRemisionDetalle(int? id);

	[OperationContract]
	void inventarioFisico(int id, int Almacen,int producto,int cantidad);



}

