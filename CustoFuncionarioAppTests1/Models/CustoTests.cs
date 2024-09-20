using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustoFuncionarioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustoFuncionarioApp.Models.Tests
{
    [TestClass()]
    public class CustoTests
    {
        private Custo custo;
        [TestInitialize()]
        public void Inicializar()
        {
            custo = new Custo();
        }

        [TestMethod()]
        [DataRow(1412.00, 7.5)]
        [DataRow(1412.01, 9.0)]
        [DataRow(2666.68, 9.0)]
        [DataRow(2666.69, 12.0)]
        [DataRow(4000.03, 12.0)]
        [DataRow(4000.04, 14.0)]
        [DataRow(7786.02, 14.0)]
        [DataRow(10000.00, 0)]
        public void getINSS_AliquotaTest(double salario, double Esperado)
        {
            custo.SalarioBruto = (decimal)salario;

            var obtido = custo.getINSS_Aliquota();
            var esperado = (decimal)Esperado;

            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod()]
        [DataRow(1412.00, 105.9)]
        [DataRow(1412.01, 127.08)]
        [DataRow(2666.68, 240.00)]
        [DataRow(2666.69, 320.00)]
        [DataRow(4000.03, 480.00)]
        [DataRow(4000.04, 560.01)]
        [DataRow(7786.02, 1089.04)]
        [DataRow(10000.00, 0.0)]
        public void getINSS_ValorTest(double salario, double esperado)
        {
            custo.SalarioBruto = (decimal)salario;
            var obtido = custo.getINSS_Valor();
            var Esperado = (decimal)esperado;

            Assert.AreEqual(Esperado, obtido, 2);
        }

        [TestMethod()]
        [DataRow(1412.00, 112.96)]
        [DataRow(1412.01, 112.96)]
        [DataRow(2666.68, 213.33)]
        [DataRow(2666.69, 213.34)]
        [DataRow(4000.03, 320.00)]
        [DataRow(4000.04, 320.00)]
        [DataRow(7786.02, 622.88)]
        [DataRow(10000.00, 800.00)]
        public void getFGTSTest(double salario, double esperado)
        {
            custo.SalarioBruto = (decimal)salario;
            var obtido = custo.getFGTS();
            var Esperado = (decimal)esperado;

            Assert.AreEqual(Esperado, obtido, 2);
        }

        [TestMethod()]
        [DataRow(1412.00, 1412.00)]
        [DataRow(1412.01, 1412.01)]
        [DataRow(2666.68, 2666.68)]
        [DataRow(2666.69, 2666.69)]
        [DataRow(4000.03, 4000.03)]
        [DataRow(4000.04, 4000.04)]
        [DataRow(7786.02, 7786.02)]
        [DataRow(10000.00, 10000.00)]
        public void get13oSalarioTest(double salario, double esperado)
        {
            custo.SalarioBruto = (decimal)salario;
            var obtido = custo.get13oSalario();
            var Esperado = (decimal)esperado;

            Assert.AreEqual(Esperado, obtido, 2);
        }

        [TestMethod()]
        [DataRow(1412.00, 1882.67)]
        [DataRow(1412.01, 1882.68)]
        [DataRow(2666.68, 3555.57)]
        [DataRow(2666.69, 3555.59)]
        [DataRow(4000.03, 5333.37)]
        [DataRow(4000.04, 5333.39)]
        [DataRow(7786.02, 10381.36)]
        [DataRow(10000.00, 13333.33)]
        public void getFeriasTest(double salario, double esperado)
        {
            custo.SalarioBruto = (decimal)salario;
            var obtido = custo.getFerias();
            var Esperado = (decimal)esperado;

            Assert.AreEqual(Esperado, obtido, 2);
        }
    }
}