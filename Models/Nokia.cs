namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero) { }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            try
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao instalar o aplicativo: {ex.Message}");
            }
        }
    }
}