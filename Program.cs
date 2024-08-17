using System;

namespace LojaGames
{    
    // Definindo a classe Jogo
    public class Jogo
    {
        // Propriedade para armazenar o nome do jogo
        public string Nome { get; set; }
        public double Preco { get; set; }

        // Construtor da classe Jogo que inicializa a propriedade Nome
        public Jogo(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        // Método para exibir as informações do jogo
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do jogo: {Nome}");
            Console.WriteLine($"Preço do jogo: R${Preco}");
        }
    }

    // Classe principal do programa
    class Program
    {
        static void Main()
        {
            Jogo jogo = null;
            bool sair = false;

            while (!sair)
            {
                Console.Clear(); //Limpa a tela a cada nova solicitação
                Console.WriteLine("Bem-vindo ao Software de Controle de Estoque. \n");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1. Novo Jogo");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Remover Produtos");
                Console.WriteLine("4. Entrada Estoque");              
                Console.WriteLine("5. Saída Estoque");                
                Console.WriteLine("6. Sair");                
            }

            //Lê a opção selecionada pelo usuário    
            string menu = Console.ReadLine();

            switch (menu)
            {
            case "1":
                InserirNovoJogo (ref jogo);
                break;
            case "2":
                ListarJogos(jogo);
                break;
            case "3":
                sair = true;
                Console.WriteLine("Saindo...");
                break;               
            }        
            
        }
    }

    static void InserirNovoJogo(ref Jogo jogo)
    {
        Console.Clear();
        Console.WriteLine("Informe o nome do jogo:")
        string nomeDoJogo = Console.ReadLine();
        
        Console.WriteLine("Infome o preço do jogo:")
        string precoString = Console.ReadLine();

        if (double.TryParse(precoString, out double precoDoJogo))

        {
            jogo = new Jogo(nomeDoJogo, precoDoJogo);
            Console.WriteLine("Jogo adicionado !");            
        }
        else
        {
            Console.WriteLine("Preço inválido ! Por favor informe um número válido.");           
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ListarJogos(Jogo jogo)
    {
        Console.Clear();
        if (jogo != null)
        {
            jogo.ExibirInformacoes();
        }
        else
        {
            Console.WriteLine("Nenhum jogo cadastrado.");

        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }
}
