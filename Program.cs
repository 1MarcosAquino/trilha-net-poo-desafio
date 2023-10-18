using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Y29pc2FzIGVzdHJhbmhlcw== está em Base64 e significa coisas estranhas
// bW9udGUgZGUgY29pc2FzIGVzdHJhbmhhcw== está em Base64 e significa monte de coisas estranhas
// Coloquei assim porque achei que ficaria legal :D

Nokia cel1 = new Nokia("999", "Nokia-X", "Y29pc2FzIGVzdHJhbmhlcw==", 16);
Iphone cel2 = new Iphone("888", "Iphone-20", "bW9udGUgZGUgY29pc2FzIGVzdHJhbmhhcw==", 32);
cel1.Ligar();
cel1.InstalarAplicativo("Linkedin");
cel1.About();

cel2.Ligar();
cel2.InstalarAplicativo("DIO");
cel2.About();
