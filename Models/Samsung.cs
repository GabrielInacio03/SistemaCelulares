using System;

namespace SistemaCelulares.Models
{
    public class Samsung : Celular
    {
        public Samsung(string modelo, string numero)
            : base("Samsung", modelo, numero)
        {
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o Samsung...");
        }

        public override void Desligar()
        {
            Console.WriteLine("Desligando o Samsung...");
        }

        public override void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Samsung enviando mensagem: {mensagem}");
        }
    }
}
