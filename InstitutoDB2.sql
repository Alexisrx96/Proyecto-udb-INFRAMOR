--****************************************************
------------------PROYECTO INFRAMOR-------------------
--------------BASE DE DATOS: InstitudoBD--------------
--****************************************************

--****************************************************
-------------CREACIÓN DE LA BASE DE DATOS-------------
--****************************************************

   USE master;
   CREATE DATABASE InstitutoBD2
   GO

--*********************************************************
------CREACIÓN DE TABLAS (CON LLAVES / RESTRICCIONES)------
--*********************************************************

--Formatos:
    --LLAVE PRIMARIA: PK_CampoAfectado  Ejem: En la tabla Alumnas su llave primaria es el campo IdAlumna. Su llave primaria es nombrada como [ PK_IdAlumna ]
    --LLAVE FORANEA: FK_TablaActual_CampoAfectado  Ejem: En la tabla EncargadosAlumnas la llave foranea es el campo IdAlumna, de la tabla Alumnas. Su llave foranea es nombrada como [ FK_Encargados_IdAlumna ]
    --CHECK: CK_CampoAfectado
    --UNIQUE: U_CampoAfectado
    --DEFAULT: DF_CampoAfectado

   USE InstitutoBD2
   GO
-------------------TABLA: Permisos-------------------
---------OBSERVACIÓN: Tabla con valores establecidos-------
   CREATE TABLE Permisos
   ( IdPermiso int IDENTITY(1,1) NOT NULL,
     NombrePermiso varchar(20) NOT NULL,
	 CONSTRAINT PK_IdPermiso PRIMARY KEY (IdPermiso),
	 CONSTRAINT U_NombrePermiso UNIQUE (NombrePermiso)
   )
   INSERT INTO Permisos (NombrePermiso) VALUES
   ('Editar Usuarios'),
   ('Ver Usuarios'),
   ('Crear Usuarios'),
   ('Editar Alumnas'),
   ('Ver Alumnas'),
   ('Crear Alumnas'),
   ('Borrar Alumnas')
-------------------TABLA: Usuarios-------------------

   CREATE TABLE Usuarios
   ( IdUsuario int IDENTITY(1,1) NOT NULL,                                           --Almacena el ID del usuario
     NombresUsuario varchar(25) NOT NULL,                                           --Almacena el primer y segundo nombre del usuario
	 ApellidosUsuario varchar(25) NOT NULL,                                         --Almacena el primer y segundo apellido del usuario
	 NomUsuario varchar(20) NOT NULL,                                               --Almacena el primer nombre y primer apellido que el usuario debe ingresar para entrar al programa
	 Contrasenia varbinary(max) NOT NULL,                                            --Almacena la contraseña que el usuario debe ingresar para entrar al programa
	 EstadoActivo bit NOT NULL,                                                     --Almacena si el usuario esta activo o no ( 1 = Activo / 0 = No Activo )
	 CONSTRAINT PK_IdUsuario PRIMARY KEY (IdUsuario),                               --Llave primaria (PK) de la tabla Usuarios (Campo: IdUsuario)
	 CONSTRAINT U_NomUsuario UNIQUE(NomUsuario) )                                   --Restricción UNIQUE donde el primer nombre y primer apellido guardados en el campo [ NomUsuario ] debe ser valor único
	 
-------------------TABLA: PermisosUsuarios-------------------
   CREATE TABLE PermisosUsuarios
   ( IdPermiso int NOT NULL,
	 IdUsuario int NOT NULL,
	 Activo bit NOT NULL,
	 CONSTRAINT PK_IdPermisosUsuarios PRIMARY KEY (IdPermiso,IdUsuario),
	 CONSTRAINT FK_PermisosUsuarios_IdPermiso FOREIGN KEY (IdPermiso)
	 REFERENCES Permisos(IdPermiso),
	 CONSTRAINT FK_PermisosUsuarios_IdUsuario FOREIGN KEY (IdUsuario)
	 REFERENCES Usuarios(IdUsuario) )

