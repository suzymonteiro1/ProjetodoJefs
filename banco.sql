CREATE DATABASE Esportes;
USE Esportes;

CREATE TABLE Cliente (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf char(11) NOT NULL,
    bairro VARCHAR(70) NOT NULL,
    cidade VARCHAR(70) NOT NULL,
    estado VARCHAR(70) NOT NULL,
    email VARCHAR(100) NOT NULL,
    senha VARCHAR(20) NOT NULL
);

CREATE TABLE Funcionario (
	id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf char(11) NOT NULL,
    bairro VARCHAR(70) NOT NULL,
    cidade VARCHAR(30) NOT NULL,
    estado VARCHAR(30) NOT NULL,
    email VARCHAR(100) NOT NULL,
    senha VARCHAR(20) NOT NULL
);

CREATE TABLE Produtos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    descricao TEXT,
    valor DECIMAL(10,2) NOT NULL,
    categoria VARCHAR(50),
    estoque INT DEFAULT 0,
    data_cadastro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    peso DECIMAL(6,2),
    largura DECIMAL(6,2),
    altura DECIMAL(6,2),
    profundidade DECIMAL(6,2)
);

select * from Produtos;