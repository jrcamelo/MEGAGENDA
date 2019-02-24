namespace MEGAGENDA.VIEW
{
    partial class Agenda
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.calendario = new Pabo.Calendar.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroPossiveisCheck = new System.Windows.Forms.CheckBox();
            this.filtroFinalizadosCheck = new System.Windows.Forms.CheckBox();
            this.filtroPagamentosCheck = new System.Windows.Forms.CheckBox();
            this.editarButton = new System.Windows.Forms.Button();
            this.textoLabel = new System.Windows.Forms.Label();
            this.eidLabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.ComboBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.calendario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.BackgroundImage = global::MEGAGENDA.Properties.Resources.BorderTallBlue;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.filtroPossiveisCheck);
            this.splitContainer1.Panel2.Controls.Add(this.filtroFinalizadosCheck);
            this.splitContainer1.Panel2.Controls.Add(this.filtroPagamentosCheck);
            this.splitContainer1.Panel2.Controls.Add(this.editarButton);
            this.splitContainer1.Panel2.Controls.Add(this.textoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.eidLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label27);
            this.splitContainer1.Panel2.Controls.Add(this.itemBox);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox9);
            this.splitContainer1.Size = new System.Drawing.Size(853, 509);
            this.splitContainer1.SplitterDistance = 580;
            this.splitContainer1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 481);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 25);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // calendario
            // 
            this.calendario.ActiveMonth.Month = 8;
            this.calendario.ActiveMonth.Year = 2018;
            this.calendario.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.calendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendario.ExtendedSelectionKey = Pabo.Calendar.mcExtendedSelectionKey.None;
            this.calendario.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.calendario.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.calendario.Header.TextColor = System.Drawing.Color.White;
            this.calendario.ImageList = null;
            this.calendario.KeyboardEnabled = false;
            this.calendario.Location = new System.Drawing.Point(0, 0);
            this.calendario.MaxDate = new System.DateTime(2056, 8, 7, 0, 0, 0, 0);
            this.calendario.MinDate = new System.DateTime(2016, 8, 7, 0, 0, 0, 0);
            this.calendario.Month.BackgroundImage = null;
            this.calendario.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Name = "calendario";
            this.calendario.SelectionMode = Pabo.Calendar.mcSelectionMode.One;
            this.calendario.ShowWeeknumbers = true;
            this.calendario.Size = new System.Drawing.Size(580, 509);
            this.calendario.TabIndex = 0;
            this.calendario.TodayColor = System.Drawing.Color.CornflowerBlue;
            this.calendario.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.MonthChanged += new Pabo.Calendar.MonthChangedEventHandler(this.calendario_MonthChanged);
            this.calendario.DayDoubleClick += new Pabo.Calendar.DayClickEventHandler(this.calendario_DayDoubleClick);
            this.calendario.DaySelected += new Pabo.Calendar.DaySelectedEventHandler(this.calendario_DaySelected);
            this.calendario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gotoHoje_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 143;
            this.label1.Text = "Filtros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // filtroPossiveisCheck
            // 
            this.filtroPossiveisCheck.AutoSize = true;
            this.filtroPossiveisCheck.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroPossiveisCheck.Location = new System.Drawing.Point(18, 109);
            this.filtroPossiveisCheck.Name = "filtroPossiveisCheck";
            this.filtroPossiveisCheck.Size = new System.Drawing.Size(150, 25);
            this.filtroPossiveisCheck.TabIndex = 142;
            this.filtroPossiveisCheck.Text = "Eventos Possíveis";
            this.filtroPossiveisCheck.UseVisualStyleBackColor = true;
            this.filtroPossiveisCheck.CheckedChanged += new System.EventHandler(this.filtroPossiveisCheck_CheckedChanged);
            // 
            // filtroFinalizadosCheck
            // 
            this.filtroFinalizadosCheck.AutoSize = true;
            this.filtroFinalizadosCheck.Checked = true;
            this.filtroFinalizadosCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filtroFinalizadosCheck.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroFinalizadosCheck.Location = new System.Drawing.Point(18, 78);
            this.filtroFinalizadosCheck.Name = "filtroFinalizadosCheck";
            this.filtroFinalizadosCheck.Size = new System.Drawing.Size(164, 25);
            this.filtroFinalizadosCheck.TabIndex = 141;
            this.filtroFinalizadosCheck.Text = "Eventos Finalizados";
            this.filtroFinalizadosCheck.UseVisualStyleBackColor = true;
            this.filtroFinalizadosCheck.CheckedChanged += new System.EventHandler(this.filtroFinalizadosCheck_CheckedChanged);
            // 
            // filtroPagamentosCheck
            // 
            this.filtroPagamentosCheck.AutoSize = true;
            this.filtroPagamentosCheck.Checked = true;
            this.filtroPagamentosCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filtroPagamentosCheck.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroPagamentosCheck.Location = new System.Drawing.Point(18, 47);
            this.filtroPagamentosCheck.Name = "filtroPagamentosCheck";
            this.filtroPagamentosCheck.Size = new System.Drawing.Size(115, 25);
            this.filtroPagamentosCheck.TabIndex = 140;
            this.filtroPagamentosCheck.Text = "Pagamentos";
            this.filtroPagamentosCheck.UseVisualStyleBackColor = true;
            this.filtroPagamentosCheck.CheckedChanged += new System.EventHandler(this.filtroPagamentosCheck_CheckedChanged);
            // 
            // editarButton
            // 
            this.editarButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editarButton.AutoEllipsis = true;
            this.editarButton.BackColor = System.Drawing.Color.White;
            this.editarButton.BackgroundImage = global::MEGAGENDA.Properties.Resources.BorderBlue;
            this.editarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarButton.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editarButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarButton.ForeColor = System.Drawing.Color.Black;
            this.editarButton.Location = new System.Drawing.Point(35, 346);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(199, 36);
            this.editarButton.TabIndex = 139;
            this.editarButton.Text = "Editar Evento";
            this.editarButton.UseVisualStyleBackColor = false;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // textoLabel
            // 
            this.textoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textoLabel.AutoEllipsis = true;
            this.textoLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLabel.ForeColor = System.Drawing.Color.Navy;
            this.textoLabel.Location = new System.Drawing.Point(13, 284);
            this.textoLabel.Name = "textoLabel";
            this.textoLabel.Size = new System.Drawing.Size(244, 59);
            this.textoLabel.TabIndex = 116;
            this.textoLabel.Text = "Nenhum lembrete selecionado";
            this.textoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eidLabel
            // 
            this.eidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eidLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eidLabel.Location = new System.Drawing.Point(35, 248);
            this.eidLabel.Name = "eidLabel";
            this.eidLabel.Size = new System.Drawing.Size(199, 17);
            this.eidLabel.TabIndex = 115;
            this.eidLabel.Text = "ID do Evento: 0";
            this.eidLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(13, 180);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(244, 22);
            this.label27.TabIndex = 113;
            this.label27.Text = "Lembretes Selecionados";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // itemBox
            // 
            this.itemBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Location = new System.Drawing.Point(13, 205);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(244, 25);
            this.itemBox.TabIndex = 0;
            this.itemBox.SelectedIndexChanged += new System.EventHandler(this.itemBox_SelectedIndexChanged);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.BackgroundImage = global::MEGAGENDA.Properties.Resources.BorderBlue;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(2, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(265, 155);
            this.pictureBox9.TabIndex = 144;
            this.pictureBox9.TabStop = false;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 509);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Pabo.Calendar.MonthCalendar calendario;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox itemBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label textoLabel;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Label eidLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox filtroPossiveisCheck;
        private System.Windows.Forms.CheckBox filtroFinalizadosCheck;
        private System.Windows.Forms.CheckBox filtroPagamentosCheck;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}