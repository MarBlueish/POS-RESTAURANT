-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 18-Set-2023 às 06:04
-- Versão do servidor: 10.4.28-MariaDB
-- versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `restaurante1`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `datalogin`
--

CREATE TABLE `datalogin` (
  `id_login` int(11) NOT NULL,
  `Data_De_Login` datetime DEFAULT NULL,
  `Data_De_Logout` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `datalogin`
--

INSERT INTO `datalogin` (`id_login`, `Data_De_Login`, `Data_De_Logout`) VALUES
(1, '2023-09-18 04:23:44', NULL),
(10, '2023-09-18 04:56:08', NULL),
(13, '2023-09-18 04:27:17', NULL),
(16, '2023-09-18 04:33:37', NULL),
(17, '2023-09-18 04:32:31', NULL),
(23, '2023-09-18 04:36:38', NULL),
(24, '2023-09-18 04:30:31', NULL),
(25, '2023-09-18 04:35:01', NULL),
(49, '2023-09-18 04:45:06', NULL),
(50, '2023-09-18 04:43:09', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `fatura`
--

CREATE TABLE `fatura` (
  `ID_Fatura` int(11) NOT NULL,
  `ID_Usuario` int(11) DEFAULT NULL,
  `ID_Pedido` int(11) DEFAULT NULL,
  `Nif_Cliente` varchar(20) DEFAULT NULL,
  `Preco_Total` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedor`
--

CREATE TABLE `fornecedor` (
  `ID_FORNECEDOR` int(11) NOT NULL,
  `EMPRESA_FORNECEDOR` varchar(255) NOT NULL,
  `MORADA_FORNECEDOR` varchar(255) DEFAULT NULL,
  `IBAN_FORNECEDOR` varchar(30) DEFAULT NULL,
  `FORMA_PAGAMENTO` varchar(50) DEFAULT NULL,
  `NIF_FORNECEDOR` varchar(20) DEFAULT NULL,
  `CONTACTO_FORNECEDOR` varchar(20) DEFAULT NULL,
  `TIPO_FORNECEDOR` varchar(50) DEFAULT NULL,
  `DATA_ENTREGA` date DEFAULT NULL,
  `EMAIL_FORNECEDOR` varchar(100) DEFAULT NULL,
  `DATA_CADASTRO` date DEFAULT NULL,
  `OBSERVACOES` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `fornecedor`
--

INSERT INTO `fornecedor` (`ID_FORNECEDOR`, `EMPRESA_FORNECEDOR`, `MORADA_FORNECEDOR`, `IBAN_FORNECEDOR`, `FORMA_PAGAMENTO`, `NIF_FORNECEDOR`, `CONTACTO_FORNECEDOR`, `TIPO_FORNECEDOR`, `DATA_ENTREGA`, `EMAIL_FORNECEDOR`, `DATA_CADASTRO`, `OBSERVACOES`) VALUES
(1, 'Transporte Saboroso Lda', 'Rua das Delícias, nº 123, Lisboa', 'PT50 1234 5678 9012 3456 7890', 'Cartão de crédito', '512345678', '912345678', 'Sobremesas', '2023-09-01', 'ana.silva@novatech.pt', '2023-09-14', 'N/A'),
(2, 'Alimentos Expresso, SA', 'Avenida dos Sabores, nº 45, Porto', 'PT50 2345 6789 0123 4567 8901', 'Cartão de crédito', '523456789', '912345679', 'Sobremesas', '2023-09-02', 'pedro.almeida@inovacloud.pt', '2023-09-14', 'N/A'),
(3, 'Rápido e Fresco Transportes', 'Praça das Frutas, nº 67, Faro', 'PT50 3456 7890 1234 5678 9012', 'Cartão de crédito', '534567890', '912345680', 'Sobremesas', '2023-09-03', 'maria.martins@exceltron.pt', '2023-09-14', 'N/A'),
(4, 'Entregas Gourmet, Lda', 'Rua dos Temperos, nº 89, Braga', 'PT50 4567 8901 2345 6789 0123', 'Cartão de crédito', '545678901', '912345681', 'Sobremesas', '2023-09-04', 'joao.santos@quadrosoft.pt', '2023-09-14', 'N/A'),
(5, 'Transporte Sabor Natural', 'Alameda dos Alimentos, nº 12, Viseu', 'PT50 5678 9012 3456 7890 1234', 'Cartão de crédito', '556789012', '912345685', 'Sobremesas', '2023-09-05', 'sofia.ferreira@techsolutions.pt', '2023-09-14', 'N/A'),
(6, 'Envio Fresco e Rápido, SA', 'Rua das Especiarias, nº 34, Coimbra', 'PT50 6789 0123 4567 8901 2345', 'Cartão de crédito', '567890123', '912345686', 'Sobremesas', '2023-09-06', 'carlos.rodrigues@biztech.pt', '2023-09-14', 'N/A'),
(7, 'Logística Saborosa', 'Avenida dos Sabores, nº 56, Évora', 'PT50 7890 1234 5678 9012 3456', 'Cartão de crédito', '578901234', '912345687', 'Sobremesas', '2023-09-07', 'marta.oliveira@digitalplus.pt', '2023-09-14', 'N/A'),
(8, 'Transporte de Delícias, Lda', 'Praça dos Alimentos, nº 78, Guarda', 'PT50 8901 2345 6789 0123 4567', 'Cartão de crédito', '589012345', '912345688', 'Sobremesas', '2023-09-08', 'andre.goncalves@logistix.pt', '2023-09-14', 'N/A'),
(9, 'Entregas Gourmet Express', 'Rua dos Aromas, nº 23, Setúbal', 'PT50 9012 3456 7890 1234 5678', 'Cartão de crédito', '590123456', '912345689', 'Sobremesas', '2023-09-09', 'isabel.fernandes@smartware.pt', '2023-09-14', 'N/A'),
(10, 'Transporte Fresco e Saboroso', 'Alameda das Ervas, nº 45, Leiria', 'PT50 0123 4567 8901 2345 6789', 'Cartão de crédito', '501234567', '912345690', 'Sobremesas', '2023-09-10', 'rui.pereira@webmaster.pt', '2023-09-14', 'N/A'),
(11, 'Rápido Sabor Transportes', 'Avenida dos Condimentos, nº 67, Santarém', 'PT50 1234 5678 9012 3456 7890', 'Cartão de Débito', '512345678', '912345691', 'Ingredientes', '2023-09-11', 'susana.lopes@innosys.pt', '2023-09-14', 'N/A'),
(12, 'Envios de Sabor, SA', 'Rua dos Frutos, nº 34, Bragança', 'PT50 2345 6789 0123 4567 8901', 'Cartão de Débito', '523456789', '912345692', 'Ingredientes', '2023-09-12', 'miguel.costa@virtuamark.pt', '2023-09-14', 'N/A'),
(13, 'Sabor em Casa Transportes', 'Praça das Especiarias, nº 78, Portimão', 'PT50 3456 7890 1234 5678 9012', 'Cartão de Débito', '534567890', '912345693', 'Ingredientes', '2023-09-13', 'claudia.dias@creativebyte.pt', '2023-09-14', 'N/A'),
(14, 'Entregas Gourmet, Lda', 'Alameda dos Sabores, nº 12, Aveiro', 'PT50 4567 8901 2345 6789 0123', 'Cartão de Débito', '545678901', '912345694', 'Ingredientes', '2023-09-14', 'antonio.marques@innotech.pt', '2023-09-14', 'N/A'),
(15, 'Transporte de Sabor Natural', 'Rua dos Temperos, nº 45, Vila Real', 'PT50 5678 9012 3456 7890 1234', 'Cartão de Débito', '556789012', '912345695', 'Ingredientes', '2023-09-15', 'sofia.ribeiro@dataflow.pt', '2023-09-14', 'N/A'),
(16, 'Envio Rápido e Fresco, Lda', 'Avenida dos Condimentos, nº 78, Funchal', 'PT50 6789 0123 4567 8901 2345', 'Cartão de Débito', '567890123', '912345696', 'Ingredientes', '2023-09-16', 'paulo.silveira@inovadex.pt', '2023-09-14', 'N/A'),
(17, 'Transporte de Sabor Delicioso', 'Rua dos Frutos, nº 67, Ponta Delgada', 'PT50 7890 1234 5678 9012 3456', 'Cartão de Débito', '578901234', '912345697', 'Ingredientes', '2023-09-17', 'ines.gomes@softex.pt', '2023-09-14', 'N/A'),
(18, 'Entregas de Sabores, SA', 'Praça das Ervas, nº 23, Évora', 'PT50 8901 2345 6789 0123 4567', 'Cartão de Débito', '589012345', '912345698', 'Ingredientes', '2023-09-18', 'ricardo.mendes@maxiline.pt', '2023-09-14', 'N/A'),
(19, 'Transporte Saboroso, Lda', 'Alameda dos Condimentos, nº 12, Viseu', 'PT50 0123 4567 8901 2345 6789', 'Cartão de Débito', '590123456', '912345699', 'Ingredientes', '2023-09-19', 'maria.rocha@netimpact.pt', '2023-09-14', 'N/A'),
(20, 'Envio Rápido de Sabores, SA', 'Rua dos Temperos, nº 34, Braga', 'PT50 1234 5678 9012 3456 7890', 'Cartão de Débito', '501234567', '912345660', 'Ingredientes', '2023-09-20', 'luis.pinto@visionware.pt', '2023-09-14', 'N/A'),
(21, 'Transporte Delicioso, SA', 'Avenida dos Aromas, nº 56, Lisboa', 'PT50 2345 6789 0123 4567 8901', 'Cartão de Débito', '512345678', '912345661', 'Bebidas', '2023-09-21', 'carla.fernandes@smarttech.pt', '2023-09-14', 'N/A'),
(22, 'Entregas de Sabor Natural', 'Praça das Especiarias, nº 12, Porto', 'PT50 3456 7890 1234 5678 9012', 'Cartão de Débito', '523456789', '912345662', 'Bebidas', '2023-09-22', 'tiago.alves@ideaseek.pt', '2023-09-14', 'N/A'),
(23, 'Transporte Saboroso Expresso', 'Rua das Delícias, nº 67, Faro', 'PT50 4567 8901 2345 6789 0123', 'Cartão de Débito', '534567890', '912345663', 'Bebidas', '2023-09-23', 'sandra.ribeiro@intellisoft.pt', '2023-09-14', 'N/A'),
(24, 'Envio de Sabores Express', 'Alameda dos Temperos, nº 89, Coimbra', 'PT50 5678 9012 3456 7890 1234', 'Cartão de Débito', '545678901', '912345664', 'Bebidas', '2023-09-24', 'andreia.martins@webfusion.pt', '2023-09-14', 'N/A'),
(25, 'Transporte Rápido e Fresco', 'Praça dos Alimentos, nº 23, Leiria', 'PT50 6789 0123 4567 8901 2345', 'Cartão de Débito', '556789012', '912345665', 'Bebidas', '2023-09-25', 'jose.pedro@techlink.pt', '2023-09-14', 'N/A'),
(26, 'Entregas Saborosas, Lda', 'Avenida das Ervas, nº 34, Santarém', 'PT50 7890 1234 5678 9012 3456', 'Cartão de Débito', '567890123', '912345666', 'Bebidas', '2023-09-26', 'raquel.santos@digitalage.pt', '2023-09-14', 'N/A'),
(27, 'Transporte de Delícias Express', 'Rua das Frutas, nº 45, Bragança', 'PT50 8901 2345 6789 0123 4567', 'Cartão de Débito', '578901234', '912345667', 'Bebidas', '2023-09-27', 'bruno.silva@biznet.pt', '2023-09-14', 'N/A'),
(28, 'Envios de Sabor, Lda', 'Alameda dos Aromas, nº 67, Évora', 'PT50 9012 3456 7890 1234 5678', 'Cartão de Débito', '589012345', '912345668', 'Bebidas', '2023-09-28', 'carolina.rodrigues@smartdata.pt', '2023-09-14', 'N/A'),
(29, 'Transporte Fresco e Saboroso, Lda', 'Praça dos Sabores, nº 12, Setúbal', 'PT50 0123 4567 8901 2345 6789', 'Cartão de Débito', '590123456', '912345669', 'Bebidas', '2023-09-29', 'fernando.mendes@innovate.pt', '2023-09-14', 'N/A'),
(30, 'Rápido Sabor Transportes, Lda', 'Rua dos Frutos, nº 23, Leiria', 'PT50 1234 5678 9012 3456 7890', 'Cartão de Débito', '501234567', '912345670', 'Limpeza', '2023-09-30', 'ana.rodrigues@quicktech.pt', '2023-09-14', 'N/A'),
(31, 'ghf', 'fghgfhj', 'dthgf', 'Cartão de Débito', 'fgjghf', 'gfsjgsfjjfg', 'Bebidas', '2023-09-18', 'gfsjfgjsjgf', '2023-09-18', 'gfjhgffg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `mesapedido`
--

CREATE TABLE `mesapedido` (
  `ID_MesaPedido` int(11) NOT NULL,
  `ID_Mesa` int(11) DEFAULT NULL,
  `ID_Produto` int(11) DEFAULT NULL,
  `ID_Prato` int(11) DEFAULT NULL,
  `Quantidade` int(11) NOT NULL,
  `Preco_Total` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mesas`
--

CREATE TABLE `mesas` (
  `ID_Mesa` int(11) NOT NULL,
  `Mesa_Numero` int(11) DEFAULT NULL,
  `Nmr_Lugares` int(11) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `mesas`
--

INSERT INTO `mesas` (`ID_Mesa`, `Mesa_Numero`, `Nmr_Lugares`, `Status`) VALUES
(1, 1, 4, 'Disponível'),
(2, 2, 4, 'Disponível'),
(3, 3, 4, 'Disponível'),
(4, 4, 4, 'Disponível'),
(5, 5, 4, 'Disponível'),
(6, 6, 4, 'Disponível'),
(7, 7, 4, 'Disponível'),
(8, 8, 4, 'Disponível'),
(9, 9, 4, 'Disponível'),
(10, 10, 4, 'Disponível'),
(11, 11, 2, 'Disponível'),
(12, 12, 2, 'Disponível'),
(13, 13, 2, 'Disponível'),
(14, 14, 2, 'Disponível'),
(15, 15, 2, 'Disponível'),
(16, 16, 2, 'Disponível'),
(17, 17, 2, 'Disponível'),
(18, 18, 2, 'Disponível'),
(19, 19, 2, 'Disponível'),
(20, 20, 2, 'Disponível'),
(21, 21, 2, 'Disponível'),
(22, 22, 2, 'Disponível'),
(23, 23, 2, 'Disponível'),
(24, 24, 2, 'Disponível'),
(25, 25, 2, 'Disponível');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedidos_delivery`
--

CREATE TABLE `pedidos_delivery` (
  `ID_Ped` int(11) NOT NULL,
  `Nome_Prato` varchar(255) NOT NULL,
  `Preco_Prato` decimal(10,2) NOT NULL,
  `Custo_Entrega` decimal(10,2) NOT NULL,
  `Quantidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto_bruto`
--

CREATE TABLE `produto_bruto` (
  `ID_Produto` int(11) NOT NULL,
  `Nome_Produto` varchar(255) NOT NULL,
  `Data_Validade` date DEFAULT NULL,
  `Nmr_Serie` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `produto_bruto`
--

INSERT INTO `produto_bruto` (`ID_Produto`, `Nome_Produto`, `Data_Validade`, `Nmr_Serie`) VALUES
(1, 'Coca Cola', '2022-12-31', 'SN1111111'),
(2, 'Pepsi', '2023-12-31', 'SN2222222'),
(3, 'Sumo de Laranja', '2023-11-30', 'SN3333333'),
(4, 'Fanta', '2023-10-31', 'SN4444444'),
(5, 'Sprite', '2023-09-30', 'SN5555555'),
(6, 'Guaraná', '2023-08-31', 'SN6666666'),
(7, 'Água Mineral', '2023-07-31', 'SN7777777'),
(8, 'Cerveja', '2023-06-30', 'SN8888888'),
(9, 'Vinho Tinto', '2023-05-31', 'SN9999999'),
(10, 'Água com Gás', '2023-04-30', 'SN1010101'),
(11, 'Limonada', '2023-03-31', 'SN2020202'),
(12, 'Chá Gelado', '2023-01-31', 'SN3030303'),
(13, 'Café', '2022-12-31', 'SN4040404'),
(14, 'Leite', '2022-11-30', 'SN5050505'),
(15, 'Tomate', '2023-12-31', 'SN6060606'),
(16, 'Cebola', '2023-12-31', 'SN7070707'),
(17, 'Alho', '2023-12-31', 'SN8080808'),
(18, 'Pimentão Vermelho', '2023-12-31', 'SN9090909'),
(19, 'Peito de Frango', '2023-12-31', 'SN1212121'),
(20, 'Arroz', '2023-12-31', 'SN1313131'),
(21, 'Feijão Preto', '2023-12-31', 'SN1414141'),
(22, 'Molho de Tomate', '2023-12-31', 'SN1515151'),
(23, 'Queijo Parmesão', '2023-12-31', 'SN1616161'),
(24, 'Azeite de Oliva', '2023-12-31', 'SN1717171'),
(25, 'Cenoura', '2023-12-31', 'SN1818181'),
(26, 'Batata', '2023-12-31', 'SN1919191'),
(27, 'Salmão', '2023-12-31', 'SN2323232'),
(28, 'Espinafre', '2023-12-31', 'SN2424242'),
(29, 'Limão', '2023-12-31', 'SN2525252'),
(30, 'Pimenta Preta', '2023-12-31', 'SN2626262'),
(31, 'Sal', '2023-12-31', 'SN2727272'),
(32, 'Salsa', '2023-12-31', 'SN2828282'),
(33, 'Pão de Alho', '2023-12-31', 'SN2929292'),
(34, 'Pimentão Amarelo', '2023-12-31', 'SN3131313'),
(35, 'Bolo de Chocolate', '2023-12-31', 'SN3232323'),
(36, 'Cheesecake de Morango', '2023-11-30', 'SN3333333'),
(37, 'Pudim de Caramelo', '2023-10-31', 'SN3434343'),
(38, 'Mousse de Limão', '2023-09-30', 'SN3535353'),
(39, 'Torta de Maçã', '2023-08-31', 'SN3636363'),
(40, 'Sorvete de Baunilha', '2023-07-31', 'SN3737373'),
(41, 'Tiramisu', '2023-06-30', 'SN3838383'),
(42, 'Mousse de Chocolate', '2023-05-31', 'SN3939393'),
(43, 'Bolo de Morango', '2023-04-30', 'SN4040404'),
(44, 'Pavê de Chocolate', '2023-03-31', 'SN4141414'),
(45, 'Bolo de Cenoura', '2023-02-28', 'SN4242424'),
(46, 'Creme Brulée', '2023-01-31', 'SN4343434'),
(47, 'Sorvete de Framboesa', '2022-12-31', 'SN4444444'),
(48, 'Pudim de Leite', '2022-11-30', 'SN4545454'),
(49, 'Torta de Limão', '2022-10-31', 'SN4646464'),
(50, 'Cheesecake de Chocolate Branco', '2022-09-30', 'SN4747474'),
(51, 'Mousse de Maracujá', '2022-08-31', 'SN4848484'),
(52, 'Torta de Morango', '2022-07-31', 'SN4949494'),
(53, 'Cupcake de Baunilha', '2022-06-30', 'SN5050505'),
(54, 'Sorvete de Caramelo', '2022-05-31', 'SN5151515');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto_comestivel`
--

CREATE TABLE `produto_comestivel` (
  `ID_Prato` int(11) NOT NULL,
  `Nome_Prato` varchar(255) NOT NULL,
  `Valor_Producao` decimal(10,2) NOT NULL,
  `Valor_Venda` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `produto_comestivel`
--

INSERT INTO `produto_comestivel` (`ID_Prato`, `Nome_Prato`, `Valor_Producao`, `Valor_Venda`) VALUES
(1, 'Bacalhau à Brás', 6.00, 13.00),
(2, 'Francesinha', 6.00, 13.00),
(3, 'Arroz de Pato', 6.00, 13.00),
(4, 'Caldo Verde', 6.00, 13.00),
(5, 'Amêijoas à Bulhão Pato', 4.00, 13.00),
(6, 'Feijoada à Transmontana', 5.00, 14.00),
(7, 'Cozido à Portuguesa', 6.00, 12.00),
(8, 'Açorda de Marisco', 3.00, 10.00),
(9, 'Tripas à Moda do Porto', 6.00, 12.00),
(10, 'Arroz de Marisco', 6.00, 18.00),
(11, 'Carne de Porco à Alentejana', 6.00, 13.00),
(12, 'Polvo à Lagareiro', 6.00, 13.00),
(13, 'Robalo Grelhado', 6.00, 13.00),
(14, 'Sardinhas Assadas', 6.00, 13.00),
(15, 'Paelha à Portuguesa', 6.00, 13.00),
(16, 'Alheira de Mirandela', 6.00, 13.00),
(17, 'Salada de Polvo', 6.00, 13.00),
(18, 'Pastéis de Bacalhau', 6.00, 13.00),
(19, 'Lulas à Setubalense', 6.00, 13.00),
(20, 'Rojões à Minhota', 4.00, 9.00),
(21, 'Bifanas à Moda do Porto', 3.00, 8.00),
(22, 'Sopa de Pedra', 1.00, 3.00),
(23, 'Chanfana', 6.00, 13.00),
(24, 'Pataniscas de Bacalhau', 6.00, 13.00),
(25, 'Empadão de Pato', 6.00, 13.00),
(26, 'Bitoque', 6.00, 13.00),
(27, 'Bolo do Caco', 6.00, 13.00),
(28, 'Frango no Churrasco', 2.00, 8.00),
(29, 'Cataplana de Marisco', 6.50, 19.00),
(30, 'Feijoada', 6.00, 13.00),
(31, 'Coxinha', 6.00, 13.00),
(32, 'Acarajé', 6.00, 13.00),
(33, 'Pão de Queijo', 3.00, 6.00),
(34, 'Moqueca de Peixe', 4.00, 8.00);

-- --------------------------------------------------------

--
-- Estrutura da tabela `salarial`
--

CREATE TABLE `salarial` (
  `ID_Pagamento` int(11) NOT NULL,
  `ID_Usuario` int(11) DEFAULT NULL,
  `Valor_Pagamento` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `salarial`
--

INSERT INTO `salarial` (`ID_Pagamento`, `ID_Usuario`, `Valor_Pagamento`) VALUES
(1, 1, 2300.00),
(2, 2, 2500.00),
(3, 40, 890.00),
(4, 48, 890.00),
(5, 12, 890.00),
(6, 43, 890.00),
(7, 33, 890.00),
(8, 23, 890.00),
(9, 17, 890.00),
(10, 32, 890.00),
(11, 5, 890.00),
(12, 13, 890.00),
(13, 49, 890.00),
(14, 26, 890.00),
(15, 28, 890.00),
(16, 21, 890.00),
(17, 25, 890.00),
(18, 29, 890.00),
(19, 47, 890.00),
(20, 37, 890.00),
(21, 38, 890.00),
(22, 14, 890.00),
(23, 44, 890.00),
(24, 18, 890.00),
(25, 24, 890.00),
(26, 15, 890.00),
(27, 39, 890.00),
(28, 27, 890.00),
(29, 9, 890.00),
(30, 8, 890.00),
(31, 34, 890.00),
(32, 19, 890.00),
(33, 45, 890.00),
(34, 7, 890.00),
(35, 30, 890.00),
(36, 46, 890.00),
(37, 22, 890.00),
(38, 4, 890.00),
(39, 36, 890.00),
(40, 42, 890.00),
(41, 20, 890.00),
(42, 11, 890.00),
(43, 41, 890.00),
(44, 3, 890.00),
(45, 10, 890.00),
(46, 35, 890.00),
(47, 6, 890.00),
(48, 50, 890.00),
(49, 16, 890.00),
(50, 31, 890.00);

-- --------------------------------------------------------

--
-- Estrutura da tabela `stock`
--

CREATE TABLE `stock` (
  `id_stock` int(11) NOT NULL,
  `Produtos` varchar(255) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `id_fornecedor` int(11) DEFAULT NULL,
  `id_usuario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `stock`
--

INSERT INTO `stock` (`id_stock`, `Produtos`, `Quantidade`, `id_fornecedor`, `id_usuario`) VALUES
(1, 'Coca Cola', 500, 1, 4),
(2, 'Pepsi', 500, 2, 6),
(3, 'Sumo de Laranja', 500, 3, 9),
(4, 'Fanta', 500, 4, 12),
(5, 'Sprite', 500, 5, 15),
(6, 'Guaraná', 500, 6, 18),
(7, 'Água Mineral', 500, 7, 21),
(8, 'Cerveja', 500, 8, 24),
(9, 'Vinho Tinto', 500, 9, 27),
(10, 'Água com Gás', 500, 10, 30),
(11, 'Limonada', 500, 11, 3),
(12, 'Chá Gelado', 500, 12, 5),
(13, 'Café', 500, 13, 7),
(14, 'Leite', 500, 14, 8),
(15, 'Tomate', 500, 15, 10),
(16, 'Cebola', 500, 16, 11),
(17, 'Alho', 500, 17, 13),
(18, 'Pimentão Vermelho', 500, 18, 14),
(19, 'Peito de Frango', 500, 19, 16),
(20, 'Arroz', 500, 20, 17),
(21, 'Feijão Preto', 500, 21, 19),
(22, 'Molho de Tomate', 500, 22, 20),
(23, 'Queijo Parmesão', 500, 23, 22),
(24, 'Azeite de Oliva', 500, 24, 23),
(25, 'Cenoura', 500, 25, 25),
(26, 'Batata', 500, 26, 26),
(27, 'Salmão', 500, 27, 28),
(28, 'Espinafre', 500, 28, 29),
(29, 'Limão', 500, 29, 31),
(30, 'Pimenta Preta', 500, 30, 32),
(31, 'Sal', 500, 1, 33),
(32, 'Salsa', 500, 2, 35),
(33, 'Pão de Alho', 500, 3, 36),
(34, 'Pimentão Amarelo', 500, 4, 38),
(35, 'Bolo de Chocolate', 500, 5, 39),
(36, 'Cheesecake de Morango', 500, 6, 41),
(37, 'Pudim de Caramelo', 500, 7, 43),
(38, 'Mousse de Limão', 500, 8, 46),
(39, 'Torta de Maçã', 500, 9, 49),
(40, 'Sorvete de Baunilha', 500, 10, 1),
(41, 'Tiramisu', 500, 11, 2),
(42, 'Mousse de Chocolate', 500, 12, 3),
(43, 'Bolo de Morango', 500, 13, 4),
(44, 'Pavê de Chocolate', 500, 14, 5),
(45, 'Bolo de Cenoura', 500, 15, 6),
(46, 'Creme Brulée', 500, 16, 7),
(47, 'Sorvete de Framboesa', 500, 17, 8),
(48, 'Pudim de Leite', 500, 18, 9),
(49, 'Torta de Limão', 500, 19, 10),
(50, 'Cheesecake de Chocolate Branco', 500, 20, 11),
(51, 'Mousse de Maracujá', 500, 21, 12),
(52, 'Torta de Morango', 500, 22, 13),
(53, 'Cupcake de Baunilha', 500, 23, 14),
(54, 'Sorvete de Caramelo', 500, 24, 15);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `ID_Usuario` int(11) NOT NULL,
  `Nome_Usuario` varchar(255) NOT NULL,
  `Cargo` varchar(100) DEFAULT NULL,
  `Senha` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Contacto_telf` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`ID_Usuario`, `Nome_Usuario`, `Cargo`, `Senha`, `Email`, `Contacto_telf`) VALUES
(1, 'Joao_Silva', 'Gerente', 'joaos', 'joaos@example.com', '911234567'),
(2, 'Ana_Pereira', 'Administrador de Sistema', 'anap', 'anap@example.com', '921234567'),
(3, 'Pedro_Sousa', 'Atendente (Mesa)', 'pedros', 'pedros@example.com', '931234567'),
(4, 'Maria_Rodrig', 'Auxiliar de Estoque', 'mariar', 'mariar@example.com', '912345678'),
(5, 'Carlos_Gomes', 'Atendente (Mesa)', 'carlosg', 'carlosg@example.com', '922345678'),
(6, 'Sofia_Ferreir', 'Auxiliar de Estoque', 'sofiaf', 'sofiaf@example.com', '932345678'),
(7, 'Manuel_Silva', 'Atendente (Mesa)', 'manuels', 'manuels@example.com', '913456789'),
(8, 'Laura_Pereira', 'Atendente (Mesa)', 'laurap', 'laurap@example.com', '923456789'),
(9, 'Jose_Alves', 'Auxiliar de Estoque', 'josea', 'josea@example.com', '933456789'),
(10, 'Rita_Carvalho', 'Atendente (Mesa)', 'ritar', 'ritar@example.com', '914567890'),
(11, 'Paulo_Fernand', 'Atendente (Mesa)', 'paulof', 'paulof@example.com', '924567890'),
(12, 'Ana_Santos', 'Auxiliar de Estoque', 'anas', 'anas@example.com', '934567890'),
(13, 'Carlos_Ribeir', 'Atendente (Mesa)', 'carlosr', 'carlosr@example.com', '915678901'),
(14, 'Ines_Oliveira', 'Atendente (Mesa)', 'ineso', 'ineso@example.com', '925678901'),
(15, 'Joao_Martins', 'Auxiliar de Estoque', 'joaom', 'joaom@example.com', '935678901'),
(16, 'Susana_Silva', 'Atendente (Mesa)', 'susanas', 'susanas@example.com', '916789012'),
(17, 'Antonio_Rodri', 'Atendente (Mesa)', 'antonior', 'antonior@example.com', '926789012'),
(18, 'Isabel_Guerra', 'Auxiliar de Estoque', 'isabelg', 'isabelg@example.com', '936789012'),
(19, 'Luis_Ferreira', 'Atendente (Mesa)', 'luisf', 'luisf@example.com', '917890123'),
(20, 'Patricia_Sous', 'Atendente (Mesa)', 'patricias', 'patricias@example.com', '927890123'),
(21, 'Daniel_Pereir', 'Auxiliar de Estoque', 'danielp', 'danielp@example.com', '937890123'),
(22, 'Mariana_Silva', 'Atendente (Mesa)', 'marianas', 'marianas@example.com', '918901234'),
(23, 'Andre_Ribeiro', 'Atendente (Mesa)', 'andrer', 'andrer@example.com', '928901234'),
(24, 'Joana_Carvalh', 'Auxiliar de Estoque', 'joanac', 'joanac@example.com', '938901234'),
(25, 'Diogo_Pereira', 'Atendente (Mesa)', 'diogop', 'diogop@example.com', '919012345'),
(26, 'Carolina_Mart', 'Atendente (Mesa)', 'carolinam', 'carolinam@example.com', '929012345'),
(27, 'Jose_Rodrigue', 'Auxiliar de Estoque', 'jose.r', 'jose.r@example.com', '939012345'),
(28, 'Catarina_Sous', 'Atendente (Mesa)', 'catarinas', 'catarinas@example.com', '910123456'),
(29, 'Francisco_Sil', 'Atendente (Mesa)', 'franciscos', 'franciscos@example.com', '920123456'),
(30, 'Margarida_Fer', 'Auxiliar de Estoque', 'margaridaf', 'margaridaf@example.com', '930123456'),
(31, 'Tiago_Ribeiro', 'Atendente (Mesa)', 'tiagor', 'tiagor@example.com', '911234567'),
(32, 'Beatriz_Gomes', 'Atendente (Mesa)', 'beatrizg', 'beatrizg@example.com', '921234567'),
(33, 'Andreia_Sousa', 'Auxiliar de Estoque', 'andreias', 'andreias@example.com', '931234567'),
(34, 'Luisa_Rodrigu', 'Atendente (Mesa)', 'luisar', 'luisar@example.com', '912345678'),
(35, 'Sergio_Carval', 'Atendente (Mesa)', 'sergioc', 'sergioc@example.com', '922345678'),
(36, 'Marta_Pereira', 'Auxiliar de Estoque', 'martap', 'martap@example.com', '932345678'),
(37, 'Hugo_Silva', 'Atendente (Mesa)', 'hugos', 'hugos@example.com', '913456789'),
(38, 'Ines_Goncalve', 'Atendente (Mesa)', 'inesg', 'inesg@example.com', '923456789'),
(39, 'Joao_Santos', 'Auxiliar de Estoque', 'joaos2', 'joaos2@example.com', '933456789'),
(40, 'Ana_Carvalho', 'Atendente (Mesa)', 'anac2', 'anac2@example.com', '934567890'),
(41, 'Pedro_Pires', 'Auxiliar de Estoque', 'pedrop2', 'pedrop2@example.com', '935678901'),
(42, 'Marta_Silva', 'Atendente (Mesa)', 'martas2', 'martas2@example.com', '936789012'),
(43, 'Andre_Carvalh', 'Auxiliar de Estoque', 'andrec2', 'andrec2@example.com', '937890123'),
(44, 'Ines_Sousa', 'Atendente (Mesa)', 'iness2', 'iness2@example.com', '938901234'),
(45, 'Luis_Martins', 'Atendente (Mesa)', 'luism2', 'luism2@example.com', '939012345'),
(46, 'Mariana_Rodri', 'Auxiliar de Estoque', 'marianar2', 'marianar2@example.com', '910123456'),
(47, 'Hugo_Pereira', 'Atendente (Mesa)', 'hugop2', 'hugop2@example.com', '920123456'),
(48, 'Ana_Fernandes', 'Atendente (Mesa)', 'anaf2', 'anaf2@example.com', '930123456'),
(49, 'Carlos_Silva', 'Auxiliar de Estoque', 'carloss2', 'carloss2@example.com', '911234567'),
(50, 'Sofia_Oliveira', 'Atendente (Mesa)', 'sofiag2', 'sofiag2@example.com', '921234567');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `datalogin`
--
ALTER TABLE `datalogin`
  ADD PRIMARY KEY (`id_login`);

--
-- Índices para tabela `fatura`
--
ALTER TABLE `fatura`
  ADD PRIMARY KEY (`ID_Fatura`);

--
-- Índices para tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  ADD PRIMARY KEY (`ID_FORNECEDOR`);

--
-- Índices para tabela `mesapedido`
--
ALTER TABLE `mesapedido`
  ADD PRIMARY KEY (`ID_MesaPedido`);

--
-- Índices para tabela `mesas`
--
ALTER TABLE `mesas`
  ADD PRIMARY KEY (`ID_Mesa`);

--
-- Índices para tabela `pedidos_delivery`
--
ALTER TABLE `pedidos_delivery`
  ADD PRIMARY KEY (`ID_Ped`);

--
-- Índices para tabela `produto_bruto`
--
ALTER TABLE `produto_bruto`
  ADD PRIMARY KEY (`ID_Produto`);

--
-- Índices para tabela `produto_comestivel`
--
ALTER TABLE `produto_comestivel`
  ADD PRIMARY KEY (`ID_Prato`);

--
-- Índices para tabela `salarial`
--
ALTER TABLE `salarial`
  ADD PRIMARY KEY (`ID_Pagamento`);

--
-- Índices para tabela `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`id_stock`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID_Usuario`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `datalogin`
--
ALTER TABLE `datalogin`
  MODIFY `id_login` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT de tabela `fatura`
--
ALTER TABLE `fatura`
  MODIFY `ID_Fatura` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  MODIFY `ID_FORNECEDOR` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT de tabela `mesapedido`
--
ALTER TABLE `mesapedido`
  MODIFY `ID_MesaPedido` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `mesas`
--
ALTER TABLE `mesas`
  MODIFY `ID_Mesa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de tabela `pedidos_delivery`
--
ALTER TABLE `pedidos_delivery`
  MODIFY `ID_Ped` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `produto_bruto`
--
ALTER TABLE `produto_bruto`
  MODIFY `ID_Produto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=277;

--
-- AUTO_INCREMENT de tabela `produto_comestivel`
--
ALTER TABLE `produto_comestivel`
  MODIFY `ID_Prato` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT de tabela `salarial`
--
ALTER TABLE `salarial`
  MODIFY `ID_Pagamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT de tabela `stock`
--
ALTER TABLE `stock`
  MODIFY `id_stock` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID_Usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
