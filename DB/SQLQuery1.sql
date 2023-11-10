--CREA LA TABLA DE PACIENTES
CREATE TABLE Pacientes(
id INT NOT NULL IDENTITY,
nombre VARCHAR(50) NOT NULL,
apellido VARCHAR(50) NOT NULL,
dni INT NOT NULL,
fecha_nacimiento DATE NOT NULL,
numero BIGINT NOT NULL, --NUMERO DE AFILIADO
atendido BIT NOT NULL,
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

INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,atendido,obra_social,fecha_alta) 
VALUES ('vanesa','pinto',5141541,'1976-02-18',1231354,1,'UP',)

