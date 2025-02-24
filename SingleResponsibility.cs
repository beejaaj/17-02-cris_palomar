using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_02_cris_palomar
{
    internal class SingleResponsibility
    {
        public class ClientService
        {
            public void CreateClient() { Console.WriteLine("Criando um novo cliente..."); }
            public void ReadClient() { Console.WriteLine("Visualizando um cliente..."); }
            public void UpdateClient() { Console.WriteLine("Atualizando o cliente"); }
            public void DeleteClient() { Console.WriteLine("Deletando o cliente"); }
        }

        abstract class ClientNotifier
        {
            public void NotifyClient()
            {
                // Envia e-mail / SMS
            }
        }
    }
}