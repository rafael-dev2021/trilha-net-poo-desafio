using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei:"123456789", memoria: 12);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iPhone = new Iphone(numero: "123456", modelo: "Modelo 2", imei:"123456789", memoria: 18);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Telegram");