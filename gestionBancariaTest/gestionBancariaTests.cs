using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]
        public void validarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        public void validarMetodoReintegro()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarExcepcionRealizarIngresoCantidadNegativa()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -1;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            cuenta.obtenerSaldo();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarExcepcionReintegroMayorQueSaldo()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 1001;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            cuenta.obtenerSaldo();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarExcepcionReintegroCantidadNegativa()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = -1;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            cuenta.obtenerSaldo();
        }
    }
}