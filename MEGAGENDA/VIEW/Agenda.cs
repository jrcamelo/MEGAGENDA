using Pabo.Calendar;
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
    public partial class Agenda : Form
    {


        List<DateItem> diasSelecionados = new List<DateItem>();
        DateItem diaSelecionado = new DateItem();
        DateTime dataSelecionada = DateTime.Today;        

        public Agenda()
        {
            InitializeComponent();

            TopLevel = false;
            Dock = DockStyle.Fill;

            Calendario.SetCalendario(calendario);
            RecarregarDatabase();

            calendario.SelectDate(DateTime.Today);
            SelecionarDia(DateTime.Today);
        }
        
        public void RecarregarDatabase()
        {
            bool finalizados = filtroFinalizadosCheck.Checked;
            bool possiveis = filtroPossiveisCheck.Checked;
            bool pagamentos = filtroPagamentosCheck.Checked;
            string primeiro_dia = calendario.Month.FirstDay().ToString("yyyy-MM-dd");
            string ultimo_dia = calendario.Month.LastDay().ToString("yyyy-MM-dd");

            calendario.Dates.Clear();
            calendario.Dates = Calendario.CarregarDatabase(finalizados, possiveis, pagamentos, primeiro_dia, ultimo_dia);
            calendario.Refresh();
        }        
        
        private void calendario_MonthChanged(object sender, MonthChangedEventArgs e)
        {
            RecarregarDatabase();
        }

        private void calendario_DayDoubleClick(object sender, DayClickEventArgs e)
        {

            //MessageBox.Show((string) calendario.GetDateInfo(calendario.SelectedDates[0]).ToString());
        }
        
        
        
            
        private void gotoHoje_MouseClick(object sender, MouseEventArgs e)
        {
            Rectangle hojerec = new Rectangle(0, this.Size.Height - 20, 70, 20);
            if (hojerec.Contains(new Point(e.X, e.Y)))
            {
                calendario.SelectDate(DateTime.Today);
                calendario.Focus();
            }

        }

        private void calendario_DaySelected(object sender, DaySelectedEventArgs e)
        {
            DateTime d = new DateTime();
            DateTime.TryParse(e.Days[0], out d);
            if (d != DateTime.MinValue)
            {
                SelecionarDia(d);
                dataSelecionada = d;
            }
        }

        public void SelecionarDia(DateTime dia)
        {
            diasSelecionados = calendario.Dates.GetDate(dia);
            itemBox.Items.Clear();
            
            foreach (DateItem di in diasSelecionados)
            {
                itemBox.Items.Add(di.Text);
            }
            if (itemBox.Items.Count > 0)
            {
                itemBox.SelectedIndex = 0;
                diaSelecionado = diasSelecionados[0];
            }
            else
            {
                diasSelecionados = new List<DateItem>();
                diaSelecionado = new DateItem();
            }
            dateTimePicker1.Value = dia;
            MostrarDia();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            calendario.SelectDate(dateTimePicker1.Value);
            SelecionarDia(dateTimePicker1.Value);
        }

        private void itemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemBox.SelectedItem.ToString() != "")
            {
                diaSelecionado = diasSelecionados[itemBox.SelectedIndex];
            }
            MostrarDia();
        }

        public void MudarDiaSelecionado(int index)
        {
            if (diasSelecionados.Count >= index)
            {
                diaSelecionado = diasSelecionados[index];
            }
        }

        public void MostrarDia()
        {
            if (diaSelecionado == null || diaSelecionado.Text == "")
            {
                eidLabel.Text = "ID do Evento: 0";
                textoLabel.Text = "Nenhum evento selecionado";
                editarButton.Enabled = false;
            }
            else
            {
                if (diaSelecionado.EID > 0)
                {
                    eidLabel.Text = "ID do evento: " + diaSelecionado.EID.ToString();
                    editarButton.Enabled = true;
                }
                else
                {
                    eidLabel.Text = "ID do Evento: 0";
                    editarButton.Enabled = false;
                }
                textoLabel.Text = diaSelecionado.Text;
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            Evento evento = Evento.Get(diaSelecionado.EID);
            if (evento != null)
            {
                if (Telas.getListas().editEvento != null)
                {
                    Telas.getListas().editEvento.Dispose();
                }
                Telas.getListas().editEvento = new EditarEvento(evento);
                Telas.getListas().editEvento.Show();
            }
        }
        
        private void filtroPossiveisCheck_CheckedChanged(object sender, EventArgs e)
        {
            RecarregarDatabase();
        }

        private void filtroFinalizadosCheck_CheckedChanged(object sender, EventArgs e)
        {
            RecarregarDatabase();
        }

        private void filtroPagamentosCheck_CheckedChanged(object sender, EventArgs e)
        {
            RecarregarDatabase();
        }
    }

}
