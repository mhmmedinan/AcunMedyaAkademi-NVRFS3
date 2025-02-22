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


//Console.Write("Lütfen geçerli bir not giriniz : ");
//int assigment = Convert.ToInt32(Console.ReadLine());


//if(assigment<=100 && assigment >= 81)
//{
//    Console.WriteLine("AA");
//}
//else if (assigment<=80 && assigment>=71)
//{
//    Console.WriteLine("BA");
//}
//else if(assigment<=70 && assigment >= 51)
//{
//    Console.WriteLine("CC");
//}
//else
//{
//    Console.WriteLine("Geçersiz Sayı");
//}


//loops
//for,foreach,while,do-while

for(int i = 0; i <= 20; i++)
{
    Console.WriteLine(i);
}

//Console.Write("Lütfen bir sayı giriniz : ");
//int numberFactorial = Convert.ToInt32(Console.ReadLine());

//int total = 1;

////for(int i = 1; i <= numberFactorial; i++)
////{
////    total *= i;
////}


//Console.WriteLine($"Factorial of {numberFactorial} is {total}");

//int[] numbers = new int[3];
//numbers[0] = 10;
//numbers[1] = 20;
//numbers[2] = 30;

//for(int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}


string[] names = { "Eşref", "Yakup", "Hasan", "Ceren" };
foreach(string name in names)
{
    Console.WriteLine(name);
}
names[3] = "Mehmet";
foreach (string name in names)
{
    Console.WriteLine(name);
}


int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int max = numbers[0];
int min = numbers[0];

for(int i = 1; i < numbers.Length; i++)
{
    if (numbers[i]>max)
        max = numbers[i];
    if (numbers[i]<min)
        min = numbers[i];
}

Console.WriteLine($"Max : {max} Min : {min}");


//list
//List<string> names1 = new List<string>();
//names1.Add("Eşref");
//names1.Add("Yakup");
//names1.Add("Hasan");

//foreach(string name in names1)
//{
//    Console.WriteLine(name);
//}


List<string> names1 = new List<string> { "Eşref", "Yakup", "Hasan" };
foreach (string name in names1)
{
    Console.WriteLine(name);
}


List<string> baskets = new List<string> { "Apple", "Banana", "Orange", "Pineapple" };

Console.Write("Lütfen sepetten silmek istediğiniz ürünü seçin :  ");
string deleteBasket = Console.ReadLine();

if (baskets.Contains(deleteBasket))
{
    baskets.Remove(deleteBasket);
    Console.WriteLine($" {deleteBasket} İsimli Ürün sepetten silindi!");
}
else
{
    Console.WriteLine("Ürün sepetinizde bulunmamaktadır!");
}

Console.WriteLine("Sepetinizdeki ürünler : "); 
foreach(string basket in baskets)
{
    Console.WriteLine(basket);
}