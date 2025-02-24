using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_02_cris_palomar
{
    internal class InterfaceSegregation
    {
        public interface IVeiculo
        {
            void LigaVeiculo();
        }

        public interface ICarro : IVeiculo
        {
            void ConfiguraCarro(string cor, int ano, float motor, int assentos, int portas);
        }

        public interface IMoto : IVeiculo
        {
            void ConfiguraMoto(string cor, int ano, float motor);
        }

        public class Carro : ICarro
        {
            public void ConfiguraCarro(string cor, int ano, float motor, int assentos, int portas)
            {
                Console.WriteLine($"Carro configurado: {cor}, {ano}, {motor}cc, {assentos} assentos, {portas} portas.");
            }

            public void LigaVeiculo()
            {
                Console.WriteLine("Ligando o carro...");
            }
        }

        public class Moto : IMoto
        {
            public void ConfiguraMoto(string cor, int ano, float motor)
            {
                Console.WriteLine($"Moto configurada: {cor}, {ano}, {motor}cc.");
            }

            public void LigaVeiculo()
            {
                Console.WriteLine("Ligando a moto...");
            }
        }
    }
}
