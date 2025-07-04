using System.Drawing.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Ej_3_2_Clinica
{
    public partial class Hospital : Form
    {
        //internal Persona[] medicos = new Persona[4];
        //internal List<Persona> pacientes = new List<Persona>();
        private CrearUsuarios crearUsuario = new CrearUsuarios();

        private ConfiguracionInterfaz configuracionUI = new ConfiguracionInterfaz();
        public Hospital()
        {
            InitializeComponent();
            // commbox_rol_options
            combBox_rol.Items.AddRange(new[] { "Médico", "Paciente" });
            // selected index by default
            combBox_rol.SelectedIndex = 0;
        }


        private void combBox_rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selected = combBox_rol?.SelectedItem?.ToString();
            // renderizado condicional de labels y combo box
            if (selected == "Médico")
            {
                configuracionUI.MedicoConfiguracion(combBox_Especialidad, lbl_historia_clinica, lbl_Especialdiad);
            }
            if (selected == "Paciente")
            {
                configuracionUI.PacienteConfiguracion(combBox_Especialidad, lbl_historia_clinica, lbl_Especialdiad);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int sexCheck;
            string mensajeError = "";
            string nombre = txt_nombre.Text;
            string DNI = txt_dni.Text;
            string telefono = txt_telefono.Text;
            string especialidad = combBox_Especialidad.Text;
            string costoConsulta = txt_h_clinica_honoriarios.Text;
            string historiaClinica = txt_h_clinica_honoriarios.Text;


            if (!rdoBtn_F.Checked && !rdoBtn_M.Checked)
            {
                mensajeError = "Debe seleccionar un sexo.";
                sexCheck = 0;
            }
            bool sexo = rdoBtn_M.Checked;
            sexCheck = 1;

            string? selected = combBox_rol.SelectedItem?.ToString();
            btn_Guardar.Enabled = (sexCheck == 1);
            lbox_Info.Items.Clear(); // Para limpiar lo anterior

            if (selected == "Médico")
            {
                crearUsuario.AgregarMedico(nombre, DNI, telefono, sexo, especialidad, costoConsulta);
                foreach (var medico in crearUsuario.medicos)
                {
                    if (medico != null)
                    {
                        lbox_Info.Items.Add(medico);
                    }
                }
            }
            else if (selected == "Paciente")
            {
                crearUsuario.AgregarPaciente(nombre, DNI, telefono, sexo, especialidad, historiaClinica);
                foreach (var paciente in crearUsuario.pacientes)
                {
                    lbox_Info.Items.Add(paciente);
                }
            }

        }
    }
}


