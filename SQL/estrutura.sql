DROP TABLE IF EXISTS animais;
CREATE TABLE animais(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
extinto BIT 
);

SELECT * FROM animais;

--adicionar coluna na tabela
ALTER TABLE animais ADD peso DECIMAL (4,2) DEFAULT 0.0;

UPDATE animais SET peso = 0;

--apagar coluna da tabela
--ALTER TABLE animais DROP CONSTRAINT DF_animais_peso_2589641;
--ALTER TABLE animais DROP COLUMN peso;

DROP TABLE IF EXISTS habilidades;
CREATE TABLE habilidades(
id INT PRIMARY KEY IDENTITY(1,1),
id_animal INT, FOREIGN KEY(id_animal) REFERENCES animais(id),
nome VARCHAR(100),
);

SELECT * FROM habilidades;
