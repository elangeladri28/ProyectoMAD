--********************************* PROCEDURES PARA EMPRESAS *************************************

--STORED PROCEDURE PARA CONSULTAR TODOS LOS USUARIOS (SIN ID)
GO
CREATE PROCEDURE SelectAllFromEmpresas
AS
SELECT IDEmpresa, NombreEmpresa, DomicilioFiscal, Telefono, RegistroPatronal, RFC, FechaInicio FROM Empresas
GO


--STORED PROCEDURE PARA ELIMINAR UNA EMPRESA DADO EL NOMBRE
GO
CREATE PROCEDURE EliminarEmpresa @Empresa int
AS
DELETE FROM Empresas WHERE IDEmpresa = @Empresa
GO


--STORED PROCEDURE PARA INSERTAR DATOS EN LA TABLA EMPRESAS
GO
CREATE PROCEDURE InsertarEmpresa 
@NE varchar(50), @DF varchar(200), @T bigint, @RP varchar(30), @RFC varchar(30), @FI date
AS
BEGIN
    IF NOT EXISTS (SELECT RFC FROM Empresas WHERE RFC = @RFC)
		BEGIN
		INSERT INTO Empresas(NombreEmpresa, DomicilioFiscal, Telefono, RegistroPatronal, RFC, FechaInicio)
		VALUES (@NE, @DF, @T, @RP, @RFC, @FE);
	END
END
GO


--STORED PROCEDURE PARA HACER UN UPDATE A UNA EMPRESA DADO EL ID
GO 
CREATE PROCEDURE ModificarEmpresa
@ID int, @NE varchar(50), @DF varchar(200), @T bigint, @RP varchar(30), @RFC varchar(30), @FI date
AS
UPDATE Empresas
SET NombreEmpresa = @NE, DomicilioFiscal = @DF, Telefono = @T, RegistroPatronal = @RP, RFC = @RFC, FechaInicio = @FI
WHERE IDEmpresa = @ID
GO



--CREAR UN QUERY PARA SACAR UNICAMENTE EL NOMBRE DE LA EMPRESA; PARA LOS COMBOBOX NECESARIOS EN EL PROGRAMA
GO
CREATE PROCEDURE GetAllEmpresasName
AS
SELECT NombreEmpresa FROM Empresas
GO



--********************************* PROCEDURES PARA EMPRESAS *************************************



--********************************* PROCEDURES PARA DEPARTAMENTOS *************************************

--STORED PROCEDURE PARA SELECCIONAR TODOS LOS DEPARTAMENTOS
GO
CREATE PROCEDURE SelectAllFromDepartamentos @Empresa varchar(50)
AS
DECLARE @IDEmpresa int
SET @IDEmpresa = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empresa)

SELECT IDDepertamento, NombreDepartamento, SueldoBase, Gerente FROM Departamentos
WHERE Empresa = @IDEmpresa
GO


--CREAR UN QUERY PARA SACAR UNICAMENTE EL NOMBRE DEL DEPTO; PARA LOS COMBOBOX NECESARIOS EN EL PROGRAMA
GO
CREATE PROCEDURE GetAllDeptosName @Empresa varchar(50)
AS
DECLARE @IDEmpresa int
SET  @IDEmpresa = (SELECT IDEmpresa FROM  Empresas WHERE NombreEmpresa = @Empresa)
SELECT NombreDepartamento FROM Departamentos
WHERE Empresa = @IDEmpresa
GO


--CREAR STORED PROCEDURE PARA 
GO
CREATE PROCEDURE InsertarDepartamento @ND varchar(50), @SB varchar(50), @G varchar(50), @Empresa varchar(50)
AS

DECLARE @IDEmpresa int
SET @IDEmpresa = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empresa)

IF NOT EXISTS (SELECT NombreDepartamento, Empresa FROM Departamentos WHERE NombreDepartamento = @ND AND Empresa = @IDEmpresa)
    BEGIN
        INSERT INTO Departamentos (NombreDepartamento, SueldoBase, Gerente, Empresa)
    VALUES(@ND, @SB, @G, @IDEmpresa)
END
GO



--STORED PROCEDURE PARA HACER EL UPDATE EN LA TABLA DE DEPARTAMENTOS
GO
CREATE PROCEDURE ModificarDepartamento @ID int, @ND varchar(50), @SB varchar(50), @G varchar(50) @Empresa varchar(50)
    BEGIN 
        DECLARE @IDEmpresa int
        SET @IDEmpresa = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empresa)
        
        UPDATE Departamentos
        SET NombreDepartamento = @ND, SueldoBase = @SB, Gerente = @G
        WHERE IDDepartamento = @ID AND Empresa = @IDEmpresa
    END
