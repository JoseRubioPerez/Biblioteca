--INSERTAR LOS SERVICIOS DISPONIBLES
INSERT INTO Servicios (id,servicio) VALUES ('1','Consulta o Referencia')
INSERT INTO Servicios (id,servicio) VALUES ('2','Bases de Datos')
INSERT INTO Servicios (id,servicio) VALUES ('3','Cubículos')
INSERT INTO Servicios (id,servicio) VALUES ('4','Sala de Trabajo en Equipo')
INSERT INTO Servicios (id,servicio) VALUES ('5','Sala de Lectura')
INSERT INTO Servicios (id,servicio) VALUES ('6','Baños')
INSERT INTO Servicios (id,servicio) VALUES ('7','Otros')

--INSERTAR LAS CARRERAS Y DEPARTAMENTOS DISPONIBLES
INSERT INTO Areas (id,area) VALUES (1,'Ingeniería en Sistemas Computacionales')
INSERT INTO Areas (id,area) VALUES (2,'Ingeniería Electromecánica')
INSERT INTO Areas (id,area) VALUES (3,'Ingeniería Industrial')
INSERT INTO Areas (id,area) VALUES (4,'Ingeniería en Gestión Empresarial')
INSERT INTO Areas (id,area) VALUES (5,'Ingeniería en Energías Renovables')
INSERT INTO Areas (id,area) VALUES (6,'Ingeniería en Tecnologías de la Información y la Comunicación')

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
INSERT INTO dbo.Usuarios (nc,nombres,apellidopat,apellidomat,sexo,area,status,foto,hora,fecha)
VALUES ('14540079','Oscar Raúl','López','Melendez','H',4,'A',NULL,CONVERT(TIME,GETDATE(),103),CONVERT(DATE,GETDATE(),108))

--INSERTAR UN ADMINISTRADOR (SIN FOTO)
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,area,password,hora,fecha,superus) VALUES
('14540074','José Luis','Rubio','Pérez','H','1234',CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),'S')
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,password,hora,fecha,superus) VALUES
('14540076','Oscar Uriel','Nuñez','Portillo','H','1234',CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),'S')
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,password,hora,fecha,superus) VALUES
('14540077','Karla','Gómez','Baray','M','1234',CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),'N')
INSERT INTO Administradores(nc,nombres,apellidopat,apellidomat,sexo,password,hora,fecha,superus) VALUES
('14540078','Daniela','Ramirez','Hernandez','M','1234',CONVERT(TIME,GETDATE(),108),CONVERT(DATE,GETDATE(),103),'N')

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