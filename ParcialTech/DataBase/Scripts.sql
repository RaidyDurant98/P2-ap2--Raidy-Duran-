create table Retenciones(
RetencionId int identity(1,1) primary key,
Descripcion varchar(100),
Valor float
);

create table TiposEmails(
TipoId int identity(1,1) primary key,
Descripcion varchar(100)
);