create database ReservaHotel;

create table cliente(
Cedula int not null,
TipoCedula varchar(150) not null,
NombreCompleto varchar(150) not null,
Telefono decimal(8) not null,
Direccion varchar(150),
email varchar(150) not null,
primary key(Cedula));


create table Paquete(
tipoPaquete varchar(150) not null,
prima decimal not null,
tiempo int not null,
montoTotal decimal not null);


select * from Paquete;
select * from Cliente;


