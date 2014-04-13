/*
PROCEDIMIENTOS ALMACENADOS
*/

USE Autos
GO

/*
CONTROL DE ERRORES
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_retornarError')
	DROP PROCEDURE sp_retornarError 
GO
CREATE PROCEDURE sp_retornarError
AS
BEGIN
	IF ERROR_NUMBER() IS NULL
		RETURN
	DECLARE
		@ErrorMessage	nvarchar(4000),
		@ErrorNumber	int,
		@ErrorSeverity	int,
		@ErrorState		int,
		@ErrorLine		int,
		@ErrorProcedure	nvarchar(200)
	SELECT
		@ErrorNumber=ERROR_NUMBER(),
		@ErrorSeverity=ERROR_SEVERITY(),
		@ErrorState=ERROR_STATE(),
		@ErrorLine=ERROR_LINE(),
		@ErrorProcedure=ISNULL(ERROR_PROCEDURE(),'-'),
		@ErrorMessage=ERROR_MESSAGE()
	RAISERROR
		(
		@ErrorMessage,
		@ErrorSeverity,
		1,
		@ErrorNumber,
		@ErrorSeverity,
		@ErrorState,
		@ErrorProcedure,
		@ErrorLine
		)
END
GO
/*
2014-03-04
LOGIN USUARIO

*/


IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_LoginUsuario')
	DROP PROCEDURE sp_LoginUsuario
GO
CREATE PROCEDURE sp_LoginUsuario
(
	@usuario varchar(30),
	@clave varchar(20)
)
AS
BEGIN
	BEGIN TRY

	SELECT 
		id_personal,
		nombres,
		dni,
		ap_paterno,
		ap_materno,
		direccion,
		telefono,
		celular,
		estado,
		cargo,
		usuario
		FROM Personal 
		WHERE usuario=@usuario 
		AND clave=@clave;

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarAccesoUsuario')
	DROP PROCEDURE sp_ListarAccesoUsuario
GO
CREATE PROCEDURE sp_ListarAccesoUsuario
(
	@id_personal smallint
)
AS
BEGIN
	BEGIN TRY

	SELECT 
		PS.id_personal,
		M.id_menu,
		S.id_submenu,
		M.descripcion AS 'menu',
		S.descripcion AS 'submenu',
		PS.estado,
		PS.nuevo,
		PS.eliminar,
		PS.modificar,
		PS.buscar
	FROM Personal_SubMenu PS
	INNER JOIN SubMenu S ON (PS.id_submenu=S.id_submenu AND PS.id_menu=S.id_menu)
	INNER JOIN Menu M ON S.id_menu=M.id_menu
	WHERE PS.id_personal=@id_personal 
	ORDER BY M.id_menu,S.id_submenu
	--AND PS.estado=1 -- Removed 2014.03.13
		
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarUsuario')
	DROP PROCEDURE sp_ListarUsuario
GO
CREATE PROCEDURE sp_ListarUsuario
AS
BEGIN
	BEGIN TRY

	SELECT 
		P.id_personal,
		P.nombres + ' ' + P.ap_paterno + ' ' + P.ap_materno AS 'nombreCompleto',
		P.usuario,
		P.estado
	FROM Personal P
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*

	2014.03.12 - 2014.03.13

*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarPermisos')
	DROP PROCEDURE sp_RegistrarPermisos
GO
CREATE PROCEDURE sp_RegistrarPermisos
(
	@id_personal	smallint,
	@cargo 			char(1)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(1,1,@id_personal,1,1,1,1,1)--Iniciar Sesión
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(1,2,@id_personal,1,1,1,1,1)--Tipo de Cambio
				INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(1,3,@id_personal,1,1,1,1,1)--Empresa
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(1,4,@id_personal,1,1,1,1,1)--Cerrar Sistema
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(1,5,@id_personal,1,1,1,1,1)--Cerrar Sistema

			IF @cargo='A' 
				BEGIN
					INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
						VALUES(2,1,@id_personal,1,1,1,1,1)--Personal "A"
					INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
						VALUES(2,2,@id_personal,1,1,1,1,1)--Asignar Permisos "A"
				END
			ELSE
				BEGIN
					INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
						VALUES(2,1,@id_personal,0,1,1,1,1)--Personal "V"					
					INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
						VALUES(2,2,@id_personal,0,1,1,1,1)--Asignar Permisos "V"
				END
			
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,3,@id_personal,1,1,1,1,1)--Clientes
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,4,@id_personal,1,1,1,1,1)--Línea
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,5,@id_personal,1,1,1,1,1)--Marca
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,6,@id_personal,1,1,1,1,1)--Producto
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,7,@id_personal,1,1,1,1,1)--Proveedor
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,8,@id_personal,1,1,1,1,1)--Unidad
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,9,@id_personal,1,1,1,1,1)--Actualizar Precios
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,10,@id_personal,1,1,1,1,1)--Vehículo
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,11,@id_personal,1,1,1,1,1)--Moneda
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,12,@id_personal,1,1,1,1,1)--Sucursal
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,13,@id_personal,1,1,1,1,1)--Almacén
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,14,@id_personal,1,1,1,1,1)--Precio
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,15,@id_personal,1,1,1,1,1)--Conceptos
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(2,16,@id_personal,1,1,1,1,1)--Tipo de Documento

			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(3,1,@id_personal,1,1,1,1,1)--Orden de Compra
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(3,2,@id_personal,1,1,1,1,1)--Nota de Crédito Proveedor
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(3,3,@id_personal,1,1,1,1,1)--Nota de Débito Proveedor
								
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(4,1,@id_personal,1,1,1,1,1)--Orden de Venta
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(4,2,@id_personal,1,1,1,1,1)--Facturación
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(4,3,@id_personal,1,1,1,1,1)--Nota de Crédito Cliente
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(4,4,@id_personal,1,1,1,1,1)--Nota de Débito Cliente
								
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(5,1,@id_personal,1,1,1,1,1)--Resumen de Caja
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(5,2,@id_personal,1,1,1,1,1)--Cuentas por Cobrar
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(5,3,@id_personal,1,1,1,1,1)--Cuentas por Pagar
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(5,4,@id_personal,1,1,1,1,1)--Canje de Letras	
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(5,5,@id_personal,1,1,1,1,1)--Gastos				

			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(6,1,@id_personal,1,1,1,1,1)--Ingreso al Kardex
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(6,2,@id_personal,1,1,1,1,1)--Movimiento de Kardex
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(6,3,@id_personal,1,1,1,1,1)--Stock
				
			INSERT INTO Personal_SubMenu(id_menu,id_submenu,id_personal,estado,nuevo,eliminar,modificar,buscar)
				VALUES(7,1,@id_personal,1,1,1,1,1)--Registro de Ventas
								
		COMMIT TRANSACTION	
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarPersonalSubMenu')
	DROP PROCEDURE sp_ModificarPersonalSubMenu
GO
CREATE PROCEDURE sp_ModificarPersonalSubMenu
(
	@id_menu		smallint,
	@id_submenu		smallint,
	@id_personal	smallint,
	@estado			bit,
	@nuevo			bit,
	@eliminar		bit,
	@modificar		bit,
	@buscar			bit
)
AS
BEGIN
	BEGIN TRY
		UPDATE Personal_SubMenu
			SET
				estado=@estado,
				nuevo=@nuevo,
				eliminar=@eliminar,
				modificar=@modificar,
				buscar=@buscar
			WHERE
				id_menu=@id_menu AND
				id_submenu=@id_submenu AND
				id_personal=@id_personal
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarPersonalSubMenu')
	DROP PROCEDURE sp_ListarPersonalSubMenu
GO
CREATE PROCEDURE sp_ListarPersonalSubMenu
(
	@id_menu		smallint,
	@id_submenu		smallint,
	@id_personal	smallint
)
AS
BEGIN
	BEGIN TRY
		SELECT	id_menu,
				id_submenu,
				id_personal,
				estado,
				nuevo,
				eliminar,
				modificar,
				buscar
		FROM Personal_SubMenu 
		WHERE id_menu=@id_menu AND id_submenu=@id_submenu AND id_personal=@id_personal
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA EMPRESA							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarEmpresa')
	DROP PROCEDURE sp_RegistrarEmpresa
GO
CREATE PROCEDURE sp_RegistrarEmpresa
(
	@id_empresa		tinyint output,
	@ruc			char(11),
	@razon_social	varchar(150),
	@direccion 		varchar(150),
	@telefono 		char(9)	
)
AS
BEGIN
	BEGIN TRY

		--IF (@id_empresa IS NOT NULL) AND EXISTS(SELECT * FROM Empresa WHERE id_empresa=@id_empresa)
		--	RAISERROR('La empresa ingresada ya se encuentra registrada, verificar datos',16,1)
		--IF (@ruc IS NOT NULL) AND EXISTS(SELECT * FROM Empresa WHERE ruc=@ruc)
		--	RAISERROR('El ruc ingresado ya se encuentra registrado, verificar datos',16,1)
		BEGIN TRANSACTION --Modified 2014.03.13
			INSERT INTO Empresa(
								ruc,
								razon_social,
								direccion,
								telefono
							)
					VALUES(
								@ruc,
								@razon_social,
								@direccion,
								@telefono
							)
			SELECT @id_empresa=IDENT_CURRENT('Empresa')
--			EXEC sp_RegistrarPermisos @id_personal,@cargo
			SELECT @id_empresa
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarEmpresa')
	DROP PROCEDURE sp_ModificarEmpresa
GO
CREATE PROCEDURE sp_ModificarEmpresa
(
	@id_empresa		tinyint,
	@ruc			char(11),
	@razon_social	varchar(150),
	@direccion 		varchar(150),
	@telefono 		char(9)
)
AS
BEGIN
	BEGIN TRY

		--IF (@id_empresa IS NOT NULL) AND EXISTS(SELECT * FROM Empresa WHERE id_empresa=@id_empresa)
		--	RAISERROR('La empresa ingresada ya se encuentra registrada, verificar datos',16,1)
		--IF (@ruc IS NOT NULL) AND EXISTS(SELECT * FROM Empresa WHERE ruc=@ruc)
		--	RAISERROR('El ruc ingresado ya se encuentra registrado, verificar datos',16,1)

		UPDATE Empresa
			SET 
				ruc=@ruc,
				razon_social = @razon_social,
				direccion=@direccion,
				telefono=@telefono
			WHERE
				id_empresa=@id_empresa

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarEmpresa')
	DROP PROCEDURE sp_ListarEmpresa
GO
CREATE PROCEDURE sp_ListarEmpresa
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Empresa
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarEmpresa')
	DROP PROCEDURE sp_EliminarEmpresa