-----------------TABLA: LugaresNacimientos-----------------
---------OBSERVACIÓN: Tabla con valores establecidos-------
  
   CREATE TABLE LugaresNacimiento
   ( IdLugarNacimiento tinyint NOT NULL IDENTITY(1,1),                              --Almacena el ID del lugar de nacimiento
     NombreDepartamento varchar(15),                                                --Almacena el nombre del departamento
	 CONSTRAINT PK_IdLugarNacimiento PRIMARY KEY (IdLugarNacimiento),               --Llave primaria (PK) de la tabla LugaresNacimientos (Campo: IdLugarNacimiento)
	 CONSTRAINT U_NomDepartamento UNIQUE(NombreDepartamento) )                      --Restricción UNIQUE donde el nombre del departamento es valor único

     --------------INGRESO DE DATOS--------------                                   --Ingreso de datos establecidos para la tabla LuagresNacimiento

     INSERT INTO LugaresNacimiento(NombreDepartamento) VALUES
     ( 'Ahuachapán' ),
	 ( 'Sonsonate' ),
     ( 'Santa Ana' ),
     ( 'La Libertad' ),
     ( 'Chalatenango' ),
     ( 'Cuscatlán' ),
     ( 'San Salvador' ),
     ( 'La Paz' ),
     ( 'Cabañas' ),
     ( 'San Vicente' ),
     ( 'Usulután' ),
     ( 'San Miguel' ),
     ( 'Morazán' ),
     ( 'La Unión' )

--------------------TABLA: Materias--------------------
--------OBSERVACIÓN: Tabla con valores establecidos----
  
   CREATE TABLE Materias
   ( IdMateria tinyint IDENTITY(1,1) NOT NULL,                                      --Almacena ID de la materia
     NombreMateria varchar(30) NOT NULL,                                            --Almacena el nombre de la materia
	 AnioInicio int NOT NULL,														--Año en que la materia estuvo vigente
	 AnioFin int NOT NULL,															--Año en que la materia dejo de ser impartida
	 CONSTRAINT CK_anio CHECK (AnioInicio < AnioFin),								---Restriccion CHECK donde el Año de inicio debe ser menor al final
	 CONSTRAINT PK_IdMaterias PRIMARY KEY (IdMateria),                              --Llave primaria (PK) de la tabla Materias (Campo: IdMateria)
	 CONSTRAINT U_NombreMateria UNIQUE(NombreMateria) )                             --Restricción UNIQUE donde el nombre de la materia es valor único
	 
	--------------INGRESO DE DATOS--------------                                    --Ingreso de datos establecidos para la tabla Materias
	                                                                                --OBSERVACIÓN: Habilitar la opción de agregar materias si desde cierto año se imparten materias que no estan en la lista dada
	INSERT INTO Materias(NombreMateria,AnioInicio,AnioFin) VALUES
	( 'Lenguaje y Literatura', 1 ),
	( 'Matemática', 1 ),
	( 'Ciencias naturales', 1 ),
	( 'Estudios sociales y  cívica', 1 ),
	( 'Idioma extranjero', 1 ),
	( 'Informática', 1 ),
	( 'Orientación para la vida', 1 ),
	( 'Seminarios', 0 ),
	( 'Curso de habilitación laboral', 0 ),
	( 'Moral, urbanidad y cívica', 0 ),
	( 'Conducta', 0 ),
	( 'Asistencia', 0 ),
	( 'Inasistencia', 0 )
   
---------------------TABLA: Grados----------------------
---------OBSERVACIÓN: Tabla con valores establecidos----   *Pendiente: Investigar los grados con sus secciones y tipo para ingresarlos a la tabla

   CREATE TABLE Grados
   ( IdGrado tinyint NOT NULL IDENTITY(1,1),                                        --Almacena el ID del grado
     NombreGrado varchar(30) NOT NULL,                                              --Almacena el nombre del grado
	 Turno varchar(25) NOT NULL,													--Almacena el tipo al que pertenece el grado (0 = General / 1 = Técnico)
	 CONSTRAINT PK_IdGrado PRIMARY KEY (IdGrado) )                                  --Llave primaria (PK) de la tabla Grados (Campo: IdGrado)
	 
	  --------------INGRESO DE DATOS--------------                                  --Ingreso de datos establecidos para la tabla Grados

	  INSERT INTO Grados(NombreGrado, Turno) VALUES
	  ( 'Primer año de Bachillerato', 'Diurno' ),
	  ( 'Primer año de Bachillerato', 'Vespertino' ),
	  ( 'Primer año de Bachillerato', 'Nocturno' ),
	  ( 'Segundo año de Bachillerato', 'Diurno' ),
	  ( 'Segundo año de Bachillerato', 'Vespertino' ),
	  ( 'Segundo año de Bachillerato', 'Nocturno' ),
	  ( 'Tercer año de Bachillerato', 'Diurno' ),
	  ( 'Tercer año de Bachillerato', 'Vespertino' ),
	  ( 'Tercer año de Bachillerato', 'Nocturno' )
	  
