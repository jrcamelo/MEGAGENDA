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
            Database.Start();

            //
            Cabine.Add(new Cabine("Primeira"));
            
            int pid = Pessoa.Add(new Pessoa("João", "9084461", "10846444445", "M", "3241-5803", "995363055", "joaorafaelx@gmail.com", "", new Endereco("Rua", "277", "BL D 301", "Tejipió", "Recife", "PE"), "Observ"));

            Evento.Add(new Evento(pid, "Formatura", "João Rafael", 1200, 400, true, "Nido", "Primeira", new Endereco("Rua", "277", "BL D 301", "Tejipió", "Recife", "PE"), DateTime.Today, DateTime.Today, DateTime.Today, 4, true, true, "AGENDADO", "Fornecedores", "Vai ser muito legal", new List<Pagamento>() { new Pagamento(1, 0, DateTime.Today, true, 1), new Pagamento(1, 0, DateTime.Today, false, 2) }));

            Modelo modelo = new Modelo("Padrão");
            modelo.padrao_teste();
            Database.AddModelo(modelo);
            //
                                    
            InitializeComponent();
            PreencherTelas();

            // Tela inicial
            Telas.TrocarTela("Listas");
        }

        public void PreencherTelas()
        {
            Telas.setPrincipal(this);
            Telas.setAgenda(new Agenda());
            Telas.setContratos(new Contratos());
            Telas.setListas(new Listas());
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
    }
}
