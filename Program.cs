/*1- Elabore um planejamento estratégico dessa vez utilizando
todos os comandos aprendidos, e com no mínimo 5 condições
relacionadas ao planejamento.*/
class Program
{
    //Estruturar o objeto Projeto
    class Projeto
    {
        //Variáveis
        public string separador=new string('-',108);
        private string Nome{get;set;}
        private string Etapa{get;set;}
        //Construtor
        public Projeto(string nome,string etapa)
        {
            Nome=nome;
            Etapa=etapa;
        }
        //Função para imprimir nome e etapa detalhada do projeto
        public void PlanejamentoEstrategico()
        {
            Console.WriteLine(separador);
            Console.ForegroundColor=ConsoleColor.DarkCyan;
            Console.WriteLine($"Nome do projeto: {Nome}");
            Console.ResetColor();
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.WriteLine(Etapa);
            Console.ResetColor();
            Console.WriteLine(separador);
        }
    }
    static void Main(string[] args)
    {
        //Corpo do programa
        string separador=new string('-',108),opcao,nome;
        Console.WriteLine(separador);
        Console.WriteLine("Gerenciador de Planejamento Estratégico");
        Console.WriteLine(separador);
        InserirNome();
        //Função para inserir o nome do projeto        
        void InserirNome()
        {
            Console.WriteLine("Entre com o nome do projeto");
            nome=Console.ReadLine();
            if(string.IsNullOrWhiteSpace(nome)||nome.Length<3)
            {
                Console.WriteLine($"Nome em branco ou com menos de três caracteres.\n{separador}");
                InserirNome();
            }
            else
            {
                QualEtapa();    
            }
        }
        //Função que escolhe a etapa do projeto para ser detalhada
        void QualEtapa()
        {
            Console.WriteLine(separador);
            Console.WriteLine("Diga qual etapa do planejamento estratégico deseja detalhar(digite Análise do ambiente, Definição de Metas,\nFormulação de Estratégias ou Implementação e Acompanhamento)");
            opcao=Console.ReadLine();
            if(opcao.ToLower().Trim()=="análise do ambiente")
            {
                Console.WriteLine(separador);
                AnaliseAmbiente();
            }
            else if(opcao.ToLower().Trim()=="definição de metas")
            {
                Console.WriteLine(separador);
                DefinicaoMetas();
            }
            else if(opcao.ToLower().Trim()=="formulação de estratégias")
            {
                Console.WriteLine(separador);
                FormulacaoEstrategias();
            }
            else if(opcao.ToLower().Trim()=="implementação e acompanhamento")
            {
                Console.WriteLine(separador);
                ImplementacaoAcompanhamento();
            }
            else
            {
                Console.WriteLine("Opção incorreta.");
                QualEtapa();        
            }
        }
        //Funções para descrever a etapa selecionada
        void AnaliseAmbiente()
        {
            Projeto projeto;
            Console.WriteLine("Detalhe tudo que analisar do ambiente");
            string ambiente=Console.ReadLine();
            if(string.IsNullOrWhiteSpace(ambiente)||ambiente.Length<3)
            {
                Console.WriteLine($"Em branco ou com menos de três caracteres.\n{separador}");
                AnaliseAmbiente();
            }
            projeto=new Projeto(nome,ambiente);
            projeto.PlanejamentoEstrategico();
            Recomecar();
        }
        void DefinicaoMetas()
        {
            Projeto projeto;
            Console.WriteLine("Defina as metas almejadas para o projeto");
            string metas=Console.ReadLine();
            if(string.IsNullOrWhiteSpace(metas)||metas.Length<3)
            {
                Console.WriteLine($"Em branco ou com menos de três caracteres.\n{separador}");
                DefinicaoMetas();
            }
            projeto=new Projeto(nome,metas);
            projeto.PlanejamentoEstrategico();
            Recomecar();
        }
        void FormulacaoEstrategias()
        {
            Projeto projeto;
            Console.WriteLine("Desenvolva suas estratégias e planos de ação para atingir suas metas");
            string estrategias=Console.ReadLine();
            if(string.IsNullOrWhiteSpace(estrategias)||estrategias.Length<3)
            {
                Console.WriteLine($"Em branco ou com menos de três caracteres.\n{separador}");
                FormulacaoEstrategias();
            }
            projeto=new Projeto(nome,estrategias);
            projeto.PlanejamentoEstrategico();
            Recomecar();
        }
        void ImplementacaoAcompanhamento()
        {
            Projeto projeto;
            Console.WriteLine("Como irá implementar e monitorar o projeto?");
            string implementacao=Console.ReadLine();
            if(string.IsNullOrWhiteSpace(implementacao)||implementacao.Length<3)
            {
                Console.WriteLine($"Em branco ou com menos de três caracteres.\n{separador}");
                ImplementacaoAcompanhamento();
            }
            projeto=new Projeto(nome,implementacao);
            projeto.PlanejamentoEstrategico();
            Recomecar();
        }
        //Função para limpar a tela
        void LimparTela()
        {
            Console.ReadKey();
            Console.Clear();
        }
        //Função que recomeça todo o processo
        void Recomecar()
        {
            Console.WriteLine("Deseja recomeçar?");
            string escolha=Console.ReadLine();
            if(escolha.ToLower().Trim()=="sim")
            {
                Console.WriteLine(separador);
                LimparTela();
                Console.WriteLine(separador);
                InserirNome();
            }
            else
            {
                Console.WriteLine(separador);
                Console.WriteLine("Obrigado, tenha um bom dia.");
                Console.WriteLine(separador);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }       
    }
}