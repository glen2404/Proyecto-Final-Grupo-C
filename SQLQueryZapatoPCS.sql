-- Usar base de datos
USE ProyectoConstruccion;
GO

-- Crear tabla Zapato
CREATE TABLE Zapato (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Modelo VARCHAR(50) NOT NULL,
    Marca VARCHAR(50) NOT NULL,
    Color VARCHAR(20) NOT NULL,
    Talla INT NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Cantidad INT NOT NULL
);
GO

-- Crear procedimiento almacenado para insertar un zapato
CREATE PROCEDURE sp_InsertarZapato
    @Modelo VARCHAR(50),
    @Marca VARCHAR(50),
    @Color VARCHAR(20),
    @Talla INT,
    @Precio DECIMAL(10, 2),
    @Cantidad INT
AS
BEGIN
    INSERT INTO Zapato (Modelo, Marca, Color, Talla, Precio, Cantidad)
    VALUES (@Modelo, @Marca, @Color, @Talla, @Precio, @Cantidad);
END;
GO

-- Crear procedimiento almacenado para actualizar un zapato
CREATE PROCEDURE sp_ActualizarZapato
    @Id INT,
    @Modelo VARCHAR(50),
    @Marca VARCHAR(50),
    @Color VARCHAR(20),
    @Talla INT,
    @Precio DECIMAL(10, 2),
    @Cantidad INT
AS
BEGIN
    UPDATE Zapato
    SET Modelo = @Modelo,
        Marca = @Marca,
        Color = @Color,
        Talla = @Talla,
        Precio = @Precio,
        Cantidad = @Cantidad
    WHERE Id = @Id;
END;
GO

-- Crear procedimiento almacenado para eliminar un zapato
CREATE PROCEDURE sp_EliminarZapato
    @Id INT
AS
BEGIN
    DELETE FROM Zapato
    WHERE Id = @Id;
END;
GO

-- Crear procedimiento almacenado para obtener un zapato por Id
CREATE PROCEDURE sp_ObtenerZapato
    @Id INT
AS
BEGIN
    SELECT * FROM Zapato
    WHERE Id = @Id;
END;
GO