create database contabil

use contabil

create table produtos(
	id integer primary key identity,
	nome varchar(30),
	compra money,
	venda money,
	icmsCompra money,
	pisCompra money,
	cofinsCompra money,
	icmsVenda money,
	pisVenda money,
	cofinsVenda money
)

create login usuario with password='senha';
create user usuario from login usuario;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

select * from produtos

create table empresa(
	id integer primary key identity,
	capital money,
	caixa money,
	custo money,
	despesa money,
	obrigacoes money,
	bens money,
	direitos money
)

insert into empresa values 
(0,0,0,0,0,0,0)

select * from empresa

insert into empresa (despesa) values (500)

drop table empresa
