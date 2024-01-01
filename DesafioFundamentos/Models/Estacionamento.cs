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
            // Implementado!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
             string placa = Console.ReadLine();

    // Verifica se a placa já está na lista
    if (!veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
    {
        veiculos.Add(placa.ToUpper());
        Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso!");
    }
    else
    {
        Console.WriteLine("Desculpe, este veículo já está estacionado aqui.");
    }
}
        

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0; 
                valorTotal = ( precoInicial + precoPorHora ) * horas;

    

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa.ToUpper());
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
                // *IMPLEMENTE AQUI*
                foreach (var veiculo in veiculos)
        {
            Console.WriteLine(veiculo);
        }
                //também poderia ser o foreach EX: foreach(string item in veiculos) 
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

//num código completo esse foreach iria ficar assim 
//Console.WriteLine("Percorrendo a lista com o FOREACH")
//int contadorForeach = 0;
//foreach(string item in veiculo){
//Console.WriteLine($"Posição N°  {contadorForeach} - {item}" );
//contadorForeach++;
//}    
 // nova informação
