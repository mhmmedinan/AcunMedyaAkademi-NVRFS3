// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Hello, World!");

Product product = new Product();
product.Id = 1;                         //property'lerin set metotlarına erişim
product.Name = "Laptop";
product.Stock = 10;


//product.SetProductId(2);                  //private set metotlarına erişim

//Console.WriteLine(product.GetProductId());          //property'lerin get metotlarına erişim


//product.ProductName = null;             //property'lerin get ve set metotlarına erişim
//Console.WriteLine(product.ProductName);      //property'lerin get ve set metotlarına erişim


Category category = new Category(1,"Elektronik");

Product product1 = new Product();
product1.Id = 2;
product1.Name = "Telefon";
product1.Stock = 20;
product1.CreatedDate = DateTime.Now;

Console.WriteLine(product1.CreatedDate);


ProductManager productManager = new ProductManager();
productManager.Add(product1);

List<Product> products = productManager.GetAll();
foreach (var item in products)
{
    Console.WriteLine(item.Name);
}