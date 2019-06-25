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
-- Table structure for table `students_tbl`
--

DROP TABLE IF EXISTS `students_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `students_tbl` (
  `UserName` int(11) NOT NULL,
  `Password` varchar(250) DEFAULT NULL,
  `first_name` varchar(250) DEFAULT NULL,
  `last_name` varchar(250) DEFAULT NULL,
  `street` varchar(250) DEFAULT NULL,
  `city` varchar(250) DEFAULT NULL,
  `zip_code` int(11) NOT NULL,
  `phone_number` varchar(25) DEFAULT NULL,
  `university_name` varchar(250) NOT NULL,
  PRIMARY KEY (`UserName`),
  KEY `FK` (`university_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students_tbl`
--

LOCK TABLES `students_tbl` WRITE;
/*!40000 ALTER TABLE `students_tbl` DISABLE KEYS */;
INSERT INTO `students_tbl` VALUES (90019138,'QuallsR97523','Robert','Qualls','395 New Street','Katy',77493,'541-287-1951','University of Houston - Downtown'),(90037632,'SealsR44203','Rigoberto','Seals','1916 Rivendell Drive','Houston',77082,'330-861-9388','University of Houston - Downtown'),(99002141,'GalindoF27106','Frances','Galindo','397 Fire Access Road','Houston',77013,'336-924-4774','University of Houston - Downtown'),(99008102,'YoungV89102','Victor','Young','3736 Hiney Road','Sugarland',77498,'702-222-9821','University of Houston - Downtown'),(99019108,'HicksonM38614','Minnie','Hickson','639 Saint Clair Street','Sugarland',77498,'662-627-5689','University of Houston - Downtown'),(99022011,'SmithM44907','Monique','Smith','1736 Langtown Road','Missouri City',77477,'567-231-2194','University of Houston - Downtown'),(99031707,'SmithC15044','Clyde','Smith','3136 Pine Street','Houston',77045,'724-321-1863','University of Houston - Downtown'),(99033436,'SmithA55104','Ariel','Smith','1369 Orchard Street','Houston',77036,'952-601-7925','University of Houston - Downtown'),(99037660,'BakerG76247','Gloria','Baker','4954 Giraffe Hill Drive','Houston',77036,'972-317-7508','University of Houston - Downtown'),(99045406,'AlexanderJ80221','Jason','Alexander','4393 Sampson Street','Humble',77396,'303-609-8275','University of Houston - Downtown'),(99048235,'WamsleyD24228','Debra','Wamsley','3684 Payne Street','Pearland',77581,'276-926-7416','University of Houston - Downtown'),(99053151,'FaulH65101','Herbert','Faul','4806 Maple Court','Pasadena',77507,'573-395-8650','University of Houston - Downtown'),(99058554,'MooreN2132','Nancy','Moore','2137 Wescam Court','The Woodlands',77387,'781-223-2723','University of Houston - Downtown'),(99061820,'NorbyJ75446','Joy','Norby','3351 Pickens Way','Pearland',77581,'903-378-8395','University of Houston - Downtown'),(99065325,'BrooksA90014','Allison','Brooks','1518 Heavens Way','Katy',77493,'949-265-1157','University of Houston - Downtown'),(99072212,'CookP92262','Patsy','Cook','1851 Coleman Avenue','Katy',77493,'760-799-5157','University of Houston - Downtown'),(99080015,'WestJ49262','John','West','1040 Amethyst Drive','Houston',77029,'517-287-2321','University of Houston - Downtown'),(99084120,'RowlandM94612','Mary','Rowland','1634 Park Street','Houston',77029,'925-419-6874','University of Houston - Downtown'),(99092111,'SchneiderD29601','Dolores','Schneider','2278 Traction Street','Sugarland',77498,'864-538-1515','University of Houston - Downtown'),(99097205,'OwensK84010','Kristal','Owens','1398 Philadelphia Avenue','Houston',77082,'801-298-2521','University of Houston - Downtown');
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

-- Dump completed on 2019-06-25 13:31:19
