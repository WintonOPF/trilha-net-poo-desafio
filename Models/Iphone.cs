namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            try
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao instalar o aplicativo: {ex.Message}");
            }
        }
    }
}