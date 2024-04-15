using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;


decimal precoInicial = 0, precoPorHora = 0;


bool camposPreenchidos = false;
while (!camposPreenchidos)
{
    Console.Clear();
    Console.WriteLine("-- Gerenciamento do Estacionamento -- ");
    try
    {        
        Console.WriteLine("Informe o preço inicial: ");
        precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Informe o preço por hora: ");
        precoPorHora = Convert.ToDecimal(Console.ReadLine());

        camposPreenchidos = precoInicial > 0 && precoPorHora > 0;
    }
    catch (FormatException)
    {
        Console.WriteLine("O campo deve ser preenchido.");
    }
}


// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento estacionamento = new(precoInicial, precoPorHora);


bool exibirMenu = true;
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
