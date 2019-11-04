USE SAEP;

INSERT INTO USUARIO(EMAIL,SENHA)
VALUES('admin@admin.com', 'admin');

INSERT INTO TIPO_EQUIPAMENTO(NOME)
VALUES ('XBOX ONE'),('PLAYSTATION 4'),('NINTENDO WII U');

INSERT INTO DEFEITO(NomeDefeito)
VALUES ('Não Liga'),('Desligando'),('Imagem'),('Internet'),('Fonte'),('HD');

BULK INSERT REGISTRO_DEFEITO
FROM 'C:\csv\registro_defeito.csv'
with(
fieldterminator = ',',
rowterminator = '\n',
firstrow = 1,
codepage = 'acp'
);