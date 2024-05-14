namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"(FEITO)
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }


        // TODO: Sobrescrever o método "InstalarAplicativo" (FEITO)
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando: {nomeApp}");
        }
    }
}