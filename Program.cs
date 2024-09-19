using DesafioPOO.Models;

Console.WriteLine("------------------------------------------");
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "(99) 99999-9999", modelo: "ModeloX", imei: "00000000", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("------------------------------------------");

Console.WriteLine("Smartphone iPhone");
Iphone iphone = new Iphone(numero: "(11) 11111-1111", modelo: "ModeloY", imei: "11111111", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine("------------------------------------------");