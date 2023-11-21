--CREA LA TABLA DE PACIENTES
CREATE TABLE Pacientes(
id INT NOT NULL IDENTITY,
nombre VARCHAR(50) NOT NULL,
apellido VARCHAR(50) NOT NULL,
dni INT NOT NULL,
fecha_nacimiento DATE NOT NULL,
numero BIGINT NOT NULL, --NUMERO DE AFILIADO
enEspera BIT NOT NULL,
obra_social VARCHAR(80) NOT NULL,
historia_clinica VARCHAR(MAX),
fecha_modificacion DATETIME NOT NULL,
CONSTRAINT pk_id PRIMARY KEY (id)
)

--ELIMINAR LA TABLA
DROP TABLE Pacientes

--CREA LA TABLA DE MEDICOS

CREATE TABLE Medicos(
id_medico INT NOT NULL IDENTITY,
nombre VARCHAR(50) NOT NULL,
apellido VARCHAR(50) NOT NULL,
dni INT NOT NULL,
fecha_nacimiento DATE NOT NULL,
matricula BIGINT NOT NULL, --NUMERO DE MATRICULA
especialidad VARCHAR(60) NOT NULL,
fecha_modificacion DATETIME NOT NULL,


CONSTRAINT pk_id_medico PRIMARY KEY (id_medico)
)

--ELIMINA LA TABLA
DROP TABLE Medicos 

--AGREGO UN PACIENTE

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('agustin','garcia',43173652,'2001-02-24',1231354,1,'UP','2023-11-17 14:30:00')

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('vanesa','pinto',5141541,'1976-02-18',321313,1,'UP','2023-01-17 09:30:00')

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('sofia','isunza',43615289,'2001-10-15',1231354,0,'UP','2022-01-10 09:30:00')

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('jorge','roncaglia',123,'2001-10-15',3311,1,'UP','2022-01-10 09:30:00')


INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('messi','leo',123,'2001-10-15',3311,1,'UP','2022-01-10 09:30:00')

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('jorgeee','leo',123,'2001-10-15',3311,1,'UP','2022-01-10 09:30:00')

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('riquelme','malo',123,'2001-10-15',3311,1,'UP','2023-11-10 15:17:00')

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('riquelme','malo',123,'2001-10-15',3311,1,'UP','2023-11-10 18:27:00')

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('riquelme','malo',123,'2001-10-15',3311,1,'UP','2023-11-10 18:29:00')

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('PRUEBA SI FUNCIONA','malo',123,'2001-10-15',3311,1,'UP','2023-11-17 19:21:10')



IF NOT EXISTS(SELECT numero FROM Pacientes WHERE numero = 3311)
INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_modificacion) 
VALUES ('PRUEBA SI FUNCIONA','malo',123,'2001-10-15',3311,1,'UP','2023-11-17 19:21:10')
ELSE
PRINT 'Este paciente esta repetido';

DELETE FROM Pacientes WHERE id = 15

SELECT * FROM Pacientes WHERE fecha_modificacion > '2022-01-01'

--MODIFICAR PACIENTE

UPDATE Pacientes SET enEspera=0 WHERE id = 4
UPDATE Pacientes SET enEspera=0 WHERE id=3
UPDATE Pacientes SET enEspera=0 WHERE id=2

UPDATE Pacientes SET enEspera=1 WHERE id = 4
UPDATE Pacientes SET enEspera=1 WHERE id=3
UPDATE Pacientes SET enEspera=1 WHERE id=2

--AGREGO UN MEDICO

INSERT INTO Medicos (nombre,apellido,dni,fecha_nacimiento,matricula,especialidad,fecha_alta) 
VALUES ('Julian','Alvarez',1148569,'2001-09-15',45879,'Clinico','2022-01-10')

SELECT * FROM Pacientes WHERE fecha_modificacion > '2023-10-10'


--REALIZA EL BACKUP SIN PROBLEMAS
BACKUP DATABASE CentroMedicoTP
TO DISK = 'C:\TP_INTEGRADOR_N2_LABO_II\DB\CentroMedicoTP.bak'
WITH FORMAT, INIT;