GO



--STORED PROCEDURE PARA ELIMINAR UNA FILA DE LA TABLA DEPARTAMENTOS
GO
CREATE PROCEDURE EliminarDepartamento @ID int, @E varchar(50)
AS
    DECLARE @IDEmpresa int
    SET @IDEmpresa = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @E)
    
    DELETE FROM Departamentos
    WHERE IDDepartamento = @ID AND Empresa = @IDEmpresa
GO




--PROCEDURE PARA OBTENER EL PURO SUELDO BASE DEL DEPTO
GO 
CREATE PROCEDURE GetOnlyMoneyDepto @Depto varchar(50)
AS
BEGIN
DECLARE @IDEmp int
	SET @IDEmp = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa= @Empre)
DECLARE @IDDepto int
	SET @IDDepto = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento = @Depto AND Empresa= @IDEmp)
    
    SELECT SueldoBase From Departamentos
	WHERE IDDepartamento = @IDDepto AND Empresa = @IDEmp
END
GO

--********************************* PROCEDURES PARA DEPARTAMENTOS *************************************



--********************************* PROCEDURES PARA PUESTOS *************************************

--ESTE STORE PROCEDURE SELECCIONA TODOS LOS PUESTOS DEL RESPECTIVO DEPARTAMENTO CON SU EMPRESA
GO
CREATE PROCEDURE SelectAllFromPuestos @Empresa varchar(50), @Depto varchar(50)
AS
SELECT P.IDPuesto P.NombrePuesto, P.ProporcionSalarial, P.SalarioDiario FROM Puestos P, Empresas E, Departamentos D
WHERE E.NombreEmpresa = @Empresa AND D.NombreDepartamento = @Depto
GO



--ESTE STORE PROCEDURE INSERTA UN NUEVO PUESTO
GO
CREATE PROCEDURE IngresarNuevoPuesto @Puestito varchar(50), @ProporSa decimal(2,2), @SD decimal(10,2), @Depto varchar(50), @Empre varchar(50)
AS
BEGIN
    DECLARE @IDEmpresa int
    SET @IDEmpresa = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empre);

    DECLARE @IDDepto int
    SET @IDDepto = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento = @Depto);

        INSERT INTO Puestos(NombrePuesto, ProporcionSalarial, SalarioDiario, Departamento, Empresa)
        VALUES(@Puestito, @ProporSa, @SD, @IDDepto, @IDEmpresa)
END

--ESTE STORE PROCEDURE MODIFICA EL PUESTO  
GO
CREATE PROCEDURE ModificarPuestos @Puesteson varchar(50), @Prop decimal(2,2), @SD decimal(10,2), @Depto varchar(50), @Empresa
AS
        BEGIN
        DECLARE @IDDepto int
        SET @IDDepto = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento = @Depto);
        DECLARE @IDEmpresa int
        SET @IDEmpresa = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empre)

        UPDATE Puestos
        SET NombrePuesto = @Puestito, ProporcionSalarial = @ProporSa, SalarioDiario = @SD FROM Puestos
        WHERE Departamento = @IDDepto AND Empresa = @IDEmpresa

END


--ESTE STORED PROCEDURE PARA ELIMINAR EL PUESTO
GO
CREATE PROCEDURE EliminarPuesto @ID int
AS

	DECLARE @IDE int
	SET @IDE = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empresa)
	DECLARE @IDD int
	SET @IDD = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento = @Depto)

    SELECT P.IDPuesto, P.NombrePuesto, P.ProporcionSalarial, P.SalarioDiario FROM Puestos P
    WHERE Departamento = @IDD AND Empresa = @IDE
GO

--ESTE PROCEDURE ES PARA SELECCIONAR EL NOMBRE DE LOS PUESTOS
GO
CREATE PROCEDURE SelectAllPuestosName @Empresa varchar(50), @Depto varchar(50)
AS

	DECLARE @IDE int
	SET @IDE = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empresa)
	DECLARE @IDD int
	SET @IDD = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento = @Depto)

SELECT NombrePuesto FROM Puestos
WHERE Departamento = @IDD AND Empresa = @IDE
GO

GO
CREATE PROCEDURE GetOnlyMoneyPuesto @Puesto varchar(50), @Depto varchar(50), @Empre varchar(50)
AS
BEGIN
	DECLARE @IDEmpre int
	SET @IDEmpre=(SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empre)
	DECLARE @IDDepto int
	SET @IDDepto = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento= @Depto AND Empresa = @IDEmpre)
	DECLARE @IDPuesto int
	SET @IDPuesto = (SELECT IDPuesto FROM Puestos WHERE NombrePuesto = @Puesto AND Empresa= @IDEmpre AND Departamento= @IDDepto)
	SELECT SalarioDiario FROM Puestos
	WHERE IDPuesto = @IDPuesto AND Departamento =@IDDepto AND Empresa = @IDEmpre
