using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        private readonly decimal precoInicial = precoInicial;
        private readonly decimal precoPorHora = precoPorHora;
        private readonly List<string> veiculos = [];

        public void AdicionarVeiculo()
        {
            // Implementado!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if(IsValidPlate(placa)){
                veiculos.Add(placa);
            }
            else
            {
                Console.WriteLine("Esta placa não é valida. ");
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal 
                Console.Write("Quantidade de horas  estacionado: ");
                int horasEstacionadas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horasEstacionadas; 

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (var veiculoEstacionado in veiculos)
                {
                    Console.WriteLine($"{veiculoEstacionado}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }


        private static bool IsValidPlate(string placa)
        {
            string pattern = @"^[A-Z]{3}\d[A-Z]\d{2}$";
            return Regex.IsMatch(placa, pattern);
        }
    }
}
