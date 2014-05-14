-- phpMyAdmin SQL Dump
-- version 4.0.7
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 27, 2013 at 09:58 PM
-- Server version: 5.5.32
-- PHP Version: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `books`
--

-- --------------------------------------------------------

--
-- Table structure for table `authors`
--

CREATE TABLE IF NOT EXISTS `authors` (
  `author_id` int(11) NOT NULL AUTO_INCREMENT,
  `author_name` varchar(250) NOT NULL,
  PRIMARY KEY (`author_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `authors`
--

INSERT INTO `authors` (`author_id`, `author_name`) VALUES
(1, 'Geo Milev'),
(2, 'Ivan Vazov'),
(3, 'Hristo Botew'),
(4, 'Leda Mileva'),
(5, 'Пущкин'),
(6, 'Swetlin Nakow'),
(7, 'Mitio Pishtowa'),
(8, 'Pesho Kalashnika'),
(10, 'Pesho Karatista');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE IF NOT EXISTS `books` (
  `book_id` int(11) NOT NULL AUTO_INCREMENT,
  `book_title` varchar(250) NOT NULL,
  PRIMARY KEY (`book_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=20 ;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`book_id`, `book_title`) VALUES
(4, 'Hronikite na ridik'),
(7, 'Sancho pansa'),
(8, 'Matricata'),
(1, 'Harry Potter'),
(10, 'Lubovta e vsichko'),
(11, 'Liubov i Omraza'),
(12, 'Vodata e Zlato'),
(13, 'Kniga za jivota'),
(14, 'Jivota i horata'),
(15, 'sdafasd'),
(16, 'sfasfsa'),
(17, 'dsafas'),
(18, 'Knigaaaaa'),
(19, '++Alkoholizirane');

-- --------------------------------------------------------

--
-- Table structure for table `books_authors`
--

CREATE TABLE IF NOT EXISTS `books_authors` (
  `book_id` int(11) NOT NULL,
  `author_id` int(11) NOT NULL,
  KEY `book_id` (`book_id`),
  KEY `author_id` (`author_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `books_authors`
--

INSERT INTO `books_authors` (`book_id`, `author_id`) VALUES
(1, 2),
(1, 1),
(4, 4),
(4, 3),
(17, 8),
(18, 3),
(18, 4),
(18, 7),
(18, 8),
(19, 6),
(19, 7),
(19, 10);

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE IF NOT EXISTS `comments` (
  `book_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `comment` varchar(250) NOT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`date`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`book_id`, `user_id`, `comment`, `date`) VALUES
(18, 1, 'Hello my comment number 3', '2013-10-27 18:50:07'),
(18, 4, 'Hello one more comment', '2013-10-27 18:52:42'),
(18, 1, 'I''m a comment number 1', '2013-10-27 17:46:00'),
(18, 1, 'I''m a comment number 2', '2013-10-27 17:46:19'),
(18, 3, 'One more comment', '2013-10-27 19:31:08'),
(18, 2, 'Oshte edin komentar', '2013-10-27 19:34:40'),
(18, 2, 'Hello my try comment', '2013-10-27 19:34:56'),
(18, 1, 'Hello my real me', '2013-10-27 19:37:37'),
(19, 1, 'This book is bulshit', '2013-10-27 19:38:32'),
(4, 1, 'hello', '2013-10-27 20:54:07');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(40) NOT NULL,
  `user_pass` varchar(40) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_name`, `user_pass`) VALUES
(1, 'iliyan', 'kafedzhiev'),
(2, 'admin', 'qwerty'),
(3, 'vladislav', 'kochanow'),
(4, 'pacoo', 'parcalaaa');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
