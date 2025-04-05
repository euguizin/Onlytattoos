create database clientes;
use clientes;
create table tb_clientes (
cpf varchar(14) not null primary key,
nome varchar(60),
email varchar(60),
telefone varchar(15),
data_nasc varchar(10),
ficha varchar(3))

select * from tb_clientes


create table tb_agendamento (
cpf varchar(14) primary key,
nome varchar(60),
dia varchar(15),
horario varchar(8))


CREATE TABLE tb_agulhas (
    tipo varchar(2),
    espessura varchar(2),
    qtd_agulhas varchar(2),
    qtd_comprada int,
    valor_total money,
    valor_uni AS CAST(valor_total AS DECIMAL) / CAST(qtd_comprada AS DECIMAL)
)

drop table tb_batoques
create table tb_batoques (
tamanho varchar(15),
quantidade int,
valor_total money,
valor_uni AS CAST(valor_total AS DECIMAL) / CAST(quantidade AS DECIMAL)
)
 
create table tb_tintas (
cor varchar(30),
quantidade int,
valor_total money,
valor_uni AS CAST(valor_total AS DECIMAL) / CAST(quantidade AS DECIMAL)
)


create table tb_produtos_geral (
produto varchar(20),
quantidade int,
valor_total money,
valor_uni AS CAST(valor_total AS DECIMAL) / CAST(quantidade AS DECIMAL)

)
