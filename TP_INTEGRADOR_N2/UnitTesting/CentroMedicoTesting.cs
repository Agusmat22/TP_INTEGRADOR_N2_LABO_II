using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class CentroMedicoTesting
    {

        [TestMethod]
        [DataRow(1445,false)]
        public void Reemplazar_SeRealizaraUnReemplazoDeUnPacienteNoRegistrado_DeberaRetornarFalse(int numeroAfiliado,bool valorEsperado)
        {
            //ARRAGE
            CentroMedico centroMedico = new CentroMedico(100);
            Paciente paciente = new Paciente();
            paciente.NumeroAfiliado = 4564564;
            centroMedico.Pacientes.Add(paciente);


            //ACT
            Paciente pacienteReemplazo = new Paciente();
            paciente.NumeroAfiliado = numeroAfiliado;


            bool resultado = centroMedico.Reemplazar(pacienteReemplazo);

            //ASSERT
            Assert.AreEqual(valorEsperado, resultado);

        }
    }
}
