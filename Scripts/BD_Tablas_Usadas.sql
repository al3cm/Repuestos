/*AVANCE*/
-- Creando la bd
USE master
IF EXISTS(SELECT * FROM sysdatabases WHERE name='Autos')
	DROP DATABASE Autos
go
CREATE DATABASE Autos
go
use Autos
go

create table Empresa  -- 0
(
	id_empresa tinyint identity(1,1) not null primary key,
	ruc char(11) not null,
	razon_social varchar(150) not null,
	direccion varchar(150) not null,
	telefono char(9) not null
)
go

create table Tipo_Cambio  -- 0
(
	id_tipo_cambio smallint identity(1,1) not null primary key,
	cambio_venta smallmoney not null,
	cambio_compra smallmoney not null,
	cambio_empresa smallmoney not null,
	fecha_inicio smalldatetime not null constraint DF_Tipo_Cambio_fecha_inicio default getdate(),
	fecha_fin smalldatetime null,
	estado bit not null constraint DF_Nota_Tipo_Cambio_estado default 1
)
go

create table Caja -- 1
(
	id_caja smallint identity(1,1) not null primary key,
	nombre_caja varchar(50) not null,
	--Added 2014.04.11
	tipo_pago char(1) not null constraint CK_Caja_tipo_caja check (tipo_pago in('E','C'))--Para validar si es de efectivo o crédito
)
go

create table Moneda -- 1
(
	id_moneda tinyint identity(1,1) not null primary key,
	descripcion varchar(20) not null,
	simbolo char(4) not null
)
go

create table Marca -- 1
(
	id_marca tinyint identity(1,1) not null primary key,
	descripcion varchar(100) not null
)
go

create table Ubigeo -- 1
(
	id_ubigeo char(6) not null primary key,
	descripcion varchar(50) not null
)
go

create table Linea -- 1
(
	id_linea tinyint identity(1,1) not null primary key,
	descripcion varchar(100) not null
)
go

create table Unidad -- 1
(
	id_unidad tinyint identity(1,1) not null primary key,
	abreviatura char(4) not null,
	descripcion varchar(50) not null
)
go

create table TipoDocumento -- 1
(
	id_tipodocumento char(3) not null primary key,
	autonumber tinyint identity(1,1) not null,
	abreviatura char(4) not null,
	descripcion varchar(50) not null
)
go

create table Concepto -- 1
(
	id_concepto smallint identity(1,1) not null primary key,
	descripcion varchar(100) not null
)
go

create table Menu -- 1
(
	id_menu smallint identity(1,1) not null primary key,
	descripcion varchar(100) not null
)
go

create table Sucursal -- 1
(
	id_sucursal tinyint identity(1,1) not null primary key,
	descripcion varchar(50) not null,
	direccion varchar(100) not null,
	telefono char(9) not null
)
go

create table Nota_Credito_Compra -- 1
(
	id_nota_credito smallint identity(1,1) not null primary key,
	nro_nota_credito char(3) not null,
	serie_nota_credito char(7) not null,
	fecha_emision smalldatetime not null constraint DF_Nota_Credito_Compra_fecha_emision default getdate(),
	motivo char(1) not null constraint CK_Nota_Credito_Compra_Motivo check (Motivo in('C','V','S','D','T')),
	total smallmoney not null constraint DF_Nota_Credito_Compra_total default 0,
    subtotal smallmoney not null constraint DF_Nota_Credito_Compra_subtotal default 0, 
    igv smallmoney not null constraint DF_Nota_Credito_Compra_igv default 0.00,
    saldo_pendiente smallmoney not null,
    estado bit not null constraint DF_Nota_Credito_Compra_estado default 1
)
go

create table Nota_Credito_Venta -- 1
(
	id_nota_credito smallint identity(1,1) not null primary key,
	nro_nota_credito char(3) not null,
	serie_nota_credito char(7) not null,
	fecha_emision smalldatetime not null constraint DF_Nota_Credito_Venta_fecha_emision default getdate(),
	total smallmoney not null constraint DF_Nota_Credito_Venta_total default 0,
    subtotal smallmoney not null constraint DF_Nota_Credito_Venta_subtotal default 0, 
    igv smallmoney not null constraint DF_Nota_Credito_Venta_igv default 0.00,
    saldo_pendiente smallmoney not null,
    estado bit not null constraint DF_Nota_Credito_Venta_estado default 1
)
go

