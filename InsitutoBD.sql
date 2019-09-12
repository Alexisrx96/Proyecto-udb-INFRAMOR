
--****************************************************
------------------PROYECTO INFRAMOR-------------------
--------------BASE DE DATOS: InstitudoBD--------------
--****************************************************

--****************************************************
-------------CREACI�N DE LA BASE DE DATOS-------------
--****************************************************

   USE master;
   CREATE DATABASE InstitutoBD
   GO

--*********************************************************
------CREACI�N DE TABLAS (CON LLAVES / RESTRICCIONES)------
--*********************************************************

   USE InstitutoBD
   GO
   --Los comentarios deber�an ser m�s amigables (descriptivos)
-------------------TABLA: Usuarios-------------------

   CREATE TABLE Usuarios
   ( IdUsuario char(8) NOT NULL,  --los docentes tienen carnet? (duda existencial)                                          --Id del usuario
     NombresUsuario varchar(15),   --Puede quedar vac�o?                                               --Primer y segundo nombre del usuario
	 ApellidosUsuario varchar(15),   --Puede quedar vac�o?                                             --Primer y Segundo apellido del usuario
	 NomUsuario varchar(10) NOT NULL,    --si tienen carnet utilizar el carnet                                        --Nombre del usuario a utilizar para ingresar al programa
	 Contrase�a varchar(20) NOT NULL,  --�o e�es  --investigar el tama�o y como encriptar                                         --Contrase�a del usuario para ingresar al programa
	 Rol varchar(15),  --Puede quedar vac�o?                                                           --Rol asignado al usuario
	 Estado varchar(10) NOT NULL,       --podr�a ser boolean y cambiar a llamarse "Activo"                               --Estado (activo / inactivo) del usuario
	 CONSTRAINT PK_IdUsuario PRIMARY KEY (IdUsuario),                             --Llave primaria (PK) IdUsuario de la tabla Usuarios
	 CONSTRAINT U_NomUsuario UNIQUE(NomUsuario),                                  --Restricci�n UNIQUE donde el nombre del usuario (utilizado para ingresar) debe ser valor �nico
	 CONSTRAINT CK_Estado CHECK (Estado = 'Activo' OR Estado = 'Inactivo') )	--si es bool sobra	  --Restricci�n CHECK donde el usuario debe ser Activo o Inactivo
     

-----------------TABLA: Departamentos-----------------
  
   CREATE TABLE LugaresNacimiento
   ( IdLugarNacimiento char(8) NOT NULL, --puede ser int                                         --Id del lugar de nacimiento
     NombreDepartamento varchar(15),                                              --Nombre del departamento
	 CONSTRAINT PK_IdLugarNacimiento PRIMARY KEY (IdLugarNacimiento),             --Llave primaria (PK) de la tabla LugaresNacimientos
	 CONSTRAINT U_NomDepartamento UNIQUE(NombreDepartamento) )                    --Restricci�n UNIQUE donde el nombre del departamento es valor �nico

--------------------TABLA: Materias--------------------
  
   CREATE TABLE Materias
   ( IdMateria char(8) NOT NULL, --puede ser int                                                 --Id de la materia
     NombreMateria varchar(20),    --Puede quedar vac�o?                                               --Nombre de la materia
	 Area varchar(25),    --Area? Especificar                                                        --�rea a la cual pertenece la materia
	 CONSTRAINT PK_IdMaterias PRIMARY KEY (IdMateria),                            --Llave primaria (PK) de la tabla Materias
	 CONSTRAINT U_NombreMateria UNIQUE(NombreMateria) )                           --Restricci�n UNIQUE donde el nombre de la materia es valor �nico

