Declare @NuevaTabla as varchar(255)
Set @NuevaTabla = 'Ant_Empleado_' + Replace(replace(convert(varchar,GETDATE()), ' ', '_'), ':', '')
Exec sp_rename 'Empleado', @NuevaTabla
go
Create Table Empleado
     ( IdEmpleado             Int Identity Primary Key
     , NombreCompleto         Varchar(255) Not Null
	 , DPI				      Int          Null
	 , CantidadHijos          Int          Null
	 , SalarioBase			  float		   Null
	 , BonoDecreto			  float 	   Null
     , FechaHoraModifica      Datetime     Null
     , UsuarioModifica        Int          Null
     , EstadoRegistro         Char(1)      Not Null   --A=Activo, I=Inactivo
     , Token                  As (CONVERT([varchar](32),hashbytes('MD5',CONVERT([varchar](32),[IdEmpleado],(2))),(2))) PERSISTED
     )
go
Insert Empleado (NombreCompleto, DPI, CantidadHijos,SalarioBase,BonoDecreto, FechaHoraModifica, UsuarioModifica, EstadoRegistro)
Select 'Mario Enrique De la cruz paz',243493493,3,3500,250, Getdate(), 1, 'A'
Union All
Select 'Luis Alfredo Merida Gonzalez',243493493,2,3500,250, Getdate(), 1, 'A'
Union All
Select 'Carlos Patricio Monroy Salgado',243493493,1,3500,250, Getdate(), 1, 'A'
Union All
Select 'Marcos Fernando Alfaro Villatoro',243493493,4,3500,250, Getdate(), 1, 'A'
Union All
Select 'Alberto Daniel Cortes Cabral',243493493,1,4500,250, Getdate(), 1, 'A'
go
