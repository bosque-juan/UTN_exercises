namespace Ej_3_2_Clinica
{
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
            // commbox_rol_options
            combBox_rol.Items.Add("M�dico");
            combBox_rol.Items.Add("Paciente");
            // selected index by default
            combBox_rol.SelectedIndex = 0;

        }


        private void combBox_rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selected = combBox_rol?.SelectedItem?.ToString();

            if (selected == "M�dico")
            {
                lbl_historia_clinica.Text = "Tarifa";
                lbl_Especialdiad.Text = "Especialidad";
                combBox_Especialidad.Items.Clear();
                combBox_Especialidad.Items.Add("Traumatolog�a");
                combBox_Especialidad.Items.Add("Pediatr�a");
                combBox_Especialidad.Items.Add("Cardiolog�a");

            }
            if (selected == "Paciente")
            {
                lbl_Especialdiad.Text = "Especialidad";
                combBox_Especialidad.Items.Clear();
                combBox_Especialidad.Items.Add("Apross");
                combBox_Especialidad.Items.Add("Met");
                combBox_Especialidad.Items.Add("Osde");
                combBox_Especialidad.Items.Add("Otras");
                lbl_historia_clinica.Text = "H. Cl�nica";
                lbl_Especialdiad.Text = "Obra Social";


            }

        }


    }
}
