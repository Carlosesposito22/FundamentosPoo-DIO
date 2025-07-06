using Desafio03_DIO.Models;

Console.WriteLine("Smartohone Nokia:");
Smartphone nokia = new Nokia("45677654", "Nokia Tijolo", "000000001", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Smartohone Iphone:");
Smartphone ihpone = new Iphone("12332142", "Iphone 6s", "99999999", 256);
ihpone.Ligar();
ihpone.InstalarAplicativo("Telegram");

