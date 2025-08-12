using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto do tipo Nokia
        Smartphone nokia = new Nokia("123456789");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        // Criando um objeto do tipo Iphone
        Smartphone iphone = new Iphone("987654321");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}