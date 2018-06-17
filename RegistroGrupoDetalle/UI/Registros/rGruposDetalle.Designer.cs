namespace RegistroGrupoDetalle.UI.Registros
{
    partial class rGruposDetalle
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.gruposDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Comentarios_textBox = new System.Windows.Forms.TextBox();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Agregar_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Borrar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Persona_comboBox = new System.Windows.Forms.ComboBox();
            this.Cantidad_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ValidarErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            idLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gruposDetalleBindingSource
            // 
            this.gruposDetalleBindingSource.DataSource = typeof(RegistroGrupoDetalle.Entidades.GruposDetalle);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 21);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(28, 19);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposDetalleBindingSource, "Id", true));
            this.idNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumericUpDown.Location = new System.Drawing.Point(45, 17);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.idNumericUpDown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Comentarios:";
            // 
            // Comentarios_textBox
            // 
            this.Comentarios_textBox.Location = new System.Drawing.Point(40, 371);
            this.Comentarios_textBox.Name = "Comentarios_textBox";
            this.Comentarios_textBox.Size = new System.Drawing.Size(490, 26);
            this.Comentarios_textBox.TabIndex = 9;
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::RegistroGrupoDetalle.Properties.Resources.buscar;
            this.Buscar_button.Location = new System.Drawing.Point(171, 15);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(35, 30);
            this.Buscar_button.TabIndex = 10;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(7, 65);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(511, 170);
            this.DetalleDataGridView.TabIndex = 11;
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Eliminar_button.Image = global::RegistroGrupoDetalle.Properties.Resources.remove;
            this.Eliminar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar_button.Location = new System.Drawing.Point(9, 250);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(131, 26);
            this.Eliminar_button.TabIndex = 12;
            this.Eliminar_button.Text = "Eliminar Tupla";
            this.Eliminar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Agregar_button
            // 
            this.Agregar_button.Image = global::RegistroGrupoDetalle.Properties.Resources.new2;
            this.Agregar_button.Location = new System.Drawing.Point(355, 28);
            this.Agregar_button.Name = "Agregar_button";
            this.Agregar_button.Size = new System.Drawing.Size(26, 28);
            this.Agregar_button.TabIndex = 13;
            this.Agregar_button.UseVisualStyleBackColor = true;
            this.Agregar_button.Click += new System.EventHandler(this.Agregar_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Image = global::RegistroGrupoDetalle.Properties.Resources.Save;
            this.Guardar_button.Location = new System.Drawing.Point(238, 420);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(48, 39);
            this.Guardar_button.TabIndex = 14;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Borrar_button
            // 
            this.Borrar_button.Image = global::RegistroGrupoDetalle.Properties.Resources.Delete;
            this.Borrar_button.Location = new System.Drawing.Point(292, 420);
            this.Borrar_button.Name = "Borrar_button";
            this.Borrar_button.Size = new System.Drawing.Size(45, 39);
            this.Borrar_button.TabIndex = 15;
            this.Borrar_button.UseVisualStyleBackColor = true;
            this.Borrar_button.Click += new System.EventHandler(this.Borrar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::RegistroGrupoDetalle.Properties.Resources.nuevo;
            this.Nuevo_button.Location = new System.Drawing.Point(195, 420);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(37, 39);
            this.Nuevo_button.TabIndex = 16;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 19);
            label2.TabIndex = 17;
            label2.Text = "Persona:";
            // 
            // Persona_comboBox
            // 
            this.Persona_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Persona_comboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Persona_comboBox.FormattingEnabled = true;
            this.Persona_comboBox.Location = new System.Drawing.Point(77, 32);
            this.Persona_comboBox.Name = "Persona_comboBox";
            this.Persona_comboBox.Size = new System.Drawing.Size(121, 23);
            this.Persona_comboBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(204, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 19);
            label3.TabIndex = 19;
            label3.Text = "Cantidad:";
            // 
            // Cantidad_numericUpDown
            // 
            this.Cantidad_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad_numericUpDown.Location = new System.Drawing.Point(278, 31);
            this.Cantidad_numericUpDown.Name = "Cantidad_numericUpDown";
            this.Cantidad_numericUpDown.Size = new System.Drawing.Size(70, 22);
            this.Cantidad_numericUpDown.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.Cantidad_numericUpDown);
            this.groupBox1.Controls.Add(this.Agregar_button);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.Eliminar_button);
            this.groupBox1.Controls.Add(this.Persona_comboBox);
            this.groupBox1.Controls.Add(this.DetalleDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 286);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargo De Personas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(246, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 19);
            label4.TabIndex = 22;
            label4.Text = "Fecha:";
            // 
            // Fecha_dateTimePicker
            // 
            this.Fecha_dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_dateTimePicker.Location = new System.Drawing.Point(299, 19);
            this.Fecha_dateTimePicker.Name = "Fecha_dateTimePicker";
            this.Fecha_dateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.Fecha_dateTimePicker.TabIndex = 23;
            // 
            // ValidarErrorProvider
            // 
            this.ValidarErrorProvider.ContainerControl = this;
            // 
            // rGruposDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(550, 471);
            this.Controls.Add(this.Fecha_dateTimePicker);
            this.Controls.Add(label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Nuevo_button);
            this.Controls.Add(this.Borrar_button);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Comentarios_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idNumericUpDown);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "rGruposDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos Personas Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.gruposDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gruposDetalleBindingSource;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Comentarios_textBox;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Agregar_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Borrar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.ComboBox Persona_comboBox;
        private System.Windows.Forms.NumericUpDown Cantidad_numericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Fecha_dateTimePicker;
        private System.Windows.Forms.ErrorProvider ValidarErrorProvider;
    }
}