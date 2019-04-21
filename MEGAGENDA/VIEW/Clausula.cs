using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEGAGENDA.CONTROLLER;

namespace MEGAGENDA.VIEW
{
    public partial class Clausula : UserControl
    {
        private Contratos Tela;
        public string Secao;
        public int Numero;

        public Clausula(Contratos parent, string secao, int numero, string texto)
        {
            InitializeComponent();
            Tela = parent;
            Secao = secao;
            Numero = numero;
            numeroLabel.Text = "Cláusula " + numero.ToString();
            editBox.Text = texto;
            SubstituirPreview();     
        }
        

        private void editBox_TextChanged(object sender, EventArgs e)
        {
            SubstituirPreview();
        }        

        public void SubstituirPreview()
        {
            if (editBox.Text == "")
                previewBox.Text = "";
            else
            {
                if (Tela.cliente != null && Tela.evento != null)
                    previewBox.Text = Editor.Substituir_Clausula(editBox.Text, Tela.cliente, Tela.evento);
                else
                    previewBox.Text = editBox.Text;
            }
        }

        private void Clausula_Scroll(object sender, ScrollEventArgs e)
        {
            Tela.flowPanel.Focus();
            Tela.flowPanel.Select();
        }

        private void numeroLabel_Click(object sender, EventArgs e)
        {
            Tela.flowPanel.Focus();
            Tela.flowPanel.Select();
        }
    }
}
