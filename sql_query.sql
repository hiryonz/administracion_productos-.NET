-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 06, 2024 at 01:56 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `admin_productos`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Cliente_BuscarPorCedula` (IN `p_Cedula` VARCHAR(15))   BEGIN
    SELECT * FROM CLIENTE WHERE Cedula = p_Cedula;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Cliente_Eliminar` (IN `p_Id` INT)   BEGIN
    DELETE FROM CLIENTE WHERE Id = p_Id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Cliente_Insertar` (IN `p_Cedula` VARCHAR(15), IN `p_Nombre` VARCHAR(30), IN `p_Apellido` VARCHAR(30), IN `p_Direccion` VARCHAR(50), IN `p_Celular` VARCHAR(9), IN `p_Correo` VARCHAR(50), IN `p_Sexo` CHAR(1), IN `p_Estatus` CHAR(1))   BEGIN
    INSERT INTO CLIENTE (Cedula, Nombre, Apellido, Direccion, Celular, Correo, Sexo, Estatus)
    VALUES (p_Cedula, p_Nombre, p_Apellido, p_Direccion, p_Celular, p_Correo, p_Sexo, p_Estatus);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Cliente_Listar` (IN `p_OrderByField` VARCHAR(30))   BEGIN
    SET @query = CONCAT('SELECT * FROM CLIENTE ORDER BY ', p_OrderByField);
    PREPARE stmt FROM @query;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Cliente_Modificar` (IN `p_Id` INT, IN `p_Nombre` VARCHAR(30), IN `p_Apellido` VARCHAR(30), IN `p_Direccion` VARCHAR(50), IN `p_Celular` VARCHAR(9), IN `p_Correo` VARCHAR(50), IN `p_Sexo` CHAR(1), IN `p_Estatus` CHAR(1))   BEGIN
    UPDATE CLIENTE
    SET Nombre = p_Nombre,
        Apellido = p_Apellido,
        Direccion = p_Direccion,
        Celular = p_Celular,
        Correo = p_Correo,
        Sexo = p_Sexo,
        Estatus = p_Estatus
    WHERE Id = p_Id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Producto_BuscarPorCodigo` (IN `p_CodigoBarra` VARCHAR(12))   BEGIN
    SELECT * FROM PRODUCTO WHERE CodigoBarra = p_CodigoBarra;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Producto_Eliminar` (IN `p_CodigoBarra` VARCHAR(50))   BEGIN
    DELETE FROM PRODUCTO WHERE CodigoBarra = p_CodigoBarra;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Producto_Insertar` (IN `p_CodigoBarra` VARCHAR(12), IN `p_Descripcion` VARCHAR(50), IN `p_Costo` DECIMAL(7,2), IN `p_Precio` DECIMAL(7,2), IN `p_ITBMS` INT, IN `p_Existencia` INT, IN `p_PuntoDeReorden` INT, IN `p_Estatus` CHAR(1))   BEGIN
    INSERT INTO PRODUCTO (CodigoBarra, Descripcion, Costo, Precio, ITBMS, Existencia, PuntoDeReorden, Estatus)
    VALUES (p_CodigoBarra, p_Descripcion, p_Costo, p_Precio, p_ITBMS, p_Existencia, p_PuntoDeReorden, p_Estatus);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Producto_Listar` (IN `p_OrderByField` VARCHAR(30))   BEGIN
    SET @query = CONCAT('SELECT * FROM PRODUCTO ORDER BY ', p_OrderByField);
    PREPARE stmt FROM @query;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Producto_Modificar` (IN `p_CodigoBarra` VARCHAR(50), IN `p_Descripcion` VARCHAR(50), IN `p_Costo` DECIMAL(7,2), IN `p_Precio` DECIMAL(7,2), IN `p_ITBMS` INT, IN `p_Existencia` INT, IN `p_PuntoDeReorden` INT, IN `p_Estatus` CHAR(1))   BEGIN
    UPDATE PRODUCTO
    SET Descripcion = p_Descripcion,
        Costo = p_Costo,
        Precio = p_Precio,
        ITBMS = p_ITBMS,
        Existencia = p_Existencia,
        PuntoDeReorden = p_PuntoDeReorden,
        Estatus = p_Estatus
    WHERE CodigoBarra = p_CodigoBarra;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE `cliente` (
  `Id` int(11) NOT NULL,
  `Cedula` varchar(15) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `Apellido` varchar(30) NOT NULL,
  `Direccion` varchar(50) DEFAULT NULL,
  `Celular` varchar(9) NOT NULL CHECK (`Celular` regexp '^[0-9]{4}-[0-9]{4}$'),
  `Correo` varchar(50) NOT NULL CHECK (`Correo` regexp '^[^@s]+@[^@s]+.[^@s]+$'),
  `Sexo` char(1) NOT NULL CHECK (`Sexo` in ('M','F')),
  `Estatus` char(1) NOT NULL CHECK (`Estatus` in ('A','I'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


--
-- Table structure for table `producto`
--

CREATE TABLE `producto` (
  `Id` int(11) NOT NULL,
  `CodigoBarra` varchar(12) NOT NULL,
  `Descripcion` varchar(50) NOT NULL,
  `Costo` decimal(7,2) NOT NULL CHECK (`Costo` >= 0),
  `Precio` decimal(7,2) NOT NULL CHECK (`Precio` >= 0),
  `ITBMS` decimal(11,2) NOT NULL,
  `Existencia` int(11) NOT NULL CHECK (`Existencia` >= 0),
  `PuntoDeReorden` int(11) NOT NULL CHECK (`PuntoDeReorden` >= 0),
  `Estatus` char(1) NOT NULL CHECK (`Estatus` in ('A','I'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;



--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `CodigoBarra` (`CodigoBarra`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `producto`
--
ALTER TABLE `producto`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

