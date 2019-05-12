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
    public partial class EditarCliente : Form
    {

        public bool editando = false;
        int eid = -1;

        public char genero = 'M';
        public int ID = -1;
        public EditarCliente()
        {
            InitializeComponent();
            int idtemp = 0;
            idLabel.Text = idtemp.ToString();
            editando = false;
            deletarButton.Enabled = false;

            Iniciar();
        }

        public EditarCliente(MODEL.Pessoa cliente)
        {
            InitializeComponent();
            editando = true;

            ID = cliente.ID;
            eid = cliente.endereco.id;
            eidLabel.Text = eid.ToString();
            nomeBox.Text = cliente.nome;
            if (cliente.isJuridica)
            {
                telaJuridica();
                cnpjBox.Text = cliente.cnpj;
                representanteBox.Text = cliente.representante;
            }
            else
            {
                cpfBox.Text = cliente.cpf;
                rgBox.Text = cliente.rg;
            }

            genero = cliente.genero.ToUpper()[0];
            if (genero == 'F')
            {
                masculinoBox.BackgroundImage = Properties.Resources.Border;
                femininoBox.BackgroundImage = Properties.Resources.Glow;
            }

            telefoneBox.Text = cliente.telefone;
            emailBox.Text = cliente.email;
            celularBox.Text = cliente.celular;
            faceBox.Text = cliente.facebook;

            ruaBox.Text = cliente.endereco.rua;
            numeroBox.Text = cliente.endereco.numero;
            bairroBox.Text = cliente.endereco.bairro;
            cidadeBox.Text = cliente.endereco.cidade;
            ufBox.Text = cliente.endereco.estado;
            compBox.Text = cliente.endereco.complemento;

            anotacoesBox.Text = cliente.anotacoes;

            Iniciar();
        }

        private void Iniciar()
        {
            idLabel.Text = ID.ToString();
            
            representanteLabel.Show();
            representanteLabel.Text = "Anotações";
            anotacoesLabel.Hide();

            anotacoesPicture.Size = new Size(261, 174);
            anotacoesBox.Size = new Size(236, 127);

            anotacoesPicture.Location = representantePicture.Location;
            anotacoesBox.Location = representanteBox.Location;

            if (genero == 'F')
            {
                masculinoBox.BackgroundImage = Properties.Resources.Border;
                femininoBox.BackgroundImage = Properties.Resources.Glow;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(telefoneBox.Text, "[0-9]"))
            {
                telefoneBox.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(telefoneBox.Text, "[0-9]"))
            {
                emailBox.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool isJuridica = false;
        private void juridicaButton_Click(object sender, EventArgs e)
        {
            isJuridica = true;
            telaJuridica();
        }
        private void telaJuridica()
        {
            fisicaButton.BackgroundImage = Properties.Resources.Border;
            juridicaButton.BackgroundImage = Properties.Resources.Glow;

            cnpjBox.Visible = true;
            cpfBox.Visible = false;
            rgBox.Visible = false;
            cpfcnpjPicture.Size = new Size(261, 54);
            cpfcnpjLabel.Text = "CNPJ";
            //cpfBox.Text = "";

            representanteBox.Show();
            representantePicture.Show();
            generoLabel.Text = "Gênero do Representante";

            representanteLabel.Text = "Nome do Representante";
            anotacoesLabel.Show();

            anotacoesPicture.Size = new Size(261, 114);
            anotacoesBox.Size = new Size(236, 71);

            anotacoesPicture.Location = new Point(557, 132);
            anotacoesBox.Location = new Point(570, 160);
        }

        private void fisicaButton_Click(object sender, EventArgs e)
        {
            isJuridica = false;
            fisicaButton.BackgroundImage = Properties.Resources.Glow;
            juridicaButton.BackgroundImage = Properties.Resources.Border;

            cnpjBox.Visible = false;
            cpfBox.Visible = true;
            rgBox.Visible = true;
            cpfcnpjPicture.Size = new Size(137, 54);
            cpfcnpjLabel.Text = "CPF";

            representanteBox.Hide();
            representantePicture.Hide();
            generoLabel.Text = "Gênero";

            representanteLabel.Text = "Anotações";
            anotacoesLabel.Hide();

            anotacoesPicture.Size = new Size(261, 174);
            anotacoesBox.Size = new Size(236, 127);

            anotacoesPicture.Location = representantePicture.Location;
            anotacoesBox.Location = representanteBox.Location;
        }

        private void masculinoBox_Click(object sender, EventArgs e)
        {
            genero = 'M';
            masculinoBox.BackgroundImage = Properties.Resources.Glow;
            femininoBox.BackgroundImage = Properties.Resources.Border;

        }

        private void femininoBox_Click(object sender, EventArgs e)
        {
            genero = 'F';
            masculinoBox.BackgroundImage = Properties.Resources.Border;
            femininoBox.BackgroundImage = Properties.Resources.Glow;

        }

        private void cpfcnpjBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rgBox_TextChanged(object sender, EventArgs e)
        {

        }

        private Pessoa fazerCliente()
        {
            Endereco endereco = new Endereco(ruaBox.Text, numeroBox.Text, compBox.Text, bairroBox.Text, cidadeBox.Text, ufBox.Text, eid);

            Pessoa cliente;
            if (isJuridica)
            {
                cliente = new Pessoa(true, nomeBox.Text, cnpjBox.Text, representanteBox.Text, genero.ToString(),
                    telefoneBox.Text, celularBox.Text, emailBox.Text, faceBox.Text, endereco, anotacoesBox.Text, ID);
            }
            else
            {
                cliente = new Pessoa(nomeBox.Text, rgBox.Text, cpfBox.Text, genero.ToString(),
                    telefoneBox.Text, celularBox.Text, emailBox.Text, faceBox.Text, endereco, anotacoesBox.Text, ID);
            }

            return cliente;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            Pessoa cliente = fazerCliente();

            int result;
            if (editando)
                result = Pessoa.Edit(cliente);
            else
                result = Pessoa.Add(cliente);

            Erro.Mensagem(result);
            if (result > 0)
            {
                Telas.getListas().PreencherCliente();
                Telas.getListas().SelectRowCliente(result);
                AntesDispose();
                this.Dispose();
            }
        }

        private void deletarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que vai DELETAR para SEMPRE este Cliente e SEUS EVENTOS?", "Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int erro = Pessoa.Delete(ID);
                Erro.Mensagem(erro, false);

                if (erro > 0)
                {
                    AntesDispose();
                    this.Dispose();
                }
            }
        }

        private void EditarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            AntesDispose();
        }

        private void AntesDispose()
        {
            Telas.getListas().PreencherCliente();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            AntesDispose();
            this.Dispose();
        }

        Color badcolor = Color.FromArgb(255, 192, 192);
        Color goodcolor = Color.FromArgb(250, 248, 255);
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "")
                box.BackColor = badcolor;
            else
                box.BackColor = goodcolor;
        }
    }
}
