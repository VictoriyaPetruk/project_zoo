CREATE DATABASE  IF NOT EXISTS `zoo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `zoo`;
-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: zoo
-- ------------------------------------------------------
-- Server version	8.0.18

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
-- Table structure for table `animals`
--

DROP TABLE IF EXISTS `animals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `animals` (
  `id_a` int(10) NOT NULL AUTO_INCREMENT,
  `kind` char(50) NOT NULL,
  `vid` char(30) NOT NULL,
  `sex` varchar(1) NOT NULL DEFAULT 'ж',
  `price` double NOT NULL,
  `a_id_v` int(10) NOT NULL,
  `a_data` date NOT NULL,
  `food` char(100) DEFAULT NULL,
  `count_a` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_a`),
  UNIQUE KEY `id_a_UNIQUE` (`id_a`),
  KEY `a_id_v` (`a_id_v`),
  CONSTRAINT `animals_ibfk_1` FOREIGN KEY (`a_id_v`) REFERENCES `vaccine` (`id_v`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `animals_chk_1` CHECK ((`price` > 0))
) ENGINE=InnoDB AUTO_INCREMENT=75 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `animals`
--

LOCK TABLES `animals` WRITE;
/*!40000 ALTER TABLE `animals` DISABLE KEYS */;
INSERT INTO `animals` VALUES (1,'кіт','персидський','м',1500,2,'2020-04-20','птиця',10),(2,'кіт','сиамський','м',2000,2,'2020-04-20','птиця',11),(3,'кіт','британський','м',5000,2,'2020-04-20','птиця',7),(4,'кіт','мейн-кун','м',10000,2,'2020-04-20','птиця',8),(5,'собака','німецька вівчарка','м',7000,1,'2020-04-20','птиця',10),(6,'собака','пудель','м',6000,1,'2020-04-20','птиця',5),(7,'собака','ретривер','м',12000,1,'2020-04-20','птиця',7),(8,'собака','бигль','м',9000,1,'2020-04-20','птиця',6),(9,'черепаха','червоновуха','м',600,5,'2020-04-20','морква',7),(10,'черепаха','жовтопуза','м',400,5,'2020-04-20','морква',7),(11,'хом`як','джунгарський','м',300,3,'2020-04-20','хлібні палички',7),(12,'хом`як','польовий','м',300,3,'2020-04-20','хлібні палички',7),(13,'хом`як','звичайний','м',1500,3,'2020-04-20','хлібні палички',10),(14,'папуга','хвилястий','м',150,4,'2020-04-20','зерно',7),(15,'папуга','Корелла','м',500,4,'2020-04-20','зерно',7),(16,'папуга','Жако','м',800,4,'2020-04-20','зерно',7),(17,'папуга','Ара','м',1500,4,'2020-04-20','зерно',7),(18,'папуга','Какаду','м',2000,4,'2020-04-20','зерно',7),(19,'папуга','королівський','м',1000,4,'2020-04-20','зерно',7),(20,'папуга','Розелла','м',1500,4,'2020-04-20','зерно',7),(21,'миша','польова','м',200,3,'2020-04-20','зерно',7),(22,'миша','домова','м',200,3,'2020-04-20','зерно',11),(23,'кролик','Бельгійський','м',1500,3,'2020-04-20','морква',9),(24,'кролик','вінський блакитний','м',2000,3,'2020-04-20','морква',7),(25,'кролик','білий велетень','м',1500,3,'2020-04-20','морква',7),(26,'кролик','сірий велетень','м',1500,3,'2020-04-20','морква',7),(27,'соловей','звичайний','м',300,4,'2020-04-20','зерно',9),(28,'горлиця','звичайна','м',400,4,'2020-04-20','зерно',7),(29,'єнот','полоскун','м',2000,5,'2020-04-20','риба',13),(30,'єнот','ракоїд','м',1500,5,'2020-04-20','риба',7),(31,'єнот','Косумельський','м',1700,5,'2020-04-20','риба',7),(32,'морська свинка','Абиссінська','м',1000,3,'2020-04-20','кукурудза',7),(33,'морська свинка','скинні','м',1300,3,'2020-04-20','кукурудза',7),(34,'морська свинка','перуанська','м',1400,3,'2020-04-20','кукурудза',7),(35,'морська свинка','Тедді','м',1500,3,'2020-04-20','кукурудза',7),(36,'кіт','персидський','ж',1500,2,'2020-04-20','птиця',7),(37,'кіт','сиамський','ж',2000,2,'2020-04-20','птиця',8),(38,'кіт','британський','ж',5000,2,'2020-04-20','птиця',7),(39,'кіт','мейн-кун','ж',10000,2,'2020-04-20','птиця',7),(40,'собака','німецька вівчарка','ж',7000,1,'2020-04-20','птиця',7),(41,'собака','пудель','ж',6000,1,'2020-04-20','птиця',8),(42,'собака','ретривер','ж',12000,1,'2020-04-20','птиця',7),(43,'собака','бигль','ж',9000,1,'2020-04-20','птиця',7),(44,'черепаха','червоновуха','ж',600,5,'2020-04-20','морква',7),(45,'черепаха','жовтопуза','ж',400,5,'2020-04-20','морква',10),(46,'хом`як','джунгарський','ж',300,3,'2020-04-20','хлібні палички',7),(47,'хом`як','польовий','ж',300,3,'2020-04-20','хлібні палички',9),(48,'хом`як','звичайний','ж',150,3,'2020-04-20','хлібні палички',7),(49,'папуга','хвилястий','ж',150,4,'2020-04-20','зерно',7),(50,'папуга','Корелла','ж',500,4,'2020-04-20','зерно',7),(51,'папуга','Жако','ж',800,4,'2020-04-20','зерно',7),(52,'папуга','Ара','ж',1500,4,'2020-04-20','зерно',7),(53,'папуга','Какаду','ж',2000,4,'2020-04-20','зерно',7),(54,'папуга','королівський','ж',1000,4,'2020-04-20','зерно',7),(55,'папуга','Розелла','ж',1500,4,'2020-04-20','зерно',7),(56,'миша','польова','ж',200,3,'2020-04-20','зерно',7),(57,'миша','домова','ж',200,3,'2020-04-20','зерно',7),(58,'кролик','Бельгійський','ж',1500,3,'2020-04-20','морква',8),(59,'кролик','вінський блакитний','ж',2000,3,'2020-04-20','морква',7),(60,'кролик','білий велетень','ж',1500,3,'2020-04-20','морква',7),(61,'кролик','сірий велетень','ж',1500,3,'2020-04-20','морква',12),(62,'соловей','звичайний','ж',300,4,'2020-04-20','зерно',7),(63,'горлиця','звичайна','ж',400,4,'2020-04-20','зерно',7),(64,'єнот','полоскун','ж',2000,5,'2020-04-20','риба',31),(65,'єнот','ракоїд','ж',1500,5,'2020-04-20','риба',7),(66,'єнот','Косумельський','ж',1700,5,'2020-04-20','риба',7),(67,'морська свинка','Абиссінська','ж',1000,3,'2020-04-20','кукурудза',7),(68,'морська свинка','скинні','ж',1300,3,'2020-04-20','кукурудза',7),(69,'морська свинка','перуанська','ж',1400,3,'2020-04-20','кукурудза',7),(70,'морська свинка','Тедді','ж',1500,3,'2020-04-20','кукурудза',7),(73,'риба','карп','м',2000,2,'2020-05-19','корм',0),(74,'собака','рассел терьер','м',4000,1,'2020-05-20','птиця',6);
/*!40000 ALTER TABLE `animals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bill`
--

DROP TABLE IF EXISTS `bill`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bill` (
  `b_id` int(10) NOT NULL AUTO_INCREMENT,
  `id_a` int(10) NOT NULL,
  `sale` double DEFAULT NULL,
  `count` int(10) NOT NULL,
  `id_sell` int(10) NOT NULL,
  PRIMARY KEY (`b_id`),
  KEY `bill_ibfk_2` (`id_a`),
  KEY `bill_ibfk_3` (`id_sell`),
  CONSTRAINT `bill_ibfk_2` FOREIGN KEY (`id_a`) REFERENCES `animals` (`id_a`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `bill_ibfk_3` FOREIGN KEY (`id_sell`) REFERENCES `sell` (`id_sell`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=170 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bill`
--

LOCK TABLES `bill` WRITE;
/*!40000 ALTER TABLE `bill` DISABLE KEYS */;
INSERT INTO `bill` VALUES (36,46,0,2,24),(38,6,0,1,25),(39,1,0,1,26),(49,36,0,2,31),(53,6,0,1,34),(54,46,0,2,35),(59,2,0,2,39),(60,2,0,1,40),(61,5,0,2,41),(62,5,0,2,41),(63,2,0,2,42),(64,47,0,3,43),(101,45,0,2,65),(102,63,0,3,65),(103,11,0,3,66),(104,44,0,5,66),(105,2,0,2,67),(106,52,0,3,67),(107,28,0,2,68),(108,17,0,4,68),(110,62,0,6,69),(112,63,0,4,70),(114,28,0,3,71),(115,43,0,1,72),(116,25,0,1,72),(117,57,0,3,73),(118,46,0,2,73),(119,41,0,2,74),(120,6,0,4,75),(121,4,0,3,76),(141,64,0,1,86),(142,29,0,1,86),(148,43,0,2,91),(149,8,0,3,92),(153,70,0,2,96),(154,55,0,1,96),(157,55,0,2,97),(158,45,0,1,97),(159,44,0,2,97),(160,39,0,1,98),(161,22,0,1,99),(163,26,0,1,101),(164,59,0,1,102),(167,26,0,3,104),(168,35,0,2,104),(169,28,0,1,104);
/*!40000 ALTER TABLE `bill` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enter`
--

DROP TABLE IF EXISTS `enter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `enter` (
  `login` char(30) NOT NULL,
  `password` int(8) NOT NULL,
  PRIMARY KEY (`login`),
  UNIQUE KEY `login` (`login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enter`
--

LOCK TABLES `enter` WRITE;
/*!40000 ALTER TABLE `enter` DISABLE KEYS */;
INSERT INTO `enter` VALUES ('admin',123),('vikapetruk',1234);
/*!40000 ALTER TABLE `enter` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `positionn`
--

DROP TABLE IF EXISTS `positionn`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `positionn` (
  `id_p` int(10) NOT NULL AUTO_INCREMENT,
  `p_name` char(30) NOT NULL,
  PRIMARY KEY (`id_p`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `positionn`
--

LOCK TABLES `positionn` WRITE;
/*!40000 ALTER TABLE `positionn` DISABLE KEYS */;
INSERT INTO `positionn` VALUES (1,'адміністратор'),(2,'директор'),(3,'касир'),(4,'консультант'),(5,'доглядач за тваринами'),(11,'касир-консультант'),(15,'уборщица');
/*!40000 ALTER TABLE `positionn` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sell`
--

DROP TABLE IF EXISTS `sell`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sell` (
  `id_sell` int(10) NOT NULL AUTO_INCREMENT,
  `data_sell` date DEFAULT NULL,
  `id_s` int(10) NOT NULL,
  PRIMARY KEY (`id_sell`),
  KEY `sell_ibfk_1` (`id_s`),
  CONSTRAINT `sell_ibfk_1` FOREIGN KEY (`id_s`) REFERENCES `staff` (`id_s`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sell`
--

LOCK TABLES `sell` WRITE;
/*!40000 ALTER TABLE `sell` DISABLE KEYS */;
INSERT INTO `sell` VALUES (1,'2020-04-30',1),(2,'2020-04-30',3),(5,'2020-05-04',2),(24,'2020-05-05',1),(25,'2020-05-05',2),(26,'2020-05-05',1),(31,'2020-05-05',4),(34,'2020-05-07',1),(35,'2020-05-07',3),(39,'2020-05-07',1),(40,'2020-05-07',1),(41,'2020-05-07',1),(42,'2020-05-07',1),(43,'2020-05-07',1),(65,'2020-05-08',1),(66,'2020-05-08',2),(67,'2020-05-08',1),(68,'2020-05-08',2),(69,'2020-05-08',4),(70,'2020-05-08',2),(71,'2020-05-08',3),(72,'2020-05-09',3),(73,'2020-05-09',1),(74,'2020-05-09',2),(75,'2020-05-14',2),(76,'2020-05-14',1),(77,'2020-05-14',1),(78,'2020-05-14',1),(79,'2020-05-14',1),(80,'2020-05-14',2),(86,'2020-05-18',2),(91,'2020-05-19',1),(92,'2020-05-19',1),(96,'2020-05-19',1),(97,'2020-05-19',1),(98,'2020-05-19',1),(99,'2020-05-19',2),(101,'2020-05-20',1),(102,'2020-05-20',3),(104,'2020-05-20',1);
/*!40000 ALTER TABLE `sell` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `id_s` int(10) NOT NULL AUTO_INCREMENT,
  `name_s` char(50) NOT NULL,
  `lname_s` char(50) NOT NULL,
  `n_phone` char(16) NOT NULL,
  `stan` char(20) NOT NULL,
  `birthday` date DEFAULT NULL,
  `s_id_p` int(10) NOT NULL,
  PRIMARY KEY (`id_s`),
  KEY `s_id_p` (`s_id_p`),
  CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`s_id_p`) REFERENCES `positionn` (`id_p`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,'Ангеліна','Аксьонова','0987653425','звільнений','2000-07-14',1),(2,'Богдан','Дорошенко','0873452678','працює','2000-08-20',2),(3,'Каріна','Черкасова','0674563489','працює','1999-07-20',3),(4,'Кирило','Петренко','098765434','працює','1989-06-20',4),(5,'Петро','Павленко','097234567','працює','2000-05-20',4),(11,'Виктория','Петрук','0960114795','у відпустці','2001-07-05',1),(13,'Ирина','Ириновна','987653425','працює','2020-05-20',15);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `id_sp` int(10) NOT NULL AUTO_INCREMENT,
  `name_f` char(50) NOT NULL,
  `f_phone` char(16) NOT NULL,
  `manager` char(150) DEFAULT NULL,
  `data_c` date NOT NULL,
  `activ` char(1) DEFAULT NULL,
  PRIMARY KEY (`id_sp`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (1,'Animalssphera','983456','Олександр Кравченко','2020-04-30','+'),(2,'Zooland','3450987','Марія Стефаненко','2020-03-15','+'),(3,'Zoongo','50678923','Кирило Стефаненко','2020-05-10','+');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vaccine`
--

DROP TABLE IF EXISTS `vaccine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vaccine` (
  `id_v` int(10) NOT NULL AUTO_INCREMENT,
  `name_v` char(50) DEFAULT NULL,
  `v_data` date NOT NULL,
  PRIMARY KEY (`id_v`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vaccine`
--

LOCK TABLES `vaccine` WRITE;
/*!40000 ALTER TABLE `vaccine` DISABLE KEYS */;
INSERT INTO `vaccine` VALUES (1,'РАБИЗИН(для собак)','2020-04-20'),(2,'Биовета(для котів)','2020-04-20'),(3,'Лапинеум(для гризунів)','2020-04-20'),(4,'Биофел(для птиць)','2020-04-20'),(5,'Глобфел(підходить всім)','2020-04-20'),(6,'Громазин','2020-05-03');
/*!40000 ALTER TABLE `vaccine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `waybill`
--

DROP TABLE IF EXISTS `waybill`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `waybill` (
  `id_w` int(10) NOT NULL AUTO_INCREMENT,
  `id_sp` int(10) NOT NULL,
  `id_s` int(10) NOT NULL,
  `data_post` date NOT NULL,
  PRIMARY KEY (`id_w`),
  KEY `id_sp` (`id_sp`),
  KEY `id_s` (`id_s`),
  CONSTRAINT `waybill_ibfk_1` FOREIGN KEY (`id_sp`) REFERENCES `supplier` (`id_sp`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `waybill_ibfk_2` FOREIGN KEY (`id_s`) REFERENCES `staff` (`id_s`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `waybill`
--

LOCK TABLES `waybill` WRITE;
/*!40000 ALTER TABLE `waybill` DISABLE KEYS */;
INSERT INTO `waybill` VALUES (1,1,1,'2020-04-30'),(2,1,3,'2020-04-30'),(3,2,4,'2020-04-30'),(4,1,4,'2020-04-30'),(5,2,3,'2020-05-08'),(8,2,3,'2020-05-08'),(9,2,3,'2020-05-08'),(10,2,3,'2020-05-08'),(11,2,3,'2020-05-09'),(13,2,11,'2020-05-18'),(15,2,3,'2020-05-18'),(16,2,3,'2020-05-18'),(17,2,3,'2020-05-18'),(18,2,3,'2020-05-18'),(19,2,3,'2020-05-18'),(20,2,3,'2020-05-18'),(21,2,3,'2020-05-18'),(22,2,3,'2020-05-18'),(23,2,3,'2020-05-18'),(24,2,3,'2020-05-18'),(25,2,11,'2020-05-18'),(26,2,3,'2020-05-18'),(27,2,11,'2020-05-19'),(28,2,3,'2020-05-20');
/*!40000 ALTER TABLE `waybill` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `waybill_animal`
--

DROP TABLE IF EXISTS `waybill_animal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `waybill_animal` (
  `id_wa` int(10) NOT NULL AUTO_INCREMENT,
  `id_w` int(10) NOT NULL,
  `id_a` int(10) NOT NULL,
  `price` double NOT NULL,
  `count_w` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_wa`),
  KEY `id_w` (`id_w`),
  KEY `waybill_animal_ibfk_1` (`id_a`),
  CONSTRAINT `waybill_animal_ibfk_1` FOREIGN KEY (`id_a`) REFERENCES `animals` (`id_a`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `waybill_animal_ibfk_2` FOREIGN KEY (`id_w`) REFERENCES `waybill` (`id_w`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `waybill_animal`
--

LOCK TABLES `waybill_animal` WRITE;
/*!40000 ALTER TABLE `waybill_animal` DISABLE KEYS */;
INSERT INTO `waybill_animal` VALUES (1,1,1,1000,1),(2,2,2,1000,1),(3,3,3,2000,1),(4,4,4,4000,1),(5,1,5,3000,1),(6,2,6,2000,1),(33,8,3,1200,5),(35,8,11,200,5),(36,9,2,1200,4),(37,9,56,200,3),(38,10,1,1500,3),(39,10,46,150,2),(48,27,5,3500,5),(49,28,74,2000,3),(50,28,5,3000,2);
/*!40000 ALTER TABLE `waybill_animal` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-22 15:23:08
