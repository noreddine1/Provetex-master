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
    public partial class frm_index : Form
    {
        public frm_index()
        {
            InitializeComponent();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {

        }

        private void F_RD_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void DataGrid_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        private void Refresh()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {

            DataGrid_list.DataSource = Program.provetex.items.Select(item => new
            {
                ID = item.C_id_item,
                Name = item.C_name_item
                //ID = sup.C_id_supplier,
                //FOURNISSEUR = sup.C_name_supplier,
                //ADRESSE = sup.C_adress_supplier,
                //PHONE = sup.C_phone_supplier,
                //EMAIL = sup.C_email_supplier,
                //AJOUTER = sup.created_at,
                //UPDATE = sup.update_at
            }).ToList();
            DataGrid_list.Columns["ID"].Visible = false;

        }
    }
}
