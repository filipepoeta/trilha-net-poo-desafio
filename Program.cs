using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia");
var nokia = new Nokia(numero: "123456",modelo:" CP45X",imei:"45874412525412",memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone");
var iphone = new Iphone(numero: "975254785",modelo:" 14 PRO MAX",imei:"100547412",memoria:256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");