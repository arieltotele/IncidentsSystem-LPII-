namespace Proyecto_Final_de_lenguaje_de_programacion_2.UI
{
    partial class Historial_de_IncidentesForm
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
            this.txtIdHistorial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIncidenteIdHistorial = new System.Windows.Forms.TextBox();
            this.txtComentarioHistorial = new System.Windows.Forms.TextBox();
            this.dtgvHistorial = new System.Windows.Forms.DataGridView();
            this.btnBorrarHistorial = new System.Windows.Forms.Button();
            this.btnActualizarHistorial = new System.Windows.Forms.Button();
            this.btnBuscarHistorial = new System.Windows.Forms.Button();
            this.btnCrearHistorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incidente ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comentario";
            // 
            // txtIdHistorial
            // 
            this.txtIdHistorial.Location = new System.Drawing.Point(552, 45);
            this.txtIdHistorial.Name = "txtIdHistorial";
            this.txtIdHistorial.Size = new System.Drawing.Size(100, 20);
            this.txtIdHistorial.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID:";
            // 
            // txtIncidenteIdHistorial
            // 
            this.txtIncidenteIdHistorial.Location = new System.Drawing.Point(82, 45);
            this.txtIncidenteIdHistorial.Name = "txtIncidenteIdHistorial";
            this.txtIncidenteIdHistorial.Size = new System.Drawing.Size(100, 20);
            this.txtIncidenteIdHistorial.TabIndex = 26;
            // 
            // txtComentarioHistorial
            // 
            this.txtComentarioHistorial.Location = new System.Drawing.Point(313, 42);
            this.txtComentarioHistorial.Name = "txtComentarioHistorial";
            this.txtComentarioHistorial.Size = new System.Drawing.Size(100, 20);
            this.txtComentarioHistorial.TabIndex = 27;
            // 
            // dtgvHistorial
            // 
            this.dtgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistorial.Location = new System.Drawing.Point(20, 274);
            this.dtgvHistorial.Name = "dtgvHistorial";
            this.dtgvHistorial.Size = new System.Drawing.Size(696, 193);
            this.dtgvHistorial.TabIndex = 31;
            // 
            // btnBorrarHistorial
            // 
            this.btnBorrarHistorial.Location = new System.Drawing.Point(577, 245);
            this.btnBorrarHistorial.Name = "btnBorrarHistorial";
            this.btnBorrarHistorial.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarHistorial.TabIndex = 35;
            this.btnBorrarHistorial.Text = "Borrar";
            this.btnBorrarHistorial.UseVisualStyleBackColor = true;
            // 
            // btnActualizarHistorial
            // 
            this.btnActualizarHistorial.Location = new System.Drawing.Point(423, 245);
            this.btnActualizarHistorial.Name = "btnActualizarHistorial";
            this.btnActualizarHistorial.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarHistorial.TabIndex = 34;
            this.btnActualizarHistorial.Text = "Actualizar";
            this.btnActualizarHistorial.UseVisualStyleBackColor = true;
            this.btnActualizarHistorial.Click += new System.EventHandler(this.btnActualizarHistorial_Click);
            // 
            // btnBuscarHistorial
            // 
            this.btnBuscarHistorial.Location = new System.Drawing.Point(259, 245);
            this.btnBuscarHistorial.Name = "btnBuscarHistorial";
            this.btnBuscarHistorial.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarHistorial.TabIndex = 33;
            this.btnBuscarHistorial.Text = "Buscar";
            this.btnBuscarHistorial.UseVisualStyleBackColor = true;
            this.btnBuscarHistorial.Click += new System.EventHandler(this.btnBuscarHistorial_Click);
            // 
            // btnCrearHistorial
            // 
            this.btnCrearHistorial.Location = new System.Drawing.Point(82, 245);
            this.btnCrearHistorial.Name = "btnCrearHistorial";
            this.btnCrearHistorial.Size = new System.Drawing.Size(75, 23);
            this.btnCrearHistorial.TabIndex = 32;
            this.btnCrearHistorial.Text = "Crear";
            this.btnCrearHistorial.UseVisualStyleBackColor = true;
            this.btnCrearHistorial.Click += new System.EventHandler(this.btnCrearHistorial_Click);
            // 
            // Historial_de_IncidentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btnBorrarHistorial);
            this.Controls.Add(this.btnActualizarHistorial);
            this.Controls.Add(this.btnBuscarHistorial);
            this.Controls.Add(this.btnCrearHistorial);
            this.Controls.Add(this.dtgvHistorial);
            this.Controls.Add(this.txtComentarioHistorial);
            this.Controls.Add(this.txtIncidenteIdHistorial);
            this.Controls.Add(this.txtIdHistorial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Historial_de_IncidentesForm";
            this.Text = "Historial_de_IncidentesForm";
            this.Load += new System.EventHandler(this.Historial_de_IncidentesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdHistorial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIncidenteIdHistorial;
        private System.Windows.Forms.TextBox txtComentarioHistorial;
        private System.Windows.Forms.DataGridView dtgvHistorial;
        private System.Windows.Forms.Button btnBorrarHistorial;
        private System.Windows.Forms.Button btnActualizarHistorial;
        private System.Windows.Forms.Button btnBuscarHistorial;
        private System.Windows.Forms.Button btnCrearHistorial;
    }
}