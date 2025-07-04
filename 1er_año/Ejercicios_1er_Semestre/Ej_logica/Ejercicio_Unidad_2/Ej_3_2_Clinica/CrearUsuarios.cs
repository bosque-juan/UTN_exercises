using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_3_2_Clinica
{
    internal class CrearUsuarios
    {
        internal Medico[] medicos = new Medico[4];
        //internal List<Medico> medicos = new List<Medico>();

        int posicion = 0;   
        internal List<Paciente> pacientes = new List<Paciente>();

        public void AgregarMedico(string nombre, string DNI, string telefono, bool sexo, string especialidad, string costoConsulta)
        {
            if(posicion >= 3) { MessageBox.Show( "No se pueden agregar más médicos"); }
            else
            {
                Medico medico = new Medico(nombre, DNI, telefono, sexo, especialidad, costoConsulta);
                medicos[posicion] = medico;
                //medicos.Add(medico);
                posicion++;
            }
        }
        public void AgregarPaciente(string label_name, string Dni, string telefono, bool sexo, string obraSocial, string historiaClinica)
        {
            Paciente paciente = new Paciente(label_name, Dni, telefono, sexo, obraSocial, historiaClinica);
            pacientes.Add(paciente);
        }


    }
}
