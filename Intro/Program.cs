// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

       //camelCase
string productName = "Ahi Evran Form Kahvesi";


byte number1 = 255; // 8 bit 1 byte 
short number2 = 32767; // 16 bit 2 byte
int number3 = 2147483647; // 32 4 byte
long number4 = 500; // 64 bit 8 byte


//identity number 

// matematiksel işlem yapılmayan her tam sayı string türündedir.

double number5 = 299.99;
decimal number6 = 299.99M;
float number7 = 299.99F;

double number8 = 200;
//tam sayı veri tiplerinde ondalıklı değer atanmaz! 
// ondalıklı veri tiplerinde tam sayı atanabilir.


char gender = 'K';
bool login = false;

var number = 50.99;


//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);
//Console.WriteLine(productName);



// Değer tipler

int number10 = 10;
int number11 = 12;
number10=number11;
Console.WriteLine(number10);


//Conditials

//Console.Write("Hesap Bakiyenizi Giriniz : ");
//double accountBalance = Convert.ToDouble(Console.ReadLine());

//Console.Write("Çekmek istediğiniz miktarı giriniz : ");
//double amount = Convert.ToDouble(Console.ReadLine());


//if (amount <= accountBalance)
//{
//    accountBalance -= amount;
//    Console.WriteLine("Para çekme işlemi başarılı! Güncel bakiye" + " " + accountBalance);
//}
//else
//{
//    Console.WriteLine("Yetersiz bakiye!");
//}


//string correctUsername = "admin";
//string correctPassword = "123456";

//Console.Write("Kullanıcı Adı : ");
//string username = Console.ReadLine();

//Console.Write("Şifre : ");
//string password = Console.ReadLine();

//if(username == correctUsername && password == correctPassword)
//{
//    Console.WriteLine("Giriş başarılı!");
//}
//else
//{
//    Console.WriteLine("Hatalı kullanıcı adı veya şifre");
//}


Console.Write("Lütfen geçerli bir not giriniz : ");
int assigment = Convert.ToInt32(Console.ReadLine());


if(assigment<=100 && assigment >= 81)
{
    Console.WriteLine("AA");
}
else if (assigment<=80 && assigment>=71)
{
    Console.WriteLine("BA");
}
else if(assigment<=70 && assigment >= 51)
{
    Console.WriteLine("CC");
}
else
{
    Console.WriteLine("Geçersiz Sayı");
}




