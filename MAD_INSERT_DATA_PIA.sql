--INSERTAR EMPRESAS

INSERT INTO Empresas(NombreEmpresa, DomicilioFiscal, Telefono, RegistroPatronal, RFC, FechaInicio)
VALUES('Ternium S.A. de C.V.', 'Churubusco S/N, Monterrey', 8186631428, 'IMSS', 'TRNM875265OK2', '1963-05-28');

INSERT INTO Empresas(NombreEmpresa, DomicilioFiscal, Telefono, RegistroPatronal, RFC, FechaInicio)
VALUES('Bimbo S.A. de C.V.', 'F�lix U. G�mez S/N, Monterrey', 8826351482, 'ISSSTE', 'BMBO52465FR13', '1926-11-16');

--INSERTAR DEPARTAMENTOS
INSERT INTO Departamentos(NombreDepartamento, SueldoBase, Gerente, Empresa)
VALUES('Almac�n', 8000, 'Manuel Barrag�n Losa', 1);
INSERT INTO Departamentos(NombreDepartamento, SueldoBase, Gerente, Empresa)
VALUES('Limpieza', 9000, 'Andrea Barrera Cortina', 1);

INSERT INTO Departamentos(NombreDepartamento, SueldoBase, Gerente, Empresa)
VALUES('Mantenimiento', 12000, 'Alfredo Pe�a Mart�nez', 2);
INSERT INTO Departamentos(NombreDepartamento, SueldoBase, Gerente, Empresa)
VALUES('Contadur�a', 15000, 'Joaqu�n Acevedo Fern�ndez', 2);

--INSERTAR PUESTOS
INSERT INTO Puestos(NombrePuesto, ProporcionSalarial, SalarioDiario, Departamento, Empresa)
VALUES('Jefe Almacenista', 2.0, 16000.0, 1, 1);
INSERT INTO Puestos(NombrePuesto, ProporcionSalarial, SalarioDiario, Departamento, Empresa)
VALUES('Jefe de Limpieza', 2.0, 18000.0, 2, 1);

INSERT INTO Puestos(NombrePuesto, ProporcionSalarial, SalarioDiario, Departamento, Empresa)
VALUES('Jefe de Mantenimiento', 2.0, 24000.0, 1, 2);
INSERT INTO Puestos(NombrePuesto, ProporcionSalarial, SalarioDiario, Departamento, Empresa)
VALUES('Jefe de Contadur�a', 2.0, 30000.0, 2, 2);

--INSERTAR EMPELADOS
INSERT INTO Empleados(Contrase�a, Nombres, ApellidoPaterno, ApellidoMaterno, EmpresaTrabajo, Departamento, Puesto, NivelSalarial, FechaNacimiento, CURP, NSS, RFC, Domicilio, Banco, NumeroCuenta, Email, Telefono, NombreCompleto)
VALUES('password', 'Manuel', 'Barrag�n', 'Losa', 1, 1, 1, 2.0, '1987-07-14', 'MABL870714HLSOUB45', '170321852947165', 'MABL870714XD1', 'Mandalaria 356, San Nicol�s de los Garza', 'BBVA', 5521986547, 'manu.barras@mail.com', 8812657405, 'Manuel Barrag�n Losa');

INSERT INTO Empleados(Contrase�a, Nombres, ApellidoPaterno, ApellidoMaterno, EmpresaTrabajo, Departamento, Puesto, NivelSalarial, FechaNacimiento, CURP, NSS, RFC, Domicilio, Banco, NumeroCuenta, Email, Telefono, NombreCompleto)
VALUES('password', 'Andrea', 'Barrera', 'Cortina', 2, 2, 1, 2.0, '1993-02-20', 'ANBC930220MSNAL2E3', '896542038405971', 'ANBC930220KLS', 'Kermel 4435, Guadalupe', 'Scotiabank', 3651478915, 'andy_corba@mail.com', 8125994725, 'Andrea Barrera Cortina');

INSERT INTO Empleados(Contrase�a, Nombres, ApellidoPaterno, ApellidoMaterno, EmpresaTrabajo, Departamento, Puesto, NivelSalarial, FechaNacimiento, CURP, NSS, RFC, Domicilio, Banco, NumeroCuenta, Email, Telefono, NombreCompleto)
VALUES('password', 'Alfredo', 'Pe�a', 'Mart�nez', 2, 3, 3, 2.0, '1975-11-23', 'MAPA751123HBCJO2I1', '221465870321054', 'MAPA751123P09', 'Manera Maquela 110, Apodaca', 'CI Banco', 9982146571, 'Alfil_75@mail.com', 8112586914, 'Alfredo Pe�a Mart�nez');

INSERT INTO Empleados(Contrase�a, Nombres, ApellidoPaterno, ApellidoMaterno, EmpresaTrabajo, Departamento, Puesto, NivelSalarial, FechaNacimiento, CURP, NSS, RFC, Domicilio, Banco, NumeroCuenta, Email, Telefono, NombreCompleto)
VALUES('Sonic', 'Joaqu�n', 'Acevedo', 'Fern�ndez', 2, 4, 4, 2.0, '2001-09-11', 'ACFJ010911HNLCRN03', '423424662532423', 'ACFJ010911ES1', 'Paraisos #1123, Colonia Granados, Guadalupe, Nuevo Leon', 'Banorte', 6492750389, 'acevfer@mail.com', 8171684655, 'Joaqu�n Acevedo Fern�ndez');
