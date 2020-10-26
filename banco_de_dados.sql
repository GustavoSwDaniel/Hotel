create database dbHotel;
use dbHotel;

---Criando a tablea Funcionario
create table funcionario (
	id INTEGER IDENTITY(1001,1) PRIMARY KEY NOT NULL,
	Nome varchar(50) NOT NULL,
	email varchar(50) NOT NULL,
	cpf varchar(11) UNIQUE NOT NULL,
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

---Criando tabla de hospedes
Create table hospedes (
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

--- Criando tabla Registro de Quartos
create table registrosQuartos (
	numero_do_quarto int PRIMARY KEY,
	tipo_de_quarto varchar(50),
	valor_do_quarto smallmoney,
	status_quarto varchar(20),
);

---Criando Tabla Quartos
create table quartos (
	id_quarto int PRIMARY KEY,
	numero_do_quarto int,
	hospede_id int,
	numero_de_ocupantes int,
	status_de_pagamento varchar(20),
);




/***Alterações nas tablelas***/




alter table quartos add constraint FK_numero_do_quarto foreign key (numero_do_quarto)
references registrosQuartos (numero_do_quarto);

alter table quartos add constraint FK_hospede_id foreign key (hospede_id)
references hospedes (hospede_id);


/***Criando Views***/
create view checkOutView(idQuarto, idHospede, numero_quarto, nome_hospede, cpf, status_de_pagamento, tipo_de_quarto, status_quarto, data_entrada, data_saida) 
as
	select 
	id_quarto, h.hospede_id ,h.numero_do_quarto, h.nome, h.cpf,status_de_pagamento, r.tipo_de_quarto, r.status_quarto, h.data_entrada, h.data_saida  from quartos
	INNER JOIN hospedes as h
	ON quartos.hospede_id = h.hospede_id
	INNER JOIN registrosQuartos as r
	ON quartos.numero_do_quarto = r.numero_do_quarto


drop view checkOutView;


create view registroQuartosCompleto(quarto_completo)
as
	select CAST(numero_do_quarto AS VARCHAR) + ' - ' + tipo_de_quarto 	 
	from registrosQuartos	
	where status_quarto = 'vazio'


/***Criando o procedimentos***/
create procedure Busca
	@cpf varchar(11)
	as
	select idQuarto, idHospede, numero_quarto, nome_hospede, cpf, status_de_pagamento, tipo_de_quarto, status_quarto, data_entrada, data_saida
	from checkOutView
	where cpf = @cpf

exec Busca 38103161055;
drop proc Busca;

create procedure Excluir
	@idHospede int,
	@id_quarto int,
	@numeroQuarto int
	as
	delete from quartos where id_quarto = @id_quarto
	delete from hospedes where hospede_id = @idHospede
	update registrosQuartos set status_quarto = 'vazio' where numero_do_quarto = @numeroQuarto;

exec Excluir 10014, 1,1
drop proc Excluir


create procedure updadeQuartos
	@novoID int,
	@antigoId int,
	@statusOcupado varchar(20) = 'ocupado',
	@statusVazio varchar(20)  = 'vazio'

	as
	UPDATE quartos set id_quarto = @novoID, numero_do_quarto = @novoID where id_quarto = @antigoId;
	UPDATE registrosQuartos set status_quarto = @statusVazio where numero_do_quarto = @antigoId;
	UPDATE registrosQuartos set status_quarto = @statusOcupado where numero_do_quarto = @novoID;

exec updadeQuartos 4, 1

select * from hospedes;
select * from quartos;
select * from registrosQuartos;

UPDATE quartos set id_quarto = 4, numero_do_quarto = 4 where id_quarto = 3;
UPDATE registrosQuartos set status_quarto = 'vazio' where numero_do_quarto = 3;
UPDATE registrosQuartos set status_quarto = 'ocupado' where numero_do_quarto = 4;




create procedure create_default_user
AS
	IF not EXISTS(select * from funcionario where Nome='admin')
		INSERT INTO funcionario(Nome, email, cpf, senha, salario, telefone, celular, cidade, uf, endereco, cargo, data_nascimento, data_admisao)
		values('admin', 'admin', 'admin', '$2a$11$Ix9rUaS.A2qzvinpxwstsu07O5Ozmsl88y8fxgNWwSUChaSbwZjPm', '0', '0', '0', 'n/d', 'n/d', 'n/d', 'admin', CONVERT(DATE, GETDATE()) ,CONVERT(DATE, GETDATE()))


exec create_default_user

create procedure update_senha
	@cpf varchar(11),
	@nova_senha varchar(150)

AS
	UPDATE funcionario SET senha = @nova_senha where cpf = @cpf 


----Selects----
-----Tables----
select * from funcionario;
select * from hospedes;
select * from quartos;
select * from registrosQuartos;
-----Views----
select * from checkOutView;
select * from listQuarto

create procedure mostrarInfoHospedes
AS
	select 
		id_quarto as 'ID reserva', 
		h.hospede_id as 'ID hospede',
		h.numero_do_quarto as 'Numero do Quarto', 
		h.nome as 'Nome', 
		h.cpf as 'CPF',
		status_de_pagamento as 'Status de Pagamento', 
		r.tipo_de_quarto as 'Tipo do Quarto', 
		r.status_quarto as 'Status do Quarto', 
		h.data_entrada as 'Data de entrada', 
		h.data_saida as 'Data de Saida'  
	from quartos
		INNER JOIN hospedes as h
		ON quartos.hospede_id = h.hospede_id
		INNER JOIN registrosQuartos as r
		ON quartos.numero_do_quarto = r.numero_do_quarto

exec mostrarInfoHospedes
exec mostrarQuartos
exec mostrarQuartosRegistrados
exec mostrarFuncionarios
exec mostrarHospedes







create view listQuarto(numeroQuarto, tipo_do_quarto, status_quarto, data_saida)
as
	select r.numero_do_quarto, r.tipo_de_quarto, r.status_quarto, h.data_saida from quartos
	INNER JOIN hospedes as h
	ON quartos.hospede_id = h.hospede_id
	INNER JOIN registrosQuartos as r
	ON quartos.numero_do_quarto = r.numero_do_quarto


DROP VIEW listQuarto





