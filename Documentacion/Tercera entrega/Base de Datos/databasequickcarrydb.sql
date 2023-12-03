CREATE DATABASE quickcarryDB CHARSET utf8mb4;
USE quickcarryDB;

CREATE TABLE trabajador(
	id INT UNSIGNED AUTO_INCREMENT,
	username VARCHAR(16) UNIQUE NOT NULL,
	pass VARCHAR(50) NOT NULL,
    nom VARCHAR(30),
	ape VARCHAR(30),
	tel VARCHAR(12),
	bajalogica BOOLEAN DEFAULT 0 NOT NULL,
    CONSTRAINT pk_trabajador PRIMARY KEY (id) 
);
CREATE TABLE almacen(
	id_alma TINYINT UNSIGNED AUTO_INCREMENT NOT NULL,
	calle VARCHAR(30) NOT NULL,
    num VARCHAR(10) NOT NULL,
    esq VARCHAR(30),
    bajalogica BOOLEAN DEFAULT 0 NOT NULL,
    CONSTRAINT pk_almacen PRIMARY KEY (id_alma)
);
CREATE TABLE camion(
	id_camion INT UNSIGNED AUTO_INCREMENT NOT NULL,
	peso_camion SMALLINT,
    volumen_camion TINYINT,
    bajalogica BOOLEAN DEFAULT 0 NOT NULL,
    CONSTRAINT check_volCamion CHECK (volumen_camion > 0),
    CONSTRAINT check_pesoCamion CHECK (peso_camion > 0),
    CONSTRAINT pk_camion PRIMARY KEY (id_camion)
);
CREATE TABLE producto(
	id_prod INT UNSIGNED AUTO_INCREMENT NOT NULL,
	peso_producto SMALLINT,
    volumen_producto TINYINT,
    calle VARCHAR(30) NOT NULL,
    num VARCHAR(10) NOT NULL,
    esq VARCHAR(30),
    cliente VARCHAR(20) NOT NULL,
    bajalogica BOOLEAN DEFAULT 0 NOT NULL,
    CONSTRAINT check_volProducto CHECK (volumen_producto > 0),
    CONSTRAINT check_pesoProducto CHECK (peso_producto > 0),
    CONSTRAINT pk_producto PRIMARY KEY (id_prod)
);
CREATE TABLE destino(
	id_des INT UNSIGNED AUTO_INCREMENT NOT NULL,
	calle VARCHAR(30) NOT NULL,
    num VARCHAR(10) NOT NULL,
    esq VARCHAR(30),
    fech_esti DATETIME,
    bajalogica BOOLEAN DEFAULT 0 NOT NULL,
    CONSTRAINT pk_destino PRIMARY KEY (id_des)
);
CREATE TABLE lote(
	id_lote INT UNSIGNED AUTO_INCREMENT NOT NULL,
	fech_crea DATE NOT NULL,
    fech_entre DATETIME,
    id_des INT UNSIGNED,
    email VARCHAR(50),
    posicion ENUM("Adelante", "Intermedio","Atras") NOT NULL,
    bajalogica BOOLEAN DEFAULT 0 NOT NULL,
    CONSTRAINT check_fechas CHECK (fech_entre > fech_crea),
	CONSTRAINT fk_IdDes_lote FOREIGN KEY (id_des) REFERENCES destino(id_des),
    CONSTRAINT pk_lote PRIMARY KEY (id_lote, id_des, fech_Crea)
);
CREATE TABLE camionero(
	id_camionero INT UNSIGNED NOT NULL,
	bajalogica BOOLEAN DEFAULT 0 NOT NULL,
    CONSTRAINT fk_id_camionero FOREIGN KEY (id_camionero) REFERENCES trabajador(id),
    CONSTRAINT pk_camionero PRIMARY KEY (id_camionero)
);
CREATE TABLE operario(
	id_operario INT UNSIGNED NOT NULL,
	bajalogica BOOLEAN DEFAULT 0 NOT NULL,
    CONSTRAINT fk_id_operario FOREIGN KEY (id_operario) REFERENCES trabajador(id),
    CONSTRAINT pk_operario PRIMARY KEY (id_operario)
);
CREATE TABLE conduce(
	id_camionero INT UNSIGNED NOT NULL,
    id_camion INT UNSIGNED NOT NULL,
    CONSTRAINT fk_camionero_conduce FOREIGN KEY (id_camionero) REFERENCES camionero(id_camionero),
    CONSTRAINT fk_camion_conduce FOREIGN KEY (id_camion) REFERENCES camion(id_camion),
    CONSTRAINT pk_conduce PRIMARY KEY (id_camionero, id_camion)
);
CREATE TABLE gestiona(
	id_operario INT UNSIGNED NOT NULL,
    id_alma TINYINT UNSIGNED NOT NULL,
    CONSTRAINT fk_operario_gestiona FOREIGN KEY (id_operario) REFERENCES operario(id_operario),
    CONSTRAINT fk_almacen_gestiona FOREIGN KEY (id_alma) REFERENCES almacen(id_alma),
    CONSTRAINT pk_gestiona PRIMARY KEY (id_operario, id_Alma)
);
CREATE TABLE almacena(
	id_prod INT UNSIGNED NOT NULL,
    id_alma TINYINT UNSIGNED NOT NULL,
    fecha_ingre DATE,
    CONSTRAINT fk_id_prod_almacena FOREIGN KEY (id_prod) REFERENCES producto(id_prod),
    CONSTRAINT fk_idalma_almacena FOREIGN KEY (id_alma) REFERENCES almacen(id_alma),
    CONSTRAINT pk_almacena PRIMARY KEY (id_prod, id_alma)
);
CREATE TABLE integra(
	id_prod INT UNSIGNED NOT NULL,
    id_lote INT UNSIGNED NOT NULL,
    CONSTRAINT fk_idprod_integra FOREIGN KEY (id_prod) REFERENCES producto(id_prod),
    CONSTRAINT fk_idlote_integra FOREIGN KEY (id_lote) REFERENCES lote(id_lote),
    CONSTRAINT pk_pertence PRIMARY KEY (id_prod, id_lote)
);
CREATE TABLE llevan(
	id_camion INT UNSIGNED NOT NULL,
    id_lote INT UNSIGNED NOT NULL,
    fech_sal DATETIME NOT NULL,
    CONSTRAINT fk_idcamion_llevan FOREIGN KEY (id_camion) REFERENCES camion(id_camion),
    CONSTRAINT fk_idlote_llevan FOREIGN KEY (id_lote) REFERENCES lote(id_lote),
    CONSTRAINT pk_llevan PRIMARY KEY (id_camion, id_lote)
);
CREATE TABLE transporta(
	id_camion INT UNSIGNED NOT NULL,
    id_lote INT UNSIGNED NOT NULL,
    id_des INT UNSIGNED NOT NULL,
	estatus ENUM ("Entregado", "EnCamino", "Retrasado", "NoEnviado"),
    CONSTRAINT fk_idcamion_camion FOREIGN KEY (id_camion) REFERENCES camion(id_camion),
    CONSTRAINT fk_idlote_transporta FOREIGN KEY (id_lote) REFERENCES lote(id_lote),
    CONSTRAINT fk_iddes_transporta FOREIGN KEY (id_des) REFERENCES destino(id_des),
    CONSTRAINT pk_transporta PRIMARY KEY (id_camion, id_lote, id_des)
);
CREATE TABLE recorrido(
	id_des INT UNSIGNED NOT NULL,
    id_alma TINYINT UNSIGNED NOT NULL,
    tipo_trayecto ENUM ("Inicio", "Parada", "Fin"),
	fech_trayecto DATETIME,
	CONSTRAINT fk_id_des_contiene FOREIGN KEY (id_des) REFERENCES destino(id_des),
    CONSTRAINT fk_id_alma_contiene FOREIGN KEY (id_alma) REFERENCES almacen(id_alma),
	CONSTRAINT pk_contiene PRIMARY KEY(id_des, id_alma)
);

