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
    public partial class Listas : Form
    {
        public EditarCliente editCliente;
        public EditarEvento editEvento;

        public Listas()
        {
            InitializeComponent();


            TopLevel = false;
            Dock = DockStyle.Fill;

            clientePesquisaTipo.SelectedIndex = 0;
            eventoPesquisaTipo.SelectedIndex = 0;

            dataClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataClientes.EnableHeadersVisualStyles = false;

            dataEventos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataEventos.EnableHeadersVisualStyles = false;
            
            pesquisaDataA.MinDate = pesquisaDataDe.Value;
            pesquisaDataDe.MaxDate = pesquisaDataA.Value;

            // Manter as colunas no Design no editor
            dataClientes.Columns.Clear();
            PreencherCliente();

            dataEventos.Columns.Clear();
            PreencherEvento();

        }

        public void SelectRow(DataGridView datagrid, string coluna, int id)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in datagrid.Rows)
                if (row.Cells[coluna].Value != null)
                    if (row.Cells[coluna].Value.ToString().Equals(id.ToString()))
                    {
                        rowIndex = row.Index;
                        break;
                    }
            if (rowIndex > -1)
                datagrid.Rows[rowIndex].Selected = true;
        }

        public void SelectRowCliente(int id)
        {
            SelectRow(dataClientes, "ID", id);
        }
        public void SelectRowEvento(int id)
        {
            SelectRow(dataEventos, "ID", id);
        }


        public void PreencherCliente(string tipoPesquisa = "")
        {
            dataClientes.DataSource = null;

            string where = Listagem.FazerWhereCliente(tipoPesquisa);
            Dictionary<string, object> param = Listagem.FazerParamsCliente(idClienteBox.Value, clientePesquisaBox.Text);

            dataClientes.DataSource = Listagem.TableCliente(where, param);

            dataClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataClientes.Columns[2].Width = 75;
            dataClientes.Columns[3].Width = 40;

            dataClientes.Refresh();
        }

        public void PreencherEvento(string tipoPesquisa = "")
        {
            dataEventos.DataSource = null;

            string where = Listagem.FazerWhereEvento(tipoPesquisa);
            Dictionary<string, object> param = Listagem.FazerParamsEvento(idEventoBox.Value, pesquisaDataDe.Value, pesquisaDataA.Value, eventoPesquisaBox.Text);

            dataEventos.DataSource = Listagem.TableEvento(where, param);

            dataEventos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataEventos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataEventos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataEventos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataEventos.Refresh();
        }

        private void editarClienteSelecionado(int index)
        {
            if (editCliente != null)
                editCliente.Dispose();

            int id = int.Parse(dataClientes.Rows[index].Cells[0].Value.ToString());
            editCliente = new EditarCliente(Pessoa.GetwEndereco(id));
            editCliente.Show();
        }

        private void editarEventoSelecionado(int index)
        {
            if (editEvento != null)
                editEvento.Dispose();

            int id = int.Parse(dataEventos.Rows[index].Cells[0].Value.ToString());
            Evento evento = Evento.Get(id);
            editEvento = new EditarEvento(evento);
            editEvento.Show();
        }

        private void clienteEventoButton_Click(object sender, EventArgs e)
        {
            if (editEvento != null)
                editEvento.Dispose();
            int pid = int.Parse(dataClientes.Rows[dataClientes.CurrentCell.RowIndex].Cells[0].Value.ToString());
            string nome = (string)dataClientes.Rows[dataClientes.CurrentCell.RowIndex].Cells[1].Value;
            editEvento = new EditarEvento(pid, nome);
            editEvento.Show();
        }

        private void addEventoButton_Click(object sender, EventArgs e)
        {
            if (editEvento != null)
                editEvento.Dispose();
            editEvento = new EditarEvento();
            editEvento.Show();
        }

        private void clientePesquisaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (clientePesquisaTipo.Text)
            {
                case "ID":
                    clientePesquisaBox.Visible = true;
                    clientePesquisaBox.Enabled = false;
                    clientePesquisaBox.BackColor = Color.WhiteSmoke;
                    idClienteBox.Enabled = true;
                    break;
                case "Nome":
                case "CPF/CNPJ":
                case "Anotações":
                    clientePesquisaBox.Visible = true;
                    clientePesquisaBox.Enabled = true;
                    clientePesquisaBox.BackColor = Color.FromArgb(250, 248, 255);
                    idClienteBox.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void eventoPesquisaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (eventoPesquisaTipo.Text)
            {
                case "ID":
                case "Cliente":
                    eventoPesquisaBox.Visible = true;
                    eventoPesquisaBox.Enabled = false;
                    eventoPesquisaBox.BackColor = Color.WhiteSmoke;
                    idEventoBox.Enabled = true;
                    break;
                case "Data":
                    eventoPesquisaBox.Visible = false;
                    eventoPesquisaBox.Enabled = false;
                    idEventoBox.Enabled = false;
                    break;
                case "Tipo":
                case "Observações":
                    eventoPesquisaBox.Visible = true;
                    eventoPesquisaBox.Enabled = true;
                    eventoPesquisaBox.BackColor = Color.FromArgb(250, 248, 255);
                    idEventoBox.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void criarClienteButton_Click(object sender, EventArgs e)
        {
            EditarCliente TelaCliente = new EditarCliente();
            TelaCliente.Show();
        }

        private void listarEventoButton_Click(object sender, EventArgs e)
        {
            if (dataClientes.CurrentCell != null && dataClientes.CurrentCell.RowIndex >= 0)
            {
                int pid = int.Parse(dataClientes.Rows[dataClientes.CurrentCell.RowIndex].Cells[0].Value.ToString());
                ListarEventos(pid);
            }
        }
        private void dataClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataClientes.CurrentCell != null && dataClientes.CurrentCell.RowIndex >= 0)
            {
                int pid = int.Parse(dataClientes.Rows[dataClientes.CurrentCell.RowIndex].Cells[0].Value.ToString());
                ListarEventos(pid);
            }
        }

        private void ListarEventos(int pid)
        {
            eventoPesquisaTipo.SelectedIndex = 1;
            idEventoBox.Value = pid;
            PreencherEvento(eventoPesquisaTipo.Text);
        }

        private void editEventoClienteButton_Click(object sender, EventArgs e)
        {
            if (dataEventos.CurrentCell != null && dataEventos.CurrentCell.RowIndex >= 0)
            {
                int id = int.Parse(dataEventos.CurrentRow.Cells["Cliente"].Value.ToString());
                editCliente = new EditarCliente(Pessoa.GetwEndereco(id));
                editCliente.Show();
            }
        }

        private void contratoButton_Click(object sender, EventArgs e)
        {
            if (dataEventos.CurrentCell != null && dataEventos.CurrentCell.RowIndex >= 0)
            {
                int id = int.Parse(dataEventos.CurrentRow.Cells["ID"].Value.ToString());
                Telas.getContratos().MudarEvento(id);
                Telas.TrocarTela("Contratos");
            }
        }

        private void dataEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataEventos.CurrentCell != null && e.RowIndex >= 0)
                editarEventoSelecionado(e.RowIndex);
        }


        private void editEventoButton_Click(object sender, EventArgs e)
        {
            if (dataEventos.CurrentCell != null && dataEventos.CurrentCell.RowIndex >= 0)
                editarEventoSelecionado(dataEventos.CurrentCell.RowIndex);
        }

        private void pesquisaDataA_ValueChanged(object sender, EventArgs e)
        {
            pesquisaDataA.MinDate = pesquisaDataDe.Value;
            pesquisaDataDe.MaxDate = pesquisaDataA.Value;
        }

        private void pesquisaDataDe_ValueChanged(object sender, EventArgs e)
        {
            pesquisaDataA.MinDate = pesquisaDataDe.Value;
            pesquisaDataDe.MaxDate = pesquisaDataA.Value;
        }

        private void dataClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataClientes.CurrentCell != null && e.RowIndex >= 0)
                editarClienteSelecionado(e.RowIndex);
        }
        private void editClienteButton_Click(object sender, EventArgs e)
        {
            if (dataClientes.CurrentCell != null && dataClientes.CurrentCell.RowIndex >= 0)
                editarClienteSelecionado(dataClientes.CurrentCell.RowIndex);
        }

        private void clientePesquisaButton_Click(object sender, EventArgs e)
        {
            PesquisaCliente();
        }

        public void PesquisaCliente()
        {
            PreencherCliente(clientePesquisaTipo.Text);
        }

        private void clienteLimparButton_Click(object sender, EventArgs e)
        {
            PreencherCliente();
        }

        private void eventoPesquisaButton_Click(object sender, EventArgs e)
        {
            PesquisaEvento();
        }

        public void PesquisaEvento()
        {
            PreencherEvento(eventoPesquisaTipo.Text);
        }

        private void eventoLimparButton_Click(object sender, EventArgs e)
        {
            PreencherEvento();
        }

    }
}
