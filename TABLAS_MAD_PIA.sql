
CREATE DATABASE MAD_PIA_David_Adrian_001;
--DROP DATABASE MAD_PIA_David_Adrian_001;
----------------------------------------------- INICIA TODO SOBRE TABLA EMPRESAS -----------------------------------------------
CREATE TABLE Empresas(
IDEmpresa int PRIMARY KEY IDENTITY(1,1) NOT NULL,
NombreEmpresa varchar(50) NOT NULL,
DomicilioFiscal varchar(200) NOT NULL,
Telefono bigint NOT NULL,
RegistroPatronal varchar(30)NOT NULL,
RFC varchar(30) UNIQUE NOT NULL,
FechaInicio date NOT NULL
);

----------------------------------------------- TERMINA TODO SOBRE TABLA EMPRESAS -----------------------------------------------

----------------------------------------------- INICIA TODO SOBRE TABLA DEPARTAMENTOS -----------------------------------------------
CREATE TABLE Departamentos(
    IDDepartamento int PRIMARY KEY IDENTITY (1,1) NOT NULL,
    NombreDepartamento varchar(50) NOT NULL,
    -- PRIMER INTENTOSueldoBase float NOT NULL, 
    SueldoBase decimal(12,2) NOT NULL, --YA CON EL CAMBIO
    Gerente varchar (50) NULL, --FOREIGN KEY REFERENCES Empleados(NombreCompleto) NULL,
    Empresa int FOREIGN KEY REFERENCES Empresas(IDEmpresa) NOT NULL
);

----------------------------------------------- TERMINA TODO SOBRE TABLA DEPARTAMENTOS ----------------------------------------

----------------------------------------------- INICIA TODO SOBRE TABLA PUESTOS -----------------------------------------------
CREATE TABLE Puestos(
    IDPuesto int PRIMARY KEY IDENTITY(1,1),
    NombrePuesto varchar(50) NOT NULL,
    ProporcionSalarial decimal(4, 2) NOT NULL,
    SalarioDiario decimal(12,2) NOT NULL,
    Departamento int FOREIGN KEY REFERENCES Departamentos(IDDepartamento),
    Empresa int FOREIGN KEY REFERENCES Empresas(IDEmpresa)
);

----------------------------------------------- TERMINA TODO SOBRE TABLA PUESTOS -----------------------------------------------

-----------------------------------------------INICIA TODO SOBRE TABLA USUARIOS -----------------------------------------------
CREATE TABLE Usuarios(
    IDUsuario int PRIMARY KEY IDENTITY(1,1),
    Contraseña varchar(20) NOT NULL,
    Nombre varchar(50) NOT NULL,
    ApellidoPaterno varchar(50) NOT NULL,
    Tipo bit NOT NULL --0 ES ADMIN | 1 ES GERENTE
);
----------------------------------------------- TERMINA TODO SOBRE TABLA USUARIOS -----------------------------------------------

----------------------------------------------- INICIA TODO SOBRE TABLA PERCEPCIONES -----------------------------------------------
--CREATE TABLE Percepciones(
--    IDPercepcion int PRIMARY KEY IDENTITY (1,1),
--    Nombre varchar(50) NOT NULL, 
--    Descripcion varchar(100) NULL,
--    Cantidad decimal (2,1) NOT NULL,
--    Tipo bit NOT NULL
--);
----------------------------------------------- TERMINA TODO SOBRE TABLA PERCEPCIONES -----------------------------------------------

----------------------------------------------- INICIA TODO SOBRE TABLA DEDUCCIONES -----------------------------------------------
--CREATE TABLE Deducciones(
--    IDDeduccion int PRIMARY KEY IDENTITY (1,1),
--    Nombre varchar(50) NOT NULL, 
--    Descripcion varchar(100) NULL,
--    Cantidad decimal (2,1) NOT NULL,
--    Tipo bit NOT NULL --1 = Cantidad Fija , 0 = Porcentual
--);
----------------------------------------------- TERMINA TODO SOBRE TABLA DEDUCCIONES -----------------------------------------------

----------------------------------------------- CAMBIO SOBRE LAS TABLAS DE PERCEPCIONES Y DEDUCCIONES ------------------------------

