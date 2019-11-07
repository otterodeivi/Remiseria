CREATE DATABASE remiseria;

USE remiseria;

CREATE TABLE chofer(
idChofer int identity(1,1) primary key,
nombre varchar(40),
apellido varchar(40),
dni int,
direccion varchar(50),
telefono int
);

CREATE TABLE socios(
idSocio int identity(1,1) not null,
dni int not null,
nombre varchar(40),
apellido varchar(40),
telefono varchar(40)
constraint pk_socio_pk primary key(idSocio, dni)
);

CREATE TABLE vehiculo(
idVehiculo int identity(1,1) primary key,
duenio varchar(40),
modelo varchar(40),
marca varchar(40),
color varchar(30),
anio date,
dominio varchar(30),
seguro varchar(40),
venc_gnc date,
venc_vtv date
);

CREATE TABLE viajes(
registro int identity(1,1) primary key,
idChofer int,
idSocio int,
idVehiculo int,
fecha_origen datetime,
fecha_destino datetime,
total decimal(7,2),
origen varchar,
destino varchar,
reserva bit,
cta_cte bit,
estado varchar(20)
);

CREATE TABLE turnos(
idTurno int identity(1,1) primary key,
idChofer int,
idVehiculo int,
ingreso datetime,
egreso datetime,
turno varchar,
disponible bit
);

CREATE TABLE liqCtaCte(
registro int identity(1,1) primary key,
idSocio int,
desde date,
hasta date,
monto decimal(7,2)
);

CREATE TABLE resumenRemiseria(
registro int identity(1,1) primary key,
fecha datetime,
monto decimal(7,2)
);

CREATE TABLE valores(
id int identity(1,1) primary key,
dueño int,
remiseria int,
kms int,
minimo decimal(7,2)
);


CREATE PROCEDURE altaChofer
@nombre varchar(40),
@apellido varchar(40),
@dni int,
@direccion varchar(50),
@telefono int
as
insert into chofer values(@nombre,@apellido, @dni,
@direccion, @telefono);


CREATE PROCEDURE altaSocio
@dni int ,
@nombre varchar(40),
@apellido varchar(40),
@telefono varchar(40)
as
insert into Socios values(@dni, @nombre, @apellido,
@telefono);


CREATE PROCEDURE altaVehiculo
@duenio varchar(40),
@modelo varchar(40),
@marca varchar(40),
@color varchar(30),
@anio date,
@dominio varchar(30),
@seguro varchar(40),
@venc_gnc date,
@venc_vtv date
as
insert into vehiculo values (@duenio, @modelo, @marca,
@color, @anio, @dominio, @seguro, @venc_gnc, @venc_vtv);

