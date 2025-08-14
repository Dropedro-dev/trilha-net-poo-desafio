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
//iphone.Numero = "111222333";
//iphone.Modelo = "iPhone 13"; // Isso não é permitido, pois Modelo é privado
//as demais propriedades devem ser acessadas através de métodos ou construtores

//TODO: Implementar testes com número inválido
//iphone.Numero = "123"; // Isso deve lançar uma exceção, pois o número deve ter de 9 a 14 dígitos
//iphone.Numero = "1234567890123456"; // Isso deve lançar uma exceção, pois o número não pode ter mais de 15 dígitos
//iphone.Numero = "12345678a"; // Isso deve lançar uma exceção, pois o número deve conter apenas dígitos
//iphone.Numero = ""; // Isso deve lançar uma exceção, pois o número não pode ser nulo ou vazio
//iphone.Ligar(); // Isso não deve ser executado, pois o número é inválido
//iphone.Numero = "123456789a"; // Isso deve lançar uma exceção, pois o número deve conter apenas dígitos
//iphone.ReceberLigacao(); // Isso não deve ser executado, pois o número é inválido