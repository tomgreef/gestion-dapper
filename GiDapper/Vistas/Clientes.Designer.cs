﻿namespace GiDapper.Vistas
{
    partial class Clientes
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNIF = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonRevisiones = new System.Windows.Forms.Button();
            this.tNIF = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.lEdad = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(295, 9);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(221, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Revisión Ocular";
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Location = new System.Drawing.Point(86, 263);
            this.labelNIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(25, 15);
            this.labelNIF.TabIndex = 2;
            this.labelNIF.Text = "NIF";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(86, 299);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(51, 15);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(86, 368);
            this.labelEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(33, 15);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(86, 335);
            this.labelApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(56, 15);
            this.labelApellidos.TabIndex = 5;
            this.labelApellidos.Text = "Apellidos";
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(88, 462);
            this.buttonAñadir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(88, 27);
            this.buttonAñadir.TabIndex = 6;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.bIns_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(238, 462);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(88, 27);
            this.buttonActualizar.TabIndex = 7;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.bUpd_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(384, 462);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(88, 27);
            this.buttonBorrar.TabIndex = 8;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.bDel_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(521, 462);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(88, 27);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(649, 462);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(88, 27);
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonRevisiones
            // 
            this.buttonRevisiones.Location = new System.Drawing.Point(593, 370);
            this.buttonRevisiones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRevisiones.Name = "buttonRevisiones";
            this.buttonRevisiones.Size = new System.Drawing.Size(88, 27);
            this.buttonRevisiones.TabIndex = 11;
            this.buttonRevisiones.Text = "Revisiones";
            this.buttonRevisiones.UseVisualStyleBackColor = true;
            this.buttonRevisiones.Click += new System.EventHandler(this.buttonRevisiones_Click);
            // 
            // tNIF
            // 
            this.tNIF.Location = new System.Drawing.Point(166, 260);
            this.tNIF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tNIF.Name = "tNIF";
            this.tNIF.Size = new System.Drawing.Size(571, 23);
            this.tNIF.TabIndex = 12;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(166, 299);
            this.tNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(571, 23);
            this.tNombre.TabIndex = 13;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(166, 335);
            this.tApellidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(571, 23);
            this.tApellidos.TabIndex = 14;
            // 
            // lEdad
            // 
            this.lEdad.FormattingEnabled = true;
            this.lEdad.ItemHeight = 15;
            this.lEdad.Location = new System.Drawing.Point(166, 370);
            this.lEdad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lEdad.Name = "lEdad";
            this.lEdad.Size = new System.Drawing.Size(139, 34);
            this.lEdad.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(649, 175);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 552);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lEdad);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tNIF);
            this.Controls.Add(this.buttonRevisiones);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNIF);
            this.Controls.Add(this.labelTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Clientes";
            this.Text = "Revisiones";
            this.Load += new System.EventHandler(this.Revisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonRevisiones;
        private System.Windows.Forms.TextBox tNIF;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.ListBox lEdad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}