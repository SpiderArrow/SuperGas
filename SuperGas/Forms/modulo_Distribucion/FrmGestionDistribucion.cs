﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGas.Forms.modulo_Distribucion
{
    public partial class FrmGestionDistribucion : Form
    {
        public FrmGestionDistribucion()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormBase parent = this.ParentForm as FormBase;
            parent.MDistribucion();
        }


    }
}
