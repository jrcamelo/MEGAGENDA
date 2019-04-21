using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MEGAGENDA.CONTROLLER;
using MEGAGENDA.MODEL;
using Spire.Doc;
using Spire.Doc.Documents;
using System.IO;

namespace MEGAGENDA.VIEW
{
    public partial class Contratos : Form
    {
        public Modelo modelo;
        public string modelo_nome = "";

        public Evento evento = null;
        public Pessoa cliente = null;

        public string secao_carregada = "";
        public Clausula[] clausulas = new Clausula[Modelo.MAXCLAUSULAS];

        public Contratos()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            InitializeComponent();

            TopLevel = false;
            Dock = DockStyle.Fill;

            LerModelos();
            LerArquivos();

            Carregar_Modelo();

            arquivoBox.Items.Add("Padrão");
            arquivoBox.SelectedItem = "Padrão";

            //foreach (KeyValuePair<string, string> word in Editor.Preparar_Keywords())
            //    keywordsList.Items.Add(word.Key);
        }

        private void LerModelos()
        {
            foreach (string nome_modelo in Modelo.GetNames())
            {
                if (!modeloBox.Items.Contains(nome_modelo))
                {
                    modeloBox.Items.Add(nome_modelo);
                }

                if (modeloBox.SelectedItem == null)
                {
                    modeloBox.SelectedIndex = 0;
                }
            }
        }
        private void LerArquivos() { }

        private void Carregar_Modelo()
        {
            if (modeloBox.SelectedItem == null)
            {
                modeloBox.SelectedIndex = 0;
            }

            modelo = Modelo.Get(modeloBox.SelectedItem.ToString());
            secaoBox.ResetText();

            salvarModeloButton.Enabled = true;
            novoModeloBox.Enabled = true;
        }

        private void eidNumeric_ValueChanged(object sender, EventArgs e)
        {
            MudarEvento();
        }

        public void MudarEvento(int id = 0)
        {
            if (id != 0)
                eidNumeric.Value = id;

            if (eidNumeric.Value == 0)
            {
                clienteLabel.Text = "Nome do Cliente";
                criarContratoBox.Enabled = false;
                cliente = null;
            }
            else
            {
                evento = Evento.Get((int)eidNumeric.Value);
                if (evento != null)
                {
                    cliente = Pessoa.Get(evento.PID);
                    if (cliente != null)
                    {
                        clienteLabel.Text = cliente.nome;
                        criarContratoBox.Enabled = true;
                    }
                    else
                    {
                        clienteLabel.Text = "EVENTO NÃO ENCONTRADO";
                        criarContratoBox.Enabled = false;
                    }
                }
                else
                {
                    clienteLabel.Text = "EVENTO NÃO ENCONTRADO";
                    criarContratoBox.Enabled = false;
                }
            }
            SubstituirPreview();
        }


        private void criarContratoBox_Click(object sender, EventArgs e)
        {
            SalvarClausulas();
            try
            {
                Editor.Fazer_Contrato(arquivoBox.Text, modelo, cliente, evento);
            }
            catch (IOException except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void novoModeloButton_Click(object sender, EventArgs e)
        {
            SalvarClausulas();

            Modelo novo_modelo = new Modelo(novoModeloBox.Text, modelo.Clausulas);
            int error = Modelo.Add(novo_modelo);
            Erro.Mensagem(error, true, "");
            if (error >= 0)
            {
                LerModelos();
                modeloBox.SelectedItem = novoModeloBox.Text;
                Carregar_Modelo();
            }
        }

        private void novoModeloBox_TextChanged(object sender, EventArgs e)
        {
            if (novoModeloBox.Text.Trim() == "" || modelo == null)
                novoModeloButton.Enabled = false;
            else
                novoModeloButton.Enabled = true;
        }

        private void modeloBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeloBox.SelectedItem != null)
            {
                SalvarClausulas();
                Carregar_Modelo();
                MostrarClausulas();
            }
        }
        private void salvarModeloButton_Click(object sender, EventArgs e)
        {
            if (modelo != null)
            {
                SalvarClausulas();

                if (MessageBox.Show("Você tem certeza que deseja sobrescrever este modelo?", "Sobrescrever", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int erro = Modelo.Update(modelo);
                    Erro.Mensagem(erro, true, "");
                }
            }
        }

        private void MostrarClausulas()
        {
            if (secao_carregada == "" || modelo == null) return;
            secaoBox.Enabled = false;

            flowPanel.Controls.Clear();
            clausulas = new Clausula[10];

            for (int i = 0; i < Modelo.MAXCLAUSULAS; i++)
            {
                string texto = modelo.Clausulas[secao_carregada][i];
                clausulas[i] = new Clausula(this, secao_carregada, i + 1, texto);
            }
            
            flowPanel.Controls.AddRange(clausulas);
            secaoBox.Enabled = true;
        }
        
        private void SalvarClausulas()
        {
            Console.WriteLine($"SALVAR {secao_carregada}");
            if (secaoBox.Text != "" && modelo != null)
                foreach (Clausula c in clausulas)
                    if (c != null)
                        modelo.Clausulas[c.Secao][c.Numero - 1] = c.editBox.Text;
        }
        

        private void SubstituirPreview()
        {
            foreach (Clausula clausula in clausulas)
                if (clausula != null)
                    clausula.SubstituirPreview();
        }
        
        private void flowPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Clausula clausula in clausulas)
            {
                if (clausula != null)
                    clausula.Width = flowPanel.Width - 30;
            }
        }

        private void secaoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secao_carregada == secaoBox.Text) return;
            SalvarClausulas();

            secao_carregada = secaoBox.Text;
            if (secaoBox.Text != "")
            {
                MostrarClausulas();
            }
            flowPanel.Select();
            flowPanel.Focus();
        }
    }
}
