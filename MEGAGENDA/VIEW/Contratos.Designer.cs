namespace MEGAGENDA.VIEW
{
    partial class Contratos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.eidNumeric = new System.Windows.Forms.NumericUpDown();
            this.modeloBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.novoModeloButton = new System.Windows.Forms.Button();
            this.novoModeloBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.criarContratoBox = new System.Windows.Forms.Button();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.eidLabel = new System.Windows.Forms.Label();
            this.arquivoBox = new System.Windows.Forms.ComboBox();
            this.salvarModeloButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.secaoBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eidNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::MEGAGENDA.Properties.Resources.BorderBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 119);
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.BackgroundImage = global::MEGAGENDA.Properties.Resources.BorderBlue;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(2, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(187, 110);
            this.pictureBox9.TabIndex = 119;
            this.pictureBox9.TabStop = false;
            // 
            // eidNumeric
            // 
            this.eidNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eidNumeric.Location = new System.Drawing.Point(110, 124);
            this.eidNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.eidNumeric.Name = "eidNumeric";
            this.eidNumeric.Size = new System.Drawing.Size(66, 22);
            this.eidNumeric.TabIndex = 3;
            this.eidNumeric.ValueChanged += new System.EventHandler(this.eidNumeric_ValueChanged);
            // 
            // modeloBox
            // 
            this.modeloBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeloBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeloBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloBox.FormattingEnabled = true;
            this.modeloBox.Location = new System.Drawing.Point(15, 77);
            this.modeloBox.Name = "modeloBox";
            this.modeloBox.Size = new System.Drawing.Size(161, 25);
            this.modeloBox.TabIndex = 102;
            this.modeloBox.SelectedIndexChanged += new System.EventHandler(this.modeloBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 118;
            this.label1.Text = "Modelo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 122;
            this.label2.Text = "Arquivo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // novoModeloButton
            // 
            this.novoModeloButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.novoModeloButton.AutoEllipsis = true;
            this.novoModeloButton.BackColor = System.Drawing.Color.White;
            this.novoModeloButton.BackgroundImage = global::MEGAGENDA.Properties.Resources.Border;
            this.novoModeloButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novoModeloButton.Enabled = false;
            this.novoModeloButton.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.novoModeloButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.novoModeloButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoModeloButton.ForeColor = System.Drawing.Color.Black;
            this.novoModeloButton.Location = new System.Drawing.Point(128, 468);
            this.novoModeloButton.Name = "novoModeloButton";
            this.novoModeloButton.Size = new System.Drawing.Size(37, 20);
            this.novoModeloButton.TabIndex = 124;
            this.novoModeloButton.Text = "OK";
            this.novoModeloButton.UseVisualStyleBackColor = false;
            this.novoModeloButton.Click += new System.EventHandler(this.novoModeloButton_Click);
            // 
            // novoModeloBox
            // 
            this.novoModeloBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.novoModeloBox.Enabled = false;
            this.novoModeloBox.Location = new System.Drawing.Point(25, 468);
            this.novoModeloBox.Name = "novoModeloBox";
            this.novoModeloBox.Size = new System.Drawing.Size(97, 20);
            this.novoModeloBox.TabIndex = 125;
            this.novoModeloBox.TextChanged += new System.EventHandler(this.novoModeloBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 126;
            this.label4.Text = "Criar novo modelo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 127;
            this.label5.Text = "Editar modelo atual";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // criarContratoBox
            // 
            this.criarContratoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.criarContratoBox.AutoEllipsis = true;
            this.criarContratoBox.BackColor = System.Drawing.Color.White;
            this.criarContratoBox.BackgroundImage = global::MEGAGENDA.Properties.Resources.BorderBlue;
            this.criarContratoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.criarContratoBox.Enabled = false;
            this.criarContratoBox.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.criarContratoBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.criarContratoBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarContratoBox.ForeColor = System.Drawing.Color.Indigo;
            this.criarContratoBox.Location = new System.Drawing.Point(15, 340);
            this.criarContratoBox.Name = "criarContratoBox";
            this.criarContratoBox.Size = new System.Drawing.Size(161, 36);
            this.criarContratoBox.TabIndex = 130;
            this.criarContratoBox.Text = "Criar Contrato";
            this.criarContratoBox.UseVisualStyleBackColor = false;
            this.criarContratoBox.Click += new System.EventHandler(this.criarContratoBox_Click);
            // 
            // clienteLabel
            // 
            this.clienteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLabel.Location = new System.Drawing.Point(7, 153);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(174, 17);
            this.clienteLabel.TabIndex = 132;
            this.clienteLabel.Text = "Nome do Cliente";
            this.clienteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eidLabel
            // 
            this.eidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eidLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eidLabel.Location = new System.Drawing.Point(13, 127);
            this.eidLabel.Name = "eidLabel";
            this.eidLabel.Size = new System.Drawing.Size(91, 17);
            this.eidLabel.TabIndex = 116;
            this.eidLabel.Text = "ID do Evento";
            // 
            // arquivoBox
            // 
            this.arquivoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arquivoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arquivoBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoBox.FormattingEnabled = true;
            this.arquivoBox.Location = new System.Drawing.Point(15, 28);
            this.arquivoBox.Name = "arquivoBox";
            this.arquivoBox.Size = new System.Drawing.Size(161, 25);
            this.arquivoBox.TabIndex = 101;
            // 
            // salvarModeloButton
            // 
            this.salvarModeloButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.salvarModeloButton.AutoEllipsis = true;
            this.salvarModeloButton.BackColor = System.Drawing.Color.White;
            this.salvarModeloButton.BackgroundImage = global::MEGAGENDA.Properties.Resources.Border;
            this.salvarModeloButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salvarModeloButton.Enabled = false;
            this.salvarModeloButton.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.salvarModeloButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvarModeloButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarModeloButton.ForeColor = System.Drawing.Color.Black;
            this.salvarModeloButton.Location = new System.Drawing.Point(25, 528);
            this.salvarModeloButton.Name = "salvarModeloButton";
            this.salvarModeloButton.Size = new System.Drawing.Size(140, 20);
            this.salvarModeloButton.TabIndex = 128;
            this.salvarModeloButton.Text = "Sobrescrever modelo";
            this.salvarModeloButton.UseVisualStyleBackColor = false;
            this.salvarModeloButton.Click += new System.EventHandler(this.salvarModeloButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.BackgroundImage = global::MEGAGENDA.Properties.Resources.BorderTallBlue;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2.Controls.Add(this.secaoBox);
            this.splitContainer2.Panel2.Controls.Add(this.salvarModeloButton);
            this.splitContainer2.Panel2.Controls.Add(this.arquivoBox);
            this.splitContainer2.Panel2.Controls.Add(this.eidLabel);
            this.splitContainer2.Panel2.Controls.Add(this.clienteLabel);
            this.splitContainer2.Panel2.Controls.Add(this.criarContratoBox);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.novoModeloBox);
            this.splitContainer2.Panel2.Controls.Add(this.novoModeloButton);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.modeloBox);
            this.splitContainer2.Panel2.Controls.Add(this.eidNumeric);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox9);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1088, 560);
            this.splitContainer2.SplitterDistance = 895;
            this.splitContainer2.TabIndex = 3;
            this.splitContainer2.TabStop = false;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.AutoSize = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(10);
            this.flowPanel.Size = new System.Drawing.Size(895, 560);
            this.flowPanel.TabIndex = 0;
            this.flowPanel.WrapContents = false;
            this.flowPanel.SizeChanged += new System.EventHandler(this.flowPanel_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.flowPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 560);
            this.panel1.TabIndex = 1;
            // 
            // secaoBox
            // 
            this.secaoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secaoBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secaoBox.FormattingEnabled = true;
            this.secaoBox.ItemHeight = 21;
            this.secaoBox.Items.AddRange(new object[] {
            "CONTRATO",
            "CONTRATANTE",
            "CONTRATADO",
            "PAGAMENTO",
            "DESCUMPRIMENTO",
            "GERAIS",
            "FORO"});
            this.secaoBox.Location = new System.Drawing.Point(21, 181);
            this.secaoBox.Name = "secaoBox";
            this.secaoBox.Size = new System.Drawing.Size(148, 147);
            this.secaoBox.TabIndex = 134;
            this.secaoBox.SelectedIndexChanged += new System.EventHandler(this.secaoBox_SelectedIndexChanged);
            // 
            // Contratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 560);
            this.Controls.Add(this.splitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(470, 470);
            this.Name = "Contratos";
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eidNumeric)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.NumericUpDown eidNumeric;
        private System.Windows.Forms.ComboBox modeloBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button novoModeloButton;
        private System.Windows.Forms.TextBox novoModeloBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button criarContratoBox;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label eidLabel;
        private System.Windows.Forms.ComboBox arquivoBox;
        private System.Windows.Forms.Button salvarModeloButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.ListBox secaoBox;
    }
}