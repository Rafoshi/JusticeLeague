create database if not exists db_justiceLeague;
use db_justiceLeague;

CREATE TABLE IF NOT EXISTS equipamentos (
    id_equipamentos int primary key auto_increment,
    nome_equipamento varchar(30),
    descricao varchar(60),
    finalidade varchar(30)
);

create table if not exists herois (
	id_heroi int primary key auto_increment,
    nome_heroi varchar(30),
    codinome varchar(30),
    especie varchar(30),
    habilidade varchar(80),
    vulnerabilidade varchar(30),
    nivel_de_acessso tinyint,
    fk_equipamentos_id int not null,
    foreign key (fk_equipamentos_id) references equipamentos (id_equipamentos)
);

create table if not exists viloes (
	id_vilao int primary key auto_increment,
    nome_vilao varchar(30),
    codinome varchar(30),
    especie varchar(30),
    vulnerabilidade varchar(30),
    nivel_de_acesso int,
    habilidade varchar(80),
    esconderijo varchar(30),
    fk_herois_rivais int(30) not null,
    fk_equipamentos_id int not null,
    foreign key (fk_equipamentos_id) references equipamentos (id_equipamentos),
    foreign key (fk_herois_rivais) references herois (id_heroi)
);

create table if not exists ataques (
	id_ataque int primary key auto_increment,
    local_ataque varchar(30) not null,
    data_ataque date not null,
    hora time not null,
    fk_vilao int not null,
    foreign key (fk_vilao) references viloes (id_vilao)
);

drop database if exists db_justiceleague;