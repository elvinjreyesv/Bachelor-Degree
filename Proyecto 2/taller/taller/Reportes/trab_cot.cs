﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller.Reportes
{
    public partial class trab_cot : Form
    {
        public trab_cot()
        {
            InitializeComponent();
        }

        private void trab_cot_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}