
--****************************************************
------------------PROYECTO INFRAMOR-------------------
--------------BASE DE DATOS: InstitudoBD--------------
--****************************************************

--****************************************************
-------------CREACIÓN DE LA BASE DE DATOS-------------
--****************************************************

   USE master;
   CREATE DATABASE InstitutoBD
   GO

--*********************************************************
------CREACIÓN DE TABLAS (CON LLAVES / RESTRICCIONES)------
--*********************************************************

   USE InstitutoBD
   GO
-------------------TABLA: Usuarios-------------------

   CREATE TABLE Usuarios
   ( IdUsuario char(8) NOT NULL,                                                  --Id del usuario
     NombresUsuario varchar(15),                                                  --Primer y segundo nombre del usuario
	 ApellidosUsuario varchar(15),                                                --Primer y Segundo apellido del usuario
	 NomUsuario varchar(10) NOT NULL,                                             --Nombre del usuario a utilizar para ingresar al programa
	 Contraseña varchar(20) NOT NULL,                                             --Contraseña del usuario para ingresar al programa
	 Rol varchar(15),                                                             --Rol asignado al usuario
	 Estado varchar(10) NOT NULL,                                                 --Estado (activo / inactivo) del usuario
	 CONSTRAINT PK_IdUsuario PRIMARY KEY (IdUsuario),                             --Llave primaria (PK) IdUsuario de la tabla Usuarios
	 CONSTRAINT U_NomUsuario UNIQUE(NomUsuario),                                  --Restricción UNIQUE donde el nombre del usuario (utilizado para ingresar) debe ser valor único
	 CONSTRAINT CK_Estado CHECK (Estado = 'Activo' OR Estado = 'Inactivo') )      --Restricción CHECK donde el usuario debe ser Activo o Inactivo

-----------------TABLA: Departamentos-----------------
  
   CREATE TABLE Departamentos
   ( IdDepartamento char(8) NOT NULL,                                             --Id del departamento
     NombreDepartamento varchar(15),                                              --Nombre del departamento
	 CONSTRAINT PK_IdDepartamento PRIMARY KEY (IdDepartamento),                   --Llave primaria (PK) de la tabla Departamentos
	 CONSTRAINT U_NomDepartamento UNIQUE(NombreDepartamento) )                    --Restricción UNIQUE donde el nombre del departamento es valor único

--------------------TABLA: Materias--------------------
  
   CREATE TABLE Materias
   ( IdMateria char(8) NOT NULL,                                                  --Id de la materia
     NombreMateria varchar(20),                                                   --Nombre de la materia
	 Area varchar(25),                                                            --Área a la cual pertenece la materia
	 CONSTRAINT PK_IdMaterias PRIMARY KEY (IdMateria),                            --Llave primaria (PK) de la tabla Materias
	 CONSTRAINT U_NombreMateria UNIQUE(NombreMateria) )                           --Restricción UNIQUE donde el nombre de la materia es valor único

---------------------TABLA: Grados----------------------
    
   CREATE TABLE Grados
   ( IdGrado char(8) NOT NULL,                                                    --Id del grado
     NombreGrado varchar(30),                                                     --Nombre del grado
	 Seccion char(1),                                                             --Sección del grado
	 CantidadAlumnos tinyint,                                                     --Cantidad de alumnos del grado
	 Año date,                                                                    --Año del grado
	 Tipo varchar(15),                                                            --Tipo al que pertenece el grado (General / Técnico)
	 CONSTRAINT PK_IdGrado PRIMARY KEY (IdGrado),                                 --Llave primaria (PK) de la tabla Grados
	 CONSTRAINT CK_Seccion CHECK (Seccion = 'A' OR Seccion = 'B' OR               --Restricción CHECK donde la sección debe ser A, B, C, D, E, F 
	  Seccion = 'C' OR Seccion = 'D' OR Seccion = 'E' OR Seccion = 'F'),
	 CONSTRAINT CK_Tipo CHECK (Tipo = 'General' OR Tipo = 'Técnico' ) )           --Restricción CHECK donde el tipo del grado debe ser General o Técnico

