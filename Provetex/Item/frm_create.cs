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
        item itemModel = new item();
        suppliers_items model= new suppliers_items();
        private void F_CU_Load(object sender, EventArgs e)
        {
            comboBox_suplier.DataSource = Program.provetex.suppliers.ToList();
            comboBox_suplier.ValueMember = "C_id_supplier";
            comboBox_suplier.DisplayMember = "C_name_supplier";
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            var Name = txt_nom.Text;
            IQueryable<int> item = from c in Program.provetex.items
                       where c.C_name_item == Name
                       select c.C_id_item;
            if (item.Count()==0)
            {
                itemModel.C_name_item = txt_nom.Text;
                //add item to table item
                Program.provetex.items.Add(itemModel);

                // add suplier_item
                model.C_item = itemModel.C_id_item;
                model.C_supplier = int.Parse(comboBox_suplier.SelectedValue.ToString());
                model.C_price = decimal.Parse(Textbox_price.Text);
                Program.provetex.suppliers_items.Add(model);
                Program.provetex.SaveChanges();
                MessageBox.Show("articl ajouter avec succé");
            }
            else
            {
                // add suplier_item
                model.C_item =item.FirstOrDefault();
                model.C_supplier = int.Parse(comboBox_suplier.SelectedValue.ToString());
                model.C_price = decimal.Parse(Textbox_price.Text);
                Program.provetex.suppliers_items.Add(model);
                Program.provetex.SaveChanges();
                MessageBox.Show("articl ajouter avec succé");
            }
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
