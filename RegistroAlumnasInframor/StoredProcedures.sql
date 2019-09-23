USE MASTER
GO
USE InstitutoBD
GO
--Listar Departamentos
CREATE PROC SP_ListarDepartamentos
AS
SELECT * FROM LugaresNacimiento
ORDER BY NombreDepartamento ASC
GO
--Listar Grados
CREATE PROC SP_ListarGrados
AS
SELECT * FROM Grados
ORDER BY NombreGrado ASC
GO
--Listar Materias
CREATE PROC SP_ListarMaterias
AS
SELECT * FROM Materias
ORDER BY NombreMateria ASC
GO
--Listar Tipos de Notas
CREATE PROC SP_ListarTiposNotas
AS
SELECT * FROM TiposNotas
ORDER BY TipoNota ASC
GO
--Buscar Usuarios por Nombre o NombUsuario
CREATE PROCEDURE SP_BuscarUsuario
    @condicion varchar(20)
AS
begin
    SELECT * from Usuarios 
	where NomUsuario  like @condicion+'%' or NombresUsuario like @condicion+'%'
end
GO
CREATE PROCEDURE PC_InsertarUsuario
    @IdUsuarios  char(8), 
	@NombresUsuarios  varchar(25), 
	@ApellidosUsuarios  varchar(25),
	@NomUsuarios  varchar(20), 
	@Contrasenias  varbinary(max),
	@Roles bit,
	@Estados bit
AS
begin
    INSERT INTO  Usuarios VALUES
	(@IdUsuarios,@NombresUsuarios,@ApellidosUsuarios,@NomUsuarios,@Contrasenias,@Roles,@Estados)
end
GO
CREATE PROCEDURE PC_EliminarUsuario
    @Condicion int
AS
begin
    Delete from Usuarios
	where IdUsuario = @Condicion
end