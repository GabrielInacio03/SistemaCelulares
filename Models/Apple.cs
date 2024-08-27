using System;

namespace SistemaCelulares.Models
{
    public class Apple : Celular
    {
        public Apple(string modelo, string numero)
            : base("Apple", modelo, numero)
        {
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o iPhone...");
        }

        public override void Desligar()
        {
            Console.WriteLine("Desligando o iPhone...");
        }

        public override void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"iPhone enviando mensagem: {mensagem}");
        }
    }
}
