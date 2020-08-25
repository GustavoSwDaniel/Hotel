create database hotel;


use hotel;


create table funcionarios
(
	id INTEGER IDENTITY(1001,1) PRIMARY KEY NOT NULL,
	Nome varchar(50) NOT NULL,
	sobrenome varchar(50) NOT NULL,
	email varchar(50) NOT NULL,
	senha varchar(150) NOT NULL,
	telefone varchar(10),
	cidade  varchar(50) NOT NULL,
	uf varchar(2) not null,
	celular varchar(11),
	cpf varchar(11) NOT NULL,
	endereco  varchar(100) NOT NULL,
	salario decimal(10,2) NOT NULL,
	cargo varchar(50) NOT NULL,
	data_nascimento date NOT NULL,
	data_admisao date
);



Create table hospedes
(
	hospede_id INTEGER IDENTITY(10001,1) PRIMARY KEY NOT NULL,
	Nome varchar(50) NOT NULL,
	sobrenome varchar(50) NOT NULL,
	numero_do_quarto int, 
	telefone varchar(10),
	celular varchar(11),
	cpf varchar(11) NOT NULL,
	cidade  varchar(50) NOT NULL,
	uf varchar(2) not null,
	data_nascimento date NOT NULL,
);


create table quartos
(
	id_quarto int PRIMARY KEY,
	id_hospede int,
	nome_do_hospede varchar(50),
	tipo_do_quarto varchar(50),
	data_entrada date,
	data_saida date
);




select * from funcionarios;
select * from hospedes;
select * from quartos;


drop table funcionarios;
drop table hospedes;
drop table quartos;

alter table hospedes
add cep varchar(8);