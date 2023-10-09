USE Banco;

CREATE TABLE Client
(
	idCiente int not null primary key,
	apellido varchar(50) not null,
	nombre varchar(50) not null,
	email varchar(50) not null,
	cuilcuit varchar(50) not null,
	estado int
);