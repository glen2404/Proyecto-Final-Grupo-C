-- Usar base de datos
USE ProyectoConstruccion;
GO

-- Crear tabla Cliente
CREATE TABLE Cliente (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Cedula VARCHAR(10) NOT NULL UNIQUE,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Telefono VARCHAR(10) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Direccion VARCHAR(200) NOT NULL,
    FechaRegistro DATE NOT NULL
);
GO

-- Crear procedimiento almacenado para insertar un cliente
CREATE PROCEDURE sp_InsertarCliente
    @Cedula VARCHAR(10),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Telefono VARCHAR(10),
    @Email VARCHAR(100),
    @Direccion VARCHAR(200),
    @FechaRegistro DATE
AS
BEGIN
    INSERT INTO Cliente (Cedula, Nombre, Apellido, Telefono, Email, Direccion, FechaRegistro)
    VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Email, @Direccion, @FechaRegistro);
END;
GO

-- Crear procedimiento almacenado para actualizar un cliente
CREATE PROCEDURE sp_ActualizarCliente
    @Cedula VARCHAR(10),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Telefono VARCHAR(10),
    @Email VARCHAR(100),
    @Direccion VARCHAR(200),
    @FechaRegistro DATE
AS
BEGIN
    UPDATE Cliente
    SET Nombre = @Nombre,
        Apellido = @Apellido,
        Telefono = @Telefono,
        Email = @Email,
        Direccion = @Direccion,
        FechaRegistro = @FechaRegistro
    WHERE Cedula = @Cedula;
END;
GO

-- Crear procedimiento almacenado para eliminar un cliente
CREATE PROCEDURE sp_EliminarCliente
    @Cedula VARCHAR(10)
AS
BEGIN
    DELETE FROM Cliente
    WHERE Cedula = @Cedula;
END;
GO

-- Crear procedimiento almacenado para obtener un cliente por cédula
CREATE PROCEDURE sp_ObtenerCliente
    @Cedula VARCHAR(10)
AS
BEGIN
    SELECT * FROM Cliente
    WHERE Cedula = @Cedula;
END;
GO