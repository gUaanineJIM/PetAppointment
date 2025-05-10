-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: vet_record
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accounts` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `sec_question` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES (1,'Janine Ishe Moral','janine','janine','ceasar'),(2,'Gabriel Angel','gab','asds','machi'),(3,'axel','axel','123','axel'),(5,'Jose Gabriela','jann','jann','bella'),(7,'Axel Lilo','axelia','1234','bella');
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointment_logs`
--

DROP TABLE IF EXISTS `appointment_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointment_logs` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `appointment_id` int DEFAULT NULL,
  `pet_id` int DEFAULT NULL,
  `vet_id` int DEFAULT NULL,
  `action` varchar(50) DEFAULT NULL,
  `action_time` datetime DEFAULT NULL,
  PRIMARY KEY (`log_id`),
  KEY `vet_id` (`vet_id`),
  KEY `appointment_logs_ibfk_1` (`appointment_id`),
  CONSTRAINT `appointment_logs_ibfk_1` FOREIGN KEY (`appointment_id`) REFERENCES `appointments` (`appointment_id`) ON DELETE CASCADE,
  CONSTRAINT `appointment_logs_ibfk_2` FOREIGN KEY (`vet_id`) REFERENCES `vet_doctor` (`vet_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=75 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointment_logs`
--

LOCK TABLES `appointment_logs` WRITE;
/*!40000 ALTER TABLE `appointment_logs` DISABLE KEYS */;
INSERT INTO `appointment_logs` VALUES (12,41,20,101,'INSERT','2025-03-16 22:05:57'),(13,37,21,202,'UPDATE','2025-03-16 22:12:26'),(17,41,20,101,'DELETE','2025-03-16 22:30:37'),(18,42,20,101,'INSERT','2025-03-16 22:40:15'),(19,43,15,406,'INSERT','2025-03-17 00:04:34'),(20,44,17,403,'INSERT','2025-03-17 00:15:02'),(21,44,17,403,'UPDATE','2025-03-17 00:28:17'),(22,44,17,403,'DELETE','2025-03-17 00:43:24'),(23,45,3,202,'INSERT','2025-03-17 00:55:39'),(24,45,3,202,'UPDATE','2025-03-17 01:02:20'),(25,45,3,202,'DELETE','2025-03-17 01:14:49'),(26,43,15,406,'UPDATE','2025-03-17 02:29:39'),(27,38,2,202,'INSERT','2025-04-01 17:36:39'),(28,39,3,303,'INSERT','2025-04-01 17:36:39'),(29,40,4,404,'INSERT','2025-04-01 17:36:39'),(30,41,5,101,'INSERT','2025-04-01 17:36:39'),(31,46,3,101,'INSERT','2025-04-01 18:01:34'),(32,47,13,404,'INSERT','2025-04-01 20:00:16'),(33,48,21,407,'INSERT','2025-04-01 20:00:16'),(34,49,14,101,'INSERT','2025-04-01 21:30:45'),(35,46,3,101,'UPDATE','2025-04-01 21:58:37'),(36,46,3,101,'UPDATE','2025-04-01 22:02:08'),(37,38,2,202,'UPDATE','2025-04-01 22:03:49'),(38,38,2,202,'UPDATE','2025-04-01 22:03:56'),(39,38,2,202,'UPDATE','2025-04-01 22:04:10'),(40,46,3,101,'UPDATE','2025-04-01 22:04:10'),(44,50,1,101,'INSERT','2025-05-04 22:30:36'),(45,51,25,202,'INSERT','2025-05-04 22:41:17'),(46,52,22,101,'INSERT','2025-05-04 22:45:06'),(47,51,25,202,'UPDATE','2025-05-04 23:21:10'),(48,52,22,101,'UPDATE','2025-05-04 23:21:26'),(49,53,8,404,'INSERT','2025-05-04 23:32:57'),(50,53,8,404,'UPDATE','2025-05-04 23:33:08'),(54,53,8,404,'DELETE','2025-05-04 23:40:26'),(55,54,1,303,'INSERT','2025-05-04 23:44:46'),(56,55,2,303,'INSERT','2025-05-04 23:47:11'),(57,55,2,303,'UPDATE','2025-05-04 23:47:17'),(58,55,2,303,'UPDATE','2025-05-04 23:47:25'),(59,55,2,303,'DELETE','2025-05-04 23:47:30'),(60,54,1,303,'UPDATE','2025-05-06 21:42:16'),(61,56,1,101,'INSERT','2025-05-06 21:46:00'),(62,56,1,101,'DELETE','2025-05-06 21:47:02'),(63,57,1,101,'INSERT','2025-05-06 21:47:50'),(64,57,1,101,'UPDATE','2025-05-06 21:47:53'),(65,57,1,101,'UPDATE','2025-05-06 21:47:59'),(66,57,1,101,'UPDATE','2025-05-06 22:22:17'),(67,54,1,303,'UPDATE','2025-05-07 11:16:18'),(68,58,10,202,'INSERT','2025-05-07 22:36:41'),(69,59,10,202,'INSERT','2025-05-07 22:37:21'),(70,58,14,202,'UPDATE','2025-05-07 22:37:46'),(71,57,1,101,'UPDATE','2025-05-07 22:38:01'),(72,59,10,202,'UPDATE','2025-05-08 22:06:11'),(73,60,28,407,'INSERT','2025-05-09 23:18:07'),(74,60,28,407,'UPDATE','2025-05-09 23:20:47');
/*!40000 ALTER TABLE `appointment_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointments`
--

DROP TABLE IF EXISTS `appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointments` (
  `appointment_id` int NOT NULL AUTO_INCREMENT,
  `pet_id` int DEFAULT NULL,
  `vet_id` int DEFAULT NULL,
  `appointment_date` date NOT NULL,
  `reason` longtext NOT NULL,
  `staff_id` int DEFAULT NULL,
  `appointment_time` varchar(45) NOT NULL,
  PRIMARY KEY (`appointment_id`),
  KEY `pet_id_idx` (`pet_id`),
  KEY `vet_id_idx` (`vet_id`),
  KEY `staff_id_idx` (`staff_id`),
  CONSTRAINT `pet_id` FOREIGN KEY (`pet_id`) REFERENCES `pets` (`pet_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `staff_id` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `vet_id` FOREIGN KEY (`vet_id`) REFERENCES `vet_doctor` (`vet_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointments`
--

LOCK TABLES `appointments` WRITE;
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
INSERT INTO `appointments` VALUES (1,1,101,'2025-02-01','Not eating',1,' 10:00:00'),(2,2,202,'2025-02-02','Skin rash and itching',2,'11:00:00'),(3,3,303,'2025-02-03','Annual wellness check',2,'09:30:00'),(4,4,404,'2025-02-04','Eye irritation and discharge',4,'14:00:00'),(5,5,101,'2025-02-05','Check for signs of lethargy',1,'15:00:00'),(6,6,202,'2025-02-06','Dental cleaning and check-up',3,'08:30:00'),(7,7,303,'2025-02-07','Minor injury, limping',3,'16:00:00'),(8,8,404,'2025-02-08','Spaying procedure',4,'13:30:00'),(9,9,101,'2025-02-09','Routine heart check-up',1,'17:00:00'),(10,10,202,'2025-02-10','Regular health check for allergies',2,'12:00:00'),(11,11,101,'2025-02-16','Routine Checkup',1,'10:00:00'),(12,12,202,'2025-02-16','Skin irritation',2,'14:00:00'),(13,13,303,'2025-02-17','Minor Leg Injury',3,'09:00:00'),(14,14,404,'2025-02-17','Eye redness and irritation',4,'13:30:00'),(15,15,101,'2025-02-18','Routine vaccinations',1,'11:00:00'),(16,16,202,'2025-02-18','Allergy test',2,'15:00:00'),(17,17,303,'2025-02-19','Broken wing treatment',3,'08:30:00'),(18,18,404,'2025-02-19','Fur loss and skin issues',4,'14:30:00'),(19,19,101,'2025-02-20','Swim bladder check',1,'09:30:00'),(20,20,202,'2025-02-20','Shell infection',2,'13:00:00'),(21,11,303,'2025-02-21','Limping, possible fracture',3,'10:00:00'),(22,12,404,'2025-02-21','Excessive scratching',4,'16:00:00'),(23,13,101,'2025-02-22','General wellness exam',1,'11:30:00'),(24,14,202,'2025-02-22','Skin rash treatment',2,'14:00:00'),(25,15,303,'2025-02-23','Leg sprain assessment',3,'10:00:00'),(26,16,404,'2025-02-23','Hair loss and redness',4,'13:30:00'),(27,17,101,'2025-02-24','Annual health exam',1,'09:00:00'),(28,18,202,'2025-02-24','Mild allergy symptoms',2,'15:00:00'),(29,19,303,'2025-02-25','Fin rot check',3,'10:30:00'),(30,20,404,'2025-02-25','Shell discoloration',4,'12:30:00'),(31,11,101,'2025-02-26','Routine blood test',1,'11:00:00'),(32,12,202,'2025-02-26','Excessive hair shedding',2,'16:00:00'),(33,13,303,'2025-02-27','Check-up after injury',3,'09:30:00'),(34,14,404,'2025-02-28','Minor Infection on ears',4,'2:00'),(35,15,101,'2025-02-28','Vaccination booster',1,'10:00:00'),(36,16,202,'2025-03-01','Minor Skin Allergy',2,'11:30'),(37,21,202,'2025-03-23','Checkup',2,'1:00'),(38,2,202,'2025-04-01','Skin rash check-up',2,'22:20:00'),(39,3,303,'2025-04-03','Annual wellness exam',3,'09:30'),(40,4,404,'2025-04-03','Eye irritation check',4,'14:00'),(41,5,101,'2025-04-04','Dental cleaning and check-up',1,'08:30'),(42,20,101,'2025-03-23','Neuter',1,'9:00'),(43,15,406,'2025-03-20','Monthly Checkup',2,'1:00'),(46,3,101,'2025-04-01','Laboratory',1,'22:20:00'),(47,13,404,'2025-04-01','Checkup',2,'23:00:00'),(48,21,407,'2025-04-01','Laboratory',3,'22:00:00'),(49,14,101,'2025-04-01','Neuter',4,'21:40:00'),(50,1,101,'2025-01-02','asas',1,'10:29:pm'),(51,25,202,'2025-05-06','Follow up Checkup',4,'8:00'),(52,22,101,'2025-05-06','Laboratory and Follow up Checkup ',4,'8:00'),(54,1,303,'2025-05-23','Skin rash and itching',3,'11:16'),(57,1,101,'2025-05-24','Neuter',1,'10:22'),(58,14,202,'2025-05-15','Checkup',2,'12:00'),(59,10,202,'2025-05-20','Deworm',2,'13:30'),(60,28,407,'2025-05-13','Dental Cleaning',4,'8:00');
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_appointment_insert` BEFORE INSERT ON `appointments` FOR EACH ROW BEGIN
    DECLARE count_existing INT;

    SELECT COUNT(*) INTO count_existing
    FROM appointments
    WHERE (pet_id = NEW.pet_id OR vet_id = NEW.vet_id) 
    AND appointment_date = NEW.appointment_date 
    AND appointment_time = NEW.appointment_time;

    IF count_existing > 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'The pet or vet already has an appointment at this time';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_appointment_insert` AFTER INSERT ON `appointments` FOR EACH ROW INSERT INTO appointment_logs (appointment_id, pet_id, vet_id, action, action_time)
VALUES (NEW.appointment_id, NEW.pet_id, NEW.vet_id, 'INSERT', NOW()) */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_appointment_update` BEFORE UPDATE ON `appointments` FOR EACH ROW BEGIN
    IF OLD.appointment_date < CURDATE() THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Cannot modify past appointments';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_appointment_update` AFTER UPDATE ON `appointments` FOR EACH ROW BEGIN
    INSERT INTO appointment_logs (appointment_id, pet_id, vet_id, action, action_time)
    VALUES (NEW.appointment_id, NEW.pet_id, NEW.vet_id, 'UPDATE', NOW());
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_appointment_delete` BEFORE DELETE ON `appointments` FOR EACH ROW BEGIN
    IF OLD.appointment_date < CURDATE() THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Cannot delete past appointments';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_appointment_delete` AFTER DELETE ON `appointments` FOR EACH ROW BEGIN
    INSERT INTO appointment_logs (appointment_id, pet_id, vet_id, action, action_time)
    VALUES (OLD.appointment_id, OLD.pet_id, OLD.vet_id, 'DELETE', NOW());
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `billing_summary`
--

DROP TABLE IF EXISTS `billing_summary`;
/*!50001 DROP VIEW IF EXISTS `billing_summary`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `billing_summary` AS SELECT 
 1 AS `bill_id`,
 1 AS `pet_name`,
 1 AS `owner_first_name`,
 1 AS `owner_last_name`,
 1 AS `appointment_date`,
 1 AS `total_cost`,
 1 AS `Total_records_count`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `bills`
--

DROP TABLE IF EXISTS `bills`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bills` (
  `bill_id` int NOT NULL AUTO_INCREMENT,
  `appointment_id` int DEFAULT NULL,
  `total_cost` decimal(10,2) DEFAULT NULL,
  `bill_status` enum('Paid','Unpaid') DEFAULT 'Unpaid',
  PRIMARY KEY (`bill_id`),
  KEY `appointment_id_idx` (`appointment_id`),
  CONSTRAINT `appointment_id_bills` FOREIGN KEY (`appointment_id`) REFERENCES `appointments` (`appointment_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bills`
--

LOCK TABLES `bills` WRITE;
/*!40000 ALTER TABLE `bills` DISABLE KEYS */;
INSERT INTO `bills` VALUES (1,1,1800.00,'Paid'),(2,2,1200.00,'Paid'),(3,3,1099.00,'Paid'),(4,4,1100.00,'Paid'),(5,5,1300.00,'Paid'),(6,6,1500.00,'Paid'),(7,8,1200.00,'Paid'),(8,7,2500.00,'Paid'),(9,9,1100.00,'Paid'),(10,10,1300.00,'Paid'),(11,11,1050.00,'Paid'),(12,12,1150.00,'Paid'),(13,13,1200.00,'Paid'),(14,14,1100.00,'Paid'),(15,15,1000.00,'Paid'),(16,16,1500.00,'Paid'),(17,17,1400.00,'Paid'),(18,18,1200.00,'Paid'),(19,19,1100.00,'Paid'),(20,20,1150.00,'Paid'),(21,21,1600.00,'Paid'),(22,22,1100.00,'Paid'),(23,23,1050.00,'Paid'),(24,24,1150.00,'Paid'),(25,25,1200.00,'Paid'),(26,26,1400.00,'Paid'),(27,27,1200.00,'Paid'),(28,28,1150.00,'Paid'),(29,29,1200.00,'Paid'),(30,30,1100.00,'Paid'),(31,31,5391.69,'Unpaid'),(32,32,6200.48,'Unpaid'),(33,33,6470.01,'Unpaid'),(34,34,5930.82,'Unpaid'),(35,35,5391.69,'Unpaid'),(36,36,6470.01,'Paid'),(39,38,1200.00,'Unpaid'),(43,46,300.00,'Unpaid');
/*!40000 ALTER TABLE `bills` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `current_appointments`
--

DROP TABLE IF EXISTS `current_appointments`;
/*!50001 DROP VIEW IF EXISTS `current_appointments`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `current_appointments` AS SELECT 
 1 AS `appointment_id`,
 1 AS `pet_id`,
 1 AS `vet_id`,
 1 AS `appointment_date`,
 1 AS `reason`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `owners`
--

DROP TABLE IF EXISTS `owners`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `owners` (
  `owner_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `phone` varchar(11) DEFAULT NULL,
  `address` mediumtext,
  PRIMARY KEY (`owner_id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `owners`
--

LOCK TABLES `owners` WRITE;
/*!40000 ALTER TABLE `owners` DISABLE KEYS */;
INSERT INTO `owners` VALUES (1,'Juan','Dela Cruz','09123456789','123 Rizal St, Manila, Metro Manila, Philippines'),(2,'Maria','Santos','09234567890','456 Mabini Ave, Quezon City, Metro Manila, Philippines'),(3,'Jose','Reyes','09345678901','789 Bonifacio Rd, Makati, Metro Manila, Philippines'),(4,'Ana','Gonzales','09456789012','147 Aguinaldo Blvd, Cebu City, Cebu, Philippines'),(5,'Pedro','Torres','09567890123','258 Luna St, Davao City, Davao del Sur, Philippines'),(6,'Luisa','Ramos','09678901234','369 Mabuhay Ave, Baguio City, Benguet, Philippines'),(7,'Carlos','Cruz','09789012345','753 Kalayaan Dr, Iloilo City, Iloilo, Philippines'),(8,'Elena','Bautista','09890123456','852 Malvar St, Cagayan de Oro, Misamis Oriental, Philippines'),(9,'Manuel','Flores','09901234567','159 Katipunan Rd, Bacolod City, Negros Occidental, Philippines'),(10,'Carmen','Navarro','09912345678','357 Lapu-Lapu Ave, Zamboanga City, Zamboanga del Sur, Philippines'),(11,'Ricardo','Fernandez','09151234567','789 Rizal St, Manila, Philippines'),(12,'Angela','Delos Reyes','09261234567','456 Katipunan Ave, Quezon City, Philippines'),(13,'Samuel','Ortiz','09371234567','123 Mabini St, Makati, Philippines'),(14,'Bianca','Lopez','09481234567','852 Bonifacio Blvd, Pasay, Philippines'),(15,'Diego','Santos','09591234567','369 Aguinaldo St, Taguig, Philippines'),(16,'Marians','Gutierrez','09601234567','753 Luna St, Marikina, Philippines'),(17,'Francis','Torralba','09711234567','357 Kalayaan Ave, Pasig, Philippines'),(18,'Michaela','Cruz','09821234567','258 Mabuhay Dr, Mandaluyong, Philippines'),(19,'Santiago','Ramos','09931234567','147 Lapu-Lapu St, San Juan, Philippines'),(20,'Lucia','Navarro','09941234567','951 Malvar Rd, Caloocan, Philippines'),(22,'Camille','Villarazas','12222444444','Camalig Albay'),(26,'Janine','Ishe','09192305098','Purok4, Camalig Albay'),(28,'Rey Gabriel','Literal','09202868754','Purok 3, Malabog, Daraga');
/*!40000 ALTER TABLE `owners` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `pastappointments`
--

DROP TABLE IF EXISTS `pastappointments`;
/*!50001 DROP VIEW IF EXISTS `pastappointments`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `pastappointments` AS SELECT 
 1 AS `appointment_id`,
 1 AS `pet_id`,
 1 AS `vet_id`,
 1 AS `appointment_date`,
 1 AS `reason`,
 1 AS `status`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `pet_info`
--

DROP TABLE IF EXISTS `pet_info`;
/*!50001 DROP VIEW IF EXISTS `pet_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `pet_info` AS SELECT 
 1 AS `pet_id`,
 1 AS `name`,
 1 AS `animal_type`,
 1 AS `description`,
 1 AS `age`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `pets`
--

DROP TABLE IF EXISTS `pets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pets` (
  `pet_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `animal_type` mediumtext,
  `description` longtext,
  `age` int DEFAULT NULL,
  `owner_id` int DEFAULT NULL,
  PRIMARY KEY (`pet_id`),
  KEY `owner_id_idx` (`owner_id`),
  CONSTRAINT `owner_id` FOREIGN KEY (`owner_id`) REFERENCES `owners` (`owner_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pets`
--

LOCK TABLES `pets` WRITE;
/*!40000 ALTER TABLE `pets` DISABLE KEYS */;
INSERT INTO `pets` VALUES (1,'Buddy','Dog','Doggo Dark Brown with white coat',6,1),(2,'Whisker','Cat','White Persian cat with fluffy fur, calm and affectionate.',4,2),(3,'Coco','Dog','Shih Tzu with a mix of brown and white fur, loves to cuddle.',4,3),(4,'Milod','Dog','Labrador Retriever with a chocolate brown coat, energetic and playful.',5,4),(5,'Luna','Cat','Siamese cat with a cream body and dark brown ears, playful and curious.',1,5),(6,'Luna','Dog','Bulldog with a white and brown patchy coat, strong and protective.',6,6),(7,'Kiwi','Bird','Green parrot with yellow-tipped wings, can mimic words.',2,7),(8,'Shadow','Cat','Black Maine Coon with long fur, independent but affectionate.',3,8),(9,'Nemo','Fish','Orange and white Clownfish, lives in a saltwater aquarium.',1,9),(10,'Bubbles','Rabbit','Gray Holland Lop rabbit with soft fur, enjoys eating carrots.',2,10),(11,'Rocky','Dog','German Shepherd, intelligent and loyal.',4,11),(12,'Fluffy','Cat','Ragdoll cat, blue eyes and fluffy fur.',3,12),(13,'Bruno','Dog','Doberman, protective and energetic.',5,13),(14,'Oreo','Rabbit','Holland Lop rabbit, black and white fur.',2,14),(15,'Max','Dog','Beagle, friendly and curious.',3,15),(16,'Snowball','Cat','British Shorthair, soft white coat.',2,16),(17,'Ziggy','Parrot','African Grey Parrot, highly intelligent.',4,17),(18,'Shadow','Dog','Siberian Husky, striking blue eyes.',3,18),(19,'Finn','Fish','Goldfish, bright orange, loves swimming.',1,19),(20,'Pebbles','Turtle','Red-eared Slider, enjoys basking.',5,20),(21,'Kimmy','Cat','White, red eye, short black tail.',2,20),(22,'Buger','Dogg','Labrador Retriever with a chocolate brown coat, energetic and playfuls.',5,4),(25,'Alex','Cat','Cute TriColor Pome with pink Collar.',2,10),(27,'Axa','Dog','White puppy with green colar and yellow tail.',1,10),(28,'Loki','Dog','Brown and White coat with chubby features and blue colar.',6,28);
/*!40000 ALTER TABLE `pets` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `staff_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `phone` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`staff_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,'Janine','Moral','09171234567'),(2,'Romar','Ancerooo','09128748902'),(3,'Johnny','Uragon','09281234567'),(4,'Akemi','Axel','09346734534');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `summary_appointments`
--

DROP TABLE IF EXISTS `summary_appointments`;
/*!50001 DROP VIEW IF EXISTS `summary_appointments`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `summary_appointments` AS SELECT 
 1 AS `appointment_id`,
 1 AS `pet_name`,
 1 AS `owner_first_name`,
 1 AS `owner_last_name`,
 1 AS `vet_first_name`,
 1 AS `vet_last_name`,
 1 AS `appointment_date`,
 1 AS `reason`,
 1 AS `non_updatable_column`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `treatment`
--

DROP TABLE IF EXISTS `treatment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `treatment` (
  `treatment_id` int NOT NULL AUTO_INCREMENT,
  `appointment_id` int DEFAULT NULL,
  `treatment_description` longtext,
  `medication` longtext,
  `cost` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`treatment_id`),
  KEY `appointment_id_idx` (`appointment_id`),
  CONSTRAINT `appointment_id_fkTreat` FOREIGN KEY (`appointment_id`) REFERENCES `appointments` (`appointment_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `treatment`
--

LOCK TABLES `treatment` WRITE;
/*!40000 ALTER TABLE `treatment` DISABLE KEYS */;
INSERT INTO `treatment` VALUES (11,1,'Treatment for anorexia and dehydration','IV fluids, appetite stimulants',1800.00),(12,2,'Treatment for skin rash and itching','Antihistamines, topical creams',1200.00),(13,3,'General wellness check','Routine check-up, vaccinations',1099.00),(14,4,'Eye irritation and discharge treatment','Antibiotic ointment, eye drops',1100.00),(15,5,'Treatment for lethargy signs','Blood work, hydration therapy',1300.00),(16,6,'Dental cleaning and routine check-up','Tooth scaling, fluoride treatment',1500.00),(17,7,'Treatment for minor injury and limping','Pain management, bandaging',1200.00),(18,8,'Spaying procedure','Anesthesia, post-op pain relief',2500.00),(19,9,'Routine heart check-up','Heart exam, ECG and Blood Test',1100.00),(20,10,'Health check for allergies','Allergy testing, medications',1300.00),(21,11,'Routine health check-up','General exam, vaccinations',1050.00),(22,12,'Treatment for skin irritation','Topical ointment, anti-inflammatory drugs',1150.00),(23,13,'Treatment for minor leg injury','Pain management, rest',1200.00),(24,14,'Treatment for eye redness and irritation','Eye drops, anti-inflammatory medication',1100.00),(25,15,'Routine vaccinations','Vaccines for core diseases',1000.00),(26,16,'Allergy testing','Skin test, antihistamines',1500.00),(27,17,'Treatment for broken wing','Splinting, pain relief',1400.00),(28,18,'Treatment for fur loss and skin issues','Anti-fungal treatment, shampoos',1200.00),(29,19,'Swim bladder check','Diagnostic exam, water therapy',1100.00),(30,20,'Treatment for shell infection','Antibiotics, shell care',1150.00),(31,21,'Treatment for limping, possible fracture','X-ray, splinting, pain management',1600.00),(32,22,'Treatment for excessive scratching','Anti-itch creams, antihistamines',1100.00),(33,23,'General wellness exam','Full check-up, vaccinations',1050.00),(34,24,'Treatment for skin rash','Topical ointments, anti-inflammatory',1150.00),(35,25,'Leg sprain assessment','Rest, bandaging, pain relief',1200.00),(36,26,'Treatment for hair loss and redness','Topical treatments, steroids',1400.00),(37,27,'Annual health exam','Comprehensive check-up',1200.00),(38,28,'Treatment for mild allergy symptoms','Antihistamines, allergy shots',1150.00),(39,29,'Treatment for fin rot','Antibiotics, water treatment',1200.00),(40,30,'Treatment for shell discoloration','Calcium supplements, shell care',1100.00),(41,31,'Routine blood test','Blood work analysis',1000.00),(42,32,'Treatment for excessive hair shedding','Vitamin supplements, skin care',1150.00),(43,33,'Check-up after injury','Post-injury check, pain management',1200.00),(44,34,'Treatment for minor ear infection','Ear drops, antibiotics',1100.00),(45,35,'Vaccination booster','Core vaccines booster',1000.00),(46,36,'Treatment for minor skin allergy','Antihistamines, topical creams',1200.00),(47,37,'Routine check-up','Full physical exam, vaccination',1050.00),(48,38,'Treatment for skin rash check-up','Topical ointment, allergy medication',920.00),(49,39,'Annual wellness exam','Routine check-up, vaccination',1200.00),(50,40,'Check for eye irritation','Eye drops, anti-inflammatory medication',1100.00),(51,41,'Dental cleaning and check-up','Tooth scaling, fluoride treatment',1500.00),(52,42,'Neuter procedure','Anesthesia, post-op care',2500.00),(53,43,'Monthly check-up','Routine check-up, vitamin supplements',1050.00),(58,46,'Lab tests only','none',300.00),(59,47,'Lab tests only for checkup','Reco: Routine Checkup and deworm',720.00);
/*!40000 ALTER TABLE `treatment` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `update_bill_cost_after_treatment_update` AFTER UPDATE ON `treatment` FOR EACH ROW BEGIN
    UPDATE bills
    SET bills.total_cost = NEW.cost
    WHERE bills.appointment_id = NEW.appointment_id;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `upcomming_appointments`
--

DROP TABLE IF EXISTS `upcomming_appointments`;
/*!50001 DROP VIEW IF EXISTS `upcomming_appointments`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `upcomming_appointments` AS SELECT 
 1 AS `appointment_id`,
 1 AS `pet_id`,
 1 AS `vet_id`,
 1 AS `appointment_date`,
 1 AS `reason`,
 1 AS `status`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `vet_doctor`
--

DROP TABLE IF EXISTS `vet_doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vet_doctor` (
  `vet_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `specialization` varchar(45) DEFAULT NULL,
  `phone` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`vet_id`)
) ENGINE=InnoDB AUTO_INCREMENT=415 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vet_doctor`
--

LOCK TABLES `vet_doctor` WRITE;
/*!40000 ALTER TABLE `vet_doctor` DISABLE KEYS */;
INSERT INTO `vet_doctor` VALUES (101,'Carlos','Santos','Internal Medicine','09123456789'),(202,'Maria','Reyes','General Practice','09234567890'),(303,'Jose','Gonzale','Surgery','09345678901'),(404,'Ana','Dela Cruz','Dermatology','09456789012'),(405,'Janine','Matamorosa','Cardio','09192305092'),(406,'Gab','Literal','Heart Surgery','09256782671'),(407,'Ishe','Morales','Dental','09873456812'),(408,'Axelia','Moral','Anesthesia','12345678991');
/*!40000 ALTER TABLE `vet_doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vet_total_loads`
--

DROP TABLE IF EXISTS `vet_total_loads`;
/*!50001 DROP VIEW IF EXISTS `vet_total_loads`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vet_total_loads` AS SELECT 
 1 AS `vet_id`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `total_appointments`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'vet_record'
--
/*!50106 SET @save_time_zone= @@TIME_ZONE */ ;
/*!50106 DROP EVENT IF EXISTS `chargeOverdueBills` */;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'SYSTEM' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`localhost`*/ /*!50106 EVENT `chargeOverdueBills` ON SCHEDULE EVERY 100 DAY STARTS '2025-04-01 22:40:19' ON COMPLETION NOT PRESERVE ENABLE DO UPDATE bills
SET total_cost = total_cost * 1.03
WHERE bill_status = 'Unpaid' */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
DELIMITER ;
/*!50106 SET TIME_ZONE= @save_time_zone */ ;

--
-- Dumping routines for database 'vet_record'
--
/*!50003 DROP FUNCTION IF EXISTS `AppointmentStatus` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `AppointmentStatus`(apptDate DATE) RETURNS char(20) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
    RETURN IF(apptDate >= CURDATE(), 'Upcoming', 'Completed');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `CalcVetTotalEarnings` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `CalcVetTotalEarnings`(vet_id INT) RETURNS double
    DETERMINISTIC
BEGIN  
    DECLARE total DOUBLE;
    SELECT SUM(b.total_cost) 
    INTO total 
    FROM bills b
    JOIN appointments a ON b.appointment_id = a.appointment_id
    WHERE a.vet_id = vet_id 
      AND a.appointment_date < CURDATE(); 

    RETURN IFNULL(total, 0);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetAnimalTypeOfPet` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetAnimalTypeOfPet`(pet_id INT) RETURNS varchar(45) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
    DECLARE pet_type VARCHAR(45);
    SELECT animal_type INTO pet_type 
    FROM pets 
    WHERE pets.pet_id = pet_id 
    LIMIT 1; 

    RETURN pet_type;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `UpcomAppCountForVet` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `UpcomAppCountForVet`(vet_id_param INT) RETURNS int
    DETERMINISTIC
BEGIN
    DECLARE appointment_count INT;

    SELECT COUNT(*) INTO appointment_count
    FROM appointments
    WHERE vet_id = vet_id_param 
    AND appointment_date > CURDATE();

    RETURN appointment_count;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `VetSpecialization` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `VetSpecialization`(vet_id INT) RETURNS varchar(100) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
    DECLARE spec VARCHAR(100);

    SELECT specialization INTO spec
    FROM vet_doctor
    WHERE vet_doctor.vet_id = vet_id
    LIMIT 1;

    RETURN IFNULL(spec, 'Not Available');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AddNewDoctor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddNewDoctor`(
	IN doc_first_name varchar(45),
    IN doc_last_name varchar(45),
    IN doc_specialization varchar(45),
    IN doc_phone varchar(11)
)
BEGIN 
	INSERT INTO vet_doctor (first_name, last_name, specialization, phone)
    VALUES (doc_first_name, doc_last_name, doc_specialization, doc_phone);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AppointmentByStaffId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AppointmentByStaffId`(
	IN input_staff_id INT
)
BEGIN 
	DECLARE done INT DEFAULT 0;
    DECLARE pet_name VARCHAR (100);
    DECLARE owner_name VARCHAR(100);
	DECLARE appointment_reason LONGTEXT;
    DECLARE appointment_date DATE;
    DECLARE appointment_time VARCHAR(45);
    DECLARE staff_name VARCHAR(100);
    
    DECLARE appointment_cursor CURSOR FOR 
		SELECT p.name, o.first_name, a.reason, a.appointment_date, a.appointment_time, s.first_name
        FROM appointments a
        JOIN pets p ON a.pet_id = p.pet_id
        JOIN staff s ON a.staff_id = s.staff_id
        JOIN owners o ON p.owner_id = o.owner_id
        WHERE a.staff_id = input_staff_id;
        
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
    
    OPEN appointment_cursor;
    
    read_loop: LOOP
    FETCH appointment_cursor INTO pet_name, owner_name, appointment_reason, appointment_date, appointment_time, staff_name;
    
    IF done THEN 
		LEAVE read_loop;
	END IF;
    
    SELECT 
		pet_name AS 'Pet Name',
        owner_name AS 'Owner Name',
        appointment_reason AS 'Reason of Visit',
        appointment_date AS 'Appointment Date',
        appointment_time AS 'Appointment Time',
        staff_name AS 'Staff Name';
        
	END LOOP;
    
    CLOSE appointment_cursor;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getPetsByOwner` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getPetsByOwner`(
	IN input_owner_id INT
)
BEGIN 
	DECLARE done INT DEFAULT 0;
    DECLARE pet_name VARCHAR(100);
    DECLARE pet_animal_type VARCHAR(45);
    DECLARE owner_name VARCHAR (100);
	DECLARE pet_description LONGTEXT;
    
    DECLARE pet_cursor CURSOR FOR
		SELECT p.name, p.animal_type, o.first_name, p.description
        FROM pets p
        JOIN owners o ON p.owner_id = o.owner_id
        WHERE p.owner_id = input_owner_id;

	DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
    
    OPEN pet_cursor;
    
    read_loop: LOOP
		FETCH pet_cursor INTO pet_name, pet_animal_type, owner_name, pet_description;
        
        IF done THEN 
			LEAVE read_loop;
		END IF;
        
        SELECT pet_name AS 'Pet Name',
				pet_animal_type AS 'Animal Type',
                owner_name AS 'Owner Name',
                pet_description AS 'Description';
		END LOOP;
        CLOSE pet_cursor;
        
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateAppointment` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateAppointment`(
	IN p_appointment_id INT,
    IN p_appointment_date DATE,
    IN p_appointment_time VARCHAR(10),
    IN p_reason LONGTEXT
)
BEGIN 
	UPDATE appointments SET
		appointment_date = p_appointment_date,
        appointment_time = p_appointment_time,
        reason = p_reason
	WHERE appointment_id = p_appointment_id;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `VetUpcomApp` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUpcomApp`(IN vet_id_param INT)
BEGIN
    SELECT 
        v.vet_id,
        v.first_name AS vet_first_name,
        v.last_name AS vet_last_name,
        UpcomAppCountForVet(v.vet_id) AS total_upcoming_appointments,
        a.appointment_id,
        a.appointment_date,
        a.appointment_time,
        p.name AS pet_name,
        a.reason
    FROM vet_doctor v
    LEFT JOIN appointments a ON v.vet_id = a.vet_id
    LEFT JOIN pets p ON a.pet_id = p.pet_id
    WHERE v.vet_id = vet_id_param 
    AND a.appointment_date > CURDATE();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `VetUpcomApp_withVetSpec` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `VetUpcomApp_withVetSpec`(IN vet_id_param INT)
BEGIN
    SELECT 
        v.vet_id,
        v.first_name AS vet_first_name,
        v.last_name AS vet_last_name,
        VetSpecialization(v.vet_id) AS specialization, -- Added VetSpecialization
        UpcomAppCountForVet(v.vet_id) AS total_upcoming_appointments,
        a.appointment_id,
        a.appointment_date,
        a.appointment_time,
        p.name AS pet_name,
        a.reason
    FROM vet_doctor v
    LEFT JOIN appointments a ON v.vet_id = a.vet_id
    LEFT JOIN pets p ON a.pet_id = p.pet_id
    WHERE v.vet_id = vet_id_param 
    AND a.appointment_date > CURDATE();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `billing_summary`
--

/*!50001 DROP VIEW IF EXISTS `billing_summary`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `billing_summary` AS select `b`.`bill_id` AS `bill_id`,`p`.`name` AS `pet_name`,`o`.`first_name` AS `owner_first_name`,`o`.`last_name` AS `owner_last_name`,`a`.`appointment_date` AS `appointment_date`,`b`.`total_cost` AS `total_cost`,count(0) AS `Total_records_count` from (((`bills` `b` join `appointments` `a` on((`b`.`appointment_id` = `a`.`appointment_id`))) join `pets` `p` on((`a`.`pet_id` = `p`.`pet_id`))) join `owners` `o` on((`p`.`owner_id` = `o`.`owner_id`))) group by `b`.`bill_id`,`p`.`name`,`o`.`first_name`,`o`.`last_name`,`a`.`appointment_date`,`b`.`total_cost` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `current_appointments`
--

/*!50001 DROP VIEW IF EXISTS `current_appointments`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `current_appointments` AS select `appointments`.`appointment_id` AS `appointment_id`,`appointments`.`pet_id` AS `pet_id`,`appointments`.`vet_id` AS `vet_id`,`appointments`.`appointment_date` AS `appointment_date`,`appointments`.`reason` AS `reason` from `appointments` where (`appointments`.`appointment_date` >= curdate()) */
/*!50002 WITH CASCADED CHECK OPTION */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `pastappointments`
--

/*!50001 DROP VIEW IF EXISTS `pastappointments`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `pastappointments` AS select `appointments`.`appointment_id` AS `appointment_id`,`appointments`.`pet_id` AS `pet_id`,`appointments`.`vet_id` AS `vet_id`,`appointments`.`appointment_date` AS `appointment_date`,`appointments`.`reason` AS `reason`,`AppointmentStatus`(`appointments`.`appointment_date`) AS `status` from `appointments` where (`appointments`.`appointment_date` < curdate()) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `pet_info`
--

/*!50001 DROP VIEW IF EXISTS `pet_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `pet_info` AS select `pets`.`pet_id` AS `pet_id`,`pets`.`name` AS `name`,`pets`.`animal_type` AS `animal_type`,`pets`.`description` AS `description`,`pets`.`age` AS `age` from `pets` */
/*!50002 WITH CASCADED CHECK OPTION */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `summary_appointments`
--

/*!50001 DROP VIEW IF EXISTS `summary_appointments`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `summary_appointments` AS select `a`.`appointment_id` AS `appointment_id`,`p`.`name` AS `pet_name`,`o`.`first_name` AS `owner_first_name`,`o`.`last_name` AS `owner_last_name`,`v`.`first_name` AS `vet_first_name`,`v`.`last_name` AS `vet_last_name`,`a`.`appointment_date` AS `appointment_date`,`a`.`reason` AS `reason`,count(0) AS `non_updatable_column` from (((`appointments` `a` join `pets` `p` on((`p`.`pet_id` = `a`.`pet_id`))) join `owners` `o` on((`p`.`owner_id` = `o`.`owner_id`))) join `vet_doctor` `v` on((`a`.`vet_id` = `v`.`vet_id`))) group by `a`.`appointment_id`,`p`.`name`,`o`.`first_name`,`o`.`last_name`,`v`.`first_name`,`v`.`last_name`,`a`.`appointment_date`,`a`.`reason` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `upcomming_appointments`
--

/*!50001 DROP VIEW IF EXISTS `upcomming_appointments`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `upcomming_appointments` AS select `appointments`.`appointment_id` AS `appointment_id`,`appointments`.`pet_id` AS `pet_id`,`appointments`.`vet_id` AS `vet_id`,`appointments`.`appointment_date` AS `appointment_date`,`appointments`.`reason` AS `reason`,`AppointmentStatus`(`appointments`.`appointment_date`) AS `status` from `appointments` where (`appointments`.`appointment_date` >= curdate()) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vet_total_loads`
--

/*!50001 DROP VIEW IF EXISTS `vet_total_loads`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vet_total_loads` AS select `v`.`vet_id` AS `vet_id`,`v`.`first_name` AS `first_name`,`v`.`last_name` AS `last_name`,count(`a`.`appointment_id`) AS `total_appointments` from (`vet_doctor` `v` left join `appointments` `a` on((`v`.`vet_id` = `a`.`vet_id`))) group by `v`.`vet_id`,`v`.`first_name`,`v`.`last_name` */;
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

-- Dump completed on 2025-05-10 20:05:22
