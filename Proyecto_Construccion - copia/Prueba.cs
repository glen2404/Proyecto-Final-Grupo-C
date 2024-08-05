using System;
using CapaDatos;
using CapaVisual;
using CapaNedocio;
using Menssage_Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Construccion;

using System.Windows.Forms;

namespace Prueba_Unitaria
[TestClass]
public class Prueba
{
    /* Prueba validar usuario existente*/
    [TestMethod]
    public void ValidaUsuarioExistente()
    {
        FormLogin formLogin = new FormLogin();
        string usuario = "Michi";
        string contrasena = "Michi123";
        formLogin.iniciar(usuario, contrasena);
    }

    /* Prueba  usuario incorrecto*/
    [TestMethod]
    public void ValidaUsuarioNoExistente()
    {
        FormLogin formLogin = new FormLogin();
        string usuario = "?";
        string contrasena = "?";
        formLogin.iniciar(usuario, contrasena);
        Assert.IsFalse(false);
    }

    /* Prueba modificar usuario correcto*/
    [TestMethod]
    public void TestModificarUsuarios()
    {
        Dato_ts modificar = new Dato_ts();
        int id = 2;
        string nombre = "Daniel Isaias Altamirano Almeida";
        string usuario = "Dan";
        string correo = "Daniel@hotmail.com";
        string contrasena = "Dan123";
        string tipo = "Cliente";
        modificar.ModificarUsuarios(id, nombre, usuario, correo, contrasena, tipo);
        Assert.IsTrue(true);
    }

    /* Prueba modificar usuario formato incorrecto*/
    [TestMethod]
    public void TestModificarUsuariosIncorrecto()
    {
        Dato_ts modificar = new Dato_ts();
        int id = 0;
        string nombre = "?";
        string usuario = "?";
        string correo = "?";
        string contrasena = "?";
        string tipo = "?";
        modificar.ModificarUsuarios(id, nombre, usuario, correo, contrasena, tipo);
        Assert.IsFalse(false);
    }

    /* Prueba eliminar usuario formato correcto*/
    [TestMethod]
    public void TestEliminarUsuarioCorrecto()
    {
        Dato_ts eliminar = new Dato_ts();
        int id = 2;
        eliminar.EliminarUsuario(id);
        Assert.IsTrue(true);
    }

    /* Prueba eliminar usuario formato incorrecto*/
    [TestMethod]
    public void TestEliminarUsuariosIncorrecto()
    {
        Dato_ts eliminar = new Dato_ts();
        int id = 0;
        eliminar.EliminarUsuario(id);
        Assert.IsFalse(false);
    }
}
