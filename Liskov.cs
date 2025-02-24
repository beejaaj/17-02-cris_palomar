using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_02_cris_palomar
{
    internal class Liskov
    {
        public interface IInstrumentoPagamento
        {
            void Validacao();
            void ColetarPagamento();
        }

        public abstract class NubankCard : IInstrumentoPagamento
        {
            public void ColetarPagamento()
            {
                Console.WriteLine("Pagamento Realizado");
            }

            public virtual void Validacao()
            {
                // Validação básica do cartão
            }
        }

        public class CreditCard : NubankCard
        {
            public override void Validacao()
            {
                Console.WriteLine("Verificando limite...");
                Console.WriteLine("Limite OK");
            }
        }

        public class DebitCard : NubankCard
        {
            public override void Validacao()
            {
                Console.WriteLine("Verificando Saldo...");
                Console.WriteLine("Saldo disponível");
            }
        }

        public class NubankRewards : NubankCard
        {
            public override void Validacao()
            {
                Console.WriteLine("Verificando pontos Nubank Rewards...");
                Console.WriteLine("Pontos disponíveis");
            }
        }
    }
}
