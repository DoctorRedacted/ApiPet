create database petDB;
use petDB;

create table tb_pet (
	id_pet			int primary key auto_increment,
	nm_nome			varchar(50),
    vl_idade		int,
    dt_nascimento	date
);