using System;
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
            // TODO: cette ligne de code charge les données dans la table 'suplierDataSet.supplier'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.supplierTableAdapter.Fill(this.suplierDataSet.supplier);

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