--------------TABLA: DatosGeneralesAlumnas--------------
   
   CREATE TABLE DatosGeneralesAlumnas
   ( IdAlumna char(8) NOT NULL,                                                   --Id de la alumna
     NombresAlumna varchar(15),                                                   --Primer y segundo nombre de la alumna
	 ApellidosAlumna varchar(20),                                                 --Primer y segundo apellido de la alumna
	 NIE int,                                                                     --NIE de la alumma
	 AñoIngreso date,                                                             --Año de ingreso de la alumna
	 AñoEgreso date,                                                              --Año de egreso de la alumna
	 FechaNacimiento date,                                                        --Fecha de nacimiento de la alumna
	 IdDepartamento char(8),                                                      --Id del departamento de nacimiento de la alumna
	 NombrePadre varchar(max),                                                    --Nombre completo del padre de la alumna
	 NombreMadre varchar(max),                                                    --Nombre completo de la madre de la alumna
	 CONSTRAINT PK_IdAlumna PRIMARY KEY (IdAlumna),                               --Llave primaria (PK) de la tabla DatosGeneralesAlumnas
	 CONSTRAINT U_NIE UNIQUE(NIE),                                                --Restriccion UNIQUE donde el NIE de la alumna debe ser´valor único
	 CONSTRAINT CK_AñoEgreso CHECK (AñoEgreso <= AñoIngreso),                     --Restriccion CHECK donde el año de egreso de la alumna debe ser mayor o igual al año de ingeso
	 CONSTRAINT FK_DGA_IdDepartamento FOREIGN KEY (IdDepartamento)                --Llave foranea (FK) IdDepartamento (PK en tabla Departamentos)
	 REFERENCES Departamentos(IdDepartamento) )

--------------TABLA: DatosPersonalesAlumnas--------------

   CREATE TABLE DatosPersonalesAlumnas
   ( IdDatoAlumna char(8) NOT NULL,                                             --Id de los datos personales de la alumna
     IdAlumna char(8),                                                          --Id de la alumna
	 NombreEncargado varchar(max),                                              --Nombres y apellidos del encargado de la alumna
	 Parentesco varchar(15),                                                    --Parentesco del encargado con la alumna
	 Direccion text,                                                            --Dirección de la alumna
	 TelefonoResidente varchar(9),                                              --Telefono de residencia de la alumna
	 Celular varchar(9),                                                        --Celular de la alumna
	 Año date,                                                                  --Año en que el encargado es responsable de la alumna
	 CONSTRAINT PK_IdDatoAlumna PRIMARY KEY (IdDatoAlumna),                     --Llave primaria (PK) de la tabla DatosPersonalesAlumnas
	 CONSTRAINT FK_DPA_IdAlumna FOREIGN KEY (IdAlumna)                          --Llave foranea (FK) IdAlumno (PK en tabla DatosGeneralesAlumnas)
	  REFERENCES DatosGeneralesAlumnas(IdAlumna) )

------------------TABLA: GradosAlumnos------------------
 
   CREATE TABLE GradosAlumnas
   ( IdGradoAlumna char(8) NOT NULL,                                            --Id del alumna de un cierto grado
     IdAlumna char(8),                                                          --Id del alumna
	 IdGrado char(8),                                                           --Id del grado al que pertenece la alumna
	 NoLista tinyint,                                                           --Número de lista de la alumna
	 CONSTRAINT PK_IdGradoAlumna PRIMARY KEY (IdGradoAlumna),                   --Llave primaria (PK) de la tabla GradosAlumnas
	 CONSTRAINT FK_GA_IdAlumna FOREIGN KEY (IdAlumna)                           --Llave foranea (FK) IdAlumna (PK en tabla DatosGeneralesAlumnas)
	  REFERENCES DatosGeneralesAlumnas(IdAlumna),
	 CONSTRAINT FK_GA_IdGrado FOREIGN KEY (IdGrado)                             --Llave foranea (FK) IdGrado (PK en tabla Grados)
	  REFERENCES Grados(IdGrado),
	 CONSTRAINT CK_NoLista CHECK (NoLista > 0) )                                --Restriccion CHECK donde el número de lista de la alumna debe ser mayor a 0

