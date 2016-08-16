-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Máquina: 127.0.0.1
-- Data de Criação: 16-Maio-2016 às 00:05
-- Versão do servidor: 5.5.32
-- versão do PHP: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `clinic`
--
CREATE DATABASE IF NOT EXISTS `clinic` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `clinic`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `administrador`
--

CREATE TABLE IF NOT EXISTS `administrador` (
  `cpfAdmin` varchar(15) NOT NULL,
  `senhaAdm` varchar(12) NOT NULL,
  `nomeAdm` varchar(50) NOT NULL,
  PRIMARY KEY (`cpfAdmin`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `administrador`
--

INSERT INTO `administrador` (`cpfAdmin`, `senhaAdm`, `nomeAdm`) VALUES
('704.097.844-00', '123', 'Kevyn Hebert'),
('704.097.894-61', '34663827', 'Ikaro Sales');

-- --------------------------------------------------------

--
-- Estrutura da tabela `clinica`
--

CREATE TABLE IF NOT EXISTS `clinica` (
  `cnpj` varchar(18) NOT NULL,
  `nome` varchar(40) NOT NULL,
  `descEspec` text NOT NULL,
  `endereco` varchar(30) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `cep` varchar(10) NOT NULL,
  `cidade` varchar(20) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `email` varchar(50) NOT NULL,
  `telefone` varchar(12) NOT NULL,
  PRIMARY KEY (`cnpj`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `clinica`
--

INSERT INTO `clinica` (`cnpj`, `nome`, `descEspec`, `endereco`, `bairro`, `cep`, `cidade`, `uf`, `email`, `telefone`) VALUES
('56.345.813/0001-78', 'Clínica Santa Rita', 'Odontologia\r\nAcupuntura\r\nCardiologia\r\nMastologia\r\nClinico Geral', 'Av. Marechal Campos 1579', 'Santa Cecília', '29.043-260', 'Vitória', 'ES', 'faleconosco@santarita.com', '3334-8000');

-- --------------------------------------------------------

--
-- Estrutura da tabela `consulta`
--

CREATE TABLE IF NOT EXISTS `consulta` (
  `codConsulta` int(11) NOT NULL AUTO_INCREMENT,
  `paciente` varchar(15) NOT NULL,
  `tipoConsulta` int(11) NOT NULL,
  `dataConsulta` varchar(10) NOT NULL,
  `horario` varchar(10) NOT NULL,
  `medico` varchar(10) NOT NULL,
  `descricao` text NOT NULL,
  PRIMARY KEY (`codConsulta`),
  KEY `tipoConsulta` (`tipoConsulta`),
  KEY `medico` (`medico`),
  KEY `paciente` (`paciente`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Extraindo dados da tabela `consulta`
--

INSERT INTO `consulta` (`codConsulta`, `paciente`, `tipoConsulta`, `dataConsulta`, `horario`, `medico`, `descricao`) VALUES
(5, '714.162.877-01', 1, '15/05/2016', '09:40', '010724/PE', ''),
(6, '182.521.494-80', 2, '15/05/2016', '16:10', '005683/SP', ''),
(14, '295.481.963-80', 3, '16/05/2016', '16:11', '005683/SP', ''),
(16, '182.521.494-80', 2, '15/05/2016', '16:10', '026464/BA', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `convenio`
--

CREATE TABLE IF NOT EXISTS `convenio` (
  `cnpj` varchar(18) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `cidade` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `observacoes` text,
  `data` date NOT NULL,
  `hora` time NOT NULL,
  PRIMARY KEY (`cnpj`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `convenio`
--

INSERT INTO `convenio` (`cnpj`, `nome`, `endereco`, `bairro`, `cidade`, `email`, `observacoes`, `data`, `hora`) VALUES
('77.405.710/0001-26', 'Amil', 'Av. Conselheiro Aguiar, 3150', 'Boa Viagem', 'Recife', 'contato@amil.com.br', '', '2016-03-19', '13:47:09'),
('90.020.077/0001-16', 'QualiCorp', 'Av. Gov. Agamenon Magalhães, 4779', 'Santo Amaro', 'Recife', 'contato@qualicorp.com.br', '', '2016-03-19', '13:44:47');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE IF NOT EXISTS `funcionario` (
  `cpf` varchar(15) NOT NULL,
  `cnpj` varchar(18) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `cep` varchar(15) NOT NULL,
  `cidade` varchar(30) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `telefone` varchar(16) NOT NULL,
  `nomeUser` varchar(12) NOT NULL,
  `senhaUser` varchar(12) NOT NULL,
  `qtdAcesso` int(11) NOT NULL,
  PRIMARY KEY (`cpf`),
  KEY `fk_Clinica` (`cnpj`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`cpf`, `cnpj`, `nome`, `endereco`, `bairro`, `cep`, `cidade`, `uf`, `telefone`, `nomeUser`, `senhaUser`, `qtdAcesso`) VALUES
('000.000.000-00', '56.345.813/0001-78', 'Kevyn', '000', '000', '000', '000', 'UF', '(00) 00000-0', 'kevyn', 'kevyn', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `medico`
--

CREATE TABLE IF NOT EXISTS `medico` (
  `crm` varchar(10) NOT NULL,
  `dataInscricao` varchar(10) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  `endereco` varchar(30) NOT NULL,
  `bairro` varchar(20) NOT NULL,
  `cidade` varchar(20) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `clinica` varchar(18) NOT NULL,
  `nomeUser` varchar(12) NOT NULL,
  `senhaUser` varchar(12) NOT NULL,
  PRIMARY KEY (`crm`),
  KEY `clinica` (`clinica`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `medico`
--

INSERT INTO `medico` (`crm`, `dataInscricao`, `nome`, `cpf`, `endereco`, `bairro`, `cidade`, `uf`, `clinica`, `nomeUser`, `senhaUser`) VALUES
('005683/SP', '13/11/72', 'Ivo Pitangui', '294.839.637-12', 'Av. Paulista, 332', 'Morumbi', 'São Paulo', 'SP', '56.345.813/0001-78', 'ivo', 'ivo'),
('010724/PE', '02/07/1992', 'João Luiz', '407.545.691-88', 'Rua Bosco Lima, 32', 'Imbiribeira', 'Recife', 'PE', '56.345.813/0001-78', 'joaoluiz', 'joaoluiz'),
('026464/BA', '14/01/2014', 'Alexandre Pithon', '639.926.047-84', 'Rua João Suassuna, 34', 'Boa Vista', 'Recife', 'PE', '56.345.813/0001-78', 'alexandre', '123');

-- --------------------------------------------------------

--
-- Estrutura da tabela `paciente`
--

CREATE TABLE IF NOT EXISTS `paciente` (
  `cpf` varchar(15) NOT NULL,
  `cnpjConv` varchar(18) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `nomePai` varchar(50) NOT NULL,
  `nomeMae` varchar(50) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `cep` varchar(15) NOT NULL,
  `telefone` varchar(12) NOT NULL,
  `email` varchar(30) NOT NULL,
  `data` date NOT NULL,
  `hora` time NOT NULL,
  PRIMARY KEY (`cpf`),
  KEY `fk_Convenio` (`cnpjConv`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `paciente`
--

INSERT INTO `paciente` (`cpf`, `cnpjConv`, `nome`, `nomePai`, `nomeMae`, `endereco`, `bairro`, `cep`, `telefone`, `email`, `data`, `hora`) VALUES
('182.521.494-80', '77.405.710/0001-26', 'Kaique Eduardo', 'Carlos Santos', 'Mikaely Ribeiro', '4ª Travessa Jaguarana, 468', 'COHAB', '51280-142', '(81) 2641-14', 'kaique.carlos.santos@academiah', '2016-05-14', '23:50:00'),
('295.481.963-80', '90.020.077/0001-16', 'Mario Carlos', 'Fernando da Silva Jr.', 'Roberta Rejane dos Santos', 'Rua Espardarte, 89', 'Pina', '51030-028', 'Recife', 'mcarlos@gmail.com', '2016-03-19', '14:09:14'),
('714.162.877-01', '90.020.077/0001-16', 'Bruno Kevin', 'Luiz Mendonça', 'Maria Santos', 'Rua João Sales de Menezes, 270', 'Iputinga', '50740-110', '(81)37139436', 'bkmendes@urbam.com.br', '2016-05-14', '23:53:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipoconsulta`
--

CREATE TABLE IF NOT EXISTS `tipoconsulta` (
  `codTipoCons` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  `descricao` text NOT NULL,
  PRIMARY KEY (`codTipoCons`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Extraindo dados da tabela `tipoconsulta`
--

INSERT INTO `tipoconsulta` (`codTipoCons`, `nome`, `descricao`) VALUES
(1, 'Cardiológica', 'Especialidade médica que se ocupa do diagnóstico e tratamento das doenças que acometem o coração bem como os outros componentes do sistema circulatório.'),
(2, 'Pediátrica', 'Especialidade médica dedicada à assistência à criança e ao adolescente, nos seus diversos aspectos, sejam eles preventivos ou curativos.'),
(3, 'Odontológica', 'Área da saúde humana que estuda e trata do sistema estomatognático - compreende a face, pescoço e cavidade bucal, abrangendo ossos, musculatura mastigatória, articulações, dentes e tecidos.');

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `consulta`
--
ALTER TABLE `consulta`
  ADD CONSTRAINT `consulta_ibfk_1` FOREIGN KEY (`tipoConsulta`) REFERENCES `tipoconsulta` (`codTipoCons`),
  ADD CONSTRAINT `consulta_ibfk_2` FOREIGN KEY (`medico`) REFERENCES `medico` (`crm`),
  ADD CONSTRAINT `consulta_ibfk_3` FOREIGN KEY (`paciente`) REFERENCES `paciente` (`cpf`);

--
-- Limitadores para a tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD CONSTRAINT `fk_Clinica` FOREIGN KEY (`cnpj`) REFERENCES `clinica` (`cnpj`);

--
-- Limitadores para a tabela `medico`
--
ALTER TABLE `medico`
  ADD CONSTRAINT `medico_ibfk_1` FOREIGN KEY (`clinica`) REFERENCES `clinica` (`cnpj`);

--
-- Limitadores para a tabela `paciente`
--
ALTER TABLE `paciente`
  ADD CONSTRAINT `fk_Convenio` FOREIGN KEY (`cnpjConv`) REFERENCES `convenio` (`cnpj`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
