// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using _17_02_cris_palomar;

/*Gerente gerente = new Gerente();

Funcionario funcionario = gerente;
funcionario.Salario = 5000.0;
Console.WriteLine("B: "+funcionario.getBonificacao());*/

while (true)
{
    Console.Clear();
    Console.WriteLine("1. S Principle\n2. O Principle\n3. L Principle\n4. I Principle\n0. Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            SingleResponsibility.ClientService cliente = new SingleResponsibility.ClientService();
            cliente.CreateClient();
            cliente.ReadClient();
            cliente.UpdateClient();
            cliente.DeleteClient();
        break;
        case "2":
            OpenClosed.Moto motocicleta = new OpenClosed.Moto("vermelho", 2015, 12);
            motocicleta.CriarVeiculo();
        break;
        case "3":
            Liskov.CreditCard creditCard = new Liskov.CreditCard();
            creditCard.Validacao();
            Liskov.NubankRewards Recompensas = new Liskov.NubankRewards();
            Recompensas.Validacao();
        break;
        case "4":
            InterfaceSegregation.Moto moto = new InterfaceSegregation.Moto();
            moto.ConfiguraMoto("azul", 2022, 24);
            moto.LigaVeiculo();
        break;
        case "0":
            System.Environment.Exit(0);
        break;
        default:
            Console.WriteLine("Escolha inválida.");
        break;
    }
    Console.WriteLine("Pressione uma tecla para retornar ao menu");
    Console.ReadKey();
}