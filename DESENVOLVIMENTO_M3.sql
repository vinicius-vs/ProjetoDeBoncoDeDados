CREATE DATABASE administradora DEFAULT charset utf8;

USE administradora;

/* Entidades Fortes */
CREATE TABLE estado
  (
     id   INT PRIMARY KEY auto_increment,
     nome VARCHAR(150),
     uf   VARCHAR(2)
  );

DROP TABLE estado;

CREATE TABLE cidade
  (
     id        INT PRIMARY KEY auto_increment,
     id_estado INT,
     nome      VARCHAR(100),
     CONSTRAINT fk_cidade_estado FOREIGN KEY (id_estado) REFERENCES estado (id)
  );

CREATE TABLE endereco
  (
     id               INT PRIMARY KEY auto_increment,
     id_cidade        INT,
     bairro           VARCHAR(20),
     logradouro       VARCHAR(50),
     numero           VARCHAR(20),
     cep              INT(11),
     complemento      VARCHAR(50),
     ponto_referencia VARCHAR(50),
     CONSTRAINT fk_endereco_cidade FOREIGN KEY (id_cidade) REFERENCES cidade (id
     )
  );

ALTER TABLE estado
  ADD UNIQUE index(uf);

CREATE TABLE telefone
  (
     id      INT PRIMARY KEY auto_increment,
     fixo    VARCHAR(50),
     celular VARCHAR(50)
  );

CREATE TABLE condominos
  (
     id                 INT PRIMARY KEY auto_increment,
     id_condominios     INT,
     nome               VARCHAR(150),
     email              VARCHAR(100),
     cpf                VARCHAR(12),
     senha              VARCHAR(8),
     telefone           VARCHAR(11),
     numero_bloco       CHAR(3),
     numero_apartamento VARCHAR(200),
     CONSTRAINT fk_condominos_condominios FOREIGN KEY (id_condominios)
     REFERENCES condominios (id)
  );

CREATE TABLE condominios
  (
     id          INT PRIMARY KEY auto_increment,
     id_endereco INT,
     nome        VARCHAR(100),
     cnpj        VARCHAR(14),
     CONSTRAINT fk_condominios_endereco FOREIGN KEY (id_endereco) REFERENCES
     endereco (id)
  );

CREATE TABLE funcionario
  (
     id             INT PRIMARY KEY auto_increment,
     id_endereco    INT,
     id_condominios INT,
     nome           VARCHAR(150),
     cpf            VARCHAR(12),
     turno          VARCHAR(12),
     funcao         VARCHAR(200),
     salario        FLOAT(20),
     CONSTRAINT fk_funcionario_endereco FOREIGN KEY (id_endereco) REFERENCES
     endereco (id),
     CONSTRAINT fk_funcionario_condominios FOREIGN KEY (id_condominios)
     REFERENCES condominios (id)
  );

SELECT *
FROM   funcionario;

/*ALTER TABLE funcionario ADD COLUMN turno VARCHAR(12);*/
CREATE TABLE reserva
  (
     id              INT PRIMARY KEY auto_increment,
     id_salao_festas INT,
     id_condominios  INT,
     id_condominos   INT,
     data            DATETIME,
     CONSTRAINT fk_reserva_salao_festas FOREIGN KEY (id_salao_festas) REFERENCES
     salao_festas (id),
     CONSTRAINT fk_reserva_condominios FOREIGN KEY (id_condominios) REFERENCES
     condominios (id),
     CONSTRAINT fk_reserva_condominos FOREIGN KEY (id_condominos) REFERENCES
     condominos (id)
  );

CREATE TABLE salao_festas
  (
     id            INT PRIMARY KEY auto_increment,
     id_condominos INT,
     nome          VARCHAR(150),
     numero_bloco  CHAR(3),
     CONSTRAINT fk_salao_festas_condominos FOREIGN KEY (id_condominos)
     REFERENCES condominos (id)
  );

/* Entidades Fracas */
CREATE TABLE achados_perdidos
  (
     id               INT PRIMARY KEY auto_increment,
     id_funcionario   INT,
     descricao_objeto VARCHAR(200),
     CONSTRAINT fk_achados_perdidos_funcionario FOREIGN KEY (id_funcionario)
     REFERENCES funcionario (id)
  );

CREATE TABLE ocorrencias
  (
     id                 INT PRIMARY KEY auto_increment,
     categoria          VARCHAR(200),
     descricao_completa VARCHAR(200)
  );

/* Entidades Associativas */
CREATE TABLE condominos_telefone
  (
     id_condominos INT,
     id_telefone   INT,
     PRIMARY KEY (id_condominos, id_telefone),
     CONSTRAINT fk_condominos_telefone_condominos FOREIGN KEY (id_condominos)
     REFERENCES condominos (id),
     CONSTRAINT fk_condominos_telefone_telefone FOREIGN KEY (id_telefone)
     REFERENCES telefone (id)
  );