END
GO

--********************************* PROCEDURES PARA PUESTOS *************************************




--********************************* PROCEDURES PARA EMPLEADOS *************************************

--STORED PROCEDURE PARA SELECCIONAR TODOS LOS EMPLEADOS
GO
CREATE PROCEDURE SelectAllFromEmpleados
AS
BEGIN
SELECT IDEmpleado, NombreCompleto, EmpresaTrabajo, Departamento, Puesto, NivelSalarial, FechaNacimiento, CURP, NSS, RFC, Domicilio, Banco, NumeroCuenta, Email, Telefono FROM Empleados;
END
GO



--STORED PROCEDURE PARA SELECCIONAR EMPLEADOS MEDIANTE FILTRO DE EMPRESA, DEPTO, PUESTO
GO
CREATE PROCEDURE SelectFromEmpleadosFiltros
@ET varchar(50), @D varchar(50), @P varchar(50)
AS
BEGIN
--PRIMERO CONSIGO LOS ID DE LAS TABLAS SEGÚN EL NOMBRE DE LOS CAMPOS DE LAS FK
DECLARE @ETID int; DECLARE @DID int; DECLARE @PID int; DECLARE @NivSal numeric(12,2)
    SET @ETID = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @ET)
    SET @DID = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento = @D)
    SET @PID = (SELECT IDPuesto FROM Puestos WHERE NombrePuesto = @P)
    SET @NivSal = (SELECT SalarioDiario FROM Puestos WHERE IDPuesto = @PID)

    SELECT Emple.IDEmpleado, Emple.NombreCompleto, Emple.FechaNacimiento, Emple.CURP, Emple.NSS, Emple.RFC, Emple.Domicilio, Emple.Banco, Emple.NumeroCuenta, Emple.Email, Emple.Telefono 
    FROM Empleados Emple
    WHERE EmpresaTrabajo = @ETID AND Emple.Departamento = @DID AND Puesto = @PID
END
GO

--PROCEDURE PARA INSERTAR UN EMPLEADO TENIENDO COMO BASE LA EMPRESA, DEPARTAMENTO, PUESTO Y NIVEL SALARIAL
GO
CREATE PROCEDURE InsertarEmpleado
@Pass varchar(50), @Nombres varchar(50), @AP varchar(50), @AM varchar(50), @ET varchar(50), @D varchar(50), @P varchar(50), @NS varchar(50), @FN date, @CURP varchar(30), @NSS varchar(18), @RFC varchar(30), @Dom varchar(200), @B varchar(50), @NC bigint, @Email varchar(50), @T bigint
AS
    BEGIN
    --PRIMERO CONSIGO LOS ID DE LAS TABLAS SEGÚN EL NOMBRE DE LOS CAMPOS DE LAS FK
    DECLARE @ETID int; DECLARE @DID int; DECLARE @PID int; DECLARE @NivSal numeric(12,2)
    SET @ETID = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @ET)
    SET @DID = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento = @D)
    SET @PID = (SELECT IDPuesto FROM Puestos WHERE NombrePuesto = @P)
    SET @NivSal = (SELECT SalarioDiario FROM Puestos WHERE IDPuesto = @PID)

    --CONCATENO EL NOMBRE COMPLETO DEL COMPA JUAS JUAS 
    DECLARE @NomC varchar(50)
    SET @NC = @Nombres + ' ' + @AP + ' ' + @AM

    INSERT INTO Empleados (Contraseña, Nombres, ApellidoPaterno, ApellidoMaterno, EmpresaTrabajo, Departamento, Puesto, NivelSalarial, FechaNacimiento, CURP, NSS, RFC, Domicilio, Banco, NumeroCuenta, Email, Telefono, NombreCompleto)
    VALUES(@Pass, @Nombres, @AP, @AM, @ETID, @DID, @PID, @NivSal, @FN, @CURP, @NSS, @RFC, @Dom, @B, @NC, @Email, @T, @NomC)
    END
GO



--AHORA SIGUE EL STORED PROCEDURE PARA ELIMINAR UN EMPLEADITO
GO
CREATE PROCEDURE EliminarEmpleado @IDEmpleadin int
AS
    DELETE FROM Empleados WHERE IDEmpleado = @IDEmpleadin
GO