create table Personal -- 1
(
	id_personal smallint identity(1,1) not null primary key,
	nombres varchar(50) not null,	
	ap_paterno varchar(50) not null,
	ap_materno varchar(50) not null,
	dni char(8) not null,
	direccion varchar(100) not null,
	telefono char(9) null,
	celular char(10) null,
	estado char(1) not null constraint CK_Usuario_estado check (estado in('A','C','V')),
	cargo char(1) not null constraint CK_Usuario_cargo check (cargo in('A','V')),
	usuario varchar(30) not null,
	clave varchar(20) not null
)
go

create table Cliente -- 1
(
	id_cliente smallint identity(1,1) not null primary key,
	razon_social varchar(100) not null,
	ruc char(11) not null,
	dni char(8) not null,
	direccion varchar(100) not null,
	telefono char(9) not null,
	celular char(10) not null,
	estado char(1) not null constraint CK_Cliente_estado check (estado in('H','D')),
	--estado bit not null constraint DF_Cliente_estado default 1,
	tipo_cliente char(1) not null constraint CK_Cliente_tipo_cliente check (tipo_cliente in('J','N'))
)
go

create table Proveedor -- 2
(
	id_proveedor smallint identity(1,1) not null primary key,
	razon_social varchar(100) not null,
	ruc char(11) not null,
	direccion varchar(100) not null,
	telefono char(9) not null,
	fax char(9) not null,
	contacto varchar(100) not null,
	email varchar(100) not null,
	descripcion varchar(150) not null,
	estado  bit not null constraint DF_Proveedor_estado default 1,
	id_ubigeo char(6)
)
go

alter table Proveedor add constraint FK_Proveedor_Ubigeo foreign key (id_ubigeo)
	references Ubigeo
			on delete no action
				on update no action

create table SubMenu -- 2
(
	id_submenu smallint not null,
	id_menu smallint not null,
	descripcion varchar(100) not null
)
go

alter table SubMenu add constraint PK_SubMenu primary key (id_submenu,id_menu)

alter table SubMenu add constraint FK_SubMenu_Menu foreign key (id_menu)
	references Menu
			on delete no action
				on update no action

create table Almacen -- 2
(
	id_almacen smallint identity(1,1) not null primary key,
	id_sucursal tinyint not null,
	descripcion varchar (100) not null
)
go

alter table Almacen add constraint FK_Almacen_Sucursal foreign key (id_sucursal)
	references Sucursal
			on delete no action
				on update no action
				
create table Vehiculo -- 2
(
	id_vehiculo smallint identity(1,1) not null primary key,
	placa char(7) not null,
	--marca varchar(20) not null,
	modelo varchar(20) not null,
	tipo_vehiculo char(8) not null constraint CK_Vehiculo_tipo check (tipo_vehiculo in('GASO','PETRO','GAS')),   
	id_cliente smallint not null,
	id_marca tinyint not null
)
go



alter table Vehiculo add constraint FK_Vehiculo_Cliente foreign key (id_cliente)
	references Cliente
			on delete no action
				on update no action


create table Producto -- 2
(
	id_producto smallint identity(1,1) not null primary key,
	nombre_producto varchar(50) not null,
	codigo_producto char(15) not null,
	modelo_producto varchar(50) not null,
	procedencia varchar(20) not null,
	estado bit not null constraint DF_Producto_estado default 1,
	precio_venta smallmoney not null,
	precio_compra smallmoney not null,
	descripcion varchar(150) not null,
	imagen image not null,
	id_marca tinyint not null,
	id_linea tinyint not null,
	id_unidad tinyint not null
)
go

alter table Producto add constraint FK_Producto_Marca foreign key (id_marca)
	references Marca
			on delete no action
				on update no action

alter table Producto add constraint FK_Producto_Linea foreign key (id_linea)
	references Linea
			on delete no action
				on update no action

alter table Producto add constraint FK_Producto_Unidad foreign key (id_unidad)
	references Unidad
			on delete no action
				on update no action

