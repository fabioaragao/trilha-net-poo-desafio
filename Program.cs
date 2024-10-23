using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Testando o Nokia
        Smartphone nokia = new Nokia("123456", "Nokia Model 1", "111111111111", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        // Testando o iPhone
        Smartphone iphone = new Iphone("654321", "iPhone Model X", "222222222222", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