---------------------TABLA: Alumnas---------------------
   
   CREATE TABLE Alumnas
   ( IdAlumna varchar(10) NOT NULL,                                                 --Almacena el ID de la alumna
     NombresAlumna varchar(25) NOT NULL,                                            --Almacena el primer y segundo nombre de la alumna
	 ApellidosAlumna varchar(25) NOT NULL,                                          --Almacena el primer y segundo apellido de la alumna
	 NIE int,                                                                       --Almacena el NIE de la alumma
	 AnioIngreso int,                                                               --Almacena el año de ingreso de la alumna
	 AnioEgreso int,                                                                --Almacena el año de egreso de la alumna
	 FechaNacimiento date,                                                          --Almacena la fecha de nacimiento de la alumna
	 IdLugarNacimiento tinyint,                                                     --Almacena el ID del lugar de nacimiento de la alumna
	 NombrePadre varchar(max),                                                      --Almacena el nombre completo del padre de la alumna
	 NombreMadre varchar(max),                                                      --Almacena el nombre completo de la madre de la alumna
	 IdGrado tinyint NOT NULL,                                                      --Almacena el ID del grado en que se encuentra la alumna
	 Seccion char(1) NOT NULL,                                                      --Almacena la sección del grado de la alumna
	 NoLista tinyint NOT NULL,                                                      --Almacena el número de lista de la alumna
	 Anio int NOT NULL,
	 Edad tinyint NOT NULL,
	 Observaciones Text,
	 DireccionFoto Text,
	 CONSTRAINT FK_Alumnas_IdGrado FOREIGN KEY (IdGrado)							--Llave foranea (FK) de la tabla GradosAlumnas (Campo: IdGrado - PK en tabla Grados)
	 REFERENCES Grados(IdGrado),
	 CONSTRAINT CK_Seccion CHECK (Seccion = '[A-Z]' ),
	 CONSTRAINT CK_NoLista CHECK (NoLista > 0),                                     --Restriccion CHECK donde el número de lista de la alumna debe ser mayor a 0
	 CONSTRAINT U_Alumna UNIQUE (IdGrado, Seccion, Anio,NoLista),                   --Restriccion UNIQUE donde la unión de los campos [ IdGrado, NoLista, Anio ] son unicos en la tabla. Una alumna no puede estar registrada dos veces en un grado el mismo año
	 CONSTRAINT PK_IdAlumna PRIMARY KEY (IdAlumna),                                 --Llave primaria (PK) de la tabla Alumnas (Campo: IdAlumna)
	 CONSTRAINT CK_AnioEgreso CHECK (AnioEgreso >= AnioIngreso),                    --Restriccion CHECK donde el año de egreso de la alumna debe ser mayor o igual al año de ingeso
	 CONSTRAINT FK_Alumnas_IdLugarNacimiento FOREIGN KEY (IdLugarNacimiento)        --Llave foranea (FK) IdLugarNacimiento (Campo: IdLugarNacimiento - PK en tabla LugaresNacimientos)
	 REFERENCES LugaresNacimiento(IdLugarNacimiento) )

------------------TABLA: Encargados--------------------

   CREATE TABLE Encargados
   ( IdEncargado int NOT NULL IDENTITY(1,1),                                        --Almacena el ID de los encargado de la alumna
     IdAlumna varchar(10) NOT NULL,                                                  --Almacena el ID de la alumna
	 NombreEncargado varchar(max) NOT NULL,                                         --Almacena nombres y apellidos del encargado de la alumna
	 Parentesco varchar(15) NOT NULL,                                               --Almacena el parentesco del encargado con la alumna
	 Direccion text,                                                                --Almacena la dirección de la alumna
	 TelefonoResidencia varchar(9),                                                 --Almacena el telefono de residencia de la alumna
	 Celular varchar(9),                                                            --Almacena el celular de la alumna
	 Anio int NOT NULL,                                                             --Almacena el año en que el encargado es responsable de la alumna (Se ingresa el año que tiene la boleta)
	 CONSTRAINT PK_IdEncargado PRIMARY KEY (IdEncargado),                           --Llave primaria (PK) de la tabla EncargadossAlumnas 
	 CONSTRAINT FK_Encargados_IdAlumna FOREIGN KEY (IdAlumna)                       --Llave foranea (FK) de la tabla Encargados (Campo: IdAlumna - PK en tabla Alumnas)
	 REFERENCES Alumnas(IdAlumna) )

