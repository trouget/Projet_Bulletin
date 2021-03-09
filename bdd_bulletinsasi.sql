-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3308
-- Généré le :  mar. 09 mars 2021 à 13:00
-- Version du serveur :  8.0.18
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdd_bulletinsasi`
--

-- --------------------------------------------------------

--
-- Structure de la table `annee1`
--

DROP TABLE IF EXISTS `annee1`;
CREATE TABLE IF NOT EXISTS `annee1` (
  `id_bulletin1` int(11) NOT NULL AUTO_INCREMENT,
  `Moyenne1` int(11) DEFAULT NULL,
  `Administration_réseau` int(11) DEFAULT NULL,
  `Anglais_technique` int(11) DEFAULT NULL,
  `Base_de_données` int(11) DEFAULT NULL,
  `Communication_écrite` int(11) DEFAULT NULL,
  `Conception_et_modélisation` int(11) DEFAULT NULL,
  `Controle_de_gestion` int(11) DEFAULT NULL,
  `Gestion_de_projet` int(11) DEFAULT NULL,
  `Infrastructure_et_scripting` int(11) DEFAULT NULL,
  `JSE` int(11) DEFAULT NULL,
  `Securite` int(11) DEFAULT NULL,
  `Systeme_open_source` int(11) DEFAULT NULL,
  `Systeme_proprietaire` int(11) DEFAULT NULL,
  `Technologie_web_dynamique` int(11) DEFAULT NULL,
  `Droit_informatique` int(11) DEFAULT NULL,
  `Framework_web` int(11) DEFAULT NULL,
  `Outils_mathematiques` int(11) DEFAULT NULL,
  `Livret_de_suivi` int(11) DEFAULT NULL,
  `Management` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bulletin1`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `annee2`
--

DROP TABLE IF EXISTS `annee2`;
CREATE TABLE IF NOT EXISTS `annee2` (
  `id_bulletin2` int(11) NOT NULL AUTO_INCREMENT,
  `Moyenne2` int(11) NOT NULL DEFAULT '0',
  `Administration_reseau` int(11) DEFAULT NULL,
  `Anglais_technique` int(11) DEFAULT NULL,
  `Application_hybride` int(11) DEFAULT NULL,
  `Droit_informatique` int(11) DEFAULT NULL,
  `Infrastructure_et_scripting` int(11) DEFAULT NULL,
  `JEE` int(11) DEFAULT NULL,
  `Outils_mathematiques` int(11) DEFAULT NULL,
  `Securite` int(11) DEFAULT NULL,
  `Suivi_de_projet` int(11) DEFAULT NULL,
  `Systeme_open_source` int(11) DEFAULT NULL,
  `Systeme_proprietaire` int(11) DEFAULT NULL,
  `Technologie_web_dynamique` int(11) DEFAULT NULL,
  `Deploiement_serveur` int(11) DEFAULT NULL,
  `Big_data` int(11) DEFAULT NULL,
  `Arduino` int(11) DEFAULT NULL,
  `Projet` int(11) DEFAULT NULL,
  `Livret_de_suivi` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_bulletin2`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `eleves`
--

DROP TABLE IF EXISTS `eleves`;
CREATE TABLE IF NOT EXISTS `eleves` (
  `id_eleve` int(11) NOT NULL AUTO_INCREMENT,
  `Moyenne_annee1` int(11) NOT NULL DEFAULT '0',
  `Moyenne_annee2` int(11) NOT NULL DEFAULT '0',
  `nom` char(50) DEFAULT NULL,
  `prenom` char(50) DEFAULT NULL,
  `promotion` char(50) DEFAULT NULL,
  `annee` date DEFAULT NULL,
  `obtention` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`id_eleve`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `eleves`
--

INSERT INTO `eleves` (`id_eleve`, `Moyenne_annee1`, `Moyenne_annee2`, `nom`, `prenom`, `promotion`, `annee`, `obtention`) VALUES
(1, 0, 0, 'gerard', 'dupont', 'asi1', '2021-02-03', 0),
(2, 0, 0, 'gerard', 'dupont', 'asi1', '2021-02-11', 0),
(3, 0, 0, 'gerard', 'dupont', 'asi1', '2021-02-11', 0),
(4, 16, 12, 'toto', 'dupont', 'asi2', '2021-02-11', 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