---------------------TABLA: Grados----------------------
    
   CREATE TABLE Grados
   ( IdGrado char(8) NOT NULL, --puede ser int                                                   --Id del grado
     NombreGrado varchar(30), --Grado puede ir separado de secci�n                                                    --Nombre del grado
	 Seccion char(1),                                                            --Secci�n del grado
	 CantidadAlumnos tinyint,  -- se podr�a hacer un "count" y se calcula        --Cantidad de alumnos del grado
	 A�o date,             --e�e �o --pasarlo a GradosAlumnas                                                     --A�o del grado
	 Tipo varchar(15),    -- Puede ser tabla a parte                                                        --Tipo al que pertenece el grado (General / T�cnico)
	 CONSTRAINT PK_IdGrado PRIMARY KEY (IdGrado),                                 --Llave primaria (PK) de la tabla Grados
	 CONSTRAINT CK_Seccion CHECK (Seccion = 'A' OR Seccion = 'B' OR               --Restricci�n CHECK donde la secci�n debe ser A, B, C, D, E, F 
	  Seccion = 'C' OR Seccion = 'D' OR Seccion = 'E' OR Seccion = 'F'),
	 CONSTRAINT CK_Tipo CHECK (Tipo = 'General' OR Tipo = 'T�cnico' ) )           --Restricci�n CHECK donde el tipo del grado debe ser General o T�cnico

--------------TABLA: DatosGeneralesAlumnas--------------
   
   CREATE TABLE DatosGeneralesAlumnas -- considerar nombre de tabla (Alumna)
   ( IdAlumna char(8) NOT NULL,  --Dan carnet?                                                 --Id de la alumna
     NombresAlumna varchar(15),                                                   --Primer y segundo nombre de la alumna
	 ApellidosAlumna varchar(20),                                                 --Primer y segundo apellido de la alumna
	 NIE int,                                                                     --NIE de la alumma
	 A�oIngreso date,  --�O E�ES --Se puede obtener mediate consulta                                                           --A�o de ingreso de la alumna
	 A�oEgreso date,  --�O E�ES --Se puede obtener mediate consulta                                                           --A�o de egreso de la alumna
	 FechaNacimiento date,                                                        --Fecha de nacimiento de la alumna
	 IdLugarNacimiento char(8), --puede ser int (DEBE SERLO)                                                  --Id del lugar de nacimiento de la alumna
	 NombrePadre varchar(max),                                                    --Nombre completo del padre de la alumna
	 NombreMadre varchar(max),                                                    --Nombre completo de la madre de la alumna
	 CONSTRAINT PK_IdAlumna PRIMARY KEY (IdAlumna),                               --Llave primaria (PK) de la tabla DatosGeneralesAlumnas
	 CONSTRAINT U_NIE UNIQUE(NIE),    -- Los NIE se pueden repetir (Gracias MINED)                                            --Restriccion UNIQUE donde el NIE de la alumna debe ser�valor �nico
	 CONSTRAINT CK_A�oEgreso CHECK (A�oEgreso >= A�oIngreso),   --se puede ir si se elimina los otros                  --Restriccion CHECK donde el a�o de egreso de la alumna debe ser mayor o igual al a�o de ingeso
	 CONSTRAINT FK_DGA_IdLugarNacimiento FOREIGN KEY (IdLugarNacimiento)          --Llave foranea (FK) IdLugarNacimiento (PK en tabla LugaresNacimientos)
	 REFERENCES LugaresNacimiento(IdLugarNacimiento) )

--------------TABLA: DatosPersonalesAlumnas--------------

   CREATE TABLE DatosPersonalesAlumnas  --considerar nombre de tabla (Encargado)
   ( IdDatoAlumna char(8) NOT NULL,                                             --Id de los datos personales de la alumna
     IdAlumna char(8),        --Muchos a muchos (Puede haber tabla intermedia)                                                  --Id de la alumna
	 NombreEncargado varchar(max),                                              --Nombres y apellidos del encargado de la alumna
	 Parentesco varchar(15),                                                    --Parentesco del encargado con la alumna
	 Direccion text,                                                            --Direcci�n de la alumna
	 TelefonoResidente varchar(9),  --RECIDENCIA*                                            --Telefono de residencia de la alumna
	 Celular varchar(9),                                                        --Celular de la alumna
	 A�o date,  --�O E�ES --Puede quedar en la intermedia                                                                --A�o en que el encargado es responsable de la alumna
	 CONSTRAINT PK_IdDatoAlumna PRIMARY KEY (IdDatoAlumna),                     --Llave primaria (PK) de la tabla DatosPersonalesAlumnas
	 CONSTRAINT FK_DPA_IdAlumna FOREIGN KEY (IdAlumna)                          --Llave foranea (FK) IdAlumno (PK en tabla DatosGeneralesAlumnas)
	  REFERENCES DatosGeneralesAlumnas(IdAlumna) )

