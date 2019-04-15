namespace MEGAGENDA.VIEW
{
    partial class Listas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listas));
            this.splitClientesEventos = new System.Windows.Forms.SplitContainer();
            this.idClienteBox = new System.Windows.Forms.NumericUpDown();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.clientePesquisaBox = new System.Windows.Forms.TextBox();
            this.clientePesquisaTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEventoBox = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.eventoPesquisaTipo = new System.Windows.Forms.ComboBox();
            this.eventoPesquisaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataEventos = new System.Windows.Forms.DataGridView();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitDataPesquisa = new System.Windows.Forms.SplitContainer();
            this.pesquisaDataDe = new System.Windows.Forms.DateTimePicker();
            this.pesquisaDataA = new System.Windows.Forms.DateTimePicker();
            this.clienteLimparButton = new System.Windows.Forms.Button();
            this.editClienteButton = new System.Windows.Forms.Button();
            this.addClienteButton = new System.Windows.Forms.Button();
            this.listarEventoButton = new System.Windows.Forms.Button();
            this.clienteEventoButton = new System.Windows.Forms.Button();
            this.clientePesquisaButton = new System.Windows.Forms.Button();
            this.eventoLimparButton = new System.Windows.Forms.Button();
            this.editEventoButton = new System.Windows.Forms.Button();
            this.addEventoButton = new System.Windows.Forms.Button();
            this.editEventoClienteButton = new System.Windows.Forms.Button();
            this.contratoButton = new System.Windows.Forms.Button();
            this.eventoPesquisaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitClientesEventos)).BeginInit();
            this.splitClientesEventos.Panel1.SuspendLayout();
            this.splitClientesEventos.Panel2.SuspendLayout();
            this.splitClientesEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idClienteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEventoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitDataPesquisa)).BeginInit();
            this.splitDataPesquisa.Panel1.SuspendLayout();
            this.splitDataPesquisa.Panel2.SuspendLayout();
            this.splitDataPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitClientesEventos
            // 
            this.splitClientesEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitClientesEventos.Location = new System.Drawing.Point(0, 0);
            this.splitClientesEventos.Name = "splitClientesEventos";
            // 
            // splitClientesEventos.Panel1
            // 
            this.splitClientesEventos.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitClientesEventos.Panel1.BackgroundImage = global::MEGAGENDA.Properties.Resources.BorderTall;
            this.splitClientesEventos.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitClientesEventos.Panel1.Controls.Add(this.clienteLimparButton);
            this.splitClientesEventos.Panel1.Controls.Add(this.idClienteBox);
            this.splitClientesEventos.Panel1.Controls.Add(this.splitContainer2);
            this.splitClientesEventos.Panel1.Controls.Add(this.clientePesquisaBox);
            this.splitClientesEventos.Panel1.Controls.Add(this.clientePesquisaButton);
            this.splitClientesEventos.Panel1.Controls.Add(this.clientePesquisaTipo);
            this.splitClientesEventos.Panel1.Controls.Add(this.label2);
            this.splitClientesEventos.Panel1.Controls.Add(this.dataClientes);
            this.splitClientesEventos.Panel1MinSize = 0;
            // 
            // splitClientesEventos.Panel2
            // 
            this.splitClientesEventos.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitClientesEventos.Panel2.BackgroundImage = global::MEGAGENDA.Properties.Resources.BorderTall;
            this.splitClientesEventos.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitClientesEventos.Panel2.Controls.Add(this.eventoLimparButton);
            this.splitClientesEventos.Panel2.Controls.Add(this.idEventoBox);
            this.splitClientesEventos.Panel2.Controls.Add(this.splitContainer1);
            this.splitClientesEventos.Panel2.Controls.Add(this.eventoPesquisaTipo);
            this.splitClientesEventos.Panel2.Controls.Add(this.eventoPesquisaBox);
            this.splitClientesEventos.Panel2.Controls.Add(this.eventoPesquisaButton);
            this.splitClientesEventos.Panel2.Controls.Add(this.label1);
            this.splitClientesEventos.Panel2.Controls.Add(this.dataEventos);
            this.splitClientesEventos.Panel2.Controls.Add(this.splitDataPesquisa);
            this.splitClientesEventos.Panel2MinSize = 0;
            this.splitClientesEventos.Size = new System.Drawing.Size(1088, 560);
            this.splitClientesEventos.SplitterDistance = 527;
            this.splitClientesEventos.TabIndex = 0;
            // 
            // idClienteBox
            // 
            this.idClienteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idClienteBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClienteBox.Location = new System.Drawing.Point(324, 120);
            this.idClienteBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.idClienteBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idClienteBox.Name = "idClienteBox";
            this.idClienteBox.Size = new System.Drawing.Size(40, 23);
            this.idClienteBox.TabIndex = 19;
            this.idClienteBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(16, 43);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.editClienteButton);
            this.splitContainer2.Panel1.Controls.Add(this.addClienteButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listarEventoButton);
            this.splitContainer2.Panel2.Controls.Add(this.clienteEventoButton);
            this.splitContainer2.Size = new System.Drawing.Size(490, 70);
            this.splitContainer2.SplitterDistance = 245;
            this.splitContainer2.TabIndex = 16;
            // 
            // clientePesquisaBox
            // 
            this.clientePesquisaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientePesquisaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.clientePesquisaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientePesquisaBox.Enabled = false;
            this.clientePesquisaBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientePesquisaBox.Location = new System.Drawing.Point(111, 119);
            this.clientePesquisaBox.Name = "clientePesquisaBox";
            this.clientePesquisaBox.Size = new System.Drawing.Size(207, 23);
            this.clientePesquisaBox.TabIndex = 9;
            // 
            // clientePesquisaTipo
            // 
            this.clientePesquisaTipo.BackColor = System.Drawing.Color.White;
            this.clientePesquisaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientePesquisaTipo.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientePesquisaTipo.FormattingEnabled = true;
            this.clientePesquisaTipo.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "CPF/CNPJ",
            "Anotações"});
            this.clientePesquisaTipo.Location = new System.Drawing.Point(17, 118);
            this.clientePesquisaTipo.Name = "clientePesquisaTipo";
            this.clientePesquisaTipo.Size = new System.Drawing.Size(88, 24);
            this.clientePesquisaTipo.TabIndex = 7;
            this.clientePesquisaTipo.SelectedIndexChanged += new System.EventHandler(this.clientePesquisaTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.AllowUserToOrderColumns = true;
            this.dataClientes.AllowUserToResizeRows = false;
            this.dataClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dataClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.Nome,
            this.Documento});
            this.dataClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataClientes.Location = new System.Drawing.Point(17, 149);
            this.dataClientes.MultiSelect = false;
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataClientes.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClientes.Size = new System.Drawing.Size(489, 399);
            this.dataClientes.TabIndex = 0;
            this.dataClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClientes_CellDoubleClick);
            // 
            // PID
            // 
            this.PID.FillWeight = 1F;
            this.PID.HeaderText = "ID";
            this.PID.MinimumWidth = 100;
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.FillWeight = 1800F;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 140;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "CPF/CNPJ";
            this.Documento.MinimumWidth = 100;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // idEventoBox
            // 
            this.idEventoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idEventoBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEventoBox.Location = new System.Drawing.Point(340, 120);
            this.idEventoBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.idEventoBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idEventoBox.Name = "idEventoBox";
            this.idEventoBox.Size = new System.Drawing.Size(48, 23);
            this.idEventoBox.TabIndex = 20;
            this.idEventoBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(20, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.editEventoButton);
            this.splitContainer1.Panel1.Controls.Add(this.addEventoButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.editEventoClienteButton);
            this.splitContainer1.Panel2.Controls.Add(this.contratoButton);
            this.splitContainer1.Size = new System.Drawing.Size(510, 69);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 15;
            // 
            // eventoPesquisaTipo
            // 
            this.eventoPesquisaTipo.BackColor = System.Drawing.Color.White;
            this.eventoPesquisaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventoPesquisaTipo.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoPesquisaTipo.FormattingEnabled = true;
            this.eventoPesquisaTipo.Items.AddRange(new object[] {
            "ID",
            "Cliente",
            "Data",
            "Tipo",
            "Observações"});
            this.eventoPesquisaTipo.Location = new System.Drawing.Point(20, 118);
            this.eventoPesquisaTipo.Name = "eventoPesquisaTipo";
            this.eventoPesquisaTipo.Size = new System.Drawing.Size(88, 24);
            this.eventoPesquisaTipo.TabIndex = 10;
            this.eventoPesquisaTipo.SelectedIndexChanged += new System.EventHandler(this.eventoPesquisaTipo_SelectedIndexChanged);
            // 
            // eventoPesquisaBox
            // 
            this.eventoPesquisaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventoPesquisaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.eventoPesquisaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventoPesquisaBox.Enabled = false;
            this.eventoPesquisaBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoPesquisaBox.Location = new System.Drawing.Point(114, 119);
            this.eventoPesquisaBox.Name = "eventoPesquisaBox";
            this.eventoPesquisaBox.Size = new System.Drawing.Size(220, 23);
            this.eventoPesquisaBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eventos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataEventos
            // 
            this.dataEventos.AllowUserToAddRows = false;
            this.dataEventos.AllowUserToDeleteRows = false;
            this.dataEventos.AllowUserToOrderColumns = true;
            this.dataEventos.AllowUserToResizeRows = false;
            this.dataEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dataEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataEventos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EID,
            this.CID,
            this.tipo,
            this.data});
            this.dataEventos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataEventos.Location = new System.Drawing.Point(20, 149);
            this.dataEventos.MultiSelect = false;
            this.dataEventos.Name = "dataEventos";
            this.dataEventos.ReadOnly = true;
            this.dataEventos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEventos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataEventos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEventos.Size = new System.Drawing.Size(510, 399);
            this.dataEventos.TabIndex = 1;
            this.dataEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEventos_CellDoubleClick);
            // 
            // EID
            // 
            this.EID.FillWeight = 1F;
            this.EID.HeaderText = "ID";
            this.EID.MinimumWidth = 55;
            this.EID.Name = "EID";
            this.EID.ReadOnly = true;
            // 
            // CID
            // 
            this.CID.FillWeight = 1F;
            this.CID.HeaderText = "Cliente";
            this.CID.MinimumWidth = 50;
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.FillWeight = 21.43562F;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.data.FillWeight = 84.42784F;
            this.data.HeaderText = "Data";
            this.data.MinimumWidth = 80;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 80;
            // 
            // splitDataPesquisa
            // 
            this.splitDataPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitDataPesquisa.BackColor = System.Drawing.Color.White;
            this.splitDataPesquisa.Location = new System.Drawing.Point(114, 119);
            this.splitDataPesquisa.Name = "splitDataPesquisa";
            // 
            // splitDataPesquisa.Panel1
            // 
            this.splitDataPesquisa.Panel1.Controls.Add(this.pesquisaDataDe);
            // 
            // splitDataPesquisa.Panel2
            // 
            this.splitDataPesquisa.Panel2.Controls.Add(this.pesquisaDataA);
            this.splitDataPesquisa.Size = new System.Drawing.Size(220, 23);
            this.splitDataPesquisa.SplitterDistance = 107;
            this.splitDataPesquisa.TabIndex = 16;
            // 
            // pesquisaDataDe
            // 
            this.pesquisaDataDe.CalendarFont = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaDataDe.CustomFormat = "De dd/MM/yyyy";
            this.pesquisaDataDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pesquisaDataDe.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaDataDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pesquisaDataDe.Location = new System.Drawing.Point(0, 0);
            this.pesquisaDataDe.Name = "pesquisaDataDe";
            this.pesquisaDataDe.Size = new System.Drawing.Size(107, 23);
            this.pesquisaDataDe.TabIndex = 13;
            this.pesquisaDataDe.ValueChanged += new System.EventHandler(this.pesquisaDataDe_ValueChanged);
            // 
            // pesquisaDataA
            // 
            this.pesquisaDataA.CalendarFont = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaDataA.CustomFormat = "A dd/MM/yyyy";
            this.pesquisaDataA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pesquisaDataA.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaDataA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pesquisaDataA.Location = new System.Drawing.Point(0, 0);
            this.pesquisaDataA.Name = "pesquisaDataA";
            this.pesquisaDataA.Size = new System.Drawing.Size(109, 23);
            this.pesquisaDataA.TabIndex = 14;
            this.pesquisaDataA.ValueChanged += new System.EventHandler(this.pesquisaDataA_ValueChanged);
            // 
            // clienteLimparButton
            // 
            this.clienteLimparButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteLimparButton.BackgroundImage = global::MEGAGENDA.Properties.Resources.Border;
            this.clienteLimparButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clienteLimparButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clienteLimparButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLimparButton.Location = new System.Drawing.Point(451, 120);
            this.clienteLimparButton.Name = "clienteLimparButton";
            this.clienteLimparButton.Size = new System.Drawing.Size(55, 24);
            this.clienteLimparButton.TabIndex = 20;
            this.clienteLimparButton.Text = "Limpar";
            this.clienteLimparButton.UseVisualStyleBackColor = true;
            this.clienteLimparButton.Click += new System.EventHandler(this.clienteLimparButton_Click);
            // 
            // editClienteButton
            // 
            this.editClienteButton.AutoSize = true;
            this.editClienteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editClienteButton.BackgroundImage")));
            this.editClienteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editClienteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editClienteButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClienteButton.Location = new System.Drawing.Point(0, 37);
            this.editClienteButton.Name = "editClienteButton";
            this.editClienteButton.Size = new System.Drawing.Size(245, 33);
            this.editClienteButton.TabIndex = 3;
            this.editClienteButton.Text = "Editar Selecionado";
            this.editClienteButton.UseVisualStyleBackColor = true;
            this.editClienteButton.Click += new System.EventHandler(this.editClienteButton_Click);
            // 
            // addClienteButton
            // 
            this.addClienteButton.AutoSize = true;
            this.addClienteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addClienteButton.BackgroundImage")));
            this.addClienteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addClienteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClienteButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClienteButton.Location = new System.Drawing.Point(0, 0);
            this.addClienteButton.Name = "addClienteButton";
            this.addClienteButton.Size = new System.Drawing.Size(245, 33);
            this.addClienteButton.TabIndex = 0;
            this.addClienteButton.Text = "Adicionar Cliente";
            this.addClienteButton.UseVisualStyleBackColor = true;
            this.addClienteButton.Click += new System.EventHandler(this.criarClienteButton_Click);
            // 
            // listarEventoButton
            // 
            this.listarEventoButton.AutoSize = true;
            this.listarEventoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listarEventoButton.BackgroundImage")));
            this.listarEventoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listarEventoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listarEventoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listarEventoButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarEventoButton.Location = new System.Drawing.Point(0, 37);
            this.listarEventoButton.Name = "listarEventoButton";
            this.listarEventoButton.Size = new System.Drawing.Size(241, 33);
            this.listarEventoButton.TabIndex = 3;
            this.listarEventoButton.Text = "Listar Eventos";
            this.listarEventoButton.UseVisualStyleBackColor = true;
            this.listarEventoButton.Click += new System.EventHandler(this.listarEventoButton_Click);
            // 
            // clienteEventoButton
            // 
            this.clienteEventoButton.AutoSize = true;
            this.clienteEventoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clienteEventoButton.BackgroundImage")));
            this.clienteEventoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clienteEventoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clienteEventoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clienteEventoButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteEventoButton.Location = new System.Drawing.Point(0, 0);
            this.clienteEventoButton.Name = "clienteEventoButton";
            this.clienteEventoButton.Size = new System.Drawing.Size(241, 33);
            this.clienteEventoButton.TabIndex = 1;
            this.clienteEventoButton.Text = "Criar Evento";
            this.clienteEventoButton.UseVisualStyleBackColor = true;
            this.clienteEventoButton.Click += new System.EventHandler(this.clienteEventoButton_Click);
            // 
            // clientePesquisaButton
            // 
            this.clientePesquisaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientePesquisaButton.BackgroundImage = global::MEGAGENDA.Properties.Resources.Border;
            this.clientePesquisaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientePesquisaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientePesquisaButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientePesquisaButton.Location = new System.Drawing.Point(370, 120);
            this.clientePesquisaButton.Name = "clientePesquisaButton";
            this.clientePesquisaButton.Size = new System.Drawing.Size(75, 24);
            this.clientePesquisaButton.TabIndex = 8;
            this.clientePesquisaButton.Text = "Pesquisar";
            this.clientePesquisaButton.UseVisualStyleBackColor = true;
            this.clientePesquisaButton.Click += new System.EventHandler(this.clientePesquisaButton_Click);
            // 
            // eventoLimparButton
            // 
            this.eventoLimparButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eventoLimparButton.BackgroundImage = global::MEGAGENDA.Properties.Resources.Border;
            this.eventoLimparButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eventoLimparButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventoLimparButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoLimparButton.Location = new System.Drawing.Point(475, 120);
            this.eventoLimparButton.Name = "eventoLimparButton";
            this.eventoLimparButton.Size = new System.Drawing.Size(55, 24);
            this.eventoLimparButton.TabIndex = 21;
            this.eventoLimparButton.Text = "Limpar";
            this.eventoLimparButton.UseVisualStyleBackColor = true;
            this.eventoLimparButton.Click += new System.EventHandler(this.eventoLimparButton_Click);
            // 
            // editEventoButton
            // 
            this.editEventoButton.AutoSize = true;
            this.editEventoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editEventoButton.BackgroundImage")));
            this.editEventoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editEventoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editEventoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEventoButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEventoButton.Location = new System.Drawing.Point(0, 36);
            this.editEventoButton.Name = "editEventoButton";
            this.editEventoButton.Size = new System.Drawing.Size(255, 33);
            this.editEventoButton.TabIndex = 3;
            this.editEventoButton.Text = "Editar Selecionado";
            this.editEventoButton.UseVisualStyleBackColor = true;
            this.editEventoButton.Click += new System.EventHandler(this.editEventoButton_Click);
            // 
            // addEventoButton
            // 
            this.addEventoButton.AutoSize = true;
            this.addEventoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEventoButton.BackgroundImage")));
            this.addEventoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEventoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addEventoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEventoButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventoButton.Location = new System.Drawing.Point(0, 0);
            this.addEventoButton.Name = "addEventoButton";
            this.addEventoButton.Size = new System.Drawing.Size(255, 33);
            this.addEventoButton.TabIndex = 2;
            this.addEventoButton.Text = "Adicionar Evento";
            this.addEventoButton.UseVisualStyleBackColor = true;
            this.addEventoButton.Click += new System.EventHandler(this.addEventoButton_Click);
            // 
            // editEventoClienteButton
            // 
            this.editEventoClienteButton.AutoSize = true;
            this.editEventoClienteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editEventoClienteButton.BackgroundImage")));
            this.editEventoClienteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editEventoClienteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editEventoClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEventoClienteButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEventoClienteButton.Location = new System.Drawing.Point(0, 36);
            this.editEventoClienteButton.Name = "editEventoClienteButton";
            this.editEventoClienteButton.Size = new System.Drawing.Size(251, 33);
            this.editEventoClienteButton.TabIndex = 2;
            this.editEventoClienteButton.Text = "Editar Cliente do Evento";
            this.editEventoClienteButton.UseVisualStyleBackColor = true;
            this.editEventoClienteButton.Click += new System.EventHandler(this.editEventoClienteButton_Click);
            // 
            // contratoButton
            // 
            this.contratoButton.AutoSize = true;
            this.contratoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contratoButton.BackgroundImage")));
            this.contratoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contratoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.contratoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contratoButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contratoButton.Location = new System.Drawing.Point(0, 0);
            this.contratoButton.Name = "contratoButton";
            this.contratoButton.Size = new System.Drawing.Size(251, 33);
            this.contratoButton.TabIndex = 1;
            this.contratoButton.Text = "Fazer Contrato";
            this.contratoButton.UseVisualStyleBackColor = true;
            this.contratoButton.Click += new System.EventHandler(this.contratoButton_Click);
            // 
            // eventoPesquisaButton
            // 
            this.eventoPesquisaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eventoPesquisaButton.BackgroundImage = global::MEGAGENDA.Properties.Resources.Border;
            this.eventoPesquisaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eventoPesquisaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventoPesquisaButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoPesquisaButton.Location = new System.Drawing.Point(394, 120);
            this.eventoPesquisaButton.Name = "eventoPesquisaButton";
            this.eventoPesquisaButton.Size = new System.Drawing.Size(75, 24);
            this.eventoPesquisaButton.TabIndex = 11;
            this.eventoPesquisaButton.Text = "Pesquisar";
            this.eventoPesquisaButton.UseVisualStyleBackColor = true;
            this.eventoPesquisaButton.Click += new System.EventHandler(this.eventoPesquisaButton_Click);
            // 
            // Listas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 560);
            this.ControlBox = false;
            this.Controls.Add(this.splitClientesEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Listas";
            this.ShowInTaskbar = false;
            this.Text = "FormListas";
            this.splitClientesEventos.Panel1.ResumeLayout(false);
            this.splitClientesEventos.Panel1.PerformLayout();
            this.splitClientesEventos.Panel2.ResumeLayout(false);
            this.splitClientesEventos.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitClientesEventos)).EndInit();
            this.splitClientesEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idClienteBox)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEventoBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEventos)).EndInit();
            this.splitDataPesquisa.Panel1.ResumeLayout(false);
            this.splitDataPesquisa.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDataPesquisa)).EndInit();
            this.splitDataPesquisa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitClientesEventos;
        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.Button addClienteButton;
        private System.Windows.Forms.Button clienteEventoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clientePesquisaButton;
        private System.Windows.Forms.ComboBox clientePesquisaTipo;
        private System.Windows.Forms.TextBox clientePesquisaBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button editClienteButton;
        private System.Windows.Forms.Button listarEventoButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button editEventoButton;
        private System.Windows.Forms.Button addEventoButton;
        private System.Windows.Forms.Button editEventoClienteButton;
        private System.Windows.Forms.Button contratoButton;
        private System.Windows.Forms.ComboBox eventoPesquisaTipo;
        private System.Windows.Forms.TextBox eventoPesquisaBox;
        private System.Windows.Forms.Button eventoPesquisaButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataEventos;
        private System.Windows.Forms.SplitContainer splitDataPesquisa;
        private System.Windows.Forms.DateTimePicker pesquisaDataDe;
        private System.Windows.Forms.DateTimePicker pesquisaDataA;
        private System.Windows.Forms.NumericUpDown idClienteBox;
        private System.Windows.Forms.NumericUpDown idEventoBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.Button clienteLimparButton;
        private System.Windows.Forms.Button eventoLimparButton;
    }
}