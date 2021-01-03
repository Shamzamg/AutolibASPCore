-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Client: localhost
-- GÃ©nÃ©rÃ© le: Ven 06 DÃ©cembre 2013 Ã  10:32
-- Version du serveur: 5.6.12-log
-- Version de PHP: 5.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de donnÃ©es: `autolib`
--
CREATE DATABASE IF NOT EXISTS `autolib` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `autolib`;

-- --------------------------------------------------------

--
-- Structure de la table `borne`
--

CREATE TABLE IF NOT EXISTS `borne` (
  `idBorne` int(11) NOT NULL AUTO_INCREMENT,
  `etatBorne` tinyint(1) NOT NULL,
  `station` int(11) NOT NULL,
  `idVehicule` int(11) DEFAULT NULL,
  PRIMARY KEY (`idBorne`),
  KEY `fk_Borne_Station1_idx` (`station`),
  KEY `fk_Borne_Vehicule1_idx` (`idVehicule`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=179 ;

--
-- Contenu de la table `borne`
--

INSERT INTO `borne` (`idBorne`, `etatBorne`, `station`, `idVehicule`) VALUES
(1, 0, 1, 1),
(2, 0, 1, 2),
(3, 1, 1, NULL),
(4, 1, 1, NULL),
(5, 0, 2, 3),
(6, 0, 2, 4),
(7, 0, 2, 5),
(8, 1, 2, NULL),
(9, 1, 2, NULL),
(10, 1, 2, NULL),
(11, 0, 3, 6),
(12, 0, 3, 7),
(13, 1, 3, NULL),
(14, 1, 3, NULL),
(15, 0, 4, 8),
(16, 0, 4, 9),
(17, 1, 4, NULL),
(18, 1, 4, NULL),
(19, 0, 5, 10),
(20, 0, 5, 11),
(21, 1, 5, NULL),
(22, 1, 5, NULL),
(23, 0, 6, 12),
(24, 0, 6, 13),
(25, 1, 6, NULL),
(26, 1, 6, NULL),
(27, 0, 7, 14),
(28, 0, 7, 15),
(29, 1, 7, NULL),
(30, 1, 7, NULL),
(31, 0, 8, 16),
(32, 0, 8, 17),
(33, 1, 8, NULL),
(34, 1, 8, NULL),
(35, 0, 9, 18),
(36, 0, 9, 19),
(37, 0, 9, 20),
(38, 1, 9, NULL),
(39, 1, 9, NULL),
(40, 1, 9, NULL),
(41, 0, 10, 21),
(42, 0, 10, 22),
(43, 0, 10, 23),
(44, 0, 10, 24),
(45, 1, 10, NULL),
(46, 1, 10, NULL),
(47, 1, 10, NULL),
(48, 1, 10, NULL),
(49, 0, 11, 25),
(50, 1, 11, NULL),
(51, 0, 12, 26),
(52, 0, 12, 27),
(53, 0, 12, 28),
(54, 1, 12, NULL),
(55, 1, 12, NULL),
(56, 1, 12, NULL),
(57, 0, 13, 29),
(58, 0, 13, 30),
(59, 0, 13, 31),
(60, 1, 13, NULL),
(61, 1, 13, NULL),
(62, 1, 13, NULL),
(63, 0, 14, 32),
(64, 0, 14, 33),
(65, 1, 14, NULL),
(66, 1, 14, NULL),
(67, 0, 15, 34),
(68, 0, 15, 35),
(69, 1, 15, NULL),
(70, 1, 15, NULL),
(71, 0, 16, 36),
(72, 0, 16, 37),
(73, 0, 16, 38),
(74, 0, 16, 39),
(75, 0, 16, 40),
(76, 1, 16, NULL),
(77, 1, 16, NULL),
(78, 1, 16, NULL),
(79, 1, 16, NULL),
(80, 1, 16, NULL),
(81, 0, 17, 41),
(82, 0, 17, 42),
(83, 0, 17, 43),
(84, 0, 17, 44),
(85, 1, 17, NULL),
(86, 1, 17, NULL),
(87, 1, 17, NULL),
(88, 1, 17, NULL),
(89, 0, 18, 45),
(90, 0, 18, 46),
(91, 0, 18, 47),
(92, 1, 18, NULL),
(93, 1, 18, NULL),
(94, 1, 18, NULL),
(95, 0, 19, 48),
(96, 0, 19, 49),
(97, 1, 19, NULL),
(98, 1, 19, NULL),
(99, 0, 20, 50),
(100, 0, 20, 51),
(101, 1, 20, NULL),
(102, 1, 20, NULL),
(103, 0, 21, 52),
(104, 0, 21, 53),
(105, 1, 21, NULL),
(106, 1, 21, NULL),
(107, 0, 22, 54),
(108, 0, 22, 55),
(109, 1, 22, NULL),
(110, 1, 22, NULL),
(111, 0, 23, 56),
(112, 0, 23, 57),
(113, 0, 23, 58),
(114, 1, 23, NULL),
(115, 1, 23, NULL),
(116, 1, 23, NULL),
(117, 0, 24, 59),
(118, 0, 24, 60),
(119, 0, 24, 61),
(120, 1, 24, NULL),
(121, 1, 24, NULL),
(122, 1, 24, NULL),
(123, 0, 25, 62),
(124, 0, 25, 63),
(125, 0, 25, 64),
(126, 1, 25, NULL),
(127, 1, 25, NULL),
(128, 1, 25, NULL),
(129, 0, 26, 65),
(130, 1, 26, NULL),
(131, 0, 27, 66),
(132, 0, 27, 67),
(133, 1, 27, NULL),
(134, 1, 27, NULL),
(135, 0, 28, 68),
(136, 0, 28, 69),
(137, 0, 28, 70),
(138, 1, 28, NULL),
(139, 1, 28, NULL),
(140, 1, 28, NULL),
(141, 0, 29, 71),
(142, 0, 29, 72),
(143, 1, 29, NULL),
(144, 1, 29, NULL),
(145, 0, 30, 73),
(146, 0, 30, 74),
(147, 0, 30, 75),
(148, 1, 30, NULL),
(149, 1, 30, NULL),
(150, 1, 30, NULL),
(151, 0, 31, 76),
(152, 0, 31, 77),
(153, 1, 31, NULL),
(154, 1, 31, NULL),
(155, 0, 32, 78),
(156, 0, 32, 79),
(157, 1, 32, NULL),
(158, 1, 32, NULL),
(159, 0, 33, 80),
(160, 0, 33, 81),
(161, 1, 33, NULL),
(162, 1, 33, NULL),
(163, 0, 34, 82),
(164, 0, 34, 83),
(165, 0, 34, 84),
(166, 0, 34, 85),
(167, 0, 34, 86),
(168, 0, 34, 87),
(169, 1, 34, NULL),
(170, 1, 34, NULL),
(171, 1, 34, NULL),
(172, 1, 34, NULL),
(173, 1, 34, NULL),
(174, 1, 34, NULL),
(175, 0, 35, 88),
(176, 0, 35, 89),
(177, 1, 35, NULL),
(178, 1, 35, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `idClient` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(45) NOT NULL,
  `prenom` varchar(45) NOT NULL,
  `date_naissance` date DEFAULT NULL,
  `email` varchar(255) NOT NULL UNIQUE,
  `passwd` varchar(255) NOT NULL,
  PRIMARY KEY (`idClient`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=401 ;

--
-- Contenu de la table `client`
--

INSERT INTO `client` (`idClient`, `nom`, `prenom`, `date_naissance`, `email`, `passwd`) VALUES
(1, 'DUVERLIE', 'FRANCOISE', '1988-07-25', 'duverlie.francoise@mail.com', 'AQAAAAEAACcQAAAAEAHGINzuNwFDatNowpSI1eUAG+x1cgrQtYbjLZGj2pYCVlSHX+yoBVM5ROQwRrWlng=='),
(2, 'DUVAL', 'JEREMY', '1988-06-25', 'duval.jeremy@mail.com', 'AQAAAAEAACcQAAAAEAHGINzuNwFDatNowpSI1eUAG+x1cgrQtYbjLZGj2pYCVlSHX+yoBVM5ROQwRrWlng==');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE IF NOT EXISTS `reservation` (
  `vehicule` int(11) NOT NULL,
  `client` int(11) NOT NULL,
  `date_reservation` datetime NOT NULL,
  `date_echeance` datetime DEFAULT NULL,
  PRIMARY KEY (`vehicule`,`client`,`date_reservation`),
  KEY `fk_Reservation_Vehicule1_idx` (`vehicule`),
  KEY `fk_Reservation_Client1_idx` (`client`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `station`
--

CREATE TABLE IF NOT EXISTS `station` (
  `idStation` int(11) NOT NULL AUTO_INCREMENT,
  `latitude` decimal(9,6) NOT NULL,
  `longitude` decimal(9,6) NOT NULL,
  `adresse` varchar(200) DEFAULT NULL,
  `numero` int(11) DEFAULT NULL,
  `ville` varchar(100) DEFAULT NULL,
  `code_postal` int(11) DEFAULT NULL,
  PRIMARY KEY (`idStation`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=36 ;

--
-- Contenu de la table `station`
--

INSERT INTO `station` (`idStation`, `latitude`, `longitude`, `adresse`, `numero`, `ville`, `code_postal`) VALUES
(1, '45.745013', '4.871353', 'Place Ambroise Courtois', 18, 'LYON', 69003),
(2, '45.756529', '4.835870', 'Place Antonin Poncet', 1, 'LYON', 69002),
(3, '45.736646', '4.869195', 'Place du 11 Novembre 1918', 1, 'LYON', 69008),
(4, '45.746291', '4.836518', 'Rue de Marseille', 99, 'LYON', 69007),
(5, '45.767066', '4.859037', 'Place Jules Ferry', 4, 'LYON', 69006),
(6, '45.750515', '4.828684', 'Place Carnot', 1, 'LYON', 69002),
(7, '45.759626', '4.831426', 'Place des Celestins', 11, 'LYON', 69001),
(8, '45.742935', '4.821108', 'Cours Charlemagne', 79, 'LYON', 69002),
(9, '45.770582', '4.863906', 'Cours Emile Zola', 25, 'VILLEURBANNE', 69100),
(10, '45.763898', '4.837211', 'Rue Antoine SallÃ¨s', 13, 'LYON', 69002),
(11, '45.763593', '4.837556', 'Rue Claudia', 18, 'LYON', 69002),
(12, '45.781623', '4.833029', 'Rue de Belfort', 79, 'LYON', 69004),
(13, '45.756493', '4.841091', 'Place Antonin Jutard', 1, 'LYON', 69003),
(14, '45.779842', '4.804396', 'Rue du 24 mars', 16, 'LYON', 69009),
(15, '45.766982', '4.804261', 'Rue de la Pépinière Royale', 1, 'LYON', 69009),
(16, '45.774699', '4.833476', 'Boulevard de la Croix-Rousse', 167, 'LYON', 69004),
(17, '45.768490', '4.836873', 'Place Louis Pradel', 1, 'LYON', 69001),
(18, '45.767306', '4.878818', 'Rue Michel Servet', 30, 'VILLEURBANNE', 69100),
(19, '45.736826', '4.836859', 'Avenue Jean Jaurès', 198, 'LYON', 69007),
(20, '45.746043', '4.841807', 'Place Jean Macé', 1, 'LYON', 69007),
(21, '45.763210', '4.851320', 'Rue Garibaldi', 156, 'LYON', 69003),
(22, '45.756331', '4.878070', 'Rue Jean Jaurès', 3, 'VILLEURBANNE', 69100),
(23, '45.768299', '4.843074', 'Place du Maréchal Lyautey', 11, 'LYON', 69006),
(24, '45.760181', '4.863023', 'Rue Maurice Flandin', 33, 'LYON', 69003),
(25, '45.760573', '4.857305', 'Rue Servient', 1, 'LYON', 69003),
(26, '45.756497', '4.796727', 'Place des Compagnons de la Chansons', 1, 'LYON', 69005),
(27, '45.760683', '4.835688', 'Rue de la République', 53, 'LYON', 69002),
(28, '45.762946', '4.832010', 'Quai Saint-Antoine', 1, 'LYON', 69002),
(29, '45.758435', '4.826310', 'Place Benoït Crepu', 6, 'LYON', 69005),
(30, '45.761159', '4.828415', 'Quai Romain Rolland', 25, 'LYON', 69005),
(31, '45.757101', '4.815734', 'Rue Trion', 40, 'LYON', 69005),
(32, '45.768823', '4.830700', 'Place Sathonay', 5, 'LYON', 69001),
(33, '45.760267', '4.845699', 'Avenue Maréchal de Saxe', 91, 'LYON', 69003),
(34, '45.767139', '4.833873', 'Place des Terreaux', 23, 'LYON', 69001),
(35, '45.775182', '4.805386', 'Rue du Sergent Michel Berthet', 2, 'LYON', 69009);

-- --------------------------------------------------------

--
-- Structure de la table `type_vehicule`
--

CREATE TABLE IF NOT EXISTS `type_vehicule` (
  `idType_vehicule` int(11) NOT NULL AUTO_INCREMENT,
  `categorie` varchar(45) NOT NULL,
  `type_vehicule` varchar(45) NOT NULL,
  `image_vehicule` varchar(45) NOT NULL,
  PRIMARY KEY (`idType_vehicule`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Contenu de la table `type_vehicule`
--

INSERT INTO `type_vehicule` (`idType_vehicule`, `categorie`, `type_vehicule`, `image_vehicule`) VALUES
(1, 'Petite citadine', 'CitroÃ«n C1', '/images/citroenc1.png'),
(2, 'Petite citadine', 'Toyota Aygo', '/images/toyotaaygo.png'),
(3, 'Utilitaire', 'CitroÃ«n Berlingo', '/images/citroenberlingo.png'),
(4, 'Utilitaire', 'CitroÃ«n Berlingo PRM', '/images/citroenberlingo.png'),
(5, 'Utilitaire', 'Nissan Evalia', '/images/nissanevalia.png'),
(6, 'Compacte', 'Toyota Yaris', '/images/toyotayaris.png'),
(7, 'Familliale', 'C4 Picasso', '/images/c4picasso.png'),
(8, 'Familliale', 'Toyota Verso', '/images/toyotaverso.png');

-- --------------------------------------------------------

--
-- Structure de la table `utilise`
--

CREATE TABLE IF NOT EXISTS `utilise` (
  `Vehicule` int(11) NOT NULL,
  `Client` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `borne_depart` int(11) NOT NULL,
  `borne_arrivee` int(11),
  PRIMARY KEY (`Vehicule`,`Client`,`date`),
  KEY `fk_table1_Client1_idx` (`Client`),
  KEY `fk_utilise_Borne1_idx` (`borne_depart`),
  KEY `fk_utilise_Borne2_idx` (`borne_arrivee`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE  `utilise` CHANGE  `borne_arrivee`  `borne_arrivee` INT( 11 ) NULL DEFAULT NULL ;
-- --------------------------------------------------------

--
-- Structure de la table `vehicule`
--

CREATE TABLE IF NOT EXISTS `vehicule` (
  `idVehicule` int(11) NOT NULL AUTO_INCREMENT,
  `RFID` int(11) NOT NULL,
  `etatBatterie` int(11) DEFAULT NULL,
  `Disponibilite` varchar(45) NOT NULL,
  `latitude` decimal(9,6) DEFAULT NULL,
  `longitude` decimal(9,6) DEFAULT NULL,
  `type_vehicule` int(11) NOT NULL,
  PRIMARY KEY (`idVehicule`),
  UNIQUE KEY `RFID_UNIQUE` (`RFID`),
  KEY `fk_Vehicule_Type_vehicule1_idx` (`type_vehicule`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=90 ;

--
-- Contenu de la table `vehicule`
--

INSERT INTO `vehicule` (`idVehicule`, `RFID`, `etatBatterie`, `Disponibilite`, `latitude`, `longitude`, `type_vehicule`) VALUES
(1, 1234567891, 100, 'LIBRE', '45.745013', '4.871353', 2),
(2, 1234567892, 100, 'LIBRE', '45.745013', '4.871353', 2),
(3, 1234567893, 100, 'LIBRE', '45.756529', '4.835870', 2),
(4, 1234567894, 100, 'LIBRE', '45.756529', '4.835870', 2),
(5, 1234567895, 100, 'LIBRE', '45.756529', '4.835870', 3),
(6, 1234567896, 100, 'LIBRE', '45.736646', '4.869195', 2),
(7, 1234567897, 100, 'LIBRE', '45.736646', '4.869195', 2),
(8, 1234567898, 100, 'LIBRE', '45.746291', '4.836518', 2),
(9, 1234567899, 100, 'LIBRE', '45.746291', '4.836518', 5),
(10, 1234567900, 100, 'LIBRE', '45.767066', '4.859037', 2),
(11, 1234567901, 100, 'LIBRE', '45.767066', '4.859037', 2),
(12, 1234567902, 100, 'LIBRE', '45.750515', '4.828684', 2),
(13, 1234567903, 100, 'LIBRE', '45.750515', '4.828684', 2),
(14, 1234567904, 100, 'LIBRE', '45.759626', '4.831426', 1),
(15, 1234567905, 100, 'LIBRE', '45.759626', '4.831426', 2),
(16, 1234567906, 100, 'LIBRE', '45.742935', '4.821108', 2),
(17, 1234567907, 100, 'LIBRE', '45.742935', '4.821108', 2),
(18, 1234567908, 100, 'LIBRE', '45.770582', '4.863906', 2),
(19, 1234567909, 100, 'LIBRE', '45.770582', '4.863906', 2),
(20, 1234567910, 100, 'LIBRE', '45.770582', '4.863906', 2),
(21, 1234567911, 100, 'LIBRE', '45.763898', '4.837211', 2),
(22, 1234567912, 100, 'LIBRE', '45.763898', '4.837211', 2),
(23, 1234567913, 100, 'LIBRE', '45.763898', '4.837211', 5),
(24, 1234567914, 100, 'LIBRE', '45.763898', '4.837211', 6),
(25, 1234567915, 100, 'LIBRE', '45.763593', '4.837556', 4),
(26, 1234567916, 100, 'LIBRE', '45.781623', '4.833029', 2),
(27, 1234567917, 100, 'LIBRE', '45.781623', '4.833029', 5),
(28, 1234567918, 100, 'LIBRE', '45.781623', '4.833029', 6),
(29, 1234567919, 100, 'LIBRE', '45.756493', '4.841091', 2),
(30, 1234567920, 100, 'LIBRE', '45.756493', '4.841091', 2),
(31, 1234567921, 100, 'LIBRE', '45.756493', '4.841091', 8),
(32, 1234567922, 100, 'LIBRE', '45.779842', '4.804396', 2),
(33, 1234567923, 100, 'LIBRE', '45.779842', '4.804396', 2),
(34, 1234567924, 100, 'LIBRE', '45.766982', '4.804261', 2),
(35, 1234567925, 100, 'LIBRE', '45.766982', '4.804261', 2),
(36, 1234567926, 100, 'LIBRE', '45.774699', '4.833476', 2),
(37, 1234567927, 100, 'LIBRE', '45.774699', '4.833476', 2),
(38, 1234567928, 100, 'LIBRE', '45.774699', '4.833476', 2),
(39, 1234567929, 100, 'LIBRE', '45.774699', '4.833476', 3),
(40, 1234567930, 100, 'LIBRE', '45.774699', '4.833476', 6),
(41, 1234567931, 100, 'LIBRE', '45.768490', '4.836873', 2),
(42, 1234567932, 100, 'LIBRE', '45.768490', '4.836873', 2),
(43, 1234567933, 100, 'LIBRE', '45.768490', '4.836873', 2),
(44, 1234567934, 100, 'LIBRE', '45.768490', '4.836873', 5),
(45, 1234567935, 100, 'LIBRE', '45.768490', '4.836873', 8),
(46, 1234567936, 100, 'LIBRE', '45.767306', '4.878818', 2),
(47, 1234567937, 100, 'LIBRE', '45.767306', '4.878818', 2),
(48, 1234567938, 100, 'LIBRE', '45.767306', '4.878818', 5),
(49, 1234567939, 100, 'LIBRE', '45.736826', '4.836859', 2),
(50, 1234567940, 100, 'LIBRE', '45.736826', '4.836859', 2),
(51, 1234567941, 100, 'LIBRE', '45.746043', '4.841807', 2),
(52, 1234567942, 100, 'LIBRE', '45.746043', '4.841807', 2),
(53, 1234567943, 100, 'LIBRE', '45.763210', '4.851320', 2),
(54, 1234567944, 100, 'LIBRE', '45.763210', '4.851320', 6),
(55, 1234567945, 100, 'LIBRE', '45.756331', '4.878070', 2),
(56, 1234567946, 100, 'LIBRE', '45.756331', '4.878070', 2),
(57, 1234567947, 100, 'LIBRE', '45.768299', '4.843074', 1),
(58, 1234567948, 100, 'LIBRE', '45.768299', '4.843074', 2),
(59, 1234567949, 100, 'LIBRE', '45.768299', '4.843074', 6),
(60, 1234567950, 100, 'LIBRE', '45.760181', '4.863023', 2),
(61, 1234567951, 100, 'LIBRE', '45.760181', '4.863023', 1),
(62, 1234567952, 100, 'LIBRE', '45.760181', '4.863023', 8),
(63, 1234567953, 100, 'LIBRE', '45.760573', '4.857305', 2),
(64, 1234567954, 100, 'LIBRE', '45.760573', '4.857305', 2),
(65, 1234567955, 100, 'LIBRE', '45.760573', '4.857305', 7),
(66, 1234567956, 100, 'LIBRE', '45.756497', '4.796727', 2),
(67, 1234567957, 100, 'LIBRE', '45.760683', '4.835688', 2),
(68, 1234567958, 100, 'LIBRE', '45.760683', '4.835688', 6),
(69, 1234567959, 100, 'LIBRE', '45.762946', '4.832010', 1),
(70, 1234567960, 100, 'LIBRE', '45.762946', '4.832010', 3),
(71, 1234567961, 100, 'LIBRE', '45.762946', '4.832010', 8),
(72, 1234567962, 100, 'LIBRE', '45.758435', '4.826310', 2),
(73, 1234567963, 100, 'LIBRE', '45.758435', '4.826310', 3),
(74, 1234567964, 100, 'LIBRE', '45.761159', '4.828415', 2),
(75, 1234567965, 100, 'LIBRE', '45.761159', '4.828415', 2),
(76, 1234567966, 100, 'LIBRE', '45.761159', '4.828415', 6),
(77, 1234567967, 100, 'LIBRE', '45.757101', '4.815734', 2),
(78, 1234567968, 100, 'LIBRE', '45.757101', '4.815734', 2),
(79, 1234567969, 100, 'LIBRE', '45.768823', '4.830700', 2),
(80, 1234567970, 100, 'LIBRE', '45.768823', '4.830700', 2),
(81, 1234567971, 100, 'LIBRE', '45.760267', '4.845699', 2),
(82, 1234567972, 100, 'LIBRE', '45.760267', '4.845699', 2),
(83, 1234567973, 100, 'LIBRE', '45.767139', '4.833873', 2),
(84, 1234567974, 100, 'LIBRE', '45.767139', '4.833873', 2),
(85, 1234567975, 100, 'LIBRE', '45.767139', '4.833873', 2),
(86, 1234567976, 100, 'LIBRE', '45.767139', '4.833873', 5),
(87, 1234567977, 100, 'LIBRE', '45.767139', '4.833873', 6),
(88, 1234567978, 100, 'LIBRE', '45.775182', '4.805386', 2),
(89, 1234567979, 100, 'LIBRE', '45.775182', '4.805386', 2);

--
-- Contraintes pour les tables exportÃ©es
--

--
-- Contraintes pour la table `borne`
--
ALTER TABLE `borne`
  ADD CONSTRAINT `fk_Borne_Station1` FOREIGN KEY (`station`) REFERENCES `station` (`idStation`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Borne_Vehicule1` FOREIGN KEY (`idVehicule`) REFERENCES `vehicule` (`idVehicule`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `fk_Reservation_Client1` FOREIGN KEY (`client`) REFERENCES `client` (`idClient`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Reservation_Vehicule1` FOREIGN KEY (`vehicule`) REFERENCES `vehicule` (`idVehicule`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `utilise`
--
ALTER TABLE `utilise`
  ADD CONSTRAINT `fk_table1_Client1` FOREIGN KEY (`Client`) REFERENCES `client` (`idClient`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_table1_Vehicule1` FOREIGN KEY (`Vehicule`) REFERENCES `vehicule` (`idVehicule`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_utilise_Borne1` FOREIGN KEY (`borne_depart`) REFERENCES `borne` (`idBorne`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_utilise_Borne2` FOREIGN KEY (`borne_arrivee`) REFERENCES `borne` (`idBorne`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `vehicule`
--
ALTER TABLE `vehicule`
  ADD CONSTRAINT `fk_Vehicule_Type_vehicule1` FOREIGN KEY (`type_vehicule`) REFERENCES `type_vehicule` (`idType_vehicule`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
