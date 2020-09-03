create database hotel;
use hotel;



/*Criancao das Tabelas*/
create table funcionarios
(
	id INTEGER IDENTITY(1001,1) PRIMARY KEY NOT NULL,
	Nome varchar(50) NOT NULL,
	email varchar(50) NOT NULL,
	cpf varchar(11) NOT NULL,
	senha varchar(150) NOT NULL,
	salario decimal(10,2) NOT NULL,
	telefone varchar(10),
	celular varchar(11),
	cidade  varchar(50) NOT NULL,
	uf varchar(50) not null,
	endereco  varchar(100) NOT NULL,
	cargo varchar(50) NOT NULL,
	data_nascimento date NOT NULL,
	data_admisao date
);

Create table hospedes
(
	hospede_id INTEGER IDENTITY(10001,1) PRIMARY KEY NOT NULL,
	nome varchar(50) NOT NULL,
	email varchar(50) NOT NULL,
	numero_do_quarto varchar(20), 
	telefone varchar(10),
	celular varchar(11),
	cpf varchar(11) NOT NULL,
	cnpj varchar(14),
	cep varchar(8),
	cidade  varchar(50) NOT NULL,
	uf varchar(50) not null,
	data_nascimento date NOT NULL,
	data_entrada datetime,
	data_saida datetime,
);

create table quartos
(
	id_quarto int PRIMARY KEY,
	cpf_hospede varchar(11),
	nome_do_hospede varchar(50),
	tipo_do_quarto varchar(50),
	dataEntrada date,
	dataSaida date
);

create table registrosQuartos
(
	numero_do_quarto int PRIMARY KEY,
	tipo_de_quarto varchar(50),
	status_quarto varchar(20)
);



/*Selects*/
select * from funcionarios;
select * from hospedes;
select * from quartos;
select * from registrosQuartos;




/*Alteraçoes*/
alter table hospedes
add cep varchar(8);

alter table registrosQuartos 
add status_quarto varchar(20);




/*Crianção da view*/
create view registroQuartosCompleto(quarto_completo)
as
	
	select
		 CAST(numero_do_quarto AS VARCHAR) + ' - ' + tipo_de_quarto 
	from
		registrosQuartos
	where status_quarto = 'vazio' or  status_quarto = 'broken';

drop view registroQuartosCompleto;
select * from registroQuartosCompleto;


delete hospedes where cpf = '56275154063';
delete quartos where cpf_hospede = '56275154063';

select * from hospedes;
select * from quartos;



/*Testes*/

SELECT COUNT(*) FROM quartos WHERE id_quarto = 1;
SELECT COUNT(2) FROM quartos WHERE cpf_hospede='93905661004';

SELECT cpf_hospede FROM quartos WHERE cpf_hospede='93905661004';
SELECT id_quarto FROM quartos WHERE id_quarto = 4;


select senha from funcionarios where cpf =' ';
SELECT cpf FROM funcionarios WHERE cpf='423';


SELECT id_quarto, nome_do_hospede, tipo_do_quarto, dataEntrada, dataSaida FROM quartos WHERE cpf_hospede = '56275154063';

UPDATE registrosQuartos SET status_quarto = 'vazio' WHERE numero_do_quarto = 2;


select * from funcionarios;
select * from hospedes;
select * from quartos;
select * from registrosQuartos;


