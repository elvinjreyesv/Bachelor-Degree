﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace habitacion
{
    public partial class reporte_tematica : Form
    {
        public reporte_tematica()
        {
            InitializeComponent();
        }

        private void reporte_tematica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_tematica' Puede moverla o quitarla según sea necesario.
            this.v_tematicaTableAdapter.Fill(this.DataSet1.v_tematica);

            this.reportViewer1.RefreshReport();
        }
    }
}
