using MEGAGENDA.CONTROLLER;
using MEGAGENDA.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGAGENDA.VIEW
{
    public partial class Resumo : Form
    {
        public Resumo()
        {
            InitializeComponent();

            TopLevel = false;
            Dock = DockStyle.Fill;

            Atualizar();
        }

        public void Atualizar()
        {
            AtualizarMes();
            AtualizarSemana();
            AtualizarHoje();
            //AtualizarParcelas();
            //AtualizarNaoPagos();

        }

        public void AtualizarMes()
        {
            DateTime now = DateTime.Now;
            DateTime datade = new DateTime(now.Year, now.Month, 1);
            DateTime dataa = datade.AddMonths(1).AddTicks(-1);

            mesBox.Text = Resumidor.ListarEventos(datade, dataa);
        }

        public void AtualizarSemana()
        {
            DateTime now = DateTime.Now;
            semanaBox.Text = Resumidor.ListarEventos(now.Date, now.Date.AddDays(7));
        }

        public void AtualizarHoje()
        {
            DateTime now = DateTime.Now;
            hojeBox.Text = Resumidor.ListarEventos(now.Date, now.Date.AddDays(1).AddTicks(-1));
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                TextBox s = (TextBox)sender;
                if (s.Text != null && s.Text != "")
                    Clipboard.SetText(s.Text);
            }
        }
    }
}
