namespace Proiect_PAW
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
            this.cbEntitate = new System.Windows.Forms.ComboBox();
            this.lbEntitate = new System.Windows.Forms.Label();
            this.lbDenumire = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.lbTitlu = new System.Windows.Forms.Label();
            this.lbNrGrupe = new System.Windows.Forms.Label();
            this.cbNrGrupe = new System.Windows.Forms.ComboBox();
            this.pnEntitate = new System.Windows.Forms.Panel();
            this.cbAnStudiu = new System.Windows.Forms.ComboBox();
            this.lbAnStudiu = new System.Windows.Forms.Label();
            this.btnEntitate = new System.Windows.Forms.Button();
            this.lbSubtitlu = new System.Windows.Forms.Label();
            this.cbSerie = new System.Windows.Forms.ComboBox();
            this.lbSerie = new System.Windows.Forms.Label();
            this.pnDisciplina = new System.Windows.Forms.Panel();
            this.lbSubtitluDisciplina = new System.Windows.Forms.Label();
            this.btnDisciplina = new System.Windows.Forms.Button();
            this.cbAnDis = new System.Windows.Forms.ComboBox();
            this.cbNumarCredite = new System.Windows.Forms.ComboBox();
            this.lbAnDis = new System.Windows.Forms.Label();
            this.lbNumarCredite = new System.Windows.Forms.Label();
            this.tbDenumireDis = new System.Windows.Forms.TextBox();
            this.lbDenumireDis = new System.Windows.Forms.Label();
            this.pnProfesor = new System.Windows.Forms.Panel();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.listBoxProfesorDisciplina = new System.Windows.Forms.ListBox();
            this.lbProfesorDisciplina = new System.Windows.Forms.Label();
            this.tbNumeProfesor = new System.Windows.Forms.TextBox();
            this.lbNumeProfesor = new System.Windows.Forms.Label();
            this.lbSubtitluProfesor = new System.Windows.Forms.Label();
            this.pnSala = new System.Windows.Forms.Panel();
            this.btnSala = new System.Windows.Forms.Button();
            this.tbCodSala = new System.Windows.Forms.TextBox();
            this.lbLocuri = new System.Windows.Forms.Label();
            this.tbCladire = new System.Windows.Forms.TextBox();
            this.tbLocuri = new System.Windows.Forms.TextBox();
            this.lbSubtitluSala = new System.Windows.Forms.Label();
            this.lbCodSala = new System.Windows.Forms.Label();
            this.lbCladire = new System.Windows.Forms.Label();
            this.pnActivitate = new System.Windows.Forms.Panel();
            this.cbActInterval = new System.Windows.Forms.ComboBox();
            this.cbActZi = new System.Windows.Forms.ComboBox();
            this.cbActSala = new System.Windows.Forms.ComboBox();
            this.btnActivitate = new System.Windows.Forms.Button();
            this.cbActProfesor = new System.Windows.Forms.ComboBox();
            this.lbSubtitluActivitate = new System.Windows.Forms.Label();
            this.cbActDisciplina = new System.Windows.Forms.ComboBox();
            this.lbActInterval = new System.Windows.Forms.Label();
            this.cbActEntitate = new System.Windows.Forms.ComboBox();
            this.lbActEntitate = new System.Windows.Forms.Label();
            this.lbActZi = new System.Windows.Forms.Label();
            this.lbActDisciplina = new System.Windows.Forms.Label();
            this.lbActSala = new System.Windows.Forms.Label();
            this.lbActProfesor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbOrarEnt = new System.Windows.Forms.ComboBox();
            this.lbOrar = new System.Windows.Forms.Label();
            this.tbLayPnOrar = new System.Windows.Forms.TableLayoutPanel();
            this.lbLuni = new System.Windows.Forms.Label();
            this.lbMarti = new System.Windows.Forms.Label();
            this.lbVineri = new System.Windows.Forms.Label();
            this.lbMiercuri = new System.Windows.Forms.Label();
            this.lbJoi = new System.Windows.Forms.Label();
            this.pnOrar = new System.Windows.Forms.Panel();
            this.pnEntitate.SuspendLayout();
            this.pnDisciplina.SuspendLayout();
            this.pnProfesor.SuspendLayout();
            this.pnSala.SuspendLayout();
            this.pnActivitate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnOrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEntitate
            // 
            this.cbEntitate.FormattingEnabled = true;
            this.cbEntitate.Items.AddRange(new object[] {
            "Serie",
            "Grupa"});
            this.cbEntitate.Location = new System.Drawing.Point(160, 67);
            this.cbEntitate.Name = "cbEntitate";
            this.cbEntitate.Size = new System.Drawing.Size(121, 24);
            this.cbEntitate.TabIndex = 0;
            this.cbEntitate.SelectedIndexChanged += new System.EventHandler(this.cbEntitate_SelectedIndexChanged);
            // 
            // lbEntitate
            // 
            this.lbEntitate.AutoSize = true;
            this.lbEntitate.Location = new System.Drawing.Point(27, 70);
            this.lbEntitate.Name = "lbEntitate";
            this.lbEntitate.Size = new System.Drawing.Size(80, 16);
            this.lbEntitate.TabIndex = 1;
            this.lbEntitate.Text = "Serie/Grupa";
            // 
            // lbDenumire
            // 
            this.lbDenumire.AutoSize = true;
            this.lbDenumire.Location = new System.Drawing.Point(33, 129);
            this.lbDenumire.Name = "lbDenumire";
            this.lbDenumire.Size = new System.Drawing.Size(0, 16);
            this.lbDenumire.TabIndex = 2;
            this.lbDenumire.Visible = false;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(160, 126);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(121, 22);
            this.tbDenumire.TabIndex = 3;
            this.tbDenumire.Visible = false;
            // 
            // lbTitlu
            // 
            this.lbTitlu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitlu.AutoSize = true;
            this.lbTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitlu.Location = new System.Drawing.Point(453, 60);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(106, 36);
            this.lbTitlu.TabIndex = 4;
            this.lbTitlu.Text = "ORAR";
            // 
            // lbNrGrupe
            // 
            this.lbNrGrupe.AutoSize = true;
            this.lbNrGrupe.Location = new System.Drawing.Point(27, 254);
            this.lbNrGrupe.Name = "lbNrGrupe";
            this.lbNrGrupe.Size = new System.Drawing.Size(85, 16);
            this.lbNrGrupe.TabIndex = 5;
            this.lbNrGrupe.Text = "Numar grupe";
            this.lbNrGrupe.Visible = false;
            // 
            // cbNrGrupe
            // 
            this.cbNrGrupe.FormattingEnabled = true;
            this.cbNrGrupe.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbNrGrupe.Location = new System.Drawing.Point(160, 251);
            this.cbNrGrupe.Name = "cbNrGrupe";
            this.cbNrGrupe.Size = new System.Drawing.Size(121, 24);
            this.cbNrGrupe.TabIndex = 6;
            this.cbNrGrupe.Visible = false;
            // 
            // pnEntitate
            // 
            this.pnEntitate.Controls.Add(this.cbAnStudiu);
            this.pnEntitate.Controls.Add(this.cbNrGrupe);
            this.pnEntitate.Controls.Add(this.lbAnStudiu);
            this.pnEntitate.Controls.Add(this.lbDenumire);
            this.pnEntitate.Controls.Add(this.tbDenumire);
            this.pnEntitate.Controls.Add(this.lbEntitate);
            this.pnEntitate.Controls.Add(this.btnEntitate);
            this.pnEntitate.Controls.Add(this.cbEntitate);
            this.pnEntitate.Controls.Add(this.lbNrGrupe);
            this.pnEntitate.Controls.Add(this.lbSubtitlu);
            this.pnEntitate.Controls.Add(this.cbSerie);
            this.pnEntitate.Controls.Add(this.lbSerie);
            this.pnEntitate.Location = new System.Drawing.Point(351, 124);
            this.pnEntitate.Name = "pnEntitate";
            this.pnEntitate.Size = new System.Drawing.Size(317, 371);
            this.pnEntitate.TabIndex = 7;
            this.pnEntitate.Visible = false;
            // 
            // cbAnStudiu
            // 
            this.cbAnStudiu.FormattingEnabled = true;
            this.cbAnStudiu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbAnStudiu.Location = new System.Drawing.Point(160, 190);
            this.cbAnStudiu.Name = "cbAnStudiu";
            this.cbAnStudiu.Size = new System.Drawing.Size(121, 24);
            this.cbAnStudiu.TabIndex = 9;
            this.cbAnStudiu.Visible = false;
            this.cbAnStudiu.SelectedIndexChanged += new System.EventHandler(this.cbAnStudiu_SelectedIndexChanged);
            // 
            // lbAnStudiu
            // 
            this.lbAnStudiu.AutoSize = true;
            this.lbAnStudiu.Location = new System.Drawing.Point(27, 193);
            this.lbAnStudiu.Name = "lbAnStudiu";
            this.lbAnStudiu.Size = new System.Drawing.Size(23, 16);
            this.lbAnStudiu.TabIndex = 8;
            this.lbAnStudiu.Text = "An";
            this.lbAnStudiu.Visible = false;
            // 
            // btnEntitate
            // 
            this.btnEntitate.Location = new System.Drawing.Point(30, 297);
            this.btnEntitate.Name = "btnEntitate";
            this.btnEntitate.Size = new System.Drawing.Size(251, 43);
            this.btnEntitate.TabIndex = 8;
            this.btnEntitate.Text = "button1";
            this.btnEntitate.UseVisualStyleBackColor = true;
            this.btnEntitate.Visible = false;
            this.btnEntitate.Click += new System.EventHandler(this.btnEntitate_Click);
            // 
            // lbSubtitlu
            // 
            this.lbSubtitlu.AutoSize = true;
            this.lbSubtitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitlu.Location = new System.Drawing.Point(73, 15);
            this.lbSubtitlu.Name = "lbSubtitlu";
            this.lbSubtitlu.Size = new System.Drawing.Size(171, 25);
            this.lbSubtitlu.TabIndex = 11;
            this.lbSubtitlu.Text = "Creeaza entitate";
            // 
            // cbSerie
            // 
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.Location = new System.Drawing.Point(160, 251);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(121, 24);
            this.cbSerie.TabIndex = 9;
            this.cbSerie.Visible = false;
            // 
            // lbSerie
            // 
            this.lbSerie.AutoSize = true;
            this.lbSerie.Location = new System.Drawing.Point(27, 254);
            this.lbSerie.Name = "lbSerie";
            this.lbSerie.Size = new System.Drawing.Size(39, 16);
            this.lbSerie.TabIndex = 10;
            this.lbSerie.Text = "Serie";
            this.lbSerie.Visible = false;
            // 
            // pnDisciplina
            // 
            this.pnDisciplina.Controls.Add(this.lbSubtitluDisciplina);
            this.pnDisciplina.Controls.Add(this.btnDisciplina);
            this.pnDisciplina.Controls.Add(this.cbAnDis);
            this.pnDisciplina.Controls.Add(this.cbNumarCredite);
            this.pnDisciplina.Controls.Add(this.lbAnDis);
            this.pnDisciplina.Controls.Add(this.lbNumarCredite);
            this.pnDisciplina.Controls.Add(this.tbDenumireDis);
            this.pnDisciplina.Controls.Add(this.lbDenumireDis);
            this.pnDisciplina.Location = new System.Drawing.Point(357, 124);
            this.pnDisciplina.Name = "pnDisciplina";
            this.pnDisciplina.Size = new System.Drawing.Size(314, 368);
            this.pnDisciplina.TabIndex = 8;
            this.pnDisciplina.Visible = false;
            // 
            // lbSubtitluDisciplina
            // 
            this.lbSubtitluDisciplina.AutoSize = true;
            this.lbSubtitluDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitluDisciplina.Location = new System.Drawing.Point(50, 15);
            this.lbSubtitluDisciplina.Name = "lbSubtitluDisciplina";
            this.lbSubtitluDisciplina.Size = new System.Drawing.Size(190, 25);
            this.lbSubtitluDisciplina.TabIndex = 7;
            this.lbSubtitluDisciplina.Text = "Creeaza disciplina";
            // 
            // btnDisciplina
            // 
            this.btnDisciplina.Location = new System.Drawing.Point(30, 287);
            this.btnDisciplina.Name = "btnDisciplina";
            this.btnDisciplina.Size = new System.Drawing.Size(240, 53);
            this.btnDisciplina.TabIndex = 6;
            this.btnDisciplina.Text = "Creeaza disciplina";
            this.btnDisciplina.UseVisualStyleBackColor = true;
            this.btnDisciplina.Click += new System.EventHandler(this.btnDisciplina_Click);
            // 
            // cbAnDis
            // 
            this.cbAnDis.FormattingEnabled = true;
            this.cbAnDis.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbAnDis.Location = new System.Drawing.Point(144, 193);
            this.cbAnDis.Name = "cbAnDis";
            this.cbAnDis.Size = new System.Drawing.Size(121, 24);
            this.cbAnDis.TabIndex = 5;
            // 
            // cbNumarCredite
            // 
            this.cbNumarCredite.FormattingEnabled = true;
            this.cbNumarCredite.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbNumarCredite.Location = new System.Drawing.Point(144, 134);
            this.cbNumarCredite.Name = "cbNumarCredite";
            this.cbNumarCredite.Size = new System.Drawing.Size(126, 24);
            this.cbNumarCredite.TabIndex = 4;
            // 
            // lbAnDis
            // 
            this.lbAnDis.AutoSize = true;
            this.lbAnDis.Location = new System.Drawing.Point(33, 196);
            this.lbAnDis.Name = "lbAnDis";
            this.lbAnDis.Size = new System.Drawing.Size(23, 16);
            this.lbAnDis.TabIndex = 3;
            this.lbAnDis.Text = "An";
            // 
            // lbNumarCredite
            // 
            this.lbNumarCredite.AutoSize = true;
            this.lbNumarCredite.Location = new System.Drawing.Point(33, 137);
            this.lbNumarCredite.Name = "lbNumarCredite";
            this.lbNumarCredite.Size = new System.Drawing.Size(91, 16);
            this.lbNumarCredite.TabIndex = 2;
            this.lbNumarCredite.Text = "Numar credite";
            // 
            // tbDenumireDis
            // 
            this.tbDenumireDis.Location = new System.Drawing.Point(144, 67);
            this.tbDenumireDis.Name = "tbDenumireDis";
            this.tbDenumireDis.Size = new System.Drawing.Size(126, 22);
            this.tbDenumireDis.TabIndex = 1;
            // 
            // lbDenumireDis
            // 
            this.lbDenumireDis.AutoSize = true;
            this.lbDenumireDis.Location = new System.Drawing.Point(33, 70);
            this.lbDenumireDis.Name = "lbDenumireDis";
            this.lbDenumireDis.Size = new System.Drawing.Size(65, 16);
            this.lbDenumireDis.TabIndex = 0;
            this.lbDenumireDis.Text = "Denumire";
            // 
            // pnProfesor
            // 
            this.pnProfesor.Controls.Add(this.btnProfesor);
            this.pnProfesor.Controls.Add(this.listBoxProfesorDisciplina);
            this.pnProfesor.Controls.Add(this.lbProfesorDisciplina);
            this.pnProfesor.Controls.Add(this.tbNumeProfesor);
            this.pnProfesor.Controls.Add(this.lbNumeProfesor);
            this.pnProfesor.Controls.Add(this.lbSubtitluProfesor);
            this.pnProfesor.Location = new System.Drawing.Point(348, 124);
            this.pnProfesor.Name = "pnProfesor";
            this.pnProfesor.Size = new System.Drawing.Size(329, 371);
            this.pnProfesor.TabIndex = 15;
            this.pnProfesor.Visible = false;
            // 
            // btnProfesor
            // 
            this.btnProfesor.Location = new System.Drawing.Point(31, 284);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(250, 53);
            this.btnProfesor.TabIndex = 16;
            this.btnProfesor.Text = "Creeaza profesor";
            this.btnProfesor.UseVisualStyleBackColor = true;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // listBoxProfesorDisciplina
            // 
            this.listBoxProfesorDisciplina.FormattingEnabled = true;
            this.listBoxProfesorDisciplina.ItemHeight = 16;
            this.listBoxProfesorDisciplina.Location = new System.Drawing.Point(130, 122);
            this.listBoxProfesorDisciplina.Name = "listBoxProfesorDisciplina";
            this.listBoxProfesorDisciplina.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxProfesorDisciplina.Size = new System.Drawing.Size(152, 84);
            this.listBoxProfesorDisciplina.TabIndex = 17;
            // 
            // lbProfesorDisciplina
            // 
            this.lbProfesorDisciplina.AutoSize = true;
            this.lbProfesorDisciplina.Location = new System.Drawing.Point(28, 123);
            this.lbProfesorDisciplina.Name = "lbProfesorDisciplina";
            this.lbProfesorDisciplina.Size = new System.Drawing.Size(66, 16);
            this.lbProfesorDisciplina.TabIndex = 16;
            this.lbProfesorDisciplina.Text = "Discipline";
            // 
            // tbNumeProfesor
            // 
            this.tbNumeProfesor.Location = new System.Drawing.Point(128, 67);
            this.tbNumeProfesor.Name = "tbNumeProfesor";
            this.tbNumeProfesor.Size = new System.Drawing.Size(153, 22);
            this.tbNumeProfesor.TabIndex = 16;
            // 
            // lbNumeProfesor
            // 
            this.lbNumeProfesor.AutoSize = true;
            this.lbNumeProfesor.Location = new System.Drawing.Point(27, 70);
            this.lbNumeProfesor.Name = "lbNumeProfesor";
            this.lbNumeProfesor.Size = new System.Drawing.Size(43, 16);
            this.lbNumeProfesor.TabIndex = 16;
            this.lbNumeProfesor.Text = "Nume";
            // 
            // lbSubtitluProfesor
            // 
            this.lbSubtitluProfesor.AutoSize = true;
            this.lbSubtitluProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitluProfesor.Location = new System.Drawing.Point(68, 17);
            this.lbSubtitluProfesor.Name = "lbSubtitluProfesor";
            this.lbSubtitluProfesor.Size = new System.Drawing.Size(179, 25);
            this.lbSubtitluProfesor.TabIndex = 16;
            this.lbSubtitluProfesor.Text = "Creeaza profesor";
            // 
            // pnSala
            // 
            this.pnSala.Controls.Add(this.btnSala);
            this.pnSala.Controls.Add(this.tbCodSala);
            this.pnSala.Controls.Add(this.lbLocuri);
            this.pnSala.Controls.Add(this.tbCladire);
            this.pnSala.Controls.Add(this.tbLocuri);
            this.pnSala.Controls.Add(this.lbSubtitluSala);
            this.pnSala.Controls.Add(this.lbCodSala);
            this.pnSala.Controls.Add(this.lbCladire);
            this.pnSala.Location = new System.Drawing.Point(351, 124);
            this.pnSala.Name = "pnSala";
            this.pnSala.Size = new System.Drawing.Size(329, 371);
            this.pnSala.TabIndex = 16;
            this.pnSala.Visible = false;
            // 
            // btnSala
            // 
            this.btnSala.Location = new System.Drawing.Point(43, 284);
            this.btnSala.Name = "btnSala";
            this.btnSala.Size = new System.Drawing.Size(239, 53);
            this.btnSala.TabIndex = 17;
            this.btnSala.Text = "Creeaza sala";
            this.btnSala.UseVisualStyleBackColor = true;
            this.btnSala.Click += new System.EventHandler(this.btnSala_Click);
            // 
            // tbCodSala
            // 
            this.tbCodSala.Location = new System.Drawing.Point(163, 123);
            this.tbCodSala.Name = "tbCodSala";
            this.tbCodSala.Size = new System.Drawing.Size(122, 22);
            this.tbCodSala.TabIndex = 19;
            // 
            // lbLocuri
            // 
            this.lbLocuri.AutoSize = true;
            this.lbLocuri.Location = new System.Drawing.Point(46, 175);
            this.lbLocuri.Name = "lbLocuri";
            this.lbLocuri.Size = new System.Drawing.Size(82, 16);
            this.lbLocuri.TabIndex = 19;
            this.lbLocuri.Text = "Numar locuri";
            // 
            // tbCladire
            // 
            this.tbCladire.Location = new System.Drawing.Point(162, 69);
            this.tbCladire.Name = "tbCladire";
            this.tbCladire.Size = new System.Drawing.Size(122, 22);
            this.tbCladire.TabIndex = 17;
            // 
            // tbLocuri
            // 
            this.tbLocuri.Location = new System.Drawing.Point(163, 175);
            this.tbLocuri.Name = "tbLocuri";
            this.tbLocuri.Size = new System.Drawing.Size(122, 22);
            this.tbLocuri.TabIndex = 18;
            // 
            // lbSubtitluSala
            // 
            this.lbSubtitluSala.AutoSize = true;
            this.lbSubtitluSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitluSala.Location = new System.Drawing.Point(86, 15);
            this.lbSubtitluSala.Name = "lbSubtitluSala";
            this.lbSubtitluSala.Size = new System.Drawing.Size(140, 25);
            this.lbSubtitluSala.TabIndex = 17;
            this.lbSubtitluSala.Text = "Creeaza sala";
            // 
            // lbCodSala
            // 
            this.lbCodSala.AutoSize = true;
            this.lbCodSala.Location = new System.Drawing.Point(49, 123);
            this.lbCodSala.Name = "lbCodSala";
            this.lbCodSala.Size = new System.Drawing.Size(32, 16);
            this.lbCodSala.TabIndex = 18;
            this.lbCodSala.Text = "Cod";
            // 
            // lbCladire
            // 
            this.lbCladire.AutoSize = true;
            this.lbCladire.Location = new System.Drawing.Point(49, 70);
            this.lbCladire.Name = "lbCladire";
            this.lbCladire.Size = new System.Drawing.Size(50, 16);
            this.lbCladire.TabIndex = 17;
            this.lbCladire.Text = "Cladire";
            // 
            // pnActivitate
            // 
            this.pnActivitate.Controls.Add(this.cbActInterval);
            this.pnActivitate.Controls.Add(this.cbActZi);
            this.pnActivitate.Controls.Add(this.cbActSala);
            this.pnActivitate.Controls.Add(this.btnActivitate);
            this.pnActivitate.Controls.Add(this.cbActProfesor);
            this.pnActivitate.Controls.Add(this.lbSubtitluActivitate);
            this.pnActivitate.Controls.Add(this.cbActDisciplina);
            this.pnActivitate.Controls.Add(this.lbActInterval);
            this.pnActivitate.Controls.Add(this.cbActEntitate);
            this.pnActivitate.Controls.Add(this.lbActEntitate);
            this.pnActivitate.Controls.Add(this.lbActZi);
            this.pnActivitate.Controls.Add(this.lbActDisciplina);
            this.pnActivitate.Controls.Add(this.lbActSala);
            this.pnActivitate.Controls.Add(this.lbActProfesor);
            this.pnActivitate.Location = new System.Drawing.Point(351, 124);
            this.pnActivitate.Name = "pnActivitate";
            this.pnActivitate.Size = new System.Drawing.Size(323, 418);
            this.pnActivitate.TabIndex = 17;
            this.pnActivitate.Visible = false;
            // 
            // cbActInterval
            // 
            this.cbActInterval.FormattingEnabled = true;
            this.cbActInterval.Location = new System.Drawing.Point(141, 281);
            this.cbActInterval.Name = "cbActInterval";
            this.cbActInterval.Size = new System.Drawing.Size(121, 24);
            this.cbActInterval.TabIndex = 22;
            this.cbActInterval.Visible = false;
            // 
            // cbActZi
            // 
            this.cbActZi.FormattingEnabled = true;
            this.cbActZi.Items.AddRange(new object[] {
            "Luni",
            "Marti",
            "Miercuri",
            "Joi",
            "Vineri"});
            this.cbActZi.Location = new System.Drawing.Point(141, 237);
            this.cbActZi.Name = "cbActZi";
            this.cbActZi.Size = new System.Drawing.Size(121, 24);
            this.cbActZi.TabIndex = 23;
            this.cbActZi.Visible = false;
            // 
            // cbActSala
            // 
            this.cbActSala.FormattingEnabled = true;
            this.cbActSala.Location = new System.Drawing.Point(141, 195);
            this.cbActSala.Name = "cbActSala";
            this.cbActSala.Size = new System.Drawing.Size(121, 24);
            this.cbActSala.TabIndex = 21;
            this.cbActSala.Visible = false;
            this.cbActSala.SelectedIndexChanged += new System.EventHandler(this.cbActSala_SelectedIndexChanged);
            // 
            // btnActivitate
            // 
            this.btnActivitate.Location = new System.Drawing.Point(49, 336);
            this.btnActivitate.Name = "btnActivitate";
            this.btnActivitate.Size = new System.Drawing.Size(213, 53);
            this.btnActivitate.TabIndex = 25;
            this.btnActivitate.Text = "Creeaza activitate";
            this.btnActivitate.UseVisualStyleBackColor = true;
            this.btnActivitate.Click += new System.EventHandler(this.btnActivitate_Click);
            // 
            // cbActProfesor
            // 
            this.cbActProfesor.FormattingEnabled = true;
            this.cbActProfesor.Location = new System.Drawing.Point(141, 152);
            this.cbActProfesor.Name = "cbActProfesor";
            this.cbActProfesor.Size = new System.Drawing.Size(121, 24);
            this.cbActProfesor.TabIndex = 20;
            this.cbActProfesor.Visible = false;
            this.cbActProfesor.SelectedIndexChanged += new System.EventHandler(this.cbActProfesor_SelectedIndexChanged);
            // 
            // lbSubtitluActivitate
            // 
            this.lbSubtitluActivitate.AutoSize = true;
            this.lbSubtitluActivitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitluActivitate.Location = new System.Drawing.Point(62, 15);
            this.lbSubtitluActivitate.Name = "lbSubtitluActivitate";
            this.lbSubtitluActivitate.Size = new System.Drawing.Size(186, 25);
            this.lbSubtitluActivitate.TabIndex = 24;
            this.lbSubtitluActivitate.Text = "Creeaza activitate";
            // 
            // cbActDisciplina
            // 
            this.cbActDisciplina.FormattingEnabled = true;
            this.cbActDisciplina.Location = new System.Drawing.Point(141, 110);
            this.cbActDisciplina.Name = "cbActDisciplina";
            this.cbActDisciplina.Size = new System.Drawing.Size(121, 24);
            this.cbActDisciplina.TabIndex = 19;
            this.cbActDisciplina.Visible = false;
            this.cbActDisciplina.SelectedIndexChanged += new System.EventHandler(this.cbActDisciplina_SelectedIndexChanged);
            // 
            // lbActInterval
            // 
            this.lbActInterval.AutoSize = true;
            this.lbActInterval.Location = new System.Drawing.Point(46, 284);
            this.lbActInterval.Name = "lbActInterval";
            this.lbActInterval.Size = new System.Drawing.Size(50, 16);
            this.lbActInterval.TabIndex = 23;
            this.lbActInterval.Text = "Interval";
            this.lbActInterval.Visible = false;
            // 
            // cbActEntitate
            // 
            this.cbActEntitate.FormattingEnabled = true;
            this.cbActEntitate.Location = new System.Drawing.Point(141, 66);
            this.cbActEntitate.Name = "cbActEntitate";
            this.cbActEntitate.Size = new System.Drawing.Size(121, 24);
            this.cbActEntitate.TabIndex = 18;
            this.cbActEntitate.SelectedIndexChanged += new System.EventHandler(this.cbActEntitate_SelectedIndexChanged);
            // 
            // lbActEntitate
            // 
            this.lbActEntitate.AutoSize = true;
            this.lbActEntitate.Location = new System.Drawing.Point(46, 69);
            this.lbActEntitate.Name = "lbActEntitate";
            this.lbActEntitate.Size = new System.Drawing.Size(51, 16);
            this.lbActEntitate.TabIndex = 18;
            this.lbActEntitate.Text = "Entitate";
            // 
            // lbActZi
            // 
            this.lbActZi.AutoSize = true;
            this.lbActZi.Location = new System.Drawing.Point(46, 237);
            this.lbActZi.Name = "lbActZi";
            this.lbActZi.Size = new System.Drawing.Size(18, 16);
            this.lbActZi.TabIndex = 22;
            this.lbActZi.Text = "Zi";
            this.lbActZi.Visible = false;
            // 
            // lbActDisciplina
            // 
            this.lbActDisciplina.AutoSize = true;
            this.lbActDisciplina.Location = new System.Drawing.Point(46, 110);
            this.lbActDisciplina.Name = "lbActDisciplina";
            this.lbActDisciplina.Size = new System.Drawing.Size(66, 16);
            this.lbActDisciplina.TabIndex = 19;
            this.lbActDisciplina.Text = "Disciplina";
            this.lbActDisciplina.Visible = false;
            // 
            // lbActSala
            // 
            this.lbActSala.AutoSize = true;
            this.lbActSala.Location = new System.Drawing.Point(46, 198);
            this.lbActSala.Name = "lbActSala";
            this.lbActSala.Size = new System.Drawing.Size(35, 16);
            this.lbActSala.TabIndex = 21;
            this.lbActSala.Text = "Sala";
            this.lbActSala.Visible = false;
            // 
            // lbActProfesor
            // 
            this.lbActProfesor.AutoSize = true;
            this.lbActProfesor.Location = new System.Drawing.Point(46, 155);
            this.lbActProfesor.Name = "lbActProfesor";
            this.lbActProfesor.Size = new System.Drawing.Size(58, 16);
            this.lbActProfesor.TabIndex = 20;
            this.lbActProfesor.Text = "Profesor";
            this.lbActProfesor.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinaToolStripMenuItem,
            this.profesorToolStripMenuItem,
            this.entitateToolStripMenuItem,
            this.salaToolStripMenuItem,
            this.activitateToolStripMenuItem,
            this.orarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.disciplinaToolStripMenuItem.Text = "Disciplina";
            this.disciplinaToolStripMenuItem.Click += new System.EventHandler(this.disciplinaToolStripMenuItem_Click);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.profesorToolStripMenuItem.Text = "Profesor";
            this.profesorToolStripMenuItem.Click += new System.EventHandler(this.profesorToolStripMenuItem_Click);
            // 
            // entitateToolStripMenuItem
            // 
            this.entitateToolStripMenuItem.Name = "entitateToolStripMenuItem";
            this.entitateToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.entitateToolStripMenuItem.Text = "Entitate";
            this.entitateToolStripMenuItem.Click += new System.EventHandler(this.entitateToolStripMenuItem_Click);
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.salaToolStripMenuItem.Text = "Sala";
            this.salaToolStripMenuItem.Click += new System.EventHandler(this.salaToolStripMenuItem_Click);
            // 
            // activitateToolStripMenuItem
            // 
            this.activitateToolStripMenuItem.Name = "activitateToolStripMenuItem";
            this.activitateToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.activitateToolStripMenuItem.Text = "Activitate";
            this.activitateToolStripMenuItem.Click += new System.EventHandler(this.activitateToolStripMenuItem_Click);
            // 
            // orarToolStripMenuItem
            // 
            this.orarToolStripMenuItem.Name = "orarToolStripMenuItem";
            this.orarToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.orarToolStripMenuItem.Text = "Orar";
            this.orarToolStripMenuItem.Click += new System.EventHandler(this.orarToolStripMenuItem_Click);
            // 
            // cbOrarEnt
            // 
            this.cbOrarEnt.FormattingEnabled = true;
            this.cbOrarEnt.Location = new System.Drawing.Point(169, 26);
            this.cbOrarEnt.Name = "cbOrarEnt";
            this.cbOrarEnt.Size = new System.Drawing.Size(121, 24);
            this.cbOrarEnt.TabIndex = 20;
            this.cbOrarEnt.SelectedIndexChanged += new System.EventHandler(this.cbOrarEnt_SelectedIndexChanged);
            // 
            // lbOrar
            // 
            this.lbOrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOrar.AutoSize = true;
            this.lbOrar.Location = new System.Drawing.Point(33, 29);
            this.lbOrar.Name = "lbOrar";
            this.lbOrar.Size = new System.Drawing.Size(109, 16);
            this.lbOrar.TabIndex = 20;
            this.lbOrar.Text = "Vizualizeaza orar";
            // 
            // tbLayPnOrar
            // 
            this.tbLayPnOrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLayPnOrar.ColumnCount = 5;
            this.tbLayPnOrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayPnOrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayPnOrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayPnOrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayPnOrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayPnOrar.Location = new System.Drawing.Point(36, 110);
            this.tbLayPnOrar.Name = "tbLayPnOrar";
            this.tbLayPnOrar.RowCount = 7;
            this.tbLayPnOrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayPnOrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayPnOrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayPnOrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayPnOrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayPnOrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayPnOrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayPnOrar.Size = new System.Drawing.Size(929, 324);
            this.tbLayPnOrar.TabIndex = 21;
            // 
            // lbLuni
            // 
            this.lbLuni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLuni.AutoSize = true;
            this.lbLuni.Location = new System.Drawing.Point(111, 75);
            this.lbLuni.Name = "lbLuni";
            this.lbLuni.Size = new System.Drawing.Size(31, 16);
            this.lbLuni.TabIndex = 22;
            this.lbLuni.Text = "Luni";
            // 
            // lbMarti
            // 
            this.lbMarti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMarti.AutoSize = true;
            this.lbMarti.Location = new System.Drawing.Point(294, 75);
            this.lbMarti.Name = "lbMarti";
            this.lbMarti.Size = new System.Drawing.Size(36, 16);
            this.lbMarti.TabIndex = 23;
            this.lbMarti.Text = "Marti";
            // 
            // lbVineri
            // 
            this.lbVineri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVineri.AutoSize = true;
            this.lbVineri.Location = new System.Drawing.Point(847, 75);
            this.lbVineri.Name = "lbVineri";
            this.lbVineri.Size = new System.Drawing.Size(41, 16);
            this.lbVineri.TabIndex = 26;
            this.lbVineri.Text = "Vineri";
            // 
            // lbMiercuri
            // 
            this.lbMiercuri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMiercuri.AutoSize = true;
            this.lbMiercuri.Location = new System.Drawing.Point(477, 75);
            this.lbMiercuri.Name = "lbMiercuri";
            this.lbMiercuri.Size = new System.Drawing.Size(54, 16);
            this.lbMiercuri.TabIndex = 24;
            this.lbMiercuri.Text = "Miercuri";
            // 
            // lbJoi
            // 
            this.lbJoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJoi.AutoSize = true;
            this.lbJoi.Location = new System.Drawing.Point(662, 75);
            this.lbJoi.Name = "lbJoi";
            this.lbJoi.Size = new System.Drawing.Size(25, 16);
            this.lbJoi.TabIndex = 25;
            this.lbJoi.Text = "Joi";
            // 
            // pnOrar
            // 
            this.pnOrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnOrar.Controls.Add(this.lbLuni);
            this.pnOrar.Controls.Add(this.lbVineri);
            this.pnOrar.Controls.Add(this.lbMarti);
            this.pnOrar.Controls.Add(this.lbJoi);
            this.pnOrar.Controls.Add(this.lbMiercuri);
            this.pnOrar.Controls.Add(this.tbLayPnOrar);
            this.pnOrar.Controls.Add(this.lbOrar);
            this.pnOrar.Controls.Add(this.cbOrarEnt);
            this.pnOrar.Location = new System.Drawing.Point(12, 124);
            this.pnOrar.Name = "pnOrar";
            this.pnOrar.Size = new System.Drawing.Size(1009, 446);
            this.pnOrar.TabIndex = 19;
            this.pnOrar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 631);
            this.Controls.Add(this.pnOrar);
            this.Controls.Add(this.pnSala);
            this.Controls.Add(this.pnActivitate);
            this.Controls.Add(this.pnProfesor);
            this.Controls.Add(this.pnEntitate);
            this.Controls.Add(this.pnDisciplina);
            this.Controls.Add(this.lbTitlu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.pnEntitate.ResumeLayout(false);
            this.pnEntitate.PerformLayout();
            this.pnDisciplina.ResumeLayout(false);
            this.pnDisciplina.PerformLayout();
            this.pnProfesor.ResumeLayout(false);
            this.pnProfesor.PerformLayout();
            this.pnSala.ResumeLayout(false);
            this.pnSala.PerformLayout();
            this.pnActivitate.ResumeLayout(false);
            this.pnActivitate.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnOrar.ResumeLayout(false);
            this.pnOrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEntitate;
        private System.Windows.Forms.Label lbEntitate;
        private System.Windows.Forms.Label lbDenumire;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label lbTitlu;
        private System.Windows.Forms.Label lbNrGrupe;
        private System.Windows.Forms.ComboBox cbNrGrupe;
        private System.Windows.Forms.Panel pnEntitate;
        private System.Windows.Forms.Button btnEntitate;
        private System.Windows.Forms.ComboBox cbSerie;
        private System.Windows.Forms.Label lbSerie;
        private System.Windows.Forms.Label lbSubtitlu;
        private System.Windows.Forms.ComboBox cbAnStudiu;
        private System.Windows.Forms.Label lbAnStudiu;
        private System.Windows.Forms.Panel pnDisciplina;
        private System.Windows.Forms.Label lbSubtitluDisciplina;
        private System.Windows.Forms.Button btnDisciplina;
        private System.Windows.Forms.ComboBox cbAnDis;
        private System.Windows.Forms.ComboBox cbNumarCredite;
        private System.Windows.Forms.Label lbAnDis;
        private System.Windows.Forms.Label lbNumarCredite;
        private System.Windows.Forms.TextBox tbDenumireDis;
        private System.Windows.Forms.Label lbDenumireDis;
        private System.Windows.Forms.Panel pnProfesor;
        private System.Windows.Forms.Label lbSubtitluProfesor;
        private System.Windows.Forms.TextBox tbNumeProfesor;
        private System.Windows.Forms.Label lbNumeProfesor;
        private System.Windows.Forms.Label lbProfesorDisciplina;
        private System.Windows.Forms.ListBox listBoxProfesorDisciplina;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Panel pnSala;
        private System.Windows.Forms.Label lbSubtitluSala;
        private System.Windows.Forms.Label lbLocuri;
        private System.Windows.Forms.TextBox tbCladire;
        private System.Windows.Forms.TextBox tbLocuri;
        private System.Windows.Forms.Label lbCodSala;
        private System.Windows.Forms.Label lbCladire;
        private System.Windows.Forms.TextBox tbCodSala;
        private System.Windows.Forms.Button btnSala;
        private System.Windows.Forms.Panel pnActivitate;
        private System.Windows.Forms.Label lbActEntitate;
        private System.Windows.Forms.Label lbActDisciplina;
        private System.Windows.Forms.Label lbActProfesor;
        private System.Windows.Forms.Label lbActSala;
        private System.Windows.Forms.Label lbActZi;
        private System.Windows.Forms.Label lbActInterval;
        private System.Windows.Forms.ComboBox cbActInterval;
        private System.Windows.Forms.ComboBox cbActZi;
        private System.Windows.Forms.ComboBox cbActSala;
        private System.Windows.Forms.Button btnActivitate;
        private System.Windows.Forms.ComboBox cbActProfesor;
        private System.Windows.Forms.Label lbSubtitluActivitate;
        private System.Windows.Forms.ComboBox cbActDisciplina;
        private System.Windows.Forms.ComboBox cbActEntitate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbOrarEnt;
        private System.Windows.Forms.Label lbOrar;
        private System.Windows.Forms.TableLayoutPanel tbLayPnOrar;
        private System.Windows.Forms.Panel pnOrar;
        private System.Windows.Forms.Label lbLuni;
        private System.Windows.Forms.Label lbMarti;
        private System.Windows.Forms.Label lbVineri;
        private System.Windows.Forms.Label lbMiercuri;
        private System.Windows.Forms.Label lbJoi;
    }
}

