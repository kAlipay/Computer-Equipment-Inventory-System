-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 10, 2022 at 04:24 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_computerequipment`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblautonumber`
--

CREATE TABLE `tblautonumber` (
  `ID` int(11) NOT NULL,
  `STRT` varchar(30) NOT NULL,
  `END` varchar(30) NOT NULL,
  `INCREMENT` int(11) NOT NULL,
  `DESCRIPTION` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblautonumber`
--

INSERT INTO `tblautonumber` (`ID`, `STRT`, `END`, `INCREMENT`, `DESCRIPTION`) VALUES
(1, '00001', '75', 1, 'Customer'),
(4, '32302', '21', 1, 'StockIn'),
(5, '102201', '62', 1, 'StockOut'),
(26, 'p0000', '1', 1, 'panasonic'),
(29, 'E0000', '1', 1, 'Espiritu'),
(30, 'h0000', '1', 1, 'hhahahahahaha'),
(31, 'A0000', '1', 1, 'Asus'),
(32, 'K0000', '1', 1, 'Kingston'),
(33, 'H0000', '1', 1, 'HP'),
(34, 'A0000', '1', 1, 'Asus'),
(35, 'R0000', '1', 1, 'Ram 4 GB DDR3'),
(36, 'R0000', '1', 1, 'Ram 8 GB DDR4'),
(37, 'b0000', '1', 1, 'bayot'),
(38, 'h0000', '1', 1, 'hahahah'),
(39, 'R0000', '1', 1, 'RAM'),
(40, 'R0000', '1', 1, 'RJ 45'),
(41, 'U0000', '1', 1, 'UTP CAble 1 set'),
(42, 'M0000', '1', 1, 'Mother Board'),
(43, 'T0000', '1', 1, 'Trib'),
(44, 'R0000', '1', 1, 'Redge'),
(45, 'b0000', '1', 1, 'bayot'),
(46, 'F0000', '1', 1, 'Flash Drive'),
(47, 'Z0000', '1', 1, 'ZKT'),
(48, 'B0000', '1', 1, 'Biometric'),
(49, 'A0000', '1', 1, 'Acer'),
(50, 'P0000', '1', 1, 'PatchSee ');

-- --------------------------------------------------------

--
-- Table structure for table `tblbrand`
--

CREATE TABLE `tblbrand` (
  `ID` int(11) NOT NULL,
  `Brand` text NOT NULL,
  `Para` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbrand`
--

INSERT INTO `tblbrand` (`ID`, `Brand`, `Para`) VALUES
(23, 'Kingston', 'Category'),
(24, 'HP', 'Category'),
(25, 'Asus', 'Category'),
(26, 'Trib', 'Category'),
(29, 'ZKT', ''),
(30, 'Acer', ''),
(31, 'PatchSee ', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblitems`
--

CREATE TABLE `tblitems` (
  `ID` int(11) NOT NULL,
  `ItemID` varchar(90) DEFAULT NULL,
  `Name` varchar(90) DEFAULT NULL,
  `Description` varchar(90) DEFAULT NULL,
  `Brand` varchar(90) DEFAULT NULL,
  `Types` varchar(30) DEFAULT NULL,
  `Price` int(30) DEFAULT NULL,
  `Quantity` int(20) NOT NULL,
  `Unit` varchar(15) NOT NULL,
  `Type` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblitems`
--

INSERT INTO `tblitems` (`ID`, `ItemID`, `Name`, `Description`, `Brand`, `Types`, `Price`, `Quantity`, `Unit`, `Type`) VALUES
(55, '0000157', 'Acer Laptop', 'Laptop Computer for home', 'Acer', 'PC', 31000, 20, 'Box', 'Item'),
(56, '0000158', 'Asus Genesis R four thousand', 'laptop for home', 'Asus', 'Laptop', 65000, 173, 'Box', 'Item'),
(58, '0000160', 'Sony Laptop SVE11415FAW', 'Sony Laptop', 'Sony', 'Laptop', 50000, 17, 'Box', 'Item'),
(59, '0000161', 'Asus GTX 5000', 'Motherboard For PC', 'ASUS', 'MotherBoard', 5000, 42, 'Peices', 'Item'),
(60, '0000163', 'RJ 45', 'connect to pc to pc or lan', 'PatchSee ', 'RJ 45', 5, 4302, 'Peices', 'Item'),
(61, '0000174', 'ZKT Biometric 3900', 'Biometric for empoyee attendance', 'ZKT', 'Biometric', 5, 10, 'Box', 'Item');

-- --------------------------------------------------------

--
-- Table structure for table `tblparts`
--

CREATE TABLE `tblparts` (
  `ID` int(11) NOT NULL,
  `Parts` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblparts`
--

INSERT INTO `tblparts` (`ID`, `Parts`) VALUES
(26, 'Ram 8 GB DDR4'),
(29, 'Random Access Memory'),
(30, 'RJ 45'),
(31, 'UTP CAble 1 set'),
(32, 'Mother Board'),
(33, 'Flash Drive'),
(34, 'Biometric');

-- --------------------------------------------------------

--
-- Table structure for table `tblperson`
--

CREATE TABLE `tblperson` (
  `ID` int(11) NOT NULL,
  `CustomerID` varchar(90) DEFAULT NULL,
  `FirstName` varchar(90) DEFAULT NULL,
  `LastName` varchar(90) DEFAULT NULL,
  `MiddleName` varchar(90) DEFAULT NULL,
  `Gender` varchar(30) DEFAULT NULL,
  `Address` varchar(30) DEFAULT NULL,
  `Telephone` varchar(20) NOT NULL,
  `Mobile` int(15) NOT NULL,
  `EMail` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblperson`
--

INSERT INTO `tblperson` (`ID`, `CustomerID`, `FirstName`, `LastName`, `MiddleName`, `Gender`, `Address`, `Telephone`, `Mobile`, `EMail`, `TYPE`) VALUES
(26, '0000127', 'Lora Lyn', 'Abella', 'Gonzales', 'Female', 'purok 9 poblacion', '09000000000', 0, NULL, 'Customer'),
(33, '0000134', 'Shaira Rose', 'Abelanio', 'Laurete', 'Female', 'Purok 14 b valencia city bukid', '828-', 2147483647, 'Shairalaurete@yahoo.com', 'Customer'),
(34, '0000135', 'Czar', 'Del Rosario', 'Abella', 'Male', 'purok 9 poblacion valencia Cit', '888 8888', 0, '7777777777', 'Customer'),
(35, '0000136', 'clyde ', 'abelanio', 'richard', 'Male', 'purok 4a bagontaas Valencia Ci', '888 6594', 900000000, 'richard _abelanio@gmail.com', 'Customer'),
(36, '0000137', 'Stelvy Jul', 'Quilog', 'Devaras', 'Female', 'Purok 6 Poblacion, Valencia Ci', '999 9999', 99999999, 'stelvyjulquilog@yahoo.com', 'Customer'),
(37, '0000138', 'Kyla Erika', 'Tumbaga', 'Tomacas', 'Female', 'purok 10 poblacion butuan agus', '888 5555', 98753245, 'erikatumbaga@yahoomail.com', 'Customer'),
(38, '0000162', 'Clarice Jowin', 'Tolentino', 'MIssion', 'Female', 'Purok 6 Poblacion, Valencia Ci', '888 8888', 90000000, 'tolentinoclaricejowin@yahoo.co', 'Customer'),
(39, '0000164', 'Cherish', 'Tolentino', 'Mission', 'Female', 'purok 6a Poblacion Valencia Ci', '0915555555', 999999, 'cherishtolentino@yahoo.com', 'Customer'),
(40, '0000165', 'Dillan Sebastian', 'Monasque', 'Poryo', 'Male', 'bagontaas purok 3, valencia ci', '09144123', 999999, 'sebastian@gmail.com', 'Supplier'),
(41, '0000172', 'Anton', 'Dumadag', 'A', 'Male', 'Poblacion Valencia City bUkidn', '888 8888', 9000000, 'dumadaganton@gmail.com', 'Customer'),
(42, '0000173', 'Jan Christian', 'Merla', '.', 'Male', 'poblacion valencia city bukidn', '888 -9999', 2147483647, 'christianmerla@yahoo.com', 'Customer');

-- --------------------------------------------------------

--
-- Table structure for table `tblsettings`
--

CREATE TABLE `tblsettings` (
  `ID` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL,
  `PARA` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsettings`
--

INSERT INTO `tblsettings` (`ID`, `DESCRIPTION`, `PARA`) VALUES
(3, 'box', 'Unit'),
(6, 'PIPE', 'Category'),
(7, 'MOTORS MACHINE', 'Category'),
(8, 'BELT', 'Category'),
(9, 'ACCESORIES', 'Category'),
(10, 'BOLT', 'Category'),
(11, '', 'Category'),
(13, 'meter', 'Unit'),
(14, 'kilo', 'Unit');

-- --------------------------------------------------------

--
-- Table structure for table `tblstock_in_out`
--

CREATE TABLE `tblstock_in_out` (
  `StockOutID` int(11) NOT NULL,
  `TransactionNumber` varchar(30) NOT NULL,
  `ItemID` varchar(30) NOT NULL,
  `TransactionDate` date NOT NULL,
  `Quantity` int(11) NOT NULL,
  `TotalPrice` double NOT NULL,
  `SupplierCustomerID` varchar(30) NOT NULL,
  `Remarks` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstock_in_out`
--

INSERT INTO `tblstock_in_out` (`StockOutID`, `TransactionNumber`, `ItemID`, `TransactionDate`, `Quantity`, `TotalPrice`, `SupplierCustomerID`, `Remarks`) VALUES
(1, '', 'A00003', '2015-02-25', 50, 100, '', 'StockIn'),
(2, '4908731', 'A00003', '2015-02-25', 10, 1000, '1220117', 'StockOut'),
(3, '', 'M00001', '2015-02-25', 10, 2000, '', 'StockIn'),
(4, '', 'M00001', '2015-02-25', 50, 2000, '', 'StockIn'),
(5, '', 'M00002', '2015-02-25', 50, 2500, '', 'StockIn'),
(6, '', 'M00003', '2015-02-25', 45, 3000, '', 'StockIn'),
(7, '', 'M00002', '2015-02-25', 60, 2500, '', 'StockIn'),
(8, '', 'M00004', '2015-02-25', 50, 4500, '', 'StockIn'),
(9, '', 'M00005', '2015-02-25', 40, 10000, '', 'StockIn'),
(10, '', 'M00006', '2015-02-25', 40, 10500, '', 'StockIn'),
(11, '', 'M00007', '2015-02-25', 40, 10000, '', 'StockIn'),
(12, '', 'M00008', '2015-02-25', 30, 15000, '', 'StockIn'),
(13, '', 'M00009', '2015-02-25', 30, 5000, '', 'StockIn'),
(14, '', 'P00001', '2015-02-25', 15, 1200, '', 'StockIn'),
(15, '', 'P00002', '2015-02-25', 50, 100, '', 'StockIn'),
(16, '', 'P00001', '2015-02-25', 15, 1200, '', 'StockIn'),
(17, '', 'P00003', '2015-02-25', 50, 100, '', 'StockIn'),
(18, '', 'P00004', '2015-02-25', 30, 250, '', 'StockIn'),
(19, '', 'B00001', '2015-02-25', 55, 250, '', 'StockIn'),
(20, '', 'B00002', '2015-02-25', 60, 300, '', 'StockIn'),
(21, '', 'B00003', '2015-02-25', 65, 350, '', 'StockIn'),
(22, '', 'A00001', '2015-02-25', 30, 75, '', 'StockIn'),
(23, '', 'A00002', '2015-02-25', 30, 350, '', 'StockIn'),
(24, '', 'A00003', '2015-02-25', 35, 50, '', 'StockIn'),
(25, '', 'A00004', '2015-02-25', 20, 40, '', 'StockIn'),
(26, '', 'A00005', '2015-02-25', 15, 250, '', 'StockIn'),
(27, '', 'A00006', '2015-02-25', 200, 25, '', 'StockIn'),
(28, '', 'A00007', '2015-02-25', 200, 50, '', 'StockIn'),
(29, '', 'A00008', '2015-02-25', 50, 40, '', 'StockIn'),
(30, '', 'A00009', '2015-02-25', 100, 150, '', 'StockIn'),
(31, '', 'A000010', '2015-02-25', 50, 350, '', 'StockIn'),
(32, '', 'A000011', '2015-02-25', 300, 45, '', 'StockIn'),
(33, '', 'A000012', '2015-02-25', 200, 100, '', 'StockIn'),
(34, '', 'A000013', '2015-02-25', 200, 45, '', 'StockIn'),
(35, '', 'A000012', '2015-02-25', 200, 100, '', 'StockIn'),
(36, '', 'A00006', '2015-02-25', 200, 25, '', 'StockIn'),
(37, '', 'A000014', '2015-02-25', 40, 150, '', 'StockIn'),
(38, '', 'A000015', '2015-02-25', 200, 350, '', 'StockIn'),
(39, '', 'A000016', '2015-02-25', 250, 150, '', 'StockIn'),
(40, '', 'A000017', '2015-02-25', 400, 50, '', 'StockIn'),
(41, '', 'A000018', '2015-02-25', 300, 250, '', 'StockIn'),
(42, '1022011', 'M00004', '2015-02-25', 5, 22500, '000011', 'StockOut'),
(43, '1022012', 'A000011', '2015-02-25', 1, 45, '000011', 'StockOut'),
(44, '1022013', 'A00001', '2015-02-25', 2, 150, '000011', 'StockOut'),
(45, '1022014', 'A000012', '2015-02-25', 4, 400, '1220117', 'StockOut'),
(46, '1022014', 'A000013', '2015-02-25', 5, 225, '1220117', 'StockOut'),
(47, '1022015', 'A000011', '2015-02-25', 1, 45, '000011', 'StockOut'),
(48, '1022016', 'A000010', '2015-02-25', 2, 700, '000016', 'StockOut'),
(49, '1022017', 'B00002', '2015-02-26', 3, 900, '000016', 'StockOut'),
(50, '1022018', 'A000017', '2015-02-26', 0, 0, '000013', 'StockOut'),
(51, '1022019', 'M00002', '2015-02-26', 1, 2500, '0000110', 'StockOut'),
(52, '10220110', 'A00001', '2015-02-26', 1, 75, '000019', 'StockOut'),
(53, '', 'M000010', '2015-02-26', 100, 2000, '', 'StockIn'),
(54, '10220111', 'M000010', '2015-02-26', 5, 10000, '000011', 'StockOut'),
(55, '10220112', 'A00007', '2015-02-26', 2, 100, '000013', 'StockOut'),
(56, '10220113', 'A000017', '2015-02-26', 1, 50, '0000112', 'StockOut'),
(57, '10220114', 'A000012', '2015-02-26', 4, 400, '0000113', 'StockOut'),
(58, '10220115', 'A000012', '2015-02-26', 6, 600, '0000111', 'StockOut'),
(59, '10220116', 'A000011', '2015-02-26', 5, 225, '0000112', 'StockOut'),
(60, '', 'A000010', '2015-02-27', 40, 350, '', 'StockIn'),
(61, '', 'A000010', '2015-02-27', 85, 350, '', 'StockIn'),
(62, '', 'A000010', '2015-02-27', 170, 350, '', 'StockIn'),
(63, '', 'A00004', '2015-02-27', 30, 40, '', 'StockIn'),
(64, '10220117', 'M000010', '2015-02-27', 5, 10000, '0000112', 'StockOut'),
(65, '10220118', 'A000010', '2022-07-05', 0, 0, '0000114', 'StockOut'),
(66, '10220119', 'A000014', '2022-08-08', 0, 0, '000019', 'StockOut'),
(67, '10220119', 'A000015', '2022-08-08', 0, 0, '000019', 'StockOut'),
(68, '', '', '2022-08-10', 0, 0, '', 'StockIn'),
(69, '', 'M00008', '2022-08-10', 50, 0, '', 'StockIn'),
(70, '', 'P00004', '2022-08-10', 2, 35000, '', 'StockIn'),
(71, '', 'P00004', '2022-08-10', 2, 35000, '', 'StockIn'),
(72, '', 'P00004', '2022-08-10', 2, 35000, '', 'StockIn'),
(73, '', 'P00004', '2022-08-10', 36, 250, '', 'StockIn'),
(74, '', '', '2022-08-11', 0, 0, '', 'StockIn'),
(75, '', '', '2022-08-11', 0, 0, '', 'StockIn'),
(76, '', '', '2022-08-11', 0, 0, '', 'StockIn'),
(77, '3230215', '0000158', '2022-08-21', 3, 0, '', 'StockIn'),
(78, '3230216', '0000158', '2022-08-21', 70, 0, '', 'StockIn'),
(79, '3230217', '0000158', '2022-08-21', 76, 0, '', 'StockIn'),
(80, '3230218', '0000160', '2022-08-21', 10, 500000, '', 'StockIn'),
(81, '3230220', '0000161', '2022-08-21', 3, 15000, '', 'StockIn'),
(82, '10220119', '0000158', '2022-08-22', 0, 0, '0000136', 'StockOut'),
(83, '10220119', '0000161', '2022-08-22', 4, 5000, '0000138', 'StockOut'),
(84, '10220119', '0000161', '2022-08-22', 0, 0, '0000137', 'StockOut'),
(85, '10220120', '0000160', '2022-08-22', 3, 50000, '0000136', 'StockOut'),
(86, '10220121', '0000161', '2022-08-22', 1, 5000, '0000136', 'StockOut'),
(87, '10220121', '0000160', '2022-08-22', 2, 50000, '0000136', 'StockOut'),
(88, '10220122', '0000157', '2022-08-22', 2, 31, '0000134', 'StockOut'),
(89, '10220123', '0000157', '2022-08-22', 2, 31, '0000134', 'StockOut'),
(90, '10220124', '0000158', '2022-08-22', 1, 65000, '0000135', 'StockOut'),
(91, '10220124', '0000160', '2022-08-22', 4, 200000, '0000135', 'StockOut'),
(92, '10220125', '0000158', '2022-08-22', 1, 65000, '0000134', 'StockOut'),
(93, '10220126', '0000157', '2022-08-22', 3, 31, '0000134', 'StockIn'),
(94, '10220127', '0000158', '2022-08-22', 10, 65000, '0000135', 'StockIn'),
(95, '10220128', '0000158', '2022-08-22', 2, 130000, '0000136', 'StockIn'),
(96, '10220129', '0000163', '2022-08-22', 0, 0, '0000162', 'StockOut'),
(97, '10220130', '0000157', '2022-08-24', 1, 31, '0000162', 'StockIn'),
(98, '10220131', '0000161', '2022-08-24', 30, 150000, '0000136', 'StockIn'),
(99, '10220132', '0000163', '2022-08-24', 0, 0, '0000134', 'StockOut'),
(100, '10220133', '0000163', '2022-08-24', 500, 2500, '0000136', 'StockIn'),
(101, '10220134', '0000157', '2022-08-28', 3, 93000, '0000134', 'StockIn'),
(102, '10220134', '0000163', '2022-08-28', 5, 25, '0000134', 'StockIn'),
(103, '10220135', '0000157', '2022-08-29', 3, 93000, '0000137', 'StockIn'),
(104, '10220136', '0000163', '2022-08-29', 45, 225, '0000136', 'StockIn'),
(105, '10220136', '0000163', '2022-08-29', 40, 200, '0000136', 'StockIn'),
(106, '10220136', '0000163', '2022-08-29', 20, 100, '0000136', 'StockIn'),
(107, '10220139', '0000163', '2022-08-29', 1600, 8000, '0000136', 'StockIn'),
(108, '10220140', '0000158', '2022-08-29', 8, 520000, '0000137', 'StockIn'),
(109, '10220141', '0000157', '2022-08-29', 5, 155000, '0000138', 'StockIn'),
(110, '10220141', '0000160', '2022-08-29', 2, 100000, '0000134', 'StockIn'),
(111, '10220143', '0000163', '2022-08-29', 500, 2500, '0000137', 'StockIn'),
(112, '10220144', '0000161', '2022-08-29', 3, 15000, '0000137', 'StockIn'),
(113, '10220145', '0000163', '2022-08-29', 250, 1250, '0000136', 'StockOut'),
(114, '10220146', '0000163', '2022-08-29', 0, 0, '0000136', 'StockIn'),
(115, '10220147', '0000163', '2022-09-16', 50, 250, '0000135', 'StockIn'),
(116, '10220148', '0000163', '2022-09-16', 1, 5, '0000135', 'StockIn'),
(117, '10220149', '0000163', '2022-09-16', 4, 20, '0000135', 'StockIn'),
(118, '10220150', '0000163', '2022-09-16', 2, 10, '0000136', 'StockOut'),
(119, '10220151', '0000161', '2022-09-16', 0, 0, '0000127', 'StockOut'),
(120, '10220152', '0000163', '2022-09-16', 1, 5, '0000136', 'StockOut'),
(121, '10220153', '0000163', '2022-09-16', 1, 5, '0000162', 'StockOut'),
(122, '10220154', '0000157', '2022-09-16', 1, 31000, '0000162', 'StockOut'),
(123, '10220155', '0000157', '2022-09-16', 1, 31000, '0000137', 'StockIn'),
(124, '10220156', '0000163', '2022-09-19', 0, 0, '0000127', 'StockOut'),
(125, '10220157', '0000163', '2022-09-19', 1, 5, '0000169', 'StockIn'),
(126, '10220158', '0000158', '2022-09-19', 1, 65000, '0000168', 'StockIn'),
(127, '10220159', '0000160', '2022-09-19', 2, 100000, '0000169', 'StockIn'),
(128, '10220160', '0000161', '2022-09-22', 1, 5000, '0000169', 'StockIn'),
(129, '10220160', '0000161', '2022-09-22', 3, 15000, '0000169', 'StockIn');

-- --------------------------------------------------------

--
-- Table structure for table `tblstock_return`
--

CREATE TABLE `tblstock_return` (
  `StockReturnID` int(11) NOT NULL,
  `StockReturnNumber` varchar(30) NOT NULL,
  `ItemID` varchar(30) NOT NULL,
  `ReturnDate` date NOT NULL,
  `Quantity` int(11) NOT NULL,
  `TotalPrice` double NOT NULL,
  `OwnerCustomerID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstock_return`
--

INSERT INTO `tblstock_return` (`StockReturnID`, `StockReturnNumber`, `ItemID`, `ReturnDate`, `Quantity`, `TotalPrice`, `OwnerCustomerID`) VALUES
(1, '5313217', 'A000011', '2015-02-25', 2, 90, 11),
(2, '5313218', 'M00002', '2015-02-26', 2, 5000, 110),
(3, '5313219', 'A00001', '2015-02-26', 2, 150, 19),
(4, '5313220', 'A00007', '2015-02-26', 2, 100, 13),
(5, '5313221', 'M000010', '2015-02-27', 5, 10000, 112),
(6, '5313222', 'A000010', '2022-08-21', 5, 1750, 15),
(7, '5313223', 'A000013', '2022-08-21', 3, 135, 15),
(8, '5313224', 'A000010', '2022-08-22', 1, 350, 114),
(9, '5313225', 'A000014', '2022-08-22', 1, 150, 114),
(10, '0', '0000160', '2022-08-24', 2, 50000, 136),
(11, '0', '0000163', '2022-08-24', 5, 25, 162),
(12, '0', '0000163', '2022-08-24', 0, 0, 162),
(13, '0', '0000163', '2022-08-24', 25, 125, 134),
(14, '0', '0000163', '2022-08-24', 5, 25, 134),
(15, '0', '0000163', '2022-08-24', 20, 100, 134),
(16, '0', '0000163', '2022-08-29', 500, 2500, 136),
(17, '0', '0000163', '2022-08-29', 250, 1250, 136),
(18, '0', '0000163', '2022-09-16', 3, 15, 136),
(19, '0', '0000161', '2022-09-16', 3, 5000, 137),
(20, '0', '0000158', '2022-09-16', 2, 65000, 137),
(21, '0', '0000161', '2022-09-16', 1, 5000, 127),
(22, '0', '0000163', '2022-09-19', 1, 5, 127);

-- --------------------------------------------------------

--
-- Table structure for table `tblsupplier`
--

CREATE TABLE `tblsupplier` (
  `ID` int(11) NOT NULL,
  `SupplierID` varchar(30) DEFAULT NULL,
  `FirstName` varchar(90) DEFAULT NULL,
  `LastName` varchar(90) DEFAULT NULL,
  `MiddleName` varchar(90) DEFAULT NULL,
  `Gender` varchar(30) DEFAULT NULL,
  `Address` varchar(30) DEFAULT NULL,
  `Telephone` varchar(20) NOT NULL,
  `Mobile` int(15) NOT NULL,
  `EMail` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsupplier`
--

INSERT INTO `tblsupplier` (`ID`, `SupplierID`, `FirstName`, `LastName`, `MiddleName`, `Gender`, `Address`, `Telephone`, `Mobile`, `EMail`, `TYPE`) VALUES
(26, '0000127', 'Lora Lyn', 'Abella', 'Gonzales', 'Female', 'purok 9 poblacion', '09000000000', 0, NULL, 'Customer'),
(33, '0000134', 'Shaira Rose', 'Abelanio', 'Laurete', 'Female', 'Purok 14 b valencia city bukid', '828-', 2147483647, 'Shairalaurete@yahoo.com', 'Customer'),
(34, '0000135', 'Czar', 'Del Rosario', 'Abella', 'Male', 'purok 9 poblacion valencia Cit', '888 8888', 0, '7777777777', 'Customer'),
(35, '0000136', 'clyde ', 'abelanio', 'richard', 'Male', 'purok 4a bagontaas Valencia Ci', '888 6594', 900000000, 'richard _abelanio@gmail.com', 'Customer'),
(36, '0000137', 'Stelvy Jul', 'Quilog', 'Devaras', 'Female', 'Purok 6 Poblacion, Valencia Ci', '999 9999', 99999999, 'stelvyjulquilog@yahoo.com', 'Customer'),
(37, '0000138', 'Kyla Erika', 'Tumbaga', 'Tomacas', 'Female', 'purok 10 poblacion butuan agus', '888 5555', 98753245, 'erikatumbaga@yahoomail.com', 'Customer'),
(38, '0000162', 'Clarice Jowin', 'Tolentino', 'MIssion', 'Female', 'Purok 6 Poblacion, Valencia Ci', '888 8888', 90000000, 'tolentinoclaricejowin@yahoo.co', 'Customer'),
(39, '0000164', 'Cherish', 'Tolentino', 'Mission', 'Female', 'purok 6a Poblacion Valencia Ci', '0915555555', 999999, 'cherishtolentino@yahoo.com', 'Customer'),
(41, '0000168', 'shaira rose', 'laurete', 'valdehueza', 'Female', 'bagontaas valencia city bukidn', '828 6594', 2147483647, 'richardabelanio@gmail.com', 'Supplier'),
(42, '0000169', 'clyde richard', 'abelanio', 'laurete', 'Male', 'bagontaas purok 4 a valencia c', '828 6594', 900000000, 'richardabelanio@gmail.com', 'Supplier'),
(43, '0000170', 'ahhaha', 'ahhaha', 'ahhaha', 'Female', 'ahhaha', '888 8888', 999999999, 'richard abelanio@gmial.com', 'Supplier');

-- --------------------------------------------------------

--
-- Table structure for table `tbltransaction`
--

CREATE TABLE `tbltransaction` (
  `StockInID` int(11) NOT NULL,
  `TransactionNumber` varchar(30) DEFAULT NULL,
  `TransactionDate` date NOT NULL,
  `Type` varchar(30) NOT NULL,
  `SupplierCustomerID` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltransaction`
--

INSERT INTO `tbltransaction` (`StockInID`, `TransactionNumber`, `TransactionDate`, `Type`, `SupplierCustomerID`) VALUES
(1, '4908731', '2015-02-25', 'StockOut', '1220117'),
(2, '1022011', '2015-02-25', 'StockOut', '000011'),
(3, '4908731', '2015-02-25', 'Returned', '1220117'),
(4, '1022011', '2015-02-25', 'Returned', '11'),
(5, '4908731', '2015-02-25', 'Returned', '1220117'),
(6, '4908731', '2015-02-25', 'Returned', '1220117'),
(7, '1022012', '2015-02-25', 'StockOut', '000011'),
(8, '1022012', '2015-02-25', 'Returned', '11'),
(9, '1022013', '2015-02-25', 'StockOut', '000011'),
(10, '1022014', '2015-02-25', 'StockOut', '1220117'),
(11, '1022015', '2015-02-25', 'StockOut', '000011'),
(12, '1022016', '2015-02-25', 'StockOut', '000016'),
(13, '1022017', '2015-02-26', 'StockOut', '000016'),
(14, '1022018', '2015-02-26', 'StockOut', '000013'),
(15, '1022019', '2015-02-26', 'StockOut', '0000110'),
(16, '1022019', '2015-02-26', 'Returned', '110'),
(17, '10220110', '2015-02-26', 'StockOut', '000019'),
(18, '10220110', '2015-02-26', 'Returned', '19'),
(19, '10220111', '2015-02-26', 'StockOut', '000011'),
(20, '10220112', '2015-02-26', 'StockOut', '000013'),
(21, '10220112', '2015-02-26', 'Returned', '13'),
(22, '10220113', '2015-02-26', 'StockOut', '0000112'),
(23, '10220114', '2015-02-26', 'StockOut', '0000113'),
(24, '10220115', '2015-02-26', 'StockOut', '0000111'),
(25, '10220116', '2015-02-26', 'StockOut', '0000112'),
(26, '10220117', '2015-02-27', 'StockOut', '0000112'),
(27, '10220117', '2015-02-27', 'Returned', '112'),
(28, '3230215', '2022-08-21', 'StockIn', ''),
(29, '3230216', '2022-08-21', 'StockIn', ''),
(30, '3230217', '2022-08-21', 'StockIn', ''),
(31, '3230218', '2022-08-21', 'StockIn', ''),
(32, '3230219', '2022-08-21', 'StockIn', '0000138'),
(33, '3230220', '2022-08-21', 'StockIn', ''),
(34, '10220119', '2022-08-22', 'StockOut', '0000137'),
(35, '10220120', '2022-08-22', 'StockOut', '0000136'),
(36, '10220121', '2022-08-22', 'StockOut', '0000136'),
(37, '10220122', '2022-08-22', 'StockOut', '0000134'),
(38, '10220123', '2022-08-22', 'StockOut', '0000134'),
(39, '10220124', '2022-08-22', 'StockOut', '0000135'),
(40, '10220125', '2022-08-22', 'StockOut', '0000134'),
(41, '10220126', '2022-08-22', 'StockIn', '0000134'),
(42, '10220127', '2022-08-22', 'StockIn', '0000135'),
(43, '10220128', '2022-08-22', 'StockIn', '0000136'),
(44, '10220129', '2022-08-22', 'StockOut', '0000162'),
(45, '10220129', '2022-08-24', 'Returned', '162'),
(46, '10220129', '2022-08-24', 'Returned', '162'),
(47, '10220130', '2022-08-24', 'StockIn', '0000162'),
(48, '10220131', '2022-08-24', 'StockIn', '0000136'),
(49, '10220132', '2022-08-24', 'StockOut', '0000134'),
(50, '10220132', '2022-08-24', 'Returned', '134'),
(51, '10220132', '2022-08-24', 'Returned', '134'),
(52, '10220132', '2022-08-24', 'Returned', '134'),
(53, '10220133', '2022-08-24', 'StockIn', '0000136'),
(54, '10220134', '2022-08-28', 'StockIn', '0000134'),
(55, '10220135', '2022-08-29', 'StockOut', '0000137'),
(56, '10220136', '2022-08-29', 'StockOut', '0000136'),
(57, '10220136', '2022-08-29', 'StockOut', '0000136'),
(58, '10220136', '2022-08-29', 'StockOut', '0000136'),
(59, '10220139', '2022-08-29', 'StockOut', '0000136'),
(60, '10220140', '2022-08-29', 'StockOut', '0000137'),
(61, '10220141', '2022-08-29', 'StockOut', '0000138'),
(62, '10220141', '2022-08-29', 'StockOut', '0000134'),
(63, '10220143', '2022-08-29', 'StockOut', '0000137'),
(64, '10220144', '2022-08-29', 'StockOut', '0000137'),
(65, '10220145', '2022-08-29', 'StockOut', '0000136'),
(66, '10220146', '2022-08-29', 'StockIn', '0000136'),
(67, '10220146', '2022-08-29', 'Returned', '136'),
(68, '10220145', '2022-08-29', 'Returned', '136'),
(69, '10220147', '2022-09-16', 'StockIn', '0000135'),
(70, '10220148', '2022-09-16', 'StockIn', '0000135'),
(71, '10220149', '2022-09-16', 'StockIn', '0000135'),
(72, '10220150', '2022-09-16', 'StockOut', '0000136'),
(73, '10220150', '2022-09-16', 'Returned', '136'),
(74, '10220119', '2022-09-16', 'Returned', '137'),
(75, '10220151', '2022-09-16', 'StockOut', '0000127'),
(76, '10220151', '2022-09-16', 'Returned', '127'),
(77, '10220152', '2022-09-16', 'StockOut', '0000136'),
(78, '10220153', '2022-09-16', 'StockOut', '0000162'),
(79, '10220154', '2022-09-16', 'StockOut', '0000162'),
(80, '10220155', '2022-09-16', 'StockIn', '0000137'),
(81, '10220156', '2022-09-19', 'StockOut', '0000127'),
(82, '10220156', '2022-09-19', 'Returned', '127'),
(83, '10220157', '2022-09-19', 'StockIn', '0000169'),
(84, '10220158', '2022-09-19', 'StockIn', '0000168'),
(85, '10220159', '2022-09-19', 'StockIn', '0000169'),
(86, '10220160', '2022-09-22', 'StockIn', '0000169'),
(87, '10220160', '2022-09-22', 'StockIn', '0000169');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(90) DEFAULT NULL,
  `Type` varchar(90) DEFAULT NULL,
  `Password` varchar(90) DEFAULT NULL,
  `Name` varchar(30) DEFAULT NULL,
  `Email` varchar(40) NOT NULL,
  `PhoneNumber` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`UserID`, `Username`, `Type`, `Password`, `Name`, `Email`, `PhoneNumber`) VALUES
(9, 'Clarice ', 'Staff', '05a74c726cdf900f86c21a40a28e88ea44996315', 'Clarice Jowin Tolentino', 'claricetolentino@gmail.com', '09000000000'),
(6, 'Shaira Rose ', 'Administrator', 'a58f4ca7a6857beefd5454c535b7ee1252ad8c9d', 'Shaira Rose Abelanio', 'Shaira Laurete Abelanio', '09153019324'),
(8, 'Clyde Richard ', 'Administrator', '81952321b82fe14894139bfb0bb9f08099076da4', 'Clyde Richard Abelanio', 'ClydeRichard@gmail.com', '09153019324'),
(12, 'Redge Esperitu', 'Administrator', '8a2da05455775e8987cbfac5a0ca54f3f728e274', 'Redgil Star Espiritu', 'RedgeEspiritu@gmail.com', '09555772538');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblbrand`
--
ALTER TABLE `tblbrand`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblitems`
--
ALTER TABLE `tblitems`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `CUSID` (`ItemID`);

--
-- Indexes for table `tblparts`
--
ALTER TABLE `tblparts`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblperson`
--
ALTER TABLE `tblperson`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `CUSID` (`CustomerID`);

--
-- Indexes for table `tblsettings`
--
ALTER TABLE `tblsettings`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblstock_in_out`
--
ALTER TABLE `tblstock_in_out`
  ADD PRIMARY KEY (`StockOutID`);

--
-- Indexes for table `tblstock_return`
--
ALTER TABLE `tblstock_return`
  ADD PRIMARY KEY (`StockReturnID`);

--
-- Indexes for table `tblsupplier`
--
ALTER TABLE `tblsupplier`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `CUSID` (`SupplierID`);

--
-- Indexes for table `tbltransaction`
--
ALTER TABLE `tbltransaction`
  ADD PRIMARY KEY (`StockInID`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`UserID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `tblbrand`
--
ALTER TABLE `tblbrand`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `tblitems`
--
ALTER TABLE `tblitems`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=62;

--
-- AUTO_INCREMENT for table `tblparts`
--
ALTER TABLE `tblparts`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `tblperson`
--
ALTER TABLE `tblperson`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `tblsettings`
--
ALTER TABLE `tblsettings`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tblstock_in_out`
--
ALTER TABLE `tblstock_in_out`
  MODIFY `StockOutID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=130;

--
-- AUTO_INCREMENT for table `tblstock_return`
--
ALTER TABLE `tblstock_return`
  MODIFY `StockReturnID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `tblsupplier`
--
ALTER TABLE `tblsupplier`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `tbltransaction`
--
ALTER TABLE `tbltransaction`
  MODIFY `StockInID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=88;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
