create database csharp_crud_lojinha;
use csharp_crud_lojinha;

create table produto(
id int not null auto_increment primary key,
codigo varchar(20) not null,
nome varchar(50) not null,
fornecedor_nome varchar(50) not null,
preco double(9,2) not null,
quantidade int not null,
ativo char(1) default 's'
);

select * from produto;
drop table produto