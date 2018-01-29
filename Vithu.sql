-- phpMyAdmin SQL Dump
-- version 4.5.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 27, 2017 at 08:47 AM
-- Server version: 5.7.9
-- PHP Version: 5.6.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `busreservation`
--
CREATE DATABASE IF NOT EXISTS `busreservation` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `busreservation`;

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
CREATE TABLE IF NOT EXISTS `booking` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `seatId` int(11) NOT NULL,
  `busId` varchar(20) NOT NULL,
  `fName` varchar(50) NOT NULL,
  `lName` varchar(50) NOT NULL,
  `Gender` varchar(7) NOT NULL,
  `Contact` int(11) NOT NULL,
  `date` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=76 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `booking`
--

INSERT INTO `booking` (`id`, `seatId`, `busId`, `fName`, `lName`, `Gender`, `Contact`, `date`) VALUES
(54, 6, '1', 'Sanjeeban', 'Nithusha', 'Male', 212212252, '12/23/2017'),
(53, 5, '1', 'Sanjeeban', 'Nithusha', 'Male', 212212252, '12/23/2017'),
(52, 5, '2', 'Sanjee', 'Nithusha', 'Male', 212221212, '12/16/2017'),
(56, 1, '2', '', '', 'Male', 212221212, '12/23/2017'),
(46, 5, '2', 'Sanjee', 'Sanjee', 'Male', 212221212, '12/3/2017'),
(47, 9, '2', 'Sanjee', 'Sanjee', 'Male', 212221212, '12/3/2017'),
(45, 1, '2', 'Sanjee', 'Sanjee', 'Male', 212221212, '12/3/2017'),
(55, 19, '1', 'Sanjeeban', 'Nithusha', 'Male', 212212252, '12/23/2017'),
(57, 5, '2', '', '', 'Male', 212221212, '12/23/2017'),
(58, 9, '2', '', '', 'Male', 212221212, '12/23/2017'),
(59, 13, '2', '', '', 'Male', 212221212, '12/23/2017'),
(60, 1, '2', 'Sanjeeban', 'Nithusha', 'Male', 212221212, '12/24/2017'),
(71, 13, '2', 'Sanjee', 'Raja', 'Male', 212221212, '12/26/2017'),
(70, 5, '2', 'Vithushan', 'Thenuja', 'Male', 212221212, '12/26/2017'),
(63, 13, '2', '', '', 'Male', 212221212, '12/24/2017'),
(72, 13, '2', 'Sanjee', 'Sanjee', 'Male', 212221212, '12/26/2017'),
(73, 17, '2', 'Sanjee', 'Sanjee', 'Male', 212221212, '12/26/2017'),
(74, 9, '2', 'Thenuja', 'Loosu', 'Male', 212221212, '12/26/2017'),
(75, 13, '2', 'Thenuja', 'Loosu', 'Male', 212221212, '12/26/2017');

-- --------------------------------------------------------

--
-- Table structure for table `bustype`
--

DROP TABLE IF EXISTS `bustype`;
CREATE TABLE IF NOT EXISTS `bustype` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bustype`
--

INSERT INTO `bustype` (`id`, `Type`) VALUES
(1, 'Luxary'),
(2, 'Semi Luxary');

-- --------------------------------------------------------

--
-- Table structure for table `route`
--

DROP TABLE IF EXISTS `route`;
CREATE TABLE IF NOT EXISTS `route` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `route` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `route`
--

INSERT INTO `route` (`Id`, `route`) VALUES
(1, 'Wellawatha'),
(2, 'Colombo'),
(3, 'Kattunayaka'),
(4, 'Negombo'),
(5, 'Chilaw'),
(6, 'Puttalam'),
(7, 'Anuradhapura'),
(8, 'Madawachiya'),
(9, 'Vavuniya'),
(10, 'Puliyankulam'),
(11, 'Kilinochchi'),
(12, 'Parantan'),
(13, 'Palai'),
(14, 'Chavakachcheri'),
(15, 'Jaffna'),
(16, 'Pointpedro');

-- --------------------------------------------------------

--
-- Table structure for table `travel`
--

DROP TABLE IF EXISTS `travel`;
CREATE TABLE IF NOT EXISTS `travel` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `busName` varchar(20) NOT NULL,
  `busFrom` varchar(20) NOT NULL,
  `busTo` varchar(20) NOT NULL,
  `Time` varchar(10) NOT NULL,
  `busType` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `travel`
--

INSERT INTO `travel` (`id`, `busName`, `busFrom`, `busTo`, `Time`, `busType`) VALUES
(1, 'VTBus', 'Jaffna', 'Colombo', '6.00PM', 'Luxary'),
(2, 'VTBus', 'Colombo', 'Jaffna', '6.00PM', 'Luxary'),
(3, 'NS Bus', 'Jaffna', 'Colombo', '8.00 PM', 'Semi Luxary');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'sanjee', 'sanjee'),
(2, 'vithu', 'vithu');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
