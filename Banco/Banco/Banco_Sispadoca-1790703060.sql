-- Formulário do cliente
CREATE TABLE IF NOT EXISTS `Clientes` (
	`id_clientes` int AUTO_INCREMENT NOT NULL UNIQUE,
	`CPF` varchar(11) NOT NULL UNIQUE COMMENT 'CPF do cliente',
	`Nome` varchar(100) NOT NULL COMMENT 'Nome do Cliente',
	`Sexo` varchar(30) NOT NULL COMMENT 'Sexo do cliente',
	`Data_Nascimento` date NOT NULL UNIQUE COMMENT 'Nascimento do cliente ',
	`Celular` varchar(11) NOT NULL COMMENT 'Celular ou celulares do cliente',
	`Email` varchar(100) COMMENT 'Email do cliente',
	`CEP` varchar(10) NOT NULL COMMENT 'CEP do cliente',
	`Endereco` varchar(100) NOT NULL COMMENT 'Endereço do cliente',
	`Bairro` varchar(100) NOT NULL COMMENT 'Bairro do cliente',
	`Cidade` varchar(100) NOT NULL COMMENT 'Cidade do cliente',
	`Estado` varchar(100) NOT NULL COMMENT 'Estado do cliente',
	`Observacoes` text NOT NULL COMMENT 'Observações do cliente',
	PRIMARY KEY (`id_clientes`)
) COMMENT='Formulário do cliente';
-- Formulário do cliente
CREATE TABLE IF NOT EXISTS `Cliente` (
	`id_clientes` int AUTO_INCREMENT NOT NULL UNIQUE,
	`CPF` varchar(11) NOT NULL UNIQUE COMMENT 'CPF do cliente',
	`Nome` varchar(100) NOT NULL COMMENT 'Nome do Cliente',
	`Sexo` varchar(30) NOT NULL COMMENT 'Sexo do cliente',
	`Data_Nascimento` date NOT NULL UNIQUE COMMENT 'Nascimento do cliente ',
	`Celular` varchar(11) NOT NULL COMMENT 'Celular ou celulares do cliente',
	`Email` varchar(100) COMMENT 'Email do cliente',
	`CEP` varchar(10) NOT NULL COMMENT 'CEP do cliente',
	`Endereco` varchar(100) NOT NULL COMMENT 'Endereço do cliente',
	`Bairro` varchar(100) NOT NULL COMMENT 'Bairro do cliente',
	`Cidade` varchar(100) NOT NULL COMMENT 'Cidade do cliente',
	`Estado` varchar(100) NOT NULL COMMENT 'Estado do cliente',
	`Observacoes` text NOT NULL COMMENT 'Observações do cliente',
	PRIMARY KEY (`id_clientes`)
) COMMENT='Formulário do cliente';
CREATE TABLE IF NOT EXISTS `Produto` (
	`id_produto` int AUTO_INCREMENT NOT NULL UNIQUE,
	`Nome` varchar(100) NOT NULL UNIQUE,
	`Cod_Prod` varchar(100) NOT NULL UNIQUE,
	`Fornecedor` int NOT NULL,
	`Fabricante` varchar(100) NOT NULL,
	`Entrega` date NOT NULL,
	`Quantidade` int NOT NULL,
	`Lote` varchar(100) NOT NULL,
	`Descricao` text NOT NULL,
	PRIMARY KEY (`id_produto`)
);
CREATE TABLE IF NOT EXISTS `Fornecedor` (
	`id_fornecedor` int AUTO_INCREMENT NOT NULL UNIQUE,
	PRIMARY KEY (`id_fornecedor`)
);
ALTER TABLE `Produto` ADD CONSTRAINT `Produto_fk3` FOREIGN KEY (`Fornecedor`) REFERENCES `Fornecedor`(`id_fornecedor`);