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

namespace MEGAGENDA.VIEW
{
    public partial class FormPrincipal : Form
    {

        public Control panelForm;

        VIEW.EditarCliente TelaCliente = new VIEW.EditarCliente();

        public FormPrincipal()
        {
            Debug.Log("\n\nSTART");
            Database.Start();
            LoadEssentials();


            //Test();
            //Test2();

            InitializeComponent();
            PreencherTelas();


            // Inicia listas
            Telas.TrocarTela("Listas");

            // Tela inicial
            Telas.TrocarTela("Resumo");
        }

        public void LoadEssentials()
        {
            Pessoa Empresa = new Pessoa(
                true,
                "Mega Selfie Cabine Fotográfica",
                "25.425.706/0001-26",
                "Ivanildo Fernandes da Silva", "M",
                "4100.1566", "98806.7578",
                "www.megaselfie.net.br / ivanildo@megaselfie.net.br",
                "/fotocabinemegaselfie /",
                 new Endereco("Rua São Mateus, 1060, Condomínio Jardim Renascença, Bl. D, Apto. 302, Iputinga, Recife/PE"),
                "4985734, SSP/PE");                
            Empresa.tipo = "EMPRESA";
            Empresa.rg = "030.099.874 - 04";
            Empresa.endereco.rua = "Rua São Mateus, 1060, Condomínio Jardim Renascença, Bl. D, Apto. 302, Iputinga, Recife/PE";

            Pessoa.Add(Empresa, false); 
            Configs.Empresa = Pessoa.Get(1, false);

            Pessoa nido = new Pessoa("Ivanildo Fernandes da Silva", "030.099.874 - 04", "4985734", "M", "4100.1566", "98806.7578", "ivanildo@megaselfie.net.br", "", new Endereco("Rua São Mateus, 1060, Condomínio Jardim Renascença, Bl. D, Apto. 302, Iputinga, Recife/PE"), "");
            nido.tipo = "FUNCIONARIO";
            Funcionario dono = new Funcionario("Nido", nido);
            Funcionario.Add(dono);

            Cabine.Add(new Cabine("Padrão"));

            Modelo modelo = new Modelo("Padrão", new Dictionary<string, List<string>>());
            modelo.padrao_teste();
            Modelo.Add(modelo, true);

        }

        public void Test()
        {
            //
            Cabine.Add(new Cabine("Padrão"));
            //
        }

        public void Test2()
        {
            Cabine.Add(new Cabine("Primeira"));

            int pid = Pessoa.Add(new Pessoa("João", "9084461", "10846444445", "M", "3241-5803", "995363055", "joaorafaelx@gmail.com", "", new Endereco("Rua", "277", "BL D 301", "Tejipió", "Recife", "PE"), "Observ"));

            Evento.Add(new Evento(pid, "Formatura", "João Rafael", 1200, 400, true, new List<string> { "Nido" }, "Primeira", new Endereco("Rua", "277", "BL D 301", "Tejipió", "Recife", "PE"), DateTime.Today, DateTime.Today, DateTime.Today, 4, true, true, 0, "Vai ser muito legal", new List<Pagamento>() { new Pagamento(1, 0, DateTime.Today, true, 1), new Pagamento(1, 0, DateTime.Today, false, 2) }));

            Modelo modelo = new Modelo("Padrão", new Dictionary<string, List<string>>());
            modelo.padrao_teste();
            Modelo.Add(modelo, true);
        }

        public void PreencherTelas()
        {
            Telas.setPrincipal(this);
            Telas.setAgenda(new Agenda());
            Telas.setContratos(new Contratos());
            Telas.setListas(new Listas());
            Telas.setConfiguracoes(new Configuracoes());
            Telas.setResumo(new Resumo());
        }

        public void ResetForm(object Form)
        {
            panelPrincipal.Controls.Clear();
            panelForm = (Control)Form;
            panelPrincipal.Controls.Add(panelForm);
            panelForm.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void FormPrincipal_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.TrocarTela("Listas");
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.TrocarTela("Agenda");
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.TrocarTela("Contratos");
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.TrocarTela("Configurações");
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.TrocarTela("Resumo");
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreOMEGGENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
