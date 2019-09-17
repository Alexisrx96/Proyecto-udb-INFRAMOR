use InstitutoBD
go
create PROCEDURE PC_BuscarUsuario
    @condicion varchar(20)
AS
begin
    SELECT * from Usuarios 
	where Id like @condicion+'%' or NombresUsuario like @condicion+'%'
end
GO
CREATE PROCEDURE PC_InsertarUsuario
    @Id int, 
	@Nombre varchar(15), 
	@Apellido varchar(15),
	@NomUsuario varchar(10), 
	@Contraseña varchar(20),
	@Rol varchar(15),
	@Estado varchar(10)
AS
begin
    INSERT INTO  Usuarios VALUES
	(@Id,@Nombre,@Apellido,@NomUsuario,@Contraseña,@Rol,@Estado)
end
GO
CREATE PROCEDURE PC_EliminarUsuario
    @Condicion int
AS
begin
    Delete from Usuarios
	where Id = @Condicion
end
