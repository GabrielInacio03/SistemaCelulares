using SistemaCelulares.Models;
using System;

namespace SistemaCelulares
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular samsung = new Samsung("Galaxy S21", "123-456-7890");
            samsung.Ligar();
            samsung.EnviarMensagem("Olá, este é um teste de mensagem!");
            samsung.Desligar();

            Celular apple = new Apple("iPhone 13", "098-765-4321");
            apple.Ligar();
            apple.EnviarMensagem("Oi, estou enviando uma mensagem pelo iPhone!");
            apple.Desligar();

            Celular nokia = new Nokia("Nokia 3310", "555-555-5555");
            nokia.Ligar();
            nokia.EnviarMensagem("Mensagem de um Nokia clássico!");
            nokia.Desligar();
        }
    }
}
