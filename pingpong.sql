create database pingpong;
use pingpong;

create table jogadores(
id int not null primary key,
nome varchar(50),
idade int,
nivel varchar(50)
);

create table partidas(
id int not null primary key,
vencedor varchar(50),
data_partida datetime,
pontuacao_geral int
);

create table fases (
id int not null primary key,
nome varchar(100),
descricao text
);