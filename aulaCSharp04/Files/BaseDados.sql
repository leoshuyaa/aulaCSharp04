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

--INSERT INTO tbUsuario (tp_usuario, nome_usuario, email_usuario, documento_usuario, celular_usuario)
--               VALUES (1, 'Carrefour Supermercados', 'carrefour@carrefour.com.br', '22.222.222/0001-22', '11-2222-2222');

SELECT *
  FROM tbUsuario
