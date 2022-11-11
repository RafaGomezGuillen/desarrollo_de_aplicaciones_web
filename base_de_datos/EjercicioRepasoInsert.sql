--cargar datos
set dateformat  dmy
go
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 1,'Antonio','C/uno nº 3','S/C Tenerife','01/03/2012','15/04/1970')
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 2,'Juan','C/la hornera nº 7','S/C Tenerife' ,'22/05/2012','29/06/1982' )
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 3,'María','C/el pino nº 7','La Laguna','22/05/2010','15/06/1960')
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 7,'Ana','C/el monte nº 6','S/C Tenerife','15/10/2012','26/12/1963')
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 12,'Juana','C/la estaca nº 77','S/C Tenerife','23/05/2009','15/12/1963')
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 22,'Los Espacios S.L.','Rambla nº 17','S/C Tenerife','15/04/2012',null)
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 33,'La Reserva S.A.','Puerto nº 66','S/C Tenerife','23/12/2011',null)
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 66,'TITSA','Intercambiador','La Laguna','14/08/2012',null)
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 99,'Contado','Sin datos','S/C Tenerife','23/1/2010',null)
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 80,'Juana María','C/La hoguera 23','S/C Tenerife','23/10/2010','26/12/1963')
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 81,'Fernando','Av Los Majuelos 7','S/C Tenerife','15/1/2010','2/11/1968')
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 82,'Isabel','Finca España','La Laguna','17/12/2011','14/5/1975')
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 83,'Ana Luisa','C/la una nº 34','S/C Tenerife','24/6/2012','26/05/1950')
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 84,'Francisco Javier',default,'Tacoronte','15/7/2010',null)
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 85,'María Luisa','C/La laguna nº 77','S/C Tenerife','18/6/2011',null)
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 86,'Antonio Juan',default,'S/C Tenerife','19/1/2010','12/12/1980')
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 87,'José',default,'Adeje','3/12/2011',null)
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 88,'Mauricio',default,'S/C Tenerife','14/8/2012','15/06/1980')
insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaAlta,FechaNacimiento )  values ( 89,'Elena','Sin datos','La Laguna','23/1/2010',null)
go

insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 22,'llave ajustable 200mm','Herramienta',12.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 25,'llave allen 1.5','Herramienta',6.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 28,'llave combinada 6','Herramienta',5.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 36,'martillo bellota','Herramienta',10.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 37,'martillo ebanista','Herramienta especializada',13.20 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 39,'destornillador plano','Herramienta',1.55 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 40,'destornillador philips','Herramienta',2.25 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 46,'tenaza','Herramienta especializada',2.34 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 50,'mordaza bloqueable','Accesorios',10.25 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 60,'alicate pelacables','Herramienta especializada',10.15 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 75,'alicate corte diagonal','Herramienta especializada',13.20 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 80,'taladro sin cable especial','Herramienta eléctrica',102.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 90,'taladro atornillador sin cable','Herramienta eléctrica',145.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 98,'taladro con cable','Herramienta eléctrica',76.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 105,'destornillador eléctrico sin cable','Herramienta eléctrica',80.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 110,'sierra de calar','Herramienta eléctrica',12.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 120,'sierra circular','Herramienta eléctrica',112.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 150,'lijadora orbital','Herramienta eléctrica',110.00 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 300,'tornillo 3mm','Tornillería',0.20 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 310,'tuerca 3mm','Tornillería',0.10 )
insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 888,'tornillo redondo','Tornillería',23.50 )
go

create database Facturas;

if object_id('FAC_T_Articulo') is not null
drop table FAC_T_Articulo; 

use Facturas;
create table FAC_T_Articulo (
	CodArticulo int primary key,
	NombreArticulo varchar(50) unique,
	TipoArticulo varchar(50),
	PrecioActual numeric(10,2)
);

if object_id('FAC_T_Cliente') is not null
drop table FAC_T_Cliente; 

create table FAC_T_Cliente(
	CodCliente int primary key,
	NombreCliente varchar(60) not null,
	DatosCliente varchar(60) default 'Desconocida',
	Municipio varchar(50),
	FechaAlta datetime default getdate(),
	FechaNacimiento datetime null
);

insert FAC_T_Articulo ( CodArticulo,NombreArticulo,TipoArticulo,PrecioActual )  values ( 205,'Sierra circular especial','Herramienta eléctrica', 158.50 );insert FAC_T_Cliente ( CodCliente,NombreCliente,DatosCliente,Municipio,FechaNacimiento )  
values ( 45,'Laura González González','C/La Marina nº 3','S/C Tenerife', '25/09/1990');

