using Entidades;
using Entidades.MetodosDeExtension;

namespace UnitTesting
{
    [TestClass]
    public class MetodosExtensionTesting
    {
        [TestMethod]
        [DataRow(114,true)]
        public void ValidarNumeroAfiliado_CuandoElNumeroYaExiste_DebeRetornarTrue(long numeroAfiliado,bool valorEsperado)
        {
            //ARRAGE
            CentroMedico centroMedico = new CentroMedico(100);
            Paciente paciente = new Paciente();
            paciente.NumeroAfiliado = numeroAfiliado;
            centroMedico.Pacientes.Add(paciente);
            //ACT
            bool resultado = centroMedico.ValidarNumeroAfiliado(numeroAfiliado);
            //ASSERT
            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow(554, false)]
        public void ValidarMatricula_CuandoElNumeroNoExiste_DebeRetornarFalse(long matricula, bool valorEsperado)
        {
            //ARRAGE
            CentroMedico centroMedico = new CentroMedico(100);
            Medico medico = new Medico();
            medico.NumeroMatricula = 564465;
            centroMedico.Medicos.Add(medico);
            //ACT
            bool resultado = centroMedico.ValidarMatricula(matricula);
            //ASSERT
            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}