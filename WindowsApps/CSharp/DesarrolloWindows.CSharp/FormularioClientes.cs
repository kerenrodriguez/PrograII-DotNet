﻿using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesarrolloWindows.CSharp
{
    public partial class FormularioClientes : Form
    {
        public FormularioClientes(Cliente[] clientes)
        {
            InitializeComponent();

            dataGridView1.DataSource = clientes;
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
