select * from Proveedor
select * from Producto
select * from RemisionEntrada
	select * from RemisionEntradaDetalle
select * from RemisionEntrada where RemisionEntrada.Codigo = 1

delete  from Proveedor Where Proveedor.id>=7

EXEC SearchAllProveedores
EXEC SearchAllProductos
EXEC SearchAllRemisionEntrada1

EXEC SearchAllRemisionEntradaD 2
EXEC SearchAllRemisionEntradaDetalleByRIdRemisionEntrada 1

CREATE PROCEDURE SearchAllRemisionEntrada1
	AS
		BEGIN
			SELECT RemisionEntrada.Id,RemisionEntrada.Codigo,Proveedor.Nombre As Provedor,Almacen.Nombre As Almacen, /* RemisionEntrada.IdProveedor,RemisionEntrada.IdAlmacen,*/ CASE RemisionEntrada.Estado 
				WHEN 1 THEN 'Registrado'	
				WHEN 2 THEN 'Confirmada'
				WHEN 3 THEN 'Anulada' 
			END  AS 'Estado'
			FROM RemisionEntrada
			INNER JOIN Proveedor ON RemisionEntrada.IdProveedor = Proveedor.Id
			INNER JOIN Almacen ON RemisionEntrada.IdAlmacen = Almacen.Id;

		END

		
CREATE PROCEDURE SearchAllRemisionEntradaDetalle
	@idEntradaDetalle int
	AS
		BEGIN
			SELECT RemisionEntradaDetalle.Id,RemisionEntrada.Codigo As RemisionCodigo,RemisionEntrada.Id As idRemision, Producto.Codigo As CodigoProducto,Producto.Id AS idProducto
			FROM RemisionEntradaDetalle
			INNER JOIN RemisionEntrada ON  RemisionEntradaDetalle.IdRemisionEntrada = RemisionEntrada.id 
			INNER JOIN Producto ON  RemisionEntradaDetalle.IdProducto = Producto.Id		
			WHERE RemisionEntrada.Id = @idEntradaDetalle;
		END


CREATE PROCEDURE SearchAllRemisionEntradaDetalleByRemision
	@idEntradaDetalle int
	AS
		BEGIN
			SELECT RemisionEntradaDetalle.Id As idRemision,RemisionEntradaDetalle.IdProducto, RemisionEntradaDetalle.Cantidad
			FROM RemisionEntradaDetalle
			INNER JOIN RemisionEntrada ON  RemisionEntradaDetalle.IdRemisionEntrada = RemisionEntrada.id 
			WHERE RemisionEntradaDetalle.IdRemisionEntrada = @idEntradaDetalle;
		END



EXEC SearchAllRemisionEntradaDetalleByRIdRemisionEntrada 2

CREATE PROCEDURE SearchAllRemisionEntradaDetalleByRIdRemisionEntrada
	@idEntradaDetalle int
	AS
		BEGIN
			select * from RemisionEntradaDetalle where RemisionEntradaDetalle.IdRemisionEntrada =  @idEntradaDetalle;
		END


EXEC SearchProductoYRemisionEntrada 1,3

CREATE PROCEDURE SearchProductoYRemisionEntrada
	@idEntradaDetalle int,
	@idProducto int
	AS
		BEGIN
		
		
		
		END

		--

	

	EXEC Report1;
		
		
SELECT Producto.Codigo,Producto.Nombre As Producto, COUNT(*) product_count FROM InventarioFisico INNER JOIN Producto ON InventarioFisico.IdProducto = Producto.Id GROUP BY 
 Producto.Codigo,Producto.Nombre ORDER BY product_count DESC;


 SELECT Producto.Codigo,Producto.Nombre As Producto, COUNT(*) product_count FROM InventarioFisico INNER JOIN Producto ON InventarioFisico.IdProducto = Producto.Id
 INNER JOIN
 INNER JOIN RemisionEntrada ON RemisionEntrada.Id = P GROUP BY 
 Producto.Codigo,Producto.Nombre ORDER BY product_count DESC;


CREATE PROCEDURE Report1
	AS
		BEGIN
			SELECT Proveedor.Nombre,RemisionEntradaDetalle.Cantidad,
			COUNT(*) total
			FROM RemisionEntrada		
			INNER JOIN Proveedor ON RemisionEntrada.IdProveedor = Proveedor.id		
			INNER JOIN RemisionEntradaDetalle ON RemisionEntrada.Id = RemisionEntradaDetalle.IdRemisionEntrada
			GROUP BY 
			Proveedor.Nombre,RemisionEntradaDetalle.Cantidad
			ORDER BY total DESC;

		
		END

		select * from InventarioFisico;


CREATE PROCEDURE InventarioFisico
	AS
		BEGIN
			SELECT Proveedor.Nombre As Provedor,Producto.Codigo As Codigo_Producto,Producto.Nombre As Nombre_Producto, RemisionEntradaDetalle.Cantidad
			FROM RemisionEntrada
			INNER JOIN Proveedor ON RemisionEntrada.IdProveedor = Proveedor.id
			INNER JOIN RemisionEntradaDetalle ON RemisionEntrada.Id = RemisionEntradaDetalle.idRemisionEntrada
			INNER JOIN Producto ON RemisionEntradaDetalle.IdProducto = Producto.Id;
		END

		--Código del producto, Nombre del Producto y Cantidad de Almacene.

CREATE PROCEDURE SearchInventarioFisico
	AS
		BEGIN
			SELECT Producto.Codigo, Almacen.Nombre As Almacen,Producto.Nombre As Producto
			FROM InventarioFisico
			INNER JOIN Producto ON InventarioFisico.IdProducto = Producto.Id
			INNER JOIN Almacen ON InventarioFisico.IdAlmacen = Almacen.Id
			WHERE InventarioFisico.Cantidad > 0
		END


	EXEC SearchInventarioFisicoCantidad;
CREATE PROCEDURE SearchInventarioFisicoCantidad
	AS
		BEGIN
		SELECT Producto.Codigo,Producto.Nombre As Producto, COUNT(*) product_count FROM InventarioFisico INNER JOIN Producto ON InventarioFisico.IdProducto = Producto.Id GROUP BY 
		Producto.Codigo,Producto.Nombre ORDER BY product_count DESC;
		END

			select * from InventarioFisico;

SELECT Producto.Codigo,Producto.Nombre As Producto, COUNT(*) product_count FROM InventarioFisico INNER JOIN Producto ON InventarioFisico.IdProducto = Producto.Id GROUP BY 
 Producto.Codigo,Producto.Nombre ORDER BY product_count DESC;

