namespace Parcial1_Ap1.UI.Registros
{
    partial class rEvaluacion
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.EstudianteLabel = new System.Windows.Forms.Label();
            this.CalificacionGroupBox = new System.Windows.Forms.GroupBox();
            this.EstudianteTextBox = new System.Windows.Forms.TextBox();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ValorLabel = new System.Windows.Forms.Label();
            this.LogradoLabel = new System.Windows.Forms.Label();
            this.PerdidoLabel = new System.Windows.Forms.Label();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.LogradoTextBox = new System.Windows.Forms.TextBox();
            this.PerdidoTextBox = new System.Windows.Forms.TextBox();
            this.SignoMenosLabel = new System.Windows.Forms.Label();
            this.SignoIgualLabel = new System.Windows.Forms.Label();
            this.PorComoLabel = new System.Windows.Forms.Label();
            this.PronosticoComboBox = new System.Windows.Forms.ComboBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CalificacionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(30, 34);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(129, 37);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(47, 17);
            this.FechaLabel.TabIndex = 1;
            this.FechaLabel.Text = "Fecha";
            // 
            // EstudianteLabel
            // 
            this.EstudianteLabel.AutoSize = true;
            this.EstudianteLabel.Location = new System.Drawing.Point(30, 96);
            this.EstudianteLabel.Name = "EstudianteLabel";
            this.EstudianteLabel.Size = new System.Drawing.Size(75, 17);
            this.EstudianteLabel.TabIndex = 2;
            this.EstudianteLabel.Text = "Estudiante";
            // 
            // CalificacionGroupBox
            // 
            this.CalificacionGroupBox.Controls.Add(this.SignoIgualLabel);
            this.CalificacionGroupBox.Controls.Add(this.SignoMenosLabel);
            this.CalificacionGroupBox.Controls.Add(this.PerdidoTextBox);
            this.CalificacionGroupBox.Controls.Add(this.LogradoTextBox);
            this.CalificacionGroupBox.Controls.Add(this.ValorTextBox);
            this.CalificacionGroupBox.Controls.Add(this.PerdidoLabel);
            this.CalificacionGroupBox.Controls.Add(this.LogradoLabel);
            this.CalificacionGroupBox.Controls.Add(this.ValorLabel);
            this.CalificacionGroupBox.Location = new System.Drawing.Point(33, 153);
            this.CalificacionGroupBox.Name = "CalificacionGroupBox";
            this.CalificacionGroupBox.Size = new System.Drawing.Size(433, 130);
            this.CalificacionGroupBox.TabIndex = 3;
            this.CalificacionGroupBox.TabStop = false;
            this.CalificacionGroupBox.Text = "Calificación tareas y parcial ";
            this.CalificacionGroupBox.Enter += new System.EventHandler(this.CalificacionGroupBox_Enter);
            // 
            // EstudianteTextBox
            // 
            this.EstudianteTextBox.Location = new System.Drawing.Point(132, 96);
            this.EstudianteTextBox.Name = "EstudianteTextBox";
            this.EstudianteTextBox.Size = new System.Drawing.Size(334, 22);
            this.EstudianteTextBox.TabIndex = 4;
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(58, 32);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(47, 22);
            this.IdNumericUpDown.TabIndex = 5;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(367, 28);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(99, 38);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(182, 34);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(155, 22);
            this.FechaDateTimePicker.TabIndex = 7;
            // 
            // ValorLabel
            // 
            this.ValorLabel.AutoSize = true;
            this.ValorLabel.Location = new System.Drawing.Point(22, 38);
            this.ValorLabel.Name = "ValorLabel";
            this.ValorLabel.Size = new System.Drawing.Size(41, 17);
            this.ValorLabel.TabIndex = 3;
            this.ValorLabel.Text = "Valor";
            // 
            // LogradoLabel
            // 
            this.LogradoLabel.AutoSize = true;
            this.LogradoLabel.Location = new System.Drawing.Point(158, 38);
            this.LogradoLabel.Name = "LogradoLabel";
            this.LogradoLabel.Size = new System.Drawing.Size(61, 17);
            this.LogradoLabel.TabIndex = 4;
            this.LogradoLabel.Text = "Logrado";
            // 
            // PerdidoLabel
            // 
            this.PerdidoLabel.AutoSize = true;
            this.PerdidoLabel.Location = new System.Drawing.Point(331, 38);
            this.PerdidoLabel.Name = "PerdidoLabel";
            this.PerdidoLabel.Size = new System.Drawing.Size(57, 17);
            this.PerdidoLabel.TabIndex = 5;
            this.PerdidoLabel.Text = "Perdido";
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(25, 76);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(83, 22);
            this.ValorTextBox.TabIndex = 6;
            // 
            // LogradoTextBox
            // 
            this.LogradoTextBox.Location = new System.Drawing.Point(161, 76);
            this.LogradoTextBox.Name = "LogradoTextBox";
            this.LogradoTextBox.Size = new System.Drawing.Size(83, 22);
            this.LogradoTextBox.TabIndex = 7;
            // 
            // PerdidoTextBox
            // 
            this.PerdidoTextBox.Location = new System.Drawing.Point(334, 76);
            this.PerdidoTextBox.Name = "PerdidoTextBox";
            this.PerdidoTextBox.ReadOnly = true;
            this.PerdidoTextBox.Size = new System.Drawing.Size(83, 22);
            this.PerdidoTextBox.TabIndex = 8;
            this.PerdidoTextBox.TextChanged += new System.EventHandler(this.PerdidoTextBox_TextChanged);
            // 
            // SignoMenosLabel
            // 
            this.SignoMenosLabel.AutoSize = true;
            this.SignoMenosLabel.Location = new System.Drawing.Point(130, 79);
            this.SignoMenosLabel.Name = "SignoMenosLabel";
            this.SignoMenosLabel.Size = new System.Drawing.Size(13, 17);
            this.SignoMenosLabel.TabIndex = 9;
            this.SignoMenosLabel.Text = "-";
            // 
            // SignoIgualLabel
            // 
            this.SignoIgualLabel.AutoSize = true;
            this.SignoIgualLabel.Location = new System.Drawing.Point(278, 79);
            this.SignoIgualLabel.Name = "SignoIgualLabel";
            this.SignoIgualLabel.Size = new System.Drawing.Size(16, 17);
            this.SignoIgualLabel.TabIndex = 10;
            this.SignoIgualLabel.Text = "=";
            // 
            // PorComoLabel
            // 
            this.PorComoLabel.AutoSize = true;
            this.PorComoLabel.Location = new System.Drawing.Point(30, 301);
            this.PorComoLabel.Name = "PorComoLabel";
            this.PorComoLabel.Size = new System.Drawing.Size(161, 17);
            this.PorComoLabel.TabIndex = 8;
            this.PorComoLabel.Text = "Por como vas deberias: ";
            // 
            // PronosticoComboBox
            // 
            this.PronosticoComboBox.FormattingEnabled = true;
            this.PronosticoComboBox.Items.AddRange(new object[] {
            "Continuar",
            "Suspenso",
            "Retirar"});
            this.PronosticoComboBox.Location = new System.Drawing.Point(194, 301);
            this.PronosticoComboBox.Name = "PronosticoComboBox";
            this.PronosticoComboBox.Size = new System.Drawing.Size(155, 24);
            this.PronosticoComboBox.TabIndex = 9;
            this.PronosticoComboBox.SelectedIndexChanged += new System.EventHandler(this.PronosticoComboBox_SelectedIndexChanged);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(33, 394);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(99, 38);
            this.NuevoButton.TabIndex = 10;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(194, 394);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(99, 38);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(367, 394);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(99, 38);
            this.EliminarButton.TabIndex = 12;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 466);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.PronosticoComboBox);
            this.Controls.Add(this.PorComoLabel);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.EstudianteTextBox);
            this.Controls.Add(this.CalificacionGroupBox);
            this.Controls.Add(this.EstudianteLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "rEvaluacion";
            this.Text = "Registro de Evaluacion";
            this.Load += new System.EventHandler(this.REvaluacion_Load);
            this.CalificacionGroupBox.ResumeLayout(false);
            this.CalificacionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label EstudianteLabel;
        private System.Windows.Forms.GroupBox CalificacionGroupBox;
        private System.Windows.Forms.TextBox EstudianteTextBox;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label SignoIgualLabel;
        private System.Windows.Forms.Label SignoMenosLabel;
        private System.Windows.Forms.TextBox PerdidoTextBox;
        private System.Windows.Forms.TextBox LogradoTextBox;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.Label PerdidoLabel;
        private System.Windows.Forms.Label LogradoLabel;
        private System.Windows.Forms.Label ValorLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label PorComoLabel;
        private System.Windows.Forms.ComboBox PronosticoComboBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}