------------------TABLA: GradosAlumnos------------------
 
   CREATE TABLE GradosAlumnas     --Pasar el a�o del grado aqu�
   ( IdGradoAlumna char(8) NOT NULL,                                            --Id del alumna de un cierto grado
     IdAlumna char(8),                                                          --Id del alumna
	 IdGrado char(8),                                                           --Id del grado al que pertenece la alumna
	 NoLista tinyint,      --incluir secci�n aqu�                                                     --N�mero de lista de la alumna
	 CONSTRAINT PK_IdGradoAlumna PRIMARY KEY (IdGradoAlumna),                   --Llave primaria (PK) de la tabla GradosAlumnas
	 CONSTRAINT FK_GA_IdAlumna FOREIGN KEY (IdAlumna)                           --Llave foranea (FK) IdAlumna (PK en tabla DatosGeneralesAlumnas)
	  REFERENCES DatosGeneralesAlumnas(IdAlumna),
	 CONSTRAINT FK_GA_IdGrado FOREIGN KEY (IdGrado)                             --Llave foranea (FK) IdGrado (PK en tabla Grados)
	  REFERENCES Grados(IdGrado),
	 CONSTRAINT CK_NoLista CHECK (NoLista > 0) )     --La combinaci�n de a�o, grado, secci�n y nolista unique         --Restriccion CHECK donde el n�mero de lista de la alumna debe ser mayor a 0

-------------------TABLA: NotasAlumnas-------------------

		--Pueden agragar un campo TipoNota para diferenciar entre promedio, nota normal o nota sirai, nota final se podr�a calcular
   CREATE TABLE NotasAlumnas
   ( IdNotaAlumna char(8) NOT NULL,                                             --Id de la nota de la alumna
     IdGradoAlumna char(8),                                                     --Id de la alumna de cierto grado
	 Nota decimal(4,2),                                                         --Nota de la alumna
	 IdMateria char(8),                                                         --Id de la materia al que pertenece la nota
	 Periodo varchar(10),  --peirodo puede ser otra tabla                                                     --Peridodo al que pertenece la nota
	 CONSTRAINT PK_IdNotaAlumna PRIMARY KEY (IdNotaAlumna),                     --Llave primaria (PK) de la tabla NotasAlumnas
	 CONSTRAINT FK_NA_IdGradoAlumna FOREIGN KEY (IdGradoAlumna)                 --Llave foranea (FK) IdGradoAlumna (PK en tabla GradosAlumnas)
	  REFERENCES GradosAlumnas(IdGradoAlumna),
	 CONSTRAINT CK_Nota CHECK (Nota BETWEEN 0.00 AND 10.00),                    --Restriccion CHECK donde la nota esta entre 0.00 - 10.00
	 CONSTRAINT FK_NA_IdMateria FOREIGN KEY (IdMateria)                         --Llave foranea (FK) IdMateria (PK en tabla Materias)
	  REFERENCES Materias(IdMateria) )

------------------TABLA: PromediosAlumnas------------------

