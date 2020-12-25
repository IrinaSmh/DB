CREATE DATABASE  IF NOT EXISTS `food` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `food`;
-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: food
-- ------------------------------------------------------
-- Server version	8.0.21

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
-- Table structure for table `characteristics`
--

DROP TABLE IF EXISTS `characteristics`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `characteristics` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `char_name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `characteristics`
--

LOCK TABLES `characteristics` WRITE;
/*!40000 ALTER TABLE `characteristics` DISABLE KEYS */;
INSERT INTO `characteristics` VALUES (1,'белки'),(2,'жиры'),(4,'калории'),(3,'углеводы');
/*!40000 ALTER TABLE `characteristics` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dishes`
--

DROP TABLE IF EXISTS `dishes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dishes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=3075 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dishes`
--

LOCK TABLES `dishes` WRITE;
/*!40000 ALTER TABLE `dishes` DISABLE KEYS */;
INSERT INTO `dishes` VALUES (58,'безе'),(39,'беляш'),(59,'бисквит'),(40,'блины'),(8,'блины с клубникой'),(1,'борщ'),(9,'бульон куриный'),(28,'бургер'),(57,'ватрушки'),(36,'винегрет'),(26,'врикасе'),(41,'галушки'),(71,'грибной соус'),(14,'гуляш'),(16,'долма'),(4,'жареная картошка'),(35,'жульен'),(68,'зефир'),(15,'зразы'),(67,'кекс'),(69,'кетчуп'),(56,'коржик'),(34,'креветки'),(54,'кулич'),(55,'курник'),(53,'лепешка'),(70,'майонез'),(52,'манник'),(51,'манты'),(27,'мясо по французски'),(3,'овощной салат'),(10,'окрошка'),(37,'оливье'),(23,'отбивные'),(65,'пахлава'),(33,'паштет говяжий'),(32,'паштет свиной'),(5,'пельмени'),(64,'печенье'),(42,'пицца'),(17,'плов'),(46,'пряники'),(18,'пудинг'),(43,'пышки'),(19,'рагу'),(49,'рогалики'),(24,'роллы'),(25,'ростбиф'),(48,'рулет с мясом'),(6,'салат \"Крабовый\"'),(38,'салат мимоза'),(47,'самса'),(63,'сиров'),(11,'солянка'),(66,'суфле'),(72,'сырный соус'),(44,'тесто слоеное'),(74,'томатный соус'),(13,'уха'),(22,'фрикадельки'),(50,'хинкали'),(7,'хлеб'),(29,'хумус'),(60,'чак-чак'),(73,'чесночный соус'),(61,'чизкейк'),(30,'чипсы'),(31,'шаурма'),(21,'шашлык'),(20,'шницель'),(12,'щи'),(62,'эклер'),(45,'эчпочмак'),(2,'яичница');
/*!40000 ALTER TABLE `dishes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dishes_has_products`
--

DROP TABLE IF EXISTS `dishes_has_products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dishes_has_products` (
  `dishes_id` int NOT NULL,
  `products_id` int NOT NULL,
  `quantity` double DEFAULT NULL,
  `measurementtype_id` int DEFAULT NULL,
  PRIMARY KEY (`dishes_id`,`products_id`),
  KEY `fk_dishes_has_products_products1_idx` (`products_id`),
  KEY `fk_dishes_has_products_dishes_idx` (`dishes_id`),
  KEY `fk_dishes_has_products_measurement type1_idx` (`measurementtype_id`),
  CONSTRAINT `fk_dishes_has_products_dishes` FOREIGN KEY (`dishes_id`) REFERENCES `dishes` (`id`),
  CONSTRAINT `fk_dishes_has_products_measurement type1` FOREIGN KEY (`measurementtype_id`) REFERENCES `measurement type` (`id`),
  CONSTRAINT `fk_dishes_has_products_products1` FOREIGN KEY (`products_id`) REFERENCES `products` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dishes_has_products`
--

LOCK TABLES `dishes_has_products` WRITE;
/*!40000 ALTER TABLE `dishes_has_products` DISABLE KEYS */;
INSERT INTO `dishes_has_products` VALUES (1,1,500,2),(1,2,1,1),(1,3,2,1),(1,4,200,2),(1,5,1,2),(1,6,1,2),(1,7,2,2),(1,8,1,2),(1,9,2,2),(1,10,1,2),(1,11,2,2),(1,12,2,2),(1,13,2,2),(1,14,1,2),(2,16,3,1),(3,6,0.5,1),(3,7,100,2),(3,12,0.5,4),(3,32,1,1),(3,33,2,1),(4,3,7,1),(5,6,1,1),(5,12,2,2),(5,19,600,2),(5,20,1,1),(5,34,1,6),(5,35,250,2),(5,36,250,2),(5,37,0.25,1),(5,38,1,4),(6,12,0.5,4),(6,20,4,1),(6,32,1,1),(6,39,100,2),(6,40,200,2),(6,41,20,2),(6,42,100,2),(6,43,20,2),(7,9,2.5,5),(7,12,1.5,4),(7,34,1,6),(7,44,11,2),(7,45,2.5,6),(7,46,1,5),(8,9,1.5,5),(8,12,0.3,4),(8,19,170,2),(8,20,1,1),(8,21,150,2),(8,24,2,5),(8,26,0.25,6),(8,27,0.3,4),(8,46,0.7,5),(9,1,10,1),(9,2,15,2),(9,3,20,3),(9,4,30,4),(9,5,0.1,5),(9,6,0.2,6),(9,7,0.3,1),(10,1,2.55,2),(10,2,4.55,3),(10,3,3.22,4),(10,4,12,5),(10,5,526,6),(10,6,100,1),(10,7,24,2),(10,8,536,3),(10,9,58,4),(10,10,45,5),(11,1,2,6),(11,2,222,1),(11,3,3,2),(11,4,1,3),(11,5,4,4),(11,6,5,5),(11,7,6,6),(11,8,9,1),(12,1,8,2),(12,2,2.1,3),(12,3,2.3,4),(12,4,3.5,5),(12,5,4.6,6),(12,6,0.55,1),(12,7,0.66,2),(12,8,0.44,3);
/*!40000 ALTER TABLE `dishes_has_products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `drinkingwater`
--

DROP TABLE IF EXISTS `drinkingwater`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `drinkingwater` (
  `id` int NOT NULL AUTO_INCREMENT,
  `createAt` timestamp NOT NULL,
  `users_id` int NOT NULL,
  `typesOfWaterPortion_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_drinkingWater_users1_idx` (`users_id`),
  KEY `fk_drinkingWater_typesOfWaterPortion1_idx` (`typesOfWaterPortion_id`),
  CONSTRAINT `fk_drinkingWater_typesOfWaterPortion1` FOREIGN KEY (`typesOfWaterPortion_id`) REFERENCES `typesofwaterportion` (`id`),
  CONSTRAINT `fk_drinkingWater_users1` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=107 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drinkingwater`
--

LOCK TABLES `drinkingwater` WRITE;
/*!40000 ALTER TABLE `drinkingwater` DISABLE KEYS */;
INSERT INTO `drinkingwater` VALUES (1,'2020-11-19 21:16:30',1,8),(2,'2020-11-19 22:16:30',1,1),(3,'2020-11-21 22:16:30',1,2),(4,'2020-11-19 22:16:30',2,3),(5,'2020-11-23 13:32:26',1,2),(54,'2020-11-30 21:16:30',2,4),(55,'2020-12-01 06:16:30',2,3),(56,'2020-12-01 09:16:30',2,3),(57,'2020-12-01 11:16:30',2,3),(58,'2020-12-01 12:16:30',2,2),(59,'2020-12-01 15:16:30',2,3),(60,'2020-12-01 18:16:30',2,2),(61,'2020-12-01 19:16:30',2,3),(62,'2020-11-30 21:16:30',3,5),(63,'2020-12-01 06:16:30',3,4),(64,'2020-12-01 09:16:30',3,5),(65,'2020-12-01 11:16:30',3,4),(66,'2020-12-01 12:16:30',3,6),(67,'2020-12-01 15:16:30',3,5),(68,'2020-12-01 18:16:30',3,2),(69,'2020-12-01 19:16:30',3,3),(70,'2020-11-30 21:16:30',4,6),(71,'2020-12-01 06:16:30',4,5),(72,'2020-12-01 09:16:30',4,2),(73,'2020-12-01 11:16:30',4,5),(74,'2020-12-01 12:16:30',4,4),(75,'2020-12-01 15:16:30',4,6),(76,'2020-12-01 18:16:30',4,3),(77,'2020-12-01 19:16:30',4,5),(78,'2020-11-30 21:16:30',5,6),(79,'2020-12-01 06:16:30',5,5),(80,'2020-12-01 09:16:30',5,4),(81,'2020-12-01 11:16:30',5,7),(82,'2020-12-01 12:16:30',5,6),(83,'2020-12-01 15:16:30',5,2),(84,'2020-12-01 18:16:30',5,1),(85,'2020-12-01 19:16:30',5,5),(86,'2020-11-30 21:16:30',6,5),(87,'2020-12-01 06:16:30',6,4),(88,'2020-12-01 09:16:30',6,7),(89,'2020-12-01 11:16:30',6,8),(90,'2020-12-01 12:16:30',6,5),(91,'2020-12-01 15:16:30',6,6),(92,'2020-12-01 18:16:30',6,5),(93,'2020-12-01 19:16:30',6,2),(94,'2020-11-30 21:16:30',7,5),(95,'2020-12-01 06:16:30',7,6),(96,'2020-12-01 09:16:30',7,5),(97,'2020-12-01 11:16:30',7,4),(98,'2020-12-01 12:16:30',7,4),(99,'2020-12-01 15:16:30',7,6),(100,'2020-12-01 18:16:30',7,5),(101,'2020-12-01 19:16:30',7,4),(102,'2020-11-23 13:32:26',1,2),(103,'2020-11-23 13:32:26',1,2),(104,'2020-11-23 13:32:26',1,3),(105,'2020-12-24 20:00:00',1,5),(106,'2020-12-24 20:00:00',1,4);
/*!40000 ALTER TABLE `drinkingwater` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `meal`
--

DROP TABLE IF EXISTS `meal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `meal` (
  `id` int NOT NULL AUTO_INCREMENT,
  `createAt` timestamp NOT NULL,
  `user_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_fk_1_idx` (`user_id`),
  KEY `createAt` (`createAt`),
  KEY `createAt_id` (`id`,`createAt`),
  KEY `createAt_userid` (`user_id`,`createAt`),
  CONSTRAINT `user_id_fk1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meal`
--

LOCK TABLES `meal` WRITE;
/*!40000 ALTER TABLE `meal` DISABLE KEYS */;
INSERT INTO `meal` VALUES (2,'2020-11-20 10:40:00',1),(3,'2020-11-20 14:25:08',1),(8,'2020-11-21 16:47:19',1),(10,'2020-11-21 19:18:06',1),(6,'2020-11-21 20:05:44',1),(7,'2020-11-21 20:37:40',1),(26,'2020-12-24 21:22:37',1),(27,'2020-12-24 21:24:30',1),(28,'2020-12-24 21:47:00',1),(29,'2020-12-24 21:49:15',1),(30,'2020-12-24 21:51:52',1),(31,'2020-12-24 22:36:17',1),(32,'2020-12-24 22:42:51',1),(35,'2020-12-25 11:50:55',1),(11,'2020-11-21 19:18:06',2),(12,'2020-11-21 19:18:06',2),(13,'2020-11-22 19:18:06',2),(14,'2020-11-21 19:18:06',3),(15,'2020-11-21 19:18:06',3),(16,'2020-11-21 19:18:06',3),(17,'2020-11-22 19:18:06',3);
/*!40000 ALTER TABLE `meal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `meal_has_dishes`
--

DROP TABLE IF EXISTS `meal_has_dishes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `meal_has_dishes` (
  `meal_id` int NOT NULL,
  `dishes_id` int NOT NULL,
  PRIMARY KEY (`meal_id`,`dishes_id`),
  KEY `dishes_id` (`dishes_id`),
  CONSTRAINT `dishes_id` FOREIGN KEY (`dishes_id`) REFERENCES `dishes` (`id`),
  CONSTRAINT `meal_id` FOREIGN KEY (`meal_id`) REFERENCES `meal` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meal_has_dishes`
--

LOCK TABLES `meal_has_dishes` WRITE;
/*!40000 ALTER TABLE `meal_has_dishes` DISABLE KEYS */;
INSERT INTO `meal_has_dishes` VALUES (29,1),(35,1),(30,17),(31,18),(32,28),(28,56),(26,57);
/*!40000 ALTER TABLE `meal_has_dishes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `meal_has_products`
--

DROP TABLE IF EXISTS `meal_has_products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `meal_has_products` (
  `meal_id` int NOT NULL,
  `products_id` int NOT NULL,
  `quantity` double DEFAULT NULL,
  `measurementtype_id` int NOT NULL,
  PRIMARY KEY (`meal_id`,`products_id`),
  KEY `fk_meal_has_products_products1_idx` (`products_id`),
  KEY `fk_meal_has_products_meal1_idx` (`meal_id`),
  KEY `fk_meal_has_products_measurement type1_idx` (`measurementtype_id`),
  KEY `quantity` (`quantity`),
  KEY `meas_type` (`measurementtype_id`),
  KEY `meas_type_id` (`measurementtype_id`,`meal_id`,`products_id`),
  CONSTRAINT `fk_meal_has_products_meal1` FOREIGN KEY (`meal_id`) REFERENCES `meal` (`id`),
  CONSTRAINT `fk_meal_has_products_measurement type1` FOREIGN KEY (`measurementtype_id`) REFERENCES `measurement type` (`id`),
  CONSTRAINT `fk_meal_has_products_products1` FOREIGN KEY (`products_id`) REFERENCES `products` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meal_has_products`
--

LOCK TABLES `meal_has_products` WRITE;
/*!40000 ALTER TABLE `meal_has_products` DISABLE KEYS */;
INSERT INTO `meal_has_products` VALUES (12,17,3,1),(13,17,5,1),(15,15,2,1),(16,15,3,1),(17,15,3,1),(27,15,2,1);
/*!40000 ALTER TABLE `meal_has_products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mealplans`
--

DROP TABLE IF EXISTS `mealplans`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mealplans` (
  `id` int NOT NULL AUTO_INCREMENT,
  `createAt` timestamp NOT NULL,
  `users_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_mealPlans_users1_idx` (`users_id`),
  KEY `createAt` (`createAt`),
  CONSTRAINT `fk_mealPlans_users1` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=169 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mealplans`
--

LOCK TABLES `mealplans` WRITE;
/*!40000 ALTER TABLE `mealplans` DISABLE KEYS */;
INSERT INTO `mealplans` VALUES (126,'2020-11-24 13:44:42',2),(132,'2020-11-24 13:44:42',3),(136,'2020-11-24 13:44:42',5),(139,'2020-11-24 13:44:42',4),(168,'2020-12-24 22:57:52',1);
/*!40000 ALTER TABLE `mealplans` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mealplans_has_valuesofcharactericstic`
--

DROP TABLE IF EXISTS `mealplans_has_valuesofcharactericstic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mealplans_has_valuesofcharactericstic` (
  `mealPlans_id` int NOT NULL,
  `valuesOfCharactericstic_id` int NOT NULL,
  PRIMARY KEY (`mealPlans_id`,`valuesOfCharactericstic_id`),
  KEY `fk_mealPlans_has_valuesOfCharactericstic_valuesOfCharacteri_idx` (`valuesOfCharactericstic_id`),
  KEY `fk_mealPlans_has_valuesOfCharactericstic_mealPlans1_idx` (`mealPlans_id`),
  CONSTRAINT `fk_mealPlans_has_valuesOfCharactericstic_mealPlans1` FOREIGN KEY (`mealPlans_id`) REFERENCES `mealplans` (`id`),
  CONSTRAINT `fk_mealPlans_has_valuesOfCharactericstic_valuesOfCharacterics1` FOREIGN KEY (`valuesOfCharactericstic_id`) REFERENCES `valuesofcharactericstic` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mealplans_has_valuesofcharactericstic`
--

LOCK TABLES `mealplans_has_valuesofcharactericstic` WRITE;
/*!40000 ALTER TABLE `mealplans_has_valuesofcharactericstic` DISABLE KEYS */;
INSERT INTO `mealplans_has_valuesofcharactericstic` VALUES (168,145),(168,146),(168,147),(168,148);
/*!40000 ALTER TABLE `mealplans_has_valuesofcharactericstic` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `measurement type`
--

DROP TABLE IF EXISTS `measurement type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `measurement type` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `measurement type`
--

LOCK TABLES `measurement type` WRITE;
/*!40000 ALTER TABLE `measurement type` DISABLE KEYS */;
INSERT INTO `measurement type` VALUES (1,'шт'),(2,' г'),(3,'за день'),(4,'ч. л.'),(5,'ст. л.'),(6,'стакан');
/*!40000 ALTER TABLE `measurement type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!50001 DROP VIEW IF EXISTS `menu`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `menu` AS SELECT 
 1 AS `createAt`,
 1 AS `user_id`,
 1 AS `dises_name`,
 1 AS `product_name`,
 1 AS `quantity`,
 1 AS `measurement_type_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `id` int NOT NULL AUTO_INCREMENT,
  `typesOfProduct_id` int DEFAULT NULL,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_products_typesOfProduct1_idx` (`typesOfProduct_id`),
  KEY `name` (`name`),
  CONSTRAINT `fk_products_typesOfProduct1` FOREIGN KEY (`typesOfProduct_id`) REFERENCES `typesofproduct` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3047 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,1,'говядина'),(2,3,'свекла'),(3,3,'картофель '),(4,3,'капуста'),(5,3,'морковь'),(6,3,'лук репчатый'),(7,12,'зелень'),(8,13,'томатная паста'),(9,14,'посолнечное масло '),(10,13,'уксус'),(11,5,'сметана'),(12,11,'соль'),(13,11,'черный перец горошком'),(14,11,'лавровый лист'),(15,4,'яблоки'),(16,10,'яйцо жареное'),(17,4,'бананы'),(19,2,'мука пшеничная'),(20,10,'яйцо сырое'),(21,6,'клубника'),(22,4,'персик'),(23,6,'малина'),(24,5,'сметана'),(25,5,'кефир'),(26,5,'молоко'),(27,11,'сода'),(28,12,'мята'),(29,6,'вишня'),(30,6,'арбуз'),(31,3,'картофель жареный'),(32,3,'огурец'),(33,3,'помидор'),(34,15,'вода'),(35,1,'свиной фарш'),(36,1,'говяжий фарш'),(37,3,'чеснок'),(38,11,'смесь перцев'),(39,3,'кукуруза консервированная'),(40,8,'крабовые палочки'),(41,13,'зеленый лук'),(42,14,'майонез'),(43,13,'укроп'),(44,11,'дрожжи сухие'),(45,2,'мука'),(46,7,'сахар'),(47,NULL,'Oil - Hazelnut'),(48,NULL,'Straws - Cocktale'),(49,NULL,'Cherries - Frozen'),(50,NULL,'Cookies - Englishbay Wht');
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `products_char`
--

DROP TABLE IF EXISTS `products_char`;
/*!50001 DROP VIEW IF EXISTS `products_char`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `products_char` AS SELECT 
 1 AS `product_name`,
 1 AS `char_name`,
 1 AS `value`,
 1 AS `mesurement_type_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `products_has_valuesofcharactericstic`
--

DROP TABLE IF EXISTS `products_has_valuesofcharactericstic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products_has_valuesofcharactericstic` (
  `products_id` int NOT NULL,
  `valuesOfCharactericstic_id` int NOT NULL,
  PRIMARY KEY (`products_id`,`valuesOfCharactericstic_id`),
  KEY `fk_products_has_valuesOfCharactericstic_valuesOfCharacteric_idx` (`valuesOfCharactericstic_id`),
  KEY `fk_products_has_valuesOfCharactericstic_products1_idx` (`products_id`),
  CONSTRAINT `fk_products_has_valuesOfCharactericstic_products1` FOREIGN KEY (`products_id`) REFERENCES `products` (`id`),
  CONSTRAINT `fk_products_has_valuesOfCharactericstic_valuesOfCharactericst1` FOREIGN KEY (`valuesOfCharactericstic_id`) REFERENCES `valuesofcharactericstic` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products_has_valuesofcharactericstic`
--

LOCK TABLES `products_has_valuesofcharactericstic` WRITE;
/*!40000 ALTER TABLE `products_has_valuesofcharactericstic` DISABLE KEYS */;
INSERT INTO `products_has_valuesofcharactericstic` VALUES (1,1),(1,2),(1,3),(1,4),(2,5),(2,6),(2,7),(2,8),(16,13),(15,14),(3,19),(3,20),(3,21),(3,22),(25,24),(25,25),(25,26),(25,27),(26,28),(26,29),(26,30),(26,31),(29,32),(29,33),(29,34),(29,35),(30,36),(30,37),(30,38),(30,39);
/*!40000 ALTER TABLE `products_has_valuesofcharactericstic` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `description` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Пользователь','Роль для пользователя'),(2,'Админ','Роль для админа');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typesofproduct`
--

DROP TABLE IF EXISTS `typesofproduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `typesofproduct` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typesofproduct`
--

LOCK TABLES `typesofproduct` WRITE;
/*!40000 ALTER TABLE `typesofproduct` DISABLE KEYS */;
INSERT INTO `typesofproduct` VALUES (1,'мясо'),(2,'зерновые'),(3,'овощи'),(4,'фрукты'),(5,'молочные'),(6,'ягоды'),(7,'сахар'),(8,'рыба'),(9,'птица'),(10,'яйца'),(11,'специи'),(12,'травы'),(13,'соус'),(14,'масло'),(15,'вода');
/*!40000 ALTER TABLE `typesofproduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typesofwaterportion`
--

DROP TABLE IF EXISTS `typesofwaterportion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `typesofwaterportion` (
  `id` int NOT NULL AUTO_INCREMENT,
  `value` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `value` (`value`),
  KEY `value_id` (`id`,`value`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typesofwaterportion`
--

LOCK TABLES `typesofwaterportion` WRITE;
/*!40000 ALTER TABLE `typesofwaterportion` DISABLE KEYS */;
INSERT INTO `typesofwaterportion` VALUES (1,100),(2,150),(3,200),(5,250),(4,270),(6,300),(7,500),(8,1000);
/*!40000 ALTER TABLE `typesofwaterportion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `password` varchar(25) NOT NULL,
  `gender` tinyint NOT NULL,
  `weight` double NOT NULL,
  `height` double NOT NULL,
  `age` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=1028 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Сергей','new password',1,80,178,25),(2,'Алена','8jfksksg8',0,55,165,22),(3,'Никита','пароль',1,60,170,16),(4,'Елизавета','пароль',0,55,162,17),(5,'Алина','пароль',0,55,160,20),(6,'Test%','test',1,1,1,1),(7,'Владислав','пароль',1,85,185,25),(8,'Kenneth','4FgW21jbZu',1,1,1,1),(9,'Muffin','kCHh6kujdgI',0,2,2,2),(10,'Matthias','qVHXO8Jlkh',1,3,3,3),(11,'Ingram','ELZ5udBJT5BI',1,4,4,4),(12,'Philomena','i6xEnL4vdYTz',1,5,5,5),(13,'Lek','7MJafsLcY',0,6,6,6),(14,'Carolan','9LJ518',0,7,7,7),(15,'Bert','zIOpe1L4HtpR',0,8,8,8),(16,'Tyrus','9Oh14n',0,9,9,9),(17,'Tisha','AnEHJ4oaU',1,10,10,10),(18,'Estrella','AZx0XeNTT',0,11,11,11),(19,'Evvie','90tGsQhVL',1,12,12,12),(20,'Daniella','8n6KBW',0,13,13,13),(21,'Rex','7wXqMz5Drs28',1,14,14,14),(22,'Easter','Ev2couRhl',0,15,15,15),(23,'Dinnie','44jopoM',1,16,16,16),(24,'Vinson','RjloMb9y',0,17,17,17),(25,'Adair','8IRA54yoXr',1,18,18,18),(26,'Moira','sikQDRRL',0,19,19,19),(27,'Jeanine','OvRGzNv55b',0,20,20,20),(28,'Demetri','qlrjpvMhZd1',0,21,21,21),(29,'Garvey','ixBTvQrj',0,22,22,22),(30,'Beatriz','2I725WB',1,23,23,23),(31,'Austin','D68Jy3dd',0,24,24,24),(32,'Elysia','MTEmWZqXg7s',0,25,25,25),(33,'Joli','gUOK3lowCSSG',1,26,26,26),(34,'Charyl','5YLDYiZFx',1,27,27,27),(35,'Kasper','bXg9qudne',1,28,28,28),(36,'Hillery','Yeuetjo6dHb',0,29,29,29),(37,'Cletus','0x6MjHu',0,30,30,30),(38,'Tedi','bOJi08hmxmNN',0,31,31,31),(39,'Meredith','Y6proG5',0,32,32,32),(40,'Clayson','yIVE60',1,33,33,33),(41,'Tilda','I5309lS',0,34,34,34),(42,'Verena','Z2UuHW6',0,35,35,35),(43,'Lynnelle','fYuWAX',0,36,36,36),(44,'Iggie','bderXaPT',0,37,37,37),(45,'Wendall','vsduHzr',1,38,38,38),(46,'Leshia','6imnLGTl',1,39,39,39),(47,'Briggs','1Jd3nd',0,40,40,40),(48,'Nonie','DoE0toWrdPH',0,41,41,41),(49,'Roxanna','B1BF8FnR0',0,42,42,42),(50,'Letisha','e3ji6l8',1,43,43,43),(51,'Carlotta','575Mk4XzPuh',1,44,44,44),(52,'Jacquelyn','fOR3QT3Oc2',0,45,45,45),(53,'Perry','yWtAynAVGqs',1,46,46,46),(54,'Glory','TLF2DMQ0',1,47,47,47),(55,'Wilone','rXTdfspYCWL',0,48,48,48),(56,'Dimitri','LopaVkTd',0,49,49,49),(57,'Benjie','0bMkIQJt1wX',1,50,50,50),(58,'Rutledge','cMrZQAAgGF',1,51,51,51),(59,'Lillian','INfXs5wYa',1,52,52,52),(60,'Carley','gszvNygUa',0,53,53,53),(61,'Cherey','zbtvn61S',1,54,54,54),(62,'Catlaina','OlQXLaSP2T',1,55,55,55),(63,'Tate','8wfbeukMN',1,56,56,56),(64,'Hilly','3gJyWw',1,57,57,57),(65,'Carolus','04IH95S',0,58,58,58),(66,'Perkin','9gFFr0z2',0,59,59,59),(67,'Lorita','NBZHDPsm',1,60,60,60),(68,'Juieta','ZgDjY90eu',0,61,61,61),(69,'Marika','AjdMi1sp5xVJ',1,62,62,62),(70,'Felice','MMc1AUZ',0,63,63,63),(71,'Fanechka','fMPUxXIZ7TQ',0,64,64,64),(72,'Evania','vGbucsvw1',0,65,65,65),(73,'Constantina','q1NV9DufVTP',0,66,66,66),(74,'Skipper','qKw1qnMy',0,67,67,67),(75,'Arman','ULayMz',0,68,68,68),(76,'Kayle','VxoyhO68fBC',1,69,69,69),(77,'Roshelle','HbyWV1XGHRA',0,70,70,70),(78,'Laney','DolecsjlwoXN',0,71,71,71),(79,'Hyman','2EsB68HZMl',1,72,72,72),(80,'Maxine','iQfsaK',0,73,73,73),(81,'Joseph','8mVyGjQ18z',0,74,74,74),(82,'Dinny','G57ulsL9',0,75,75,75),(83,'Odell','q5AyX3IyQrn',0,76,76,76),(84,'Shaughn','Fh46NQMkUYF',0,77,77,77),(85,'Michaelina','UAJtaK2',0,78,78,78),(86,'Rancell','gTApFbQFUq',1,79,79,79),(87,'Carlin','iuVVXnr',0,80,80,80),(88,'Kamila','sR6wxqbAi',0,81,81,81),(89,'Nataniel','31Zdi4M',1,82,82,82),(90,'Ibby','5EhuwoQd8a',0,83,83,83),(91,'Karyn','vTKIdArSL',1,84,84,84),(92,'Theadora','hItJdAd2',1,85,85,85),(93,'Abbie','nRcyM7',0,86,86,86),(94,'Gregoire','H54i6r57F',1,87,87,87),(95,'Myranda','4embzqLybvL',0,88,88,88),(96,'Ree','8Pe5f3afF',0,89,89,89),(97,'Paule','h1iAbOGU5MHO',1,90,90,90),(98,'Lisle','rABVMIE1KxLG',1,91,91,91),(99,'Clevie','DDOVqk',0,92,92,92),(100,'Roderic','5S9Uku4ITYJe',0,93,93,93),(101,'Roobbie','yo67bBTD8oj',1,94,94,94),(102,'Trixi','B7lSVX',1,95,95,95),(103,'Vivienne','PzK19QD7wGe3',0,96,96,96),(104,'Aguistin','ASrqingbS',0,97,97,97),(105,'Sampson','b3EzTo4B',0,98,98,98),(106,'Cora','YzQLmffW7',0,99,99,99),(107,'Lindsey','nvb0uRXiu',1,100,100,100),(108,'Rachelle','5LClabdeb',1,101,101,101),(109,'Jorey','NlOAMAXc',0,102,102,102),(110,'Lewiss','MJ5H7SiArYVI',0,103,103,103),(111,'Dion','qzz5Agn',1,104,104,104),(112,'Cloris','YnjYgeEowmZf',1,105,105,105),(113,'Liza','l8GuRj6cWV7',1,106,106,106),(114,'Alfi','wytGw1VkVE',0,107,107,107),(115,'Libbi','EMUdeFJ',0,108,108,108),(116,'Shandeigh','GjLKwE',0,109,109,109),(117,'Gunilla','Wh45XYYY',1,110,110,110),(118,'Vale','YMOCi4zpkz',1,111,111,111),(119,'Meier','r3c9HxAlci',1,112,112,112),(120,'Natala','Ur8n9Ww',0,113,113,113),(121,'Kirby','iWtsBvdAt',1,114,114,114),(122,'Shea','6o32TOMx',0,115,115,115),(123,'Jeffy','jTObaFs',1,116,116,116),(124,'Maud','0TfxBL1wz4L',0,117,117,117),(125,'Babb','8ztSIhn2',0,118,118,118),(126,'Jerry','AI7l9nveL',1,119,119,119),(127,'Bart','5XbDdeyB',0,120,120,120),(128,'Vinnie','M2JsiwN',0,121,121,121),(129,'Filbert','nO7WxkeFh',0,122,122,122),(130,'Cleve','13PMG2P',0,123,123,123),(131,'Gigi','0tg0ul8AIhWP',1,124,124,124),(132,'Mariette','oaPXiTQGXP7',1,125,125,125),(133,'Clara','feP5JOQ',1,126,126,126),(134,'Kathe','6eKXXKBq',1,127,127,127),(135,'Hagan','ZfJ8AnT',1,128,128,128),(136,'Faustina','UWYVTN',0,129,129,129),(137,'Francklin','ptZPnmHf4',1,130,130,130),(138,'Daren','L3twYTnFW2',0,131,131,131),(139,'Lindsy','pZkPYQJFU7T',1,132,132,132),(140,'Thaddus','ZoweK8x3g',1,133,133,133),(141,'Winnie','JqPA1Cho7',1,134,134,134),(142,'Parry','q7tVhHDTn',1,135,135,135),(143,'Josselyn','vQJi0Byfx',0,136,136,136),(144,'Catlaina','wDBGiDbnGB',0,137,137,137),(145,'Terri','IOJZ33s',0,138,138,138),(146,'Erminia','ClnVCO',0,139,139,139),(147,'Hillery','9fIHhdLm',1,140,140,140),(148,'Mariellen','Wyi5rXYsI',1,141,141,141),(149,'Ursuline','CWEbTEyD0d',1,142,142,142),(150,'Redd','hW9hIcPGvdq',1,143,143,143),(151,'Tadeo','J95L06eXvM85',0,144,144,144),(152,'Angel','NhgRcPCT55Ei',0,145,145,145),(153,'Hana','LvC9HYQRYnc',0,146,146,146),(154,'Conchita','anNZ8WuOmTh',0,147,147,147),(155,'Caren','xCxLUq8lPnb',0,148,148,148),(156,'Olly','paNfTtCPspe',0,149,149,149),(157,'Massimo','hryYnjlk0U',1,150,150,150),(158,'Mavra','W6t5QX2bfQ1',0,151,151,151),(159,'Herby','PFL1Ds8i',1,152,152,152),(160,'Vasily','x47iR2Wfm',0,153,153,153),(161,'Reba','VHsWPSsu1y',0,154,154,154),(162,'Lisa','zDoxMdvi',0,155,155,155),(163,'Remington','1qloHq3Y',1,156,156,156),(164,'Sharlene','ARZwrv',1,157,157,157),(165,'Kalil','mR3DHUdfd8Y',1,158,158,158),(166,'Robin','qqmqsHzO',1,159,159,159),(167,'Iggy','IQlAVy',1,160,160,160),(168,'Rennie','3Zkw5zK',1,161,161,161),(169,'Maximo','PEioYhuYH',0,162,162,162),(170,'Bertrando','hpKVrUb0dq',0,163,163,163),(171,'Luce','wVU6SEl0',1,164,164,164),(172,'Adelle','SQQ6uQ5bKX',0,165,165,165),(173,'Heindrick','nqFxBF',0,166,166,166),(174,'Chen','EupgfZabeue',1,167,167,167),(175,'Cirstoforo','d9swWc2XwBsx',0,168,168,168),(176,'Tabatha','r8IbLEGx',1,169,169,169),(177,'Joye','xezS5nM',1,170,170,170),(178,'Terrance','qGnydEZ6bgHY',0,171,171,171),(179,'Virgie','R7cc4CNYvw',0,172,172,172),(180,'Crosby','oRu1cV',0,173,173,173),(181,'Kellen','9O8umcbr',0,174,174,174),(182,'Alisa','7UDFSn',1,175,175,175),(183,'Harcourt','GOCSQzH40',1,176,176,176),(184,'Carolynn','uXbAfXCX8U',0,177,177,177),(185,'Marchelle','acyuUms4',1,178,178,178),(186,'Arvie','WCyZ7o',1,179,179,179),(187,'Carolan','RuLfTFFdQm7V',1,180,180,180),(188,'Sherlock','nuzxLpBO',1,181,181,181),(189,'Hi','IOLq2Kpmpj',0,182,182,182),(190,'Netta','DLHTH55',0,183,183,183),(191,'Anthia','V4OXwt85xCR',1,184,184,184),(192,'Betty','K7ohyikJSF',1,185,185,185),(193,'Renae','1IFH4GTkQ4j',0,186,186,186),(194,'Laney','P6GvkcXFS',0,187,187,187),(195,'Goldina','Q1odYlT72WB',0,188,188,188),(196,'Normie','Hc4tDZtB2',1,189,189,189),(197,'Asa','CfWutWetB',0,190,190,190),(198,'Charis','A3RiIPxhJ',1,191,191,191),(199,'Lief','wIdbekKp',1,192,192,192),(200,'Amby','ui8aQAXd4x',1,193,193,193),(201,'Boris','rJqwbzRAc',1,194,194,194),(202,'Gavan','XqHjlXZNqx',0,195,195,195),(203,'Tonnie','tfME5AAMidoJ',1,196,196,196),(204,'Mildrid','YX6yjbApRzPo',0,197,197,197),(205,'Wallie','KYMeAcu39M',1,198,198,198),(206,'Yanaton','VrkxgllALdn',0,199,199,199),(207,'Rance','0bt7XqZ7f',0,200,200,200),(208,'Mae','5A3bYtuUTzi',1,201,201,201),(209,'Hynda','biJ6R8TIc6pQ',0,202,202,202),(210,'Maximo','ewtz3XfcZBT5',0,203,203,203),(211,'Hadleigh','mTAjffn3CC',0,204,204,204),(212,'Trudy','DQXjxXUJo0e',1,205,205,205),(213,'Catrina','kx1xfRoyIv3U',0,206,206,206),(214,'Moshe','1rGophN',1,207,207,207),(215,'Rog','oYz7o20tro',0,208,208,208),(216,'Doroteya','BNh98mbnM',0,209,209,209),(217,'Baryram','HnjoXu',0,210,210,210),(218,'Brenna','0yMnTzqjQ',0,211,211,211),(219,'Lorelle','XYC8wU03zFo',1,212,212,212),(220,'Sindee','nqfPVuGc0J0',1,213,213,213),(221,'Ramonda','Nu2rDzq0hAg',0,214,214,214),(222,'Cindi','QwnYE9',0,215,215,215),(223,'George','VBV5DkqWF',1,216,216,216),(224,'Farrah','52vJBoCOe',1,217,217,217),(225,'Dedra','PQByK9W',0,218,218,218),(226,'Angeli','Pxdsf0',0,219,219,219),(227,'Vale','u3SBdC7DK',0,220,220,220),(228,'Brod','jv00eJ4',0,221,221,221),(229,'Kippy','LwzuB4',0,222,222,222),(230,'Jo','k0DQzVrNgOx',1,223,223,223),(231,'Fionna','DBKAkEnr3',0,224,224,224),(232,'Clem','7cTd8lrIWyRP',1,225,225,225),(233,'Jillane','Iw88hoo',1,226,226,226),(234,'Wendi','FSmIHWudyqx',0,227,227,227),(235,'Katrine','opu7vZB2g',0,228,228,228),(236,'Biddie','8KELPccXJR',0,229,229,229),(237,'Robinia','Dbg3ML',1,230,230,230),(238,'Gerhardine','MiwPqHP8aGY',0,231,231,231),(239,'Kristy','glE6Wxy2',1,232,232,232),(240,'Andre','d0Ew2DVLd',1,233,233,233),(241,'Saunder','6cmmaC9',0,234,234,234),(242,'Catharine','bkjlE1R',0,235,235,235),(243,'Blondell','N7658yH2aVlI',0,236,236,236),(244,'Alana','17SUBuly5m',0,237,237,237),(245,'Aeriel','hKj4vTUSe',0,238,238,238),(246,'Francklin','ZWgqhxYP',0,239,239,239),(247,'Christabel','MIpBXo',0,240,240,240),(248,'Neilla','IAtGRmBz',0,241,241,241),(249,'Sandy','5mL3Y0nfp',1,242,242,242),(250,'Avie','hXNA3sF',0,243,243,243),(251,'Lorrin','DKaa01w',0,244,244,244),(252,'Lorne','4eQIJM',1,245,245,245),(253,'Inga','Kl8WGf6Y',0,246,246,246),(254,'Hugh','zn5eOSRdVAY',0,247,247,247),(255,'Basile','xynelct2dorY',1,248,248,248),(256,'Willy','wxf0NHZ3eb',0,249,249,249),(257,'Shannon','C3QdfEVm',1,250,250,250),(258,'Gabi','OmVJMQ',1,251,251,251),(259,'Kaitlin','Z8ScsGtsOxk',1,252,252,252),(260,'Ardyce','eTp7cAgK',1,253,253,253),(261,'Orren','QoOczM4sKyiY',0,254,254,254),(262,'Ramona','mUX2Gi8UaH',1,255,255,255),(263,'Gayla','KmO6EmKX',0,256,256,256),(264,'Keary','1H5JMtGJkj',1,257,257,257),(265,'Leodora','026f3e08Ik',0,258,258,258),(266,'Delainey','8TKn4W',1,259,259,259),(267,'Margo','pWWJc2g',1,260,260,260),(268,'Peadar','mXabtbWpA',0,261,261,261),(269,'Arlette','x4p8HrTriKI',1,262,262,262),(270,'Trevor','G8G86RI',0,263,263,263),(271,'Margette','RQEd8NFnWZUg',0,264,264,264),(272,'Corrie','K8D9DJ',0,265,265,265),(273,'Vinni','ktt4Ko',1,266,266,266),(274,'Arel','fxjyU8dft54',1,267,267,267),(275,'Forster','h5FxizM',0,268,268,268),(276,'Walther','wTWptJYb',0,269,269,269),(277,'Riva','leeGx8ZCLV',0,270,270,270),(278,'Flossy','Fs4PHMi',0,271,271,271),(279,'Kamila','gW8c2P7n',1,272,272,272),(280,'Richmound','8LaBPe',0,273,273,273),(281,'Mahmud','iUCEWCQswNRK',1,274,274,274),(282,'Ardra','YzlRRXp',1,275,275,275),(283,'Case','wAYPlhAoPu21',0,276,276,276),(284,'Austin','YZJFI03zL8h2',1,277,277,277),(285,'Bartholomew','DEaUNgsB',0,278,278,278),(286,'Casie','tV4ERfkkv',1,279,279,279),(287,'Garry','FxWL2Nf66Pk',0,280,280,280),(288,'Tanner','TZBbpZgJRc',0,281,281,281),(289,'Shirline','Rh1A6JqLbvxl',1,282,282,282),(290,'Muffin','QPK3jAvYV',1,283,283,283),(291,'Shurlocke','2oW9TdssT',0,284,284,284),(292,'Benito','ApKBTfc',1,285,285,285),(293,'Malvina','OuToDt7fe',0,286,286,286),(294,'Stevena','BEMGSgAN2VdX',1,287,287,287),(295,'Patin','gaQFJOYJ',1,288,288,288),(296,'Regen','ammRVE',1,289,289,289),(297,'Emmalynne','ZewrXa9MUCm',0,290,290,290),(298,'Danny','lsEeOy',0,291,291,291),(299,'Galina','dVGqqn0ABl',1,292,292,292),(300,'Franky','HltOxpvG0sGR',0,293,293,293),(301,'Thomasin','uuYzr9jcgYK',0,294,294,294),(302,'Harvey','lAsyC1rrP',1,295,295,295),(303,'Jennee','G4tFYlumI',0,296,296,296),(304,'Jecho','4lN8qE1EDqfa',1,297,297,297),(305,'Gearard','KVXveSyS4',1,298,298,298),(306,'Brewster','CZdyqZtT0o',1,299,299,299),(307,'Tymon','Iq1mXMS',0,300,300,300),(308,'Lucienne','MTBtSphBrbvL',1,301,301,301),(309,'Rand','Q4vGwz',0,302,302,302),(310,'Steffi','ZN4KFeu',0,303,303,303),(311,'Gunther','TAbDoBG2t4iQ',0,304,304,304),(312,'Sarajane','U9BjTiADo7',0,305,305,305),(313,'Nata','h9Db2PmX',1,306,306,306),(314,'Clotilda','YQXnm688f8',0,307,307,307),(315,'Ban','3RcIrN',0,308,308,308),(316,'Gillie','zUeVELb',0,309,309,309),(317,'Vachel','VcoWYH',0,310,310,310),(318,'Waring','bOMt7HUK73IH',0,311,311,311),(319,'Fey','W60c2wxLeK7',0,312,312,312),(320,'Jamie','E1oXZsWpLx',0,313,313,313),(321,'Pippo','s1fFO9HBcbh',1,314,314,314),(322,'Shel','vMir8LSl',1,315,315,315),(323,'Ardyce','gjduDvCkFQT',1,316,316,316),(324,'Lory','rvKOAiXpP',1,317,317,317),(325,'Dilly','mbUVtjY',1,318,318,318),(326,'Sam','maJswNKK',0,319,319,319),(327,'Annetta','VhGWhq122SzH',1,320,320,320),(328,'Cherise','mPsEasMuriA',0,321,321,321),(329,'Rickie','xjoNq1NTisNg',0,322,322,322),(330,'Dinah','D6rKbZUrs',1,323,323,323),(331,'Launce','VNcJJhl',0,324,324,324),(332,'Nickolai','cSFSuxdB',1,325,325,325),(333,'Kacey','S72t169PQzn',1,326,326,326),(334,'D\'arcy','SjHETSaqp',0,327,327,327),(335,'Sanford','zzMF25UkN',0,328,328,328),(336,'Mattie','jxazGwkx',0,329,329,329),(337,'Mildrid','dOI0ef34',0,330,330,330),(338,'Guendolen','9Ja5MwRsQbb',1,331,331,331),(339,'Godwin','aevhG3jKl',0,332,332,332),(340,'Collete','CMHLyLjVIr6n',0,333,333,333),(341,'Neilla','qaqjPTu',1,334,334,334),(342,'Mead','J3Fhk8Bo',0,335,335,335),(343,'Tucker','AW7Iz3TCVLI0',0,336,336,336),(344,'Rinaldo','gt1kIZgEjj',0,337,337,337),(345,'Demetris','LUGVdGjzfnp',0,338,338,338),(346,'Jerrilee','CHebrqWx8',1,339,339,339),(347,'Ynes','iDhDzyGxrn',1,340,340,340),(348,'Maxwell','8ehCP6',1,341,341,341),(349,'Brian','xhxQxe64Qm',1,342,342,342),(350,'Rochella','BLp0P2XANHaa',1,343,343,343),(351,'Ced','pFaiVvgeRB8',0,344,344,344),(352,'Perla','HBMFPK5n',1,345,345,345),(353,'Caril','8wvXFmg',0,346,346,346),(354,'Belle','ucGYlVf',1,347,347,347),(355,'Maris','sQLLO6kK5y',0,348,348,348),(356,'Doralynn','WgmPKGWS',1,349,349,349),(357,'Dinnie','P0rpqPP',0,350,350,350),(358,'Robinette','XnsrBN',0,351,351,351),(359,'Gerhard','OWxIU4K',1,352,352,352),(360,'Joscelin','piZNk4HgWJi',0,353,353,353),(361,'Cristie','uNMbHuDqEl',1,354,354,354),(362,'Vernice','bUFw5fin',1,355,355,355),(363,'Ilyse','P8xDVYV',1,356,356,356),(364,'Claudette','h0kBNuTY',0,357,357,357),(365,'Dunstan','fJVoXATf9lA9',0,358,358,358),(366,'Moore','6QfYupkLfq',1,359,359,359),(367,'Isabel','VXJRdO4',0,360,360,360),(368,'Gaye','JvpUAW1bgCtC',0,361,361,361),(369,'Harman','qalxEo35q4',0,362,362,362),(370,'Brittne','Da8POz',1,363,363,363),(371,'Bronnie','c46k0YO',1,364,364,364),(372,'Drake','gVwvBCEwf8T',0,365,365,365),(373,'Dorey','lyZyWTHQh1u',0,366,366,366),(374,'Merlina','EL1HH0GostIJ',1,367,367,367),(375,'Sid','MyszrP',0,368,368,368),(376,'Cristal','Rke2FK',1,369,369,369),(377,'Rice','pEbCaN6uYWD',1,370,370,370),(378,'Tiffie','3vLMiDt',0,371,371,371),(379,'Sam','lbMTQD6BjijL',1,372,372,372),(380,'Marisa','PNBduTHUIHPt',0,373,373,373),(381,'Terza','aguEbOllF',1,374,374,374),(382,'Jilly','cYLfDVaLNhgg',1,375,375,375),(383,'Robinet','07B5B8F',0,376,376,376),(384,'Myrna','wysQTbbDP8uT',0,377,377,377),(385,'Ninetta','Hn3DMfo53d4V',0,378,378,378),(386,'Germayne','bLyPxUwDsg',1,379,379,379),(387,'Lowrance','P7hCdlk8Oi7h',0,380,380,380),(388,'Hadria','N0bbdB6F0q',1,381,381,381),(389,'Klemens','6Jnj3un',1,382,382,382),(390,'Francesca','QGXmWkMwztWk',0,383,383,383),(391,'Greer','EHsNcphZvv',1,384,384,384),(392,'Yovonnda','464TaDlM',0,385,385,385),(393,'Margalit','wFlU9kkzGsu',0,386,386,386),(394,'Jerrilyn','LGARep4Er',1,387,387,387),(395,'Marysa','itNuPS',1,388,388,388),(396,'Matt','4v9BAyJCpRt',1,389,389,389),(397,'Waite','BXabDYtu7',0,390,390,390),(398,'Meredith','Lmjp86T',1,391,391,391),(399,'Edee','MwohRoS',1,392,392,392),(400,'Sibeal','fI3nEOKI6J',1,393,393,393),(401,'Mortimer','woZjFrUX52',1,394,394,394),(402,'Olin','KjmGdzFeclj',0,395,395,395),(403,'Madelina','oqy38YTc5',1,396,396,396),(404,'Brittani','fuD6BGOqyi5s',1,397,397,397),(405,'Jo','TQDIZP3DoOO',0,398,398,398),(406,'Laure','EKxid97oXW',1,399,399,399),(407,'Lucais','XOHgp3S2u3',0,400,400,400),(408,'Corbett','rXIgv3o7J7R',1,401,401,401),(409,'Corly','WFIEblaX5trx',0,402,402,402),(410,'Mitchell','HqRpyDc2r',0,403,403,403),(411,'Eal','fBgEec3uha81',1,404,404,404),(412,'Levi','jxPGEr7C4b7a',1,405,405,405),(413,'Maitilde','pjVRbHM0',1,406,406,406),(414,'Rudy','C3BXOfpaT',0,407,407,407),(415,'Paulita','UiN71uB6',0,408,408,408),(416,'Andrej','sy239m',0,409,409,409),(417,'Kordula','Go75woVzUWz',1,410,410,410),(418,'Gypsy','ZoD7ks',0,411,411,411),(419,'Almeta','soxQQY',1,412,412,412),(420,'Jacinda','s1RN0n',1,413,413,413),(421,'Guendolen','2aW9oZoD',0,414,414,414),(422,'Karissa','UQNC6DVod5l',1,415,415,415),(423,'Renate','DZmfWDA6e5rP',1,416,416,416),(424,'Brooks','N3ESYVWDmGa7',1,417,417,417),(425,'Daren','BBzBBpp',1,418,418,418),(426,'Colette','wyee4rIptrD4',0,419,419,419),(427,'Charita','BwnSAbzA5Z',0,420,420,420),(428,'Woodie','hxrHTQrztAfO',1,421,421,421),(429,'Dulci','FYQsTG6gMF',0,422,422,422),(430,'Bowie','ZrUcE2yuehv2',1,423,423,423),(431,'Di','snvw5N9',0,424,424,424),(432,'Elmo','vxb0xiau',1,425,425,425),(433,'Quintina','sT4iyQA',0,426,426,426),(434,'Skell','2tGUC37',0,427,427,427),(435,'Ebenezer','2UigQH1wDw',0,428,428,428),(436,'Lacey','iG3TELmN7',1,429,429,429),(437,'Kirsti','2pXcnwQ',1,430,430,430),(438,'Antons','ocr5H9mzjEU',0,431,431,431),(439,'Jen','xmo4XWq1',1,432,432,432),(440,'Ardene','usBklu',0,433,433,433),(441,'Waldemar','k8gPC9P4',0,434,434,434),(442,'Torin','8YhrmFVed',0,435,435,435),(443,'Loydie','ndfYbtS',0,436,436,436),(444,'Sianna','3dOT58wJPo',0,437,437,437),(445,'Pris','tHtUTurpH',1,438,438,438),(446,'Gerrie','HRgdftaTv7',1,439,439,439),(447,'Kippie','CcjK77u0PaNx',1,440,440,440),(448,'Mariejeanne','U0K6ddzy',1,441,441,441),(449,'Elwood','1DTqBLhlGsT',0,442,442,442),(450,'Abra','hZrQgsCRAbj1',0,443,443,443),(451,'Gertie','1a9MUUGKzm',1,444,444,444),(452,'Nola','hDovF1a',0,445,445,445),(453,'Bowie','YygV2mp9AKd',1,446,446,446),(454,'Shelba','PqJLfd',0,447,447,447),(455,'Shaina','WdirU5b2Ey',1,448,448,448),(456,'Maxie','tADWH5ubC2',1,449,449,449),(457,'Christiane','r8SHsCaADi',1,450,450,450),(458,'Sofia','XwN3L3znzA',0,451,451,451),(459,'Noland','4PwTpMlUhT8',1,452,452,452),(460,'Chaddie','xrRm0b73Bx',1,453,453,453),(461,'Marieann','KtLQMmgd2ml',1,454,454,454),(462,'Garvin','tTaD52Js',1,455,455,455),(463,'Bobby','NEFSz9NiF',0,456,456,456),(464,'Maynard','TmQxLrU',1,457,457,457),(465,'Beitris','Neiq14L',0,458,458,458),(466,'Fleming','Fgt51co',1,459,459,459),(467,'Tiffie','xXT1sA4SVT',1,460,460,460),(468,'Dudley','uIewVk5X',0,461,461,461),(469,'Audy','bgw3quyV01',1,462,462,462),(470,'Meir','IkQNZ37',0,463,463,463),(471,'Danny','eaxNxmN',1,464,464,464),(472,'Noel','YUibbBG',1,465,465,465),(473,'Ashia','P581MCrp',1,466,466,466),(474,'Devora','UgsRb7XPZ7k',0,467,467,467),(475,'Casie','oQKNSlHUo',0,468,468,468),(476,'Aurel','frdAr6YcH',1,469,469,469),(477,'Fayette','2okKTJmxW7',0,470,470,470),(478,'Colleen','SWmbW03',1,471,471,471),(479,'Ezmeralda','u8Kyvp',0,472,472,472),(480,'Raymond','Nfy9sRiGu',0,473,473,473),(481,'Kelby','IPuqeT',0,474,474,474),(482,'Lutero','hvuGHenb7s',1,475,475,475),(483,'Norton','2k0y5Saf',1,476,476,476),(484,'Cissiee','Vgr43pQykAgh',0,477,477,477),(485,'Dee','5Glu3sWwCK',0,478,478,478),(486,'Adolpho','yf8nLOp6Ec7',1,479,479,479),(487,'Emmy','N2j9zRAy',0,480,480,480),(488,'Farica','aj46zYckl5N',1,481,481,481),(489,'Sharl','13eCYmdMK',1,482,482,482),(490,'Scotti','T85a4uEzB',1,483,483,483),(491,'Carroll','NZCN73z',1,484,484,484),(492,'Linnell','mogzD5fSmvi',1,485,485,485),(493,'Any','Wzfk4dNo6B',1,486,486,486),(494,'Deedee','tKJ11EFGio',1,487,487,487),(495,'Henri','bV6AGnQkpS',0,488,488,488),(496,'Allissa','kGOe2uiHolMK',0,489,489,489),(497,'Skippy','0q2iFbwphv',1,490,490,490),(498,'Marya','XIiCjUeyba',1,491,491,491),(499,'Alvin','xdoRKh',1,492,492,492),(500,'Udale','Szsndsop',1,493,493,493),(501,'Aveline','VO3Vom',0,494,494,494),(502,'Freedman','wTarlhtXBFfJ',1,495,495,495),(503,'Niven','rQ9YPELYC',0,496,496,496),(504,'Ryon','PVwuBp66xtP',0,497,497,497),(505,'Cicily','UHaqwPXh',0,498,498,498),(506,'Sophi','H8d1l2Y',1,499,499,499),(507,'Conant','ouF2gYqV',1,500,500,500),(508,'Thorsten','ITkeAT9QiivZ',0,501,501,501),(509,'Frederic','ywSC3sTBS',1,502,502,502),(510,'Ellis','Gbj7lexi',0,503,503,503),(511,'Cloris','cNOtv0',1,504,504,504),(512,'Patrizia','lgG3Cl6N',0,505,505,505),(513,'Rafaelia','K8kZ3wNea',1,506,506,506),(514,'Trixie','WlgGyE',1,507,507,507),(515,'Linnea','poD7Pn3wIqp',0,508,508,508),(516,'Fawne','E2rpJkZuWl',1,509,509,509),(517,'Liliane','Rw8QDKl4deuX',0,510,510,510),(518,'Yardley','SVX7tkvyNg7S',0,511,511,511),(519,'Riannon','joc01KW',1,512,512,512),(520,'Aindrea','tXvyvyFDcuUW',0,513,513,513),(521,'Val','yqvOwmNz',1,514,514,514),(522,'Alexine','ft4WGgWtV9Az',0,515,515,515),(523,'Joshua','RnMZVDMU',0,516,516,516),(524,'Hyman','dy0mMR11M',1,517,517,517),(525,'Garold','0r3celj',1,518,518,518),(526,'Annabelle','f3r4yLgi0JR',0,519,519,519),(527,'Johnnie','vcoiUGWVxqyy',0,520,520,520),(528,'Shirline','Iy9u8mliG0',1,521,521,521),(529,'Rochella','wVEOip3vC2',1,522,522,522),(530,'Anatol','HEcdiYSR',1,523,523,523),(531,'Willdon','VTWtaNiY0hL',1,524,524,524),(532,'Mae','cEt0y3UOH',0,525,525,525),(533,'Heda','BEUtx2co',0,526,526,526),(534,'Ruthie','hTM6SEK5',0,527,527,527),(535,'Aviva','4mGJY2',0,528,528,528),(536,'Farleigh','T74tTxwsNm2',0,529,529,529),(537,'Etienne','lpzn7DItZ',1,530,530,530),(538,'Reuben','IAdl2Ql',1,531,531,531),(539,'Hobart','QOfQtk',1,532,532,532),(540,'Benedict','o18yvyHy9zL',1,533,533,533),(541,'Danette','ZU1WCDOom',0,534,534,534),(542,'Betta','2qgi2hRq',0,535,535,535),(543,'Jo ann','B3MOGLd',0,536,536,536),(544,'Daniele','MKSR2jC',1,537,537,537),(545,'Burnard','gcSQ0zKejd',0,538,538,538),(546,'Berty','OQ6yFydBG2az',0,539,539,539),(547,'Marice','f2zQnPdLL2t',1,540,540,540),(548,'Jozef','uBRGqwOpq6sp',1,541,541,541),(549,'Clayborne','tq5xdqLRT',1,542,542,542),(550,'Mordecai','CldRle',0,543,543,543),(551,'Shayla','QYs88fY34E',0,544,544,544),(552,'Mollie','HqL8H1l',0,545,545,545),(553,'Ronnie','L6pwfwdt',1,546,546,546),(554,'Tori','GXeQq8',1,547,547,547),(555,'Pattin','NKtm2jhpb',0,548,548,548),(556,'Vickie','HoxvfI',1,549,549,549),(557,'Camala','2VfMUKMi',0,550,550,550),(558,'Drusi','69O566UW',0,551,551,551),(559,'Nataniel','yWBThS',1,552,552,552),(560,'Sydelle','y9fZ3x',1,553,553,553),(561,'Masha','CAbjnwfa',0,554,554,554),(562,'Didi','0JTNsH8l',1,555,555,555),(563,'Allsun','333L7fJnSH',0,556,556,556),(564,'Estell','YdGkD2Y9b',0,557,557,557),(565,'Caz','ug73oNx3',0,558,558,558),(566,'Keely','OuE16Hu0Tur',0,559,559,559),(567,'Fredia','FZzlsV',1,560,560,560),(568,'Gae','jO4tdlYmAGk',1,561,561,561),(569,'Kylie','xzA8VGw2WgR',0,562,562,562),(570,'Shelbi','vgEq6G',1,563,563,563),(571,'Ynez','NsZLyuH9A0',1,564,564,564),(572,'Garrick','kl0QBvyS',1,565,565,565),(573,'Adolpho','d61XYZO4m',0,566,566,566),(574,'Gabriella','LhhjtrSfH8H',0,567,567,567),(575,'Ave','X4x43ZXkuNhq',0,568,568,568),(576,'Amerigo','5U0iZShUNGmX',0,569,569,569),(577,'Riane','EnTpxOjlw',1,570,570,570),(578,'Faustina','cjDhwssMVJEO',1,571,571,571),(579,'Babs','KIFFHPm',0,572,572,572),(580,'Izak','HlUKliZ',1,573,573,573),(581,'Carney','ZO4MKz2auO',1,574,574,574),(582,'Kelsey','lZGHoEhF',0,575,575,575),(583,'Dorita','MOiaRiEkCac',1,576,576,576),(584,'Verne','9NvV4Hi8F',1,577,577,577),(585,'Boothe','QMgaT710W4R',0,578,578,578),(586,'Carny','yGXkrf',1,579,579,579),(587,'Zia','GzCj2R499lHL',0,580,580,580),(588,'Klarika','akhFjFcst',0,581,581,581),(589,'Christy','G583y1ZZupu',0,582,582,582),(590,'Theda','C5xDAw0U7N',1,583,583,583),(591,'Aurelia','E0WZHFfJ',1,584,584,584),(592,'Martainn','04STEvfCFYk6',1,585,585,585),(593,'Salim','VH7lPhnUg',0,586,586,586),(594,'Lynnea','l3BBemGa',1,587,587,587),(595,'Chlo','NnNJQX0vn1z',1,588,588,588),(596,'Mattie','ZgVNqXW5',0,589,589,589),(597,'Aleta','g6dk3VPua',1,590,590,590),(598,'Maybelle','cLL1Zi0o',0,591,591,591),(599,'Kipp','Y8noAnvPJFYv',1,592,592,592),(600,'Dario','UAun0Q9',0,593,593,593),(601,'Lotta','sdjYPfG8Zvmc',1,594,594,594),(602,'Nealy','SqLhCJ',0,595,595,595),(603,'Sherrie','NmXVao4OaVAS',1,596,596,596),(604,'Creigh','XayxnS',0,597,597,597),(605,'Jackson','BUOJj5H',1,598,598,598),(606,'Berrie','rrWcx9ij4QnD',1,599,599,599),(607,'Carver','sJsG1viC3',0,600,600,600),(608,'Siouxie','imL3HY53w',1,601,601,601),(609,'Essa','VeyE6MiF',0,602,602,602),(610,'Veradis','J8IsxU4YonAW',0,603,603,603),(611,'Martita','umSTyyHU',1,604,604,604),(612,'Casie','e69mFO9lLeum',1,605,605,605),(613,'Johnath','3ARTV5Jz',1,606,606,606),(614,'Janina','mAejRoHMWlz',0,607,607,607),(615,'Sharleen','bfYtqShyhDw',0,608,608,608),(616,'Angie','3jw3UWmB0OVV',0,609,609,609),(617,'Clemens','ME69etfsz0H',0,610,610,610),(618,'Brendon','v8DYeld',1,611,611,611),(619,'Bradford','LZ5qF8sB2',1,612,612,612),(620,'Kilian','FwqAAjHCgh4',0,613,613,613),(621,'Dell','V2t6Vy6y',0,614,614,614),(622,'Rasla','8a0kBe',1,615,615,615),(623,'Alexandro','FJeegy9',1,616,616,616),(624,'Frans','BTPWxXCIjC',1,617,617,617),(625,'Neville','QZVGl7',0,618,618,618),(626,'Darrell','58tI3lupn2FI',0,619,619,619),(627,'Myrtie','xgQ70JaAzPPf',1,620,620,620),(628,'Ella','1ve1Fe',1,621,621,621),(629,'Abra','TCPZ7cJfK',0,622,622,622),(630,'Elnore','iRRbSlDFTgIp',0,623,623,623),(631,'Jarvis','FtW2WAeB1',1,624,624,624),(632,'Wadsworth','BL8NwHJ25Wb',0,625,625,625),(633,'Merwin','3vTXttGwe',1,626,626,626),(634,'Misha','YHlKle8',1,627,627,627),(635,'Eustace','VCLDOTGvz',1,628,628,628),(636,'Noellyn','pNs9xLy',0,629,629,629),(637,'Benji','bZ6PvDOu',0,630,630,630),(638,'Quint','VVWaqN0K',0,631,631,631),(639,'Grady','YnS6xD7',1,632,632,632),(640,'Pam','6u4dDGU4a',0,633,633,633),(641,'Marnie','pHOOJr',1,634,634,634),(642,'Nanny','0XqhDpK',1,635,635,635),(643,'Paddie','gRvadv72',0,636,636,636),(644,'Anders','FSqGTyL',1,637,637,637),(645,'Dean','ZO8ZJq',0,638,638,638),(646,'Wilmer','VGaQxc1',1,639,639,639),(647,'Benjy','gxXJ9pjZVeB',0,640,640,640),(648,'Livia','lGLpgRSsyF',1,641,641,641),(649,'Emma','zVyWh5b4Ovlg',0,642,642,642),(650,'Chase','trBoTVlb',0,643,643,643),(651,'Scotti','4mptmq',0,644,644,644),(652,'Rawley','vVEHIdx',0,645,645,645),(653,'Ben','ehkVymyQ0NRQ',0,646,646,646),(654,'Marjy','TUK5kdb8L',0,647,647,647),(655,'Cherilyn','EmU72ffDtgLw',1,648,648,648),(656,'Collete','9kjeduf0',0,649,649,649),(657,'Ileane','GmSvvumOoe',1,650,650,650),(658,'Zach','bW3NGx',1,651,651,651),(659,'Zahara','nS3jbzXtnAP',0,652,652,652),(660,'Ermanno','GlgXaDB',0,653,653,653),(661,'Bernardine','wnHvlM9B5v',0,654,654,654),(662,'Ki','5ctqUX2',1,655,655,655),(663,'Coretta','mHfvmUkiF',1,656,656,656),(664,'Sandro','jNHLIU8',0,657,657,657),(665,'Leandra','HRjX1G',0,658,658,658),(666,'Estell','52fskc2iVwl',1,659,659,659),(667,'Jenilee','qtTIYU',0,660,660,660),(668,'Wendie','BOZro0V2TsX',0,661,661,661),(669,'Kelsey','rCHmK7',0,662,662,662),(670,'Myrna','6DpyonI59',1,663,663,663),(671,'Merla','wDWeju',0,664,664,664),(672,'Roland','jmiCmgIwcc',1,665,665,665),(673,'Rivalee','UymdiefluyfN',0,666,666,666),(674,'Ariella','2FJZ0k',0,667,667,667),(675,'Ario','y2sKNF',1,668,668,668),(676,'Yurik','2CAEz5QDg7ue',1,669,669,669),(677,'Clayson','ogJPADHhp',0,670,670,670),(678,'Bancroft','q6eTd7CeONjf',0,671,671,671),(679,'Elayne','gezWdyI',1,672,672,672),(680,'Nessi','1BdIj06h0vdn',0,673,673,673),(681,'Pearla','pjQ9ef2oqdH',1,674,674,674),(682,'Judd','wvgHQzt6',0,675,675,675),(683,'Arnie','G9K7zaP',1,676,676,676),(684,'Darcey','RnvOR56BgA7e',0,677,677,677),(685,'Shayne','kdgO2fb',0,678,678,678),(686,'Baily','53yoS3QjAed',0,679,679,679),(687,'Elmer','ltFersOexU',0,680,680,680),(688,'Nola','8kdleEE113',0,681,681,681),(689,'Arlinda','18tp4cMknha',1,682,682,682),(690,'Jade','dTvj6G',0,683,683,683),(691,'Cherye','eLv2nWT9S',1,684,684,684),(692,'Uta','xaamNo',1,685,685,685),(693,'Stuart','zJGDQn',1,686,686,686),(694,'Torry','44bqNb',1,687,687,687),(695,'Marna','oMovmQeH3rp7',1,688,688,688),(696,'Harland','gnTiPDbNuD',1,689,689,689),(697,'Sharline','rjmWthB',0,690,690,690),(698,'Kelsey','YNy4Qd',1,691,691,691),(699,'Reginauld','W0tfoZN',0,692,692,692),(700,'Anallese','T8A5UWiBnMt',1,693,693,693),(701,'Inglis','yuzFGAs9',0,694,694,694),(702,'Yolanda','Zjs49IWNrbv',1,695,695,695),(703,'Jannelle','wUTwgx',0,696,696,696),(704,'Gayler','sA7FUn',1,697,697,697),(705,'Kirstyn','SlYDLB5uQ',0,698,698,698),(706,'Kiri','vuSS1uwCYy',0,699,699,699),(707,'Harriett','6wRxJvL63',0,700,700,700),(708,'Lurlene','OhNKE6gcJGg',0,701,701,701),(709,'Christie','a5JbY3WvT0r',0,702,702,702),(710,'Danette','ifl4WLh',1,703,703,703),(711,'Lindsay','JeYRdl',0,704,704,704),(712,'Lurlene','ksIlUal',0,705,705,705),(713,'Keslie','Zbvk5EGcOcW',0,706,706,706),(714,'Vilma','DQPo47rEB',0,707,707,707),(715,'Hanny','NTx1ufFNPe9A',0,708,708,708),(716,'Nert','5DuniO',1,709,709,709),(717,'Justus','TUoUSVx2hXFA',0,710,710,710),(718,'Miran','FXRTypL98sR',1,711,711,711),(719,'Artemus','P03llEZP',0,712,712,712),(720,'Brandais','afSgqN',0,713,713,713),(721,'Nikos','iFZqrXf',0,714,714,714),(722,'Marlane','M2keSy6',1,715,715,715),(723,'Lona','W3uhyOmJ',0,716,716,716),(724,'Dan','4ZucydmOz',1,717,717,717),(725,'Ulysses','gEteMbJS',0,718,718,718),(726,'Jannelle','xqMzBvSx5',1,719,719,719),(727,'Pinchas','YDDakkDzyr',1,720,720,720),(728,'Lilli','Zz2PFG',0,721,721,721),(729,'Flin','RlYAixCpXN',1,722,722,722),(730,'Matthaeus','L2pEhq2c',1,723,723,723),(731,'Talbert','wYys5oWfchw',1,724,724,724),(732,'Cathlene','aIKh6d',1,725,725,725),(733,'Monica','ww9JUFl',0,726,726,726),(734,'Deeann','IC8Nj2Was',0,727,727,727),(735,'Rhodia','ruvFUtWH',0,728,728,728),(736,'Noelle','FXq09cVP',1,729,729,729),(737,'Northrup','vxkenYKuqBfJ',0,730,730,730),(738,'Granthem','vnPoufd',1,731,731,731),(739,'Briant','6usNGhw',0,732,732,732),(740,'Leopold','MIa8OUkpi',1,733,733,733),(741,'Shurlock','tDN9OwP5eV7',0,734,734,734),(742,'Carlita','Gvzl6V9zMUhQ',0,735,735,735),(743,'Francklyn','Nl6bVmXWTF',0,736,736,736),(744,'Falkner','DD9Ljk',0,737,737,737),(745,'Ki','Dc0dkJ53YN2',1,738,738,738),(746,'Aldis','ssKHqYlrC6Un',1,739,739,739),(747,'Agata','cF8im3s',1,740,740,740),(748,'Tessi','YpEl2e',0,741,741,741),(749,'Hadlee','OAnJ54RJ9sk',1,742,742,742),(750,'Emelia','MxkwIBG',1,743,743,743),(751,'Brittney','DuH2j1',1,744,744,744),(752,'Ferdinanda','VsIIlnZO0',1,745,745,745),(753,'Caresa','VIUFwbf',1,746,746,746),(754,'Davide','Ov5FRPpMgj',0,747,747,747),(755,'Anett','YgzoopdJJZP',0,748,748,748),(756,'Kerrie','MFrhUjjPRqbg',1,749,749,749),(757,'Kerrin','0lMdzTsplwx',0,750,750,750),(758,'My','LnrrM4WUZ',0,751,751,751),(759,'Isahella','nWRMER7Dyg',1,752,752,752),(760,'Stephana','sUKYprJ',0,753,753,753),(761,'Melly','x7Dbm2l',0,754,754,754),(762,'Saundra','64MvdDgloH',1,755,755,755),(763,'Mandie','LPjC2tv4pMC',1,756,756,756),(764,'Yolanda','BYoEHa',1,757,757,757),(765,'Englebert','uucLNEUU',0,758,758,758),(766,'Anthony','cd7k2Q8ItSqP',1,759,759,759),(767,'Elayne','dcOHQhy6aktY',1,760,760,760),(768,'Lyle','WN7uuMI5d',0,761,761,761),(769,'Meggy','JFRunF7gKcU',1,762,762,762),(770,'Abelard','ac1MwtpXd',0,763,763,763),(771,'Cara','Dq5fxK',0,764,764,764),(772,'Ced','iGXE7klhIvv',0,765,765,765),(773,'Ed','i4byAMzf',0,766,766,766),(774,'Baudoin','UmVEisuzY',0,767,767,767),(775,'Amanda','PfCOKP11hKRJ',0,768,768,768),(776,'Steve','ips06O2',0,769,769,769),(777,'Christophorus','WA2f7B2ARV',0,770,770,770),(778,'Diandra','X5Tz1eZREzQk',1,771,771,771),(779,'Phillipp','NHrtmc',1,772,772,772),(780,'Fleming','dsBhTsEws',0,773,773,773),(781,'Dorrie','TCZVG6',0,774,774,774),(782,'Roland','gt8FnsHgaa6m',0,775,775,775),(783,'Nicolai','u6qjeuIbT',0,776,776,776),(784,'Sharlene','xtORgTkl9V',1,777,777,777),(785,'Worthington','i0CGASlWt',0,778,778,778),(786,'Wash','0dca1mIP',0,779,779,779),(787,'Karilynn','kI5weIl',1,780,780,780),(788,'Broderick','inpLk6',1,781,781,781),(789,'Adey','aMPnKF5R',0,782,782,782),(790,'Vale','ZdQRgsAC',1,783,783,783),(791,'Elva','CrnfRN1ic',1,784,784,784),(792,'Shanie','FLjhcRRFD3',0,785,785,785),(793,'Jessee','Nn79ZgQ',0,786,786,786),(794,'Joel','Sge1m4',1,787,787,787),(795,'Kara-lynn','qRHwBQl',1,788,788,788),(796,'Kearney','9RBo7a',1,789,789,789),(797,'Cal','Bv24MATCG',0,790,790,790),(798,'Josselyn','TTFCw9TMS9C',0,791,791,791),(799,'Ellynn','DCjGTGcC',1,792,792,792),(800,'Julie','KDzxYKoo4h4',1,793,793,793),(801,'Gayler','H53Zg6mT1H',0,794,794,794),(802,'Jacobo','ZMSZHJt',0,795,795,795),(803,'Drucill','dV38mtLcq',0,796,796,796),(804,'Wenonah','t63ZNOQjUE',0,797,797,797),(805,'Reagan','msSzEfcC',0,798,798,798),(806,'Susanna','cnNj2Ga',1,799,799,799),(807,'Rosy','gQPlWjw7LkO',1,800,800,800),(808,'Maryrose','7vBocFyTMSh',0,801,801,801),(809,'Emmy','ebkUeBBVrWi',1,802,802,802),(810,'Elaina','jmDn1rtTO',1,803,803,803),(811,'Trudie','RVKsCH3',1,804,804,804),(812,'Fallon','ie634q',1,805,805,805),(813,'Stafani','Cz0Enhm4dYzm',0,806,806,806),(814,'Caressa','oK47KNTGyCc4',0,807,807,807),(815,'Cris','oO16On',0,808,808,808),(816,'Langsdon','LsCSxD5',0,809,809,809),(817,'Jecho','RBTOhzH',1,810,810,810),(818,'Gunilla','cwIY8Wl',1,811,811,811),(819,'Baldwin','ix3nlc',1,812,812,812),(820,'Anselm','EAblRNEqW01',0,813,813,813),(821,'Alvin','3JQbEkou',1,814,814,814),(822,'Maurise','07GWj5t6E',0,815,815,815),(823,'Craig','SOF03uq',1,816,816,816),(824,'Mathew','W3CcJgmdQH',0,817,817,817),(825,'Virgil','NnrtrQ3mUjR',1,818,818,818),(826,'Kathryn','lNAB3al',1,819,819,819),(827,'Mendie','tRrU2vaZ',0,820,820,820),(828,'Raimund','qBhWRKEnrvs',0,821,821,821),(829,'Jessamine','QdRkyhGKMI',0,822,822,822),(830,'Revkah','L5JWKq',1,823,823,823),(831,'Geoff','vCdyADl',1,824,824,824),(832,'Lucille','FKGeeZKn',0,825,825,825),(833,'Mel','q92sYEnG2Hi',0,826,826,826),(834,'Noe','hXZRQyk',0,827,827,827),(835,'Kirbee','sTW1uzcad8',0,828,828,828),(836,'Barth','GAvlCp8P',0,829,829,829),(837,'Patti','JRWsyyz7cUV',1,830,830,830),(838,'Parsifal','PLxRiY43F3y',1,831,831,831),(839,'Thornton','jPy2F3opsT',0,832,832,832),(840,'Wallace','4rTxGr31Dec',0,833,833,833),(841,'Skip','yIFWOtj5',0,834,834,834),(842,'Fritz','QK9qq7',0,835,835,835),(843,'Winonah','jjr1qhpt20A',1,836,836,836),(844,'Marsha','TSLUUb3l4Zz9',0,837,837,837),(845,'Lucy','iPpiPcKsTQ6w',1,838,838,838),(846,'Beniamino','u2rwCU',0,839,839,839),(847,'Pete','bDaJlgKJ2i6',0,840,840,840),(848,'Regen','NjpCTZSJ',0,841,841,841),(849,'Horace','ypjPn1a0I',1,842,842,842),(850,'Jules','AAchxTiz',0,843,843,843),(851,'Codie','0rmkPpa',0,844,844,844),(852,'Helen','GwGm5VcLr',1,845,845,845),(853,'Ernest','ciuDiJs',0,846,846,846),(854,'Tiebout','mHmyFi',0,847,847,847),(855,'Vonny','Y2xXDc7viBMC',1,848,848,848),(856,'Jerrylee','E2cCnfYn',1,849,849,849),(857,'Melvyn','NGqLxlqLwrj6',1,850,850,850),(858,'Alvy','IZGHzZSgEBZ',0,851,851,851),(859,'Conrad','TWY7JnwotVt',1,852,852,852),(860,'Gilberto','ZheUS1',0,853,853,853),(861,'Rudy','9q7D7oZu',0,854,854,854),(862,'Del','0H9oaV',0,855,855,855),(863,'Smith','B9yZZoXdn09',1,856,856,856),(864,'Alasdair','mUHMqnZilb4',1,857,857,857),(865,'Siegfried','nj2DlE2',1,858,858,858),(866,'Kile','COJGF2bc5Rz',0,859,859,859),(867,'Kerri','1mq74mvBI6O',0,860,860,860),(868,'Melinda','OMQrRWwO',0,861,861,861),(869,'Charleen','sGr5cd',0,862,862,862),(870,'Fulvia','b0ofoSIZHO4',1,863,863,863),(871,'Caspar','cEwrIYDfAs',1,864,864,864),(872,'Iorgos','07oJDReFn',1,865,865,865),(873,'Blaire','TZXx59',1,866,866,866),(874,'Kayley','J5WnJbJ4XRcg',1,867,867,867),(875,'Elmer','G1bLSXa',0,868,868,868),(876,'Nicoline','517fmTPkY',0,869,869,869),(877,'Ivie','xp3dSk65T',1,870,870,870),(878,'Bordie','KrBwa9boFQU8',0,871,871,871),(879,'Nels','N5QfLv8KH8',1,872,872,872),(880,'Calida','WIAzHeUfcUb',1,873,873,873),(881,'Berenice','zuKCiiE',1,874,874,874),(882,'Guntar','TLQIeznszD',0,875,875,875),(883,'Josephine','Mxd5rSYS',1,876,876,876),(884,'Carola','yDJbuPAe0gXR',0,877,877,877),(885,'Taryn','KdlKi7',0,878,878,878),(886,'Carilyn','epTmLRSmVPtD',1,879,879,879),(887,'Ransom','csQ41LqGGZgq',0,880,880,880),(888,'Dwayne','e3dbzCJftG8E',1,881,881,881),(889,'Sileas','kWtjdCjD5n',1,882,882,882),(890,'Keven','FHiolBX7qN',1,883,883,883),(891,'Alika','mMRbTSH85W',0,884,884,884),(892,'Eleanore','V2JT6NZ',0,885,885,885),(893,'Jewelle','Y1m8FQ6Xwa7U',1,886,886,886),(894,'Felizio','9hm7sh7RuS',0,887,887,887),(895,'Cam','Z6XUNlzcTm',1,888,888,888),(896,'Rodger','Hx4kLu',0,889,889,889),(897,'Adamo','Q5hIYnGC',1,890,890,890),(898,'Roseann','iXEprTFv4up6',0,891,891,891),(899,'Audrie','gX3uR6aiZh',1,892,892,892),(900,'Ludvig','lR7njpICE8',1,893,893,893),(901,'Jacklyn','PR5eFl',0,894,894,894),(902,'Lon','Jqyh9mpaPbhZ',0,895,895,895),(903,'Porter','kgjNtXXe',1,896,896,896),(904,'Shandra','jT70YOd7bn8P',0,897,897,897),(905,'Aura','MXclBB59',0,898,898,898),(906,'Kathlin','uioYy3vB49JA',1,899,899,899),(907,'Hallie','afWrSxYL',1,900,900,900),(908,'Leilah','o1U5mhitm2',1,901,901,901),(909,'Lynn','dXKwQS',0,902,902,902),(910,'Lezlie','Nx0u3lNArz',0,903,903,903),(911,'Simeon','V4twgg',1,904,904,904),(912,'Gonzales','BlXkH0OpT',1,905,905,905),(913,'Peria','Mv5GBsi',0,906,906,906),(914,'Jocelyne','ov1ZID',0,907,907,907),(915,'Hedi','oAOYQp',0,908,908,908),(916,'Manda','Tl1YLvky',0,909,909,909),(917,'Aldridge','EWnmhwO',1,910,910,910),(918,'Xever','UirAPRcX46QG',1,911,911,911),(919,'Katheryn','cYS7wL',0,912,912,912),(920,'Felice','mnj3jSOp2m',1,913,913,913),(921,'Lyndell','HJbgFX4avCxd',0,914,914,914),(922,'Karen','8IRYcSekf',0,915,915,915),(923,'Gaby','vBI5C3Ya',0,916,916,916),(924,'Darren','9bqFYGbl75VX',1,917,917,917),(925,'Hanny','lJij2gI',0,918,918,918),(926,'Addie','gpoVY07',1,919,919,919),(927,'Skyler','VkK1MTheuUN',0,920,920,920),(928,'Cleo','Bh3gZFF7u0l',0,921,921,921),(929,'Mariel','VyiCHHtYY4D',1,922,922,922),(930,'Penelope','fBHxDW',1,923,923,923),(931,'Amii','svCQawEOA',0,924,924,924),(932,'Beverie','oUAJCTPkEfh2',1,925,925,925),(1001,'Reggie','QnHz9rUvcL',1,994,994,994),(1002,'Karrah','IEXeR4LSBXm',0,995,995,995),(1003,'Ingaborg','ie8i1dU9b',1,996,996,996),(1004,'Neil','LZaSRq1E',1,997,997,997),(1005,'Kaycee','qgLqOt',0,998,998,998),(1006,'Rabi','9UMsVO6Pozw',0,999,999,999),(1007,'Osgood','fEP82IH',0,1000,1000,1000),(1008,'дек','дек',30,70,180,NULL),(1023,'dfdfd','dfdfdf',0,424,42,42),(1024,'цуа','цуа',3,8,8,8),(1025,'Сергей','как',11,11,1,NULL),(1026,'Сергей','епе',1,1,1,NULL),(1027,'АААА','ап',1,1,1,NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users_has_roles`
--

DROP TABLE IF EXISTS `users_has_roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users_has_roles` (
  `users_id` int NOT NULL,
  `roles_id` int NOT NULL,
  PRIMARY KEY (`users_id`,`roles_id`),
  KEY `fk_users_has_roles_roles1_idx` (`roles_id`),
  KEY `fk_users_has_roles_users1_idx` (`users_id`),
  CONSTRAINT `fk_users_has_roles_roles1` FOREIGN KEY (`roles_id`) REFERENCES `roles` (`id`),
  CONSTRAINT `fk_users_has_roles_users1` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_has_roles`
--

LOCK TABLES `users_has_roles` WRITE;
/*!40000 ALTER TABLE `users_has_roles` DISABLE KEYS */;
INSERT INTO `users_has_roles` VALUES (1,1),(2,1),(5,1),(6,1),(7,1),(3,2),(4,2);
/*!40000 ALTER TABLE `users_has_roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `valuesofcharactericstic`
--

DROP TABLE IF EXISTS `valuesofcharactericstic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `valuesofcharactericstic` (
  `id` int NOT NULL AUTO_INCREMENT,
  `value` double NOT NULL,
  `characteristics_id` int NOT NULL,
  `measurement_type_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_valuesOfCharactericstic_characteristics1_idx` (`characteristics_id`),
  KEY `fk_meas_type_idx` (`measurement_type_id`),
  KEY `id` (`id`),
  KEY `value` (`value`),
  CONSTRAINT `fk_measurement_type` FOREIGN KEY (`measurement_type_id`) REFERENCES `measurement type` (`id`),
  CONSTRAINT `fk_valuesOfCharactericstic_characteristics1` FOREIGN KEY (`characteristics_id`) REFERENCES `characteristics` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=149 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `valuesofcharactericstic`
--

LOCK TABLES `valuesofcharactericstic` WRITE;
/*!40000 ALTER TABLE `valuesofcharactericstic` DISABLE KEYS */;
INSERT INTO `valuesofcharactericstic` VALUES (1,18,1,2),(2,12.4,2,2),(3,0,3,2),(4,187,4,2),(5,1.8,1,2),(6,0,2,2),(7,10.8,3,2),(8,49,4,1),(13,125,4,2),(14,52,4,1),(15,1500,4,3),(16,100,1,3),(17,200,2,3),(18,2000,4,3),(19,2.8,1,2),(20,9.5,2,2),(21,23.4,3,2),(22,192,4,2),(23,200,1,3),(24,2.9,1,2),(25,3.2,2,2),(26,4,3,2),(27,59,4,2),(28,2.8,1,2),(29,2.5,2,2),(30,4.7,3,2),(31,52,4,2),(32,0.8,1,2),(33,0.5,2,2),(34,11.3,3,2),(35,52,4,2),(36,0.6,1,2),(37,0.1,2,2),(38,5.8,3,2),(39,25,4,2),(140,2100,4,2),(141,800,1,3),(142,300,2,3),(143,500,3,3),(144,2400,4,3),(145,900,1,3),(146,400,2,3),(147,600,3,3),(148,2500,4,3);
/*!40000 ALTER TABLE `valuesofcharactericstic` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `menu`
--

/*!50001 DROP VIEW IF EXISTS `menu`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `menu` AS select `meal`.`createAt` AS `createAt`,`meal`.`user_id` AS `user_id`,`dishes`.`name` AS `dises_name`,`products`.`name` AS `product_name`,`dishes_has_products`.`quantity` AS `quantity`,`measurement type`.`name` AS `measurement_type_name` from (((((`products` join `dishes_has_products` on((`dishes_has_products`.`products_id` = `products`.`id`))) join `dishes` on((`dishes_has_products`.`dishes_id` = `dishes`.`id`))) join `measurement type` on((`dishes_has_products`.`measurementtype_id` = `measurement type`.`id`))) join `meal_has_dishes` on((`meal_has_dishes`.`dishes_id` = `dishes`.`id`))) join `meal` on((`meal_has_dishes`.`meal_id` = `meal`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `products_char`
--

/*!50001 DROP VIEW IF EXISTS `products_char`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `products_char` AS select `products`.`name` AS `product_name`,`characteristics`.`name` AS `char_name`,`valuesofcharactericstic`.`value` AS `value`,`measurement type`.`name` AS `mesurement_type_name` from ((((`valuesofcharactericstic` join `products_has_valuesofcharactericstic` on((`valuesofcharactericstic`.`id` = `products_has_valuesofcharactericstic`.`valuesOfCharactericstic_id`))) join `products` on((`products`.`id` = `products_has_valuesofcharactericstic`.`products_id`))) join `characteristics` on((`valuesofcharactericstic`.`characteristics_id` = `characteristics`.`id`))) join `measurement type` on((`measurement type`.`id` = `valuesofcharactericstic`.`measurement_type_id`))) */;
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

-- Dump completed on 2020-12-25 16:02:42
