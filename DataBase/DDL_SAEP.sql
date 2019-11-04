CREATE DATABASE SAEP;

USE SAEP;

CREATE TABLE USUARIO(
Id  int identity primary key,
Email varchar(250) unique not null,
Senha Varchar(250) not null
);

CREATE TABLE TIPO_EQUIPAMENTO(
Id  int identity primary key,
Nome varchar(250) unique not null
);

CREATE TABLE DEFEITO(
Id  int identity primary key,
NomeDefeito varchar(250) unique not null
);

CREATE TABLE REGISTRO_DEFEITO(
Id  int identity primary key,
Data_Registro datetime not null,
Id_Tipo_equipamento int foreign key references TIPO_EQUIPAMENTO(id) not null,
Id_Defeito int foreign key references DEFEITO(id) not null,
Descricao text not null
);