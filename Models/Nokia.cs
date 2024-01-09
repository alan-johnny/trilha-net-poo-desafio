namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero,string modelo,string Imei, int Memoria ) : base(numero,modelo,Imei,Memoria)
        {
            
        }

        
    

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no android ");
        }
    }
}