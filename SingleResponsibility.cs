using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_02_cris_palomar
{
    internal class SingleResponsibility
    {
        class ClientService
        {
            public void CreateClient() { }
            public void ReadClient() { }
            public void UpdateClient() { }
            public void DeleteClient() { }
        }

        class ClientNotifier
        {
            public void NotifyClient()
            {
                // Envia e-mail / SMS
            }
        }
    }
}