CREATE TABLE condominios_funcionario
  (
     id_condominios INT,
     id_funcionario INT,
     PRIMARY KEY (id_condominios, id_funcionario),
     CONSTRAINT fk_condominios_funcionario_condominios FOREIGN KEY (
     id_condominios) REFERENCES condominios (id),
     CONSTRAINT fk_condominios_funcionario_funcionario FOREIGN KEY (
     id_funcionario) REFERENCES funcionario (id)
  );

CREATE TABLE condominios_condominos
  (
     id_condominios INT,
     id_condominos  INT,
     PRIMARY KEY (id_condominios, id_condominos),
     CONSTRAINT fk_condominios_condominos_condominios FOREIGN KEY (
     id_condominios) REFERENCES condominios (id),
     CONSTRAINT fk_condominios_condominos_condominos FOREIGN KEY (id_condominos)
     REFERENCES condominos (id)
  );

CREATE TABLE condominios_achados_perdidos
  (
     id_condominios      INT,
     id_achados_perdidos INT,
     PRIMARY KEY (id_condominios, id_achados_perdidos),
     CONSTRAINT fk_condominios_achados_perdidos_condominios FOREIGN KEY (
     id_condominios) REFERENCES condominios (id),
     CONSTRAINT fk_condominios_achados_perdidos_achados_perdidos FOREIGN KEY (
     id_achados_perdidos) REFERENCES achados_perdidos (id)
  );

CREATE TABLE condominios_ocorrencias
  (
     id_condominios INT,
     id_ocorrencias INT,
     PRIMARY KEY (id_condominios, id_ocorrencias),
     CONSTRAINT fk_condominios_ocorrencias_condominios FOREIGN KEY (
     id_condominios) REFERENCES condominios (id),
     CONSTRAINT fk_condominios_ocorrencias_ocorrencias FOREIGN KEY (
     id_ocorrencias) REFERENCES ocorrencias (id)
  );

CREATE TABLE condominios_reserva
  (
     id_condominios INT,
     id_reserva     INT,
     PRIMARY KEY (id_condominios, id_reserva),
     CONSTRAINT fk_condominios_reserva_condominios FOREIGN KEY (id_condominios)
     REFERENCES condominios (id),
     CONSTRAINT fk_condominios_reserva_reserva FOREIGN KEY (id_reserva)
     REFERENCES reserva (id)
  );

CREATE TABLE condominos_ocorrencias
  (
     id_condominios INT,
     id_ocorrencias INT,
     PRIMARY KEY (id_condominos, id_ocorrencias),
     CONSTRAINT fk_condominos_ocorrencias_condominos FOREIGN KEY (id_condominos)
     REFERENCES condominos (id),
     CONSTRAINT fk_condominos_ocorrencias_ocorrencias FOREIGN KEY (
     id_ocorrencias) REFERENCES ocorrencias (id)
  );

CREATE TABLE condominos_reserva
  (
     id_condominos INT,
     id_reserva    INT,
     PRIMARY KEY (id_condominos, id_reserva),
     CONSTRAINT fk_condominos_reserva_condominos FOREIGN KEY (id_condominos)
     REFERENCES condominos (id),
     CONSTRAINT fk_condominos_reserva_reserva FOREIGN KEY (id_reserva)
     REFERENCES reserva (id)
  );

/* Simular 10 inserções */
INSERT INTO estado
            (nome,
             uf)
VALUES      ('Santa Catarina',
             'SC'),
            ('Rio Grande do Sul',
             'RS');

INSERT INTO estado
            (nome,
             uf)
VALUES      ('Santa Catarina',
             'SC');

SELECT *
FROM   estado;

INSERT INTO cidade
            (id_estado,
             nome)
VALUES      (1,
             'Itajaí'),
            (1,
             'Brusque'),
            (1,
             'Porto Alegre'),
            (2,
             'Gramado');

SELECT *
FROM   estado;

SELECT *
FROM   cidade;

INSERT INTO endereco
            (id_cidade,
             logradouro,
             numero,
             bairro,
             cep,
             complemento,
             ponto_referencia)
VALUES      (2,
             'Rua Santos Dumont',
             15,
             'Santa Terezinha',
             '88352202',
             NULL,
             'Próximo ao Stop Shop');

SELECT *
FROM   endereco;

INSERT INTO telefone
            (fixo,
             celular)
VALUES      ('(47) 3198-1640',
             '(47) 1234-5678'),
            ('(47) 3098-1000',
             '(47) 12345-6789');

SELECT *
FROM   telefone;

INSERT INTO condominos
            (nome,
             cpf,
             email,
             senha,
             id_condominios,
             numero_bloco,
             numero_apartamento)
