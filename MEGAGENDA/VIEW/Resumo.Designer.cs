namespace MEGAGENDA.VIEW
{
    partial class Resumo
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
            this.mesBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.semanaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hojeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mesBox
            // 
            this.mesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(248)))), ((int)(((byte)(198)))));
            this.mesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mesBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesBox.Location = new System.Drawing.Point(499, 36);
            this.mesBox.Multiline = true;
            this.mesBox.Name = "mesBox";
            this.mesBox.ReadOnly = true;
            this.mesBox.Size = new System.Drawing.Size(533, 413);
            this.mesBox.TabIndex = 0;
            this.mesBox.TabStop = false;
            this.mesBox.Click += new System.EventHandler(this.copiar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(499, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resumo do Mês";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semanaBox
            // 
            this.semanaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.semanaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(248)))), ((int)(((byte)(198)))));
            this.semanaBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.semanaBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semanaBox.Location = new System.Drawing.Point(7, 172);
            this.semanaBox.Multiline = true;
            this.semanaBox.Name = "semanaBox";
            this.semanaBox.ReadOnly = true;
            this.semanaBox.Size = new System.Drawing.Size(457, 277);
            this.semanaBox.TabIndex = 8;
            this.semanaBox.TabStop = false;
            this.semanaBox.Click += new System.EventHandler(this.copiar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(7, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Próximos 7 dias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hojeBox
            // 
            this.hojeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(248)))), ((int)(((byte)(198)))));
            this.hojeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hojeBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hojeBox.Location = new System.Drawing.Point(7, 36);
            this.hojeBox.Multiline = true;
            this.hojeBox.Name = "hojeBox";
            this.hojeBox.ReadOnly = true;
            this.hojeBox.Size = new System.Drawing.Size(457, 98);
            this.hojeBox.TabIndex = 10;
            this.hojeBox.TabStop = false;
            this.hojeBox.Click += new System.EventHandler(this.copiar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hoje";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(852, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Clicar na caixa verde copia o texto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hojeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.semanaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resumo";
            this.Text = "Resumo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox semanaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hojeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}