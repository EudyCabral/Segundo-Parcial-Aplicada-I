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

use SegundoParcialDbs
go
INSERT INTO Vehiculos(Descripcion,Mantenimiento)
VALUES ('Toyota Corolla 2005 LE',0);

go
INSERT INTO Vehiculos(Descripcion,Mantenimiento)
VALUES ('Honda CRV 2015 Touring',0);



select * from Vehiculos

truncate table Vehiculos