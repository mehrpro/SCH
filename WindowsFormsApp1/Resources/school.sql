CREATE DATABASE  IF NOT EXISTS `schooldb` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_persian_ci */;
USE `schooldb`;
-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: localhost    Database: schooldb
-- ------------------------------------------------------
-- Server version	8.0.11

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
-- Table structure for table `academic_year`
--

DROP TABLE IF EXISTS `academic_year`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `academic_year` (
  `ID` smallint(5) unsigned NOT NULL AUTO_INCREMENT COMMENT 'شناسه',
  `years_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'سال تحصیلی',
  `years_start` date NOT NULL COMMENT 'آغاز سال تحصیلی',
  `years_finish` date NOT NULL COMMENT 'پایان سال تحصیلی',
  `enabled` tinyint(4) NOT NULL COMMENT 'وضعیت',
  `description` varchar(300) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL COMMENT 'توضیحات',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `classrooms`
--

DROP TABLE IF EXISTS `classrooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `classrooms` (
  `ClassID` tinyint(3) unsigned NOT NULL AUTO_INCREMENT COMMENT 'شناسه',
  `ClassName` varchar(150) CHARACTER SET utf8 COLLATE utf8_persian_ci NOT NULL COMMENT 'نام کلاس',
  `ClassLevel` tinyint(3) unsigned NOT NULL COMMENT 'مقطع تحصیلی',
  `ClassRegisterDate` date NOT NULL COMMENT 'تاریخ ثبت',
  `ClassRoomEnable` tinyint(1) NOT NULL COMMENT 'فعال بودن کلاس',
  PRIMARY KEY (`ClassID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci ROW_FORMAT=COMPRESSED;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `registered`
--

DROP TABLE IF EXISTS `registered`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `registered` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'شناسه',
  `years_fk` smallint(6) NOT NULL COMMENT 'شناسه سال تحصیلی',
  `school_fk` tinyint(4) NOT NULL COMMENT 'شناسه مدرسه',
  `class_fk` tinyint(4) NOT NULL COMMENT 'شناسه کلاس',
  `student_fk` int(11) NOT NULL COMMENT 'شناسه دانش آموز',
  `enabled` tinyint(4) NOT NULL COMMENT 'وضعیت',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `registered_tag`
--

DROP TABLE IF EXISTS `registered_tag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `registered_tag` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT COMMENT 'شناسه',
  `tagid_fk` int(11) NOT NULL COMMENT 'شناسه تگ',
  `student_fk` int(11) NOT NULL COMMENT 'شناسه دانش آموز',
  `enabled` tinyint(4) NOT NULL COMMENT 'وضعیت',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `schools`
--

DROP TABLE IF EXISTS `schools`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `schools` (
  `ID` tinyint(3) unsigned NOT NULL AUTO_INCREMENT COMMENT 'شناسه',
  `SchoolName` varchar(150) CHARACTER SET utf8 COLLATE utf8_persian_ci NOT NULL COMMENT 'نام مدرسه',
  `SchoolAddress` varchar(250) CHARACTER SET utf8 COLLATE utf8_persian_ci NOT NULL COMMENT 'آدرس مدرسه',
  `SchoolTel` varchar(12) CHARACTER SET utf8 COLLATE utf8_persian_ci NOT NULL COMMENT 'تلفن مدرسه',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `students` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT COMMENT 'شناسه',
  `FName` varchar(50) CHARACTER SET utf8 COLLATE utf8_persian_ci NOT NULL COMMENT 'نام',
  `LName` varchar(100) CHARACTER SET utf8 COLLATE utf8_persian_ci NOT NULL COMMENT 'فامیلی',
  `FullName` varchar(151) CHARACTER SET utf8 COLLATE utf8_persian_ci GENERATED ALWAYS AS (concat(`FName`,_utf8mb3' ',`LName`)) STORED NOT NULL COMMENT 'نام کامل',
  `StudentCode` varchar(20) CHARACTER SET utf8 COLLATE utf8_persian_ci DEFAULT NULL COMMENT 'کد دانش آموزشی',
  `StudentNatinalCode` int(11) NOT NULL COMMENT 'کد ملی',
  `FatherName` varchar(50) CHARACTER SET utf8 COLLATE utf8_persian_ci DEFAULT NULL COMMENT 'نام پدر',
  `MotherName` varchar(50) CHARACTER SET utf8 COLLATE utf8_persian_ci NOT NULL COMMENT 'نام مادر',
  `HomePhone` char(11) CHARACTER SET utf8 COLLATE utf8_persian_ci DEFAULT NULL COMMENT 'تلفن منزل',
  `FatherPhone` char(11) CHARACTER SET utf8 COLLATE utf8_persian_ci DEFAULT NULL COMMENT 'موبایل پدر',
  `MotherPhone` char(11) CHARACTER SET utf8 COLLATE utf8_persian_ci DEFAULT NULL COMMENT 'موبایل مادر',
  `SMS` char(11) CHARACTER SET utf8 COLLATE utf8_persian_ci DEFAULT NULL COMMENT 'پیامک',
  `BrithDate` date DEFAULT NULL COMMENT 'تاریخ تولد',
  `RegDate` datetime NOT NULL COMMENT 'تاریخ ثبت',
  `enabled` tinyint(1) NOT NULL COMMENT 'وضعیت',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tagid`
--

DROP TABLE IF EXISTS `tagid`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tagid` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'شناسه',
  `tagid_hex` varchar(20) COLLATE utf8_persian_ci NOT NULL COMMENT 'شماره سریال کارت',
  `enabled` tinyint(4) NOT NULL COMMENT 'وضعیت',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `users` (
  `ID` smallint(6) NOT NULL AUTO_INCREMENT COMMENT 'شناسه',
  `UserName` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'نام کاربری',
  `FName` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'نام',
  `LName` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'نام خانوادگی',
  `Mobile` char(12) CHARACTER SET utf8 COLLATE utf8_persian_ci DEFAULT NULL COMMENT 'موبایل',
  `Password` char(120) CHARACTER SET utf8 COLLATE utf8_persian_ci DEFAULT NULL COMMENT 'گذرواژه',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-01 21:13:16
