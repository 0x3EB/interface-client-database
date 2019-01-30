-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  Dim 04 nov. 2018 à 21:21
-- Version du serveur :  10.1.35-MariaDB
-- Version de PHP :  7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `sml_databse`
--

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` char(32) NOT NULL,
  `question` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL DEFAULT 'CLIENT',
  `expired_password_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `last_verif_code` varchar(255) NOT NULL,
  `activated` varchar(255) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `lastname`, `name`, `email`, `username`, `password`, `question`, `role`, `expired_password_date`, `last_verif_code`, `activated`) VALUES
(1, 'admin', 'admin', 'admin@sml.fr', 'admin', '21232f297a57a5a743894a0e4a801fc3', '', 'ADMIN', NULL, '', '0'),
(4, 'Turio', 'Julien', 'jturio@gmail.com', 'Jturio', '990ACB1EE1512AF2E62DB28CE426C252', 'Rex', 'CLIENT', '2018-10-11 22:20:15', '', '0'),
(10, 'lejeune', 'sebastien', 'sebastien.lejeune6@gmail.com', 'sml', '990ACB1EE1512AF2E62DB28CE426C252', 'Jack', 'CLIENT', '2018-10-13 15:27:38', 'V1Q2EA', '1');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
