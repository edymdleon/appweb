Declare @NuevaTabla as varchar(255)
Set @NuevaTabla = 'Ant_Usuario_' + Replace(replace(convert(varchar,GETDATE()), ' ', '_'), ':', '')
Exec sp_rename 'Usuario', @NuevaTabla
go
Create Table Usuario
     ( IdUsuario	                Int Identity Primary Key
     , NombreUsuario            	Varchar(255) Not Null
	 , Email		            	Varchar(255) Not Null
	 , FechaNacimiento            	Varchar(100) Not Null
     , FechaHoraModifica      		Datetime     Null
     , UsuarioModifica        		Int          Null
     , EstadoRegistro         		Char(1)      Not Null   --A=Activo, I=Inactivo
     , Token                  		As (CONVERT([varchar](32),hashbytes('MD5',CONVERT([varchar](32),[IdUsuario],(2))),(2))) PERSISTED
     )
go
Insert Usuario (NombreUsuario,Email, FechaNacimiento, FechaHoraModifica, UsuarioModifica, EstadoRegistro)
Select 'Administrador','admin@mail.com','19/10/1989', Getdate(), 1, 'A'
Union All
Select 'Supervisor','super@mail.com','23/09/1992', Getdate(), 1, 'A'
go