create table Personal_SubMenu -- 2
(
	id_menu smallint not null,
	id_submenu smallint not null,
	id_personal smallint not null,
	estado bit not null constraint DF_Personal_SubMenu_estado default 1,
	nuevo bit not null constraint DF_Personal_SubMenu_nuevo	default 1,
	eliminar bit not null constraint DF_Personal_SubMenu_eliminar default 1,
	modificar bit not null constraint DF_Personal_SubMenu_modificar default 1,
	buscar bit not null constraint DF_Personal_SubMenu_buscar default 1
)
go

alter table Personal_SubMenu add constraint PK_Personal_SubMenu primary key (id_menu,id_submenu,id_personal)
alter table Personal_SubMenu add constraint FK_Personal_SubMenu_Personal foreign key (id_personal)
	references Personal
			on delete no action
				on update no action
alter table Personal_SubMenu add constraint FK_Personal_SubMenu_Menu foreign key (id_menu)
	references Menu
			on delete no action
				on update no action
			
create table Almacen_Personal -- 3
(
   id_almacen smallint not null,
   id_personal smallint not null
)
alter table Almacen_Personal add constraint FK_Almacen_Personal_Almacen foreign key (id_almacen)
	references Almacen
			on delete no action
				on update no action
				
alter table Almacen_Personal add constraint FK_Almacen_Personal_Personal foreign key (id_personal)
	references Personal
			on delete no action
				on update no action
go
alter table Almacen_Personal add constraint PK_Almacen_Personal primary key (id_personal,id_almacen)
create table Precio -- 3
(
	id_producto smallint not null,
	id_almacen smallint not null,
	precio_compra smallmoney not null,
	precio_venta smallmoney not null,
	precio_trajecta smallmoney not null
)
go

alter table Precio add constraint FK_Precio_Producto foreign key (id_producto)
	references Producto
			on delete no action
				on update no action

alter table Precio add constraint FK_Precio_Almacen foreign key (id_almacen)
	references Almacen
			on delete no action
				on update no action
					
create table Codigo_Facturacion -- 3
(
	id_Codigo char(3) not null primary key,
	id_almacen smallint not null,
	estado bit not null constraint DF_Codigo_Facturacion_estado default 1
)
go

alter table Codigo_Facturacion add constraint FK_Codigo_Facturacion_Almacen foreign key (id_almacen)
	references Almacen
			on delete no action
				on update no action
				
create table Detalle_Caja -- 3
(
	id_caja smallint not null,
	id_almacen smallint not null,
	descripcion varchar(100) not null
)
go

alter table Detalle_Caja add constraint PK_Detalle_Caja primary key (id_caja,id_almacen)

alter table Detalle_Caja add constraint FK_Detalle_Caja_Caja foreign key (id_caja)
	references Caja
			on delete no action
				on update no action

alter table Detalle_Caja add constraint FK_Detalle_Caja_Almacen foreign key (id_almacen)
	references Almacen
			on delete no action
				on update no action

create table Producto_Almacen -- 3
(
	id_producto smallint not null,
	id_almacen smallint not null,
	stock int not null constraint DF_Producto_Almacen_stock default 0,
	descripcion varchar(100) not null
)
go

alter table Producto_Almacen add constraint PK_Producto_Almacen primary key (id_producto,id_almacen)
alter table Producto_Almacen add constraint FK_Producto_Almacen_Producto foreign key (id_producto)
	references Producto
			on delete no action
				on update no action

alter table Producto_Almacen add constraint FK_Producto_Almacen_Almacen foreign key (id_almacen)
	references Almacen
			on delete no action
				on update no action
								
create table Compra -- 3
(
	id_compra smallint identity(1,1) not null primary key,
	fecha_compra smalldatetime not null constraint DF_Compra_fecha default getdate(),
	total smallmoney not null constraint DF_Compra_total default 0,
    subtotal smallmoney not null constraint DF_Compra_subtotal default 0, 
    igv smallmoney not null constraint DF_Compra_igv default 0.00,
    numero_documento char(3) not null,
    serie_documento char(7) not null,
    estado char(1) not null constraint DF_Compra_estado default 1,
    id_moneda tinyint not null,
    id_proveedor smallint not null,
    id_almacen smallint not null,
    tipo_cambio smallmoney null,
    tipo_pago char(1) not null constraint CK_Compra_tipo_pago check (tipo_pago in('C','E'))
)
go

