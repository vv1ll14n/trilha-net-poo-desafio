using System.Security.AccessControl;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("55555", "nokia", "000000001", 64);
Iphone iphone = new Iphone("55555", "iphone", "000000001", 128);

Console.WriteLine("Nokia --");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Iphone --");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");