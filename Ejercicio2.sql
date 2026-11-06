USE tienda;
DESCRIBE clientes;
SELECT ID, Nombre, Correo FROM clientes;
SELECT * FROM clientes WHERE Nombre = 'Juan Pérez';
SELECT * FROM clientes ORDER BY Nombre;
SELECT COUNT(*) AS Total_clientes FROM clientes;