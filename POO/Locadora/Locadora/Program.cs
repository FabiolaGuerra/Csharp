namespace Locadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Carro> listCarros = new List<Carro>()
            {
                new Carro("BMW", "X1", 2022, 300),
                new Carro("Renault", "Kwid", 2024, 130),
                new Carro("Honda","HRV",2024,260)
            };
            List<Caminhao> listCaminhao = new List<Caminhao>()
            {
                new Caminhao("Kia","Bong-Baú",2022,670),
                new Caminhao("Mercedes-Benz","Atego",2024,690),
                new Caminhao ("Ford","F-Line",2020,900)
            };
            List<Moto> listMotos = new List<Moto>()
            {
                new Moto("Yamaha","Factor 150",2023,45),
                new Moto("Honda","CG 160",2024,49),
                new Moto("Royal","Enfield Hunter 350",2022,66)
            };

            while (true)
            {
                Console.WriteLine("Bem vindo a Moved");
                Console.WriteLine("-------------------");
                Console.WriteLine("Escolha uma opção: \n1 Cadastrar Veículo \n2 Alugar Veículo \n3 Sair");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1) //cadastrar veiculos
                {
                    Console.WriteLine("Qual tipo de veiculo automotor deseja cadastrar \n1 Carro \n2 Moto \n3 Caminhão");
                    int tipoveiculo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a marca:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Informe o modelo:");
                    string modelo = Console.ReadLine();
                    Console.WriteLine("Informe o ano:");
                    int ano = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o preço da diária:");
                    decimal preco = decimal.Parse(Console.ReadLine());

                    if (tipoveiculo == 1)
                    {
                        Carro cadastro = new Carro(modelo, marca, ano, preco);
                        listCarros.Add(cadastro);
                    }
                    else if (tipoveiculo == 2)
                    {
                        Moto cadastro = new Moto(modelo, marca, ano, preco);
                        listMotos.Add(cadastro);
                    }
                    else if (tipoveiculo == 3)
                    {
                        Caminhao cadastro = new Caminhao(modelo, marca, ano, preco);
                        listCaminhao.Add(cadastro);
                    }
                    else
                    {
                        Console.WriteLine("Tipo de veículo inválido");
                    }
                    Console.WriteLine("Veículo cadastrado com sucesso!");
                }
                else if (opcao == 2) //alugar carro
                {
                    Console.WriteLine("Escolha uma opção: \n1 Carro \n2 Moto \n3 Caminhão");
                    var tipo = int.Parse(Console.ReadLine());
                    if (tipo == 1)
                    {
                        if(listCarros.Count == 0)
                        { 
                            Console.WriteLine("Sem carros disponíveis no momento");
                            continue;
                        }
                        Console.WriteLine("Escolha seu carro:");
                        foreach (Carro carro in listCarros)
                        {
                            Console.WriteLine(carro.ToString());
                        }
                        int indiceCarroEscolhido = int.Parse(Console.ReadLine());
                        Console.WriteLine("Por favor, informe por quantos dias deseja alugar o Carro:");
                        int quantidadeDeDias = int.Parse(Console.ReadLine());
                        Carro carroEscolhido = listCarros.ElementAt(indiceCarroEscolhido);
                        Console.WriteLine($"Parabéns, voce alugou um {carroEscolhido.ToString()}");
                        Console.WriteLine($"Total a pagar: {carroEscolhido.CalcularValorAluguel(quantidadeDeDias)}");
                        listCarros.RemoveAt(indiceCarroEscolhido);
                    }
                    else if (tipo == 2)
                    {
                        if (listMotos.Count == 0)
                        {
                            Console.WriteLine("Sem motos disponiveis para locação");
                            continue;
                        }
                        Console.WriteLine("Escolha a moto que deseja alugar:");
                        foreach (Moto moto in listMotos)
                        {
                            Console.WriteLine(moto.ToString());
                        }
                        int indiceMotoEscolhida = int.Parse(Console.ReadLine());
                        Console.WriteLine("Por favor, informe por quantos dias deseja alugar a Moto:");
                        int quantidadeDeDias =int.Parse(Console.ReadLine());
                        Moto motoEscolhida = listMotos.ElementAt(indiceMotoEscolhida);
                        Console.WriteLine($"Parabéns, você alugou uma {motoEscolhida.ToString()}");
                        Console.WriteLine($"Total a pagar: R${motoEscolhida.CalcularValorAluguel(quantidadeDeDias)}");
                        listMotos.RemoveAt(indiceMotoEscolhida);
                    }
                    else if(tipo == 3)
                    {
                       if (listCaminhao.Count == 0)
                        {
                            Console.WriteLine("Sem caminhoões disponiveis para locação");
                            continue;
                        }
                        Console.WriteLine("Escolha o Caminhão que deseja alugar:");
                        foreach (Caminhao caminhao in listCaminhao)
                        {
                            Console.WriteLine(caminhao.ToString());
                        }
                        int indiceCaminhaoEscolhido = int.Parse(Console.ReadLine());
                        Console.WriteLine("Por favor, informe por quantos dias deseja alugar o Caminhão:");
                        int quantidadeDeDias =int.Parse(Console.ReadLine());
                        Caminhao caminhaoEscolhido = listCaminhao.ElementAt(indiceCaminhaoEscolhido);
                        Console.WriteLine($"Parabéns, você alugou uma {caminhaoEscolhido.ToString()}");
                        Console.WriteLine($"Total a pagar: R${caminhaoEscolhido.CalcularValorAluguel(quantidadeDeDias)}");
                        listMotos.RemoveAt(indiceCaminhaoEscolhido);

                    }
                }
                if (opcao == 3) 
                    break;
            }

            
        }
    }
}
