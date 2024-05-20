use BibliotecaWebG2_p;


drop table Usuarios;

select * from libros;
select * from Usuarios;

create table Usuarios(
Email varchar(150) not null primary key,
NombreCompleto varchar(150) not null,
Password varchar(200) not null,
Restablecer char not null default 'S',
FechaRegistro datetime not null default GETDATE(),
Estado char not null default 'A')

insert into Usuarios(Email,NombreCompleto,Password)
values ('admin@gmail.com','Administrador','admin')