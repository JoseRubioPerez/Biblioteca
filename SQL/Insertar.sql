--INSERTAR LOS SERVICIOS DISPONIBLES
INSERT INTO Servicios (id,servicio) VALUES ('1','Consulta o Referencia')
INSERT INTO Servicios (id,servicio) VALUES ('2','Bases de Datos')
INSERT INTO Servicios (id,servicio) VALUES ('3','Cubículos')
INSERT INTO Servicios (id,servicio) VALUES ('4','Sala de Trabajo en Equipo')
INSERT INTO Servicios (id,servicio) VALUES ('5','Sala de Lectura')
INSERT INTO Servicios (id,servicio) VALUES ('6','Baños')
INSERT INTO Servicios (id,servicio) VALUES ('7','Otros')

--INSERTAR LAS CARRERAS Y DEPARTAMENTOS DISPONIBLES
INSERT INTO Areas (id,area) VALUES (0,'NINGUNA')
INSERT INTO Areas (id,area) VALUES (1,'Ingeniería Industrial') --CORREGIDA
INSERT INTO Areas (id,area) VALUES (2,'Ingeniería Electromecánica') --CORREGIDA
INSERT INTO Areas (id,area) VALUES (3,'Docente')
INSERT INTO Areas (id,area) VALUES (4,'Ingeniería en Sistemas Computacionales') --CORREGIDA
INSERT INTO Areas (id,area) VALUES (5,'Subdirección Acedémica')
INSERT INTO Areas (id,area) VALUES (6,'Dirección')
INSERT INTO Areas (id,area) VALUES (7,'Ingeniería en Gestión Empresarial') --CORREGIDA
INSERT INTO Areas (id,area) VALUES (8,'Ingeniería en Tecnologías de la Información y la Comunicación') --CORREGIDA
INSERT INTO Areas (id,area) VALUES (9,'Ingeniería en Energías Renovables') --CORREGIDA
INSERT INTO Areas (id,area) VALUES (10,'Subdirección de Planeación')
INSERT INTO Areas (id,area) VALUES (11,'Subdirección Administrativa')
INSERT INTO Areas (id,area) VALUES (12,'Departamento de Ingeniería Industrial')
INSERT INTO Areas (id,area) VALUES (13,'Departamento de Metal Mecánica')
INSERT INTO Areas (id,area) VALUES (14,'Departamento de Sistemas y Computación')
INSERT INTO Areas (id,area) VALUES (15,'Departamento de Ciencias Económico Administrativo')
INSERT INTO Areas (id,area) VALUES (16,'Departamento de Ciencias Básicas')
INSERT INTO Areas (id,area) VALUES (17,'Departamento de Desarrollo Académico')
INSERT INTO Areas (id,area) VALUES (18,'Departamento de Estudios Profesionales')
INSERT INTO Areas (id,area) VALUES (19,'Departamento de Planeación')
INSERT INTO Areas (id,area) VALUES (20,'Departamento de Comunicación y Difusión')
INSERT INTO Areas (id,area) VALUES (21,'Departamento de Información')
INSERT INTO Areas (id,area) VALUES (22,'Departamento de Gestión Tecnológica')
INSERT INTO Areas (id,area) VALUES (23,'Departamento de Servicios Escolares')
INSERT INTO Areas (id,area) VALUES (24,'Departamento de Actividades Extraescolares')
INSERT INTO Areas (id,area) VALUES (25,'Departamento de Recursos Humanos')
INSERT INTO Areas (id,area) VALUES (26,'Departamento de Recursos Materiales')
INSERT INTO Areas (id,area) VALUES (27,'Departamento de Mantenimiento')
INSERT INTO Areas (id,area) VALUES (28,'Departamento de Recursos Financieros')
INSERT INTO Areas (id,area) VALUES (29,'Centro de Computo')

--INSERTAR USUARIOS (SIN FOTO)
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('14540074','José Luis','Rubio','Pérez','H',4,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))

--INSERTAR UN ADMINISTRADOR (SIN FOTO)
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,area,password,hora,fecha,superus) VALUES
('14540074','José Luis','Rubio','Pérez','H','1234',CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),'S')

--REINCIAR TABLAS (TENER EXTREMO CUIDADO AL REINICIAR ALGUNA)
DELETE FROM dbo.RegLogeo
DBCC CHECKIDENT (RegLogeo, RESEED, 0)