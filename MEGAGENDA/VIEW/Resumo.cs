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
            AtualizarMeses();
            AtualizarSemana();
            AtualizarVencidas();
        }

        public void AtualizarMeses()
        {
            DateTime now = DateTime.Now;
            DateTime datade = new DateTime(now.Year, now.Month, 1);
            DateTime dataa = datade.AddMonths(12).AddTicks(-1);

            mesBox.Text = Resumidor.ListarEventos(datade, dataa);
        }
        public void AtualizarSemana()
        {
            DateTime now = DateTime.Now;
            semanaBox.Text = Resumidor.ListarEventos(now.Date, now.Date.AddDays(7));
        }

        public void AtualizarVencidas()
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            vencidasBox.Text = Resumidor.ListarParcelasVencidas(tomorrow.Date);

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