alter table Compra add constraint FK_Compra_Proveedor foreign key (id_proveedor)
	references Proveedor
			on delete no action
				on update no action
alter table Compra add constraint FK_Compra_Moneda foreign key (id_moneda)
	references moneda
			on delete no action
				on update no action
alter table Compra add constraint FK_Compra_Almacen foreign key (id_almacen)
	references almacen
			on delete no action
				on update no action

create table Venta -- 3
(
	id_venta smallint identity(1,1) not null primary key,
	id_personal smallint not null,
	id_almacen smallint not null,
    id_tipodocumento char(3) not null,
	id_cliente smallint not null,
	fecha_emision smalldatetime not null constraint DF_Ventas_fecha_emision default getdate(),
	numero_documento char(3) not null,
	serie_documento char(7) not null,
	total smallmoney not null constraint DF_Ventas_total default 0.00,
    subtotal smallmoney not null constraint DF_Ventas_subtotal default 0, 
    igv smallmoney not null constraint DF_Ventas_igv default 0.00,
    estado char(1) not null constraint DF_Ventas_estado default 1,
    id_moneda tinyint not null,
    tipo_pago char(1) not null constraint CK_Ventas_tipo_pago check (tipo_pago in('C','E','T','P')),
    pago_inicial smallmoney not null constraint DF_Ventas_pago_inicial default 0.00,
    monto_financiado smallmoney null,
    nro_cuotas int null,
    tipo_cambio smallmoney null,
    monto_cuota smallmoney null  
)
go

alter table Venta add constraint FK_Venta_Personal foreign key (id_personal)
	references Personal
			on delete no action
				on update no action

alter table Venta add constraint FK_Venta_TipoDocumento foreign key (id_tipodocumento)
	references TipoDocumento
			on delete no action
				on update no action

alter table Venta add constraint FK_Venta_Tipo_Cliente foreign key (id_cliente)
	references Cliente
			on delete no action
				on update no action
				
alter table Venta add constraint FK_Venta_Moneda foreign key (id_moneda)
	references Moneda
			on delete no action
				on update no action
				
alter table Venta add constraint FK_Venta_Almacen foreign key (id_almacen)
	references almacen
			on delete no action
				on update no action

create table Cuenta -- 4
(
	id_cuenta smallint identity(1,1) not null primary key,
	id_compra smallint not null,
	pago_inicial smallmoney not null constraint DF_Cuenta_pago_inicial default 0.00,
    monto_financiado smallmoney not null constraint DF_Cuenta_monto_financiado default 0.00,
    nro_cuotas int  not null constraint DF_Cuenta_nro_cuotas default 0,
    deudad smallmoney not null constraint DF_Cuenta_deudad default 0.00,
    estado bit not null constraint DF_Cuenta_estado default 1
)
go
alter table Cuenta add constraint FK_Cuenta_Compra foreign key (id_compra)
	references Compra
			on delete no action
				on update no action
								
create table Compra_Producto -- 4
(
	id_compra smallint not null,
	id_producto smallint not null,
	cantidad int not null,
	precio_compra smallmoney not null constraint DF_Compra_Producto_precio_compra default 0.00,
	descuento smallmoney not null constraint DF_Compra_Producto_descuento default 0.00,
	Sub_Total smallmoney not null constraint DF_Compra_Producto_Sub_Total default 0.00
)
go

alter table Compra_Producto add constraint PK_Compra_Producto primary key (id_compra,id_producto)
alter table Compra_Producto add constraint FK_Compra_Producto_Compra foreign key (id_compra)
	references Compra
			on delete no action
				on update no action
			

alter table Compra_Producto add constraint FK_Compra_Producto_Producto foreign key (id_producto)
	references Producto
			on delete no action
				on update no action

create table Nota_Debito_Compra -- 4
(
	id_nota_debito smallint identity(1,1) not null primary key,
	id_compra smallint not null,
	nro_nota_debito char(3) not null,
	serie_nota_debito char(7) not null,
	fecha_emision smalldatetime not null constraint DF_Nota_Debito_Compra_fecha_emision default getdate(),
	motivo char(1) not null constraint CK_Nota_Debito_Compra_Motivo check (Motivo in('C','V','S','D','T')),
	total smallmoney not null constraint DF_Nota_Debito_Compra_total default 0,
    subtotal smallmoney not null constraint DF_Nota_Debito_Compra_subtotal default 0, 
    igv smallmoney not null constraint DF_Nota_Debito_Compra_igv default 0.00,
    saldo_pendiente smallmoney not null,
    estado bit not null constraint DF_Nota_Debito_Compra_estado default 1
)
go

