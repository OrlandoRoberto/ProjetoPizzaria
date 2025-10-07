-- criando banco de dados

create database dbpizza;
-- usando o banco de dados
use dbpizza;

-- criando as tabelas do banco de dados
create table tbPedido(
coodPedido int primary key auto_increment,
tipoPizza varchar(50),
valorPizza varchar(50),
valorTotal varchar(50)
);
-- consultando as tabelas do banco de dados
select *from tbPedido;