-------------------TABLA: TiposNotas--------------------
------OBSERVACIÓN: Tabla con valores ya establecidos----

   CREATE TABLE TiposNotas
   ( IdTipoNota tinyint NOT NULL IDENTITY(1,1),                                     --Almacena el ID del tìpo de nota
     TipoNota varchar(15) NOT NULL,                                                 --Almacena el nombre del tipo de nota (Nota 1 / Nota 2 / Nota 3 / Nota Promedio / Nota Final / Nota Sirai)
	 CONSTRAINT PK_IdTipoNota PRIMARY KEY (IdTipoNota),                             --Llave primaria (PK) de la tabla TiposNotas
	 CONSTRAINT U_TipoNota UNIQUE (TipoNota) )                                      --Restriccion UNIQUE donde el nombre del tipo de nota es valor único

   --------------INGRESO DE DATOS--------------
   
   INSERT INTO TiposNotas VALUES
   ( 'Nota 1'),
   ( 'Nota 2' ),
   ( 'Nota 3' ),
   ( 'Nota Promedio' ),
   ( 'Nota Final' ),
   ( 'Nota SIRAI' )

----------------------TABLA: Notas----------------------

   CREATE TABLE Notas
   ( IdNota int NOT NULL IDENTITY (1,1),                                            --Almacena el ID de la nota de la alumna
   	 IdMateria tinyint NOT NULL,                                                    --Almacena el ID de la materia al que pertenece la nota
	 IdTipoNota tinyint NOT NULL,                                                   --Almacena el ID del tipo de nota (Nota 1 / Nota 2 / Nota 3 / Nota Promedio / Nota Final / Nota Sirai)
	 Nota char(4) NOT NULL,                                                         --Almacena la nota de la alumna (Números, MB, B, E)
	 Periodo varchar(10),                                                           --Almacena el periodo al que pertenece la nota
	 Anio int NOT NULL,                                                             --Almacena el año en que la alumna tuvo la nota (Se ingresa el año que tiene la boleta)
	 CONSTRAINT PK_IdNota PRIMARY KEY (IdNota),                                     --Llave primaria (PK) de la tabla Notas
	 CONSTRAINT FK_Notas_IdMateria FOREIGN KEY (IdMateria)                          --Llave foranea (FK) de la tabla Notas (Campo: IdMateria - PK en tabla Materias)
	 REFERENCES Materias(IdMateria), 
	 CONSTRAINT FK_Notas_IdTipoNota FOREIGN KEY (IdTipoNota)                        --Llave foranea (FK) de la tabla Notas (Campo: IdTipoNota - PK en tabla TiposNotas)
	 REFERENCES TiposNotas(IdTipoNota),
	 CONSTRAINT CK_Periodo CHECK (Periodo = 'Primero' OR Periodo = 'Segundo'        --Restriccion CHECK donde el periodo deber Primero, Segundo, Tercero o Cuarto
	  OR Periodo = 'Tercero' OR Periodo = 'Cuarto' ) )

	  --OBSERVACIONES: 
	     --Al seleccionar un tipo de nota como  [ Nota Final ] o  [ Nota SIRAI ] no se ingresarán datos en el campo  [ Peridodo ], por ende este será NULL
		 --Al seleccionar una materia como [ Conducta ], [ Asistencia ] o [ Inasistencia ] su tipo de nota será [ Nota Promedio ]
	    
--------------------TABLA: Registros--------------------

   CREATE TABLE Registros
   ( IdRegistro int NOT NULL IDENTITY(1,1),                                         --Almacena el ID del registro
   	 DUIENcargado varchar(10),                                                      --Almacena el DUI del encargado de la alumna
	 NombreEncargado varchar(max),                                                  --Almacena nombres y apellidos del encargado de la alumna
	 FechaRecibido date,                                                            --Almacena la fecha de recibido del registro 
	 NoFolio int,                                                                   --Almacena el número de folio del registro
	 Anio int NOT NULL,                                                             --Almacena el año del registro
	 CONSTRAINT PK_IdRegistro PRIMARY KEY (IdRegistro),                             --Llave primaria (PK) de la tabla Registros
	 CONSTRAINT CK_NoFolio CHECK (NoFolio > 0 ) )                                   --Restricción CHECK donde el número del folio debe ser mayor a cero

 --------------------TABLA: NotasAlumnas--------------------

	 CREATE TABLE NotasAlumnas														
	 (
		IdAlumna varchar(10),														--Almacena el código de la alumna.
		IdNota int,																	--Almacena el código de la nota.
		CONSTRAINT FK_NotasAlumnas_IdAlumna FOREIGN KEY (IdAlumna)					--Llave foranea (FK) de la tabla Notas Alumnas (Campo: IdAlumna - PK en tabla Alumnas)
		REFERENCES Alumnas(IdAlumna),	
		CONSTRAINT FK_NotasAlumnas_IdNotas FOREIGN KEY (IdNota)						--Llave foranea (FK) de la tabla NotasAlumnas (Campo: IdNota - PK en tabla Notas)
		REFERENCES Notas(IdNota),													
	 )