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
INSERT INTO Areas (id,area) VALUES (1,'Ingeniería en Sistemas Computacionales')
INSERT INTO Areas (id,area) VALUES (2,'Ingeniería Electromecánica')
INSERT INTO Areas (id,area) VALUES (3,'Ingeniería Industrial')
INSERT INTO Areas (id,area) VALUES (4,'Ingeniería en Gestión Empresarial')
INSERT INTO Areas (id,area) VALUES (5,'Ingeniería en Energías Renovables')
INSERT INTO Areas (id,area) VALUES (6,'Ingeniería en Tecnologías de la Información y la Comunicación')
INSERT INTO Areas (id,area) VALUES (7,'Docente')
INSERT INTO Areas (id,area) VALUES (8,'Dirección')
INSERT INTO Areas (id,area) VALUES (9,'Subdirección Acedémica')
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
VALUES ('14540072','José Antonio','López','Beltrán','H',3,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('14540073','Kevin Andrés','García','Marquez','H',2,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('14540075','César Raúl','González','López','H',1,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('14540074','José Luis','Rubio','Pérez','H',1,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('14540077','Karla','Gómez','Baray','M',1,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('14540078','Daniela','Ramirez','Hernandez','M',1,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
<<<<<<< HEAD
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('14540079','Oscar Raúl','López','Melendez','H',4,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios(nc ,nombres ,apellidopat ,apellidomat ,sexo ,area ,status ,foto ,hora ,fecha)
VALUES('14540071','Rodolfo Manuel','Hernandez','Solis','H',6,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios(nc ,nombres ,apellidopat ,apellidomat ,sexo ,area ,status ,foto ,hora ,fecha)
VALUES('101','Raquel','Portillo','Marquez','M',12,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios(nc ,nombres ,apellidopat ,apellidomat ,sexo ,area ,status ,foto ,hora ,fecha)
VALUES('104','Mónica','Fernandez','Garcia','M',14,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('209','Rosalinda','Garcia','Cantón','M',22,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('105','María Fernanda','Bustillos','Chaves','M',8,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('103','Gabriela','Rubalcaba','Araujo','M',10,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('102','Juana','Lujan','Ortiz','M',11,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('106','Marco Antonio','Melendez','Urrutia','H',19,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('107','Juan Carlos','Ledezma','Rodríguez','H',23,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('108','Armando Bronca','Guzman','Nuñez','H',26,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('109','Felipe','Calderon','Hinojosa','H',15,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('110','Vicente','Fox','Quesada','H',28,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))
=======
>>>>>>> configuraciones

--INSERTAR UN ADMINISTRADOR (SIN FOTO)
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,area,password,hora,fecha,superus) VALUES
('14540074','José Luis','Rubio','Pérez','H','1234',CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),'S')
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,password,hora,fecha,superus) VALUES
('14540076','Oscar Uriel','Nuñez','Portillo','H','1234',CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),'S')
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,password,hora,fecha,superus) VALUES
('14540077','Karla','Gómez','Baray','M','1234',CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),'N')
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,password,hora,fecha,superus) VALUES
('14540078','Daniela','Ramirez','Hernandez','M','1234',CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),'N')

<<<<<<< HEAD
--AGREGAR MOVIMIENTOS
INSERT INTO dbo.Movimientos (nc,servicio,hora,fecha)
VALUES ('14540074',1,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103))
INSERT INTO dbo.Movimientos (nc,servicio,hora,fecha)
VALUES ('209',4,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103))

--BUSCAR ENTRE FECHAS
SELECT * FROM dbo.Movimientos WHERE fecha BETWEEN '2018-04-01' AND CONVERT(DATE,GETDATE(),108)
SELECT * FROM dbo.Movimientos WHERE fecha BETWEEN CONVERT(DATE,GETDATE(),108) AND CONVERT(DATE,GETDATE(),108)

--REINCIAR LA TABLA DE "RegLogeo"
DELETE FROM dbo.RegLogeo
DBCC CHECKIDENT (RegLogeo, RESEED, 0)
=======
--PRUEBAS QUE ESTUVE REALIZANDO

UPDATE Administradores SET hora = CONVERT(varchar,GETDATE(),108) WHERE nc = '14540074' --ACTUALIZAR EL CAMPO "hora" DEL USUARIO "14540074"

DELETE FROM Administradores WHERE sexo = 'H' --BORRAR TODOS LOS REGISTROS DE LA TABLA "Administradores" CUANDO EL CAMPO "sexo" ES IGUAL A "H"

SELECT DATEPART(HOUR,GETDATE()),DATEPART(MINUTE,GETDATE()) --DIVIDIR LA HORA EN PARTES

SELECT CONVERT(varchar,GETDATE(),108) --Mirar doc: https://docs.microsoft.com/es-es/sql/t-sql/functions/cast-and-convert-transact-sql

INSERT INTO RegLogeo(registro,nc,hora,fecha) VALUES(2,'14540075',CONVERT(varchar,GETDATE(),114),CONVERT(varchar,GETDATE(),103)) --INTENTO DE INSERT EN TABLA "RegLogeo"

ALTER TABLE dbo.Usuarios DROP COLUMN superus --BORRAR COLUMNA DE TABLA "Usuarios"

declare @locationType varchar(50);
declare @locationID int;
SELECT * FROM dbo.Usuarios WHERE nc = 
  CASE '14540074'
      WHEN '14540074' THEN ''
      WHEN '14540075' THEN ''
      WHEN '14540076' THEN ''
  END
  
INSERT INTO dbo.Movimientos (nc,servicio,hora,fecha)
VALUES ('14540074',1,CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103))

SELECT dbo.Movimientos.id,dbo.Movimientos.nc,dbo.Servicios.servicio,dbo.Movimientos.hora,dbo.Movimientos.fecha FROM dbo.Movimientos
INNER JOIN dbo.Servicios ON Servicios.id = Movimientos.servicio
>>>>>>> configuraciones
