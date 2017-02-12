namespace WindowsForms
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.tab1Clients = new MetroFramework.Controls.MetroTabPage();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.lbl_infoIdResult = new MetroFramework.Controls.MetroLabel();
			this.lbl_infoRaceLastNameResult = new MetroFramework.Controls.MetroLabel();
			this.lbl_infoNameResult = new MetroFramework.Controls.MetroLabel();
			this.ID = new MetroFramework.Controls.MetroLabel();
			this.lbl_InfoRaceLastName = new MetroFramework.Controls.MetroLabel();
			this.lbl_infoName = new MetroFramework.Controls.MetroLabel();
			this.btn_search = new MetroFramework.Controls.MetroButton();
			this.lvw_PetSearch = new System.Windows.Forms.ListView();
			this.column_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_raza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmbbox_searchType = new MetroFramework.Controls.MetroComboBox();
			this.lbl_search_param = new MetroFramework.Controls.MetroLabel();
			this.txtbox_searchParam = new MetroFramework.Controls.MetroTextBox();
			this.tab2Pets = new MetroFramework.Controls.MetroTabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
			this.lbl_registerSLastName = new MetroFramework.Controls.MetroLabel();
			this.lbl_registerLastName = new MetroFramework.Controls.MetroLabel();
			this.lbl_registerName = new MetroFramework.Controls.MetroLabel();
			this.txtbox_registerSLastName = new MetroFramework.Controls.MetroTextBox();
			this.txtbox_registerLastName = new MetroFramework.Controls.MetroTextBox();
			this.txtbox_registerName = new MetroFramework.Controls.MetroTextBox();
			this.btn_registerOk = new MetroFramework.Controls.MetroButton();
			this.tab3Manage = new MetroFramework.Controls.MetroTabPage();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroTabControl1.SuspendLayout();
			this.tab1Clients.SuspendLayout();
			this.tab2Pets.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tab3Manage.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroStyleManager1
			// 
			this.metroStyleManager1.OwnerForm = null;
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
			this.metroTabControl1.SelectedIndex = 1;
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
			this.tab1Clients.Controls.Add(this.metroComboBox1);
			this.tab1Clients.Controls.Add(this.lbl_infoIdResult);
			this.tab1Clients.Controls.Add(this.lbl_infoRaceLastNameResult);
			this.tab1Clients.Controls.Add(this.lbl_infoNameResult);
			this.tab1Clients.Controls.Add(this.ID);
			this.tab1Clients.Controls.Add(this.lbl_InfoRaceLastName);
			this.tab1Clients.Controls.Add(this.lbl_infoName);
			this.tab1Clients.Controls.Add(this.btn_search);
			this.tab1Clients.Controls.Add(this.lvw_PetSearch);
			this.tab1Clients.Controls.Add(this.cmbbox_searchType);
			this.tab1Clients.Controls.Add(this.lbl_search_param);
			this.tab1Clients.Controls.Add(this.txtbox_searchParam);
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
			// metroComboBox1
			// 
			this.metroComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.metroComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.metroComboBox1.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.metroComboBox1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "ID"});
			this.metroComboBox1.Location = new System.Drawing.Point(4, 59);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(195, 29);
			this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroComboBox1.StyleManager = null;
			this.metroComboBox1.TabIndex = 18;
			this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// lbl_infoIdResult
			// 
			this.lbl_infoIdResult.AutoSize = true;
			this.lbl_infoIdResult.CustomBackground = false;
			this.lbl_infoIdResult.CustomForeColor = false;
			this.lbl_infoIdResult.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_infoIdResult.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_infoIdResult.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_infoIdResult.Location = new System.Drawing.Point(332, 103);
			this.lbl_infoIdResult.Name = "lbl_infoIdResult";
			this.lbl_infoIdResult.Size = new System.Drawing.Size(20, 19);
			this.lbl_infoIdResult.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_infoIdResult.StyleManager = null;
			this.lbl_infoIdResult.TabIndex = 17;
			this.lbl_infoIdResult.Text = "Id";
			this.lbl_infoIdResult.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_infoIdResult.UseStyleColors = false;
			// 
			// lbl_infoRaceLastNameResult
			// 
			this.lbl_infoRaceLastNameResult.AutoSize = true;
			this.lbl_infoRaceLastNameResult.CustomBackground = false;
			this.lbl_infoRaceLastNameResult.CustomForeColor = false;
			this.lbl_infoRaceLastNameResult.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_infoRaceLastNameResult.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_infoRaceLastNameResult.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_infoRaceLastNameResult.Location = new System.Drawing.Point(332, 63);
			this.lbl_infoRaceLastNameResult.Name = "lbl_infoRaceLastNameResult";
			this.lbl_infoRaceLastNameResult.Size = new System.Drawing.Size(95, 19);
			this.lbl_infoRaceLastNameResult.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_infoRaceLastNameResult.StyleManager = null;
			this.lbl_infoRaceLastNameResult.TabIndex = 16;
			this.lbl_infoRaceLastNameResult.Text = "RazaLastName";
			this.lbl_infoRaceLastNameResult.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_infoRaceLastNameResult.UseStyleColors = false;
			// 
			// lbl_infoNameResult
			// 
			this.lbl_infoNameResult.AutoSize = true;
			this.lbl_infoNameResult.CustomBackground = false;
			this.lbl_infoNameResult.CustomForeColor = false;
			this.lbl_infoNameResult.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_infoNameResult.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_infoNameResult.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_infoNameResult.Location = new System.Drawing.Point(332, 22);
			this.lbl_infoNameResult.Name = "lbl_infoNameResult";
			this.lbl_infoNameResult.Size = new System.Drawing.Size(59, 19);
			this.lbl_infoNameResult.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_infoNameResult.StyleManager = null;
			this.lbl_infoNameResult.TabIndex = 15;
			this.lbl_infoNameResult.Text = "Nombre";
			this.lbl_infoNameResult.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_infoNameResult.UseStyleColors = false;
			// 
			// ID
			// 
			this.ID.AutoSize = true;
			this.ID.CustomBackground = false;
			this.ID.CustomForeColor = false;
			this.ID.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.ID.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.ID.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.ID.Location = new System.Drawing.Point(216, 104);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(21, 19);
			this.ID.Style = MetroFramework.MetroColorStyle.Blue;
			this.ID.StyleManager = null;
			this.ID.TabIndex = 14;
			this.ID.Text = "ID";
			this.ID.Theme = MetroFramework.MetroThemeStyle.Light;
			this.ID.UseStyleColors = false;
			// 
			// lbl_InfoRaceLastName
			// 
			this.lbl_InfoRaceLastName.AutoSize = true;
			this.lbl_InfoRaceLastName.CustomBackground = false;
			this.lbl_InfoRaceLastName.CustomForeColor = false;
			this.lbl_InfoRaceLastName.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_InfoRaceLastName.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_InfoRaceLastName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_InfoRaceLastName.Location = new System.Drawing.Point(216, 63);
			this.lbl_InfoRaceLastName.Name = "lbl_InfoRaceLastName";
			this.lbl_InfoRaceLastName.Size = new System.Drawing.Size(37, 19);
			this.lbl_InfoRaceLastName.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_InfoRaceLastName.StyleManager = null;
			this.lbl_InfoRaceLastName.TabIndex = 13;
			this.lbl_InfoRaceLastName.Text = "Raza";
			this.lbl_InfoRaceLastName.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_InfoRaceLastName.UseStyleColors = false;
			// 
			// lbl_infoName
			// 
			this.lbl_infoName.AutoSize = true;
			this.lbl_infoName.CustomBackground = false;
			this.lbl_infoName.CustomForeColor = false;
			this.lbl_infoName.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_infoName.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_infoName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_infoName.Location = new System.Drawing.Point(216, 23);
			this.lbl_infoName.Name = "lbl_infoName";
			this.lbl_infoName.Size = new System.Drawing.Size(59, 19);
			this.lbl_infoName.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_infoName.StyleManager = null;
			this.lbl_infoName.TabIndex = 12;
			this.lbl_infoName.Text = "Nombre";
			this.lbl_infoName.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_infoName.UseStyleColors = false;
			// 
			// btn_search
			// 
			this.btn_search.Highlight = false;
			this.btn_search.Location = new System.Drawing.Point(63, 181);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(75, 23);
			this.btn_search.Style = MetroFramework.MetroColorStyle.Blue;
			this.btn_search.StyleManager = null;
			this.btn_search.TabIndex = 11;
			this.btn_search.Text = "Buscar";
			this.btn_search.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// lvw_PetSearch
			// 
			this.lvw_PetSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_name,
            this.column_raza,
            this.column_ID});
			this.lvw_PetSearch.Location = new System.Drawing.Point(216, 139);
			this.lvw_PetSearch.Name = "lvw_PetSearch";
			this.lvw_PetSearch.Size = new System.Drawing.Size(370, 216);
			this.lvw_PetSearch.TabIndex = 9;
			this.lvw_PetSearch.UseCompatibleStateImageBehavior = false;
			this.lvw_PetSearch.View = System.Windows.Forms.View.Details;
			// 
			// column_name
			// 
			this.column_name.Text = "Name";
			// 
			// column_raza
			// 
			this.column_raza.Text = "Raza";
			// 
			// column_ID
			// 
			this.column_ID.Text = "ID";
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
			// lbl_search_param
			// 
			this.lbl_search_param.AutoSize = true;
			this.lbl_search_param.CustomBackground = false;
			this.lbl_search_param.CustomForeColor = false;
			this.lbl_search_param.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_search_param.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_search_param.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_search_param.Location = new System.Drawing.Point(4, 133);
			this.lbl_search_param.Name = "lbl_search_param";
			this.lbl_search_param.Size = new System.Drawing.Size(21, 19);
			this.lbl_search_param.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_search_param.StyleManager = null;
			this.lbl_search_param.TabIndex = 7;
			this.lbl_search_param.Text = "ID";
			this.lbl_search_param.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_search_param.UseStyleColors = false;
			// 
			// txtbox_searchParam
			// 
			this.txtbox_searchParam.CustomBackground = false;
			this.txtbox_searchParam.CustomForeColor = false;
			this.txtbox_searchParam.FontSize = MetroFramework.MetroTextBoxSize.Small;
			this.txtbox_searchParam.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
			this.txtbox_searchParam.Location = new System.Drawing.Point(4, 152);
			this.txtbox_searchParam.Multiline = false;
			this.txtbox_searchParam.Name = "txtbox_searchParam";
			this.txtbox_searchParam.SelectedText = "";
			this.txtbox_searchParam.Size = new System.Drawing.Size(196, 23);
			this.txtbox_searchParam.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtbox_searchParam.StyleManager = null;
			this.txtbox_searchParam.TabIndex = 4;
			this.txtbox_searchParam.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtbox_searchParam.UseStyleColors = false;
			// 
			// tab2Pets
			// 
			this.tab2Pets.Controls.Add(this.pictureBox1);
			this.tab2Pets.Controls.Add(this.metroLabel3);
			this.tab2Pets.Controls.Add(this.metroLabel2);
			this.tab2Pets.Controls.Add(this.metroTextBox4);
			this.tab2Pets.Controls.Add(this.lbl_registerSLastName);
			this.tab2Pets.Controls.Add(this.lbl_registerLastName);
			this.tab2Pets.Controls.Add(this.lbl_registerName);
			this.tab2Pets.Controls.Add(this.txtbox_registerSLastName);
			this.tab2Pets.Controls.Add(this.txtbox_registerLastName);
			this.tab2Pets.Controls.Add(this.txtbox_registerName);
			this.tab2Pets.Controls.Add(this.btn_registerOk);
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
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(456, 208);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(134, 151);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.CustomBackground = false;
			this.metroLabel3.CustomForeColor = false;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.metroLabel3.Location = new System.Drawing.Point(370, 68);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(77, 25);
			this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel3.StyleManager = null;
			this.metroLabel3.TabIndex = 17;
			this.metroLabel3.Text = "Su ID es:";
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroLabel3.UseStyleColors = false;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.CustomBackground = false;
			this.metroLabel2.CustomForeColor = false;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.metroLabel2.Location = new System.Drawing.Point(357, 32);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(101, 19);
			this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel2.StyleManager = null;
			this.metroLabel2.TabIndex = 16;
			this.metroLabel2.Text = "Usuario Creado";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroLabel2.UseStyleColors = false;
			// 
			// metroTextBox4
			// 
			this.metroTextBox4.CustomBackground = false;
			this.metroTextBox4.CustomForeColor = false;
			this.metroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Tall;
			this.metroTextBox4.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
			this.metroTextBox4.Location = new System.Drawing.Point(342, 96);
			this.metroTextBox4.Multiline = true;
			this.metroTextBox4.Name = "metroTextBox4";
			this.metroTextBox4.SelectedText = "";
			this.metroTextBox4.Size = new System.Drawing.Size(134, 32);
			this.metroTextBox4.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBox4.StyleManager = null;
			this.metroTextBox4.TabIndex = 13;
			this.metroTextBox4.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBox4.UseStyleColors = false;
			// 
			// lbl_registerSLastName
			// 
			this.lbl_registerSLastName.AutoSize = true;
			this.lbl_registerSLastName.CustomBackground = false;
			this.lbl_registerSLastName.CustomForeColor = false;
			this.lbl_registerSLastName.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_registerSLastName.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_registerSLastName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_registerSLastName.Location = new System.Drawing.Point(3, 119);
			this.lbl_registerSLastName.Name = "lbl_registerSLastName";
			this.lbl_registerSLastName.Size = new System.Drawing.Size(112, 19);
			this.lbl_registerSLastName.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_registerSLastName.StyleManager = null;
			this.lbl_registerSLastName.TabIndex = 12;
			this.lbl_registerSLastName.Text = "Apellido Materno";
			this.lbl_registerSLastName.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_registerSLastName.UseStyleColors = false;
			// 
			// lbl_registerLastName
			// 
			this.lbl_registerLastName.AutoSize = true;
			this.lbl_registerLastName.CustomBackground = false;
			this.lbl_registerLastName.CustomForeColor = false;
			this.lbl_registerLastName.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_registerLastName.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_registerLastName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_registerLastName.Location = new System.Drawing.Point(3, 68);
			this.lbl_registerLastName.Name = "lbl_registerLastName";
			this.lbl_registerLastName.Size = new System.Drawing.Size(107, 19);
			this.lbl_registerLastName.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_registerLastName.StyleManager = null;
			this.lbl_registerLastName.TabIndex = 11;
			this.lbl_registerLastName.Text = "Apellido Paterno";
			this.lbl_registerLastName.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_registerLastName.UseStyleColors = false;
			// 
			// lbl_registerName
			// 
			this.lbl_registerName.AutoSize = true;
			this.lbl_registerName.CustomBackground = false;
			this.lbl_registerName.CustomForeColor = false;
			this.lbl_registerName.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lbl_registerName.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lbl_registerName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lbl_registerName.Location = new System.Drawing.Point(3, 20);
			this.lbl_registerName.Name = "lbl_registerName";
			this.lbl_registerName.Size = new System.Drawing.Size(59, 19);
			this.lbl_registerName.Style = MetroFramework.MetroColorStyle.Blue;
			this.lbl_registerName.StyleManager = null;
			this.lbl_registerName.TabIndex = 10;
			this.lbl_registerName.Text = "Nombre";
			this.lbl_registerName.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbl_registerName.UseStyleColors = false;
			// 
			// txtbox_registerSLastName
			// 
			this.txtbox_registerSLastName.CustomBackground = false;
			this.txtbox_registerSLastName.CustomForeColor = false;
			this.txtbox_registerSLastName.FontSize = MetroFramework.MetroTextBoxSize.Small;
			this.txtbox_registerSLastName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
			this.txtbox_registerSLastName.Location = new System.Drawing.Point(4, 141);
			this.txtbox_registerSLastName.Multiline = false;
			this.txtbox_registerSLastName.Name = "txtbox_registerSLastName";
			this.txtbox_registerSLastName.SelectedText = "";
			this.txtbox_registerSLastName.Size = new System.Drawing.Size(179, 23);
			this.txtbox_registerSLastName.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtbox_registerSLastName.StyleManager = null;
			this.txtbox_registerSLastName.TabIndex = 8;
			this.txtbox_registerSLastName.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtbox_registerSLastName.UseStyleColors = false;
			// 
			// txtbox_registerLastName
			// 
			this.txtbox_registerLastName.CustomBackground = false;
			this.txtbox_registerLastName.CustomForeColor = false;
			this.txtbox_registerLastName.FontSize = MetroFramework.MetroTextBoxSize.Small;
			this.txtbox_registerLastName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
			this.txtbox_registerLastName.Location = new System.Drawing.Point(4, 90);
			this.txtbox_registerLastName.Multiline = false;
			this.txtbox_registerLastName.Name = "txtbox_registerLastName";
			this.txtbox_registerLastName.SelectedText = "";
			this.txtbox_registerLastName.Size = new System.Drawing.Size(179, 23);
			this.txtbox_registerLastName.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtbox_registerLastName.StyleManager = null;
			this.txtbox_registerLastName.TabIndex = 7;
			this.txtbox_registerLastName.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtbox_registerLastName.UseStyleColors = false;
			// 
			// txtbox_registerName
			// 
			this.txtbox_registerName.CustomBackground = false;
			this.txtbox_registerName.CustomForeColor = false;
			this.txtbox_registerName.FontSize = MetroFramework.MetroTextBoxSize.Small;
			this.txtbox_registerName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
			this.txtbox_registerName.Location = new System.Drawing.Point(4, 42);
			this.txtbox_registerName.Multiline = false;
			this.txtbox_registerName.Name = "txtbox_registerName";
			this.txtbox_registerName.SelectedText = "";
			this.txtbox_registerName.Size = new System.Drawing.Size(179, 23);
			this.txtbox_registerName.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtbox_registerName.StyleManager = null;
			this.txtbox_registerName.TabIndex = 6;
			this.txtbox_registerName.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtbox_registerName.UseStyleColors = false;
			// 
			// btn_registerOk
			// 
			this.btn_registerOk.Highlight = false;
			this.btn_registerOk.Location = new System.Drawing.Point(58, 170);
			this.btn_registerOk.Name = "btn_registerOk";
			this.btn_registerOk.Size = new System.Drawing.Size(82, 70);
			this.btn_registerOk.Style = MetroFramework.MetroColorStyle.Blue;
			this.btn_registerOk.StyleManager = null;
			this.btn_registerOk.TabIndex = 3;
			this.btn_registerOk.Text = "Registrar";
			this.btn_registerOk.Theme = MetroFramework.MetroThemeStyle.Light;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 480);
			this.Controls.Add(this.metroTabControl1);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "MainForm";
			this.Text = "Veterinaria YEI";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.metroTabControl1.ResumeLayout(false);
			this.tab1Clients.ResumeLayout(false);
			this.tab1Clients.PerformLayout();
			this.tab2Pets.ResumeLayout(false);
			this.tab2Pets.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tab3Manage.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab1Clients;
        private MetroFramework.Controls.MetroComboBox cmbbox_searchType;
        private MetroFramework.Controls.MetroLabel lbl_search_param;
        private MetroFramework.Controls.MetroTextBox txtbox_searchParam;
        private MetroFramework.Controls.MetroTabPage tab2Pets;
        private MetroFramework.Controls.MetroButton btn_registerOk;
        private MetroFramework.Controls.MetroTabPage tab3Manage;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
		private System.Windows.Forms.ListView lvw_PetSearch;
		private System.Windows.Forms.ColumnHeader column_name;
		private System.Windows.Forms.ColumnHeader column_raza;
		private MetroFramework.Controls.MetroButton btn_search;
		private MetroFramework.Controls.MetroLabel lbl_infoIdResult;
		private MetroFramework.Controls.MetroLabel lbl_infoRaceLastNameResult;
		private MetroFramework.Controls.MetroLabel lbl_infoNameResult;
		private MetroFramework.Controls.MetroLabel ID;
		private MetroFramework.Controls.MetroLabel lbl_InfoRaceLastName;
		private MetroFramework.Controls.MetroLabel lbl_infoName;
		private System.Windows.Forms.ColumnHeader column_ID;
		private MetroFramework.Controls.MetroLabel lbl_registerSLastName;
		private MetroFramework.Controls.MetroLabel lbl_registerLastName;
		private MetroFramework.Controls.MetroLabel lbl_registerName;
		private MetroFramework.Controls.MetroTextBox txtbox_registerSLastName;
		private MetroFramework.Controls.MetroTextBox txtbox_registerLastName;
		private MetroFramework.Controls.MetroTextBox txtbox_registerName;
		private MetroFramework.Controls.MetroTextBox metroTextBox4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

