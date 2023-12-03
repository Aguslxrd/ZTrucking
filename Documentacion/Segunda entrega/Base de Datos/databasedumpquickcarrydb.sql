-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: quickcarrydb
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacen`
--

LOCK TABLES `almacen` WRITE;
/*!40000 ALTER TABLE `almacen` DISABLE KEYS */;
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
  CONSTRAINT `check_pesoCamion` CHECK ((`peso_camion` <= 26000)),
  CONSTRAINT `check_volCamion` CHECK ((`volumen_camion` <= 90))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `camion`
--

LOCK TABLES `camion` WRITE;
/*!40000 ALTER TABLE `camion` DISABLE KEYS */;
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
  `fech_esti` date DEFAULT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_des`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `destino`
--

LOCK TABLES `destino` WRITE;
/*!40000 ALTER TABLE `destino` DISABLE KEYS */;
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
  `fech_sal` date NOT NULL,
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
  `fech_entre` date DEFAULT NULL,
  `id_des` int unsigned NOT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_lote`,`id_des`,`fech_crea`),
  KEY `fk_IdDes_lote` (`id_des`),
  CONSTRAINT `fk_IdDes_lote` FOREIGN KEY (`id_des`) REFERENCES `destino` (`id_des`),
  CONSTRAINT `check_fechas` CHECK ((`fech_entre` > `fech_crea`))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lote`
--

LOCK TABLES `lote` WRITE;
/*!40000 ALTER TABLE `lote` DISABLE KEYS */;
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
  `peso_producto` smallint unsigned DEFAULT NULL,
  `volumen_producto` tinyint unsigned DEFAULT NULL,
  `calle` varchar(30) NOT NULL,
  `num` varchar(10) NOT NULL,
  `esq` varchar(30) DEFAULT NULL,
  `cliente` varchar(20) NOT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_prod`),
  CONSTRAINT `check_pesoProducto` CHECK ((`peso_producto` <= 26000)),
  CONSTRAINT `check_volProducto` CHECK ((`volumen_producto` <= 90))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trabajador`
--

LOCK TABLES `trabajador` WRITE;
/*!40000 ALTER TABLE `trabajador` DISABLE KEYS */;
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
/*!40000 ALTER TABLE `transporta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-22 14:17:39
