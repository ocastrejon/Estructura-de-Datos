﻿namespace Inventario_con_Listas_Simples_Enlazadas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnReporte = new System.Windows.Forms.Button();
            this.txtBxInventario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxPosicion = new System.Windows.Forms.TextBox();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnInsertar = new System.Windows.Forms.Button();
            this.txtBxPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.bttnAgregarEnInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnReporte
            // 
            this.bttnReporte.AutoSize = true;
            this.bttnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReporte.Location = new System.Drawing.Point(163, 489);
            this.bttnReporte.Name = "bttnReporte";
            this.bttnReporte.Size = new System.Drawing.Size(110, 39);
            this.bttnReporte.TabIndex = 31;
            this.bttnReporte.Text = "Reporte";
            this.bttnReporte.UseVisualStyleBackColor = true;
            this.bttnReporte.Click += new System.EventHandler(this.bttnReporte_Click);
            // 
            // txtBxInventario
            // 
            this.txtBxInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxInventario.Location = new System.Drawing.Point(284, 35);
            this.txtBxInventario.Multiline = true;
            this.txtBxInventario.Name = "txtBxInventario";
            this.txtBxInventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxInventario.Size = new System.Drawing.Size(231, 493);
            this.txtBxInventario.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Pos:";
            // 
            // txtBxPosicion
            // 
            this.txtBxPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPosicion.Location = new System.Drawing.Point(221, 302);
            this.txtBxPosicion.Name = "txtBxPosicion";
            this.txtBxPosicion.Size = new System.Drawing.Size(43, 34);
            this.txtBxPosicion.TabIndex = 28;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.AutoSize = true;
            this.bttnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBuscar.Location = new System.Drawing.Point(103, 357);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(102, 39);
            this.bttnBuscar.TabIndex = 27;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.AutoSize = true;
            this.bttnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminar.Location = new System.Drawing.Point(29, 297);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(55, 39);
            this.bttnEliminar.TabIndex = 26;
            this.bttnEliminar.Text = "-";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnInsertar
            // 
            this.bttnInsertar.AutoSize = true;
            this.bttnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnInsertar.Location = new System.Drawing.Point(103, 299);
            this.bttnInsertar.Name = "bttnInsertar";
            this.bttnInsertar.Size = new System.Drawing.Size(103, 39);
            this.bttnInsertar.TabIndex = 25;
            this.bttnInsertar.Text = "Insertar";
            this.bttnInsertar.UseVisualStyleBackColor = true;
            this.bttnInsertar.Click += new System.EventHandler(this.bttnInsertar_Click);
            // 
            // txtBxPrecio
            // 
            this.txtBxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPrecio.Location = new System.Drawing.Point(150, 155);
            this.txtBxPrecio.Name = "txtBxPrecio";
            this.txtBxPrecio.Size = new System.Drawing.Size(100, 34);
            this.txtBxPrecio.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Precio:";
            // 
            // txtBxCantidad
            // 
            this.txtBxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCantidad.Location = new System.Drawing.Point(150, 115);
            this.txtBxCantidad.Name = "txtBxCantidad";
            this.txtBxCantidad.Size = new System.Drawing.Size(100, 34);
            this.txtBxCantidad.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cantidad:";
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNombre.Location = new System.Drawing.Point(150, 75);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(100, 34);
            this.txtBxNombre.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre:";
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCodigo.Location = new System.Drawing.Point(150, 35);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.Size = new System.Drawing.Size(100, 34);
            this.txtBxCodigo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código:";
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.AutoSize = true;
            this.bttnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregar.Location = new System.Drawing.Point(29, 239);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(55, 39);
            this.bttnAgregar.TabIndex = 16;
            this.bttnAgregar.Text = "+";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // bttnAgregarEnInicio
            // 
            this.bttnAgregarEnInicio.AutoSize = true;
            this.bttnAgregarEnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregarEnInicio.Location = new System.Drawing.Point(106, 239);
            this.bttnAgregarEnInicio.Name = "bttnAgregarEnInicio";
            this.bttnAgregarEnInicio.Size = new System.Drawing.Size(100, 39);
            this.bttnAgregarEnInicio.TabIndex = 32;
            this.bttnAgregarEnInicio.Text = "+ Inicio";
            this.bttnAgregarEnInicio.UseVisualStyleBackColor = true;
            this.bttnAgregarEnInicio.Click += new System.EventHandler(this.bttnAgregarEnInicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 562);
            this.Controls.Add(this.bttnAgregarEnInicio);
            this.Controls.Add(this.bttnReporte);
            this.Controls.Add(this.txtBxInventario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxPosicion);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnInsertar);
            this.Controls.Add(this.txtBxPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnReporte;
        private System.Windows.Forms.TextBox txtBxInventario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxPosicion;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnInsertar;
        private System.Windows.Forms.TextBox txtBxPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Button bttnAgregarEnInicio;
    }
}

