-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: software_eng
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
-- Table structure for table `courses_tbl`
--

DROP TABLE IF EXISTS `courses_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `courses_tbl` (
  `course_id` int(11) NOT NULL,
  `course_number` int(11) DEFAULT NULL,
  `course_name` varchar(250) DEFAULT NULL,
  `start_time` varchar(20) DEFAULT NULL,
  `end_time` varchar(20) DEFAULT NULL,
  `days` varchar(5) DEFAULT NULL,
  `book_title` varchar(250) DEFAULT NULL,
  `professor_name` varchar(250) DEFAULT NULL,
  `cost` float DEFAULT NULL,
  PRIMARY KEY (`course_id`),
  KEY `FK` (`book_title`,`professor_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses_tbl`
--

LOCK TABLES `courses_tbl` WRITE;
/*!40000 ALTER TABLE `courses_tbl` DISABLE KEYS */;
INSERT INTO `courses_tbl` VALUES (21808,1408,'Intro to CS with Visual Basic','5:30 PM','7:15 PM','TR','STARTING OUT W/VISUAL BASIC','Singh, Kulwant',300),(21815,2410,'Data Structures & Algorithms','10:00 AM','11:45 AM','TR','STARTING OUT W/C++','Harris, Cyril',300),(23357,4318,'Theory DB & File Structures','1:00 PM','2:15 PM','MW','DATABASE SYSTEMS:PRACT.APP','Yuan, Shengli',300),(23917,5318,'Database Management Systems','5:30 PM','6:45 PM','R',NULL,'Yuan, Shengli',300),(23923,3321,'Software Engineering','4:00 PM','5:15 AM','W',NULL,'Chang, Yuchou',300),(23926,3318,'Intro to Computer Security','1:00 PM','2:15 PM','R',NULL,'Yuan, Shengli',300),(23949,1301,'Composition I','11:30 AM','12:45 PM','MW',NULL,'Fortunato, Paul',300),(23991,2302,'Digital Logic','11:30 AM','12:45 PM','TR','FUNDAMENTALS OF LOGIC DESIGN','Singh, Kulwant',300),(24601,4332,'Artificial Intelligence','1:00 PM','2:15 PM','T',NULL,'Chang, Yuchou',300);
/*!40000 ALTER TABLE `courses_tbl` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-25 13:31:16
