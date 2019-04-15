using MEGAGENDA.CONTROLLER;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{
    [Serializable]
    public class Modelo
    {
        public static int MAXCLAUSULAS = 10;
        
        public string Nome = "";

        public Dictionary<string, List<String>> Clausulas = new Dictionary<string, List<string>>();

        public Modelo(string nome_modelo)
        {
            Nome = nome_modelo;
        }

        public Modelo(string nome_modelo, Dictionary<string, List<string>> clausulas)
        {
            Nome = nome_modelo;
            Clausulas = clausulas;
        }

        public void Adicionar_Secao(string nome, List<string> secao)
        {
            for (int i = secao.Count; i <= MAXCLAUSULAS; i++)
            {
                secao.Add("");
            }

            Clausulas[nome.ToUpper()] = secao;
        }



        public void padrao_teste()
        {
            // CONTRATO
            List<String> Clausulas_Contrato = new List<string>(12);

            Clausulas_Contrato.Add("É objeto do presente contrato o aluguel, montagem e operação de uma Cabine Fotográfica pelo período de [EVENTO DURACAO_MINUTOS] consecutivos, em [EVENTO TIPO]  a realizar-se no dia [EVENTO DATA], com início previsto para às [EVENTO HORA_INICIO] e prestação do serviço a partir das [EVENTO HORA_CABINE], localizada à [EVENTO ENDERECO].");
            Clausulas_Contrato.Add("A Cabine contará com equipe de apoio necessária a realização do evento durante as horas contratadas.");
            Clausulas_Contrato.Add("Serão impressas até 4 (quatro) cópias de cada montagem feita pela Cabine sem número máximo de impressões durante as [EVENTO DURACAO_MINUTOS].");
            Clausulas_Contrato.Add("Serão disponibilizados adereços e plaquinhas divertidas para os convidados.");
            Clausulas_Contrato.Add("Serão disponibilizadas, como CORTESIA, 60 (sessenta) folhas pretas, 4 (quatro) canetas prateadas e 2 (duas) colas em bastão para que os convidados fixem 1 (uma) das fotos impressas e deixem mensagens aos anfitriões. Estas páginas serão encadernadas com uma capa contendo uma arte aprovada pelo Contratante. As imagens para a arte da capa, cuja autorização de uso é de inteira responsabilidade do Contratante, deverão ser fornecidas, já tratadas, com antecedência mínima de 20 (vinte) dias para que a arte possa ser produzida e aprovada faltando no mínimo 10 (dez) dias para o evento sob pena do Guestbook ser entregue sem a capa ou de ser usada uma foto enviada anteriormente para outra arte. O Guestbook deverá ser retirado pelo Contratado no endereço constante no preâmbulo deste dispositivo ou em local acordado entre as partes, no prazo de até 30 (trinta) dias após a aprovação da arte.");
            Clausulas_Contrato.Add("A Cabine terá uma de suas laterais personalizada, no tamanho 1,25 x 1,85 metros, com a arte do evento, aprovada pelo Contratante, como CORTESIA.");
            Clausulas_Contrato.Add("Na ocasião da entrega do Guestbook, será entregue ao Contratante, um CD contendo todas as fotos tiradas pela Cabine no seu evento.");
            Clausulas_Contrato.Add("Todas as montagens feitas pela Cabine serão disponibilizadas na internet no endereço www.facebook.com/fotocabinemegaselfie até 3 (três) dias após o evento.");

            Adicionar_Secao("CONTRATO", Clausulas_Contrato);

            // CONTRATANTE
            List<String> Clausulas_Contratante = new List<string>(12);

            Clausulas_Contratante.Add("O Contratante deverá fornecer ao Contratado todas as informações necessárias à realização do serviço além de garantir o livre acesso da equipe ao local, no dia do evento.");
            Clausulas_Contratante.Add("O Contratante deverá, com antecedência mínima de 20 (vinte) dias, fornecer as imagens já tratadas e em alta resolução que pretende usar nesta moldura e na personalização da cabine, sendo inteiramente responsável pelo uso delas, para que as artes possam ser produzidas e aprovadas faltando no mínimo 10 (dez) dias para o evento. Caso o Contratante queira mais de uma moldura para o evento, a produção da arte para as demais molduras ficará por conta do mesmo. ");
            Clausulas_Contratante.Add("Fica o Contratante ciente de que é necessária para a montagem da Cabine, uma área de piso plano e coberta, com pelo menos 3,0 metros de largura por 3,0 metros de profundidade, um pé direito de, no mínimo, 2,4 metros e a uma distância mínima de 20 metros dos caixas de som.");
            Clausulas_Contratante.Add("Fica o Contratante responsável pela disponibilização de um ponto de energia próximo ao local de montagem da Cabine, bem como 2 (duas) mesas para acomodar os adereços e 1 (uma) mesa com 2 (duas) cadeiras para o Guestbook.");
            Clausulas_Contratante.Add("Fica o Contratante responsável por comunicar por escrito ao Contratado, com antecedência mínima de 2 (dois) dias, algum impedimento na utilização e publicação das fotos de algum dos convidados na internet ou na publicidade da Cabine.");
            Clausulas_Contratante.Add("É de responsabilidade da Contratante, eventuais danos físicos causados por parte de seus convidados ou pela equipe de apoio do evento (ex: segurança, cerimonial, garçom, etc.), aos equipamentos ou membros da equipe do Contratado, devendo este ser ressarcido de todo prejuízo sofrido no prazo máximo de 1 (uma) semana.");

            Adicionar_Secao("CONTRATANTE", Clausulas_Contratante);

            // CONTRATADO
            List<String> Clausulas_Contratado = new List<string>(12);

            Clausulas_Contratado.Add("Fica o Contratado responsável por chegar ao local do evento com no mínimo 2 (duas) horas de antecedência para montagem dos equipamentos.");
            Clausulas_Contratado.Add("É de responsabilidade do Contratado, testar previamente o funcionamento dos equipamentos e a impressão das fotos em papel fotográfico na presença de um representante do Contratante.");
            Clausulas_Contratado.Add("Fica o Contratado responsável pela disponibilização de, no mínimo, 1 (um) monitor para auxiliarem os convidados na utilização da Cabine.");

            Adicionar_Secao("CONTRATADO", Clausulas_Contratado);

            // PAGAMENTO
            List<String> Clausulas_Pagamento = new List<string>(12);

            Clausulas_Pagamento.Add("O valor total do Contrato é de [EVENTO VALOR].");
            Clausulas_Pagamento.Add("O pagamento será realizado mediante entrada de [EVENTO VALOR_ENTRADA] no ato da assinatura deste instrumento e o saldo mediante depósito na conta bancária de Ivanildo Fernandes da Silva, Banco do Brasil, Agência 3243-3, Conta 137521-0, CPF 030.099.874-04, até dia [EVENTO DATA_LIMITE_PAGAMENTO].");

            Adicionar_Secao("PAGAMENTO", Clausulas_Pagamento);

            // DESCUMPRIMENTO
            List<String> Clausulas_Descumprimento = new List<string>(12);

            Clausulas_Descumprimento.Add("A rescisão injustificada por parte do Contratante implicará na perda da quantia correspondente a 30% do valor total do contrato.");
            Clausulas_Descumprimento.Add("O cancelamento feito pelo Contratante após a chegada da equipe ao local do evento, implicará na perda do valor total pago.");
            Clausulas_Descumprimento.Add("O cancelamento injustificado por parte do Contratado implicará na devolução das parcelas pagas, acrescidas de 30%. ");
            Clausulas_Descumprimento.Add("Caso ocorra algum impedimento à realização do evento, ligado a caso fortuito ou de força maior, as partes podem: \nI – Pactuar outra data no prazo de 6(seis) meses da data inicialmente prevista, de acordo com a disponibilidade de agenda do Contratado;\nII – Pactuar nova data após 6(seis) meses da data inicialmente prevista desde que o Contratante efetue o pagamento de eventual diferença no preço dos serviços;\nIII – Proceder à devolução dos valores pagos e à reposição do que foi gasto nos preparativos.");
            Clausulas_Descumprimento.Add("Fica estabelecido entre as partes, que o preço da hora extra custará [EMPRESA CUSTO_HORA_EXTRA], devendo ser autorizada por escrito no decorrer da festa pelo Contratante e paga até 3 (três) dias após o evento.");
            Clausulas_Descumprimento.Add("Em caso de cobrança judicial, serão crescidas custas processuais e 20% de honorários advocatícios.");

            Adicionar_Secao("DESCUMPRIMENTO", Clausulas_Descumprimento);

            // GERAIS
            List<String> Clausulas_Gerais = new List<string>(12);

            Clausulas_Gerais.Add("Fica pactuada a total inexistência de vínculo trabalhista entre as partes contratantes, excluindo as obrigações previdenciárias e os encargos sociais, não havendo entre Contratado e Contratante qualquer tipo de relação de subordinação.");
            Clausulas_Gerais.Add("Salvo com a expressa autorização do Contratante, não pode o Contratado transferir ou subcontratar os serviços previstos neste instrumento, sob o risco de ocorrer a rescisão imediata.");
            Clausulas_Gerais.Add("O Contratante AUTORIZA o uso de imagens do evento para divulgação, por parte do Contratado, em seu site, Facebook, Instagram, Youtube e portfólios, sempre com o único fim de divulgação de seus serviços, respeitando-se a integridade e a moralidade do Contratante e de seus convidados.");
            Clausulas_Gerais.Add("As despesas adicionais, tais como taxas e locações de espaços para o evento e outros, serão de única e exclusiva responsabilidade do Contratante.");

            Adicionar_Secao("GERAIS", Clausulas_Gerais);

            // FORO
            List<String> Clausulas_Foro = new List<string>(12);

            Clausulas_Foro.Add("Para dirimir quaisquer controvérsias oriundas do presente contrato, as partes elegem o foro da comarca de Recife/PE. ");

            Adicionar_Secao("FORO", Clausulas_Foro);

        }
        





        public static Dictionary<string, List<String>> Build(SQLiteDataReader reader)
        {
            Dictionary<string, List<String>> clausulas = new Dictionary<string, List<string>>();
            if (reader != null && reader.HasRows)
                while (reader.Read())
                {
                    string secao = Database.ObjToString(reader["Secao"]);
                    if (!clausulas.ContainsKey(secao))
                        clausulas[secao] = new List<string>();
                    clausulas[secao].Add(Database.ObjToString(reader["Texto"]));
                }
            return clausulas;
        }

        public static Modelo Get(string nome)
        {
            string sql = $"SELECT * FROM Modelo JOIN Clausula ON Modelo_ID = Modelo_FK WHERE Nome = @nome ORDER BY Numero ASC";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nome", nome);

            SQLiteDataReader reader = Database.DoReader(sql, parameters);

            Dictionary<string, List<String>> result = Build(reader);
            if (result == null)
                return null;

            return new Modelo(nome, result);
        }

        public static List<string> GetNames()
        {
            string sql = "SELECT Nome FROM Modelo";
            List<string> modelos = new List<string>();

            SQLiteDataReader reader = Database.DoReader(sql);
            if (reader != null && reader.HasRows)
                while (reader.Read())
                    modelos.Add(Database.ObjToString(reader["Nome"]));
            return modelos;
        }

        public static int Add(Modelo modelo, bool silent = false)
        {
            if (modelo == null)
                return -604;
            
            string sql = "INSERT INTO Modelo (Nome) ";
            sql += $"VALUES (@nome)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nome", modelo.Nome);

            int result = Database.DoScalar(sql, parameters, silent);
            if (result < 0)
                return result;

            int count = AddClausulaLoop(result, modelo.Clausulas);

            Debug.Log($"{count} CLAUSULAS ADICIONADAS NO MODELO {modelo.Nome} COM ID {result}");
            return result;
        }

        private static int AddClausulaLoop(int modelo, Dictionary<string, List<String>> clausulas)
        {
            int count = 0;
            foreach (string secao in clausulas.Keys)
            {
                int numero = 1;
                foreach (string texto in clausulas[secao])
                {
                    count += AddClausula(modelo, secao, numero, texto);
                    numero++;
                }
            }
            return count;
        }

        public static int AddClausula(int modelo, string secao, int numero, string texto)
        {
            string sql = "INSERT INTO Clausula (Modelo_FK, Secao, Numero, Texto) ";
            sql += $"VALUES (@modelo, @secao, @numero, @texto)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@modelo", modelo);
            parameters.Add("@secao", secao);
            parameters.Add("@numero", numero);
            parameters.Add("@texto", texto);
            
            //If there's an error, it will return 0, so the debug count works
            return Database.DoNonQuery(sql, parameters, 0, true);
        }

        public static int Delete(int id)
        {
            string sql = $"DELETE FROM Modelo WHERE Modelo_ID = @id";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);

            int result = Database.DoScalar(sql, parameters);
            if (result == -101)
                Debug.Log($"ERRO AO DELETAR MODELO {id}");
            else
                Debug.Log($"MODELO {id} DELETADO");
            return result;
        }

        public static int Update(Modelo modelo)
        {
            if (modelo == null)
                return -604;

            string sql = "SELECT Modelo_ID FROM Modelo WHERE Nome = @nome";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nome", modelo.Nome);

            int id = -1;
            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            if (reader != null && reader.HasRows)
                while (reader.Read())
                    id = Database.ObjToInt(reader["Modelo_ID"]);
            if (id <= 0)
                return id;


            sql = "DELETE FROM Clausula WHERE Modelo_FK = @id";

            parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);

            int deleted = Database.DoScalar(sql, parameters);
            if (deleted < 0)
                return deleted;

            int added = AddClausulaLoop(id, modelo.Clausulas);  

            Debug.Log($"{deleted} CLAUSULAS DELETADAS E {added} ADICIONADAS NO MODELO {modelo.Nome} COM ID {id}");
            return added;
        }

    }
}