alter table Nota_Debito_Compra add constraint FK_Nota_Debito_Compra_Compra foreign key (id_compra)
	references Compra
			on delete no action
				on update no action
				
create table Nota_Debito_Venta -- 4
(
	id_nota_debito smallint identity(1,1) not null primary key,
	id_venta smallint not null,
	nro_nota_debito char(3) not null,
	serie_nota_debito char(7) not null,
	fecha_emision smalldatetime not null constraint DF_Nota_Debito_Venta_fecha_emision default getdate(),
	motivo char(1) not null constraint CK_Nota_Debito_Venta_Motivo check (Motivo in('C','V','S','D','T')),
	total smallmoney not null constraint DF_Nota_Debito_Venta_total default 0,
    subtotal smallmoney not null constraint DF_Nota_Debito_Venta_subtotal default 0, 
    igv smallmoney not null constraint DF_Nota_Debito_Venta_igv default 0.00,
    saldo_pendiente smallmoney not null,
    estado bit not null constraint DF_Nota_Debito_Venta_estado default 1
)
go

alter table Nota_Debito_Venta add constraint FK_Nota_Debito_Venta_Venta foreign key (id_venta)
	references Venta
			on delete no action
				on update no action
				
create table Cuotas -- 4
(
	id_cuota smallint identity(1,1) not null primary key,
	id_venta smallint not null,
	fecha smalldatetime not null constraint DF_Cuotas_fecha default getdate(),
	total smallmoney not null constraint DF_Cuotas_total default 0,
	estado bit not null constraint DF_Cuotas_estado default 1
)
go

alter table Cuotas add constraint FK_Cuotas_Venta foreign key (id_venta)
	references Venta
			on delete no action
				on update no action
								
create table Venta_Producto -- 4
(
	id_venta smallint not null,
	id_producto smallint not null,
	cantidad int not null,
	precio_venta smallmoney not null constraint DF_Venta_Producto_precio_venta default 0.00,
	descuento smallmoney not null constraint DF_Venta_Producto_descuento default 0.00,
	Sub_Total smallmoney not null constraint DF_Venta_Producto_Sub_Total default 0.00
)
go

alter table Venta_Producto add constraint PK_Venta_Producto primary key (id_venta,id_producto)
alter table Venta_Producto add constraint FK_Venta_Producto_Venta foreign key (id_venta)
	references venta
			on delete no action
				on update no action
			
alter table Venta_Producto add constraint FK_Venta_Producto_Producto foreign key (id_producto)
	references Producto
			on delete no action
				on update no action

create table Detalle_Nota_Credito_Compra -- 4
(
	id_nota_credito smallint not null,
	id_compra smallint not null,
	id_producto smallint not null,
	cantidad int not null,
	precio_compra smallmoney not null constraint DF_Detalle_Nota_Credito_compra default 0.00,
	descuento smallmoney not null constraint DF_Detalle_Nota_Credito_descuento default 0.00,
	sub_total smallmoney not null constraint DF_Detalle_Nota_Credito_Sub_Total default 0.00
)
go

alter table Detalle_Nota_Credito_Compra add constraint PK_Detalle_Nota_Credito_Compra primary key (id_nota_credito,id_compra,id_producto)
alter table Detalle_Nota_Credito_Compra add constraint FK_Detalle_Nota_Credito_Compra_Nota_Credito_Compra foreign key (id_nota_credito)
	references Nota_Credito_Compra
			on delete no action
				on update no action
				
alter table Detalle_Nota_Credito_Compra add constraint FK_Detalle_Nota_Credito_Compra_Compra foreign key (id_compra)
	references Compra
			on delete no action
				on update no action
			
alter table Detalle_Nota_Credito_Compra add constraint FK_Detalle_Nota_Credito_Compra_Producto foreign key (id_producto)
	references Producto
			on delete no action
				on update no action

