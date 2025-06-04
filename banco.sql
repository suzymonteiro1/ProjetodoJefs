CREATE DATABASE login_db;

USE login_db;

CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    email VARCHAR(100) NOT NULL,
    senha VARCHAR(100) NOT NULL
);

CREATE TABLE Produtos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    descricao TEXT,
    valor DECIMAL(10,2) NOT NULL,
    categoria VARCHAR(50),
    estoque INT DEFAULT 0,
    data_cadastro DATETIME DEFAULT CURRENT_TIMESTAMP,
    peso DECIMAL(6,2),
    largura DECIMAL(6,2),
    altura DECIMAL(6,2),
    profundidade DECIMAL(6,2)
);

INSERT INTO Produtos (nome, descricao, valor, categoria, estoque, peso, largura, altura, profundidade) VALUES
(
    'Bicicleta Mountain Bike Aro 29  ',
    'Bicicleta ideal para trilhas e uso urbano, aro 29, suspensão dianteira, 21 velocidades.',
    1499.90,
    'Ciclismo',
    15,
    13.50,
    25.00,
    90.00,
    110.00
),
(
	'Tênis de Corrida FlexRun 2000   ',
    'Leve e confortável, solado com amortecimento, ideal para corridas longas.',
    299.99,
    'Calçados',
    30,
    0.45,
    12.00,
    30.00,
    20.00
),
(	
	'Bola de Futebol Campo Pro Soccer',
    'Bola oficial de campo, tamanho 5, material durável e costuras termoplásticas.',
    89.90,
    'Futebol',
    50,
    0.42,
    22.00,
    22.00,
    22.00
),
(
	'Mochila Esportiva 30L UltraLight',
    'Mochila leve e resistente à água, com compartimento para laptop e hidratação.',
    149.90,
    'Acessórios',
    20,
    0.80,
    30.00,
    50.00,
    15.00
),
(
	'Barra de Proteína Whey Chocolate',
    'Barra de proteína sabor chocolate, 20g de whey protein por unidade.',
    7.50,
    'Nutrição',
    200,
    0.06,
    5.00,
    15.00,
    3.00
);

INSERT INTO usuarios (email, senha) VALUES
('teste@email.com', '123456');

select * from usuarios;

SELECT * FROM Produtos;

DROP TABLE Produtos;