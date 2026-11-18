CREATE TABLE Producto (
    Codigo INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Cantidad INT NOT NULL,
    Categoria INT NOT NULL,
    FOREIGN KEY (Categoria) REFERENCES Categoria(Codigo)
);
-- Categorías
INSERT INTO Categoria (Nombre) VALUES ('Electrónica');
INSERT INTO Categoria (Nombre) VALUES ('Ropa');