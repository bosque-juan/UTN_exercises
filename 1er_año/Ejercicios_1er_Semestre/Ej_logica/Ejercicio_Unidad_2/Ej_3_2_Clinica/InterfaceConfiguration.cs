using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_3_2_Clinica
{
    internal class ConfiguracionInterfaz
    {
        internal void PacienteConfiguracion(ComboBox Combo, Label lbl_historiaClinica, Label lbl_Especialidad) 
        {
            Combo.Items.Clear();
            Combo.Items.AddRange(new[] { "Apross", "Met", "Osde", "Otras" });
            lbl_historiaClinica.Text = "H. Clínica";
            lbl_Especialidad.Text = "Obra Social";
        }
        internal void MedicoConfiguracion(ComboBox combBox_Especialidad, Label lbl_historia_clinica, Label lbl_Especialdiad)
        {
            combBox_Especialidad.Items.Clear();
            combBox_Especialidad.Items.AddRange(new[] { "Traumatología", "Pediatría", "Cardiología" });
            lbl_historia_clinica.Text = "Tarifa";
            lbl_Especialdiad.Text = "Especialidad";
        }
    }
}
