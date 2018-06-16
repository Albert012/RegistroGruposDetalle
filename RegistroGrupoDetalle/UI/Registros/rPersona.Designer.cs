namespace RegistroGrupoDetalle.UI.Registros
{
    partial class rPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label personaIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.cedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.ValidarErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            personaIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaIdNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // personaIdLabel
            // 
            personaIdLabel.AutoSize = true;
            personaIdLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personaIdLabel.ForeColor = System.Drawing.SystemColors.Control;
            personaIdLabel.Location = new System.Drawing.Point(11, 28);
            personaIdLabel.Name = "personaIdLabel";
            personaIdLabel.Size = new System.Drawing.Size(86, 19);
            personaIdLabel.TabIndex = 1;
            personaIdLabel.Text = "Persona Id:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaLabel.Location = new System.Drawing.Point(32, 60);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(54, 19);
            fechaLabel.TabIndex = 2;
            fechaLabel.Text = "Fecha:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombresLabel.ForeColor = System.Drawing.SystemColors.Control;
            nombresLabel.Location = new System.Drawing.Point(20, 93);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(75, 19);
            nombresLabel.TabIndex = 4;
            nombresLabel.Text = "Nombres:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.ForeColor = System.Drawing.SystemColors.Control;
            direccionLabel.Location = new System.Drawing.Point(17, 129);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(78, 19);
            direccionLabel.TabIndex = 6;
            direccionLabel.Text = "Direccion:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cedulaLabel.ForeColor = System.Drawing.SystemColors.Control;
            cedulaLabel.Location = new System.Drawing.Point(29, 166);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(61, 19);
            cedulaLabel.TabIndex = 8;
            cedulaLabel.Text = "Cedula:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.ForeColor = System.Drawing.SystemColors.Control;
            telefonoLabel.Location = new System.Drawing.Point(217, 166);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(72, 19);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Telefono:";
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataSource = typeof(RegistroGrupoDetalle.Entidades.Personas);
            // 
            // personaIdNumericUpDown
            // 
            this.personaIdNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personasBindingSource, "PersonaId", true));
            this.personaIdNumericUpDown.Location = new System.Drawing.Point(105, 25);
            this.personaIdNumericUpDown.Name = "personaIdNumericUpDown";
            this.personaIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.personaIdNumericUpDown.TabIndex = 2;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personasBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(105, 56);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.fechaDateTimePicker.TabIndex = 3;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(105, 90);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(287, 20);
            this.nombresTextBox.TabIndex = 5;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(105, 126);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(287, 20);
            this.direccionTextBox.TabIndex = 7;
            // 
            // cedulaMaskedTextBox
            // 
            this.cedulaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Cedula", true));
            this.cedulaMaskedTextBox.Location = new System.Drawing.Point(105, 163);
            this.cedulaMaskedTextBox.Mask = "000-0000000-0";
            this.cedulaMaskedTextBox.Name = "cedulaMaskedTextBox";
            this.cedulaMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaMaskedTextBox.TabIndex = 9;
            // 
            // telefonoMaskedTextBox
            // 
            this.telefonoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "Telefono", true));
            this.telefonoMaskedTextBox.Location = new System.Drawing.Point(292, 163);
            this.telefonoMaskedTextBox.Mask = "000-000-0000";
            this.telefonoMaskedTextBox.Name = "telefonoMaskedTextBox";
            this.telefonoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoMaskedTextBox.TabIndex = 11;
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::RegistroGrupoDetalle.Properties.Resources.buscar;
            this.Buscar_button.Location = new System.Drawing.Point(230, 19);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(30, 29);
            this.Buscar_button.TabIndex = 12;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Nuevo_button);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(123, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // button2
            // 
            this.button2.Image = global::RegistroGrupoDetalle.Properties.Resources.Delete;
            this.button2.Location = new System.Drawing.Point(119, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 41);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::RegistroGrupoDetalle.Properties.Resources.Save;
            this.button1.Location = new System.Drawing.Point(69, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::RegistroGrupoDetalle.Properties.Resources.new2;
            this.Nuevo_button.Location = new System.Drawing.Point(14, 24);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(42, 40);
            this.Nuevo_button.TabIndex = 0;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // ValidarErrorProvider
            // 
            this.ValidarErrorProvider.ContainerControl = this;
            // 
            // rPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(421, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoMaskedTextBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaMaskedTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(personaIdLabel);
            this.Controls.Add(this.personaIdNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "rPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rPersona";
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaIdNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personasBindingSource;
        private System.Windows.Forms.NumericUpDown personaIdNumericUpDown;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.MaskedTextBox cedulaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefonoMaskedTextBox;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.ErrorProvider ValidarErrorProvider;
    }
}