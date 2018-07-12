create database SegundoParcialDbs
go
use SegundoParcialDbs
go
create table Vehiculos
(
    VehiculosId int primary key identity(1,1),
	Descripcion varchar(40),
	Mantenimiento money
);
go
create table Talleres
(

    TallerId int primary key identity(1,1),
	Nombre varchar(30),

);
go

go
create table RegistrodeMantenimientoes
(
			MantenimientoId int primary key identity(1,1),
			VehiculoId int,
            Fecha date,
			Subtotal money,
			itbis money,
			Total money
);
go

go
create table RegistrodeMantenimientoDetalles
(
			Id int primary key identity(1,1),
			MantenimientoId int,
            TallerId int,
            ArticulosId int,
            Articulo varchar(40),
            Cantidad int,
            Precio int,
            Importe int
      
);
go

go
create table RegistroEntradaDeArticulos
(
			EntradaId int primary key identity(1,1),
            Fecha date,
            ArticuloId int,          
            Cantidad int
           
      
);
go

go
create table RegistrodeArticulos
(
			ArticulosId int primary key identity(1,1),
            Descripcion varchar(40),
            costo money,
            Ganancia int,
            precio money,
            Inventario int
); 
go


select * from RegistrodeArticulos
select * from RegistroEntradaDeArticulos
select * from Talleres
select * from Vehiculos
select* from RegistrodeMantenimientoDetalles
select* from RegistrodeMantenimientoes




truncate table RegistrodeArticulos
truncate table RegistroEntradaDeArticulos
truncate table Talleres
truncate table Vehiculos
truncate table RegistrodeMantenimientoDetalles
truncate table RegistrodeMantenimientoes

