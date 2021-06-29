-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 29, 2021 at 05:45 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cakestore`
--
CREATE DATABASE IF NOT EXISTS `cakestore` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `cakestore`;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
  `lastname` text DEFAULT NULL,
  `firstname` text DEFAULT NULL,
  `username` text DEFAULT NULL,
  `password` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `lastname`, `firstname`, `username`, `password`) VALUES
(3, 'Pandan Gwapo', 'James', 'jj', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL,
  `price` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`id`, `name`, `price`) VALUES
(7, 'Ginger Bread', 500),
(10, 'Lava Cake', 600),
(11, 'Salmon Cake', 800);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `id` int(11) NOT NULL,
  `transaction_date` date DEFAULT current_timestamp(),
  `employee_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`id`, `transaction_date`, `employee_id`) VALUES
(10, '2021-06-28', 3),
(11, '2021-06-28', 3),
(12, '2021-06-28', 3),
(13, '2021-06-28', 3),
(14, '2021-06-28', 3),
(15, '2021-06-28', 3),
(16, '2021-06-28', 3),
(17, '2021-06-28', 3),
(18, '2021-06-28', 3);

-- --------------------------------------------------------

--
-- Table structure for table `transaction_details`
--

CREATE TABLE `transaction_details` (
  `id` int(11) NOT NULL,
  `transaction_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaction_details`
--

INSERT INTO `transaction_details` (`id`, `transaction_id`, `item_id`, `qty`) VALUES
(11, 13, 11, 1),
(12, 14, 11, 1),
(13, 15, 11, 1),
(14, 15, 10, 1),
(15, 16, 11, 1),
(16, 16, 10, 1),
(17, 17, 11, 1),
(18, 17, 7, 1),
(19, 18, 11, 1),
(20, 18, 11, 1),
(21, 18, 11, 1),
(22, 18, 11, 1),
(23, 18, 11, 1),
(24, 18, 11, 1),
(25, 18, 11, 1),
(26, 18, 11, 1),
(27, 18, 11, 1),
(28, 18, 11, 1),
(29, 18, 11, 1),
(30, 18, 11, 1),
(31, 18, 11, 1);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwtransactions`
-- (See below for the actual view)
--
CREATE TABLE `vwtransactions` (
`id` int(11)
,`transaction_date` date
,`Employee` mediumtext
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwtransactionsdetails`
-- (See below for the actual view)
--
CREATE TABLE `vwtransactionsdetails` (
`transaction_id` int(11)
,`item_id` int(11)
,`name` text
,`qty` int(11)
,`subtotal` double
);

-- --------------------------------------------------------

--
-- Structure for view `vwtransactions`
--
DROP TABLE IF EXISTS `vwtransactions`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwtransactions`  AS SELECT `transactions`.`id` AS `id`, `transactions`.`transaction_date` AS `transaction_date`, concat(`employee`.`lastname`,', ',`employee`.`firstname`) AS `Employee` FROM (`transactions` join `employee` on(`transactions`.`employee_id` = `employee`.`id`)) ;

-- --------------------------------------------------------

--
-- Structure for view `vwtransactionsdetails`
--
DROP TABLE IF EXISTS `vwtransactionsdetails`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwtransactionsdetails`  AS SELECT `transaction_details`.`transaction_id` AS `transaction_id`, `transaction_details`.`item_id` AS `item_id`, `items`.`name` AS `name`, `transaction_details`.`qty` AS `qty`, `items`.`price`* `transaction_details`.`qty` AS `subtotal` FROM (`transaction_details` join `items` on(`transaction_details`.`item_id` = `items`.`id`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id` (`id`),
  ADD KEY `id_2` (`id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- Indexes for table `transaction_details`
--
ALTER TABLE `transaction_details`
  ADD PRIMARY KEY (`id`),
  ADD KEY `item_id` (`item_id`),
  ADD KEY `transaction_id` (`transaction_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `transaction_details`
--
ALTER TABLE `transaction_details`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