--AHORA EL PROCEDURE PARA MODIFICAR AL EMPLEADITO, PERO SOLO CIERTOS DATOS
--(TERMINADO)
GO
CREATE PROCEDURE ModificarEmpleado @IDEmpleadin int, @Nombres varchar(50), @AP varchar(50), @AM varchar(50), @ET varchar(50), @D varchar(50), @P varchar(50), @NS varchar(50), @FN date, @CURP varchar(30), @NSS varchar(18), @RFC varchar(30), @Dom varchar(200), @B varchar(50), @NC bigint, @Email varchar(50), @T bigint
AS
	BEGIN
	DECLARE @ETID int; DECLARE @DID int; DECLARE @PID int; DECLARE @NivSal numeric(12,2)
    SET @ETID = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @ET)
    SET @DID = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento = @D)
    SET @PID = (SELECT IDPuesto FROM Puestos WHERE NombrePuesto = @P)
    SET @NivSal = (SELECT SalarioDiario FROM Puestos WHERE IDPuesto = @PID)

	DECLARE @NomC varchar(50)
    SET @NomC = @Nombres + ' ' + @AP + ' ' + @AM

	UPDATE Empleados
	SET Nombres = @Nombres, ApellidoPaterno = @AP, ApellidoMaterno = @AM, EmpresaTrabajo = @ETID, Departamento = @DID, Puesto = @PID, NivelSalarial = @NivSal, FechaNacimiento = @FN, CURP = @CURP, NSS = @NSS, RFC = @RFC, Domicilio = @Dom, Banco = @B, NumeroCuenta = @NC, Email = @Email, Telefono = @T, NombreCompleto = @NomC
	WHERE IDEmpleado = @IDEmpleadin
	END
GO

INSERT INTO Empleados (Contraseña, Nombres, ApellidoPaterno, ApellidoMaterno, EmpresaTrabajo, Departamento, Puesto, NivelSalarial,
FechaNacimiento, CURP, NSS, RFC, Domicilio, Banco, NumeroCuenta, Email, Telefono, NombreCompleto)
VALUES ('pass test', 'Name test', 'AP test', 'AM test', 1, 1, 1, 6000, '1990-10-10', 'CURP Test', 'NSS Test', 'RFC Test', 'Domicilio Test', 'Banco Test', 0123456789, 'mail@mail.com', 9876543210, 'nombre completo Test');


--********************************* PROCEDURES PARA EMPLEADOS *************************************



--********************************* PROCEDURES PARA REPORTES HEADCOUNTER *************************************


--ESTE PROCEDURE OBTIENE LA CANTIDAD DE PERSONAS QUE HAY EN UN SOLO PUESTO SELECCIONADO
GO
CREATE PROCEDURE ObtenerHeadCounter @Puesto varchar(50), @Depto varchar(50), @Empre varchar(50)
AS
BEGIN
	DECLARE @ETID int; 
	DECLARE @DID int; 
	DECLARE @PID int; 
    SET @ETID = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empre)
    SET @DID = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento = @Depto AND Empresa = @ETID)
    SET @PID = (SELECT IDPuesto FROM Puestos WHERE NombrePuesto = @Puesto AND Departamento=@DID AND Empresa = @ETID)
    
	SELECT COUNT (IDEmpleado) Cantidad FROM Empleados WHERE Puesto= @PID AND Departamento= @DID AND EmpresaTrabajo= @ETID
	
END
GO



--ESTE PROCEDURE OBTIENE LA CANTIDAD DE PERSONAS QUE HAY EN UN SOLO DEPARTAMENTO SELECCIONADO

GO
CREATE PROCEDURE ObtenerHeadCounterDepto @Depto varchar (50), @Empre varchar (50)
AS
BEGIN
	DECLARE @ETID int; 
	DECLARE @DID int; 
	DECLARE @PID int; 
    SET @ETID = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empre)
    SET @DID = (SELECT IDDepartamento FROM Departamentos WHERE NombreDepartamento = @Depto AND Empresa = @ETID)
    
	SELECT COUNT (IDEmpleado) Cantidad FROM Empleados WHERE Departamento= @DID AND EmpresaTrabajo= @ETID
	
END
GO

--ESTE PROCEDURE OBTIENE LA CANTIDAD DE PERSONAS QUE HAY EN UNA SOLA EMPRESA SELECCIONADA

GO
CREATE PROCEDURE ObtenerHeadCounterEmpresa @Empre varchar (50)
AS
BEGIN
	DECLARE @ETID int; 
    SET @ETID = (SELECT IDEmpresa FROM Empresas WHERE NombreEmpresa = @Empre)
      
	SELECT COUNT (IDEmpleado) Cantidad FROM Empleados WHERE EmpresaTrabajo= @ETID
	
END
GO

--********************************* PROCEDURES PARA REPORTES HEADCOUNTER *************************************
