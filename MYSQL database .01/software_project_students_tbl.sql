-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: software_project
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `students_tbl`
--

DROP TABLE IF EXISTS `students_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `students_tbl` (
  `student_id` int(11) NOT NULL,
  `password` varchar(250) DEFAULT NULL,
  `first_name` varchar(250) DEFAULT NULL,
  `last_name` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students_tbl`
--

LOCK TABLES `students_tbl` WRITE;
/*!40000 ALTER TABLE `students_tbl` DISABLE KEYS */;
INSERT INTO `students_tbl` VALUES (90019138,'QuallsR97523','Robert','Qualls'),(90037632,'SealsR44203','Rigoberto','Seals'),(99002141,'GalindoF27106','Frances','Galindo'),(99008102,'YoungV89102','Victor','Young'),(99019108,'HicksonM38614','Minnie','Hickson'),(99022011,'SmithM44907','Monique','Smith'),(99031707,'SmithC15044','Clyde','Smith'),(99033436,'SmithA55104','Ariel','Smith'),(99037660,'BakerG76247','Gloria','Baker'),(99045406,'AlexanderJ80221','Jason','Alexander'),(99048235,'WamsleyD24228','Debra','Wamsley'),(99053151,'FaulH65101','Herbert','Faul'),(99058554,'MooreN2132','Nancy','Moore'),(99061820,'NorbyJ75446','Joy','Norby'),(99065325,'BrooksA90014','Allison','Brooks'),(99072212,'CookP92262','Patsy','Cook'),(99080015,'WestJ49262','John','West'),(99084120,'RowlandM94612','Mary','Rowland'),(99092111,'SchneiderD29601','Dolores','Schneider'),(99097205,'OwensK84010','Kristal','Owens');
/*!40000 ALTER TABLE `students_tbl` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-13 14:41:19
