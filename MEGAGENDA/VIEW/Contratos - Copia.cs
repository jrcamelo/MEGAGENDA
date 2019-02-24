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

        public Contrato contrato = null;

        public Evento evento = null;
        public Pessoa cliente = null;

        List<TextBox> BoxesClausulas = new List<TextBox>();
        List<CheckBox> ChecksClausulas = new List<CheckBox>();

        public string secao_carregada;
        
        public Contratos()
        {
            InitializeComponent();

            TopLevel = false;
            Dock = DockStyle.Fill;

            Ler_Modelos();
            Ler_Arquivos();

            BoxesClausulas.Add(clausula1Box);
            BoxesClausulas.Add(clausula2Box);
            BoxesClausulas.Add(clausula3Box);
            BoxesClausulas.Add(clausula4Box);
            BoxesClausulas.Add(clausula5Box);
            BoxesClausulas.Add(clausula6Box);
            BoxesClausulas.Add(clausula7Box);
            BoxesClausulas.Add(clausula8Box);
            BoxesClausulas.Add(clausula9Box);
            BoxesClausulas.Add(clausula10Box);

            ChecksClausulas.Add(clausula1Check);
            ChecksClausulas.Add(clausula2Check);
            ChecksClausulas.Add(clausula3Check);
            ChecksClausulas.Add(clausula4Check);
            ChecksClausulas.Add(clausula5Check);
            ChecksClausulas.Add(clausula6Check);
            ChecksClausulas.Add(clausula7Check);
            ChecksClausulas.Add(clausula8Check);
            ChecksClausulas.Add(clausula9Check);
            ChecksClausulas.Add(clausula10Check);

            Carregar_Modelo();
            
            arquivoBox.Items.Add("Padrão");
            arquivoBox.SelectedItem = "Padrão";

        }

        private void Ler_Modelos()
        {
            foreach (string nome_modelo in Database.GetListaModelos())
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
        private void Ler_Arquivos() { }

        private void Carregar_Modelo()
        {
            if (modeloBox.SelectedItem == null)
            {
                modeloBox.SelectedIndex = 0;
            }
            
            modelo = Database.GetModelo(modeloBox.SelectedItem.ToString());
            Limpar_Secao();
            Carregar_Clausulas();

            salvarModeloButton.Enabled = true;
            novoModeloBox.Enabled = true;
        }

        private void Carregar_Secao()
        {
            Console.Out.WriteLine(modelo.Nome);

            Console.Out.WriteLine("PADRÃO - " + Database.GetModelo("Padrão").Clausulas["CONTRATO"][1]);
            Console.Out.WriteLine("DB - " + Database.GetModelo(modeloBox.SelectedItem.ToString()).Clausulas["CONTRATO"][1]);
            Console.Out.WriteLine("MODELO - " + modelo.Clausulas["CONTRATO"][1]);

            if (secaoBox.SelectedItem != null && modelo != null)
            {
                if (secao_carregada != null)
                {
                    Salvar_Clausulas();
                }

                secao_carregada = secaoBox.SelectedItem.ToString();
                Carregar_Clausulas();                
            }
        }

        private void Limpar_Secao()
        {
            secao_carregada = "";
            if (secaoBox.SelectedItem != null)
            {
                secaoBox.ClearSelected();
            }

        }

        private void Salvar_Clausulas()
        {
            List<string> novas_clausulas = new List<string>();

            for (int i = 0; i < Modelo.MAXCLAUSULAS; i++)
            {
                if (ChecksClausulas[i].Checked == true && BoxesClausulas[i].Text != "")
                {
                    novas_clausulas.Add(BoxesClausulas[i].Text);
                }
                else
                {
                    novas_clausulas.Add(null);
                }
            }

            modelo.Clausulas[secao_carregada] = novas_clausulas;
        }

        private void Carregar_Clausulas()
        {
            if (secao_carregada == "")
            {
                if (secaoBox.SelectedItem != null)
                {
                    secaoBox.ClearSelected();
                }

                foreach (TextBox box in BoxesClausulas)
                {
                    box.Text = "";
                }

                foreach (CheckBox check in ChecksClausulas)
                {
                    check.Checked = true;
                }
            }
            else
            {
                List<string> clausulas = modelo.Clausulas[secao_carregada];
                if (clausulas != null)
                {
                    for (int i = 0; i < Modelo.MAXCLAUSULAS; i++)
                    {
                        if (clausulas[i] != null)
                        {
                            ChecksClausulas[i].Checked = true;
                            BoxesClausulas[i].Text = clausulas[i];
                        }
                        else
                        {
                            ChecksClausulas[i].Checked = false;
                            BoxesClausulas[i].Text = "";
                        }
                    }
                }
            }            
        }

        private void eidNumeric_ValueChanged(object sender, EventArgs e)
        {
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
                        clienteLabel.Text = "CLIENTE NÃO ENCONTRADO";
                        criarContratoBox.Enabled = false;
                    }
                }
                else
                {
                    clienteLabel.Text = "CLIENTE NÃO ENCONTRADO";
                    criarContratoBox.Enabled = false;
                }
            }
        }
        
        private void secaoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secaoBox.SelectedItem != null)
            {
                Carregar_Secao();
            }
        }
        
        private void criarContratoBox_Click(object sender, EventArgs e)
        {
            Salvar_Clausulas();

            try
            {
                Editor.Fazer_Contrato(arquivoBox.Text, secaoBox.Items, modelo, cliente, evento);

            }
            catch (IOException except)
            {
                MessageBox.Show(except.Message);
            }

        }
        
        private void novoModeloButton_Click(object sender, EventArgs e)
        {
            Salvar_Clausulas();

            Modelo novo_modelo = null;
            novo_modelo = modelo.Clone();

            novo_modelo.Nome = novoModeloBox.Text;
            string error = Database.AddModelo(novo_modelo);
            if (error != "")
            {
                MessageBox.Show(error);
            }
            else
            {
                Ler_Modelos();
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
            }
        }
        private void salvarModeloButton_Click(object sender, EventArgs e)
        {
            if (modelo != null)
            {
                Salvar_Clausulas();

                if (MessageBox.Show("Você tem certeza que deseja sobrescrever este modelo?", "Sobrescrever", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string erro = Database.EditModelo(modelo);
                    if (erro != "")
                    {
                        MessageBox.Show(erro);
                    }
                }
            }
        }

        private void Marcar_CheckBox(int i)
        {
            ChecksClausulas[i].Checked = BoxesClausulas[i].Text != "";
        }

        private void clausula1Box_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            Marcar_CheckBox(i);
        }

        private void clausula2Box_TextChanged(object sender, EventArgs e)
        {
            int i = 1;
            Marcar_CheckBox(i);
        }

        private void clausula3Box_TextChanged(object sender, EventArgs e)
        {
            int i = 2;
            Marcar_CheckBox(i);
        }

        private void clausula4Box_TextChanged(object sender, EventArgs e)
        {
            int i = 3;
            Marcar_CheckBox(i);
        }

        private void clausula5Box_TextChanged(object sender, EventArgs e)
        {
            int i = 4;
            Marcar_CheckBox(i);
        }

        private void clausula6Box_TextChanged(object sender, EventArgs e)
        {
            int i = 5;
            Marcar_CheckBox(i);
        }

        private void clausula7Box_TextChanged(object sender, EventArgs e)
        {
            int i = 6;
            Marcar_CheckBox(i);
        }

        private void clausula8Box_TextChanged(object sender, EventArgs e)
        {
            int i = 7;
            Marcar_CheckBox(i);
        }

        private void clausula9Box_TextChanged(object sender, EventArgs e)
        {
            int i = 8;
            Marcar_CheckBox(i);
        }

        private void clausula10Box_TextChanged(object sender, EventArgs e)
        {
            int i = 9;
            Marcar_CheckBox(i);
        }

    }
}