--la tabla sobra
   CREATE TABLE PromediosAlumnas
   ( IdPromedioAlumna char(8) NOT NULL,                                         --Id del promedio de la alumna
     IdGradoAlumna char(8),                                                     --Id de la alumna de cierto grado
	 Promedio decimal(4,2),                                                     --Promedio del alumno
	 IdMateria char(8),                                                         --Id de la materia al que pertenece el promedio
	 Peridodo varchar(10),                                                      --Periodo al que pertenece el promedio
	 CONSTRAINT PK_IdPromedioAlumna PRIMARY KEY (IdPromedioAlumna),             --Llave primaria (PK) de la tabla PromediosAlumnas
	 CONSTRAINT FK_PA_IdGradoAlumna FOREIGN KEY (IdGradoAlumna)                 --Llave foranea (FK) IdGradoAlumna (PK en tabla GradosAlumnas)
	  REFERENCES GradosAlumnas(IdGradoAlumna),
	 CONSTRAINT CK_Promedio CHECK (Promedio BETWEEN 0.00 AND 10.00),            --Restriccion CHECK donde el promedio esta entre 0.00 - 10.00
	 CONSTRAINT FK_PA_IdMateria FOREIGN KEY (IdMateria)                         --Llave foranea (FK) IdMateria (PK en tabla Materias)
	  REFERENCES Materias(IdMateria) )

--------------------TABLA: NotasFinales--------------------

--la tabla sobra
   CREATE TABLE NotasFinales
   ( IdNotaFinal char(8) NOT NULL,                                              --Id de la nota final de la alumna
     IdGradoAlumna char(8),                                                     --Id de la alumna de cierto grado
	 NotaFinal decimal(4,2),                                                    --Nota Final de la alumna en una materia
	 NotaSirai decimal(4,2),                                                    --Nota Sirai de la alumna en una materia
	 IdMateria char(8),                                                         --Id de la materia al que pertenece la nota final y la nota Sirai
	 A�o date,                                                                  --A�o de registro de las notas
	 CONSTRAINT PK_IdNotaFinal PRIMARY KEY (IdNotaFinal),                       --Llave primaria (PK) de la tabla NotasFinales
	 CONSTRAINT FK_NF_IdGradoAlumna FOREIGN KEY (IdGradoAlumna)                 --Llave foranea (FK) IdGradoAlumna (PK en tabla GradosAlumnas)
	  REFERENCES GradosAlumnas(IdGradoAlumna),
	 CONSTRAINT CK_NotaFinal CHECK (NotaFinal BETWEEN 0.00 AND 10.00),          --Restricci�n CHECK donde la nota final esta entre 0.00 - 10.00
	 CONSTRAINT CK_NotaSirai CHECK (NotaSirai BETWEEN 0.00 AND 10.00),          --Restriccion CHECK donde la nota Sirai esta entre 0.00 - 10.00
	 CONSTRAINT FK_NF_IdMateria FOREIGN KEY (IdMateria)                         --Llave foranea (FK) IdMateria (PK en tabla Materias)
	  REFERENCES Materias(IdMateria) )

----------------------TABLA: Registros----------------------

   CREATE TABLE Registros
   ( IdRegistro char(8) NOT NULL,                                               --Id del registro de la alumna
     IdGradoAlumna char(8),                                                     --Id de la alumna de cierto grado
	 DUIENcargado varchar(10),                                                  --DUI del encargado de la alumna
	 NombreEncargado varchar(max),                                              --Nombres y apellidos del encargado de la alumna
	 FechaRecibido date,                                                        --Fecha de recibido del registro 
	 A�o date,  --�O E�ES!!!                                                                --A�o del registro
	 NoFolio int,                                                               --N�mero de folio del registro
	 CONSTRAINT PK_IdRegistro PRIMARY KEY (IdRegistro),                         --Llave primaria (PK) IdRegistro de la tabla Registros
	 CONSTRAINT FK_R_IdGradoAlumna FOREIGN KEY (IdGradoAlumna)                  --Llave foranea (FK) IdGradoAlumna (PK en tabla GradosAlumnas)
	  REFERENCES GradosAlumnas(IdGradoAlumna),
	 CONSTRAINT CK_NoFolio CHECK (NoFolio > 0 ) )                               --Restricci�n CHECK donde el n�mero del folio debe ser mayor a cero

