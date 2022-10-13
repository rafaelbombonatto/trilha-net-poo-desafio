using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Realizando Testes no Nokia
Console.WriteLine("Testes no Nokia");
Nokia nokia = new Nokia("19981818181","ZPTO 2000", "321as32a1s3a1s",256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("DIO");

// Realizando Testes no  IPHONE
Console.WriteLine("Testes no IPhone");
Iphone iphone = new Iphone("19981818181","ixy 15b", "121asa123121",1000);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DIO");