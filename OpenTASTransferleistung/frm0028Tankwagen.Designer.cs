namespace OpenTASTransferleistung
{
    partial class frm0028Tankwagen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.neuePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zurücksetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.SmartEdit = new System.Windows.Forms.TabPage();
            this.AllgDaten = new System.Windows.Forms.TabPage();
            this.TechnischeDaten = new System.Windows.Forms.TabPage();
            this.Gefahrgutangaben = new System.Windows.Forms.TabPage();
            this.Beladedaten = new System.Windows.Forms.TabPage();
            this.gbBeladedatenAllgemein = new System.Windows.Forms.GroupBox();
            this.lRauminhalt = new System.Windows.Forms.Label();
            this.lMaxGesGewicht = new System.Windows.Forms.Label();
            this.tbRauminhalt = new System.Windows.Forms.TextBox();
            this.tbMaxGesGewicht = new System.Windows.Forms.TextBox();
            this.lLeergewicht = new System.Windows.Forms.Label();
            this.lPrüfdruck = new System.Windows.Forms.Label();
            this.tbPrüfdruck = new System.Windows.Forms.TextBox();
            this.tbLeergewicht = new System.Windows.Forms.TextBox();
            this.tbProduktartLong = new System.Windows.Forms.TextBox();
            this.tbBeladeartLong = new System.Windows.Forms.TextBox();
            this.tbProduktartShort = new System.Windows.Forms.TextBox();
            this.lProduktart = new System.Windows.Forms.Label();
            this.lBeladeart = new System.Windows.Forms.Label();
            this.tbBeladeartShort = new System.Windows.Forms.TextBox();
            this.gbKammern = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colKammer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRauminhalt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriorität = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colADAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sortenzuordnung = new System.Windows.Forms.TabPage();
            this.Fahrerzuordnung = new System.Windows.Forms.TabPage();
            this.Versandbereich = new System.Windows.Forms.TabPage();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lTransporteinheitstyp = new System.Windows.Forms.Label();
            this.tbTransporteinheitstypLong = new System.Windows.Forms.TextBox();
            this.tbTransporteinheitstypShort = new System.Windows.Forms.TextBox();
            this.tbFahrzeugkennzeichen = new System.Windows.Forms.TextBox();
            this.lFahrzeugkennzeichen = new System.Windows.Forms.Label();
            this.pDB = new System.Windows.Forms.Panel();
            this.lSPK = new System.Windows.Forms.Label();
            this.lUSR = new System.Windows.Forms.Label();
            this.tbSPK = new System.Windows.Forms.TextBox();
            this.tbUSR = new System.Windows.Forms.TextBox();
            this.tbADAT = new System.Windows.Forms.TextBox();
            this.lADAT = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Beladedaten.SuspendLayout();
            this.gbBeladedatenAllgemein.SuspendLayout();
            this.gbKammern.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pHeader.SuspendLayout();
            this.pDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuePositionToolStripMenuItem,
            this.validierenToolStripMenuItem,
            this.zurücksetzenToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // neuePositionToolStripMenuItem
            // 
            this.neuePositionToolStripMenuItem.Name = "neuePositionToolStripMenuItem";
            this.neuePositionToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.neuePositionToolStripMenuItem.Text = "Neue Position";
            this.neuePositionToolStripMenuItem.Click += new System.EventHandler(this.neuePositionToolStripMenuItem_Click);
            // 
            // validierenToolStripMenuItem
            // 
            this.validierenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.cToolStripMenuItem});
            this.validierenToolStripMenuItem.Name = "validierenToolStripMenuItem";
            this.validierenToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.validierenToolStripMenuItem.Text = "Validieren";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.fToolStripMenuItem.Text = "F#";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.cToolStripMenuItem.Text = "C#";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // zurücksetzenToolStripMenuItem
            // 
            this.zurücksetzenToolStripMenuItem.Name = "zurücksetzenToolStripMenuItem";
            this.zurücksetzenToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.zurücksetzenToolStripMenuItem.Text = "Zurücksetzen";
            this.zurücksetzenToolStripMenuItem.Click += new System.EventHandler(this.zurücksetzenToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.SmartEdit);
            this.tabControl.Controls.Add(this.AllgDaten);
            this.tabControl.Controls.Add(this.TechnischeDaten);
            this.tabControl.Controls.Add(this.Gefahrgutangaben);
            this.tabControl.Controls.Add(this.Beladedaten);
            this.tabControl.Controls.Add(this.Sortenzuordnung);
            this.tabControl.Controls.Add(this.Fahrerzuordnung);
            this.tabControl.Controls.Add(this.Versandbereich);
            this.tabControl.Location = new System.Drawing.Point(16, 96);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(768, 344);
            this.tabControl.TabIndex = 2;
            // 
            // SmartEdit
            // 
            this.SmartEdit.BackColor = System.Drawing.SystemColors.Control;
            this.SmartEdit.Location = new System.Drawing.Point(4, 22);
            this.SmartEdit.Name = "SmartEdit";
            this.SmartEdit.Padding = new System.Windows.Forms.Padding(3);
            this.SmartEdit.Size = new System.Drawing.Size(760, 318);
            this.SmartEdit.TabIndex = 0;
            this.SmartEdit.Text = "SmartEdit";
            // 
            // AllgDaten
            // 
            this.AllgDaten.BackColor = System.Drawing.SystemColors.Control;
            this.AllgDaten.Location = new System.Drawing.Point(4, 22);
            this.AllgDaten.Name = "AllgDaten";
            this.AllgDaten.Padding = new System.Windows.Forms.Padding(3);
            this.AllgDaten.Size = new System.Drawing.Size(760, 318);
            this.AllgDaten.TabIndex = 1;
            this.AllgDaten.Text = "Allg. Daten";
            // 
            // TechnischeDaten
            // 
            this.TechnischeDaten.BackColor = System.Drawing.SystemColors.Control;
            this.TechnischeDaten.Location = new System.Drawing.Point(4, 22);
            this.TechnischeDaten.Name = "TechnischeDaten";
            this.TechnischeDaten.Size = new System.Drawing.Size(760, 318);
            this.TechnischeDaten.TabIndex = 2;
            this.TechnischeDaten.Text = "Technische Daten";
            // 
            // Gefahrgutangaben
            // 
            this.Gefahrgutangaben.BackColor = System.Drawing.SystemColors.Control;
            this.Gefahrgutangaben.Location = new System.Drawing.Point(4, 22);
            this.Gefahrgutangaben.Name = "Gefahrgutangaben";
            this.Gefahrgutangaben.Size = new System.Drawing.Size(760, 318);
            this.Gefahrgutangaben.TabIndex = 3;
            this.Gefahrgutangaben.Text = "Gefahrgutangaben";
            // 
            // Beladedaten
            // 
            this.Beladedaten.BackColor = System.Drawing.SystemColors.Control;
            this.Beladedaten.Controls.Add(this.gbBeladedatenAllgemein);
            this.Beladedaten.Controls.Add(this.gbKammern);
            this.Beladedaten.Location = new System.Drawing.Point(4, 22);
            this.Beladedaten.Name = "Beladedaten";
            this.Beladedaten.Size = new System.Drawing.Size(760, 318);
            this.Beladedaten.TabIndex = 4;
            this.Beladedaten.Text = "Beladedaten";
            // 
            // gbBeladedatenAllgemein
            // 
            this.gbBeladedatenAllgemein.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBeladedatenAllgemein.Controls.Add(this.lRauminhalt);
            this.gbBeladedatenAllgemein.Controls.Add(this.lMaxGesGewicht);
            this.gbBeladedatenAllgemein.Controls.Add(this.tbRauminhalt);
            this.gbBeladedatenAllgemein.Controls.Add(this.tbMaxGesGewicht);
            this.gbBeladedatenAllgemein.Controls.Add(this.lLeergewicht);
            this.gbBeladedatenAllgemein.Controls.Add(this.lPrüfdruck);
            this.gbBeladedatenAllgemein.Controls.Add(this.tbPrüfdruck);
            this.gbBeladedatenAllgemein.Controls.Add(this.tbLeergewicht);
            this.gbBeladedatenAllgemein.Controls.Add(this.tbProduktartLong);
            this.gbBeladedatenAllgemein.Controls.Add(this.tbBeladeartLong);
            this.gbBeladedatenAllgemein.Controls.Add(this.tbProduktartShort);
            this.gbBeladedatenAllgemein.Controls.Add(this.lProduktart);
            this.gbBeladedatenAllgemein.Controls.Add(this.lBeladeart);
            this.gbBeladedatenAllgemein.Controls.Add(this.tbBeladeartShort);
            this.gbBeladedatenAllgemein.Location = new System.Drawing.Point(16, 8);
            this.gbBeladedatenAllgemein.Name = "gbBeladedatenAllgemein";
            this.gbBeladedatenAllgemein.Size = new System.Drawing.Size(728, 116);
            this.gbBeladedatenAllgemein.TabIndex = 0;
            this.gbBeladedatenAllgemein.TabStop = false;
            // 
            // lRauminhalt
            // 
            this.lRauminhalt.Location = new System.Drawing.Point(473, 8);
            this.lRauminhalt.Name = "lRauminhalt";
            this.lRauminhalt.Size = new System.Drawing.Size(99, 24);
            this.lRauminhalt.TabIndex = 11;
            this.lRauminhalt.Text = "Rauminhalt (l)";
            this.lRauminhalt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lMaxGesGewicht
            // 
            this.lMaxGesGewicht.Location = new System.Drawing.Point(337, 8);
            this.lMaxGesGewicht.Name = "lMaxGesGewicht";
            this.lMaxGesGewicht.Size = new System.Drawing.Size(120, 24);
            this.lMaxGesGewicht.TabIndex = 10;
            this.lMaxGesGewicht.Text = "max. ges. Gewicht (kg)";
            this.lMaxGesGewicht.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbRauminhalt
            // 
            this.tbRauminhalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRauminhalt.Location = new System.Drawing.Point(476, 32);
            this.tbRauminhalt.Name = "tbRauminhalt";
            this.tbRauminhalt.ReadOnly = true;
            this.tbRauminhalt.Size = new System.Drawing.Size(96, 24);
            this.tbRauminhalt.TabIndex = 3;
            // 
            // tbMaxGesGewicht
            // 
            this.tbMaxGesGewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxGesGewicht.Location = new System.Drawing.Point(340, 32);
            this.tbMaxGesGewicht.Name = "tbMaxGesGewicht";
            this.tbMaxGesGewicht.Size = new System.Drawing.Size(120, 24);
            this.tbMaxGesGewicht.TabIndex = 2;
            // 
            // lLeergewicht
            // 
            this.lLeergewicht.Location = new System.Drawing.Point(201, 8);
            this.lLeergewicht.Name = "lLeergewicht";
            this.lLeergewicht.Size = new System.Drawing.Size(120, 24);
            this.lLeergewicht.TabIndex = 9;
            this.lLeergewicht.Text = "Leergewicht (kg)";
            this.lLeergewicht.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lPrüfdruck
            // 
            this.lPrüfdruck.Location = new System.Drawing.Point(201, 56);
            this.lPrüfdruck.Name = "lPrüfdruck";
            this.lPrüfdruck.Size = new System.Drawing.Size(120, 24);
            this.lPrüfdruck.TabIndex = 13;
            this.lPrüfdruck.Text = "Prüfdruck (MPa)";
            this.lPrüfdruck.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbPrüfdruck
            // 
            this.tbPrüfdruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrüfdruck.Location = new System.Drawing.Point(204, 80);
            this.tbPrüfdruck.Name = "tbPrüfdruck";
            this.tbPrüfdruck.Size = new System.Drawing.Size(120, 24);
            this.tbPrüfdruck.TabIndex = 5;
            // 
            // tbLeergewicht
            // 
            this.tbLeergewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLeergewicht.Location = new System.Drawing.Point(204, 32);
            this.tbLeergewicht.Name = "tbLeergewicht";
            this.tbLeergewicht.Size = new System.Drawing.Size(120, 24);
            this.tbLeergewicht.TabIndex = 1;
            // 
            // tbProduktartLong
            // 
            this.tbProduktartLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduktartLong.Location = new System.Drawing.Point(68, 80);
            this.tbProduktartLong.Name = "tbProduktartLong";
            this.tbProduktartLong.ReadOnly = true;
            this.tbProduktartLong.Size = new System.Drawing.Size(120, 24);
            this.tbProduktartLong.TabIndex = 7;
            // 
            // tbBeladeartLong
            // 
            this.tbBeladeartLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeladeartLong.Location = new System.Drawing.Point(68, 32);
            this.tbBeladeartLong.Name = "tbBeladeartLong";
            this.tbBeladeartLong.ReadOnly = true;
            this.tbBeladeartLong.Size = new System.Drawing.Size(120, 24);
            this.tbBeladeartLong.TabIndex = 6;
            // 
            // tbProduktartShort
            // 
            this.tbProduktartShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduktartShort.Location = new System.Drawing.Point(16, 80);
            this.tbProduktartShort.Name = "tbProduktartShort";
            this.tbProduktartShort.Size = new System.Drawing.Size(44, 24);
            this.tbProduktartShort.TabIndex = 4;
            // 
            // lProduktart
            // 
            this.lProduktart.Location = new System.Drawing.Point(11, 56);
            this.lProduktart.Name = "lProduktart";
            this.lProduktart.Size = new System.Drawing.Size(177, 24);
            this.lProduktart.TabIndex = 12;
            this.lProduktart.Text = "Produktart";
            this.lProduktart.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lBeladeart
            // 
            this.lBeladeart.Location = new System.Drawing.Point(11, 8);
            this.lBeladeart.Name = "lBeladeart";
            this.lBeladeart.Size = new System.Drawing.Size(177, 24);
            this.lBeladeart.TabIndex = 8;
            this.lBeladeart.Text = "Beladeart";
            this.lBeladeart.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbBeladeartShort
            // 
            this.tbBeladeartShort.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBeladeartShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeladeartShort.Location = new System.Drawing.Point(16, 32);
            this.tbBeladeartShort.MaxLength = 1;
            this.tbBeladeartShort.Name = "tbBeladeartShort";
            this.tbBeladeartShort.Size = new System.Drawing.Size(44, 24);
            this.tbBeladeartShort.TabIndex = 0;
            // 
            // gbKammern
            // 
            this.gbKammern.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKammern.Controls.Add(this.dataGridView);
            this.gbKammern.Location = new System.Drawing.Point(16, 132);
            this.gbKammern.Name = "gbKammern";
            this.gbKammern.Size = new System.Drawing.Size(728, 170);
            this.gbKammern.TabIndex = 1;
            this.gbKammern.TabStop = false;
            this.gbKammern.Text = "Kammern";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeight = 24;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKammer,
            this.colRauminhalt,
            this.colPriorität,
            this.colADAT,
            this.colUSR,
            this.colSPK});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(16, 24);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(698, 134);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Leave += new System.EventHandler(this.dataGridView_Leave);
            // 
            // colKammer
            // 
            this.colKammer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colKammer.HeaderText = "Kammer";
            this.colKammer.Name = "colKammer";
            this.colKammer.Width = 70;
            // 
            // colRauminhalt
            // 
            this.colRauminhalt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRauminhalt.HeaderText = "Rauminhalt (l)";
            this.colRauminhalt.Name = "colRauminhalt";
            this.colRauminhalt.Width = 96;
            // 
            // colPriorität
            // 
            this.colPriorität.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPriorität.HeaderText = "Priorität";
            this.colPriorität.Name = "colPriorität";
            this.colPriorität.Width = 67;
            // 
            // colADAT
            // 
            this.colADAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colADAT.HeaderText = "Letzte Änd. am";
            this.colADAT.Name = "colADAT";
            this.colADAT.ReadOnly = true;
            this.colADAT.Width = 103;
            // 
            // colUSR
            // 
            this.colUSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUSR.HeaderText = "Letzte Änd. von";
            this.colUSR.Name = "colUSR";
            this.colUSR.ReadOnly = true;
            this.colUSR.Width = 107;
            // 
            // colSPK
            // 
            this.colSPK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSPK.HeaderText = "SPK";
            this.colSPK.Name = "colSPK";
            this.colSPK.ReadOnly = true;
            // 
            // Sortenzuordnung
            // 
            this.Sortenzuordnung.BackColor = System.Drawing.SystemColors.Control;
            this.Sortenzuordnung.Location = new System.Drawing.Point(4, 22);
            this.Sortenzuordnung.Name = "Sortenzuordnung";
            this.Sortenzuordnung.Size = new System.Drawing.Size(760, 318);
            this.Sortenzuordnung.TabIndex = 5;
            this.Sortenzuordnung.Text = "Sortenzuordnung";
            // 
            // Fahrerzuordnung
            // 
            this.Fahrerzuordnung.BackColor = System.Drawing.SystemColors.Control;
            this.Fahrerzuordnung.Location = new System.Drawing.Point(4, 22);
            this.Fahrerzuordnung.Name = "Fahrerzuordnung";
            this.Fahrerzuordnung.Size = new System.Drawing.Size(760, 318);
            this.Fahrerzuordnung.TabIndex = 6;
            this.Fahrerzuordnung.Text = "Fahrerzuordnung";
            // 
            // Versandbereich
            // 
            this.Versandbereich.BackColor = System.Drawing.SystemColors.Control;
            this.Versandbereich.Location = new System.Drawing.Point(4, 22);
            this.Versandbereich.Name = "Versandbereich";
            this.Versandbereich.Size = new System.Drawing.Size(760, 318);
            this.Versandbereich.TabIndex = 7;
            this.Versandbereich.Text = "Versandbereich";
            // 
            // pHeader
            // 
            this.pHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHeader.Controls.Add(this.lTransporteinheitstyp);
            this.pHeader.Controls.Add(this.tbTransporteinheitstypLong);
            this.pHeader.Controls.Add(this.tbTransporteinheitstypShort);
            this.pHeader.Controls.Add(this.tbFahrzeugkennzeichen);
            this.pHeader.Controls.Add(this.lFahrzeugkennzeichen);
            this.pHeader.Location = new System.Drawing.Point(0, 32);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(800, 48);
            this.pHeader.TabIndex = 1;
            // 
            // lTransporteinheitstyp
            // 
            this.lTransporteinheitstyp.Location = new System.Drawing.Point(149, 0);
            this.lTransporteinheitstyp.Name = "lTransporteinheitstyp";
            this.lTransporteinheitstyp.Size = new System.Drawing.Size(120, 24);
            this.lTransporteinheitstyp.TabIndex = 4;
            this.lTransporteinheitstyp.Text = "Transporteinheitstyp";
            this.lTransporteinheitstyp.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbTransporteinheitstypLong
            // 
            this.tbTransporteinheitstypLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTransporteinheitstypLong.Location = new System.Drawing.Point(240, 24);
            this.tbTransporteinheitstypLong.Name = "tbTransporteinheitstypLong";
            this.tbTransporteinheitstypLong.ReadOnly = true;
            this.tbTransporteinheitstypLong.Size = new System.Drawing.Size(120, 24);
            this.tbTransporteinheitstypLong.TabIndex = 2;
            // 
            // tbTransporteinheitstypShort
            // 
            this.tbTransporteinheitstypShort.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTransporteinheitstypShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTransporteinheitstypShort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbTransporteinheitstypShort.Location = new System.Drawing.Point(152, 24);
            this.tbTransporteinheitstypShort.Name = "tbTransporteinheitstypShort";
            this.tbTransporteinheitstypShort.Size = new System.Drawing.Size(80, 24);
            this.tbTransporteinheitstypShort.TabIndex = 1;
            // 
            // tbFahrzeugkennzeichen
            // 
            this.tbFahrzeugkennzeichen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFahrzeugkennzeichen.Location = new System.Drawing.Point(16, 24);
            this.tbFahrzeugkennzeichen.Name = "tbFahrzeugkennzeichen";
            this.tbFahrzeugkennzeichen.Size = new System.Drawing.Size(120, 24);
            this.tbFahrzeugkennzeichen.TabIndex = 0;
            // 
            // lFahrzeugkennzeichen
            // 
            this.lFahrzeugkennzeichen.Location = new System.Drawing.Point(12, 0);
            this.lFahrzeugkennzeichen.Name = "lFahrzeugkennzeichen";
            this.lFahrzeugkennzeichen.Size = new System.Drawing.Size(120, 24);
            this.lFahrzeugkennzeichen.TabIndex = 3;
            this.lFahrzeugkennzeichen.Text = "Fahrzeugkennzeichen";
            this.lFahrzeugkennzeichen.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pDB
            // 
            this.pDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDB.Controls.Add(this.lSPK);
            this.pDB.Controls.Add(this.lUSR);
            this.pDB.Controls.Add(this.tbSPK);
            this.pDB.Controls.Add(this.tbUSR);
            this.pDB.Controls.Add(this.tbADAT);
            this.pDB.Controls.Add(this.lADAT);
            this.pDB.Location = new System.Drawing.Point(0, 456);
            this.pDB.Name = "pDB";
            this.pDB.Size = new System.Drawing.Size(800, 64);
            this.pDB.TabIndex = 3;
            // 
            // lSPK
            // 
            this.lSPK.Location = new System.Drawing.Point(281, 0);
            this.lSPK.Name = "lSPK";
            this.lSPK.Size = new System.Drawing.Size(47, 24);
            this.lSPK.TabIndex = 5;
            this.lSPK.Text = "SPK";
            this.lSPK.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lUSR
            // 
            this.lUSR.Location = new System.Drawing.Point(149, 0);
            this.lUSR.Name = "lUSR";
            this.lUSR.Size = new System.Drawing.Size(120, 24);
            this.lUSR.TabIndex = 4;
            this.lUSR.Text = "Letzte Änderung von";
            this.lUSR.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbSPK
            // 
            this.tbSPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSPK.Location = new System.Drawing.Point(284, 24);
            this.tbSPK.Name = "tbSPK";
            this.tbSPK.ReadOnly = true;
            this.tbSPK.Size = new System.Drawing.Size(44, 24);
            this.tbSPK.TabIndex = 2;
            this.tbSPK.Text = "0";
            // 
            // tbUSR
            // 
            this.tbUSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUSR.Location = new System.Drawing.Point(152, 24);
            this.tbUSR.Name = "tbUSR";
            this.tbUSR.ReadOnly = true;
            this.tbUSR.Size = new System.Drawing.Size(120, 24);
            this.tbUSR.TabIndex = 1;
            this.tbUSR.Text = "Implico";
            // 
            // tbADAT
            // 
            this.tbADAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbADAT.Location = new System.Drawing.Point(16, 24);
            this.tbADAT.Name = "tbADAT";
            this.tbADAT.ReadOnly = true;
            this.tbADAT.Size = new System.Drawing.Size(120, 24);
            this.tbADAT.TabIndex = 0;
            // 
            // lADAT
            // 
            this.lADAT.Location = new System.Drawing.Point(13, 0);
            this.lADAT.Name = "lADAT";
            this.lADAT.Size = new System.Drawing.Size(120, 24);
            this.lADAT.TabIndex = 3;
            this.lADAT.Text = "Letzte Änderung am";
            this.lADAT.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frm0028Tankwagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.pDB);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frm0028Tankwagen";
            this.Text = "Tankwagen";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Beladedaten.ResumeLayout(false);
            this.gbBeladedatenAllgemein.ResumeLayout(false);
            this.gbBeladedatenAllgemein.PerformLayout();
            this.gbKammern.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pDB.ResumeLayout(false);
            this.pDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem neuePositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validierenToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage SmartEdit;
        private System.Windows.Forms.TabPage AllgDaten;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.TextBox tbFahrzeugkennzeichen;
        private System.Windows.Forms.Label lFahrzeugkennzeichen;
        private System.Windows.Forms.Panel pDB;
        private System.Windows.Forms.Label lTransporteinheitstyp;
        private System.Windows.Forms.TextBox tbTransporteinheitstypLong;
        private System.Windows.Forms.TextBox tbTransporteinheitstypShort;
        private System.Windows.Forms.Label lSPK;
        private System.Windows.Forms.Label lUSR;
        private System.Windows.Forms.TextBox tbSPK;
        private System.Windows.Forms.TextBox tbUSR;
        private System.Windows.Forms.TextBox tbADAT;
        private System.Windows.Forms.Label lADAT;
        private System.Windows.Forms.TabPage TechnischeDaten;
        private System.Windows.Forms.TabPage Gefahrgutangaben;
        private System.Windows.Forms.TabPage Beladedaten;
        private System.Windows.Forms.TabPage Sortenzuordnung;
        private System.Windows.Forms.TabPage Fahrerzuordnung;
        private System.Windows.Forms.TabPage Versandbereich;
        private System.Windows.Forms.GroupBox gbKammern;
        private System.Windows.Forms.GroupBox gbBeladedatenAllgemein;
        private System.Windows.Forms.TextBox tbProduktartShort;
        private System.Windows.Forms.Label lProduktart;
        private System.Windows.Forms.Label lBeladeart;
        private System.Windows.Forms.TextBox tbBeladeartShort;
        private System.Windows.Forms.Label lRauminhalt;
        private System.Windows.Forms.Label lMaxGesGewicht;
        private System.Windows.Forms.TextBox tbRauminhalt;
        private System.Windows.Forms.TextBox tbMaxGesGewicht;
        private System.Windows.Forms.Label lLeergewicht;
        private System.Windows.Forms.Label lPrüfdruck;
        private System.Windows.Forms.TextBox tbPrüfdruck;
        private System.Windows.Forms.TextBox tbLeergewicht;
        private System.Windows.Forms.TextBox tbProduktartLong;
        private System.Windows.Forms.TextBox tbBeladeartLong;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKammer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRauminhalt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriorität;
        private System.Windows.Forms.DataGridViewTextBoxColumn colADAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPK;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zurücksetzenToolStripMenuItem;
    }
}

