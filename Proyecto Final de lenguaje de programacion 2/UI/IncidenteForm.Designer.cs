namespace Proyecto_Final_de_lenguaje_de_programacion_2.UI
{
    partial class IncidenteForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCreadoporIncidente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuarioIncidente = new System.Windows.Forms.TextBox();
            this.txtModificadoporIncidente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsuarioReportadoIncidente = new System.Windows.Forms.TextBox();
            this.txtUsuarioAsignadoIdIncidente = new System.Windows.Forms.TextBox();
            this.txtPrioridadIdIncidente = new System.Windows.Forms.TextBox();
            this.DepartamentoIdIncidente = new System.Windows.Forms.TextBox();
            this.txtDescripcionIncidente = new System.Windows.Forms.TextBox();
            this.txtFechaCierreIncidente = new System.Windows.Forms.TextBox();
            this.txtComentariocCerreIncidente = new System.Windows.Forms.TextBox();
            this.txtTituloIncidente = new System.Windows.Forms.TextBox();
            this.dtgvIncidente = new System.Windows.Forms.DataGridView();
            this.btnBorrarIncidente = new System.Windows.Forms.Button();
            this.btnActualizarIncidente = new System.Windows.Forms.Button();
            this.btnBuscarIncidente = new System.Windows.Forms.Button();
            this.btnCrearIncidente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIncidente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario Reportado ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario Asignado ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prioridad ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departamento ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Cierre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comentario de Cierre";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Titulo";
            // 
            // txtCreadoporIncidente
            // 
            this.txtCreadoporIncidente.Location = new System.Drawing.Point(574, 180);
            this.txtCreadoporIncidente.Name = "txtCreadoporIncidente";
            this.txtCreadoporIncidente.Size = new System.Drawing.Size(100, 20);
            this.txtCreadoporIncidente.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Creado por";
            // 
            // txtUsuarioIncidente
            // 
            this.txtUsuarioIncidente.Location = new System.Drawing.Point(773, 93);
            this.txtUsuarioIncidente.Name = "txtUsuarioIncidente";
            this.txtUsuarioIncidente.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioIncidente.TabIndex = 21;
            // 
            // txtModificadoporIncidente
            // 
            this.txtModificadoporIncidente.Location = new System.Drawing.Point(773, 37);
            this.txtModificadoporIncidente.Name = "txtModificadoporIncidente";
            this.txtModificadoporIncidente.Size = new System.Drawing.Size(100, 20);
            this.txtModificadoporIncidente.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(724, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(690, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Modificado por";
            // 
            // txtUsuarioReportadoIncidente
            // 
            this.txtUsuarioReportadoIncidente.Location = new System.Drawing.Point(125, 41);
            this.txtUsuarioReportadoIncidente.Name = "txtUsuarioReportadoIncidente";
            this.txtUsuarioReportadoIncidente.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioReportadoIncidente.TabIndex = 22;
            // 
            // txtUsuarioAsignadoIdIncidente
            // 
            this.txtUsuarioAsignadoIdIncidente.Location = new System.Drawing.Point(125, 108);
            this.txtUsuarioAsignadoIdIncidente.Name = "txtUsuarioAsignadoIdIncidente";
            this.txtUsuarioAsignadoIdIncidente.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioAsignadoIdIncidente.TabIndex = 23;
            // 
            // txtPrioridadIdIncidente
            // 
            this.txtPrioridadIdIncidente.Location = new System.Drawing.Point(125, 183);
            this.txtPrioridadIdIncidente.Name = "txtPrioridadIdIncidente";
            this.txtPrioridadIdIncidente.Size = new System.Drawing.Size(100, 20);
            this.txtPrioridadIdIncidente.TabIndex = 24;
            // 
            // DepartamentoIdIncidente
            // 
            this.DepartamentoIdIncidente.Location = new System.Drawing.Point(349, 37);
            this.DepartamentoIdIncidente.Name = "DepartamentoIdIncidente";
            this.DepartamentoIdIncidente.Size = new System.Drawing.Size(100, 20);
            this.DepartamentoIdIncidente.TabIndex = 25;
            this.DepartamentoIdIncidente.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDescripcionIncidente
            // 
            this.txtDescripcionIncidente.Location = new System.Drawing.Point(349, 180);
            this.txtDescripcionIncidente.Name = "txtDescripcionIncidente";
            this.txtDescripcionIncidente.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionIncidente.TabIndex = 26;
            // 
            // txtFechaCierreIncidente
            // 
            this.txtFechaCierreIncidente.Location = new System.Drawing.Point(574, 37);
            this.txtFechaCierreIncidente.Name = "txtFechaCierreIncidente";
            this.txtFechaCierreIncidente.Size = new System.Drawing.Size(100, 20);
            this.txtFechaCierreIncidente.TabIndex = 27;
            // 
            // txtComentariocCerreIncidente
            // 
            this.txtComentariocCerreIncidente.Location = new System.Drawing.Point(574, 112);
            this.txtComentariocCerreIncidente.Name = "txtComentariocCerreIncidente";
            this.txtComentariocCerreIncidente.Size = new System.Drawing.Size(100, 20);
            this.txtComentariocCerreIncidente.TabIndex = 28;
            // 
            // txtTituloIncidente
            // 
            this.txtTituloIncidente.Location = new System.Drawing.Point(349, 105);
            this.txtTituloIncidente.Name = "txtTituloIncidente";
            this.txtTituloIncidente.Size = new System.Drawing.Size(100, 20);
            this.txtTituloIncidente.TabIndex = 29;
            // 
            // dtgvIncidente
            // 
            this.dtgvIncidente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIncidente.Location = new System.Drawing.Point(12, 276);
            this.dtgvIncidente.Name = "dtgvIncidente";
            this.dtgvIncidente.Size = new System.Drawing.Size(696, 193);
            this.dtgvIncidente.TabIndex = 30;
            // 
            // btnBorrarIncidente
            // 
            this.btnBorrarIncidente.Location = new System.Drawing.Point(536, 247);
            this.btnBorrarIncidente.Name = "btnBorrarIncidente";
            this.btnBorrarIncidente.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarIncidente.TabIndex = 34;
            this.btnBorrarIncidente.Text = "Borrar";
            this.btnBorrarIncidente.UseVisualStyleBackColor = true;
            // 
            // btnActualizarIncidente
            // 
            this.btnActualizarIncidente.Location = new System.Drawing.Point(382, 247);
            this.btnActualizarIncidente.Name = "btnActualizarIncidente";
            this.btnActualizarIncidente.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarIncidente.TabIndex = 33;
            this.btnActualizarIncidente.Text = "Actualizar";
            this.btnActualizarIncidente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarIncidente
            // 
            this.btnBuscarIncidente.Location = new System.Drawing.Point(218, 247);
            this.btnBuscarIncidente.Name = "btnBuscarIncidente";
            this.btnBuscarIncidente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarIncidente.TabIndex = 32;
            this.btnBuscarIncidente.Text = "Buscar";
            this.btnBuscarIncidente.UseVisualStyleBackColor = true;
            // 
            // btnCrearIncidente
            // 
            this.btnCrearIncidente.Location = new System.Drawing.Point(41, 247);
            this.btnCrearIncidente.Name = "btnCrearIncidente";
            this.btnCrearIncidente.Size = new System.Drawing.Size(75, 23);
            this.btnCrearIncidente.TabIndex = 31;
            this.btnCrearIncidente.Text = "Crear";
            this.btnCrearIncidente.UseVisualStyleBackColor = true;
            // 
            // IncidenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(901, 498);
            this.Controls.Add(this.btnBorrarIncidente);
            this.Controls.Add(this.btnActualizarIncidente);
            this.Controls.Add(this.btnBuscarIncidente);
            this.Controls.Add(this.btnCrearIncidente);
            this.Controls.Add(this.dtgvIncidente);
            this.Controls.Add(this.txtTituloIncidente);
            this.Controls.Add(this.txtComentariocCerreIncidente);
            this.Controls.Add(this.txtFechaCierreIncidente);
            this.Controls.Add(this.txtDescripcionIncidente);
            this.Controls.Add(this.DepartamentoIdIncidente);
            this.Controls.Add(this.txtPrioridadIdIncidente);
            this.Controls.Add(this.txtUsuarioAsignadoIdIncidente);
            this.Controls.Add(this.txtUsuarioReportadoIncidente);
            this.Controls.Add(this.txtUsuarioIncidente);
            this.Controls.Add(this.txtModificadoporIncidente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCreadoporIncidente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IncidenteForm";
            this.Text = "IncidenteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIncidente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCreadoporIncidente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsuarioIncidente;
        private System.Windows.Forms.TextBox txtModificadoporIncidente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUsuarioReportadoIncidente;
        private System.Windows.Forms.TextBox txtUsuarioAsignadoIdIncidente;
        private System.Windows.Forms.TextBox txtPrioridadIdIncidente;
        private System.Windows.Forms.TextBox DepartamentoIdIncidente;
        private System.Windows.Forms.TextBox txtDescripcionIncidente;
        private System.Windows.Forms.TextBox txtFechaCierreIncidente;
        private System.Windows.Forms.TextBox txtComentariocCerreIncidente;
        private System.Windows.Forms.TextBox txtTituloIncidente;
        private System.Windows.Forms.DataGridView dtgvIncidente;
        private System.Windows.Forms.Button btnBorrarIncidente;
        private System.Windows.Forms.Button btnActualizarIncidente;
        private System.Windows.Forms.Button btnBuscarIncidente;
        private System.Windows.Forms.Button btnCrearIncidente;
    }
}