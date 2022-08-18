namespace Proyecto_Final_de_lenguaje_de_programacion_2.UI
{
    partial class DepartamentoForm
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
            this.txtNombredep = new System.Windows.Forms.TextBox();
            this.txtCreadopordep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModificadopordep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuariodep = new System.Windows.Forms.TextBox();
            this.dtgvDepartamento = new System.Windows.Forms.DataGridView();
            this.btnBorrarDepartamento = new System.Windows.Forms.Button();
            this.btnActualizarDepartamento = new System.Windows.Forms.Button();
            this.btnBuscarDepartamento = new System.Windows.Forms.Button();
            this.btnCrearDepartamento = new System.Windows.Forms.Button();
            this.id_departxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombredep
            // 
            this.txtNombredep.Location = new System.Drawing.Point(75, 133);
            this.txtNombredep.Name = "txtNombredep";
            this.txtNombredep.Size = new System.Drawing.Size(119, 20);
            this.txtNombredep.TabIndex = 3;
            // 
            // txtCreadopordep
            // 
            this.txtCreadopordep.Location = new System.Drawing.Point(320, 63);
            this.txtCreadopordep.Name = "txtCreadopordep";
            this.txtCreadopordep.Size = new System.Drawing.Size(100, 20);
            this.txtCreadopordep.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Creado por";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Modificado por";
            // 
            // txtModificadopordep
            // 
            this.txtModificadopordep.Location = new System.Drawing.Point(320, 133);
            this.txtModificadopordep.Name = "txtModificadopordep";
            this.txtModificadopordep.Size = new System.Drawing.Size(100, 20);
            this.txtModificadopordep.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Usuario";
            // 
            // txtUsuariodep
            // 
            this.txtUsuariodep.Location = new System.Drawing.Point(548, 70);
            this.txtUsuariodep.Name = "txtUsuariodep";
            this.txtUsuariodep.Size = new System.Drawing.Size(100, 20);
            this.txtUsuariodep.TabIndex = 10;
            // 
            // dtgvDepartamento
            // 
            this.dtgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDepartamento.Location = new System.Drawing.Point(24, 307);
            this.dtgvDepartamento.Name = "dtgvDepartamento";
            this.dtgvDepartamento.Size = new System.Drawing.Size(696, 193);
            this.dtgvDepartamento.TabIndex = 11;
            // 
            // btnBorrarDepartamento
            // 
            this.btnBorrarDepartamento.Location = new System.Drawing.Point(519, 268);
            this.btnBorrarDepartamento.Name = "btnBorrarDepartamento";
            this.btnBorrarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarDepartamento.TabIndex = 20;
            this.btnBorrarDepartamento.Text = "Borrar";
            this.btnBorrarDepartamento.UseVisualStyleBackColor = true;
            this.btnBorrarDepartamento.Click += new System.EventHandler(this.btnBorrarDepartamento_Click);
            // 
            // btnActualizarDepartamento
            // 
            this.btnActualizarDepartamento.Location = new System.Drawing.Point(365, 268);
            this.btnActualizarDepartamento.Name = "btnActualizarDepartamento";
            this.btnActualizarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarDepartamento.TabIndex = 19;
            this.btnActualizarDepartamento.Text = "Actualizar";
            this.btnActualizarDepartamento.UseVisualStyleBackColor = true;
            this.btnActualizarDepartamento.Click += new System.EventHandler(this.btnActualizarDepartamento_Click);
            // 
            // btnBuscarDepartamento
            // 
            this.btnBuscarDepartamento.Location = new System.Drawing.Point(201, 268);
            this.btnBuscarDepartamento.Name = "btnBuscarDepartamento";
            this.btnBuscarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDepartamento.TabIndex = 18;
            this.btnBuscarDepartamento.Text = "Buscar";
            this.btnBuscarDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscarDepartamento.Click += new System.EventHandler(this.btnBuscarDepartamento_Click);
            // 
            // btnCrearDepartamento
            // 
            this.btnCrearDepartamento.Location = new System.Drawing.Point(24, 268);
            this.btnCrearDepartamento.Name = "btnCrearDepartamento";
            this.btnCrearDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnCrearDepartamento.TabIndex = 17;
            this.btnCrearDepartamento.Text = "Crear";
            this.btnCrearDepartamento.UseVisualStyleBackColor = true;
            this.btnCrearDepartamento.Click += new System.EventHandler(this.btnCrearDepartamento_Click);
            // 
            // id_departxt
            // 
            this.id_departxt.Location = new System.Drawing.Point(111, 70);
            this.id_departxt.Name = "id_departxt";
            this.id_departxt.Size = new System.Drawing.Size(100, 20);
            this.id_departxt.TabIndex = 22;
            this.id_departxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id Departamento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DepartamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.id_departxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBorrarDepartamento);
            this.Controls.Add(this.btnActualizarDepartamento);
            this.Controls.Add(this.btnBuscarDepartamento);
            this.Controls.Add(this.btnCrearDepartamento);
            this.Controls.Add(this.dtgvDepartamento);
            this.Controls.Add(this.txtUsuariodep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModificadopordep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreadopordep);
            this.Controls.Add(this.txtNombredep);
            this.Controls.Add(this.label1);
            this.Name = "DepartamentoForm";
            this.Text = "DepartamentoForm";
            this.Load += new System.EventHandler(this.DepartamentoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombredep;
        private System.Windows.Forms.TextBox txtCreadopordep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModificadopordep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuariodep;
        private System.Windows.Forms.DataGridView dtgvDepartamento;
        private System.Windows.Forms.Button btnBorrarDepartamento;
        private System.Windows.Forms.Button btnActualizarDepartamento;
        private System.Windows.Forms.Button btnBuscarDepartamento;
        private System.Windows.Forms.Button btnCrearDepartamento;
        private System.Windows.Forms.TextBox id_departxt;
        private System.Windows.Forms.Label label2;
    }
}