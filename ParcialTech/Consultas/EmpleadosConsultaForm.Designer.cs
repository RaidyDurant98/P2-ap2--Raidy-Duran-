namespace ParcialTech.Consultas
{
    partial class EmpleadosConsultaForm
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
            this.FiltrardataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrartextBox = new System.Windows.Forms.TextBox();
            this.Filtrarbutton = new System.Windows.Forms.Button();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CamposVacioserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FiltrardataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamposVacioserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrardataGridView
            // 
            this.FiltrardataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FiltrardataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FiltrardataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.FiltrardataGridView.Location = new System.Drawing.Point(12, 133);
            this.FiltrardataGridView.Name = "FiltrardataGridView";
            this.FiltrardataGridView.Size = new System.Drawing.Size(488, 295);
            this.FiltrardataGridView.TabIndex = 0;
            this.FiltrardataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FiltrardataGridView_CellContentClick);
            // 
            // FiltrartextBox
            // 
            this.FiltrartextBox.Location = new System.Drawing.Point(216, 52);
            this.FiltrartextBox.Name = "FiltrartextBox";
            this.FiltrartextBox.Size = new System.Drawing.Size(132, 20);
            this.FiltrartextBox.TabIndex = 1;
            // 
            // Filtrarbutton
            // 
            this.Filtrarbutton.Location = new System.Drawing.Point(377, 50);
            this.Filtrarbutton.Name = "Filtrarbutton";
            this.Filtrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Filtrarbutton.TabIndex = 2;
            this.Filtrarbutton.Text = "Filtrar";
            this.Filtrarbutton.UseVisualStyleBackColor = true;
            this.Filtrarbutton.Click += new System.EventHandler(this.Filtrarbutton_Click);
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Items.AddRange(new object[] {
            "Todos",
            "Nombre",
            "Fecha",
            "Nombre y Fecha"});
            this.FiltrarcomboBox.Location = new System.Drawing.Point(51, 53);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarcomboBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elija la opcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Campo a evaluar:";
            // 
            // CamposVacioserrorProvider
            // 
            this.CamposVacioserrorProvider.ContainerControl = this;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(139, 97);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.DesdedateTimePicker.TabIndex = 14;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(295, 96);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.HastadateTimePicker.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hasta:";
            // 
            // EmpleadosConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.Filtrarbutton);
            this.Controls.Add(this.FiltrartextBox);
            this.Controls.Add(this.FiltrardataGridView);
            this.Name = "EmpleadosConsultaForm";
            this.Text = "Consulta de empleados";
            ((System.ComponentModel.ISupportInitialize)(this.FiltrardataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamposVacioserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FiltrardataGridView;
        private System.Windows.Forms.TextBox FiltrartextBox;
        private System.Windows.Forms.Button Filtrarbutton;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider CamposVacioserrorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
    }
}