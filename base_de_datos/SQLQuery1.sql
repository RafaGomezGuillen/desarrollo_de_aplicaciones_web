--1
create table Paises (
	idPais int primary key identity,
	pais varchar(50) not null,
	codPais char(3) not null
);

--2 
set identity_insert Paises on;
insert into Paises (idPais, pais, codPais) values (1, 'Italia', '001');

select *
from Paises;

set identity_insert Paises off;
insert into Paises (pais, codPais) values ('Alemanio', '002');

insert into Paises (pais, codPais) values (null, '002');

--3
update PuntuacionBasicas
set Fecha = DATEADD(MONTH,1,Fecha)
where Plataforma = 'PC';

--4
delete from Paises
where idPais > 1

select * 
from Paises;

--5
select COUNT(Juego) as CuantosJuegosHay, Plataforma, Tipo
from Juegos
where Plataforma = 'PS3' and Tipo = 'Acción'
group by Plataforma, Tipo;

--6
select top 2 Nombre, FechaNacimiento
from Cliente
where Email like '%.ca' and DATEPART(MONTH, FechaNacimiento) = 5
order by FechaNacimiento desc;

--7
select top 3 COUNT(distinct Juego) as Juegos, Desarrollador, Tipo
from Juegos
where Desarrollador like 'B%' and Tipo = 'Acción'
group by Desarrollador, Tipo
order by COUNT(distinct Juego) desc;

--8
select COUNT(Nombre) as NumeroDeClientes, DATENAME(DW, FechaRegistro) as DiaDeLaSemana
from Cliente
group by DATEPART(DW, FechaRegistro), DATENAME(DW, FechaRegistro)
order by DATEPART(DW, FechaRegistro) asc;

--9
select Plataforma, COUNT(Puntuacion) as NumeroPuntaciones, 
	   SUM(Puntuacion) as SumaPuntuacion, COUNT(distinct Juego) as NumeroJuegosDistintos
from PuntuacionBasicas
group by Plataforma
having COUNT(Puntuacion) > 6
order by SUM(Puntuacion) desc;

--10
select UPPER(NombreCliente) as NombreCliente,
	   COUNT(Puntuacion) as NumeroPuntuaciones, AVG(Puntuacion) as Media
from PuntuacionBasicas
group by NombreCliente
having AVG(Puntuacion) > 5 and COUNT(Puntuacion) > 1
order by AVG(Puntuacion) desc;