SELECT user FROM mysql.user;
CREATE USER 'root' identified by 'root1234';
CREATE USER 'admin_bd' identified by 'admin123';
CREATE USER 'chofer' identified by '1234';
CREATE USER 'almacenero' identified by '4321';

#PERMISOS_ROOT
GRANT ALL PRIVILEGES ON quickcarryDB.all TO 'root'@'localhost';

#PERMISOS_ADMIN_BD
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.trabajador TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.almacen TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.camion TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.producto TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.destino TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.lote TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.camionero TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.operario TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.conduce TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.gestiona TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.almacena TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.integra TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.llevan TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.transporta TO 'admin_bd'@'localhost';
GRANT SELECT, INSERT, DELETE, UPDATE ON quickcarryDB.recorrido TO 'admin_bd'@'localhost';

#PERMISOS_CAMIONERO
GRANT SELECT, UPDATE ON quickcarryDB.transporta TO 'camionero'@'localhost';
GRANT SELECT, UPDATE ON quickcarryDB.recorrido TO 'camionero'@'localhost';
GRANT SELECT ON quickcarryDB.destino TO 'camionero'@'localhost';
GRANT SELECT ON quickcarryDB.conduce TO 'camionero'@'localhost';
GRANT SELECT ON quickcarryDB.llevan TO 'camionero'@'localhost';

