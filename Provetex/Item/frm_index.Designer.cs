namespace Provetex.Item
{
    partial class frm_index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_index));
            this.DataGrid_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.Btn_refresh = new System.Windows.Forms.PictureBox();
            this.Button_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Textbox_searsh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_list.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGrid_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.detail});
            this.DataGrid_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGrid_list.DoubleBuffered = true;
            this.DataGrid_list.EnableHeadersVisualStyles = false;
            this.DataGrid_list.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.DataGrid_list.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.DataGrid_list.Location = new System.Drawing.Point(16, 182);
            this.DataGrid_list.Name = "DataGrid_list";
            this.DataGrid_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_list.Size = new System.Drawing.Size(776, 388);
            this.DataGrid_list.TabIndex = 6;
            this.DataGrid_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_list_CellContentClick);
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 32;
            // 
            // detail
            // 
            this.detail.HeaderText = "";
            this.detail.Image = ((System.Drawing.Image)(resources.GetObject("detail.Image")));
            this.detail.Name = "detail";
            this.detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detail.Width = 32;
            // 
            // Btn_refresh
            // 
            this.Btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("Btn_refresh.Image")));
            this.Btn_refresh.Location = new System.Drawing.Point(759, 143);
            this.Btn_refresh.Name = "Btn_refresh";
            this.Btn_refresh.Size = new System.Drawing.Size(33, 33);
            this.Btn_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_refresh.TabIndex = 11;
            this.Btn_refresh.TabStop = false;
            // 
            // Button_add
            // 
            this.Button_add.Active = false;
            this.Button_add.Activecolor = System.Drawing.Color.Silver;
            this.Button_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_add.BorderRadius = 0;
            this.Button_add.ButtonText = "Ajouter un article";
            this.Button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_add.DisabledColor = System.Drawing.Color.RoyalBlue;
            this.Button_add.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_add.Iconimage = ((System.Drawing.Image)(resources.GetObject("Button_add.Iconimage")));
            this.Button_add.Iconimage_right = null;
            this.Button_add.Iconimage_right_Selected = null;
            this.Button_add.Iconimage_Selected = null;
            this.Button_add.IconMarginLeft = 0;
            this.Button_add.IconMarginRight = 0;
            this.Button_add.IconRightVisible = true;
            this.Button_add.IconRightZoom = 0D;
            this.Button_add.IconVisible = true;
            this.Button_add.IconZoom = 50D;
            this.Button_add.IsTab = false;
            this.Button_add.Location = new System.Drawing.Point(16, 143);
            this.Button_add.Name = "Button_add";
            this.Button_add.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.Button_add.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.Button_add.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_add.selected = false;
            this.Button_add.Size = new System.Drawing.Size(151, 33);
            this.Button_add.TabIndex = 10;
            this.Button_add.Text = "Ajouter un article";
            this.Button_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_add.Textcolor = System.Drawing.Color.White;
            this.Button_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(727, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Textbox_searsh
            // 
            this.Textbox_searsh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Textbox_searsh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Textbox_searsh.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Textbox_searsh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_searsh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_searsh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox_searsh.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_searsh.HintText = "Rechercher ...";
            this.Textbox_searsh.isPassword = false;
            this.Textbox_searsh.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_searsh.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_searsh.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_searsh.LineThickness = 3;
            this.Textbox_searsh.Location = new System.Drawing.Point(541, 143);
            this.Textbox_searsh.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_searsh.MaxLength = 32767;
            this.Textbox_searsh.Name = "Textbox_searsh";
            this.Textbox_searsh.Size = new System.Drawing.Size(211, 33);
            this.Textbox_searsh.TabIndex = 8;
            this.Textbox_searsh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Articels";
            // 
            // frm_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.DataGrid_list);
            this.Controls.Add(this.Btn_refresh);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Textbox_searsh);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_index";
            this.Text = "F_RD";
            this.Load += new System.EventHandler(this.F_RD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_list;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn detail;
        private System.Windows.Forms.PictureBox Btn_refresh;
        private Bunifu.Framework.UI.BunifuFlatButton Button_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_searsh;
        private System.Windows.Forms.Label label1;
    }
}