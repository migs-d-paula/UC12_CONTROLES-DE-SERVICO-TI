-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21/06/2023 às 03:10
-- Versão do servidor: 10.4.22-MariaDB
-- Versão do PHP: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_controle_de_servicos`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tbl_cliente`
--

CREATE TABLE `tbl_cliente` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `cpf` int(11) DEFAULT NULL,
  `celular` int(11) DEFAULT NULL,
  `fk_endereco` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `tbl_cliente`
--

INSERT INTO `tbl_cliente` (`id`, `nome`, `cpf`, `celular`, `fk_endereco`) VALUES
(1, 'Miguel', 2147483647, 2147483647, 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tbl_endereco`
--

CREATE TABLE `tbl_endereco` (
  `id` int(11) NOT NULL,
  `estado` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `bairro` varchar(100) DEFAULT NULL,
  `rua` varchar(100) DEFAULT NULL,
  `numero` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `tbl_endereco`
--

INSERT INTO `tbl_endereco` (`id`, `estado`, `cidade`, `bairro`, `rua`, `numero`) VALUES
(1, 'São Paulo', 'Guaratinguetá', 'Santa Rita', 'Adriano mendonça', 173);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tbl_ordem_de_servico`
--

CREATE TABLE `tbl_ordem_de_servico` (
  `id` int(11) NOT NULL,
  `cliente` int(11) NOT NULL,
  `produto` varchar(100) NOT NULL,
  `problema` varchar(50) NOT NULL,
  `data_de_chegada` datetime NOT NULL,
  `solucoes` varchar(100) NOT NULL,
  `valor` double NOT NULL,
  `status` varchar(100) NOT NULL,
  `fk_cliente` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `tbl_ordem_de_servico`
--

INSERT INTO `tbl_ordem_de_servico` (`id`, `cliente`, `produto`, `problema`, `data_de_chegada`, `solucoes`, `valor`, `status`, `fk_cliente`) VALUES
(1, 0, 'notebook', 'nao liga', '2023-06-20 21:15:26', 'comprar e instalar novo hdd', 250, ' Em Andamento', NULL);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tbl_cliente`
--
ALTER TABLE `tbl_cliente`
  ADD PRIMARY KEY (`id`),
  ADD KEY `cliente_endereco` (`fk_endereco`);

--
-- Índices de tabela `tbl_endereco`
--
ALTER TABLE `tbl_endereco`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `tbl_ordem_de_servico`
--
ALTER TABLE `tbl_ordem_de_servico`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ordem_cliente` (`cliente`),
  ADD KEY `cliente` (`fk_cliente`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tbl_cliente`
--
ALTER TABLE `tbl_cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `tbl_endereco`
--
ALTER TABLE `tbl_endereco`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `tbl_ordem_de_servico`
--
ALTER TABLE `tbl_ordem_de_servico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `tbl_cliente`
--
ALTER TABLE `tbl_cliente`
  ADD CONSTRAINT `cliente_endereco` FOREIGN KEY (`fk_endereco`) REFERENCES `tbl_endereco` (`id`);

--
-- Restrições para tabelas `tbl_ordem_de_servico`
--
ALTER TABLE `tbl_ordem_de_servico`
  ADD CONSTRAINT `cliente` FOREIGN KEY (`fk_cliente`) REFERENCES `tbl_cliente` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
