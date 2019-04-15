using MEGAGENDA.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.CONTROLLER
{
    public static class Telas
    {
        private static FormPrincipal TelaPrincipal;
        private static VIEW.Listas TelaListas;
        private static VIEW.Agenda TelaAgenda;
        private static VIEW.Contratos TelaContratos;
        private static VIEW.Resumo TelaResumo;
        private static VIEW.Configuracoes TelaConfiguracoes;

        public static void setPrincipal(FormPrincipal principal)
        {
            TelaPrincipal = principal;
        }

        public static void TrocarTela(object Form)
        {
            TelaPrincipal.ResetForm(Form);
        }

        public static void TrocarTela(string tela)
        {
            object form = null;
            switch (tela)
            {
                case "Agenda":
                    //TelaAgenda = null;
                    //TelaAgenda = new Agenda();
                    //
                    TelaAgenda.RecarregarDatabase();
                    form = TelaAgenda;
                    break;
                case "Contratos":
                    //TelaContratos = null;
                    //TelaContratos = new Contratos();
                    //
                    form = TelaContratos;
                    break;
                case "Listas":
                    form = TelaListas;
                    break;
                case "Configurações":
                    form = TelaConfiguracoes;
                    break;
                case "Resumo":
                    TelaResumo.Atualizar();
                    form = TelaResumo;
                    break;
                default:
                    break;
            }
            if (form != null)
            {
                TelaPrincipal.ResetForm(form);
            }            
        }

        public static void setListas(VIEW.Listas listas)
        {
            TelaListas = listas;
        }

        public static VIEW.Listas getListas()
        {
            return TelaListas;
        }

        public static void setAgenda(VIEW.Agenda agenda)
        {
            TelaAgenda = agenda;
        }

        public static VIEW.Agenda getAgenda()
        {
            return TelaAgenda;
        }

        public static void setContratos(VIEW.Contratos contratos)
        {
            TelaContratos = contratos;
        }

        public static VIEW.Contratos getContratos()
        {
            return TelaContratos;
        }
        public static void setConfiguracoes(VIEW.Configuracoes configuracoes)
        {
            TelaConfiguracoes = configuracoes;
        }

        public static VIEW.Configuracoes getConfiguracoes()
        {
            return TelaConfiguracoes;
        }

        public static void setResumo(VIEW.Resumo resumo)
        {
            TelaResumo = resumo;
        }

        public static VIEW.Resumo getResumo()
        {
            return TelaResumo;
        }
    }
}
