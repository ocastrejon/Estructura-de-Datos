﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_Ordenado_con_Listas_Enlazadas
{
    public partial class Form1 : Form
    {
        Inventario inv = new Inventario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxCodigo.Text) || string.IsNullOrEmpty(txtBxNombre.Text) || string.IsNullOrEmpty(txtBxCantidad.Text) || string.IsNullOrEmpty(txtBxPrecio.Text))
                MessageBox.Show("Faltan datos por agregar");
            else
            {
                Producto prA = new Producto();
                prA.codigo = Convert.ToInt16(txtBxCodigo.Text);
                prA.nombre = txtBxNombre.Text;
                prA.cantidad = Convert.ToInt16(txtBxCantidad.Text);
                prA.precio = Convert.ToInt16(txtBxPrecio.Text);

                inv.Agregar(prA);

                txtBxCodigo.Clear();
                txtBxNombre.Clear();
                txtBxCantidad.Clear();
                txtBxPrecio.Clear();
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxCodigo.Text))
                MessageBox.Show("Agregar codigo que desea eliminar");
            else
            {
                inv.Borrar(Convert.ToInt16(txtBxCodigo.Text));
                txtBxCodigo.Clear();
                txtBxInventario.Clear();
                MessageBox.Show("Producto eliminado");
            }
        }

        private void bttnInsertar_Click(object sender, EventArgs e)
        {
           
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxCodigo.Text))
                MessageBox.Show("Ingrese un código de busqueda");
            else
            {
                Producto buscado = inv.Buscar(Convert.ToInt16(txtBxCodigo.Text));
                if (buscado == null)
                {
                    MessageBox.Show("No existe");
                }
                else
                    txtBxInventario.Text = buscado.ToString();
            }
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            if (inv.inicio == null)
                MessageBox.Show("No hay reportes existentes.");
            else
            {
                txtBxInventario.Clear();
                txtBxInventario.Text += inv.Reporte().ToString();
            }
        }

        private void bttnReporteInvertido_Click(object sender, EventArgs e)
        {
            txtBxInventario.Text += inv.ReporteInvertido();
        }
    }
}