-------------------TABLA: NotasAlumnas-------------------

   CREATE TABLE NotasAlumnas
   ( IdNotaAlumna char(8) NOT NULL,                                             --Id de la nota de la alumna
     IdGradoAlumna char(8),                                                     --Id de la alumna de cierto grado
	 Nota decimal(2,2),                                                         --Nota de la alumna
	 IdMateria char(8),                                                         --Id de la materia al que pertenece la nota
	 Periodo varchar(10),                                                       --Peridodo al que pertenece la nota
	 CONSTRAINT PK_IdNotaAlumna PRIMARY KEY (IdNotaAlumna),                     --Llave primaria (PK) de la tabla NotasAlumnas
	 CONSTRAINT FK_NA_IdGradoAlumna FOREIGN KEY (IdGradoAlumna)                 --Llave foranea (FK) IdGradoAlumna (PK en tabla GradosAlumnas)
	  REFERENCES GradosAlumnas(IdGradoAlumna),
	 CONSTRAINT CK_Nota CHECK (Nota BETWEEN 0.00 AND 10.00),                    --Restriccion CHECK donde la nota esta entre 0.00 - 10.00
	 CONSTRAINT FK_NA_IdMateria FOREIGN KEY (IdMateria)                         --Llave foranea (FK) IdMateria (PK en tabla Materias)
	  REFERENCES Materias(IdMateria) )

------------------TABLA: PromediosAlumnas------------------

   CREATE TABLE PromediosAlumnas
   ( IdPromedioAlumna char(8) NOT NULL,                                         --Id del promedio de la alumna
     IdGradoAlumna char(8),                                                     --Id de la alumna de cierto grado
	 Promedio decimal(2,2),                                                     --Promedio del alumno
	 IdMateria char(8),                                                         --Id de la materia al que pertenece el promedio
	 Peridodo varchar(10),                                                      --Periodo al que pertenece el promedio
	 CONSTRAINT PK_IdPromedioAlumna PRIMARY KEY (IdPromedioAlumna),             --Llave primaria (PK) de la tabla PromediosAlumnas
	 CONSTRAINT FK_PA_IdGradoAlumna FOREIGN KEY (IdGradoAlumna)                 --Llave foranea (FK) IdGradoAlumna (PK en tabla GradosAlumnas)
	  REFERENCES GradosAlumnas(IdGradoAlumna),
	 CONSTRAINT CK_Promedio CHECK (Promedio BETWEEN 0.00 AND 10.00),            --Restriccion CHECK donde el promedio esta entre 0.00 - 10.00
	 CONSTRAINT FK_PA_IdMateria FOREIGN KEY (IdMateria)                         --Llave foranea (FK) IdMateria (PK en tabla Materias)
	  REFERENCES Materias(IdMateria) )

--------------------TABLA: NotasFinales--------------------

   CREATE TABLE NotasFinales
   ( IdNotaFinal char(8) NOT NULL,                                              --Id de la nota final de la alumna
     IdGradoAlumna char(8),                                                     --Id de la alumna de cierto grado
	 NotaFinal decimal(2,2),                                                    --Nota Final de la alumna en una materia
	 NotaSirai decimal(2,2),                                                    --Nota Sirai de la alumna en una materia
	 IdMateria char(8),                                                         --Id de la materia al que pertenece la nota final y la nota Sirai
	 Año date,                                                                  --Año de registro de las notas
	 CONSTRAINT PK_IdNotaFinal PRIMARY KEY (IdNotaFinal),                       --Llave primaria (PK) de la tabla NotasFinales
	 CONSTRAINT FK_NF_IdGradoAlumna FOREIGN KEY (IdGradoAlumna)                 --Llave foranea (FK) IdGradoAlumna (PK en tabla GradosAlumnas)
	  REFERENCES GradosAlumnas(IdGradoAlumna),
	 CONSTRAINT CK_NotaFinal CHECK (NotaFinal BETWEEN 0.00 AND 10.00),          --Restricción CHECK donde la nota final esta entre 0.00 - 10.00
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
	 Año date,                                                                  --Año del registro
	 NoFolio int,                                                               --Número de folio del registro
	 CONSTRAINT PK_IdRegistro PRIMARY KEY (IdRegistro),                         --Llave primaria (PK) IdRegistro de la tabla Registros
	 CONSTRAINT FK_R_IdGradoAlumna FOREIGN KEY (IdGradoAlumna)                  --Llave foranea (FK) IdGradoAlumna (PK en tabla GradosAlumnas)
	  REFERENCES GradosAlumnas(IdGradoAlumna),
	 CONSTRAINT CK_NoFolio CHECK (NoFolio > 0 ) )                               --Restricción CHECK donde el número del folio debe ser mayor a cero

