namespace Ej_3_2_Clinica
{
    partial class Hospital
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbox_Info = new ListBox();
            panel1 = new Panel();
            lbl_historia_clinica = new Label();
            combBox_Especialidad = new ComboBox();
            rdoBtn_F = new RadioButton();
            rdoBtn_M = new RadioButton();
            txt_h_clinica_honoriarios = new TextBox();
            txt_dni = new TextBox();
            txt_telefono = new TextBox();
            lbl_dni = new Label();
            lbl_Especialdiad = new Label();
            lbl_telefono = new Label();
            lbl_sexo = new Label();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            combBox_rol = new ComboBox();
            lbl_rol = new Label();
            btn_Guardar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbox_Info
            // 
            lbox_Info.FormattingEnabled = true;
            lbox_Info.ItemHeight = 15;
            lbox_Info.Location = new Point(512, 97);
            lbox_Info.Name = "lbox_Info";
            lbox_Info.Size = new Size(184, 259);
            lbox_Info.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(lbl_historia_clinica);
            panel1.Controls.Add(combBox_Especialidad);
            panel1.Controls.Add(rdoBtn_F);
            panel1.Controls.Add(rdoBtn_M);
            panel1.Controls.Add(txt_h_clinica_honoriarios);
            panel1.Controls.Add(txt_dni);
            panel1.Controls.Add(txt_telefono);
            panel1.Controls.Add(lbl_dni);
            panel1.Controls.Add(lbl_Especialdiad);
            panel1.Controls.Add(lbl_telefono);
            panel1.Controls.Add(lbl_sexo);
            panel1.Controls.Add(lbl_nombre);
            panel1.Controls.Add(txt_nombre);
            panel1.Location = new Point(60, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 258);
            panel1.TabIndex = 3;
            // 
            // lbl_historia_clinica
            // 
            lbl_historia_clinica.AutoSize = true;
            lbl_historia_clinica.Location = new Point(41, 224);
            lbl_historia_clinica.Name = "lbl_historia_clinica";
            lbl_historia_clinica.Size = new Size(58, 15);
            lbl_historia_clinica.TabIndex = 15;
            lbl_historia_clinica.Text = "H. Clinica";
            // 
            // combBox_Especialidad
            // 
            combBox_Especialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            combBox_Especialidad.FormattingEnabled = true;
            combBox_Especialidad.Location = new Point(119, 183);
            combBox_Especialidad.Name = "combBox_Especialidad";
            combBox_Especialidad.Size = new Size(102, 23);
            combBox_Especialidad.TabIndex = 14;
            // 
            // rdoBtn_F
            // 
            rdoBtn_F.AutoSize = true;
            rdoBtn_F.Location = new Point(190, 146);
            rdoBtn_F.Name = "rdoBtn_F";
            rdoBtn_F.Size = new Size(31, 19);
            rdoBtn_F.TabIndex = 12;
            rdoBtn_F.TabStop = true;
            rdoBtn_F.Text = "F";
            rdoBtn_F.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_M
            // 
            rdoBtn_M.AutoSize = true;
            rdoBtn_M.Location = new Point(121, 146);
            rdoBtn_M.Name = "rdoBtn_M";
            rdoBtn_M.Size = new Size(36, 19);
            rdoBtn_M.TabIndex = 11;
            rdoBtn_M.TabStop = true;
            rdoBtn_M.Text = "M";
            rdoBtn_M.UseVisualStyleBackColor = true;
            // 
            // txt_h_clinica_honoriarios
            // 
            txt_h_clinica_honoriarios.Location = new Point(119, 221);
            txt_h_clinica_honoriarios.Name = "txt_h_clinica_honoriarios";
            txt_h_clinica_honoriarios.Size = new Size(102, 23);
            txt_h_clinica_honoriarios.TabIndex = 16;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(121, 69);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(100, 23);
            txt_dni.TabIndex = 7;
            // 
            // txt_telefono
            // 
            txt_telefono.AcceptsReturn = true;
            txt_telefono.Location = new Point(121, 109);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(100, 23);
            txt_telefono.TabIndex = 9;
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Location = new Point(41, 72);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(27, 15);
            lbl_dni.TabIndex = 6;
            lbl_dni.Text = "DNI";
            // 
            // lbl_Especialdiad
            // 
            lbl_Especialdiad.AutoSize = true;
            lbl_Especialdiad.Location = new Point(41, 186);
            lbl_Especialdiad.Name = "lbl_Especialdiad";
            lbl_Especialdiad.Size = new Size(72, 15);
            lbl_Especialdiad.TabIndex = 13;
            lbl_Especialdiad.Text = "Especialidad";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(41, 109);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(52, 15);
            lbl_telefono.TabIndex = 8;
            lbl_telefono.Text = "Telefono";
            // 
            // lbl_sexo
            // 
            lbl_sexo.AutoSize = true;
            lbl_sexo.Location = new Point(41, 148);
            lbl_sexo.Name = "lbl_sexo";
            lbl_sexo.Size = new Size(32, 15);
            lbl_sexo.TabIndex = 10;
            lbl_sexo.Text = "Sexo";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(41, 37);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 4;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(121, 34);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 5;
            // 
            // combBox_rol
            // 
            combBox_rol.DropDownStyle = ComboBoxStyle.DropDownList;
            combBox_rol.FormattingEnabled = true;
            combBox_rol.Location = new Point(101, 54);
            combBox_rol.Name = "combBox_rol";
            combBox_rol.Size = new Size(180, 23);
            combBox_rol.TabIndex = 2;
            combBox_rol.SelectedIndexChanged += combBox_rol_SelectedIndexChanged;
            // 
            // lbl_rol
            // 
            lbl_rol.AutoSize = true;
            lbl_rol.Location = new Point(101, 23);
            lbl_rol.Name = "lbl_rol";
            lbl_rol.Size = new Size(100, 15);
            lbl_rol.TabIndex = 1;
            lbl_rol.Text = "Seleccione un rol:";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(101, 383);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(180, 31);
            btn_Guardar.TabIndex = 18;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // Hospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Guardar);
            Controls.Add(lbl_rol);
            Controls.Add(combBox_rol);
            Controls.Add(panel1);
            Controls.Add(lbox_Info);
            Name = "Hospital";
            Text = "Hospital";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lbox_Info;
        private Panel panel1;
        private TextBox txt_dni;
        private TextBox txt_h_clinica_honoriarios;
        private TextBox txt_telefono;
        private Label lbl_dni;
        private Label lbl_Especialdiad;
        private Label lbl_telefono;
        private Label lbl_sexo;
        private Label lbl_nombre;
        private TextBox txt_nombre;
        private ComboBox combBox_rol;
        private Label lbl_rol;
        private RadioButton rdoBtn_M;
        private RadioButton rdoBtn_F;
        private ComboBox combBox_Especialidad;
        private Label lbl_historia_clinica;
        private Button btn_Guardar;
    }
}
