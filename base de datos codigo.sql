USE Tienda;

CREATE TABLE Categoria (
    Codigo INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL
);

CREATE TABLE Producto (
    Codigo INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Cantidad INT NOT NULL,
    Categoria INT NOT NULL,
    FOREIGN KEY (Categoria) REFERENCES Categoria(Codigo)
);

-- Insertar categorías
INSERT INTO Categoria (Nombre) VALUES ('Electrónica');
INSERT INTO Categoria (Nombre) VALUES ('Ropa');

-- Insertar productos
INSERT INTO Producto (Nombre, Precio, Cantidad, Categoria) 
VALUES ('Audífonos', 25.50, 15, 1);

INSERT INTO Producto (Nombre, Precio, Cantidad, Categoria) 
VALUES ('Camiseta', 12.00, 30, 2);

INSERT INTO Producto (Nombre, Precio, Cantidad, Categoria) 
VALUES ('Cargador USB', 18.75, 20, 1);

-- Eliminar producto
DELETE FROM Producto WHERE Codigo = 3;

--  Ver resultado
SELECT * FROM Producto;