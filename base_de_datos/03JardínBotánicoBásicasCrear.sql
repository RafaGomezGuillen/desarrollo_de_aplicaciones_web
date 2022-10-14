--Crear base de datos
create database JardinBotanicoBasicas;
--go
--http://www.jardinbotanico.org/parque-jardin-botanico-de-moraleja-de-enmedio/familias-de-plantas/
use JardinBotanicoBasicas;
go

--eliminar tablas

if object_id('Planta') is not null
  drop table Planta;
  go
if object_id('Familia') is not null
  drop table Familia;
  go


--Crear tabla Familia
create table Familia
(		
	CodFamilia 	integer,
	Familia	varchar(50)
);
go
--Crear tabla Planta
create table Planta
(		
	CodPlanta 	integer,
	DescripcionPlanta	varchar(50),
	CodFamilia integer,
	Precio decimal(6,2)
);
go



--Cargar datos
insert Familia (CodFamilia,Familia)
	values
	(1,'CYPERACEAE');
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (1,'Scyrpus Holoschoenus',1,23);
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (2,'Scyrpus lacustris',1,14);

insert Familia (CodFamilia,Familia)
	values
	(2,'CUCURBITACEAE');
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (3,'Cucumis melo',2,4);
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (4,'Cucurbita pepo',2,12);

insert Familia (CodFamilia,Familia)
	values
	(3,'PINACEAE-ABIETACEAE');
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (5,'Pinus pinea',3,45);
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (6,'Cedrus deodara',3,23.30);
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (7,'Cedrus libani',3,10.40);		

insert Familia (CodFamilia,Familia)
	values
	(4,'PLATANACEAE');
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (8,'Platanus hispánica',4,12.50);
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (9,'Platanus orientalis ',4,14.30);

insert Familia (CodFamilia,Familia)
	values
	(5,'ROSACEAE');
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (10,'Fragaria X ananassa',5,1.05);
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (11,'Prunus pérsica',5,2.30);
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (12,'Prunus avium',5,6.20);

insert Familia (CodFamilia,Familia)
	values
	(6,'RUTACEAE');
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (13,'Agave americana',6,20.30);
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (14,'Dracaena indivisa',6,3.20);

insert Familia (CodFamilia,Familia)
	values
	(7,'RUBIACEAE');
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (15,'Citrus limón',7,10.20);
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (16,'Citrus sinensis',7,12.30);
insert Planta (CodPlanta,DescripcionPlanta,CodFamilia,Precio)	
	values (17,'Skimmia japonica',7,17.35);
go

create table Personal (
	ID int primary key identity,
	DNI char(9),
	Nombre varchar(100),
	Puesto char(20),
	FechaDeNacimiento datetime,
	NHijos int
);
go

create table Prueba (
	ID int,
	Dato char(20)
);
go

insert Prueba (ID, Dato) values (1, 'elemento1');
insert Prueba (ID, Dato) values (2, 'elemento2');
go

select ID, Dato from Prueba;
go

delete from Prueba where ID = 2;
go

drop table Prueba;
go

select * from Prueba;
go

set dateformat dmy;
go

set identity_insert Personal off;
go

insert Personal (DNI, Nombre, Puesto, FechaDeNacimiento, NHijos) values ('32456789H', 'María','Jefa','27/3/1975', null);
insert Personal (DNI, Nombre, Puesto, FechaDeNacimiento, NHijos) values ('23456789W','Juan','Técnico','23/4/1968', null);
insert Personal (DNI, Nombre, Puesto, FechaDeNacimiento, NHijos) values ('45454545J','Ana','Jardinero','21/1/1980', null);
go

set identity_insert Personal on;
go

insert Personal (ID, DNI, Nombre, Puesto, FechaDeNacimiento, NHijos) values (33,'65656546G','Antonio','Jardinero','23/05/1978', null);
go

delete from Personal where DNI = '65656546G';
go

select Precio from Planta where Precio > 20;
go

select CodFamilia from Familia where Familia = 'Cyperaceae';
go

select DescripcionPlanta from Planta where Precio = 12.30;
go

update Planta set Precio = Precio + 1 where Precio < 5;
go

select Familia from Familia where CodFamilia = 5;
go

update Familia set Familia = 'Rosaceae officinalis' where CodFamilia = 5;
go

if DB_ID('JardinBotanicoBasicas') is null
	 create database JardinBotanicoBasicas;
else
	 drop database JardinBotanicoBasicas
	 create database JardinBotanicoBasicas;
go

select @@LANGUAGE;
go

set language Español;
go