#PERMISOS_OPERARIO
GRANT SELECT, UPDATE ON quickcarryDB.almacena TO 'operario'@'localhost';
GRANT SELECT, UPDATE ON quickcarryDB.integra TO 'operario'@'localhost';
GRANT SELECT, UPDATE ON quickcarryDB.llevan TO 'operario'@'localhost';
GRANT SELECT, UPDATE ON quickcarryDB.lote TO 'operario'@'localhost';
GRANT SELECT ON quickcarryDB.almacen TO 'operario'@'localhost';
GRANT SELECT ON quickcarryDB.producto TO 'operario'@'localhost';
GRANT SELECT ON quickcarryDB.lote TO 'operario'@'localhost';
GRANT SELECT ON quickcarryDB.camion TO 'operario'@'localhost';
GRANT SELECT ON quickcarryDB.destino TO 'operario'@'localhost';

START TRANSACTION;
SET AUTOCOMMIT = OFF;

INSERT INTO trabajador(username, pass, nom, ape, tel, bajalogica)
VALUES
('jperez', 'jperez123', 'Juan', 'Perez', '095358999', 0),
('wwhite', 'whwc789', 'Walter', 'White', '091355999', 0),
('jrosa', 'jhombrerosa123', 'Jesse', 'Pinkman', '093358219', 0),
('drfreeman', 'lamnda567', 'Gordon', 'Freeman', '091358922', 0),
('2lawyer', 'soulgoodmanBTS', 'James', 'McGill', '098358929', 0),
('kimwex', 'sleepingKim54321', 'Kimberly', 'Wexler', '095358888', 0),
('elnoba', 'tiracorte123', 'Lautaro', 'Rene', '092358799', 0);

INSERT INTO almacen (calle, num, esq, bajalogica)
VALUES
('Av Luis Batlle Berres', '9867', 'Av al Parque Lecocq', 0),
('Circulacion e', '15600', 'Bypass de Pando', 0),
('Av Carlos Reyles', '1952', '', 0),
('Gral Fructuoso Rivera', 'km 495', '', 1),
('Cam Antonio Lussich', '4286', 'Napoles', 0);

INSERT INTO camion (peso_camion, volumen_camion, bajalogica)
VALUES
(26000, 90, 1),
(26000, 90, 0),
(26000, 90, 0),
(26000, 90, 0);

