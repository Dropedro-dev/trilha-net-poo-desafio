using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste Nokia:");
var nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Teste Iphone:");
var iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

//nenhuma propriedade além do nomero pode ser alterada diretamente
iphone.Numero = "111222333";
//iphone.Modelo = "iPhone 13"; // Isso não é permitido, pois Modelo é privado
//as demais propriedades devem ser acessadas através de métodos ou construtores