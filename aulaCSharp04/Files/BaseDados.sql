--CREATE DATABASE MyFinanceiro;
--USE MyFinanceiro;

--CREATE TABLE tbUsuario ( id_usuario        INT IDENTITY PRIMARY KEY
--                       , tp_usuario        INT
--                       , nome_usuario      VARCHAR(100)
--                       , email_usuario     VARCHAR(100)
--                       , documento_usuario VARCHAR(20)
--                       , celular_usuario   VARCHAR(20)
--                       , senha_usuario     VARCHAR(20)	
--                       )
--                       ;

--CREATE TABLE tbFormaPagamento ( id_forma   INT IDENTITY PRIMARY KEY
--                              , nome_forma VARCHAR(100)
--                              )
--                              ;

--CREATE TABLE tbRecebimento ( id_recebimento INT IDENTITY PRIMARY KEY
--                           , id_usuario     INT FOREIGN KEY REFERENCES tbUsuario(id_usuario)
--                           , data_vcto      DATETIME DEFAULT GETDATE()
--                           , valor          FLOAT
--                           , id_forma       INT FOREIGN KEY REFERENCES tbFormaPagamento(id_forma)
--                           , descricao      VARCHAR(1000)
--                           )
--                           ;


--INSERT INTO tbUsuario (tp_usuario, nome_usuario, email_usuario, documento_usuario, celular_usuario)
--               VALUES (1, 'Carrefour Supermercados', 'carrefour@carrefour.com.br', '22.222.222/0001-22', '11-2222-2222');

--INSERT INTO tbUsuario (tp_usuario, nome_usuario, email_usuario, documento_usuario, celular_usuario)
--               VALUES (2, 'Assaí', 'atendimento@assai.com.br', '33.333.333/0001-33', '11-3333-3333');

--INSERT INTO tbFormaPagamento (nome_forma) VALUES ('Dinheiro')
--                                               , ('PIX')
--                                               , ('Cartão de Débito')
--                                               , ('Cartão de Crédito')
--                                               ;

--UPDATE tbUsuario
--   SET tbUsuario.tp_usuario = 2
-- WHERE tbUsuario.tp_usuario = 3

--DELETE tbusuario
--  FROM tbUsuario
-- WHERE tbUsuario.id_usuario = 5


--ALTER TABLE tbusuario
--	    ADD status_usuario INT DEFAULT(1)

--UPDATE tbUsuario
--   SET tbUsuario.status_usuario = 1
--UPDATE tbUsuario
--   SET tbUsuario.status_usuario = 0
-- WHERE tbUsuario.id_usuario = 2

SELECT *
  FROM tbUsuario

SELECT *
  FROM tbFormaPagamento

SELECT *
  FROM tbRecebimento

--INSERT INTO tbRecebimento (id_usuario, data_vcto, valor, id_forma, descricao)
--     VALUES (1, GETDATE(), 1000, 1, 'Recebimento 01')
--          , (1, GETDATE(), 1002, 2, 'Recebimento 02')
--          , (2, GETDATE(), 1050, 3, 'Recebimento 03')
--          , (2, GETDATE(), 1050, 4, 'Recebimento 03')

