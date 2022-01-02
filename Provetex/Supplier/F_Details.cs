﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provetex.Supplier
{
    public partial class F_Details : Form
    {
        public F_Details()
        {
            InitializeComponent();
        }
        //globales
        private bool firstDetail = true;
        private int id_item;
        private int id_sup_item;
        private int id_sup;
        //Methods
        private void ListSuppliers()
        {
            pictureBox_back.Visible = false;
            label_titel.Text = "Fournisseurs";
            DataGrid_list.Columns["detail"].Visible = true;
            DataGrid_list.DataSource = (from sup in Program.provetex.suppliers
                                        join sup_item in Program.provetex.suppliers_items on sup.C_id_supplier equals sup_item.C_supplier
                                        group sup by new { sup.C_id_supplier, sup.C_name_supplier }
                                        into g
                                        select new
                                        {
                                            ID = g.Key.C_id_supplier,
                                            FOURNISSEUR = g.Key.C_name_supplier,
                                            NOMBRE_ARTICLE = g.Count(),
                                        }
                                        ).ToList();
            DataGrid_list.Columns["delet"].Visible = false;
            firstDetail = true;

        }
        private void ListSupplierDetail(int id)
        {
            DataGrid_list.DataSource = (from sup_items in Program.provetex.suppliers_items
                                        where sup_items.C_supplier == id
                                        select new
                                        {
                                            ID = sup_items.C_id_suppliers_items,
                                            ID_ARTICLE = sup_items.C_item,
                                            ARTICLE = sup_items.item.C_name_item,
                                            PRICE = sup_items.C_price
                                        }).ToList();
        }
        private void Form_load()
        {
            panel_choise.Visible = true;
            radioButton_notNew.Checked = true;
            Dropdown_list_article.Visible = true;
            Textbox_artcle.Visible = false;
        }
        private void item_form()
        {

        }
        //
        private void F_Details_Load(object sender, EventArgs e)
        {
            ListSuppliers();
            panel_form.Visible = false; 
            Button_add.Visible = false;
            Dropdown_list_article.DataSource = (from i in Program.provetex.items
                                    select i).ToList();
            Dropdown_list_article.DisplayMember = "C_name_item";
            Dropdown_list_article.ValueMember = "C_id_item";
        }

        private void DataGrid_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (firstDetail)
            {
                if (e.ColumnIndex == 1)
                {
                    DataGrid_list.Columns["delet"].Visible = true;
                    Button_add.Visible = true;
                    int index = e.RowIndex;
                    id_sup = (int)DataGrid_list.Rows[index].Cells["ID"].Value;
                    var supplier = Program.provetex.suppliers.Find(id_sup);
                    label_titel.Text = supplier.C_name_supplier;
                    ListSupplierDetail(id_sup);
                    pictureBox_back.Visible = true;
                    firstDetail = false;
                    DataGrid_list.Columns["ID"].Visible = false;
                }
                else
                {
                }
            }
            else
            {
                int index = e.RowIndex;
                int id = (int)DataGrid_list.Rows[index].Cells["ID"].Value;
                if (e.ColumnIndex == 0)
                {
                    MessageBox.Show("" + id);
                    DialogResult result = MessageBox.Show("Etes-vous sure?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var supitem = Program.provetex.suppliers_items.Find(id);
                        Program.provetex.suppliers_items.Remove(supitem);
                        Program.provetex.SaveChanges();
                        Refresh();
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    Program.id_sup_item = id;
                    panel_form.Visible = true;
                    panel_choise.Visible = false;
                    Dropdown_list_article.Visible = false;
                    Textbox_artcle.Visible = true;
                    Textbox_artcle.Enabled = false;
                    Textbox_artcle.Text = Program.provetex.suppliers_items.Find(id).item.C_name_item;
                    Textbox_prix.Text = Program.provetex.suppliers_items.Find(id).C_price.ToString();
                    Button_save.ButtonText = "UPDATE";
                }
            }
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            ListSuppliers();
            Button_add.Visible = false;
        }

        private void Textbox_searsh_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            panel_form.Visible = true;
            Form_load();
            Button_add.Visible = false;
            Button_save.ButtonText = "Enregistrer";
        }
        Point point = new Point(36, 58);
        private void radioButton_new_CheckedChanged(object sender, EventArgs e)
        {
            Dropdown_list_article.Visible = false;
            Textbox_artcle.Visible = true;
            Textbox_artcle.Enabled = true;
            Textbox_artcle.Location = point;
            Textbox_artcle.Text = "";
        }

        private void radioButton_notNew_CheckedChanged(object sender, EventArgs e)
        {
            Textbox_artcle.Visible = false;
            Dropdown_list_article.Visible = true;
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            Button_add.Visible = true;
            panel_form.Visible = false;
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            string action = Button_save.ButtonText;
            if (action.ToLower() == "enregistrer")
            {
                MessageBox.Show("Enregistrer");
            }
            else
            {
                var item = Program.provetex.suppliers_items.Find(Program.id_sup_item);
                item.C_price = decimal.Parse(Textbox_prix.Text);
                Program.provetex.SaveChanges();
                MessageBox.Show("update" + Program.id_sup_item.Value);
            }
        }
    }
}
