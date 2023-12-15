namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; protected set; }
        public string Modelo { get; protected set; }
        public string IMEI { get; protected set; }
        public int Memoria { get; protected set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}