create table Detalle_Nota_Debito_Compra -- 4
(
	id_nota_debito smallint not null,
	id_producto smallint not null,
	cantidad int not null,
	precio_compra smallmoney not null constraint DF_Detalle_Nota_Debito_Compra_precio_compra default 0.00,
	descuento smallmoney not null constraint DF_Detalle_Nota_Debito_Compra_descuento default 0.00,
	sub_total smallmoney not null constraint DF_Detalle_Nota_Debito_Compra_sub_total default 0.00
)
go

alter table Detalle_Nota_Debito_Compra add constraint PK_Detalle_Nota_Debito_Compra primary key (id_nota_debito,id_producto)

alter table Detalle_Nota_Debito_Compra add constraint FK_Detalle_Nota_Debito_Compra_Nota_Debito_Compra foreign key (id_nota_debito)
	references Nota_Debito_Compra
			on delete no action
				on update no action
				
alter table Detalle_Nota_Debito_Compra add constraint FK_Detalle_Nota_Debito_Compra_Producto foreign key (id_producto)
	references Producto
			on delete no action
				on update no action

create table Letras -- 4
(
	id_letras smallint identity(1,1) not null primary key,
	id_venta smallint not null,
	coprobrante Char(19) not null,
	fecha_emision smalldatetime not null constraint DF_Letras_fecha_emision default getdate(),
	tasa real not null constraint DF_Letras_Tasa default 0.00,
	saldo smallmoney not null constraint DF_Letras_Saldo default 0.00,
    estado bit not null constraint DF_Letras_estado default 1
)

alter table Letras add constraint FK_Letras_Venta foreign key (id_venta)
	references venta
			on delete no action
				on update no action
									
create table Detalle_Nota_Debito_Venta -- 5
(
	id_nota_debito smallint not null,
	id_producto smallint not null,
	cantidad int not null,
	precio_venta smallmoney not null constraint DF_Detalle_Nota_Debito_Venta_precio_venta default 0.00,
	descuento smallmoney not null constraint DF_Detalle_Nota_Debito_Venta_descuento default 0.00,
	sub_total smallmoney not null constraint DF_Detalle_Nota_Debito_Venta_Sub_Total default 0.00
)
go

alter table Detalle_Nota_Debito_Venta add constraint PK_Detalle_Nota_Debito_Venta primary key (id_nota_debito,id_producto)

alter table Detalle_Nota_Debito_Venta add constraint FK_Detalle_Nota_Debito_Venta_Nota_Debito_Venta foreign key (id_nota_debito)
	references Nota_Debito_Venta
			on delete no action
				on update no action
				
alter table Detalle_Nota_Debito_Venta add constraint FK_Detalle_Nota_Debito_Venta_Producto foreign key (id_producto)
	references Producto
			on delete no action
				on update no action
				
create table Detalle_Nota_Credito_Venta -- 5
(
	id_nota_credito smallint not null,
	id_venta smallint not null,
	id_producto smallint not null,
	cantidad int not null,
	precio_venta smallmoney not null constraint DF_Detalle_Nota_Credito_Venta_precio_venta default 0.00,
	descuento smallmoney not null constraint DF_Detalle_Nota_Credito_Venta_descuento default 0.00,
	sub_total smallmoney not null constraint DF_Detalle_Nota_Credito_Venta_sub_total default 0.00
)
go

alter table Detalle_Nota_Credito_Venta add constraint PK_Detalle_Nota_Credito_Venta primary key (id_nota_credito,id_venta,id_producto)

alter table Detalle_Nota_Credito_Venta add constraint FK_Detalle_Nota_Credito_Venta_Nota_Credito_Venta foreign key (id_nota_credito)
	references Nota_Credito_Venta
			on delete no action
				on update no action
alter table Detalle_Nota_Credito_Venta add constraint FK_Detalle_Nota_Credito_Venta_Venta foreign key (id_venta)
	references venta
			on delete no action
				on update no action
			
alter table Detalle_Nota_Credito_Venta add constraint FK_Detalle_Nota_Credito_Venta_Producto foreign key (id_producto)
	references Producto
			on delete no action
				on update no action

create table Detalle_Letras -- 5
(
	id_detalle_letras smallint identity(1,1) not null primary key,
	id_letras smallint not null,
	num_letra int not null,
	dias int not null,
	fecha_vencimiento smalldatetime not null constraint DF_Detalle_Letras_fecha_emision default getdate(),
	monto smallmoney not null constraint DF_Detalle_Letras_monto default 0.0,
	descripcion varchar(100) not null,
    estado bit not null constraint DF_Detalle_Letras_estado default 1
)

