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
        
        public string secao_carregada;
        
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

            foreach (KeyValuePair<string, string> word in Editor.Preparar_Keywords())
                keywordsList.Items.Add(word.Key);
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
            secaoComboBox.Text = "";
            clausulaNumeric.Value = 1;

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
            SalvarClausula();

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
            SalvarClausula();
            Modelo novo_modelo = new Modelo(novoModeloBox.Text, modelo.Clausulas);
            int error = Modelo.Add(novo_modelo);
            if (error < 0)
            {
                MessageBox.Show(error.ToString());
            }
            else
            {
                MessageBox.Show(novoModeloBox.Text + " criado com sucesso!");

                LerModelos();
                modeloBox.SelectedItem = novoModeloBox.Text;
                Carregar_Modelo();
            }
        }

        private void novoModeloBox_TextChanged(object sender, EventArgs e)
        {
            if (novoModeloBox.Text.Trim() == "" || modelo == null)
            {
                novoModeloButton.Enabled = false;
            }
            else
            {
                novoModeloButton.Enabled = true;
            }
        }
        private void modeloBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeloBox.SelectedItem != null)
            {
                Carregar_Modelo();
                MostrarClausula();
            }
        }
        private void salvarModeloButton_Click(object sender, EventArgs e)
        {
            if (modelo != null)
            {
                SalvarClausula();

                if (MessageBox.Show("Você tem certeza que deseja sobrescrever este modelo?", "Sobrescrever", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int erro = Modelo.Update(modelo);
                    if (erro < 0)
                        MessageBox.Show(erro.ToString());
                    else
                        MessageBox.Show("Modelo atualizado com sucesso");
                }
            }
        }

        private void SalvarClausula()
        {
            if (secaoComboBox.Text != "")
                modelo.Clausulas[secaoComboBox.Text][(int)clausulaNumeric.Value - 1] = clausulaBox.Text; 
        }
        
        private void MostrarClausula()
        {
            if (secaoComboBox.Text != "")
                clausulaBox.Text = modelo.Clausulas[secaoComboBox.Text][(int)clausulaNumeric.Value - 1];
            else
                clausulaBox.Text = "";
            SubstituirPreview();
        }

        private void SubstituirPreview()
        {
            if (clausulaBox.Text == "")
                previewBox.Text = "";
            else
            {
                if (cliente != null && evento != null)
                    previewBox.Text = Editor.Substituir_Clausula(clausulaBox.Text, cliente, evento);
                else
                    previewBox.Text = clausulaBox.Text;

            }
        }
        
        private void secaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secaoComboBox.Text != "")
            {
                clausulaNumeric.Value = 1;
                MostrarClausula();
            }
        }

        private void secaoComboBox_Click(object sender, EventArgs e)
        {
            SalvarClausula();
        }

        private void clausulaNumeric_ValueChanged(object sender, EventArgs e)
        {
            MostrarClausula();
        }

        private void clausulaBox_TextChanged(object sender, EventArgs e)
        {
            SalvarClausula();
            SubstituirPreview();
        }
    }
}