CREATE TABLE Ingresos(
	IDIngreso int PRIMARY KEY IDENTITY (1,1),
	Titulo varchar(50) NOT NULL,
	Descripcion varchar(100) NULL,
	Tipo bit NOT NULL, --0 PARA PERCEPCIÓN, 1 PARA DEDUCCIÓN
	Cantidad decimal(10,2)
	);

	DROP TABLE Ingresos;
----------------------------------------------- FINAL DE CAMBIO SOBRE LAS TABLAS DE PERCEPTIONS Y DEDUCTIONS -----------------------

----------------------------------------------- INICIA TODO SOBRE TABLA EMPLEADOS -----------------------------------------------    
CREATE TABLE Empleados(
    IDEmpleado int PRIMARY KEY IDENTITY (1,1) NOT NULL,
    Contraseña varchar(20) NOT NULL,
    Nombres varchar(50) NOT NULL,
    ApellidoPaterno varchar(20) NOT NULL,
    ApellidoMaterno varchar(20) NOT NULL,
    --Esta es la relación, con la tabla Empresas; relaciono el Nombre de la empresa directamente y no el ID. Para mayor facilidad.
    EmpresaTrabajo int FOREIGN KEY REFERENCES Empresas(IDEmpresa) NOT NULL,
    --Aquí deberá ir el Nombre del Departamento con su respectiva tabla.
    Departamento int FOREIGN KEY REFERENCES Departamentos(IDDepartamento) NOT NULL,
    --Aquí deberá ir el Nombre del Puesto con su respectiva tabla.
    Puesto int FOREIGN KEY REFERENCES Puestos(IDPuesto) NOT NULL,
    --El nivel salarial también se saca de Puesto
    NivelSalarial numeric(4,2) NOT NULL, 
    FechaNacimiento date NOT NULL,
    CURP varchar(30) UNIQUE NOT NULL,
    NSS varchar(18) UNIQUE NOT NULL,
    RFC varchar(30) UNIQUE NOT NULL,
    Domicilio varchar(200) NOT NULL,
    Banco varchar(50) NOT NULL,
    NumeroCuenta bigint  NOT NULL,
    Email varchar(50) NOT NULL,
    Telefono bigint NOT NULL,
    NombreCompleto varchar(50) NOT NULL,
);


----------------------------------------------- INICIA TODO SOBRE TABLA FRECUENCIA DE PAGO -----------------------------------------------

CREATE TABLE FrecuenciaPagos(
	IDFrecuencia int PRIMARY KEY IDENTITY(1,1),
	Frecuencia int CHECK (Frecuencia = 7 OR Frecuencia = 14 OR Frecuencia = 15 OR Frecuencia = 30),
	Empresa int FOREIGN KEY REFERENCES Empresas(IDEmpresa) NOT NULL,
	Departamento int FOREIGN KEY REFERENCES Departamentos(IDDepartamento) NOT NULL,
	Puesto int FOREIGN KEY REFERENCES Puestos(IDPuesto) NOT NULL
	);

----------------------------------------------- TERMINA TODO SOBRE TABLA FRECUENCIA DE PAGO -----------------------------------------------

----------------------------------------------- INICIA TODO SOBRE TABLA NOMINAS -----------------------------------------------

CREATE TABLE Nominas(
	IDNomina int PRIMARY KEY IDENTITY(1,1),
	Empleado int FOREIGN KEY REFERENCES Empleados(IDEmpleado) NOT NULL,
	Empresa int FOREIGN KEY REFERENCES Empresas(IDEmpresa) NOT NULL,
	Departamento int FOREIGN KEY REFERENCES Departamentos(IDDepartamento) NOT NULL,
	Puesto int FOREIGN KEY REFERENCES Puestos(IDPuesto) NOT NULL,
	FechaInicioNomina date NOT NULL,
	FechaFinNomina date NOT NULL
	);

----------------------------------------------- TERMINA TODO SOBRE TABLA NOMINAS -----------------------------------------------

----------------------------------------------- INICIA TODO SOBRE TABLA ALTERAR NOMINAS -----------------------------------------------

CREATE TABLE AlterarNominas(
	IDAlteracion int PRIMARY KEY IDENTITY(1,1),
	Nomina int FOREIGN KEY REFERENCES Nominas(IDNomina) NOT NULL,
	TipoIngreso int FOREIGN KEY REFERENCES Ingresos(IDIngreso) NOT NULL
	);

	DROP TABLE AlterarNominas;
----------------------------------------------- TERMINA TODO SOBRE TABLA ALTERAR NOMINAS -----------------------------------------------
