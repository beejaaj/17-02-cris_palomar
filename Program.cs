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
    Console.WriteLine("1. S Principle\n2. O Principle\n3. L Principle\n4. I Principle\n0. Close");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            //
        break;
        case "2":
            OpenClosed.Moto motocicleta = new OpenClosed.Moto("vermelho", 2015, 12);
            motocicleta.CriarVeiculo();
        break;
        case "3":
            //
        break;
        case "4":
            //
        break;
        case "0":
        //
        default:
            Console.WriteLine("Escolha inválida.");
            break;
    }
    Console.WriteLine("Pressione uma tecla para retornar ao menu");
    Console.ReadKey();
}