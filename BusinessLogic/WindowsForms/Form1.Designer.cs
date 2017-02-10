namespace WindowsForms
{
    partial class Form1
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
			this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.tab1Clients = new MetroFramework.Controls.MetroTabPage();
			this.cmbbox_searchType = new MetroFramework.Controls.MetroComboBox();
			this.lbl_search_ID = new MetroFramework.Controls.MetroLabel();
			this.lbl_search_RaceLastName = new MetroFramework.Controls.MetroLabel();
			this.lbl_search_name = new MetroFramework.Controls.MetroLabel();
			this.txtbox_ID = new MetroFramework.Controls.MetroTextBox();
			this.txtbox_LastNameRace = new MetroFramework.Controls.MetroTextBox();
			this.txtbox_name = new MetroFramework.Controls.MetroTextBox();
			this.tab2Pets = new MetroFramework.Controls.MetroTabPage();
			this.metroButton4 = new MetroFramework.Controls.MetroButton();
			this.metroButton5 = new MetroFramework.Controls.MetroButton();
			this.metroButton6 = new MetroFramework.Controls.MetroButton();
			this.tab3Manage = new MetroFramework.Controls.MetroTabPage();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroTabControl1.SuspendLayout();
			this.tab1Clients.SuspendLayout();
			this.tab2Pets.SuspendLayout();
			this.tab3Manage.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroStyleManager1
			// 
			this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.tab1Clients);
			this.metroTabControl1.Controls.Add(this.tab2Pets);
			this.metroTabControl1.Controls.Add(this.tab3Manage);
			this.metroTabControl1.CustomBackground = false;
			this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium;
			this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light;
			this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 0;
			this.metroTabControl1.Size = new System.Drawing.Size(594, 394);
			this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTabControl1.StyleManager = null;
			this.metroTabControl1.TabIndex = 3;
			this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTabControl1.UseStyleColors = false;
			// 
			// tab1Clients
			// 
			this.tab1Clients.Controls.Add(this.cmbbox_searchType);
			this.tab1Clients.Controls.Add(this.lbl_search_ID);
			this.tab1Clients.Controls.Add(this.lbl_search_RaceLastName);
			this.tab1Clients.Controls.Add(this.lbl_search_name);
			this.tab1Clients.Controls.Add(this.txtbox_ID);
			this.tab1Clients.Controls.Add(this.txtbox_LastNameRace);
			this.tab1Clients.Controls.Add(this.txtbox_name);
			this.tab1Clients.CustomBackground = false;
			this.tab1Clients.HorizontalScrollbar = false;
			this.tab1Clients.HorizontalScrollbarBarColor = true;
			this.tab1Clients.HorizontalScrollbarHighlightOnWheel = false;
			this.tab1Clients.HorizontalScrollbarSize = 10;
			this.tab1Clients.Location = new System.Drawing.Point(4, 35);
			this.tab1Clients.Name = "tab1Clients";
			this.tab1Clients.Size = new System.Drawing.Size(586, 355);
			this.tab1Clients.Style = MetroFramework.MetroColorStyle.Blue;
			this.tab1Clients.StyleManager = null;
			this.tab1Clients.TabIndex = 0;
			this.tab1Clients.Text = "Busqueda";
			this.tab1Clients.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tab1Clients.VerticalScrollbar = false;
			this.tab1Clients.VerticalScrollbarBarColor = true;
			this.tab1Clients.VerticalScrollbarHighlightOnWheel = false;
			this.tab1Clients.VerticalScrollbarSize = 10;
			// 
			// cmbbox_searchType
			// 
			this.cmbbox_searchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbbox_searchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbbox_searchType.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cmbbox_searchType.FontWeight = MetroFramework.MetroLinkWeight.Regular;
			this.cmbbox_searchType.FormattingEnabled = true;
			this.cmbbox_searchType.ItemHeight = 23;
			this.cmbbox_searchType.Items.AddRange(new object[] {
            "Cliente",
            "Mascota"});
			this.cmbbox_searchType.Location = new System.Drawing.Point(3, 23);
			this.cmbbox_searchType.Name = "cmbbox_searchType";
			this.cmbbox_searchType.Size = new System.Drawing.Size(196, 29);
			this.cmbbox_searchType.Style = MetroFramework.MetroColorStyle.Blue;
			this.cmbbox_searchType.StyleManager = null;
			this.cmbbox_searchType.TabIndex = 8;
			this.cmbbox_searchType.Theme = MetroFramework.MetroThemeStyle.Light;
			this.cmbbox_searchType.SelectedIndexChanged += new System.EventHandler(this.cmbbox_searchType_SelectedIndexChanged);
			// 
			// lbl_search_ID
			// 
			this.lbl_search_ID.AutoSize = true;
			this.lbl_search_ID.CustomBackground = false;
			this.lbl_search_ID.CustomForeColor = false;
			this.lbl_search_ID.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_search_ID.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_search_ID.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_search_ID.Location = new System.Drawing.Point(3, 165);
			this.lbl_search_ID.Name = "lbl_search_ID";
			this.lbl_search_ID.Size = new System.Drawing.Size(21, 19);
			this.lbl_search_ID.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_search_ID.StyleManager = null;
			this.lbl_search_ID.TabIndex = 7;
			this.lbl_search_ID.Text = "ID";
			this.lbl_search_ID.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_search_ID.UseStyleColors = false;
			// 
			// lbl_search_RaceLastName
			// 
			this.lbl_search_RaceLastName.AutoSize = true;
			this.lbl_search_RaceLastName.CustomBackground = false;
			this.lbl_search_RaceLastName.CustomForeColor = false;
			this.lbl_search_RaceLastName.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_search_RaceLastName.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_search_RaceLastName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_search_RaceLastName.Location = new System.Drawing.Point(3, 117);
			this.lbl_search_RaceLastName.Name = "lbl_search_RaceLastName";
			this.lbl_search_RaceLastName.Size = new System.Drawing.Size(58, 19);
			this.lbl_search_RaceLastName.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_search_RaceLastName.StyleManager = null;
			this.lbl_search_RaceLastName.TabIndex = 6;
			this.lbl_search_RaceLastName.Text = "Apellido";
			this.lbl_search_RaceLastName.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_search_RaceLastName.UseStyleColors = false;
			// 
			// lbl_search_name
			// 
			this.lbl_search_name.AutoSize = true;
			this.lbl_search_name.CustomBackground = false;
			this.lbl_search_name.CustomForeColor = false;
			this.lbl_search_name.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_search_name.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_search_name.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_search_name.Location = new System.Drawing.Point(3, 69);
			this.lbl_search_name.Name = "lbl_search_name";
			this.lbl_search_name.Size = new System.Drawing.Size(59, 19);
			this.lbl_search_name.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_search_name.StyleManager = null;
			this.lbl_search_name.TabIndex = 5;
			this.lbl_search_name.Text = "Nombre";
			this.lbl_search_name.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_search_name.UseStyleColors = false;
			// 
			// txtbox_ID
			// 
			this.txtbox_ID.CustomBackground = false;
			this.txtbox_ID.CustomForeColor = false;
			this.txtbox_ID.FontSize = MetroFramework.MetroTextBoxSize.Small;
			this.txtbox_ID.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
			this.txtbox_ID.Location = new System.Drawing.Point(3, 187);
			this.txtbox_ID.Multiline = false;
			this.txtbox_ID.Name = "txtbox_ID";
			this.txtbox_ID.SelectedText = "";
			this.txtbox_ID.Size = new System.Drawing.Size(196, 23);
			this.txtbox_ID.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtbox_ID.StyleManager = null;
			this.txtbox_ID.TabIndex = 4;
			this.txtbox_ID.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtbox_ID.UseStyleColors = false;
			// 
			// txtbox_LastNameRace
			// 
			this.txtbox_LastNameRace.CustomBackground = false;
			this.txtbox_LastNameRace.CustomForeColor = false;
			this.txtbox_LastNameRace.FontSize = MetroFramework.MetroTextBoxSize.Small;
			this.txtbox_LastNameRace.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
			this.txtbox_LastNameRace.Location = new System.Drawing.Point(3, 139);
			this.txtbox_LastNameRace.Multiline = false;
			this.txtbox_LastNameRace.Name = "txtbox_LastNameRace";
			this.txtbox_LastNameRace.SelectedText = "";
			this.txtbox_LastNameRace.Size = new System.Drawing.Size(196, 23);
			this.txtbox_LastNameRace.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtbox_LastNameRace.StyleManager = null;
			this.txtbox_LastNameRace.TabIndex = 3;
			this.txtbox_LastNameRace.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtbox_LastNameRace.UseStyleColors = false;
			// 
			// txtbox_name
			// 
			this.txtbox_name.CustomBackground = false;
			this.txtbox_name.CustomForeColor = false;
			this.txtbox_name.FontSize = MetroFramework.MetroTextBoxSize.Small;
			this.txtbox_name.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
			this.txtbox_name.Location = new System.Drawing.Point(3, 91);
			this.txtbox_name.Multiline = false;
			this.txtbox_name.Name = "txtbox_name";
			this.txtbox_name.SelectedText = "";
			this.txtbox_name.Size = new System.Drawing.Size(196, 23);
			this.txtbox_name.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtbox_name.StyleManager = null;
			this.txtbox_name.TabIndex = 2;
			this.txtbox_name.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtbox_name.UseStyleColors = false;
			// 
			// tab2Pets
			// 
			this.tab2Pets.Controls.Add(this.metroButton4);
			this.tab2Pets.Controls.Add(this.metroButton5);
			this.tab2Pets.Controls.Add(this.metroButton6);
			this.tab2Pets.CustomBackground = false;
			this.tab2Pets.HorizontalScrollbar = false;
			this.tab2Pets.HorizontalScrollbarBarColor = true;
			this.tab2Pets.HorizontalScrollbarHighlightOnWheel = false;
			this.tab2Pets.HorizontalScrollbarSize = 10;
			this.tab2Pets.Location = new System.Drawing.Point(4, 35);
			this.tab2Pets.Name = "tab2Pets";
			this.tab2Pets.Size = new System.Drawing.Size(586, 355);
			this.tab2Pets.Style = MetroFramework.MetroColorStyle.Blue;
			this.tab2Pets.StyleManager = null;
			this.tab2Pets.TabIndex = 1;
			this.tab2Pets.Text = "Registrar Cliente";
			this.tab2Pets.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tab2Pets.VerticalScrollbar = false;
			this.tab2Pets.VerticalScrollbarBarColor = true;
			this.tab2Pets.VerticalScrollbarHighlightOnWheel = false;
			this.tab2Pets.VerticalScrollbarSize = 10;
			// 
			// metroButton4
			// 
			this.metroButton4.Highlight = false;
			this.metroButton4.Location = new System.Drawing.Point(508, 81);
			this.metroButton4.Name = "metroButton4";
			this.metroButton4.Size = new System.Drawing.Size(75, 23);
			this.metroButton4.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton4.StyleManager = null;
			this.metroButton4.TabIndex = 5;
			this.metroButton4.Text = "metroButton4";
			this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// metroButton5
			// 
			this.metroButton5.Highlight = false;
			this.metroButton5.Location = new System.Drawing.Point(508, 51);
			this.metroButton5.Name = "metroButton5";
			this.metroButton5.Size = new System.Drawing.Size(75, 23);
			this.metroButton5.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton5.StyleManager = null;
			this.metroButton5.TabIndex = 4;
			this.metroButton5.Text = "metroButton5";
			this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// metroButton6
			// 
			this.metroButton6.Highlight = false;
			this.metroButton6.Location = new System.Drawing.Point(508, 21);
			this.metroButton6.Name = "metroButton6";
			this.metroButton6.Size = new System.Drawing.Size(75, 23);
			this.metroButton6.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton6.StyleManager = null;
			this.metroButton6.TabIndex = 3;
			this.metroButton6.Text = "metroButton6";
			this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// tab3Manage
			// 
			this.tab3Manage.Controls.Add(this.metroButton3);
			this.tab3Manage.Controls.Add(this.metroButton2);
			this.tab3Manage.Controls.Add(this.metroButton1);
			this.tab3Manage.CustomBackground = false;
			this.tab3Manage.HorizontalScrollbar = false;
			this.tab3Manage.HorizontalScrollbarBarColor = true;
			this.tab3Manage.HorizontalScrollbarHighlightOnWheel = false;
			this.tab3Manage.HorizontalScrollbarSize = 10;
			this.tab3Manage.Location = new System.Drawing.Point(4, 35);
			this.tab3Manage.Name = "tab3Manage";
			this.tab3Manage.Size = new System.Drawing.Size(586, 355);
			this.tab3Manage.Style = MetroFramework.MetroColorStyle.Blue;
			this.tab3Manage.StyleManager = null;
			this.tab3Manage.TabIndex = 2;
			this.tab3Manage.Text = "Administrar";
			this.tab3Manage.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tab3Manage.VerticalScrollbar = false;
			this.tab3Manage.VerticalScrollbarBarColor = true;
			this.tab3Manage.VerticalScrollbarHighlightOnWheel = false;
			this.tab3Manage.VerticalScrollbarSize = 10;
			// 
			// metroButton3
			// 
			this.metroButton3.Highlight = false;
			this.metroButton3.Location = new System.Drawing.Point(508, 81);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(75, 23);
			this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton3.StyleManager = null;
			this.metroButton3.TabIndex = 5;
			this.metroButton3.Text = "metroButton3";
			this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// metroButton2
			// 
			this.metroButton2.Highlight = false;
			this.metroButton2.Location = new System.Drawing.Point(508, 51);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(75, 23);
			this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton2.StyleManager = null;
			this.metroButton2.TabIndex = 4;
			this.metroButton2.Text = "metroButton2";
			this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// metroButton1
			// 
			this.metroButton1.Highlight = false;
			this.metroButton1.Location = new System.Drawing.Point(508, 21);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(75, 23);
			this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton1.StyleManager = null;
			this.metroButton1.TabIndex = 3;
			this.metroButton1.Text = "metroButton1";
			this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 480);
			this.Controls.Add(this.metroTabControl1);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "Form1";
			this.Text = "Veterinaria YEI";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.metroTabControl1.ResumeLayout(false);
			this.tab1Clients.ResumeLayout(false);
			this.tab1Clients.PerformLayout();
			this.tab2Pets.ResumeLayout(false);
			this.tab3Manage.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab1Clients;
        private MetroFramework.Controls.MetroComboBox cmbbox_searchType;
        private MetroFramework.Controls.MetroLabel lbl_search_ID;
        private MetroFramework.Controls.MetroLabel lbl_search_RaceLastName;
        private MetroFramework.Controls.MetroLabel lbl_search_name;
        private MetroFramework.Controls.MetroTextBox txtbox_ID;
        private MetroFramework.Controls.MetroTextBox txtbox_LastNameRace;
        private MetroFramework.Controls.MetroTextBox txtbox_name;
        private MetroFramework.Controls.MetroTabPage tab2Pets;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroTabPage tab3Manage;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

