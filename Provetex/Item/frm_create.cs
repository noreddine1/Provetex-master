﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provetex.Item
{
    public partial class frm_create : Form
    {
        public frm_create()
        {
            InitializeComponent();
        }

        private void F_CU_Load(object sender, EventArgs e)
        {
            comboBox_suplier.DataSource = Program.provetex.suppliers.ToList();
            comboBox_suplier.ValueMember = "C_id_supplier";
            comboBox_suplier.DisplayMember = "C_name_supplier";
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
           
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
