create database PrestamoLibros;

use PrestamoLibros;
if object_id ('libros') is not null drop table libros;
 create table libros(
 codigo int identity,
 titulo varchar(40) not null,
 autor varchar(20) default 'Desconocido',
 editorial varchar(20),
 precio decimal(6,2),
 cantidad int default 0,
 primary key (codigo)
);

insert into libros (titulo,autor,editorial,precio) values('El aleph','Borges','Emece',25);
insert into libros values('Java en 10 minutos','Mario Molina','Siglo XXI',50.40,100);
insert into libros (titulo,autor,editorial,precio,cantidad) values('Alicia en el pais de las maravillas','Lewis Carroll','Emece',15,50);gouse PrestamoLibros;-- Mostrar las 3 primeras letras de todos los ttulos.
select LEFT(titulo, 3) from libros;
-- Mostrar el precio como cadena de caracteres.
select str(precio,7,3)from libros;
-- Mostrar la cadena con el ttulo, un guión, el autor un guión y el precio.
select titulo +' - '+autor +' - '+str(precio,7,3)+' euros ' as column1 from libros;
-- Mostrar las seis últmas letras del ttulo y del autor.
select RIGHT(titulo, 6), RIGHT(autor, 6) from libros;
select SUBSTRING(titulo, len(titulo)- 5, 6), SUBSTRING(autor, len(autor) - 5, 6) from libros;
-- Mostrar el nombre del autor en mayúscula.
select UPPER(autor) from libros;
-- Indicar el número de letras del autor y del ttulo.
select LEN(autor), LEN(titulo) from libros;
-- Mostrar los caracteres del 4 al 10 del autor
select SUBSTRING(autor, 4, 7) from libros;
-- Cambiar arroba por el carácter arroba y punto por el carácter
-- punto en el texto correoarrobahotmailpuntocom select REPLACE('correoarrobahotmailpuntocom', 'arroba', '@');select REPLACE('correoarrobahotmailpuntocom', 'punto', '.');select REPLACE (REPLACE('correoarrobahotmailpuntocom', 'arroba', '@'), 'punto', '.');