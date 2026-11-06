USE tienda;
SET SQL_SAFE_UPDATES = 0;
DELETE FROM clientes WHERE ID > 0;
SET SQL_SAFE_UPDATES = 1;
INSERT INTO clientes (Nombre, Correo)
VALUES ('Juan Pérez', 'juan@mail.com');
INSERT INTO clientes (Nombre, Correo)
VALUES ('Ana López', 'ana@mail.com');
SELECT * FROM clientes;
SET SQL_SAFE_UPDATES = 0;
DELETE FROM clientes WHERE Nombre = 'Ana López';
SET SQL_SAFE_UPDATES = 1;
SELECT * FROM clientes;