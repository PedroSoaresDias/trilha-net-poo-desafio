using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("222525", "Tijolão", "1111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone");
Iphone ios = new Iphone("22465", "13 Pro", "265", 256);
ios.ReceberLigacao();
ios.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Xiaomi");
Xiaomi xiaomi = new Xiaomi("25415", "Poco X3", "622", 128);
xiaomi.Ligar();
xiaomi.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Samsung");
Samsung sam = new Samsung("456852", "Galaxy S20", "235", 128);
sam.ReceberLigacao();
sam.InstalarAplicativo("Twitch");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Motorola");
Motorola moto = new Motorola("265235", "G7", "455", 64);
moto.Ligar();
moto.InstalarAplicativo("TikTok");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Asus");
Asus asus = new Asus("532257", "Zenfone 9", "312", 256);
asus.ReceberLigacao();
asus.InstalarAplicativo("Twitter");