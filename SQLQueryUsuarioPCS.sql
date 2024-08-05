-- Crear base de datos
CREATE DATABASE ProyectoConstruccion;
GO

-- Usar base de datos
USE ProyectoConstruccion;
GO

-- Crear tabla Usuario
CREATE TABLE Usuario (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Cedula VARCHAR(10) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Telefono VARCHAR(10) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    NombreUsuario VARCHAR(50) NOT NULL,
    Contrasenia VARCHAR(100) NOT NULL,
    Rol VARCHAR(20) NOT NULL
);
GO

-- Crear procedimiento almacenado para insertar un usuario
CREATE PROCEDURE sp_InsertarUsuario
    @Cedula VARCHAR(10),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Telefono VARCHAR(10),
    @Email VARCHAR(100),
    @NombreUsuario VARCHAR(50),
    @Contrasenia VARCHAR(100),
    @Rol VARCHAR(20)
AS
BEGIN
    INSERT INTO Usuario (Cedula, Nombre, Apellido, Telefono, Email, NombreUsuario, Contrasenia, Rol)
    VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Email, @NombreUsuario, @Contrasenia, @Rol);
END;
GO

-- Crear procedimiento almacenado para actualizar un usuario
CREATE PROCEDURE sp_ActualizarUsuario
    @Cedula VARCHAR(10),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Telefono VARCHAR(10),
    @Email VARCHAR(100),
    @NombreUsuario VARCHAR(50),
    @Contrasenia VARCHAR(100),
    @Rol VARCHAR(20)
AS
BEGIN
    UPDATE Usuario
    SET Cedula = @Cedula,
		Nombre = @Nombre,
        Apellido = @Apellido,
        Telefono = @Telefono,
        Email = @Email,
        NombreUsuario = @NombreUsuario,
        Contrasenia = @Contrasenia,
        Rol = @Rol
    WHERE Cedula = @Cedula;
END;
GO

-- Crear procedimiento almacenado para eliminar un usuario
CREATE PROCEDURE sp_EliminarUsuario
    @Cedula VARCHAR(10)
AS
BEGIN
    DELETE FROM Usuario
    WHERE Cedula = @Cedula;
END;
GO

-- Crear procedimiento almacenado para obtener un usuario por cédula
CREATE PROCEDURE sp_ObtenerUsuario
    @Cedula VARCHAR(10)
AS
BEGIN
    SELECT * FROM Usuario
    WHERE Cedula = @Cedula;
END;
GO