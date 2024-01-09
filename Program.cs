using System.ComponentModel.DataAnnotations;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("smartphone android");
Smartphone nokia = new Nokia(numero:"123456", modelo:"model-1", Imei:"111111", Memoria:8);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

 Console.WriteLine("\n");

 Console.WriteLine("smartphone iphone");
Smartphone iphone = new Iphone(numero:"654123", modelo:"model-14", Imei:"222222", Memoria:16);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");





 ///



