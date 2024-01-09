namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set; }
        protected int Memoria { get; set;}
        protected string Imei { get; set; }        

        public Smartphone(string numero, string modelo,string Imei, int Memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.Modelo = modelo;
            this.Imei = Imei;
            this.Memoria = Memoria;

        }

        protected Smartphone(string numero)
        {
            Numero = numero;
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