using System;

namespace SistemaCelulares.Models
{
    public abstract class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Numero { get; set; }

        public Celular(string marca, string modelo, string numero)
        {
            Marca = marca;
            Modelo = modelo;
            Numero = numero;
        }

        public abstract void Ligar();

        public abstract void Desligar();

        public virtual void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Mensagem enviada: {mensagem}");
        }
    }
}
