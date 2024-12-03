CREATE DATABASE SistemaEstoque;

USE SistemaEstoque;

-- Tabela de Produtos
CREATE TABLE Produtos (
    IdProduto INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Quantidade INT NOT NULL,
    Preco DECIMAL(10, 2) NOT NULL
);

-- Tabela de Fornecedores
CREATE TABLE Fornecedores (
    IdFornecedor INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Telefone VARCHAR(15)
);

-- Tabela de Pedidos
CREATE TABLE Pedidos (
    IdPedido INT AUTO_INCREMENT PRIMARY KEY,
    IdProduto INT NOT NULL,
    IdFornecedor INT NOT NULL,
    Quantidade INT NOT NULL,
    DataPedido DATE NOT NULL,
    FOREIGN KEY (IdProduto) REFERENCES Produtos(IdProduto) ON DELETE CASCADE,
    FOREIGN KEY (IdFornecedor) REFERENCES Fornecedores(IdFornecedor) ON DELETE CASCADE
);

-- Inserção de Dados Iniciais
INSERT INTO Produtos (Nome, Quantidade, Preco) VALUES 
('Salgado Frito', 20, 7.50),
('Bombom', 20, 1.50),
('Refrigerante', 30, 5.00),
('Salgado Assado', 25, 8.00);

INSERT INTO Fornecedores (Nome, Telefone) VALUES 
('Padaria da Marcia', '111111111'),
('Panificadora Laelia', '222222222'),
('Distribuidora da Vila', '333333333');

INSERT INTO Pedidos (IdProduto, IdFornecedor, Quantidade, DataPedido) VALUES 
(1, 1, 10, '2005-03-28'),
(2, 2, 30, '2019-11-03'),
(3, 3, 20, '2024-12-02');
