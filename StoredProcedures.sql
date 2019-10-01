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
--Buscar Usuarios por NombUsuario
CREATE PROCEDURE SP_BuscarUsuarios
    @condicion varchar(20)
AS
BEGIN
    SELECT NombresUsuario,ApellidosUsuario,NomUsuario,EstadoActivo from Usuarios 
	WHERE NomUsuario  LIKE @condicion+'%'
END
GO
--Buscar a un usuario en específico por NombUsuario
CREATE PROCEDURE SP_BuscarUsuario
    @condicion varchar(20)
AS
BEGIN
    SELECT NombresUsuario,ApellidosUsuario,NomUsuario,EstadoActivo from Usuarios 
	WHERE NomUsuario  = @condicion
END
GO
CREATE PROCEDURE SP_InsertarUsuario
	@NombresUsuario  varchar(25), 
	@ApellidosUsuario  varchar(25),
	@NomUsuario  varchar(20), 
	@Contrasenia  nvarchar(25),
	@Estado bit
AS
BEGIN
    INSERT INTO  Usuarios(NombresUsuario,ApellidosUsuario,NomUsuario,Contrasenia,EstadoActivo) VALUES
	(@NombresUsuario,@ApellidosUsuario,@NomUsuario,HASHBYTES('SHA2_256', HASHBYTES('SHA2_512',@Contrasenia)),@Estado)
END
GO
CREATE PROCEDURE SP_EliminarUsuario
    @NomUsuario varchar(20)
AS
BEGIN
    Delete from Usuarios
	WHERE NomUsuario = @NomUsuario
END
GO
CREATE PROCEDURE SP_ComprobarUsuario
    @NomUsuario varchar(20),
	@Contrasenia nvarchar(25)
AS
BEGIN
    SELECT * from Usuarios
	WHERE NomUsuario = @NomUsuario AND Contrasenia = HASHBYTES('SHA2_256', HASHBYTES('SHA2_512',@Contrasenia))
END
GO
CREATE PROCEDURE SP_EditarUsuario
	@NombresUsuario  varchar(25), 
	@ApellidosUsuario  varchar(25),
	@NomUsuario  varchar(20),
	@Estado bit,
	@Condicion varchar(20)
AS
BEGIN
    UPDATE Usuarios 
	SET NombresUsuario = @NombresUsuario,
		ApellidosUsuario = @ApellidosUsuario, 
		NomUsuario = @NomUsuario,
		EstadoActivo = @Estado
	WHERE NomUsuario = @Condicion
END
GO
CREATE PROCEDURE SP_InsertarAlumna
@IdAlumna char(8),
@NombreAlumna varchar(25),
@ApellidoAlumna varchar(25),
@Nie int,
@AnioIngreso int,
@AnioEgreso int,
@FechaNacimiento date,
@IdLugarNacimiento tinyint,
@NombrePadre varchar(max),
@NombreMadre varchar(max)
AS
BEGIN
	INSERT INTO Alumnas VALUES
	(@IdAlumna,@NombreAlumna,@ApellidoAlumna,@Nie,@AnioIngreso,@AnioEgreso,@FechaNacimiento,@IdLugarNacimiento,@NombrePadre,@NombreMadre)
END
GO
CREATE PROC SP_EditarAlumna
@IdAlumna char(8),
@NombreAlumna varchar(25),
@ApellidoAlumna varchar(25),
@Nie int,
@AnioIngreso int,
@AnioEgreso int,
@FechaNacimiento date,
@IdLugarNacimiento tinyint,
@NombrePadre varchar(max),
@NombreMadre varchar(max),
@Condicion char(8)
AS
BEGIN
	UPDATE Alumnas
	SET IdAlumna = @IdAlumna,
		NombresAlumna = @NombreAlumna,
		ApellidosAlumna = @ApellidoAlumna,
		NIE=@Nie,
		AnioIngreso=@AnioIngreso,
		FechaNacimiento=@FechaNacimiento,
		IdLugarNacimiento=@IdLugarNacimiento,
		NombrePadre=@NombrePadre,
		NombreMadre=@NombreMadre
		WHERE IdAlumna =@Condicion
END
GO
CREATE PROCEDURE SP_EliminarAlumna
    @IdAlumna char(8)
AS
BEGIN
    Delete from Alumnas
	WHERE IdAlumna = @IdAlumna
END
GO