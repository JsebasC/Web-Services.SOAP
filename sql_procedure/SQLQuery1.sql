select * from Proveedor
select * from Producto
select * from RemisionEntrada
select * from RemisionEntradaDetalle

EXEC SearchAllProveedores
EXEC SearchAllProductos
EXEC SearchAllRemisionEntrada1

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
	AS
		BEGIN
			SELECT RemisionEntradaDetalle.Id,RemisionEntrada.Codigo As RemisionCodigo, Producto.Codigo As CodigoProducto,RemisionEntrada.Id As idRemision,Producto.Id AS idProducto, Producto.Nombre
			FROM RemisionEntradaDetalle
			INNER JOIN RemisionEntrada ON  RemisionEntradaDetalle.IdRemisionEntrada = RemisionEntrada.id 
			INNER JOIN Producto ON  RemisionEntradaDetalle.IdProducto = Producto.Id
			WHERE RemisionEntrada.Id = 2
		END

