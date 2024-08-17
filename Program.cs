using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", "16GB");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone("987654321", "iPhone 12", "987654321", "128GB");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