VALUES      ('Pamela',
             '34556721320',
             'pamela.gerber@hotmail.com',
             12345678,
             2,
             40,
             401),
            ('Leonardo',
             '78052721300',
             'leonardo.bigodi@hotmail.com',
             16342178,
             4,
             80,
             802),
            ('Matheus',
             '45512721330',
             'matheus_ff@hotmail.com',
             95431234,
             1,
             10,
             105),
            ('Lucas',
             '31253425605',
             'lucasw@hotmail.com',
             00975432,
             3,
             60,
             603);

SELECT *
FROM   condominos;

INSERT INTO condominos_telefone
VALUES      (1,
             3),
            (1,
             2);

SELECT *
FROM   condominos_telefone;

SELECT *
FROM   condominos;

SELECT *
FROM   telefone;

INSERT INTO condominios
            (id_endereco,
             nome,
             cnpj)
VALUES      (1,
             'Santa madalena',
             12345678934567),
            (2,
             'Pasquallotto',
             34215789054323),
            (1,
             'Piradao',
             56789045321567),
            (2,
             'Marquezine',
             76214569876543);

SELECT *
FROM   condominios;

INSERT INTO funcionario
            (id_endereco,
             id_condominios,
             nome,
             cpf,
             turno,
             funcao,
             salario)
VALUES      (2,
             2,
             'Francisco',
             '95438047000',
             'matutino',
             'jardineiro',
             1500.00),
            (2,
             1,
             'Leopoldo',
             '34528900000',
             'noturno',
             'segurança',
             1000.00);

SELECT *
FROM   funcionario;

INSERT INTO reserva
            (id_condominios,
             id_condominos,
             id_salao_festas,
             data)
VALUES      (1,
             1,
             2,
             '2022-10-12 12:30:30.000000');

SELECT *
FROM   reserva;

INSERT INTO salao_festas
            (id_condominos,
             nome,
             numero_bloco)
VALUES      (3,
             'Camila',
             '50');

SELECT *
FROM   salao_festas;

/* Simular 5 atualizações (com WHERE) */
UPDATE funcionario
SET    nome = 'Francisco'
WHERE  id = 1;

UPDATE condominios
SET    id_endereco = 2
WHERE  id = 3;

UPDATE salao_festas
SET    nome = 'Camila'
WHERE  id = 1;

UPDATE condominos
SET    nome = 'Paulo'
WHERE  id = 4;

UPDATE condominos
SET    numero_apartamento = '401'
WHERE  id = 8;

/* Simular 5 exclusões (com WHERE) */
DELETE FROM telefone
WHERE  id = 1;

DELETE FROM condominos_telefone
WHERE  id_telefone = 1;

DELETE FROM telefone
WHERE  id = 1; # tentamos excluir novamente
DELETE FROM funcionario
WHERE  id = 4;

DELETE FROM condominos
WHERE  id = 2;

/* Dez seleções de dados, sendo, no mínimo, cinco utilizando JOIN*/
SELECT *
FROM   condominos
       INNER JOIN condominios
               ON condominos.nome = condominios.nome;

SELECT funcionario.nome,
       endereco.logradouro,
       endereco.numero
FROM   funcionario
       INNER JOIN endereco
               ON funcionario.id_endereco = endereco.id;

SELECT *
FROM   salao_festas
       LEFT JOIN reserva
              ON salao_festas.id = reserva.id_salao_festas;

SELECT *
FROM   condominios
       RIGHT JOIN condominos
               ON condominios.id = condominos.id_condominios;

SELECT *
FROM   condominios
       INNER JOIN funcionario
               ON condominios.id = funcionario.id_condominios;

-- Mostre a quantidade de funcionario que existem por condominios. Colocar o nome da condominios e a quantidade.
SELECT co.nome      AS condominios,
       Count(fu.id) AS quantidade_funcionario
FROM   funcionario fu
       INNER JOIN condominios co
               ON fu.id_condominios = co.id
GROUP  BY condominios
ORDER  BY quantidade_funcionario DESC,
          condominios;

-- Crie uma visão para mostrar apenas o nome do condominio de Itajaí.
CREATE view condominios_itj
AS
  SELECT nome
  FROM   condominios
  WHERE  id_endereco = 1;

SELECT *
FROM   condominios_itj;

-- Mostre apenas os condominos que começam com a letra L.
SELECT *
FROM   condominos
WHERE  nome LIKE 'l%';

-- Mostre apenas os condominios que começam com a letra P.
SELECT *
FROM   condominios
WHERE  nome LIKE 'p%';

-- Mostre o nome do condominio do Rio Grande do Sul 
SELECT con.nome
FROM   condominios con
       INNER JOIN endereco en
               ON en.id = con.id_endereco
       INNER JOIN cidade ci
               ON ci.id = en.id_cidade
       INNER JOIN estado es
               ON es.id = ci.id_estado
WHERE  es.uf = 'RS';






