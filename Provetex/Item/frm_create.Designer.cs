namespace Provetex.Item
{
    partial class frm_create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_create));
            this.Button_back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Textbox_phone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox_suplier = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Button_back
            // 
            this.Button_back.ActiveBorderThickness = 1;
            this.Button_back.ActiveCornerRadius = 20;
            this.Button_back.ActiveFillColor = System.Drawing.Color.Gray;
            this.Button_back.ActiveForecolor = System.Drawing.Color.White;
            this.Button_back.ActiveLineColor = System.Drawing.Color.Gray;
            this.Button_back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Button_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_back.BackgroundImage")));
            this.Button_back.ButtonText = "Annuler";
            this.Button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_back.ForeColor = System.Drawing.Color.Gray;
            this.Button_back.IdleBorderThickness = 1;
            this.Button_back.IdleCornerRadius = 20;
            this.Button_back.IdleFillColor = System.Drawing.Color.White;
            this.Button_back.IdleForecolor = System.Drawing.Color.Gray;
            this.Button_back.IdleLineColor = System.Drawing.Color.Gray;
            this.Button_back.Location = new System.Drawing.Point(217, 357);
            this.Button_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_back.Name = "Button_back";
            this.Button_back.Size = new System.Drawing.Size(113, 46);
            this.Button_back.TabIndex = 30;
            this.Button_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // Button_save
            // 
            this.Button_save.ActiveBorderThickness = 1;
            this.Button_save.ActiveCornerRadius = 20;
            this.Button_save.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.Button_save.ActiveForecolor = System.Drawing.Color.White;
            this.Button_save.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.Button_save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_save.BackgroundImage")));
            this.Button_save.ButtonText = "Enregistrer";
            this.Button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_save.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Button_save.IdleBorderThickness = 1;
            this.Button_save.IdleCornerRadius = 20;
            this.Button_save.IdleFillColor = System.Drawing.Color.White;
            this.Button_save.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.Button_save.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.Button_save.Location = new System.Drawing.Point(71, 357);
            this.Button_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_save.Name = "Button_save";
            this.Button_save.Size = new System.Drawing.Size(113, 46);
            this.Button_save.TabIndex = 29;
            this.Button_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // Textbox_phone
            // 
            this.Textbox_phone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Textbox_phone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Textbox_phone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Textbox_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_phone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Textbox_phone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.Textbox_phone.HintText = "Prix";
            this.Textbox_phone.isPassword = false;
            this.Textbox_phone.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_phone.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_phone.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.Textbox_phone.LineThickness = 3;
            this.Textbox_phone.Location = new System.Drawing.Point(71, 253);
            this.Textbox_phone.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_phone.MaxLength = 32767;
            this.Textbox_phone.Name = "Textbox_phone";
            this.Textbox_phone.Size = new System.Drawing.Size(181, 33);
            this.Textbox_phone.TabIndex = 27;
            this.Textbox_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_nom
            // 
            this.txt_nom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_nom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_nom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.txt_nom.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(5)))));
            this.txt_nom.HintText = "Nom d\'article";
            this.txt_nom.isPassword = false;
            this.txt_nom.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_nom.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_nom.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_nom.LineThickness = 3;
            this.txt_nom.Location = new System.Drawing.Point(71, 102);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom.MaxLength = 32767;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(259, 33);
            this.txt_nom.TabIndex = 26;
            this.txt_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox_suplier
            // 
            this.comboBox_suplier.FormattingEnabled = true;
            this.comboBox_suplier.Location = new System.Drawing.Point(71, 200);
            this.comboBox_suplier.Name = "comboBox_suplier";
            this.comboBox_suplier.Size = new System.Drawing.Size(259, 21);
            this.comboBox_suplier.TabIndex = 31;
            // 
            // frm_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 470);
            this.Controls.Add(this.comboBox_suplier);
            this.Controls.Add(this.Button_back);
            this.Controls.Add(this.Button_save);
            this.Controls.Add(this.Textbox_phone);
            this.Controls.Add(this.txt_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_create";
            this.Text = "F_CU";
            this.Load += new System.EventHandler(this.F_CU_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 Button_back;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_save;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_phone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nom;
        private System.Windows.Forms.ComboBox comboBox_suplier;
    }
}