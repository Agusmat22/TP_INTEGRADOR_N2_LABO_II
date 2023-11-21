using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetodosDeExtension
{
    public static class CentroMedicoExtension
    {
        /// <summary>
        /// Agregara una lista de pacientes a una lista ya existente, en caso de exitir no lo agregara
        /// </summary>
        /// <param name="centroMedico"></param>
        /// <param name="lista"></param>
        public static void ExtenderListaPacientes(this CentroMedico centroMedico,List<Paciente> lista)
        {
            foreach (Paciente item in lista)
            {
                //si mi lista de pacientes no se encuentra dicho paciente lo agrego, de otro modo no
                if (!centroMedico.Pacientes.Contains(item))
                {
                    centroMedico.Pacientes.Add(item);
                }
                
            }
           
        }

        /// <summary>
        /// Agrega una lista de pacientes a una ya existente, si ya existe el paciente dependiendo el valor por parametro ingresado se reemplazara o no
        /// y en caso de que no exista lo agregara
        /// </summary>
        /// <param name="centroMedico"></param>
        /// <param name="lista"></param>
        /// <param name="reemplazar"></param>
        public static void ExtenderListaPacientes(this CentroMedico centroMedico, List<Paciente> lista, bool reemplazar)
        {
            foreach (Paciente item in lista)
            {
                if (centroMedico.Pacientes.Contains(item))
                {
                    if (reemplazar == true)
                    {
                        centroMedico.Reemplazar(item);
                    }
                }
                else
                {
                    centroMedico.Pacientes.Add(item);
                }
            }

        }

        public static bool ValidarNumeroAfiliado(this CentroMedico centroMedico, long numero)
        {
            foreach (Paciente item in centroMedico.Pacientes)
            {
                if (item.NumeroAfiliado == numero)
                {
                    return true;
                }
            }

            return false;   
        }

        public static bool ValidarMatricula(this CentroMedico centroMedico, long numero)
        {
            foreach (Medico item in centroMedico.Medicos)
            {
                if (item.NumeroMatricula == numero)
                {
                    return true;
                }
            }

            return false;
        }

        public static string GenerarHistoriaClinica(this CentroMedico centroMedico,string diagnostico,Paciente paciente,Medico medico)
        {
            StringBuilder sb = new StringBuilder();

            if (paciente.HistoriaClinica is null)
            {
                sb.Append(' ', 85);
                sb.Append("HISTORIA CLINICA\n");
                sb.Append('-', 122);
                sb.Append('\n', 2);
                //-------------------------------------------------------------

                sb.Append($"Nombre: {paciente.Nombre}");
                sb.Append(' ', 52);
                sb.Append($"Apellido: {paciente.Apellido}");
                sb.Append(' ', 40);
                sb.Append($"Dni: {paciente.Dni}");
                //sb.Append(' ', 40);
                sb.Append('\n', 2);

                //-------------------------------------------------------------

                //salto de linea
                sb.Append($"Numero Afiliado: {paciente.NumeroAfiliado}");
                sb.Append(' ', 43);
                sb.Append($"Obra Social: {paciente.ObraSocial}");
                sb.Append(' ', 37);
                sb.Append($"Nacimiento: {paciente.FechaNacimiento.ToString("dd/MM/yyyy")}");
                sb.Append('\n', 2);
                sb.Append('-', 122);

            }
            else
            {
                sb.Append(paciente.HistoriaClinica);
            }

            //agrego 4 salto de linea 
            sb.Append('\n', 1);

            sb.Append($"Fecha de atencion: {DateTime.Now.ToString("dd/MM/yyyy")}");
            sb.Append(' ', 100);
            sb.Append($"Medico: {medico.ToString()}");

            //agrego 4 salto de linea 
            sb.Append('\n', 3);
            sb.Append("DIAGNOSTICO:");
            sb.Append('\n', 2);
            sb.Append(diagnostico);

            //division entre cada diagnostico
            sb.Append('\n', 4);
            sb.Append('-', 122);

            return sb.ToString();
        }
        
    }
}