alter table Detalle_Letras add constraint DF_Detalle_Letras_Letras foreign key (id_letras)
	references Letras
			on delete no action
				on update no action

create table Movimiento -- 6
(
	id_movimiento smallint identity(1,1) not null primary key,
	id_caja smallint not null,--FK con Detalle_Caja
	id_operacion smallint not null,--Equivalente a id_Venta
	id_almacen smallint not null,--FK con Detalle_Caja
	id_tipodocumento char(3) not null,--A evaluar si es el mismo tipodocumento de venta
	numero_documento char(3) null,-- A evaluar si es el mismo numero_documento de venta
	serie_documento char(7) null,-- A evaluar si es el mismo serie_documento de venta
	tipo_movimiento char(1) not null constraint CK_Movimiento_tipo_movimiento check (tipo_movimiento in('E','S','C')),
	monto smallmoney not null constraint DF_Movimiento_monto default 0.0, -- A evaluar si es el total en venta
	fecha_movimiento smalldatetime not null constraint DF_Movimiento_fecha_movimiento default getdate(),
	tipo_cambio smallint null, --A evaluar si es el mismo tipo_cambio de venta	
	estado bit not null constraint DF_Movimiento_estado default 1
)
go
--Modified 2014.04.11: relación modificada hacia Detalle_Caja
alter table Movimiento add constraint FK_Movimiento_Detalle_Caja foreign key (id_caja,id_almacen)
	references Detalle_Caja
			on delete no action
				on update no action
/*
--Deleted 2014.04.11: no guarda relación con almacén, lo hace mediante Detalle_Caja
alter table Movimiento add constraint FK_Movimiento_Personal foreign key (id_almacen)
	references Almacen
			on delete no action
				on update no action
*/				
alter table Movimiento add constraint FK_Movimiento_TipoDocumento foreign key (id_tipodocumento)
	references TipoDocumento
			on delete no action
				on update no action

create table Pagos_Letras -- 6
(
	id_pagos_letras smallint identity(1,1) not null primary key,
	id_detalle_letras smallint not null,
	id_personal smallint not null,
	fecha smalldatetime not null constraint DF_Pagos_Letras_fecha default getdate(),
	tipo_cambio smallint not null,
	total smallmoney not null constraint DF_Pagos_Letras_total default 0.0,
	observaciones varchar(100) not null,
	tipo_pago char(1) not null constraint CK_Pagos_Letras_tipo_pago check (tipo_pago in('T','E')),
    estado bit not null constraint DF_Pagos_Letras_estado default 1
)
											
alter table Pagos_Letras add constraint FK_Pagos_Letras_Personal foreign key (id_personal)
	references Personal
			on delete no action
				on update no action
						
create table Kardex -- 7
(
	id_kardex smallint identity(1,1) not null primary key,
	fecha smalldatetime not null constraint DF_Kardex_fecha default getdate(),
	nro_documento char(3) not null,
	serie_documento char(7) not null,
	id_tipodocumento char(3) not null,
	id_producto smallint not null,
	id_almacen smallint not null,
	id_movimiento smallint not null,
	stock int not null,
	cantidad int not null,
	precio smallmoney not null,
	Descuentro smallmoney not null,
	tipo char(1) not null constraint CK_Kardex_tipo check (tipo in('S','E','V','C','P','D')),
	total smallmoney not null constraint DF_Kardex_total default 0.0,
	ruc_dni varchar(11) not null,
	Nombre varchar(100) not null,
    estado bit not null constraint DF_Kardex_estado default 1
)
go

alter table Kardex add constraint FK_Kardex_TipoDocumento foreign key (id_tipodocumento)
	references TipoDocumento
			on delete no action
				on update no action

alter table Kardex add constraint FK_Kardex_Producto foreign key (id_producto)
	references Producto
			on delete no action
				on update no action

alter table Kardex add constraint FK_Kardex_Almacen foreign key (id_almacen)
	references Almacen
			on delete no action
				on update no action

alter table Kardex add constraint FK_Kardex_Movimiento foreign key (id_movimiento)
	references Movimiento
			on delete no action
				on update no action

use master
go