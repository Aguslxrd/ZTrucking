-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: quickcarryDB
-- ------------------------------------------------------
-- Server version	8.0.25

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `almacen`
--

DROP TABLE IF EXISTS `almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `almacen` (
  `id_alma` tinyint unsigned NOT NULL AUTO_INCREMENT,
  `calle` varchar(30) NOT NULL,
  `num` varchar(10) NOT NULL,
  `esq` varchar(30) DEFAULT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_alma`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacen`
--

LOCK TABLES `almacen` WRITE;
/*!40000 ALTER TABLE `almacen` DISABLE KEYS */;
INSERT INTO `almacen` VALUES (1,'Av Luis Batlle Berres','9867','Av al Parque Lecocq',0),(2,'Circulacion e','15600','Bypass de Pando',0),(3,'Av Carlos Reyles','1952','',0),(4,'Gral Fructuoso Rivera','km 495','',1),(5,'Cam Antonio Lussich','4286','Napoles',0),(6,'dsa','1212','zxc',1),(8,'av italia','2525','ib',0),(9,'Luis battle berres','1231','aramburu',1),(10,'rivera','2323','soca',1);
/*!40000 ALTER TABLE `almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `almacena`
--

DROP TABLE IF EXISTS `almacena`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `almacena` (
  `id_prod` int unsigned NOT NULL,
  `id_alma` tinyint unsigned NOT NULL,
  `fecha_ingre` date DEFAULT NULL,
  PRIMARY KEY (`id_prod`,`id_alma`),
  KEY `fk_idalma_almacena` (`id_alma`),
  CONSTRAINT `fk_id_prod_almacena` FOREIGN KEY (`id_prod`) REFERENCES `producto` (`id_prod`),
  CONSTRAINT `fk_idalma_almacena` FOREIGN KEY (`id_alma`) REFERENCES `almacen` (`id_alma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacena`
--

LOCK TABLES `almacena` WRITE;
/*!40000 ALTER TABLE `almacena` DISABLE KEYS */;
/*!40000 ALTER TABLE `almacena` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `camion`
--

DROP TABLE IF EXISTS `camion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `camion` (
  `id_camion` int unsigned NOT NULL AUTO_INCREMENT,
  `peso_camion` smallint DEFAULT NULL,
  `volumen_camion` tinyint DEFAULT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_camion`),
  CONSTRAINT `check_pesoCamion` CHECK ((`peso_camion` > 0)),
  CONSTRAINT `check_volCamion` CHECK ((`volumen_camion` > 0))
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `camion`
--

LOCK TABLES `camion` WRITE;
/*!40000 ALTER TABLE `camion` DISABLE KEYS */;
INSERT INTO `camion` VALUES (1,26000,90,1),(2,26000,90,0),(3,26000,90,0),(4,26000,90,0),(5,23000,80,1),(6,24444,45,1),(7,25000,85,1),(8,24000,75,1);
/*!40000 ALTER TABLE `camion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `camionero`
--

DROP TABLE IF EXISTS `camionero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `camionero` (
  `id_camionero` int unsigned NOT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_camionero`),
  CONSTRAINT `fk_id_camionero` FOREIGN KEY (`id_camionero`) REFERENCES `trabajador` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `camionero`
--

LOCK TABLES `camionero` WRITE;
/*!40000 ALTER TABLE `camionero` DISABLE KEYS */;
INSERT INTO `camionero` VALUES (9,0),(13,0);
/*!40000 ALTER TABLE `camionero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conduce`
--

DROP TABLE IF EXISTS `conduce`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conduce` (
  `id_camionero` int unsigned NOT NULL,
  `id_camion` int unsigned NOT NULL,
  PRIMARY KEY (`id_camionero`,`id_camion`),
  KEY `fk_camion_conduce` (`id_camion`),
  CONSTRAINT `fk_camion_conduce` FOREIGN KEY (`id_camion`) REFERENCES `camion` (`id_camion`),
  CONSTRAINT `fk_camionero_conduce` FOREIGN KEY (`id_camionero`) REFERENCES `camionero` (`id_camionero`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conduce`
--

LOCK TABLES `conduce` WRITE;
/*!40000 ALTER TABLE `conduce` DISABLE KEYS */;
INSERT INTO `conduce` VALUES (9,2);
/*!40000 ALTER TABLE `conduce` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `destino`
--

DROP TABLE IF EXISTS `destino`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `destino` (
  `id_des` int unsigned NOT NULL AUTO_INCREMENT,
  `calle` varchar(30) NOT NULL,
  `num` varchar(10) NOT NULL,
  `esq` varchar(30) DEFAULT NULL,
  `fech_esti` datetime DEFAULT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_des`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `destino`
--

LOCK TABLES `destino` WRITE;
/*!40000 ALTER TABLE `destino` DISABLE KEYS */;
INSERT INTO `destino` VALUES (1,'Av Luis Batlle Berres','9867','Av al Parque Lecocq','2023-01-22 00:00:00',0),(2,'Circulacion e','15600','Bypass de Pando','2023-01-22 00:00:00',0),(3,'Av Carlos Reyles','1952','','2023-10-22 00:00:00',0),(4,'Gral Fructuoso Rivera','km 495','','2023-09-11 00:00:00',1),(5,'Cam Antonio Lussich','4286','Napoles','2023-09-11 00:00:00',0),(6,'nuevaprueba','255 prueba','esquinaprueba','2023-10-22 14:00:00',1),(7,'demostenes','24245','santiago rivas','2023-12-01 12:45:09',0),(8,'pruebasql','33432','sql','2023-11-18 14:36:14',0),(10,'Destino','5654','esqDestino','2023-11-16 15:09:19',1);
/*!40000 ALTER TABLE `destino` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gestiona`
--

DROP TABLE IF EXISTS `gestiona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gestiona` (
  `id_operario` int unsigned NOT NULL,
  `id_alma` tinyint unsigned NOT NULL,
  PRIMARY KEY (`id_operario`,`id_alma`),
  KEY `fk_almacen_gestiona` (`id_alma`),
  CONSTRAINT `fk_almacen_gestiona` FOREIGN KEY (`id_alma`) REFERENCES `almacen` (`id_alma`),
  CONSTRAINT `fk_operario_gestiona` FOREIGN KEY (`id_operario`) REFERENCES `operario` (`id_operario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gestiona`
--

LOCK TABLES `gestiona` WRITE;
/*!40000 ALTER TABLE `gestiona` DISABLE KEYS */;
INSERT INTO `gestiona` VALUES (8,1),(8,10);
/*!40000 ALTER TABLE `gestiona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `integra`
--

DROP TABLE IF EXISTS `integra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `integra` (
  `id_prod` int unsigned NOT NULL,
  `id_lote` int unsigned NOT NULL,
  PRIMARY KEY (`id_prod`,`id_lote`),
  KEY `fk_idlote_integra` (`id_lote`),
  CONSTRAINT `fk_idlote_integra` FOREIGN KEY (`id_lote`) REFERENCES `lote` (`id_lote`),
  CONSTRAINT `fk_idprod_integra` FOREIGN KEY (`id_prod`) REFERENCES `producto` (`id_prod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `integra`
--

LOCK TABLES `integra` WRITE;
/*!40000 ALTER TABLE `integra` DISABLE KEYS */;
INSERT INTO `integra` VALUES (2,1),(3,4),(5,7),(13,7),(14,16);
/*!40000 ALTER TABLE `integra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `llevan`
--

DROP TABLE IF EXISTS `llevan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `llevan` (
  `id_camion` int unsigned NOT NULL,
  `id_lote` int unsigned NOT NULL,
  `fech_sal` datetime NOT NULL,
  PRIMARY KEY (`id_camion`,`id_lote`),
  KEY `fk_idlote_llevan` (`id_lote`),
  CONSTRAINT `fk_idcamion_llevan` FOREIGN KEY (`id_camion`) REFERENCES `camion` (`id_camion`),
  CONSTRAINT `fk_idlote_llevan` FOREIGN KEY (`id_lote`) REFERENCES `lote` (`id_lote`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `llevan`
--

LOCK TABLES `llevan` WRITE;
/*!40000 ALTER TABLE `llevan` DISABLE KEYS */;
INSERT INTO `llevan` VALUES (2,7,'2023-11-18 23:39:03'),(2,16,'2023-11-15 15:11:38');
/*!40000 ALTER TABLE `llevan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lote`
--

DROP TABLE IF EXISTS `lote`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lote` (
  `id_lote` int unsigned NOT NULL AUTO_INCREMENT,
  `fech_crea` date NOT NULL,
  `fech_entre` datetime DEFAULT NULL,
  `id_des` int unsigned NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  `posicion` enum('Adelante','Intermedio','Atras') NOT NULL,
  PRIMARY KEY (`id_lote`,`id_des`,`fech_crea`),
  KEY `fk_IdDes_lote` (`id_des`),
  CONSTRAINT `fk_IdDes_lote` FOREIGN KEY (`id_des`) REFERENCES `destino` (`id_des`),
  CONSTRAINT `check_fechas` CHECK ((`fech_entre` > `fech_crea`))
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lote`
--

LOCK TABLES `lote` WRITE;
/*!40000 ALTER TABLE `lote` DISABLE KEYS */;
INSERT INTO `lote` VALUES (1,'2023-01-20','2023-01-22 00:00:00',1,'prueba1@gmail.com',0,'Adelante'),(2,'2023-01-20','2023-10-22 00:00:00',2,'prueba2@gmail.com',0,'Adelante'),(3,'2023-10-18','2023-10-22 00:00:00',2,'prueba3@gmail.com',0,'Adelante'),(4,'2023-09-09','2023-09-11 00:00:00',4,'prueba4@gmail.com',1,'Adelante'),(5,'2023-09-10','2023-09-11 00:00:00',4,'prueba5@gmail.com',0,'Adelante'),(6,'2023-11-09','2023-11-10 22:12:33',2,'test@gmail.com',1,'Intermedio'),(7,'2023-11-09','2023-11-23 12:23:22',2,'test2@gmail.com',1,'Atras'),(12,'2023-11-11','2023-11-17 09:44:01',1,'pruebaasql@gmail.com',1,'Adelante'),(13,'2023-11-12','2023-11-27 13:00:00',2,'pedroperez@gmail.com',1,'Adelante'),(15,'2023-11-14','2023-11-16 16:00:00',2,'email@gmail.com',1,'Intermedio'),(16,'2023-11-14','2023-11-17 18:00:00',2,'email@gmail.com',1,'Adelante');
/*!40000 ALTER TABLE `lote` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `operario`
--

DROP TABLE IF EXISTS `operario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `operario` (
  `id_operario` int unsigned NOT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_operario`),
  CONSTRAINT `fk_id_operario` FOREIGN KEY (`id_operario`) REFERENCES `trabajador` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operario`
--

LOCK TABLES `operario` WRITE;
/*!40000 ALTER TABLE `operario` DISABLE KEYS */;
INSERT INTO `operario` VALUES (8,0);
/*!40000 ALTER TABLE `operario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `id_prod` int unsigned NOT NULL AUTO_INCREMENT,
  `peso_producto` smallint DEFAULT NULL,
  `volumen_producto` tinyint DEFAULT NULL,
  `calle` varchar(30) NOT NULL,
  `num` varchar(10) NOT NULL,
  `esq` varchar(30) DEFAULT NULL,
  `cliente` varchar(20) NOT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_prod`),
  CONSTRAINT `check_pesoProducto` CHECK ((`peso_producto` > 0)),
  CONSTRAINT `check_volProducto` CHECK ((`volumen_producto` > 0))
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,15000,45,'Calle 8','200','Esquina 2','CRECOM',0),(2,11000,45,'Calle 9','200','Esquina 2','CRECOM',1),(3,8000,45,'Calle 1','2670','Esquina 7','CRECOM',0),(4,5000,10,'Calle 2','9201','Esquina 10','Fodex',0),(5,5000,25,'Calle 3','5372','Esquina 22','miaTienda',0),(7,1200,23,'rivera','22','soca','CRECOM',1),(12,1400,45,'Calle 12','2432','Esquina 13','ClientePrueba',1),(13,1540,50,'Calle 15','2421','Esquina 16','Cliente',1),(14,1580,35,'Calle 123','2432','Esquina 124','Cliente',1),(15,1580,25,'calle','2342','esquina','cliente',1);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recorrido`
--

DROP TABLE IF EXISTS `recorrido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recorrido` (
  `id_des` int unsigned NOT NULL,
  `id_alma` tinyint unsigned NOT NULL,
  `tipo_trayecto` enum('Inicio','Parada','Fin') DEFAULT NULL,
  `fech_trayecto` datetime DEFAULT NULL,
  PRIMARY KEY (`id_des`,`id_alma`),
  KEY `fk_id_alma_contiene` (`id_alma`),
  CONSTRAINT `fk_id_alma_contiene` FOREIGN KEY (`id_alma`) REFERENCES `almacen` (`id_alma`),
  CONSTRAINT `fk_id_des_contiene` FOREIGN KEY (`id_des`) REFERENCES `destino` (`id_des`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recorrido`
--

LOCK TABLES `recorrido` WRITE;
/*!40000 ALTER TABLE `recorrido` DISABLE KEYS */;
INSERT INTO `recorrido` VALUES (2,1,'Inicio','2023-11-25 07:56:53'),(3,1,'Inicio','2023-12-02 06:20:31'),(4,1,'Parada','2023-11-18 12:00:00');
/*!40000 ALTER TABLE `recorrido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trabajador`
--

DROP TABLE IF EXISTS `trabajador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trabajador` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(16) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `nom` varchar(30) DEFAULT NULL,
  `ape` varchar(30) DEFAULT NULL,
  `tel` varchar(12) DEFAULT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trabajador`
--

LOCK TABLES `trabajador` WRITE;
/*!40000 ALTER TABLE `trabajador` DISABLE KEYS */;
INSERT INTO `trabajador` VALUES (1,'jperez','jperez123','Juan','Perez','095358999',0),(2,'wwhite','whwc789','Walter','White','091355999',0),(3,'jrosa','jhombrerosa123','Jesse','Pinkman','093358219',0),(4,'drfreeman','lamnda567','Gordon','Freeman','091358922',0),(5,'2lawyer','soulgoodmanBTS','James','McGill','098358929',0),(6,'kimwex','sleepingKim54321','Kimberly','Wexler','095358888',0),(7,'elnoba','tiracorte123','Lautaro','Rene','092358799',0),(8,'user3','81dc9bdb52d04dc20036dbd8313ed055','operario','operaridou','242424',0),(9,'user1','81dc9bdb52d04dc20036dbd8313ed055','camionero','camionedou','252525',0),(11,'juancillo','81dc9bdb52d04dc20036dbd8313ed055','juan','pinkman','23124',0),(13,'operator12','81dc9bdb52d04dc20036dbd8313ed055','name','lastnme','2435621',0);
/*!40000 ALTER TABLE `trabajador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transporta`
--

DROP TABLE IF EXISTS `transporta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transporta` (
  `id_camion` int unsigned NOT NULL,
  `id_lote` int unsigned NOT NULL,
  `id_des` int unsigned NOT NULL,
  `estatus` enum('Entregado','EnCamino','Retrasado','NoEnviado') DEFAULT NULL,
  PRIMARY KEY (`id_camion`,`id_lote`,`id_des`),
  KEY `fk_idlote_transporta` (`id_lote`),
  KEY `fk_iddes_transporta` (`id_des`),
  CONSTRAINT `fk_idcamion_camion` FOREIGN KEY (`id_camion`) REFERENCES `camion` (`id_camion`),
  CONSTRAINT `fk_iddes_transporta` FOREIGN KEY (`id_des`) REFERENCES `destino` (`id_des`),
  CONSTRAINT `fk_idlote_transporta` FOREIGN KEY (`id_lote`) REFERENCES `lote` (`id_lote`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transporta`
--

LOCK TABLES `transporta` WRITE;
/*!40000 ALTER TABLE `transporta` DISABLE KEYS */;
INSERT INTO `transporta` VALUES (1,1,3,'Retrasado'),(2,7,5,'Entregado'),(2,16,2,'EnCamino');
/*!40000 ALTER TABLE `transporta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vista_camiones_disponibles`
--

DROP TABLE IF EXISTS `vista_camiones_disponibles`;
/*!50001 DROP VIEW IF EXISTS `vista_camiones_disponibles`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_camiones_disponibles` AS SELECT 
 1 AS `id_camion`,
 1 AS `peso_camion`,
 1 AS `volumen_camion`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vista_entregas_pendientes`
--

DROP TABLE IF EXISTS `vista_entregas_pendientes`;
/*!50001 DROP VIEW IF EXISTS `vista_entregas_pendientes`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_entregas_pendientes` AS SELECT 
 1 AS `id_lote`,
 1 AS `direccion_entrega`,
 1 AS `fech_entre`,
 1 AS `estatus`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vista_inventario_almacen`
--

DROP TABLE IF EXISTS `vista_inventario_almacen`;
/*!50001 DROP VIEW IF EXISTS `vista_inventario_almacen`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_inventario_almacen` AS SELECT 
 1 AS `id_alma`,
 1 AS `calle`,
 1 AS `num`,
 1 AS `esq`,
 1 AS `cantidad_productos`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vista_trabajadores_tipo`
--

DROP TABLE IF EXISTS `vista_trabajadores_tipo`;
/*!50001 DROP VIEW IF EXISTS `vista_trabajadores_tipo`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vista_trabajadores_tipo` AS SELECT 
 1 AS `id_trabajador`,
 1 AS `username`,
 1 AS `tipo_trabajador`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vista_camiones_disponibles`
--

/*!50001 DROP VIEW IF EXISTS `vista_camiones_disponibles`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_camiones_disponibles` AS select `c`.`id_camion` AS `id_camion`,`c`.`peso_camion` AS `peso_camion`,`c`.`volumen_camion` AS `volumen_camion` from `camion` `c` where (`c`.`bajalogica` = 0) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_entregas_pendientes`
--

/*!50001 DROP VIEW IF EXISTS `vista_entregas_pendientes`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_entregas_pendientes` AS select `l`.`id_lote` AS `id_lote`,`d`.`calle` AS `direccion_entrega`,`l`.`fech_entre` AS `fech_entre`,`t`.`estatus` AS `estatus` from ((`lote` `l` join `destino` `d` on((`l`.`id_des` = `d`.`id_des`))) join `transporta` `t` on((`l`.`id_lote` = `t`.`id_lote`))) where ((`t`.`estatus` <> 'Entregado') and (`l`.`bajalogica` = 0)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_inventario_almacen`
--

/*!50001 DROP VIEW IF EXISTS `vista_inventario_almacen`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_inventario_almacen` AS select `a`.`id_alma` AS `id_alma`,`a`.`calle` AS `calle`,`a`.`num` AS `num`,`a`.`esq` AS `esq`,count(`al`.`id_prod`) AS `cantidad_productos` from (`almacen` `a` left join `almacena` `al` on((`a`.`id_alma` = `al`.`id_alma`))) where (`a`.`bajalogica` = 0) group by `a`.`id_alma` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_trabajadores_tipo`
--

/*!50001 DROP VIEW IF EXISTS `vista_trabajadores_tipo`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_trabajadores_tipo` AS select `t`.`id` AS `id_trabajador`,`t`.`username` AS `username`,(case when (`c`.`id_camionero` is not null) then 'Camionero' else 'Operario' end) AS `tipo_trabajador` from (`trabajador` `t` left join `camionero` `c` on((`t`.`id` = `c`.`id_camionero`))) where (`t`.`bajalogica` = 0) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-15 10:48:00