INSERT INTO producto (peso_producto, volumen_producto, calle, num, esq, cliente, bajalogica)
VALUES
('15000', '45', 'Calle 8', 200, 'Esquina 2', 'CRECOM', 0),
('11000', '45', 'Calle 9', 200, 'Esquina 2', 'CRECOM', 0),
('8000', '45', 'Calle 1', 2670, 'Esquina 7', 'CRECOM', 0),
('5000', '10', 'Calle 2', 9201, 'Esquina 10', 'Fodex', 0),
('5000', '25', 'Calle 3', 5372, 'Esquina 22', 'miaTienda', 0),
('2000', '25', 'Calle 4', 8345, 'Esquina 1', 'MercadoJusto', 0);

INSERT INTO destino (calle, num, esq, fech_esti, bajalogica)
VALUES
('Av Luis Batlle Berres', '9867', 'Av al Parque Lecocq', '2023-01-22 12:45:00', 0),
('Circulacion e', '15600', 'Bypass de Pando', '2023-01-22 22:15:00', 0),
('Av Carlos Reyles', '1952', '','2023-10-22 9:30:00', 0),
('Gral Fructuoso Rivera', 'km 495', '', '2023-9-11 12:00:00', 1),
('Cam Antonio Lussich', '4286', 'Napoles', '2023-9-11 10:30:00', 0);

INSERT INTO lote(fech_crea, fech_entre, id_des, posicion ,bajalogica)
VALUES
('2023-01-20', '2023-01-22 13:00:00', 1, "Adelante", 0),
('2023-01-20', '2023-10-22 23:00:00', 2, "Atras", 0),
('2023-10-18', '2023-10-22 10:00:00', 2, "Adelante", 0),
('2023-9-9', '2023-9-11 13:30:30', 4, "Atras", 1),
('2023-9-10', '2023-9-11 11:30:00', 4, "Adelante", 0);
COMMIT;


START TRANSACTION;
SET AUTOCOMMIT = OFF;

INSERT INTO camionero (id_camionero, bajalogica)
VALUES
(2,0),
(3,0),
(4,0),
(7,0);

INSERT INTO operario (id_operario, bajalogica)
VALUES
(1,0),
(5,0),
(6,0);
COMMIT;

START TRANSACTION;
SET AUTOCOMMIT = OFF;

INSERT INTO conduce (id_camionero, id_camion)
VALUES
(2,2),
(3,3),
(4,4);

INSERT INTO gestiona (id_operario, id_alma)
VALUES
(1,1),
(5,3),
(6,4);
COMMIT;


START TRANSACTION;
SET AUTOCOMMIT = OFF;

INSERT INTO almacena (id_prod, id_alma, fecha_ingre)
VALUES
(1, 1, '2023-01-19'),
(2, 1, '2023-01-19'),
(3, 2, '2023-10-15'),
(4, 2, '2023-10-15'),
(5, 3, '2023-9-1'),
(6, 3, '2023-9-5');

INSERT INTO integra (id_prod, id_lote)
VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 2),
(5, 4),
(6, 5);
COMMIT;

START TRANSACTION;
SET AUTOCOMMIT = OFF;

INSERT INTO llevan (id_camion, id_lote, fech_sal)
VALUES
(2, 1, '2023-01-22'),
(3, 2, '2023-10-22'),
(4, 4, '2023-9-11');

INSERT INTO transporta (id_camion, id_lote, id_des, estatus)
VALUES
(2, 1, 1, 'Entregado'),
(3, 2, 2, 'EnCamino'),
(4, 4, 4, 'Entregado');

INSERT INTO recorrido (id_des, id_alma, tipo_trayecto, fech_trayecto)
VALUES
(1, 1, '2023-01-22 12:32:57', 'Entregado'),
(2, 2, '2023-10-22 9:11:29', 'EnCamino'),
(4, 4, '2023-9-11 11:59:14', 'Entregado');
COMMIT;