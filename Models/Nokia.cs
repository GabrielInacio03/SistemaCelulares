using System;

namespace SistemaCelulares.Models
{
    public class Nokia : Celular
    {
        public Nokia(string modelo, string numero)
            : base("Nokia", modelo, numero)
        {
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o Nokia...");
        }

        public override void Desligar()
        {
            Console.WriteLine("Desligando o Nokia...");
        }

        // Mantém o comportamento padrão de enviar mensagem
    }
}
