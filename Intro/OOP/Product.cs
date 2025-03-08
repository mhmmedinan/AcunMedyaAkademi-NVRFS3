namespace OOP;


//sınıf isimlendirmeleri PascalCase olmalıdır.
public class Product:BaseEntity<int>
{
    //property isimlendirmeleri PascalCase olmalıdır.
    public string Name { get; set; }
    public double Stock { get; set; }

    public Product(int id,string name, double stock)
    {
        Id = id;
        Name = name;
        Stock = stock;
    }

    public Product()
    {
        
    }





    //Encaplusation (Kapsülleme) => field'ları private yaparak dışarıdan erişimi kısıtlamak.


    //1. Kullanım 

    //public int ProductId { private get; private set; }


    //2. Kullanım

    //private int ProductId { get; set; }
    //private string ProductName { get; set; }
    //private double ProductStock { get; set; }


    //public void SetProductId(int productId)
    //{
    //    ProductId = productId;
    //}

    //public int GetProductId()
    //{
    //    return ProductId;
    //}

    //private string name;

    //// 3. Kullanım
    //public string ProductName 
    //{ 
    //    get { return name; } 
    //    set {
    //        if (!string.IsNullOrEmpty(value))
    //            name = value;
    //        else 
    //            Console.WriteLine("Ürün ismi boş olamaz.");
    //    }
    //}





}




//internal => sadece aynı assembly içerisinden erişilebilir.
//public => her yerden erişilebilir.
//private => sadece tanımlandığı sınıf içerisinden erişilebilir.
//protected => tanımlandığı sınıf ve bu sınıftan türetilen sınıflardan erişilebilir.
//internal protected => tanımlandığı assembly içerisinden ve bu sınıftan türetilen sınıflardan erişilebilir.