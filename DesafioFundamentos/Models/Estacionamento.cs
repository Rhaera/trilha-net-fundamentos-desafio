namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? novaPlaca = Console.ReadLine();

            if (novaPlaca != null) {

                veiculos.Add(novaPlaca);

            } else {

                Console.WriteLine("Placa inválida! Não foi possível registrar o veículo.");

            }
        
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string? placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (placa != null && veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                
                int horas = 0;
                string? hora = Console.ReadLine();

                if (hora != null) {
                        horas = int.Parse(hora);
                    } else {
                        Console.WriteLine("Por favor, insira um valor inteiro para as horas.");
                    }

                // try {
                //     if (hora != null) {
                //         horas = int.Parse(hora);
                //     } else {
                //         Console.WriteLine("Por favor, insira um valor inteiro para as horas.");
                //     }       
                // } catch (Exception e) {
                //      Console.WriteLine($"Por favor, insira um valor inteiro para as horas. Erro encontrado: {e.Message}");
                // }

                decimal horaDecimal = Convert.ToDecimal(horas); 
                decimal valorTotal = precoInicial + horaDecimal * precoPorHora;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
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

            int count = 0;

            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach(string veiculo in veiculos) {

                    count++;
                    Console.WriteLine($"{count}° Veículo: {veiculo}");

                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
