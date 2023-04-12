create table usuario (
administrador bit not null,
nome varchar(50) not null,
senha varchar(8) not null,
Id_usuario varchar(36) not null primary key
)
use gpsstation

INSERT INTO usuario (administrador, nome, senha, Id_usuario)
VALUES (0, 'John Doe', 'password', 'abc12345-def6-789g-hi01-jk234lmno567');

select * from usuario