create database SegundoParcialDbs
go
use SegundoParcialDbs
go
create table Vehiculos
(
    VehiculosId int primary key identity(1,1),
	Descripcion varchar(40),
	Mantenimiento int
);
go
create table Talleres
(

    TallerId int primary key identity(1,1),
	Nombre varchar(30),

);
go

go
create table RegistroEntradaDeArticulos
(
			EntradaId int primary key identity(1,1),
            Fecha date,
            Articulos varchar(40),
            Cantidad int
);
go

select * from RegistrodeArticulos
select * from Vehiculos
select * from RegistroEntradaDeArticulos
select * from Talleres

use SegundoParcialDbs
go
INSERT INTO Vehiculos(Descripcion,Mantenimiento)
VALUES ('Toyota Corolla 2005 LE',0);

go
INSERT INTO Vehiculos(Descripcion,Mantenimiento)
VALUES ('Honda CRV 2015 Touring',0);





