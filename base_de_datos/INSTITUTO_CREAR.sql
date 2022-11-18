CREATE DATABASE INSTITUTO
GO
use INSTITUTO
go

if OBJECT_ID('alumnos') is not null
drop table alumnos

create table alumnos(
    expediente char(6) primary key,
	nombre varchar(50),
	localidad varchar(50),
	fecha_nac datetime,
	direccion varchar(50),
	curso int,
	nivel varchar(10),
	faltas int,
	beca int);
	

insert into alumnos values(123456,'Juan Miguel Soler Bakero','Murcia','10/10/07','Gran Via, 2, 4A',1,'ESO',15,200);
insert into alumnos values(654321,'Laura Gomez Fernandez','Lorca','10/05/06','Junterones, 10, 5B',2,'ESO',25,null);
insert into alumnos values(765432,'Beatriz Martinez Hernandez','Murcia','05/05/05','Plaza Mayor, 6, 3B',3,'ESO',5,null);
insert into alumnos values(987654,'Diego Marin Llorente','Alhama de Murcia','03/06/02','Diego de la Cierva, 5, 7A',1,'BACHILLER',34,null);
insert into alumnos values(445544,'Juan Francisco Cano Riquelme','Murcia','01/07/04','Plaza de Belluga, 3, 4A',4,'ESO',13,500);
insert into alumnos values(998867,'Leonor Sanchez Fernández','Murcia','03/01/04','Torre de Romo, 8',4,'ESO',5,null);
insert into alumnos values(223322,'Raquel Riquelme Rubio','Lorca','05/11/02','San Juan, 14, 3B',1,'BACHILLER',7,1000);
insert into alumnos values(998887,'Cristina Sanchez Bermejo','Murcia','03/10/07','Torre de Romo, 7',1,'ESO',1,null);
insert into alumnos values(334455,'Pedro Jesus Rodriguez Soler','Alhama de Murcia','10/03/06','Camino de Badel, 4',2,'ESO',11,750);
insert into alumnos values(334400,'Javier Ramonez Rodriguez','Murcia','05/02/05','Gran V’a, 4, 3A',3,'ESO',0,null);
insert into alumnos values(993322,'Gema Rubio Colero','Lorca','09/09/04','Plaza Fuensanta, 5, 7A',1,'BACHILLER',19,1000);
insert into alumnos values(555511,'Joaquin Hernandez Gonzalez','Lorca','12/12/03','Junterones, 4, 5A',2,'BACHILLER',14,null);
insert into alumnos values(554477,'Marcos Lopez Gonzalez','Murcia','11/10/03','C/ Peñón 111, 1A',2,'BACHILLER',15,500);
insert into alumnos values(554444,'Gustavo Bueno Gonzalez','Murcia','11/10/04','C/ San Juan 12, 3A',1,'BACHILLER',15,750);

--1
select nombre, faltas, beca 
from alumnos
where faltas > 15 and beca is not null;

update alumnos
set beca = beca - (beca * 0.10)
where faltas > 15 and beca is not null;

select nombre, faltas, beca 
from alumnos
where faltas > 15 and beca is not null;

--2 
select nombre, localidad, curso, nivel
from alumnos
where nombre like '%ez%' and localidad like '%ca'
order by nivel asc, curso asc;

--3
select UPPER(nombre) as NombreMayuscula, str(curso,1,0)+ 'º de la ESO' as CursoESO
from alumnos
where curso <= 3 and nivel = 'ESO'
order by curso asc;

--4 
select COUNT(nombre) as AlumnosMatriculados
from alumnos;

--5
select COUNT(nombre) as CuantosAlumnosHay, curso, nivel, COUNT(beca) as CuantosTienenBeca
from alumnos
group by curso, nivel
order by curso asc, nivel asc;

--6
select curso, nivel, SUM(beca) as TotalBeca
from alumnos
group by curso, nivel
having AVG(beca) > 200;

--7
select top 2 DATENAME(MONTH, fecha_nac) as Mes
from alumnos
group by DATENAME(MONTH, fecha_nac)
order by COUNT(MONTH(fecha_nac)) desc;

--8
select nombre, DATEDIFF(YEAR, fecha_nac, GETDATE()) as Edad, 
	   DATENAME(DW, fecha_nac) as DiaSemanaNacimiento
from alumnos
where beca is null;

--9 
select nombre, curso, DATEDIFF(YEAR, fecha_nac, GETDATE()) as Edad
from alumnos
where DATEDIFF(YEAR, fecha_nac, GETDATE()) between 15 and 17

--10
select top 1 curso, COUNT(nombre) as NumeroMatriculado
from alumnos
group by curso;

