create database tecnologia;

use tecnologia; 

create table trabajadores(
usuario varchar (100),
contrasena varchar (100),
roll varchar (50),
);

insert into trabajadores values('kevin godinez','marzo30','administrador');
insert into trabajadores values('carla godoy','marzo12','secretaria');
insert into trabajadores values('estuardo chavez','enero04','cliente');

select *from trabajadores;

drop database trabajadores;

create proc _iniciosesion
@usuario varchar (25),
@contrasena varchar (25)
as 
select *from trabajadores where
usuario=@usuario and contrasena=@contrasena
 