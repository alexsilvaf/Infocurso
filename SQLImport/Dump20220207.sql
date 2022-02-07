CREATE DATABASE  IF NOT EXISTS `db_infocourse` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_infocourse`;
-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: db_infocourse
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aula`
--

DROP TABLE IF EXISTS `aula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aula` (
  `idAula` int unsigned NOT NULL AUTO_INCREMENT,
  `titulo` varchar(50) NOT NULL,
  `video` varchar(150) NOT NULL,
  `idCurs` int unsigned NOT NULL,
  PRIMARY KEY (`idAula`),
  UNIQUE KEY `idAula_UNIQUE` (`idAula`),
  KEY `fk_aula_curs1_idx` (`idCurs`),
  CONSTRAINT `fk_aula_curs1` FOREIGN KEY (`idCurs`) REFERENCES `curs` (`idCurs`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aula`
--

LOCK TABLES `aula` WRITE;
/*!40000 ALTER TABLE `aula` DISABLE KEYS */;
/*!40000 ALTER TABLE `aula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `catg`
--

DROP TABLE IF EXISTS `catg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `catg` (
  `idCatg` int unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  PRIMARY KEY (`idCatg`),
  UNIQUE KEY `idCatg_UNIQUE` (`idCatg`),
  UNIQUE KEY `nomeCatg_UNIQUE` (`nome`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catg`
--

LOCK TABLES `catg` WRITE;
/*!40000 ALTER TABLE `catg` DISABLE KEYS */;
INSERT INTO `catg` VALUES (2,'Administração'),(3,'Ciências Contábeis'),(5,'Engenharia Elétrica'),(1,'Informática'),(4,'Recursos Humanos');
/*!40000 ALTER TABLE `catg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curs`
--

DROP TABLE IF EXISTS `curs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `curs` (
  `idCurs` int unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `descricao` varchar(200) DEFAULT NULL,
  `idProfessor` int unsigned NOT NULL,
  `idNivl` int unsigned NOT NULL,
  `idCatg` int unsigned NOT NULL,
  PRIMARY KEY (`idCurs`),
  UNIQUE KEY `idCurs_UNIQUE` (`idCurs`),
  UNIQUE KEY `nome_UNIQUE` (`nome`),
  KEY `fk_curs_catg1_idx` (`idCatg`),
  KEY `fk_curs_nivl1_idx` (`idNivl`),
  KEY `fk_curs_usua1_idx` (`idProfessor`),
  CONSTRAINT `fk_curs_catg1` FOREIGN KEY (`idCatg`) REFERENCES `catg` (`idCatg`),
  CONSTRAINT `fk_curs_nivl1` FOREIGN KEY (`idNivl`) REFERENCES `nivl` (`idNivl`),
  CONSTRAINT `fk_curs_usua1` FOREIGN KEY (`idProfessor`) REFERENCES `usua` (`idUsua`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curs`
--

LOCK TABLES `curs` WRITE;
/*!40000 ALTER TABLE `curs` DISABLE KEYS */;
/*!40000 ALTER TABLE `curs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nivl`
--

DROP TABLE IF EXISTS `nivl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nivl` (
  `idNivl` int unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(15) NOT NULL,
  PRIMARY KEY (`idNivl`),
  UNIQUE KEY `idNivl_UNIQUE` (`idNivl`),
  UNIQUE KEY `nome_UNIQUE` (`nome`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nivl`
--

LOCK TABLES `nivl` WRITE;
/*!40000 ALTER TABLE `nivl` DISABLE KEYS */;
INSERT INTO `nivl` VALUES (3,'Avançado'),(1,'Básico'),(2,'Intermediário');
/*!40000 ALTER TABLE `nivl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sexo`
--

DROP TABLE IF EXISTS `sexo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sexo` (
  `idSexo` int unsigned NOT NULL AUTO_INCREMENT,
  `nome` char(1) NOT NULL,
  PRIMARY KEY (`idSexo`),
  UNIQUE KEY `idSexo_UNIQUE` (`idSexo`),
  UNIQUE KEY `nome_UNIQUE` (`nome`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sexo`
--

LOCK TABLES `sexo` WRITE;
/*!40000 ALTER TABLE `sexo` DISABLE KEYS */;
INSERT INTO `sexo` VALUES (2,'F'),(1,'M');
/*!40000 ALTER TABLE `sexo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usua`
--

DROP TABLE IF EXISTS `usua`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usua` (
  `idUsua` int unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `email` varchar(40) DEFAULT NULL,
  `telefone1` varchar(16) NOT NULL,
  `telefone2` varchar(16) DEFAULT NULL,
  `cpf` varchar(14) NOT NULL,
  `rg` varchar(9) DEFAULT NULL,
  `senha` varchar(30) NOT NULL,
  `dataNascimento` date NOT NULL,
  `idSexo` int unsigned NOT NULL,
  PRIMARY KEY (`idUsua`),
  UNIQUE KEY `idUsua_UNIQUE` (`idUsua`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`),
  KEY `fk_usua_sexo1_idx` (`idSexo`),
  CONSTRAINT `fk_usua_sexo1` FOREIGN KEY (`idSexo`) REFERENCES `sexo` (`idSexo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usua`
--

LOCK TABLES `usua` WRITE;
/*!40000 ALTER TABLE `usua` DISABLE KEYS */;
INSERT INTO `usua` VALUES (1,'Admin','admin@infocurso.com.br','(00) 0 0000-0000','(28) 9 8804-6220','000.000.000-00','0.000.000','123','2000-09-12',1);
/*!40000 ALTER TABLE `usua` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'db_infocourse'
--

--
-- Dumping routines for database 'db_infocourse'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-02-07 18:01:44
