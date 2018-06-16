namespace RegistroGrupoDetalle.UI.Registros
{
    partial class rGrupo
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
            System.Windows.Forms.Label grupoIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label grupoLabel;
            System.Windows.Forms.Label integrantesLabel;
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.grupoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.integrantesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.ValidarErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            grupoIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            grupoLabel = new System.Windows.Forms.Label();
            integrantesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrantesNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoIdLabel
            // 
            grupoIdLabel.AutoSize = true;
            grupoIdLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grupoIdLabel.ForeColor = System.Drawing.SystemColors.Control;
            grupoIdLabel.Location = new System.Drawing.Point(32, 35);
            grupoIdLabel.Name = "grupoIdLabel";
            grupoIdLabel.Size = new System.Drawing.Size(72, 17);
            grupoIdLabel.TabIndex = 1;
            grupoIdLabel.Text = "Grupo Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.ForeColor = System.Drawing.SystemColors.Control;
            descripcionLabel.Location = new System.Drawing.Point(13, 68);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(91, 17);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripcion:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaLabel.Location = new System.Drawing.Point(52, 98);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(52, 17);
            fechaLabel.TabIndex = 4;
            fechaLabel.Text = "Fecha:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.ForeColor = System.Drawing.SystemColors.Control;
            cantidadLabel.Location = new System.Drawing.Point(32, 129);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(71, 17);
            cantidadLabel.TabIndex = 6;
            cantidadLabel.Text = "Cantidad:";
            // 
            // grupoLabel
            // 
            grupoLabel.AutoSize = true;
            grupoLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grupoLabel.ForeColor = System.Drawing.SystemColors.Control;
            grupoLabel.Location = new System.Drawing.Point(186, 130);
            grupoLabel.Name = "grupoLabel";
            grupoLabel.Size = new System.Drawing.Size(61, 17);
            grupoLabel.TabIndex = 8;
            grupoLabel.Text = "Grupos:";
            // 
            // integrantesLabel
            // 
            integrantesLabel.AutoSize = true;
            integrantesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            integrantesLabel.ForeColor = System.Drawing.SystemColors.Control;
            integrantesLabel.Location = new System.Drawing.Point(17, 159);
            integrantesLabel.Name = "integrantesLabel";
            integrantesLabel.Size = new System.Drawing.Size(89, 17);
            integrantesLabel.TabIndex = 10;
            integrantesLabel.Text = "Integrantes:";
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataSource = typeof(RegistroGrupoDetalle.Entidades.Grupos);
            // 
            // grupoIdNumericUpDown
            // 
            this.grupoIdNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "GrupoId", true));
            this.grupoIdNumericUpDown.Location = new System.Drawing.Point(112, 32);
            this.grupoIdNumericUpDown.Name = "grupoIdNumericUpDown";
            this.grupoIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.grupoIdNumericUpDown.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(112, 64);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(112, 95);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.fechaDateTimePicker.TabIndex = 5;
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Cantidad", true));
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(114, 127);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(66, 20);
            this.cantidadNumericUpDown.TabIndex = 7;
            this.cantidadNumericUpDown.ValueChanged += new System.EventHandler(this.cantidadNumericUpDown_ValueChanged);
            // 
            // grupoNumericUpDown
            // 
            this.grupoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Grupo", true));
            this.grupoNumericUpDown.Location = new System.Drawing.Point(248, 128);
            this.grupoNumericUpDown.Name = "grupoNumericUpDown";
            this.grupoNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.grupoNumericUpDown.TabIndex = 9;
            this.grupoNumericUpDown.ValueChanged += new System.EventHandler(this.grupoNumericUpDown_ValueChanged);
            // 
            // integrantesNumericUpDown
            // 
            this.integrantesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Integrantes", true));
            this.integrantesNumericUpDown.Enabled = false;
            this.integrantesNumericUpDown.Location = new System.Drawing.Point(114, 157);
            this.integrantesNumericUpDown.Name = "integrantesNumericUpDown";
            this.integrantesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.integrantesNumericUpDown.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Eliminar_button);
            this.groupBox1.Controls.Add(this.Guardar_button);
            this.groupBox1.Controls.Add(this.Nuevo_button);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(79, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::RegistroGrupoDetalle.Properties.Resources.new2;
            this.Nuevo_button.Location = new System.Drawing.Point(18, 24);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(40, 42);
            this.Nuevo_button.TabIndex = 0;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Image = global::RegistroGrupoDetalle.Properties.Resources.Save;
            this.Guardar_button.Location = new System.Drawing.Point(74, 24);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(41, 42);
            this.Guardar_button.TabIndex = 1;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Image = global::RegistroGrupoDetalle.Properties.Resources.Delete;
            this.Eliminar_button.Location = new System.Drawing.Point(130, 24);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(37, 41);
            this.Eliminar_button.TabIndex = 2;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::RegistroGrupoDetalle.Properties.Resources.buscar;
            this.Buscar_button.Location = new System.Drawing.Point(238, 25);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(32, 30);
            this.Buscar_button.TabIndex = 13;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // ValidarErrorProvider
            // 
            this.ValidarErrorProvider.ContainerControl = this;
            // 
            // rRegistroGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(331, 284);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(integrantesLabel);
            this.Controls.Add(this.integrantesNumericUpDown);
            this.Controls.Add(grupoLabel);
            this.Controls.Add(this.grupoNumericUpDown);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(grupoIdLabel);
            this.Controls.Add(this.grupoIdNumericUpDown);
            this.MaximizeBox = false;
            this.Name = "rRegistroGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrantesNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gruposBindingSource;
        private System.Windows.Forms.NumericUpDown grupoIdNumericUpDown;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.NumericUpDown grupoNumericUpDown;
        private System.Windows.Forms.NumericUpDown integrantesNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.ErrorProvider ValidarErrorProvider;
    }
}