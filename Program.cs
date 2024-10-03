using DesafioPOO.Models;

Smartphone nokia = new Nokia("999179636", "Nokia 10", "12345678", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Smartphone iphone = new Iphone("2313123123", "Iphone XR", "2222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");