update FAC_T_Articulo
set PrecioActual = PrecioActual + PrecioActual * 0.1
where PrecioActual <= 5

select PrecioActual
from FAC_T_Articulo
where PrecioActual <= 5

select Municipio, DatosCliente, NombreCliente, FechaNacimiento
from FAC_T_Cliente
where NombreCliente = 'Laura González González';

set dateformat dmy;
update FAC_T_Cliente
set Datoscliente = 'C/Esmeralda nº 7', FechaNacimiento = '29/09/1990'
where NombreCliente = 'Laura González González';

select *
from FAC_T_Articulo
where PrecioActual < 1;

delete 
from FAC_T_Articulo
where PrecioActual < 1;

select NombreArticulo, PrecioActual
from FAC_T_Articulo;

select NombreCliente, DatosCliente, convert(varchar,FechaNacimiento,103) as DiaMesAnio, DATEDIFF(YEAR, FechaNacimiento, GETDATE()) as NumeroAnio 
from FAC_T_Cliente
where DATEPART(MONTH, FechaNacimiento) = 6
order by DATEDIFF(YEAR, FechaNacimiento, GETDATE()) asc;

select CodArticulo, NombreArticulo, PrecioActual
from FAC_T_Articulo
where PrecioActual between 10 and 50
order by PrecioActual desc;

select NombreCliente, DATENAME(MONTH, FechaAlta) as MES
from FAC_T_Cliente
where DATENAME(MONTH, FechaAlta) in ('enero', 'marzo', 'abril', 'junio');

select NombreArticulo
from FAC_T_Articulo
where NombreArticulo like '%[1-9]%'

select NombreCliente + ' -- ' + str(CodCliente,2,0) as 'datos cliente', DATEPART(YEAR, FechaAlta) as Anio
from FAC_T_Cliente

select NombreCliente
from FAC_T_Cliente
where FechaAlta is not null and DATENAME(MONTH, FechaAlta) = 'mayo';

select *
from FAC_T_Articulo
where PrecioActual > 2 and NombreArticulo like '%destornillador%';

select NombreCliente, FechaAlta
from FAC_T_Cliente
where DATENAME(MONTH, FechaAlta) in ('enero', 'marzo', 'mayo');

select NombreCliente, CodCliente, DATEDIFF(MONTH, FechaAlta, GETDATE()) as 'meses de antigüedad'
from FAC_T_Cliente
order by NombreCliente;

select NombreCliente, DATENAME(DW, FechaAlta) as DiaSemanaDeAlta
from FAC_T_Cliente
order by FechaAlta asc; 

EXEC sp_columns @Table_name = 'FAC_T_Cliente'; 

select COUNT(NombreCliente) as ContarClientes
from FAC_T_Cliente;

select COUNT(FechaNacimiento) as FechaNacimiento
from FAC_T_Cliente
where FechaNacimiento is not null;

select AVG(PrecioActual) as MediaPrecioArticulos
from FAC_T_Articulo
where TipoArticulo like  '%Herramienta%';

select TipoArticulo
from FAC_T_Articulo
group by TipoArticulo
order by TipoArticulo;

select TipoArticulo, COUNT(NombreArticulo) as CuantosArticulos
from FAC_T_Articulo
group by TipoArticulo
order by COUNT(NombreArticulo) desc;

select TipoArticulo, AVG(PrecioActual) as MediaPrecio
from FAC_T_Articulo
group by TipoArticulo
having COUNT(TipoArticulo) > 2;


select TOP 2 Municipio, COUNT(NombreCliente) as Clientes
from FAC_T_Cliente
group by Municipio
order by COUNT(NombreCliente) desc;

select TipoArticulo, MAX(PrecioActual) as PrecioMasAlto
from FAC_T_Articulo
group by TipoArticulo
order by MAX(PrecioActual) desc;

select Municipio, COUNT(*) - COUNT(FechaNacimiento) as ClientesConFecha, COUNT(FechaNacimiento) as ClientesSinFecha
from FAC_T_Cliente
group by Municipio; 

select DATENAME(MONTH, FechaNacimiento) as Mes, COUNT(NombreCliente) as CuantosClientes
from FAC_T_Cliente
where DATENAME(MONTH, FechaNacimiento) is not null
group by DATENAME(MONTH, FechaNacimiento), MONTH(FechaNacimiento)
order by MONTH(FechaNacimiento) asc;