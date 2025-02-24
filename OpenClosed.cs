using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_02_cris_palomar
{
    internal class OpenClosed
    {
        public abstract class Veiculo
        {
            protected string cor;
            protected int ano;
            protected double motor;

            public Veiculo(string cor, int ano, double motor)
            {
                this.cor = cor;
                this.ano = ano;
                this.motor = motor;
            }

            public abstract void CriarVeiculo();

            public void LigaMotor()
            {
                Console.WriteLine("Ligando os motores...");
            }
        }

        public class Carro : Veiculo
        {
            private int assentos;
            private int portas;

            public Carro(string cor, int ano, double motor, int assentos, int portas)
                : base(cor, ano, motor)
            {
                this.assentos = assentos;
                this.portas = portas;
            }

            public override void CriarVeiculo()
            {
                Console.WriteLine($"Criando um carro {cor}, {ano}, {motor} cilindradas, {portas} portas e {assentos} assentos");
                LigaMotor();
            }
        }

        public class Moto : Veiculo
        {
            public Moto(string cor, int ano, double motor)
                : base(cor, ano, motor)
            {
            }

            public override void CriarVeiculo()
            {
                Console.WriteLine($"Criando uma moto {cor}, {ano}, {motor} cilindradas");
                LigaMotor();
            }
        }
    }
}
