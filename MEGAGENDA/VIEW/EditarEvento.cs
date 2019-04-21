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
    public partial class EditarEvento : Form
    {

        int id = -1;
        int pid = -1;
        int eid = -1;
        int peid = -1;

        bool guestbook = true;
        int situacao = 2;

        bool editando = false;

        DateTimePicker oDateTimePicker = new DateTimePicker();
        Rectangle _Rectangle;

        public EditarEvento()
        {
            InitializeComponent();
            deletarButton.Hide();

            editando = false;

            contratanteLabel.Text = "SELECIONE UM CLIENTE!";
            deletarButton.Visible = false;

            Inicializar();
            MudarID();

            pidBox.Show();
        }

        public EditarEvento(int pid, string nome)
        {
            InitializeComponent();

            Inicializar();
            MudarID();
            MudarCliente(pid);
            CarregarCliente();

            pidLabel.Text = "ID: " + pid;
            contratanteLabel.Text = nome;
            deletarButton.Visible = false;
        }

        public EditarEvento(Evento evento)
        {
            InitializeComponent();
            editando = true;

            Inicializar();
            InicializarEditar(evento);

            LerEquipe(evento.equipe);
            LerPagamentos(evento.pagamentos);
        }

        public void Inicializar()
        {
            foreach (string tipo in Evento.GetAllTipos())
                tipoBox.Items.Add(tipo);

            foreach (string cab in Cabine.GetAll())
                cabineBox.Items.Add(cab);

            foreach (var funci in Funcionario.GetAllIdentificadores())
                equipeComboBox.Items.Add(new CheckComboBoxItem(funci, false));

            pagamentosGrid.Controls.Add(oDateTimePicker);
            oDateTimePicker.Visible = false;
            oDateTimePicker.Format = DateTimePickerFormat.Custom;
            oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);
        }

        public void InicializarEditar(Evento evento)
        {

            this.Name = "Editar Evento";
            editando = true;

            MudarID(evento.ID);
            MudarCliente(evento.PID);

            eid = evento.local.id;
            ChecarEnderecoCliente();

            idLabel.Text = "ID: " + evento.ID.ToString();
            eidLabel.Text = eid.ToString();

            situacao = evento.situacao;
            AtualizarSituacao();

            guestbook = evento.guestbook;
            if (!guestbook)
            {
                guestNaoButton.BackgroundImage = Properties.Resources.Glow;
                guestSimButton.BackgroundImage = Properties.Resources.Border;
            }

            pidLabel.Text = "ID: " + evento.PID.ToString();

            tipoBox.Text = evento.tipo;
            dataPicker.Value = evento.data;

            horaCabine.Value = evento.horaCabine;
            horaEvento.Value = evento.horaEvento;

            protagonistaBox.Text = evento.protagonista;
            valorBox.Value = (decimal)evento.valor;
            entradaBox.Value = (decimal)evento.entrada;
            entradaCheck.Checked = evento.entradaQuitada;
            obserBox.Text = evento.observacoes;
            materialBox.Checked = evento.material;

            ruaBox.Text = evento.local.rua;
            numeroBox.Text = evento.local.numero;
            bairroBox.Text = evento.local.bairro;
            cidadeBox.Text = evento.local.cidade;
            ufBox.Text = evento.local.estado;
            compBox.Text = evento.local.complemento;

            cabineBox.Text = evento.cabine;
        }

        public void MudarID(int ID = 0)
        {
            if (ID == 0)
                ID = id;
            else
                id = ID;

            idLabel.Text = "ID: " + id.ToString();
        }

        private void CarregarCliente()
        {
            Pessoa cliente = Pessoa.GetwEndereco(pid);
            protagonistaBox.Text = cliente.nome;
            eid = cliente.endereco.id;
            MudarEndereco(eid);
        }

        private void MudarCliente(int PID)
        {
            Pessoa cliente = Pessoa.Get(PID);
            if (cliente != null)
            {
                contratanteLabel.Text = cliente.nome;
                pid = PID;
                peid = cliente.endereco.id;
            }
            else
            {
                contratanteLabel.Text = "SELECIONE UM CLIENTE!";
                pid = 0;
            }
        }

        private bool MudarEndereco(int EID)
        {
            Endereco local = Endereco.Get(EID);
            if (local != null)
            {
                ruaBox.Text = local.rua;
                numeroBox.Text = local.numero;
                bairroBox.Text = local.bairro;
                cidadeBox.Text = local.cidade;
                ufBox.Text = local.estado;
                compBox.Text = local.complemento;
                eid = local.id;
                eidLabel.Text = eid.ToString();

                return true;
            }
            return false;
        }

        private void ChecarEnderecoCliente(bool mudar = false)
        {
            if (pid > 0 && peid > 0)
            {
                if (eid == peid)
                {
                    if (mudar)
                    {
                        ligarEnderecoButton.Text = "Ligar ao Endereço do Cliente";
                        eid = 0;
                        eidLabel.Text = eid.ToString();
                    }
                    else
                    {
                        ligarEnderecoButton.Text = "Separar do Endereço do Cliente";
                    }
                }
                else
                {
                    if (mudar)
                    {
                        ligarEnderecoButton.Text = "Separar do Endereço do Cliente";
                        MudarEndereco(peid);
                    }
                    else
                    {
                        ligarEnderecoButton.Text = "Ligar ao Endereço do Cliente";
                    }
                }
            }
        }

        public void LerEquipe(List<string> equipe)
        {
            foreach (string funci in equipe)
                foreach (CheckComboBoxItem item in equipeComboBox.Items)
                    if (item.Text == funci)
                        item.CheckState = true;
            atualizarEquipe();
        }

        public void LerPagamentos(List<Pagamento> pagamentos)
        {
            foreach (Pagamento pag in pagamentos)
                pagamentosGrid.Rows.Add(pag.data.ToShortDateString(), pag.valor, pag.pago);
        }

        private void AtualizarSituacao()
        {
            switch (situacao)
            {
                case 0:
                    situacaoLabel.Text = "FINALIZADO";
                    situacaoLabel.ForeColor = Color.Black;
                    situacaoAgendarButton.Enabled = true;
                    situacaoFinalizarButton.Enabled = false;
                    situacaoPossivelButton.Enabled = true;
                    break;
                case 1:
                    situacaoLabel.Text = "AGENDADO";
                    situacaoLabel.ForeColor = Color.DarkGreen;
                    situacaoAgendarButton.Enabled = false;
                    situacaoFinalizarButton.Enabled = true;
                    situacaoPossivelButton.Enabled = true;
                    break;
                case 2:
                default:
                    situacaoLabel.Text = "NÃO CONFIRMADO";
                    situacaoLabel.ForeColor = Color.DarkGray;
                    situacaoAgendarButton.Enabled = true;
                    situacaoFinalizarButton.Enabled = true;
                    situacaoPossivelButton.Enabled = false;
                    break;
            }
        }

        private void parcelaAutoButton_Click(object sender, EventArgs e)
        {
            pagamentosGrid.Rows.Clear();

            decimal valor = valorBox.Value;
            DateTime parcela = parcelaPrimeiraBox.Value.Date;
            int qtd = (int)parcelaQtdBox.Value;

            decimal valorParcela = valor / qtd;

            for (int i = 0; i < qtd; i++)
            {
                pagamentosGrid.Rows.Add(parcela.ToShortDateString(), valorParcela.ToString("0.00"), false);
                parcela = parcela.AddMonths(1);
            }
            ChecarParcelas();
        }

        public void ChecarParcelas()
        {
            if (pagamentosGrid.Rows.Count > 0)
            {
                double valor = (double)valorBox.Value;
                double total = 0;
                double result = 0;
                for (int i = 0; i < pagamentosGrid.Rows.Count; i++)
                {
                    object v = pagamentosGrid.Rows[i].Cells[1].Value;
                    if (v != null)
                    {
                        double.TryParse(pagamentosGrid.Rows[i].Cells[1].Value.ToString(), out result);
                        total += result;

                        if (result == 0)
                        {
                            total = 0;
                            pagamentosLabel.Text = "Parcela zerada ou errada";
                            pagamentosLabel.ForeColor = Color.Red;
                            break;
                        }
                    }
                }
                pagamentosLabel.Text = "Pagamentos";
                pagamentosLabel.ForeColor = Color.Black;

                if (total > 0)
                {
                    pagamentosLabel.ForeColor = Color.Red;
                    if (total + 1 < valor)
                        pagamentosLabel.Text = "Soma MENOR que o contrato";
                    else
                    {
                        if (total - 1 > valor)
                            pagamentosLabel.Text = "Soma MAIOR que o contrato";
                        else
                        {
                            pagamentosLabel.Text = "Pagamentos";
                            pagamentosLabel.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        private Evento FazerEvento()
        {
            List<Pagamento> pagamentos = FazerPagamentos();

            Endereco local = FazerLocal();

            return new Evento(pid, tipoBox.Text, protagonistaBox.Text, (double)valorBox.Value, (double)entradaBox.Value, entradaCheck.Checked,
                FazerEquipe(), cabineBox.Text, local, dataPicker.Value, horaCabine.Value, horaEvento.Value, (int)numericDuracao.Value, guestbook, materialBox.Checked,
                situacao, obserBox.Text, pagamentos, id);
        }

        private Endereco FazerLocal()
        {
            return new Endereco(ruaBox.Text, numeroBox.Text, compBox.Text, bairroBox.Text, cidadeBox.Text, ufBox.Text, eid);
        }

        private List<Pagamento> FazerPagamentos()
        {
            List<Pagamento> pagamentos = new List<Pagamento>();

            int count = 1;
            pagamentosGrid.Sort(data, ListSortDirection.Ascending);
            foreach (DataGridViewRow row in pagamentosGrid.Rows)
            {
                double parcelaValor = 0;
                DateTime parcelaData = DateTime.MinValue;
                bool parcelaPaga = false;

                if (row.Cells["data"].Value != null)
                    DateTime.TryParse(row.Cells["data"].Value.ToString(), out parcelaData);

                if (row.Cells["Valor"].Value != null)
                    double.TryParse(row.Cells["Valor"].Value.ToString(), out parcelaValor);

                if (row.Cells["Paga"].Value != null)
                    bool.TryParse(row.Cells["Paga"].Value.ToString(), out parcelaPaga);

                if (parcelaData != DateTime.MinValue)
                {
                    pagamentos.Add(new Pagamento(id, parcelaValor, parcelaData, parcelaPaga, count));
                    count++;
                }
            }

            return pagamentos;
        }

        public List<string> FazerEquipe()
        {
            List<string> result = new List<string>();
            foreach (CheckComboBoxItem func in equipeComboBox.Items)
            {
                if (func.CheckState)
                    result.Add(func.Text);
            }
            return result;
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            Evento evento = FazerEvento();

            int result;
            if (editando)
                result = Evento.Edit(evento);
            else
                result = Evento.Add(evento);

            Erro.Mensagem(result);
            if (result > 0)
            {
                Telas.getListas().PreencherEvento();
                Telas.getListas().SelectRowEvento(result);
            }
            AntesDispose();
            this.Dispose();

        }

        private void deletarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que vai DELETAR para SEMPRE este evento?", "Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int erro = Evento.Delete(id);
                Erro.Mensagem(erro, false);
                if (erro > 0)
                { 
                    AntesDispose();
                    this.Dispose();
                }
            }
        }

        private void pagamentosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oDateTimePicker.Visible = false;
        }
        private void pagamentosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    if (pagamentosGrid.CurrentCell.RowIndex >= 0)
                    {
                        DateTime date = DateTime.Today;

                        _Rectangle = pagamentosGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        oDateTimePicker.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        oDateTimePicker.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        oDateTimePicker.Visible = true;

                        if (pagamentosGrid.CurrentCell.Value != null)
                            DateTime.TryParse(pagamentosGrid.CurrentCell.Value.ToString(), out date);
                        oDateTimePicker.CloseUp += oDateTimePicker_CloseUp;
                        oDateTimePicker.Value = date;
                        pagamentosGrid.CurrentCell.Value = oDateTimePicker.Text.ToString();
                    }
                    break;
                default:
                    break;
            }
        }

        private void guestSimButton_Click(object sender, EventArgs e)
        {
            guestbook = true;
            guestSimButton.BackgroundImage = Properties.Resources.Glow;
            guestNaoButton.BackgroundImage = Properties.Resources.Border;
        }

        private void guestNaoButton_Click(object sender, EventArgs e)
        {
            guestbook = false;
            guestNaoButton.BackgroundImage = Properties.Resources.Glow;
            guestSimButton.BackgroundImage = Properties.Resources.Border;
        }

        private void pagamentosGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChecarParcelas();
        }
        private void valorBox_ValueChanged(object sender, EventArgs e)
        {
            ChecarParcelas();
        }

        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            pagamentosGrid.CurrentCell.Value = oDateTimePicker.Text.ToString();
        }
        void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   
            oDateTimePicker.Visible = false;
        }

        private void pagamentosGrid_Leave(object sender, EventArgs e)
        {
            oDateTimePicker.Visible = false;
        }

        private void equipeComboBox_CheckStateChanged(object sender, EventArgs e)
        {
            atualizarEquipe();
        }

        private void atualizarEquipe()
        {
            equipeTextBox.Text = "";
            foreach (CheckComboBoxItem item in equipeComboBox.Items)
            {
                if (item.CheckState)
                {
                    equipeTextBox.Text += item.Text + "/";
                }
            }
        }

        private void equipeTextBox_Click(object sender, EventArgs e)
        {
            equipeComboBox.DroppedDown = true;
            equipeComboBox.Focus();
        }

        private void copiarLocalButton_Click(object sender, EventArgs e)
        {
            ChecarEnderecoCliente(true);
        }

        private void pidBox_ValueChanged(object sender, EventArgs e)
        {
            MudarCliente((int)pidBox.Value);
        }


        private void cancelarButton_Click(object sender, EventArgs e)
        {
            AntesDispose();
            this.Dispose();
        }

        private void EditarEvento_FormClosing(object sender, FormClosingEventArgs e)
        {
            AntesDispose();
        }

        private void AntesDispose()
        {
            Telas.getAgenda().RecarregarDatabase();
            Telas.getListas().PreencherEvento();
        }

        private void situacaoPossivelButton_Click(object sender, EventArgs e)
        {
            situacao = 2;
            AtualizarSituacao();
        }

        private void situacaoAgendarButton_Click(object sender, EventArgs e)
        {
            situacao = 1;
            AtualizarSituacao();
        }

        private void situacaoFinalizarButton_Click(object sender, EventArgs e)
        {
            situacao = 0;
            AtualizarSituacao();
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
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (box.Text == "")
                box.BackColor = badcolor;
            else
                box.BackColor = goodcolor;
        }

        private void mapsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Isto é uma pesquisa no Google Maps usando o que está escrito, então pode levar para o local errado. Utilize com cuidado.", "Pesquisar no Google Maps", MessageBoxButtons.OK);
            Endereco local = FazerLocal();
            System.Diagnostics.Process.Start("https://maps.google.com/?q=" + local.ToTexto());
        }
    }
}