GO
CREATE PROCEDURE sp_EliminarEmpresa
(
	@id_empresa	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Empresa WHERE id_empresa=@id_empresa

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA PERSONAL							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarPersonal')
	DROP PROCEDURE sp_RegistrarPersonal
GO
CREATE PROCEDURE sp_RegistrarPersonal
(
	@id_personal	tinyint output,
	@nombres		varchar(50),
	@ap_paterno		varchar(50),
	@ap_materno		varchar(50),
	@dni 			char(8),
	@direccion 		varchar(100),
	@telefono 		char(9),
	@celular 		char(10),
	@estado 		char(1),
	@cargo 			char(1),
	@usuario 		varchar(30),
	@clave			varchar(20)
)
AS
BEGIN
	BEGIN TRY

		IF (@usuario IS NOT NULL) AND EXISTS(SELECT * FROM Personal WHERE usuario=@usuario)
			RAISERROR('El usuario ingresado ya se encuentra registrado, verificar datos',16,1)
		IF (@dni IS NOT NULL) AND EXISTS(SELECT * FROM Personal WHERE dni=@dni)
			RAISERROR('El dni ingresado ya se encuentra registrado, verificar datos',16,1)
		BEGIN TRANSACTION --Modified 2014.03.13
			INSERT INTO Personal(
								nombres,
								ap_paterno,
								ap_materno,
								dni,
								direccion,
								telefono,
								celular,
								estado,
								cargo,
								usuario,
								clave
							)
					VALUES(
								@nombres,
								@ap_paterno,
								@ap_materno,
								@dni,
								@direccion,
								@telefono,
								@celular,
								@estado,
								@cargo,
								@usuario,
								@clave
							)
			SELECT @id_personal=IDENT_CURRENT('Personal')
			EXEC sp_RegistrarPermisos @id_personal,@cargo
			SELECT @id_personal
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarPersonal')
	DROP PROCEDURE sp_ModificarPersonal
GO
CREATE PROCEDURE sp_ModificarPersonal
(
	@id_personal	tinyint,
	@nombres		varchar(50),
	@ap_paterno		varchar(50),
	@ap_materno		varchar(50),
	@dni 			char(8),
	@direccion 		varchar(100),
	@telefono 		char(9),
	@celular 		char(10),
	@estado 		char(1),
	@cargo 			char(1),
	@usuario 		varchar(30),
	@clave			varchar(20)
)
AS
BEGIN
	BEGIN TRY

		IF EXISTS(SELECT * FROM Personal WHERE usuario=@usuario AND id_personal<>@id_personal)
			RAISERROR('El usuario ingresado ya se encuentra registrado, verificar datos',16,1)
		IF EXISTS(SELECT * FROM Personal WHERE dni=@dni AND id_personal<>@id_personal)
			RAISERROR('El dni ingresado ya se encuentra registrado, verificar datos',16,1)

		UPDATE Personal 
			SET 
				nombres=@nombres,
				ap_paterno=@ap_paterno,
				ap_materno=@ap_materno,
				dni=@dni,
				direccion=@direccion,
				telefono=@telefono,
				celular=@celular,
				estado=@estado,
				cargo=@cargo,
				usuario=@usuario,
				clave=@clave
			WHERE
				id_personal=@id_personal

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarPersonal')
	DROP PROCEDURE sp_ListarPersonal
GO
CREATE PROCEDURE sp_ListarPersonal
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Personal
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarPersonalXID')
	DROP PROCEDURE sp_ListarPersonalXID
GO
CREATE PROCEDURE sp_ListarPersonalXID
(
	@id_personal	tinyint
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Personal WHERE id_personal=@id_personal
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarPersonal')
	DROP PROCEDURE sp_EliminarPersonal
GO
CREATE PROCEDURE sp_EliminarPersonal
(
	@id_personal	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Personal WHERE id_personal=@id_personal

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA LINEA							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarLinea')
	DROP PROCEDURE sp_RegistrarLinea
GO
CREATE PROCEDURE sp_RegistrarLinea
(
	@id_linea    	smallint output,
	@descripcion	varchar(100)
)
AS
BEGIN
	BEGIN TRY

		IF (@descripcion IS NOT NULL) AND EXISTS(SELECT * FROM Linea WHERE descripcion=@descripcion)
			RAISERROR('La Linea ingresada ya se encuentra registrada, verificar datos',16,1)
		

		INSERT INTO Linea(
								descripcion
							)
					VALUES(
								@descripcion
							)
		SELECT @id_linea=IDENT_CURRENT('Linea')
		SELECT @id_linea
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarLinea')
	DROP PROCEDURE sp_ModificarLinea
GO
CREATE PROCEDURE sp_ModificarLinea
(
	@id_linea		smallint,
	@descripcion	varchar(100)
)
AS
BEGIN
	BEGIN TRY

		IF (@descripcion IS NOT NULL) AND EXISTS(SELECT * FROM Linea WHERE descripcion=@descripcion AND id_linea<>@id_linea)
			RAISERROR('La Linea ingresada ya se encuentra registrada, verificar datos',16,1)
		

		UPDATE Linea 
			SET 
				descripcion=@descripcion
				
			WHERE
				id_linea=@id_linea

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarLinea')
	DROP PROCEDURE sp_ListarLinea
GO
CREATE PROCEDURE sp_ListarLinea
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Linea
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarLinea')
	DROP PROCEDURE sp_EliminarLinea
GO
CREATE PROCEDURE sp_EliminarLinea
(
	@id_linea	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Linea WHERE id_linea=@id_linea

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA MARCA							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarMarca')
	DROP PROCEDURE sp_RegistrarMarca
GO
CREATE PROCEDURE sp_RegistrarMarca
(
	@id_marca    	smallint output,
	@descripcion	varchar(100)
)
AS
BEGIN
	BEGIN TRY

		IF (@descripcion IS NOT NULL) AND EXISTS(SELECT * FROM Marca WHERE descripcion=@descripcion)
			RAISERROR('La Marca ingresada ya se encuentra registrada, verificar datos',16,1)
		

		INSERT INTO Marca(
								descripcion
							)
					VALUES(
								@descripcion
							)
		SELECT @id_marca=IDENT_CURRENT('Marca')
		SELECT @id_marca
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarMarca')
	DROP PROCEDURE sp_ModificarMarca
GO
CREATE PROCEDURE sp_ModificarMarca
(
	@id_marca		smallint,
	@descripcion	varchar(100)
)
AS
BEGIN
	BEGIN TRY

		IF (@descripcion IS NOT NULL) AND EXISTS(SELECT * FROM Marca WHERE descripcion=@descripcion AND id_marca<>@id_marca)
			RAISERROR('La Marca ingresada ya se encuentra registrada, verificar datos',16,1)
		

		UPDATE Marca 
			SET 
				descripcion=@descripcion
				
			WHERE
				id_marca=@id_marca

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarMarca')
	DROP PROCEDURE sp_ListarMarca
GO
CREATE PROCEDURE sp_ListarMarca
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Marca
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarMarca')
	DROP PROCEDURE sp_EliminarMarca
GO
CREATE PROCEDURE sp_EliminarMarca
(
	@id_marca	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Marca WHERE id_marca=@id_marca

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO


/*
*************************************************************
*															*
*					TABLA MONEDA							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarMoneda')
	DROP PROCEDURE sp_RegistrarMoneda
GO
CREATE PROCEDURE sp_RegistrarMoneda
(
	@id_moneda    	tinyint output,
	@descripcion	varchar(20),
	@simbolo		char(4)
)
AS
BEGIN
	BEGIN TRY

		IF (@descripcion IS NOT NULL) AND EXISTS(SELECT * FROM Moneda WHERE descripcion=@descripcion)
			RAISERROR('La Moneda ingresada ya se encuentra registrada, verificar datos',16,1)
		IF (@simbolo IS NOT NULL) AND EXISTS(SELECT * FROM Moneda WHERE simbolo=@simbolo)
			RAISERROR('El Simbolo ingresado ya se encuentra registrado, verificar datos',16,1)
		

		INSERT INTO Moneda(
								descripcion,
								simbolo
							)
					VALUES(
								@descripcion,
								@simbolo
							)
		SELECT @id_moneda=IDENT_CURRENT('Moneda')
		SELECT @id_moneda
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarMoneda')
	DROP PROCEDURE sp_ModificarMoneda
GO
CREATE PROCEDURE sp_ModificarMoneda
(
	@id_moneda		tinyint,
	@descripcion	varchar(20),
	@simbolo		char(4)
)
AS
BEGIN
	BEGIN TRY

		IF (@descripcion IS NOT NULL) AND EXISTS(SELECT * FROM Moneda WHERE descripcion=@descripcion AND id_moneda<>@id_moneda)--Modified 2014.03.24
			RAISERROR('La Moneda ingresada ya se encuentra registrada, verificar datos',16,1)
		IF (@simbolo IS NOT NULL) AND EXISTS(SELECT * FROM Moneda WHERE simbolo=@simbolo AND id_moneda<>@id_moneda)--Modified 2014.03.24
			RAISERROR('El Simbolo ingresado ya se encuentra registrado, verificar datos',16,1)
		

		UPDATE Moneda 
			SET 
				descripcion=@descripcion,
				simbolo=@simbolo
				
			WHERE
				id_moneda=@id_moneda

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarMoneda')
	DROP PROCEDURE sp_ListarMoneda
GO
CREATE PROCEDURE sp_ListarMoneda
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Moneda
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarMoneda')
	DROP PROCEDURE sp_EliminarMoneda
GO
CREATE PROCEDURE sp_EliminarMoneda
(
	@id_moneda	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Moneda WHERE id_moneda=@id_moneda

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA UBIGEO							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarDistritro')
	DROP PROCEDURE sp_ListarDistritro
GO
CREATE PROCEDURE sp_ListarDistritro
(
	@Provicia char(4)
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Ubigeo where id_ubigeo like @Provicia+'%' AND id_ubigeo <> @Provicia+'00'
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarProvicia')
	DROP PROCEDURE sp_ListarProvicia
GO
CREATE PROCEDURE sp_ListarProvicia
(
	@Depatamento char(2)
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Ubigeo where id_ubigeo like @Depatamento+'%00' AND id_ubigeo <> @Depatamento+'0000'
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarUbigeo')
	DROP PROCEDURE sp_ListarUbigeo
GO
CREATE PROCEDURE sp_ListarUbigeo
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Ubigeo where id_ubigeo like '%0000'
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarUbigeo')
	DROP PROCEDURE sp_EliminarUbigeo
GO

/*
*************************************************************
*															*
*					TABLA SUCURSAL							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarSucursal')
	DROP PROCEDURE sp_RegistrarSucursal
GO
CREATE PROCEDURE sp_RegistrarSucursal
(
	@id_sucursal   	tinyint output,
	@descripcion	varchar(50),
	@direccion		varchar(100),
	@telefono		char(9)
)
AS
BEGIN
	BEGIN TRY


		IF (@direccion IS NOT NULL) AND EXISTS(SELECT * FROM Sucursal WHERE direccion=@direccion)--Added 2014.03.24
			RAISERROR('La dirección ingresada para su sucursal ya se encuentra registrada, verificar datos',16,1)

		INSERT INTO Sucursal(
								descripcion,
								direccion,
								telefono
							)
					VALUES(
								@descripcion,
								@direccion,
								@telefono
							)
		SELECT @id_sucursal=IDENT_CURRENT('Sucursal')
		SELECT @id_sucursal
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarSucursal')
	DROP PROCEDURE sp_ModificarSucursal
GO
CREATE PROCEDURE sp_ModificarSucursal
(
	@id_sucursal	tinyint,
	@descripcion	varchar(50),
	@direccion		varchar(100),
	@telefono		char(9)
)
AS
BEGIN
	BEGIN TRY

		IF (@direccion IS NOT NULL) AND EXISTS(SELECT * FROM Sucursal WHERE direccion=@direccion AND id_sucursal<>@id_sucursal)--Added 2014.03.24
			RAISERROR('La dirección ingresada para su sucursal ya se encuentra registrada, verificar datos',16,1)
		

		UPDATE Sucursal
			SET 
				descripcion=@descripcion,
				direccion=@direccion,
				telefono=@telefono
			WHERE
				id_sucursal=@id_sucursal

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarSucursal')
	DROP PROCEDURE sp_ListarSucursal
GO
CREATE PROCEDURE sp_ListarSucursal
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Sucursal
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO


IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarSucursal')
	DROP PROCEDURE sp_EliminarSucursal
GO
CREATE PROCEDURE sp_EliminarSucursal
(
	@id_sucursal	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Sucursal WHERE id_sucursal=@id_sucursal

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO


/*
*************************************************************
*															*
*					TABLA TIPO DOCUMENTO							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarTipoDocumento')
	DROP PROCEDURE sp_RegistrarTipoDocumento
GO
CREATE PROCEDURE sp_RegistrarTipoDocumento
(
	@id_tipodocumento   	char(3),
	@abreviatura			char(4),
	@descripcion			varchar(50)
	
)
AS
BEGIN
	BEGIN TRY

		--IF (@departamento IS NOT NULL) AND EXISTS(SELECT * FROM Ubigeo WHERE departamento=@departamento)
		--	RAISERROR('El departamento ingresado ya se encuentra registrado, verificar datos',16,1)
		

		INSERT INTO TipoDocumento(
								id_tipodocumento,
								abreviatura,
								descripcion								
							)
					VALUES(
								@id_tipodocumento,
								@abreviatura,
								@descripcion
							)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarTipoDocumento')
	DROP PROCEDURE sp_ModificarTipoDocumento
GO
CREATE PROCEDURE sp_ModificarTipoDocumento
(
	@id_tipodocumento	char(3),
	@abreviatura		char(4),
	@descripcion	varchar(50)	
)
AS
BEGIN
	BEGIN TRY

		--IF (@departamento IS NOT NULL) AND EXISTS(SELECT * FROM Ubigeo WHERE departamento=@departamento)
		--	RAISERROR('El departamento ingresado ya se encuentra registrado, verificar datos',16,1)
		

		UPDATE TipoDocumento
			SET 
				abreviatura=@abreviatura,
				descripcion=@descripcion
				
			WHERE
				id_tipodocumento=@id_tipodocumento

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarTipoDocumento')
	DROP PROCEDURE sp_ListarTipoDocumento
GO
CREATE PROCEDURE sp_ListarTipoDocumento
AS
BEGIN
	BEGIN TRY
		SELECT * FROM TipoDocumento
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO



IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarTipoDocumento')
	DROP PROCEDURE sp_EliminarTipoDocumento
GO
CREATE PROCEDURE sp_EliminarTipoDocumento
(
	@id_tipodocumento	char(3)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM TipoDocumento WHERE id_tipodocumento=@id_tipodocumento

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_BuscarIdTipoDocumento')
	DROP PROCEDURE sp_BuscarIdTipoDocumento
GO
CREATE PROCEDURE sp_BuscarIdTipoDocumento
(
	@id_TipoDocumento	tinyint out
	)
AS
BEGIN
	BEGIN TRY
		SELECT @id_TipoDocumento =max(autonumber) FROM TipoDocumento
		IF @id_TipoDocumento is null	
SET @id_TipoDocumento = 1
ELSE
SELECT @id_TipoDocumento = @id_TipoDocumento + 1
return @id_TipoDocumento
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA UNIDAD							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarUnidad')
	DROP PROCEDURE sp_RegistrarUnidad
GO
CREATE PROCEDURE sp_RegistrarUnidad
(
	@id_unidad   	smallint output,
	@abreviatura	char(4),
	@descripcion	varchar(50)
	
)
AS
BEGIN
	BEGIN TRY

		IF (@descripcion IS NOT NULL) AND EXISTS(SELECT * FROM Unidad WHERE descripcion=@descripcion)
			RAISERROR('La unidad ingresada ya se encuentra registrada, verificar datos',16,1)
		

		INSERT INTO Unidad(
								abreviatura,
								descripcion								
							)
					VALUES(
								@abreviatura,
								@descripcion
							)
		SELECT @id_unidad=IDENT_CURRENT('Unidad')
		SELECT @id_unidad
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarUnidad')
	DROP PROCEDURE sp_ModificarUnidad
GO
CREATE PROCEDURE sp_ModificarUnidad
(
	@id_unidad		smallint,
	@abreviatura	char(4),
	@descripcion	varchar(50)	
)
AS
BEGIN
	BEGIN TRY

		IF (@descripcion IS NOT NULL) AND EXISTS(SELECT * FROM Unidad WHERE descripcion=@descripcion AND id_unidad<>@id_unidad)
			RAISERROR('La unidad ingresada ya se encuentra registrada, verificar datos',16,1)

		UPDATE Unidad
			SET 
				abreviatura=@abreviatura,
				descripcion=@descripcion
				
			WHERE
				id_unidad=@id_unidad

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarUnidad')
	DROP PROCEDURE sp_ListarUnidad
GO
CREATE PROCEDURE sp_ListarUnidad
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Unidad
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO



IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarUnidad')
	DROP PROCEDURE sp_EliminarUnidad
GO
CREATE PROCEDURE sp_EliminarUnidad
(
	@id_unidad	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Unidad WHERE id_unidad=@id_unidad

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarUnidadXID')
	DROP PROCEDURE sp_ListarUnidadXID
GO
CREATE PROCEDURE sp_ListarUnidadXID
(
	@id_unidad tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Unidad where id_unidad = @id_unidad
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_BuscarIdUnidad')
	DROP PROCEDURE sp_BuscarIdUnidad
GO
CREATE PROCEDURE sp_BuscarIdUnidad
(
	@id_unidad   	smallint output,
	@abreviatura	char(4)
	)
AS
BEGIN
	BEGIN TRY
		SELECT @id_unidad= id_unidad FROM Unidad where abreviatura = @abreviatura
		return @id_unidad
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO



/*
*************************************************************
*															*
*					TABLA CONCEPTO							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarConcepto')
	DROP PROCEDURE sp_RegistrarConcepto
GO
CREATE PROCEDURE sp_RegistrarConcepto
(
	@id_concepto   	smallint output,
	@descripcion	varchar(100)
	
)
AS
BEGIN
	BEGIN TRY

		--IF (@departamento IS NOT NULL) AND EXISTS(SELECT * FROM Ubigeo WHERE departamento=@departamento)
		--	RAISERROR('El departamento ingresado ya se encuentra registrado, verificar datos',16,1)
		

		INSERT INTO Concepto(
								descripcion								
							)
					VALUES(
								
								@descripcion
							)
		SELECT @id_concepto=IDENT_CURRENT('Concepto')
		SELECT @id_concepto
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarConcepto')
	DROP PROCEDURE sp_ModificarConcepto
GO
CREATE PROCEDURE sp_ModificarConcepto
(
	@id_concepto		smallint,
	@descripcion	varchar(100)	
)
AS
BEGIN
	BEGIN TRY

		--IF (@departamento IS NOT NULL) AND EXISTS(SELECT * FROM Ubigeo WHERE departamento=@departamento)
		--	RAISERROR('El departamento ingresado ya se encuentra registrado, verificar datos',16,1)
		

		UPDATE Concepto
			SET 
				
				descripcion=@descripcion
				
			WHERE
				id_concepto=@id_concepto

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarConcepto')
	DROP PROCEDURE sp_ListarConcepto
GO
CREATE PROCEDURE sp_ListarConcepto
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Concepto
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO



IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarConcepto')
	DROP PROCEDURE sp_EliminarConcepto
GO
CREATE PROCEDURE sp_EliminarConcepto
(
	@id_concepto	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Concepto WHERE id_concepto=@id_concepto

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA CLIENTE							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarCliente')
	DROP PROCEDURE sp_RegistrarCliente
GO
CREATE PROCEDURE sp_RegistrarCliente
(
	@id_cliente   	smallint output,
	@razon_social	varchar(100),
	@ruc			char(11),
	@dni			char(8),
	@direccion		varchar(100),
	@telefono		char(9),
	@celular		char(10),
	@estado			char(1),
	@tipo_cliente	char(1)
)
AS
BEGIN
	BEGIN TRY

		IF (@ruc IS NOT NULL) AND EXISTS(SELECT * FROM Cliente WHERE ruc=@ruc) AND @ruc<>''--Modified 2014.04.12
			RAISERROR('El ruc ingresado ya se encuentra registrado, verificar datos',16,1)
		
		IF (@dni IS NOT NULL) AND EXISTS(SELECT * FROM Cliente WHERE dni=@dni) AND @dni<>''--Modified 2014.04.12
			RAISERROR('El dni ingresado ya se encuentra registrado, verificar datos',16,1)
			
		INSERT INTO Cliente(
								razon_social,
								ruc,
								dni,
								direccion,							
								telefono,
								celular,
								estado,
								tipo_cliente
							)
					VALUES(
								@razon_social,
								@ruc,
								@dni,
								@direccion,
								@telefono,
								@celular,
								@estado,
								@tipo_cliente
							)
		SELECT @id_cliente=IDENT_CURRENT('Cliente')
		SELECT @id_cliente
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarCliente')
	DROP PROCEDURE sp_ModificarCliente
GO
CREATE PROCEDURE sp_ModificarCliente
(
	@id_cliente		tinyint,
	@razon_social	varchar(100),
	@ruc			char(11),
	@dni			char(8),
	@direccion		varchar(100),
	@telefono		char(9),
	@celular		char(10),
	@estado			char(1),
	@tipo_cliente	char(1)
)
AS
BEGIN
	BEGIN TRY

		IF (@ruc IS NOT NULL) AND EXISTS(SELECT * FROM Cliente WHERE ruc=@ruc AND id_cliente<>@id_cliente)
			RAISERROR('El ruc ingresado ya se encuentra registrado, verificar datos',16,1)
		
		IF (@dni IS NOT NULL) AND EXISTS(SELECT * FROM Cliente WHERE dni=@dni  AND id_cliente<>@id_cliente)
			RAISERROR('El dni ingresado ya se encuentra registrado, verificar datos',16,1)

		UPDATE Cliente
			SET 
				razon_social=@razon_social,
				ruc=@ruc,
				dni=@dni,
				direccion=@direccion,							
				telefono=@telefono,
				celular=@celular,
				estado=@estado,
				tipo_cliente=@tipo_cliente
				
			WHERE
				id_cliente=@id_cliente

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarCliente')
	DROP PROCEDURE sp_ListarCliente
GO
CREATE PROCEDURE sp_ListarCliente
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Cliente
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO



IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarCliente')
	DROP PROCEDURE sp_EliminarCliente
GO
CREATE PROCEDURE sp_EliminarCliente
(
	@id_cliente	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Cliente WHERE id_cliente=@id_cliente

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaClienteXID')
	DROP PROCEDURE sp_ListaClienteXID
GO
CREATE PROCEDURE sp_ListaClienteXID
(
	@id_Cliente tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Cliente where id_cliente = @id_Cliente
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA ALMACEN							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarAlmacen')
	DROP PROCEDURE sp_RegistrarAlmacen
GO
CREATE PROCEDURE sp_RegistrarAlmacen
(
	@id_almacen   	smallint output,
	@id_sucursal	tinyint,
	@descripcion	varchar(100)
)
AS
BEGIN
	BEGIN TRY

		--IF (@departamento IS NOT NULL) AND EXISTS(SELECT * FROM Ubigeo WHERE departamento=@departamento)
		--	RAISERROR('El departamento ingresado ya se encuentra registrado, verificar datos',16,1)
		

		INSERT INTO Almacen(
								id_sucursal,
								descripcion
							)
					VALUES(
								@id_sucursal,
								@descripcion								
							)
		SELECT @id_almacen=IDENT_CURRENT('Almacen')
		SELECT @id_almacen
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarAlmacen')
	DROP PROCEDURE sp_ModificarAlmacen
GO
CREATE PROCEDURE sp_ModificarAlmacen
(
	@id_almacen		smallint,
	@id_sucursal	tinyint,
	@descripcion	varchar(100)
)
AS
BEGIN
	BEGIN TRY

		--IF (@departamento IS NOT NULL) AND EXISTS(SELECT * FROM Ubigeo WHERE departamento=@departamento)
		--	RAISERROR('El departamento ingresado ya se encuentra registrado, verificar datos',16,1)
		

		UPDATE Almacen
			SET 
				id_sucursal = @id_sucursal,
				descripcion = @descripcion
				
			WHERE
				id_almacen=@id_almacen -- Modified 2014.03.24

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarAlmacen')
	DROP PROCEDURE sp_ListarAlmacen
GO
CREATE PROCEDURE sp_ListarAlmacen
AS
BEGIN
	BEGIN TRY
		--SELECT * FROM Almacen
		SELECT A.*,S.descripcion AS 'sucursal' FROM Almacen A INNER JOIN Sucursal S ON A.id_sucursal=S.id_sucursal --Modified 2014.03.24
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO



IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarAlmacen')
	DROP PROCEDURE sp_EliminarAlmacen
GO
CREATE PROCEDURE sp_EliminarAlmacen
(
	@id_almacen	smallint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Almacen WHERE id_almacen=@id_almacen

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarAlmacenXSucursal')
	DROP PROCEDURE sp_ListarAlmacenXSucursal
GO
CREATE PROCEDURE sp_ListarAlmacenXSucursal
(
	@id_sucursal tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Almacen where id_sucursal = @id_sucursal
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarPersonalAlmacen')
	DROP PROCEDURE sp_ListarPersonalAlmacen
GO
CREATE PROCEDURE sp_ListarPersonalAlmacen
(
	@id_personal tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT id_almacen FROM Almacen_Personal where id_personal = @id_personal
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA VEHICULO							*
*															*
*************************************************************
*/
use Autos
go
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarVehiculo')
	DROP PROCEDURE sp_RegistrarVehiculo
GO
CREATE PROCEDURE sp_RegistrarVehiculo
(
	@id_vehiculo	smallint output,
	@id_cliente		smallint,
	@placa			char(7),
	@id_marca		tinyint,
	@modelo			varchar(20),
	@tipo_vehiculo	char(8)	
)
AS
BEGIN
	BEGIN TRY

		--IF (@usuario IS NOT NULL) AND EXISTS(SELECT * FROM Personal WHERE usuario=@usuario)
		--	RAISERROR('El usuario ingresado ya se encuentra registrado, verificar datos',16,1)
		IF (@placa IS NOT NULL) AND EXISTS(SELECT * FROM Vehiculo WHERE placa=@placa)
			RAISERROR('La placa ingresada ya se encuentra registrada, verificar datos',16,1)

		INSERT INTO Vehiculo(
								id_cliente,
								placa,
								id_marca,
								modelo,
								tipo_vehiculo								
							)
					VALUES(
								@id_cliente,
								@placa,
								@id_marca,
								@modelo,
								@tipo_vehiculo
															
							)
		SELECT @id_vehiculo=IDENT_CURRENT('Vehiculo')
		SELECT @id_vehiculo
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarVehiculo')
	DROP PROCEDURE sp_ModificarVehiculo
GO
CREATE PROCEDURE sp_ModificarVehiculo
(
	@id_vehiculo	smallint,
	@id_cliente		smallint,
	@placa			char(7),
	@id_marca		tinyint,
	@modelo			varchar(20),
	@tipo_vehiculo	char(8)			
)
AS
BEGIN
	BEGIN TRY

		--IF EXISTS(SELECT * FROM Personal WHERE usuario=@usuario AND id_personal<>@id_personal)
		--	RAISERROR('El usuario ingresado ya se encuentra registrado, verificar datos',16,1)
		IF (@placa IS NOT NULL) AND EXISTS(SELECT * FROM Vehiculo WHERE placa=@placa AND id_vehiculo<>@id_vehiculo)
			RAISERROR('La placa ingresada ya se encuentra registrada, verificar datos',16,1)

		UPDATE Vehiculo 
			SET 
				id_cliente = @id_cliente,
				placa = @placa,
				@id_marca = @id_marca,
				modelo = @modelo,
				tipo_vehiculo = @tipo_vehiculo						
			WHERE
				id_vehiculo=@id_vehiculo

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarVehiculo')
	DROP PROCEDURE sp_ListarVehiculo
GO
CREATE PROCEDURE sp_ListarVehiculo
AS
BEGIN
	BEGIN TRY
		SELECT	V.id_vehiculo,
		V.placa,
		V.id_marca,
		V.modelo,
		V.tipo_vehiculo,
		V.id_cliente,
		C.razon_social
FROM Vehiculo V
INNER JOIN Cliente C ON V.id_cliente = C.id_cliente
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarVehiculo')
	DROP PROCEDURE sp_EliminarVehiculo
GO
CREATE PROCEDURE sp_EliminarVehiculo
(
	@id_vehiculo	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Vehiculo WHERE id_vehiculo=@id_vehiculo

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA PROVEEDOR							*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarProveedor')
	DROP PROCEDURE sp_RegistrarProveedor
GO
CREATE PROCEDURE sp_RegistrarProveedor
(
	@id_proveedor	tinyint output,
	@id_ubigeo		char(6),
	@razon_social	varchar(100),
	@ruc			char(11),
	@direccion		varchar(100),
	@telefono 		char(9),
	@fax	 		char(9),
	@contacto 		varchar(100),
	@email 			varchar(100),
	@descripcion	varchar(150),
	@estado 		bit	
)
AS
BEGIN
	BEGIN TRY

		--IF (@usuario IS NOT NULL) AND EXISTS(SELECT * FROM Personal WHERE usuario=@usuario)
		--	RAISERROR('El usuario ingresado ya se encuentra registrado, verificar datos',16,1)
		IF (@ruc IS NOT NULL) AND EXISTS(SELECT * FROM Proveedor WHERE ruc=@ruc)
			RAISERROR('El dni ingresado ya se encuentra registrado, verificar datos',16,1)

		INSERT INTO Proveedor(
								id_ubigeo,
								razon_social,
								ruc,
								direccion,
								telefono,
								fax,
								contacto,
								email,
								descripcion,
								estado
							)
					VALUES(
								@id_ubigeo,
								@razon_social,
								@ruc,
								@direccion,
								@telefono,
								@fax,
								@contacto,
								@email,
								@descripcion,
								@estado								
							)
		SELECT @id_proveedor=IDENT_CURRENT('Proveedor')
		SELECT @id_proveedor
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarProveedor')
	DROP PROCEDURE sp_ModificarProveedor
GO
CREATE PROCEDURE sp_ModificarProveedor
(
	@id_proveedor	tinyint,
	@id_ubigeo		char(6),
	@razon_social	varchar(100),
	@ruc			char(11),
	@direccion		varchar(100),
	@telefono 		char(9),
	@fax	 		char(9),
	@contacto 		varchar(100),
	@email 			varchar(100),
	@descripcion	varchar(150),	
	@estado 		bit	
)
AS
BEGIN
	BEGIN TRY

		--IF EXISTS(SELECT * FROM Personal WHERE usuario=@usuario AND id_personal<>@id_personal)
		--	RAISERROR('El usuario ingresado ya se encuentra registrado, verificar datos',16,1)
		IF (@ruc IS NOT NULL) AND EXISTS(SELECT * FROM Proveedor WHERE ruc=@ruc AND id_proveedor<>@id_proveedor)
			RAISERROR('El ruc ingresado ya se encuentra registrado, verificar datos',16,1)

		UPDATE Proveedor 
			SET 
				id_ubigeo=@id_ubigeo,
				razon_social=@razon_social,
				ruc=@ruc,
				direccion=@direccion,
				telefono=@telefono,
				fax=@fax,
				contacto=@contacto,
				email=@email,
				descripcion=@descripcion,
				estado=@estado				
			WHERE
				id_proveedor=@id_proveedor

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarProveedor')
	DROP PROCEDURE sp_ListarProveedor
GO
CREATE PROCEDURE sp_ListarProveedor
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Proveedor
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarProveedor')
	DROP PROCEDURE sp_EliminarProveedor
GO
CREATE PROCEDURE sp_EliminarProveedor
(
	@id_proveedor	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			/*
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Venta WHERE id_personal=@id_personal)
				RAISERROR('El personal a eliminar posee ventas registradas no se puede eliminar, verificar datos',16,1)	
			*/
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Proveedor WHERE id_proveedor=@id_proveedor

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaProveedorXID')
	DROP PROCEDURE sp_ListaProveedorXID
GO
CREATE PROCEDURE sp_ListaProveedorXID
(
	@id_Proveedor tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Proveedor where id_proveedor = @id_Proveedor
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO



/*
*************************************************************
*															*
*					TABLA PRODUCTO						*
*															*
*************************************************************
*/

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarProducto')
	DROP PROCEDURE sp_RegistrarProducto
GO
CREATE PROCEDURE sp_RegistrarProducto
(
	@id_producto	smallint output,
	@id_linea		tinyint,
	@id_marca		tinyint,
	@id_unidad		tinyint,
	@nombre_producto varchar(50),
	@codigo_producto char(15),
	@modelo_producto varchar(50),
	@numero_comprobante char(10),
	@estado bit,
	@precio_venta smallmoney,
	@precio_compra smallmoney,
	@imagen image,
	@descripcion varchar(150)	
)
AS
BEGIN
	BEGIN TRY

		--IF (@usuario IS NOT NULL) AND EXISTS(SELECT * FROM Personal WHERE usuario=@usuario)
		--	RAISERROR('El usuario ingresado ya se encuentra registrado, verificar datos',16,1)
		IF (@codigo_producto IS NOT NULL) AND EXISTS(SELECT * FROM Producto WHERE codigo_producto=@codigo_producto)
			RAISERROR('El codigo del producto ingresado ya se encuentra registrado, verificar datos',16,1)

		INSERT INTO Producto(
								--id_producto,
								id_linea,
								id_marca,
								id_unidad,
								nombre_producto ,
								codigo_producto,
								modelo_producto,
								numero_comprobante,
								estado,
								precio_venta ,
								precio_compra,
								imagen,
								descripcion
							)
					VALUES(
								--@id_producto,
								@id_linea,
								@id_marca,
								@id_unidad,
								@nombre_producto ,
								@codigo_producto,
								@modelo_producto,
								@numero_comprobante,
								@estado,
								@precio_venta ,
								@precio_compra,
								@imagen,
								@descripcion							
							)
		SELECT @id_producto=IDENT_CURRENT('Producto')
		SELECT @id_producto
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarProducto')
	DROP PROCEDURE sp_ModificarProducto
GO
CREATE PROCEDURE sp_ModificarProducto
(
	@id_producto	smallint output,
	@id_linea		tinyint,
	@id_marca		tinyint,
	@id_unidad		tinyint,
	@nombre_producto varchar(50),
	@codigo_producto char(15),
	@modelo_producto varchar(50),
	@numero_comprobante char(10),
	@estado bit,
	@precio_venta smallmoney,
	@precio_compra smallmoney,
	@descripcion varchar(150)
)
AS
BEGIN
	BEGIN TRY

		--IF EXISTS(SELECT * FROM Personal WHERE usuario=@usuario AND id_personal<>@id_personal)
		--	RAISERROR('El usuario ingresado ya se encuentra registrado, verificar datos',16,1)
		-- IF (@codigo_producto IS NOT NULL) AND EXISTS(SELECT * FROM Producto WHERE codigo_producto=@codigo_producto)
		--	RAISERROR('El codigo del producto ingresado ya se encuentra registrado, verificar datos',16,1)

		UPDATE Producto
			SET 
						id_linea=@id_linea,
								id_marca=@id_marca,
								id_unidad=@id_unidad,
								nombre_producto=@nombre_producto ,
								codigo_producto=@codigo_producto,
								modelo_producto=@modelo_producto,
								numero_comprobante=@numero_comprobante,
								estado=@estado,
								precio_compra = @precio_compra,
								precio_venta = @precio_venta,
								descripcion=@descripcion			
			WHERE
				id_producto=@id_producto

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarProducto')
	DROP PROCEDURE sp_ListarProducto
GO
CREATE PROCEDURE sp_ListarProducto
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Producto
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaProductoXID')
	DROP PROCEDURE sp_ListaProductoXID
GO
CREATE PROCEDURE sp_ListaProductoXID
(
	@id_producto tinyint
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Producto where id_producto = @id_producto
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarProducto')
	DROP PROCEDURE sp_EliminarProducto
GO
CREATE PROCEDURE sp_EliminarProducto
(
	@id_producto	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			
			--Para agregar cuando exista
			IF EXISTS(SELECT * FROM Precio WHERE id_producto=@id_producto)
				RAISERROR('El producto a eliminar posee precios registrados por lo que no se puede eliminar, verificar datos',16,1)	
			--En versión - Dennis no se encuentra por eso lo comento
				--IF EXISTS(SELECT * FROM Kardex WHERE id_producto=@id_producto)
				--	RAISERROR('El producto a eliminar posee kardex registrados por lo que no se puede eliminar, verificar datos',16,1)				
		
			/*
			--Para agregar cuando exista
			DELETE FROM Usuario_SubMenu WHERE id_personal=@id_personal
			*/
			DELETE FROM Producto WHERE id_producto=@id_producto

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO
/*
*************************************************************
*															*
*					TABLA TIPO_CAMBIO						*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarTipo_Cambio')
	DROP PROCEDURE sp_RegistrarTipo_Cambio
GO
CREATE PROCEDURE sp_RegistrarTipo_Cambio
(
	@id_tipo_cambio smallint output,
	@cambio_venta smallmoney,
	@cambio_compra smallmoney,
	@cambio_empresa smallmoney,
	@fecha_inicio smalldatetime
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Tipo_Cambio (
								cambio_venta,
								cambio_compra,
								cambio_empresa,
								fecha_inicio
								)
						VALUES(
								@cambio_venta,
								@cambio_compra,
								@cambio_empresa,
								@fecha_inicio
								)
		SELECT @id_Tipo_Cambio=IDENT_CURRENT('Tipo_Cambio')
		SELECT @id_Tipo_Cambio
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarTipo_Cambio')
	DROP PROCEDURE sp_EliminarTipo_Cambio
GO
CREATE PROCEDURE sp_EliminarTipo_Cambio
(
	@id_tipo_cambio smallint,
	@fecha_fin smalldatetime
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Tipo_Cambio SET estado = 0, fecha_fin = @fecha_fin WHERE id_tipo_cambio = @id_tipo_cambio
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_LitarTipo_Cambio')
	DROP PROCEDURE sp_LitarTipo_Cambio
GO
CREATE PROCEDURE sp_LitarTipo_Cambio
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Tipo_Cambio where estado = 1
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
/*
*************************************************************
*															*
*					TABLA DETALLE_CAJA						*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarCaja')
	DROP PROCEDURE sp_ListarCaja
GO
CREATE PROCEDURE sp_ListarCaja
AS
BEGIN
	BEGIN TRY
			Select * from Caja
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarDetalle_Caja')
	DROP PROCEDURE sp_RegistrarDetalle_Caja
GO
CREATE PROCEDURE sp_RegistrarDetalle_Caja
	(
	@id_Caja smallint,
	@id_almacen smallint,
	@descripcion varchar(100)
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO  Detalle_Caja( 
										id_caja,
										id_almacen,
										descripcion
										)
					VALUES(
										@id_Caja,
										@id_almacen,
										@descripcion
)	

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarDetalle_Caja')
	DROP PROCEDURE sp_ModificarDetalle_Caja
GO
CREATE PROCEDURE sp_ModificarDetalle_Caja
(
	@id_Caja smallint,
	@id_almacen smallint,
	@descripcion varchar(100)
)
AS
BEGIN
	BEGIN TRY

		UPDATE Detalle_Caja
			SET 
						descripcion=@descripcion			
			WHERE
				id_caja = @id_Caja AND id_almacen = @id_almacen

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarDetalle_CajaXAlmacen')
	DROP PROCEDURE sp_ListarDetalle_CajaXAlmacen
GO
CREATE PROCEDURE sp_ListarDetalle_CajaXAlmacen
	(
	@id_almacen smallint
)
AS
BEGIN
	BEGIN TRY
			Select * from Detalle_Caja
				WHERE  id_almacen = @id_almacen
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

--Added 2014.04.12
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarDetalle_CajaXAlmacenTipoPago')
	DROP PROCEDURE sp_ListarDetalle_CajaXAlmacenTipoPago
GO
CREATE PROCEDURE sp_ListarDetalle_CajaXAlmacenTipoPago
	(
	@id_almacen smallint,
	@tipo_pago char(1)
)
AS
BEGIN
	BEGIN TRY
			SELECT 
				DC.*
			FROM Detalle_Caja DC
			INNER JOIN Caja C ON DC.id_caja = C.id_caja
			WHERE  DC.id_almacen = @id_almacen AND C.tipo_pago = @tipo_pago
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA PRODUCTO_ALMACEN					*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarProducto_Almacen')
	DROP PROCEDURE sp_RegistrarProducto_Almacen
GO
CREATE PROCEDURE sp_RegistrarProducto_Almacen
	(
	@id_producto smallint,
	@id_almacen smallint,
	@descripcion varchar(100)
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO  Producto_Almacen ( 
										id_producto,
										id_almacen,
										descripcion
										)
					VALUES(
										@id_producto,
										@id_almacen,
										@descripcion
)	

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarProducto_Almacen')
	DROP PROCEDURE sp_ModificarProducto_Almacen
GO
CREATE PROCEDURE sp_ModificarProducto_Almacen
(
	@id_producto smallint,
	@id_almacen smallint,
	@descripcion varchar(100)
)
AS
BEGIN
	BEGIN TRY

		UPDATE Producto_Almacen
			SET 
						descripcion=@descripcion			
			WHERE
				id_producto = @id_producto AND id_almacen = @id_almacen

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ContraProducto_Almacen')
	DROP PROCEDURE sp_ContraProducto_Almacen
GO
CREATE PROCEDURE sp_ContraProducto_Almacen
	(
	@Cantidad int out,
	@id_producto smallint,
	@id_almacen smallint
)
AS
BEGIN
	BEGIN TRY
SELECT 	@Cantidad = COUNT(*) from Producto_Almacen where id_producto = @id_producto and id_almacen = @id_almacen
return @Cantidad
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarProducto_Almacen')
	DROP PROCEDURE sp_ListarProducto_Almacen
GO
CREATE PROCEDURE sp_ListarProducto_Almacen
	(
	@id_producto smallint,
	@id_almacen smallint
)
AS
BEGIN
	BEGIN TRY
			Select * from Producto_Almacen
				WHERE id_producto = @id_producto and id_almacen = @id_almacen
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_AutorizaStock')
	DROP PROCEDURE sp_AutorizaStock
GO
CREATE PROCEDURE sp_AutorizaStock
	(
	@id_producto smallint,
	@id_almacen smallint,
	@stock int
)
AS
BEGIN
	BEGIN TRY
			UPDATE Producto_Almacen
				SET
				stock = @stock
				WHERE id_producto = @id_producto and id_almacen = @id_almacen
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
/*
*************************************************************
*															*
*						TABLA PRECIO						*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarPrecio')
	DROP PROCEDURE sp_RegistrarPrecio
GO
CREATE PROCEDURE sp_RegistrarPrecio
	(
	@id_producto smallint,
	@id_almacen smallint,
	@precio_compra smallmoney,
	@precio_venta smallmoney,
	@precio_trajecta smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Precio( 
										id_producto,
										id_almacen,
										precio_compra,
										precio_venta,
										precio_trajecta
										)
					VALUES(
										@id_producto,
										@id_almacen,
										@precio_compra,
										@precio_venta,
										@precio_trajecta
											)	

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarPrecio')
	DROP PROCEDURE sp_ModificarPrecio
GO
CREATE PROCEDURE sp_ModificarPrecio
(
	@id_producto smallint,
	@id_almacen smallint,
	@precio_compra smallmoney,
	@precio_venta smallmoney,
	@precio_trajecta smallmoney
)
AS
BEGIN
	BEGIN TRY

		UPDATE Precio
			SET 
						precio_compra = @precio_compra,
						precio_venta = @precio_venta,
						precio_trajecta = @precio_trajecta
			WHERE
				id_producto = @id_producto AND id_almacen = @id_almacen

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
/*
*************************************************************
*															*
*					TABLA MOVIMIENTO						*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarMovimiento')
	DROP PROCEDURE sp_RegistrarMovimiento
GO
CREATE PROCEDURE sp_RegistrarMovimiento
	(
	@id_movimiento smallint output,
	@id_caja smallint,
	@id_operacion smallint,
	@id_almacen smallint,
	@id_tipodocumento char(3),
	@numero_documento char(3),
	@serie_documento char(7),
	@tipo_movimiento char(1),
	@monto smallmoney,
	@fecha_movimiento smalldatetime
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Movimiento(
							id_caja,
							id_operacion,
							id_almacen,
							id_tipodocumento,
							numero_documento,
							serie_documento,
							tipo_movimiento,
							monto, 
							fecha_movimiento
							)
					VALUES(
								@id_caja,
								@id_operacion,
								@id_almacen,
								@id_tipodocumento,
								@numero_documento,
								@serie_documento,
								@tipo_movimiento,
								@monto, 
								@fecha_movimiento		
							)
		SELECT @id_movimiento=IDENT_CURRENT('Movimiento')
		SELECT @id_movimiento
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarMovimientoConCambion')
	DROP PROCEDURE sp_RegistrarMovimientoConCambion
GO
CREATE PROCEDURE sp_RegistrarMovimientoConCambion
	(
	@id_movimiento smallint output,
	@id_caja smallint,
	@id_operacion smallint,
	@id_almacen smallint,
	@id_tipodocumento char(3),
	@numero_documento char(3),
	@serie_documento char(7),
	@tipo_movimiento char(1),
	@monto smallmoney, 
	@fecha_movimiento smalldatetime,
	@tipo_cambio smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Movimiento(
							id_caja,
							id_operacion,
							id_almacen,
							id_tipodocumento,
							numero_documento,
							serie_documento,
							tipo_movimiento,
							monto, 
							fecha_movimiento,
							tipo_cambio
							)
					VALUES(
								@id_caja,
								@id_operacion,
								@id_almacen,
								@id_tipodocumento,
								@numero_documento,
								@serie_documento,
								@tipo_movimiento,
								@monto, 
								@fecha_movimiento,
								@tipo_cambio	
							)
		SELECT @id_movimiento=IDENT_CURRENT('Movimiento')
		SELECT @id_movimiento
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarMovimiento')
	DROP PROCEDURE sp_ModificarMovimiento
GO
CREATE PROCEDURE sp_ModificarMovimiento
	(
	@id_movimiento smallint output,
	@id_caja smallint,
	@id_operacion smallint,
	@id_almacen smallint,
	@id_tipodocumento char(3),
	@numero_documento char(3),
	@serie_documento char(7),
	@monto smallmoney
)
AS
BEGIN
	BEGIN TRY
			UPDATE Movimiento
				SET
				id_caja = @id_caja,
				id_operacion = @id_operacion,
				id_almacen = @id_almacen,
				id_tipodocumento = @id_tipodocumento,
				numero_documento = @numero_documento,
				serie_documento = @serie_documento,
				monto = @monto
				WHERE id_movimiento = @id_movimiento
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarMovimiento')
	DROP PROCEDURE sp_EliminarMovimiento
GO
CREATE PROCEDURE sp_EliminarMovimiento
(
	@id_movimiento smallint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Movimiento SET estado = 0 WHERE id_movimiento = @id_movimiento
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_BuscarIdMovimiento')
	DROP PROCEDURE sp_BuscarIdMovimiento
GO
CREATE PROCEDURE sp_BuscarIdMovimiento
(
	@id_Movimiento	smallint out,
	@id_tipodocumento tinyint,
	@numero_documento char(3)
	)
AS
BEGIN
	BEGIN TRY
		SELECT @id_Movimiento =max(id_movimiento) FROM Movimiento where id_tipodocumento = @id_tipodocumento AND numero_documento = @numero_documento
		IF @id_Movimiento is null
SET @id_Movimiento = 1
ELSE
SELECT @id_Movimiento = @id_Movimiento + 1
return @id_Movimiento
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ResumenCaja')
	DROP PROCEDURE sp_ResumenCaja
GO
CREATE PROCEDURE sp_ResumenCaja
(
	@fechaIni smalldatetime,
	@fechaFin smalldatetime,
	@id_caja smallint,
	@id_almacen smallint
	)
AS
BEGIN
	BEGIN TRY
		SELECT
			DC.descripcion AS 'detalleCaja',
			C.razon_social AS 'cliente',
			M.numero_documento AS 'documento',
			MD.descripcion AS 'moneda',
			M.monto AS 'monto',
			S.descripcion AS 'sucursal',
			M.fecha_movimiento
		FROM Movimiento M 
		INNER JOIN Detalle_Caja DC ON (M.id_almacen = DC.id_almacen AND M.id_caja=DC.id_caja) 
		INNER JOIN Venta V ON M.id_operacion = V.id_venta
		INNER JOIN Cliente C ON V.id_cliente = C.id_cliente
		INNER JOIN Moneda MD ON V.id_moneda = MD.id_moneda
		INNER JOIN Almacen A ON V.id_almacen = A.id_almacen
		INNER JOIN Sucursal S ON A.id_sucursal = S.id_sucursal
		WHERE (M.fecha_movimiento >=@fechaIni AND M.fecha_movimiento<@fechaFin+1) 
			AND (M.id_caja=M.id_caja-@id_caja OR M.id_caja=@id_caja)--para números, cuando se le envía 0 lista todo
			AND (M.id_almacen=M.id_almacen-@id_almacen OR M.id_almacen=@id_almacen)--para números, cuando se le envía 0 lista todo
			AND M.tipo_movimiento = 'E'

	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA COMPRA							*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarCompra')
	DROP PROCEDURE sp_RegistrarCompra
GO
CREATE PROCEDURE sp_RegistrarCompra
	(
	@id_compra smallint output,
	@fecha_compra smalldatetime,
	@total smallmoney,
	@subtotal smallmoney,
	@igv smallmoney,
	@id_moneda tinyint,
	@numero_documento char(3),
	@serie_documento char(7),
	@id_proveedor smallint,
	@id_almacen smallint,
	@tipo_pago char(1)
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Compra(
							fecha_compra,
							total,
							subtotal,
							igv,
							id_moneda,
							numero_documento,
							serie_documento,
							id_proveedor,
							id_almacen,
							tipo_pago
							)
					VALUES(
								@fecha_compra,
								@total,
								@subtotal,
								@igv,
								@id_moneda,
								@numero_documento,
								@serie_documento,
								@id_proveedor,
								@id_almacen,
								@tipo_pago			
							)
		SELECT @id_compra=IDENT_CURRENT('Compra')
		SELECT @id_compra
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarCompraConCambion')
	DROP PROCEDURE sp_RegistrarCompraConCambion
GO
CREATE PROCEDURE sp_RegistrarCompraConCambion
	(
	@id_compra smallint output,
	@fecha_compra smalldatetime,
	@total smallmoney,
	@subtotal smallmoney,
	@igv smallmoney,
	@id_moneda tinyint,
	@numero_documento char(3),
	@serie_documento char(7),
	@id_proveedor smallint,
	@id_almacen smallint,
	@tipo_cambio smallmoney,
	@tipo_pago char(1)
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Compra(
							fecha_compra,
							total,
							subtotal,
							igv,
							id_moneda,
							numero_documento,
							serie_documento,
							id_proveedor,
							id_almacen,
							tipo_cambio,
							tipo_pago
							)
					VALUES(
								@fecha_compra,
								@total,
								@subtotal,
								@igv,
								@id_moneda,
								@numero_documento,
								@serie_documento,
								@id_proveedor,
								@id_almacen,
								@tipo_cambio,
								@tipo_pago			
							)
		SELECT @id_compra=IDENT_CURRENT('Compra')
		SELECT @id_compra
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarCompra')
	DROP PROCEDURE sp_ModificarCompra
GO
CREATE PROCEDURE sp_ModificarCompra
	(
	@id_compra smallint output,
	@fecha_compra smalldatetime,
	@total smallmoney,
	@subtotal smallmoney,
	@igv smallmoney,
	@id_moneda tinyint,
	@numero_documento char(3),
	@serie_documento char(7),
	@id_proveedor smallint,
	@id_almacen smallint,
	@tipo_pago char(1)
)
AS
BEGIN
	BEGIN TRY
			UPDATE Compra 
				SET
				fecha_compra = @fecha_compra,
				total = @total,
				subtotal = @subtotal,
				igv = @igv,
				id_moneda = @id_moneda,
				numero_documento = @numero_documento,
				serie_documento = @serie_documento,
				id_proveedor = @id_proveedor,
				id_almacen = @id_almacen,
				tipo_pago = @tipo_pago
				WHERE id_compra = @id_compra
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarCompra')
	DROP PROCEDURE sp_EliminarCompra
GO
CREATE PROCEDURE sp_EliminarCompra
(
	@id_compra	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Compra SET estado = 9 WHERE id_compra = @id_compra
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_AtenderCompra')
	DROP PROCEDURE sp_AtenderCompra
GO
CREATE PROCEDURE sp_AtenderCompra
(
	@id_compra	tinyint,
    @estado char(1)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Compra SET estado = @estado WHERE id_compra = @id_compra
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarCompra')
	DROP PROCEDURE sp_ListarCompra
GO
CREATE PROCEDURE sp_ListarCompra
AS
BEGIN
	BEGIN TRY

	SELECT 
	    C.id_compra,
	    P.razon_social,
	    C.numero_documento, 
	    C.serie_documento,
	    C.fecha_compra,
	    M.descripcion As 'Moneda',
	    C.total
	FROM Compra C
	INNER JOIN Proveedor P ON (C.id_proveedor=P.id_proveedor)
	INNER JOIN Moneda M ON(C.id_moneda = M.id_moneda)
	where C.Estado =1

		
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaCompraXID')
	DROP PROCEDURE sp_ListaCompraXID
GO
CREATE PROCEDURE sp_ListaCompraXID
(
	@id_Compra tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Compra where id_compra = @id_Compra
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_BuscarIdCompra')
	DROP PROCEDURE sp_BuscarIdCompra
GO
CREATE PROCEDURE sp_BuscarIdCompra
(
	@id_Compra	tinyint out
	)
AS
BEGIN
	BEGIN TRY
		SELECT @id_Compra =max(id_compra) FROM Compra
		IF @id_Compra is null	
SET @id_Compra = 1
ELSE
SELECT @id_Compra = @id_Compra + 1
return @id_Compra
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA COMPRA_PRODUCTO					*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarCompra_Producto')
	DROP PROCEDURE sp_RegistrarCompra_Producto
GO
CREATE PROCEDURE sp_RegistrarCompra_Producto
	(
	@id_compra smallint,
	@id_producto smallint,
	@cantidad int,
	@precio_compra smallmoney,
	@descuento smallmoney,
	@Sub_Total smallmoney
)
AS
BEGIN
	BEGIN TRY
			INSERT INTO Compra_Producto(
							id_compra,
							id_producto,
							cantidad,
							precio_compra,
							descuento,
							Sub_Total
							)
					VALUES(
								@id_compra,
								@id_producto,
								@cantidad,
								@precio_compra,
								@descuento,
								@Sub_Total
				
							)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarCompra_Producto')
	DROP PROCEDURE sp_EliminarCompra_Producto
GO
CREATE PROCEDURE sp_EliminarCompra_Producto
(
	@id_compra	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Compra_Producto WHERE id_compra = @id_compra
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaDetalleCompraXCompra')
	DROP PROCEDURE sp_ListaDetalleCompraXCompra
GO
CREATE PROCEDURE sp_ListaDetalleCompraXCompra
(
	@id_Compra tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT 
			CP.id_producto,
			P.nombre_producto,
			CP.cantidad,
			U.abreviatura,
			CP.precio_compra,
			CP.descuento,
			CP.Sub_Total
		FROM Compra_Producto CP 
		INNER JOIN Producto P ON(CP.id_producto = P.id_producto)
		INNER JOIN Unidad U ON (P.id_unidad = U.id_unidad)
		where CP.id_compra = @id_Compra
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
/*
*************************************************************
*															*
*					TABLA VENTA								*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarVenta')
	DROP PROCEDURE sp_RegistrarVenta
GO
CREATE PROCEDURE sp_RegistrarVenta
	(
	@id_Venta smallint output,
	@id_almacen	smallint,
	@id_personal smallint,
	@id_tipodocumento char(3),
	@id_cliente smallint,
	@fecha_emision smalldatetime,
	@total smallmoney,
	@subtotal smallmoney,
	@igv smallmoney,
	@id_moneda tinyint,
	@numero_documento char(3),
	@serie_documento char(7),
	@tipo_pago char(1),
	@pago_inicial smallmoney,
    @monto_financiado smallmoney,
    @nro_cuotas int,
    @monto_cuota smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Venta(
							id_almacen,
							id_personal,
							id_tipodocumento,
							id_cliente,
							fecha_emision,
							total,
							subtotal,
							igv,
							id_moneda,
							numero_documento,
							serie_documento,
							tipo_pago,
							pago_inicial,
							monto_financiado,
							nro_cuotas,
							Monto_cuota
							)
					VALUES(
								@id_almacen,
								@id_personal,
								@id_tipodocumento,
								@id_cliente,
								@fecha_emision,
								@total,
								@subtotal,
								@igv,
								@id_moneda,
								@numero_documento,
								@serie_documento,
								@tipo_pago,
								@pago_inicial,
								@monto_financiado,
								@nro_cuotas,
								@Monto_cuota
							)
		SELECT @id_Venta=IDENT_CURRENT('Venta')
		SELECT @id_Venta
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarVentaConCambion')
	DROP PROCEDURE sp_RegistrarVentaConCambion
GO
CREATE PROCEDURE sp_RegistrarVentaConCambion
	(
	@id_Venta smallint output,
	@id_almacen	smallint,
	@id_personal smallint,
	@id_tipodocumento char(3),
	@id_cliente smallint,
	@fecha_emision smalldatetime,
	@total smallmoney,
	@subtotal smallmoney,
	@igv smallmoney,
	@id_moneda tinyint,
	@numero_documento char(3),
	@serie_documento char(7),
	@tipo_pago char(1),
	@pago_inicial smallmoney,
    @monto_financiado smallmoney,
    @nro_cuotas int,
    @monto_cuota smallmoney,
    @tipo_cambio smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Venta(
							id_almacen,
							id_personal,
							id_tipodocumento,
							id_cliente,
							fecha_emision,
							total,
							subtotal,
							igv,
							id_moneda,
							numero_documento,
							serie_documento,
							tipo_pago,
							pago_inicial,
							monto_financiado,
							nro_cuotas,
							Monto_cuota,
							tipo_cambio
							)
					VALUES(
								@id_almacen,
								@id_personal,
								@id_tipodocumento,
								@id_cliente,
								@fecha_emision,
								@total,
								@subtotal,
								@igv,
								@id_moneda,
								@numero_documento,
								@serie_documento,
								@tipo_pago,
								@pago_inicial,
								@monto_financiado,
								@nro_cuotas,
								@Monto_cuota,
								@tipo_cambio
							)
		SELECT @id_Venta=IDENT_CURRENT('Venta')
		SELECT @id_Venta
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarVenta')
	DROP PROCEDURE sp_ModificarVenta
GO
CREATE PROCEDURE sp_ModificarVenta
	(
	@id_Venta smallint,
	@id_almacen	smallint,
	@id_personal smallint,
	@id_tipodocumento char(3),
	@id_cliente smallint,
	@fecha_emision smalldatetime,
	@total smallmoney,
	@subtotal smallmoney,
	@igv smallmoney,
	@id_moneda tinyint,
	@numero_documento char(3),
	@serie_documento char(7),
	@tipo_pago char(1),
	@pago_inicial	smallmoney,
    @monto_financiado smallmoney,
    @nro_cuotas int,
    @Monto_cuota smallmoney
)
AS
BEGIN
	BEGIN TRY
			UPDATE Venta
				SET
				id_almacen = @id_almacen,
				id_personal = @id_personal,
				id_tipodocumento=@id_tipodocumento,
				id_cliente =@id_cliente,
				fecha_emision=@fecha_emision,
				total = @total,
				subtotal = @subtotal,
				igv = @igv,
				id_moneda = @id_moneda,
				numero_documento = @numero_documento,
				serie_documento = @serie_documento,
				tipo_pago = @tipo_pago,
				pago_inicial = @pago_inicial,
				monto_financiado = @monto_financiado,
				nro_cuotas = @monto_financiado,
				Monto_cuota = @Monto_cuota
				WHERE id_venta = @id_Venta
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarVenta')
	DROP PROCEDURE sp_EliminarVenta
GO
CREATE PROCEDURE sp_EliminarVenta
(
	@id_venta	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Venta SET estado = 9 WHERE id_venta = @id_venta
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_AtenderVenta')
	DROP PROCEDURE sp_AtenderVenta
GO
CREATE PROCEDURE sp_AtenderVenta
(
	@id_venta	tinyint,
    @estado char(1)
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Venta SET estado = @estado WHERE id_venta = @id_venta
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarVenta')
	DROP PROCEDURE sp_ListarVenta
GO
CREATE PROCEDURE sp_ListarVenta
AS
BEGIN
	BEGIN TRY

	SELECT 
	    V.id_venta,
	    C.razon_social,
	    V.numero_documento, 
	    V.serie_documento,
	    V.fecha_emision,
	    M.descripcion As 'Moneda',
	    V.tipo_pago,
	    P.ap_paterno,
	    P.ap_materno,
	    P.nombres,
	    V.total
	FROM Venta V
	INNER JOIN Cliente C ON (C.id_cliente=V.id_cliente)
	INNER JOIN Moneda M ON(M.id_moneda = V.id_moneda)
	INNER JOIN Personal P ON(V.id_personal = P.id_personal)
	where V.Estado =1

		
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaVentaXID')
	DROP PROCEDURE sp_ListaVentaXID
GO
CREATE PROCEDURE sp_ListaVentaXID
(
	@id_Venta tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Venta where id_venta = @id_Venta
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_BuscarIdVenta')
	DROP PROCEDURE sp_BuscarIdVenta
GO
CREATE PROCEDURE sp_BuscarIdVenta
(
	@id_Venta	tinyint out
	)
AS
BEGIN
	BEGIN TRY
		SELECT @id_Venta =max(id_venta) FROM Venta
		IF @id_Venta is null	
SET @id_Venta = 1
ELSE
SELECT @id_Venta = @id_Venta + 1
return @id_Venta
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA VENTA_PRODUCTO					*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarVenta_Producto')
	DROP PROCEDURE sp_RegistrarVenta_Producto
GO
CREATE PROCEDURE sp_RegistrarVenta_Producto
	(
	@id_venta smallint,
	@id_producto smallint,
	@cantidad int,
	@precio_venta smallmoney,
	@descuento smallmoney,
	@Sub_Total smallmoney
)
AS
BEGIN
	BEGIN TRY
			INSERT INTO venta_Producto(
							id_venta,
							id_producto,
							cantidad,
							precio_venta,
							descuento,
							Sub_Total
							)
					VALUES(
								@id_venta,
								@id_producto,
								@cantidad,
								@precio_venta,
								@descuento,
								@Sub_Total
				
							)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarVenta_Producto')
	DROP PROCEDURE sp_EliminarVenta_Producto
GO
CREATE PROCEDURE sp_EliminarVenta_Producto
(
	@id_venta	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM venta_Producto WHERE id_venta = @id_venta
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaDetalleVentaXVenta')
	DROP PROCEDURE sp_ListaDetalleVentaXVenta
GO
CREATE PROCEDURE sp_ListaDetalleVentaXVenta
(
	@id_Venta tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT 
			VP.id_producto,
			P.nombre_producto,
			VP.cantidad,
			U.abreviatura,
			VP.precio_venta,
			VP.descuento,
			VP.Sub_Total
		FROM venta_Producto VP 
		INNER JOIN Producto P ON(VP.id_producto = P.id_producto)
		INNER JOIN Unidad U ON (P.id_unidad = U.id_unidad)
		where VP.id_venta = @id_Venta
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*					TABLA KARDEX							*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarKardex')
	DROP PROCEDURE sp_RegistrarKardex
GO
CREATE PROCEDURE sp_RegistrarKardex
	(
	@id_kardex smallint output,
	@fecha smalldatetime,
	@nro_documento char(3),
	@serie_documento char(7),
	@id_tipodocumento char(3),
	@id_producto smallint,
	@id_almacen tinyint,
	@stock int,
	@cantidad int,
	@precio smallmoney,
	@descuento smallmoney,
	@tipo char(1),
	@total smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Kardex(
							fecha,
							nro_documento,
							serie_documento,
							id_tipodocumento,
							id_producto,
							id_almacen,
							stock,
							cantidad,
							precio,
							Descuentro,
							tipo,
							total
						)
					VALUES(
								@fecha,
								@nro_documento,
								@serie_documento,
								@id_tipodocumento,
								@id_producto,
								@id_almacen,
								@stock,
								@cantidad,
								@precio,
								@descuento,
								@tipo,
								@total
							)
		SELECT @id_Kardex=IDENT_CURRENT('Kardex')
		SELECT @id_Kardex
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarKardex')
	DROP PROCEDURE sp_ModificarKardex
GO
CREATE PROCEDURE sp_ModificarKardex
	(
	@id_kardex smallint,
	@fecha smalldatetime,
	@nro_documento char(3),
	@serie_documento char(7),
	@id_tipodocumento char(3),
	@id_producto smallint,
	@id_almacen tinyint,
	@stock int,
	@cantidad int,
	@precio smallmoney,
	@descuento smallmoney,
	@tipo char(1),
	@total smallmoney
)
AS
BEGIN
	BEGIN TRY
			UPDATE Kardex
				SET
				fecha = @fecha,
				nro_documento = @nro_documento,
				serie_documento = @serie_documento,
				id_tipodocumento = @id_tipodocumento,
				id_producto = @id_producto,
				id_almacen = @id_almacen,
				stock = @stock,
				cantidad = @cantidad,
				precio = @precio,
				Descuentro = @descuento,
				tipo = @tipo,
				total = @total
				WHERE id_kardex = @id_kardex
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_Eliminarkardex')
	DROP PROCEDURE sp_Eliminarkardex
GO
CREATE PROCEDURE sp_Eliminarkardex
(
	@id_kardex smallint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Kardex SET estado = 0 WHERE id_kardex = @id_kardex
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_Listarkardex')
	DROP PROCEDURE sp_Listarkardex
GO
CREATE PROCEDURE sp_Listarkardex
AS
BEGIN
	BEGIN TRY

	SELECT 
	    K.id_kardex,
	    K.id_producto,
	    P.descripcion As 'Producto',
	    P.nombre_producto,
	    K.nro_documento, 
	    K.serie_documento,
	    K.fecha,
	    TD.descripcion As 'TipoDocumento',
	    K.stock,
	    K.cantidad,
		U.abreviatura,
		K.precio,
		K.Descuentro,
	    K.tipo,
	    K.total
	FROM kardex K
	INNER JOIN Producto P ON (K.id_producto = P.id_producto)
	INNER JOIN TipoDocumento TD ON (K.id_tipodocumento = TD.id_tipodocumento)
	INNER JOIN Unidad U ON (P.id_unidad = U.id_unidad)
	where K.Estado =1
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListakardexXID')
	DROP PROCEDURE sp_ListakardexXID
GO
CREATE PROCEDURE sp_ListakardexXID
(
	@id_kardex tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM kardex where id_kardex = @id_kardex
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListakardexXID')
	DROP PROCEDURE sp_ListakardexXID
GO
CREATE PROCEDURE sp_ListakardexXID
(
	@id_kardex smallint
	)
AS
BEGIN
	BEGIN TRY
		SELECT 
		K.id_kardex,
	    K.id_producto,
	    P.descripcion As 'Producto',
	    P.nombre_producto,
	    K.nro_documento, 
	    K.serie_documento,
	    K.fecha,
	    TD.descripcion As 'TipoDocumento',
	    K.cantidad,
		U.abreviatura,
		K.precio,
		K.Descuentro,
	    K.tipo,
	    K.total
	FROM kardex K
	INNER JOIN Producto P ON (K.id_producto = P.id_producto)
	INNER JOIN TipoDocumento TD ON (K.id_tipodocumento = TD.id_tipodocumento)
	INNER JOIN Unidad U ON (P.id_unidad = U.id_unidad)
	where K.id_kardex = @id_kardex
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*				TABLA NOTA_CREDITO_VENTA					*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarNota_Credito_Cliente')
	DROP PROCEDURE sp_RegistrarNota_Credito_Cliente
GO
CREATE PROCEDURE sp_RegistrarNota_Credito_Cliente
	(
	@id_nota_credito smallint output,
	@nro_nota_credito char(3),
	@serie_nota_credito char(7),
	@fecha_emision smalldatetime,
	@total smallmoney,
    @subtotal smallmoney, 
    @Saldo_Pendiente smallmoney,
    @igv smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Nota_Credito_Venta(
							nro_nota_credito,
							serie_nota_credito,
							fecha_emision,
							total,
							subtotal,
							Saldo_Pendiente,
							igv
							)
					VALUES(
								@nro_nota_credito,
								@serie_nota_credito,
								@fecha_emision,
								@total,
								@subtotal,
								@Saldo_Pendiente,
								@igv
							)
		SELECT @id_nota_credito=IDENT_CURRENT('Nota_Credito_Venta')
		SELECT @id_nota_credito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarNota_Credito_Cliente')
	DROP PROCEDURE sp_ModificarNota_Credito_Cliente
GO
CREATE PROCEDURE sp_ModificarNota_Credito_Cliente
	(
	@id_nota_credito smallint,
	@nro_nota_credito char(3),
	@serie_nota_credito char(7),
	@fecha_emision smalldatetime,
	@total smallmoney,
    @subtotal smallmoney, 
    @Saldo_Pendiente smallmoney,
    @igv smallmoney
)
AS
BEGIN
	BEGIN TRY
			UPDATE Nota_Credito_Venta 
				SET
					nro_nota_credito = @nro_nota_credito,
					serie_nota_credito = @serie_nota_credito,
					fecha_emision = @fecha_emision,
					total = @total,
					subtotal = @subtotal,
					Saldo_Pendiente = @Saldo_Pendiente,
					igv = @igv
					WHERE id_nota_credito = @id_nota_credito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarNota_Credito_Cliente')
	DROP PROCEDURE sp_EliminarNota_Credito_Cliente
GO
CREATE PROCEDURE sp_EliminarNota_Credito_Cliente
(
	@id_nota_credito	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Nota_Credito_Venta WHERE id_nota_credito = @id_nota_credito
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarNota_Credito_Cliente')
	DROP PROCEDURE sp_ListarNota_Credito_Cliente
GO
CREATE PROCEDURE sp_ListarNota_Credito_Cliente
AS
BEGIN
	BEGIN TRY
		SELECT distinct
		NC.id_nota_credito, NC.nro_nota_credito, NC.serie_nota_credito, V.numero_documento, 
		V.serie_documento, C.razon_social, NC.total, M.descripcion AS 'Moneda'
		FROM Nota_Credito_Venta NC
		INNER JOIN Detalle_Nota_Credito_Venta DN ON (DN.id_nota_credito = NC.id_nota_credito)
		INNER JOIN Venta V ON (V.id_venta = DN.id_venta)
		INNER JOIN Cliente C ON (C.id_cliente = V.id_cliente)
		INNER JOIN Moneda M ON (M.id_moneda = V.id_moneda)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaNota_Credito_ClienteXID')
	DROP PROCEDURE sp_ListaNota_Credito_ClienteXID
GO
CREATE PROCEDURE sp_ListaNota_Credito_ClienteXID
(
	@id_nota_credito tinyint
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Nota_Credito_Venta WHERE id_nota_credito = @id_nota_credito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_BuscarIdNota_Credito_Cliente')
	DROP PROCEDURE sp_BuscarIdNota_Credito_Cliente
GO
CREATE PROCEDURE sp_BuscarIdNota_Credito_Cliente
(
	@id_nota_credito tinyint out
	)
AS
BEGIN
	BEGIN TRY
		SELECT @id_nota_credito =max(id_nota_credito) FROM Nota_Credito_Venta
		IF @id_nota_credito is null	
SET @id_nota_credito = 1
ELSE
SELECT @id_nota_credito = @id_nota_credito + 1
return @id_nota_credito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*			TABLA DETALLE_NOTA_CREDITO_VENTA				*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarDetalle_Nota_Credito_Cliente')
	DROP PROCEDURE sp_RegistrarDetalle_Nota_Credito_Cliente
GO
CREATE PROCEDURE sp_RegistrarDetalle_Nota_Credito_Cliente
	(
	@id_nota_credito smallint,
	@id_venta smallint,
	@id_producto smallint,
	@cantidad int,
	@precio_venta smallmoney,
	@descuento smallmoney,
	@Sub_Total smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Detalle_Nota_Credito_Venta(
							id_nota_credito,
							id_venta,
							id_producto,
							cantidad,
							precio_venta,
							descuento,
							Sub_Total
							)
					VALUES(
								@id_nota_credito,
								@id_venta,
								@id_producto,
								@cantidad,
								@precio_venta,
								@descuento,
								@Sub_Total
							)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarDetalle_Nota_Credito_Cliente')
	DROP PROCEDURE sp_EliminarDetalle_Nota_Credito_Cliente
GO
CREATE PROCEDURE sp_EliminarDetalle_Nota_Credito_Cliente
(
	@id_nota_credito	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Detalle_Nota_Credito_Venta WHERE id_nota_credito = @id_nota_credito
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaDetalleNota_Credito_ClienteXNota_Credito_Cliente')
	DROP PROCEDURE sp_ListaDetalleNota_Credito_ClienteXNota_Credito_Cliente
GO
CREATE PROCEDURE sp_ListaDetalleNota_Credito_ClienteXNota_Credito_Cliente
(
	@id_Nota_Credito tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT 
			DN.id_producto,
			DN.id_venta,
			P.nombre_producto,
			DN.cantidad,
			U.abreviatura,
			DN.precio_venta,
			DN.descuento,
			DN.Sub_Total
		FROM Detalle_Nota_Credito_Venta DN
		INNER JOIN Producto P ON(DN.id_producto = P.id_producto)
		INNER JOIN Unidad U ON (P.id_unidad = U.id_unidad)
		where DN.id_nota_credito = @id_Nota_Credito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*				TABLA NOTA_CREDITO_COMPRA					*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarNota_Credito_Proveedor')
	DROP PROCEDURE sp_RegistrarNota_Credito_Proveedor
GO
CREATE PROCEDURE sp_RegistrarNota_Credito_Proveedor
	(
	@id_nota_credito smallint output,
	@nro_nota_credito char(3),
	@serie_nota_credito char(7),
	@fecha_emision smalldatetime,
	@Motivo char(1),
	@total smallmoney,
    @subtotal smallmoney,
    @Saldo_Pendiente smallmoney,
    @igv smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Nota_Credito_Compra(
							nro_nota_credito,
							serie_nota_credito,
							fecha_emision,
							Motivo,
							total,
							subtotal,
							Saldo_Pendiente,
							igv
							)
					VALUES(
								@nro_nota_credito,
								@serie_nota_credito,
								@fecha_emision,
								@Motivo,
								@total,
								@subtotal,
								@Saldo_Pendiente,
								@igv
							)
		SELECT @id_nota_credito=IDENT_CURRENT('Nota_Credito_Compra')
		SELECT @id_nota_credito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarNota_Credito_Proveedor')
	DROP PROCEDURE sp_ModificarNota_Credito_Proveedor
GO
CREATE PROCEDURE sp_ModificarNota_Credito_Proveedor
	(
	@id_nota_credito smallint,
	@nro_nota_credito char(3),
	@serie_nota_credito char(7),
	@fecha_emision smalldatetime,
	@Motivo char(1),
	@total smallmoney,
    @subtotal smallmoney,
    @Saldo_Pendiente smallmoney,
    @igv smallmoney
)
AS
BEGIN
	BEGIN TRY
			UPDATE Nota_Credito_Compra 
				SET
					nro_nota_credito = @nro_nota_credito,
					serie_nota_credito = @serie_nota_credito,
					fecha_emision = @fecha_emision,
					Motivo = @Motivo,
					total = @total,
					subtotal = @subtotal,
					Saldo_Pendiente = @Saldo_Pendiente,
					igv = @igv
					WHERE id_nota_credito = @id_nota_credito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarNota_Credito_Proveedor')
	DROP PROCEDURE sp_EliminarNota_Credito_Proveedor
GO
CREATE PROCEDURE sp_EliminarNota_Credito_Proveedor
(
	@id_nota_credito	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Nota_Credito_Compra WHERE id_nota_credito = @id_nota_credito
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarNota_Credito_Proveedor')
	DROP PROCEDURE sp_ListarNota_Credito_Proveedor
GO
CREATE PROCEDURE sp_ListarNota_Credito_Proveedor
AS
BEGIN
	BEGIN TRY
		SELECT distinct 
		NC.id_nota_credito,NC.nro_nota_credito, NC.serie_nota_credito, P.razon_social, NC.fecha_emision, NC.total, NC.estado
		FROM Nota_Credito_Compra NC
		INNER JOIN Detalle_Nota_Credito_Compra DN ON (DN.id_nota_credito = NC.id_nota_credito)
		INNER JOIN Compra C ON  ( C.id_compra = DN.id_compra)
		INNER JOIN Proveedor P ON (P.id_proveedor = C.id_proveedor)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaNota_Credito_ProveedorXID')
	DROP PROCEDURE sp_ListaNota_Credito_ProveedorXID
GO
CREATE PROCEDURE sp_ListaNota_Credito_ProveedorXID
(
	@id_nota_credito tinyint
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Nota_Credito_Compra WHERE id_nota_credito = @id_nota_credito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_BuscarIdNota_Credito_Proveedor')
	DROP PROCEDURE sp_BuscarIdNota_Credito_Proveedor
GO
CREATE PROCEDURE sp_BuscarIdNota_Credito_Proveedor
(
	@id_nota_credito tinyint out
	)
AS
BEGIN
	BEGIN TRY
		SELECT @id_nota_credito =max(id_nota_credito) FROM Nota_Credito_Compra
		IF @id_nota_credito is null	
SET @id_nota_credito = 1
ELSE
SELECT @id_nota_credito = @id_nota_credito + 1
return @id_nota_credito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*			TABLA DETALLE_NOTA_CREDITO_COMPRA				*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarDetalle_Nota_Credito_Proveedor')
	DROP PROCEDURE sp_RegistrarDetalle_Nota_Credito_Proveedor
GO
CREATE PROCEDURE sp_RegistrarDetalle_Nota_Credito_Proveedor
	(
	@id_nota_credito smallint,
	@id_compra smallint,
	@id_producto smallint,
	@cantidad int,
	@precio_compra smallmoney,
	@descuento smallmoney,
	@Sub_Total smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Detalle_Nota_Credito_Compra(
							id_nota_credito,
							id_compra,
							id_producto,
							cantidad,
							precio_compra,
							descuento,
							Sub_Total
							)
					VALUES(
								@id_nota_credito,
								@id_compra,
								@id_producto,
								@cantidad,
								@precio_compra,
								@descuento,
								@Sub_Total
							)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarDetalle_Nota_Credito_Proveedor')
	DROP PROCEDURE sp_EliminarDetalle_Nota_Credito_Proveedor
GO
CREATE PROCEDURE sp_EliminarDetalle_Nota_Credito_Proveedor
(
	@id_nota_credito	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Detalle_Nota_Credito_Compra WHERE id_nota_credito = @id_nota_credito
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaDetalleNota_Credito_ProveedorXNota_Credito_Proveedor')
	DROP PROCEDURE sp_ListaDetalleNota_Credito_ProveedorXNota_Credito_Proveedor
GO
CREATE PROCEDURE sp_ListaDetalleNota_Credito_ProveedorXNota_Credito_Proveedor
(
	@id_Nota_Credito tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT 
			DN.id_producto,
			DN.id_compra,
			P.nombre_producto,
			DN.cantidad,
			U.abreviatura,
			DN.precio_compra,
			DN.descuento,
			DN.Sub_Total
		FROM Detalle_Nota_Credito_Compra DN
		INNER JOIN Producto P ON(DN.id_producto = P.id_producto)
		INNER JOIN Unidad U ON (P.id_unidad = U.id_unidad)
		where DN.id_nota_credito = @id_Nota_Credito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*				TABLA NOTA_DEBITO_COMPRA					*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarNota_Debito_Proveedor')
	DROP PROCEDURE sp_RegistrarNota_Debito_Proveedor
GO
CREATE PROCEDURE sp_RegistrarNota_Debito_Proveedor
	(
	@id_nota_debito smallint output,
	@id_compra smallint,
	@nro_nota_debito char(3),
	@serie_nota_debito char(7),
	@fecha_emision smalldatetime,
	@Motivo char(1),
	@total smallmoney,
    @subtotal smallmoney,
    @Saldo_Pendiente smallmoney,
    @igv smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Nota_Debito_Compra(
							nro_nota_debito,
							id_compra,
							serie_nota_debito,
							fecha_emision,
							Motivo,
							total,
							subtotal,
							Saldo_Pendiente,
							igv
							)
					VALUES(
								@nro_nota_debito,
								@id_compra,
								@serie_nota_debito,
								@fecha_emision,
								@Motivo,
								@total,
								@subtotal,
								@Saldo_Pendiente,
								@igv
							)
		SELECT @id_nota_debito=IDENT_CURRENT('Nota_Debito_Compra')
		SELECT @id_nota_debito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarNota_Debito_Proveedor')
	DROP PROCEDURE sp_ModificarNota_Debito_Proveedor
GO
CREATE PROCEDURE sp_ModificarNota_Debito_Proveedor
	(
	@id_nota_debito smallint,
	@id_compra smallint,
	@nro_nota_debito char(3),
	@serie_nota_debito char(7),
	@fecha_emision smalldatetime,
	@Motivo char(1),
	@total smallmoney,
    @subtotal smallmoney,
    @Saldo_Pendiente smallmoney,
    @igv smallmoney
)
AS
BEGIN
	BEGIN TRY
			UPDATE Nota_Debito_Compra 
				SET
					nro_nota_debito = @nro_nota_debito,
					id_compra = @id_compra,
					serie_nota_debito = @serie_nota_debito,
					fecha_emision = @fecha_emision,
					Motivo = @Motivo,
					total = @total,
					subtotal = @subtotal,
					Saldo_Pendiente = @Saldo_Pendiente,
					igv = @igv
					WHERE id_nota_debito = @id_nota_debito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarNota_Debito_Proveedor')
	DROP PROCEDURE sp_EliminarNota_Debito_Proveedor
GO
CREATE PROCEDURE sp_EliminarNota_Debito_Proveedor
(
	@id_nota_debito	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Nota_Debito_Compra WHERE id_nota_debito = @id_nota_debito
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarNota_Debito_Proveedor')
	DROP PROCEDURE sp_ListarNota_Debito_Proveedor
GO
CREATE PROCEDURE sp_ListarNota_Debito_Proveedor
AS
BEGIN
	BEGIN TRY
		SELECT 
		ND.id_nota_debito, ND.nro_nota_debito, ND.serie_nota_debito, P.razon_social, ND.fecha_emision, ND.total 
		FROM Nota_Debito_Compra ND
		INNER JOIN Compra C ON (ND.id_compra = C.id_compra)
		INNER JOIN Proveedor P ON (C.id_proveedor = P.id_proveedor)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaNota_Debito_ProveedorXID')
	DROP PROCEDURE sp_ListaNota_Debito_ProveedorXID
GO
CREATE PROCEDURE sp_ListaNota_Debito_ProveedorXID
(
	@id_nota_debito tinyint
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Nota_Debito_Compra WHERE id_nota_debito = @id_nota_debito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_BuscarIdNota_Debito_Proveedor')
	DROP PROCEDURE sp_BuscarIdNota_Debito_Proveedor
GO
CREATE PROCEDURE sp_BuscarIdNota_Debito_Proveedor
(
	@id_nota_debito tinyint out
	)
AS
BEGIN
	BEGIN TRY
		SELECT @id_nota_debito =max(id_nota_debito) FROM Nota_Debito_Compra
		IF @id_nota_debito is null	
SET @id_nota_debito = 1
ELSE
SELECT @id_nota_debito = @id_nota_debito + 1
return @id_nota_debito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*			TABLA DETALLE_NOTA_DEBITO_COMPRA				*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarDetalle_Nota_Debito_Proveedor')
	DROP PROCEDURE sp_RegistrarDetalle_Nota_Debito_Proveedor
GO
CREATE PROCEDURE sp_RegistrarDetalle_Nota_Debito_Proveedor
	(
	@id_nota_debito smallint,
	@id_producto smallint,
	@cantidad int,
	@precio_compra smallmoney,
	@descuento smallmoney,
	@Sub_Total smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Detalle_Nota_Debito_Compra(
							id_nota_debito,
							id_producto,
							cantidad,
							precio_compra,
							descuento,
							Sub_Total
							)
					VALUES(
								@id_nota_debito,
								@id_producto,
								@cantidad,
								@precio_compra,
								@descuento,
								@Sub_Total
							)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarDetalle_Nota_Debito_Proveedor')
	DROP PROCEDURE sp_EliminarDetalle_Nota_Debito_Proveedor
GO
CREATE PROCEDURE sp_EliminarDetalle_Nota_Debito_Proveedor
(
	@id_nota_debito	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Detalle_Nota_Debito_Compra WHERE id_nota_debito = @id_nota_debito
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaDetalleNota_Debito_ProveedorXNota_Debito_Proveedor')
	DROP PROCEDURE sp_ListaDetalleNota_Debito_ProveedorXNota_Debito_Proveedor
GO
CREATE PROCEDURE sp_ListaDetalleNota_Debito_ProveedorXNota_Debito_Proveedor
(
	@id_nota_debito tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT 
			DN.id_producto,
			P.nombre_producto,
			DN.cantidad,
			U.abreviatura,
			DN.precio_compra,
			DN.descuento,
			DN.Sub_Total
		FROM Detalle_Nota_Debito_Compra DN
		INNER JOIN Producto P ON(DN.id_producto = P.id_producto)
		INNER JOIN Unidad U ON (P.id_unidad = U.id_unidad)
		where DN.id_nota_debito = @id_nota_debito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO
/*
*************************************************************
*															*
*				TABLA NOTA_DEBITO_VENTA					*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarNota_Debito_Cliente')
	DROP PROCEDURE sp_RegistrarNota_Debito_Cliente
GO
CREATE PROCEDURE sp_RegistrarNota_Debito_Cliente
	(
	@id_nota_debito smallint output,
	@id_venta smallint,
	@nro_nota_debito char(3),
	@serie_nota_debito char(7),
	@fecha_emision smalldatetime,
	@Motivo char(1),
	@total smallmoney,
    @subtotal smallmoney,
    @Saldo_Pendiente smallmoney,
    @igv smallmoney	
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Nota_Debito_Venta(
							nro_nota_debito,
							id_venta,
							serie_nota_debito,
							fecha_emision,
							Motivo,
							total,
							subtotal,
							Saldo_Pendiente,
							igv
							)
					VALUES(
								@nro_nota_debito,
								@id_venta,
								@serie_nota_debito,
								@fecha_emision,
								@Motivo,
								@total,
								@subtotal,
								@Saldo_Pendiente,
								@igv
							)
		SELECT @id_nota_debito=IDENT_CURRENT('Nota_Debito_Venta')
		SELECT @id_nota_debito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ModificarNota_Debito_Cliente')
	DROP PROCEDURE sp_ModificarNota_Debito_Cliente
GO
CREATE PROCEDURE sp_ModificarNota_Debito_Cliente
	(
	@id_nota_debito smallint,
	@id_venta smallint,
	@nro_nota_debito char(3),
	@serie_nota_debito char(7),
	@fecha_emision smalldatetime,
	@Motivo char(1),
	@total smallmoney,
    @subtotal smallmoney,
    @Saldo_Pendiente smallmoney,
    @igv smallmoney
)
AS
BEGIN
	BEGIN TRY
			UPDATE Nota_Debito_Venta 
				SET
					nro_nota_debito = @nro_nota_debito,
					id_venta = @id_venta,
					serie_nota_debito = @serie_nota_debito,
					fecha_emision = @fecha_emision,
					Motivo = @Motivo,
					total = @total,
					subtotal = @subtotal,
					Saldo_Pendiente = @Saldo_Pendiente,
					igv = @igv
					WHERE id_nota_debito = @id_nota_debito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarNota_Debito_Cliente')
	DROP PROCEDURE sp_EliminarNota_Debito_Cliente
GO
CREATE PROCEDURE sp_EliminarNota_Debito_Cliente
(
	@id_nota_debito	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Nota_Debito_Venta WHERE id_nota_debito = @id_nota_debito
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListarNota_Debito_Cliente')
	DROP PROCEDURE sp_ListarNota_Debito_Cliente
GO
CREATE PROCEDURE sp_ListarNota_Debito_Cliente
AS
BEGIN
	BEGIN TRY
		SELECT 
		ND.id_nota_debito, ND.nro_nota_debito, ND.serie_nota_debito, V.numero_documento,
		V.serie_documento, C.razon_social, ND.total, M.descripcion AS 'Moneda'
		FROM Nota_Debito_Venta ND
		INNER JOIN Venta V ON (ND.id_venta = V.id_venta)
		INNER JOIN Cliente C ON (V.id_cliente = C.id_cliente)
		INNER JOIN Moneda M ON (V.id_moneda = M.id_moneda)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaNota_Debito_ClienteXID')
	DROP PROCEDURE sp_ListaNota_Debito_ClienteXID
GO
CREATE PROCEDURE sp_ListaNota_Debito_ClienteXID
(
	@id_nota_debito tinyint
)
AS
BEGIN
	BEGIN TRY
		SELECT * FROM Nota_Debito_Venta WHERE id_nota_debito = @id_nota_debito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_BuscarIdNota_Debito_Cliente')
	DROP PROCEDURE sp_BuscarIdNota_Debito_Cliente
GO
CREATE PROCEDURE sp_BuscarIdNota_Debito_Cliente
(
	@id_nota_debito tinyint out
	)
AS
BEGIN
	BEGIN TRY
		SELECT @id_nota_debito =max(id_nota_debito) FROM Nota_Debito_Venta
		IF @id_nota_debito is null	
SET @id_nota_debito = 1
ELSE
SELECT @id_nota_debito = @id_nota_debito + 1
return @id_nota_debito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

/*
*************************************************************
*															*
*			TABLA DETALLE_NOTA_DEBITO_VENTA				*
*															*
*************************************************************
*/
IF EXISTS( SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_RegistrarDetalle_Nota_Debito_Cliente')
	DROP PROCEDURE sp_RegistrarDetalle_Nota_Debito_Cliente
GO
CREATE PROCEDURE sp_RegistrarDetalle_Nota_Debito_Cliente
	(
	@id_nota_debito smallint,
	@id_producto smallint,
	@cantidad int,
	@precio_venta smallmoney,
	@descuento smallmoney,
	@Sub_Total smallmoney
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Detalle_Nota_Debito_Venta(
							id_nota_debito,
							id_producto,
							cantidad,
							precio_venta,
							descuento,
							Sub_Total
							)
					VALUES(
								@id_nota_debito,
								@id_producto,
								@cantidad,
								@precio_venta,
								@descuento,
								@Sub_Total
							)
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_EliminarDetalle_Nota_Debito_Cliente')
	DROP PROCEDURE sp_EliminarDetalle_Nota_Debito_Cliente
GO
CREATE PROCEDURE sp_EliminarDetalle_Nota_Debito_Cliente
(
	@id_nota_debito	tinyint
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Detalle_Nota_Debito_Venta WHERE id_nota_debito = @id_nota_debito
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION
		EXEC sp_retornarError
	END CATCH
END
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.procedures WHERE name = 'sp_ListaDetalleNota_Debito_ProveedorXNota_Debito_Proveedor')
	DROP PROCEDURE sp_ListaDetalleNota_Debito_ProveedorXNota_Debito_Proveedor
GO
CREATE PROCEDURE sp_ListaDetalleNota_Debito_ProveedorXNota_Debito_Proveedor
(
	@id_nota_debito tinyint
	)
AS
BEGIN
	BEGIN TRY
		SELECT 
			DN.id_producto,
			P.nombre_producto,
			DN.cantidad,
			U.abreviatura,
			DN.precio_venta,
			DN.descuento,
			DN.Sub_Total
		FROM Detalle_Nota_Debito_Venta DN
		INNER JOIN Producto P ON(DN.id_producto = P.id_producto)
		INNER JOIN Unidad U ON (P.id_unidad = U.id_unidad)
		where DN.id_nota_debito = @id_nota_debito
	END TRY
	BEGIN CATCH
		EXEC sp_retornarError
	END CATCH
END
GO



