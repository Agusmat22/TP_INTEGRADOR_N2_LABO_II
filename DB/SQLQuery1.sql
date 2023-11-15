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
fecha_alta DATE NOT NULL,
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
fecha_alta DATE NOT NULL,


CONSTRAINT pk_id_medico PRIMARY KEY (id_medico)
)

--ELIMINA LA TABLA
DROP TABLE Medicos 

--AGREGO UN PACIENTE

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_alta) 
VALUES ('agustin','garcia',43173652,'2001-02-24',1231354,1,'UP','2023-11-10')

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_alta) 
VALUES ('vanesa','pinto',5141541,'1976-02-18',321313,1,'UP','2023-02-01')

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,fecha_alta) 
VALUES ('sofia','isunza',43615289,'2001-10-15',1231354,1,'UP','2022-01-10')

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