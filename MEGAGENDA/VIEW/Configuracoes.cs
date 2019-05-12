using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MEGAGENDA.MODEL;
using MEGAGENDA.CONTROLLER;

namespace MEGAGENDA.VIEW
{
    public partial class Configuracoes : Form
    {

        Funcionario funcionario;

        public Configuracoes()
        {
            InitializeComponent();

            TopLevel = false;
            Dock = DockStyle.Fill;

            Inicializar();
        }

        private void Inicializar()
        {
            AtualizarFuncionarios();
            AtualizarEmpresa();
        }
        
        private void AtualizarFuncionarios()
        {
            funcionariosBox.Items.Clear();
            foreach (string f in Funcionario.GetAllIdentificadores())
                funcionariosBox.Items.Add(f);
        }

        private void funcionariosDeleteButton_Click(object sender, EventArgs e)
        {
            if (funcionariosBox.Text != "")
                Funcionario.Delete(funcionariosBox.Text);
            funcionariosBox.Text = "";
            AtualizarFuncionarios();
        }

        private void carregarButton_Click(object sender, EventArgs e)
        {
            if (funcionariosBox.Text != "")
            {
                funcionario = Funcionario.Get(funcionariosBox.Text);
                EditarFuncionario();
            }
        }

        private void EditarFuncionario()
        {
            if (funcionario != null)
            {
                identBox.Text = funcionario.identificador;
                nomefBox.Text = funcionario.pessoa.nome;
                cpffBox.Text = funcionario.pessoa.cpf;
                rgfBox.Text = funcionario.pessoa.rg;
                telefonefBox.Text = funcionario.pessoa.telefone;
                facefBox.Text = funcionario.pessoa.facebook;
                emailfBox.Text = funcionario.pessoa.email;
                celularfBox.Text = funcionario.pessoa.celular;

                addButton.Visible = false;
                editButton.Visible = true;
                cancelEditButton.Visible = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (identBox.Text != "")
            {
                funcionario.identificador = identBox.Text;

                funcionario.pessoa.nome = nomefBox.Text;
                funcionario.pessoa.cpf = cpffBox.Text;
                funcionario.pessoa.rg = rgfBox.Text;
                funcionario.pessoa.telefone = telefonefBox.Text;
                funcionario.pessoa.facebook = facefBox.Text;
                funcionario.pessoa.email = emailfBox.Text;
                funcionario.pessoa.celular = celularfBox.Text;

                int result = Funcionario.Edit(funcionario);
                Erro.Mensagem(result, true, "");
                if (result > 0)
                {
                    result = Pessoa.Edit(funcionario.pessoa);
                    if (result > 0)
                        CancelEdit();
                }
            }
        }

        private void CancelEdit()
        {
            funcionario = null;

            identBox.Text = "";
            nomefBox.Text = "";
            cpffBox.Text = "";
            rgfBox.Text = "";
            telefonefBox.Text = "";
            facefBox.Text = "";
            emailfBox.Text = "";
            celularfBox.Text = "";

            addButton.Visible = true;
            editButton.Visible = false;
            cancelEditButton.Visible = false;

            AtualizarFuncionarios();
        }

        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            CancelEdit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (identBox.Text != "")
            {
                Pessoa pessoa = new Pessoa(nomefBox.Text, rgfBox.Text, cpffBox.Text, "M", telefonefBox.Text, celularfBox.Text, emailfBox.Text, facefBox.Text, new Endereco(0), "");
                Funcionario func = new Funcionario(identBox.Text, pessoa);

                int result = Funcionario.Add(func);
                Erro.Mensagem(result, true, "");
                if (result > 0)
                    CancelEdit();
            }
        }

        public void AtualizarEmpresa()
        {
            nomeebox.Text = Configs.Empresa.nome;
            cnpjBox.Text = Configs.Empresa.cnpj;
            enderecoeBox.Text = Configs.Empresa.endereco.manual;
            representanteBox.Text = Configs.Empresa.representante;
            cpfrBox.Text = Configs.Empresa.anotacoes;
            rgrBox.Text = Configs.Empresa.rg;
            telefoneeBox.Text = Configs.Empresa.telefone;
            celulareBox.Text = Configs.Empresa.celular;
            emaileBox.Text = Configs.Empresa.email;
            faceeBox.Text = Configs.Empresa.facebook;
        }

        private void editEmpresaButton_Click(object sender, EventArgs e)
        {
            Configs.Empresa.nome = nomeebox.Text;
            Configs.Empresa.cnpj = cnpjBox.Text;
            Configs.Empresa.endereco.manual = enderecoeBox.Text;
            Configs.Empresa.representante = representanteBox.Text;
            Configs.Empresa.anotacoes = cpfrBox.Text;
            Configs.Empresa.rg = rgrBox.Text;
            Configs.Empresa.telefone = telefoneeBox.Text;
            Configs.Empresa.celular = celulareBox.Text;
            Configs.Empresa.email = emaileBox.Text;
            Configs.Empresa.facebook = faceeBox.Text;

            int result = Pessoa.Edit(Configs.Empresa);
            Erro.Mensagem(result, true, "");
            
        }
    }
}
