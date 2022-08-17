namespace Proyecto_Final_de_lenguaje_de_programacion_2.UI
{
    partial class PuestoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepartamentoIdpt = new System.Windows.Forms.TextBox();
            this.txtNombrePuesto = new System.Windows.Forms.TextBox();
            this.txtcreadoporpt = new System.Windows.Forms.TextBox();
            this.txtModificadoporpt = new System.Windows.Forms.TextBox();
            this.txtUsuariopt = new System.Windows.Forms.TextBox();
            this.dtgvPuesto = new System.Windows.Forms.DataGridView();
            this.btnCrearPuesto = new System.Windows.Forms.Button();
            this.btnBuscarPuesto = new System.Windows.Forms.Button();
            this.btnActualizarPuesto = new System.Windows.Forms.Button();
            this.btnBorrarPuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Creado por";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modificado por";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario";
            // 
            // txtDepartamentoIdpt
            // 
            this.txtDepartamentoIdpt.Location = new System.Drawing.Point(123, 45);
            this.txtDepartamentoIdpt.Name = "txtDepartamentoIdpt";
            this.txtDepartamentoIdpt.Size = new System.Drawing.Size(100, 20);
            this.txtDepartamentoIdpt.TabIndex = 5;
            // 
            // txtNombrePuesto
            // 
            this.txtNombrePuesto.Location = new System.Drawing.Point(123, 118);
            this.txtNombrePuesto.Name = "txtNombrePuesto";
            this.txtNombrePuesto.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePuesto.TabIndex = 6;
            // 
            // txtcreadoporpt
            // 
            this.txtcreadoporpt.Location = new System.Drawing.Point(123, 194);
            this.txtcreadoporpt.Name = "txtcreadoporpt";
            this.txtcreadoporpt.Size = new System.Drawing.Size(100, 20);
            this.txtcreadoporpt.TabIndex = 7;
            // 
            // txtModificadoporpt
            // 
            this.txtModificadoporpt.Location = new System.Drawing.Point(348, 48);
            this.txtModificadoporpt.Name = "txtModificadoporpt";
            this.txtModificadoporpt.Size = new System.Drawing.Size(100, 20);
            this.txtModificadoporpt.TabIndex = 8;
            // 
            // txtUsuariopt
            // 
            this.txtUsuariopt.Location = new System.Drawing.Point(348, 118);
            this.txtUsuariopt.Name = "txtUsuariopt";
            this.txtUsuariopt.Size = new System.Drawing.Size(100, 20);
            this.txtUsuariopt.TabIndex = 9;
            // 
            // dtgvPuesto
            // 
            this.dtgvPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPuesto.Location = new System.Drawing.Point(32, 286);
            this.dtgvPuesto.Name = "dtgvPuesto";
            this.dtgvPuesto.Size = new System.Drawing.Size(696, 193);
            this.dtgvPuesto.TabIndex = 12;
            // 
            // btnCrearPuesto
            // 
            this.btnCrearPuesto.Location = new System.Drawing.Point(32, 245);
            this.btnCrearPuesto.Name = "btnCrearPuesto";
            this.btnCrearPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnCrearPuesto.TabIndex = 13;
            this.btnCrearPuesto.Text = "Crear";
            this.btnCrearPuesto.UseVisualStyleBackColor = true;
            this.btnCrearPuesto.Click += new System.EventHandler(this.btnCrearPuesto_Click);
            // 
            // btnBuscarPuesto
            // 
            this.btnBuscarPuesto.Location = new System.Drawing.Point(209, 245);
            this.btnBuscarPuesto.Name = "btnBuscarPuesto";
            this.btnBuscarPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPuesto.TabIndex = 14;
            this.btnBuscarPuesto.Text = "Buscar";
            this.btnBuscarPuesto.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPuesto
            // 
            this.btnActualizarPuesto.Location = new System.Drawing.Point(373, 245);
            this.btnActualizarPuesto.Name = "btnActualizarPuesto";
            this.btnActualizarPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarPuesto.TabIndex = 15;
            this.btnActualizarPuesto.Text = "Actualizar";
            this.btnActualizarPuesto.UseVisualStyleBackColor = true;
            // 
            // btnBorrarPuesto
            // 
            this.btnBorrarPuesto.Location = new System.Drawing.Point(527, 245);
            this.btnBorrarPuesto.Name = "btnBorrarPuesto";
            this.btnBorrarPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarPuesto.TabIndex = 16;
            this.btnBorrarPuesto.Text = "Borrar";
            this.btnBorrarPuesto.UseVisualStyleBackColor = true;
            // 
            // PuestoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnBorrarPuesto);
            this.Controls.Add(this.btnActualizarPuesto);
            this.Controls.Add(this.btnBuscarPuesto);
            this.Controls.Add(this.btnCrearPuesto);
            this.Controls.Add(this.dtgvPuesto);
            this.Controls.Add(this.txtUsuariopt);
            this.Controls.Add(this.txtModificadoporpt);
            this.Controls.Add(this.txtcreadoporpt);
            this.Controls.Add(this.txtNombrePuesto);
            this.Controls.Add(this.txtDepartamentoIdpt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PuestoForm";
            this.Text = "PuestoForm";
            this.Load += new System.EventHandler(this.PuestoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepartamentoIdpt;
        private System.Windows.Forms.TextBox txtNombrePuesto;
        private System.Windows.Forms.TextBox txtcreadoporpt;
        private System.Windows.Forms.TextBox txtModificadoporpt;
        private System.Windows.Forms.TextBox txtUsuariopt;
        private System.Windows.Forms.DataGridView dtgvPuesto;
        private System.Windows.Forms.Button btnCrearPuesto;
        private System.Windows.Forms.Button btnBuscarPuesto;
        private System.Windows.Forms.Button btnActualizarPuesto;
        private System.Windows.Forms.Button btnBorrarPuesto;
    }
}