namespace OOP;

public class ProductManager
{

    private List<Product> _products;


    //Constructor => Bir sınıf new'lenirken çalışan bloktur.

    //Dependency Injection

    public ProductManager()
    {
        _products = new List<Product>();
        _products.Add(new Product { Id = 1, Name = "Laptop", Stock = 10 });
        _products.Add(new Product(1,"Masa",10));
    }


    public void Add(Product product)
    {
       _products.Add(product);
        
    }

    public List<Product> GetAll()
    {
        return _products;
    }


    //kötü kod pratiği 


    //public void Add()
    //{
    //    Category category = new Category();
    //    category.Id = 1;
    //    category.Name = "Elektronik";
    //    category.CreatedDate = DateTime.Now;
    //    Console.WriteLine(category.CreatedDate);
    //}



    //public void Add(Product product)
    //{
    //    List<Product> products = new List<Product>();
    //    products.Add(product);
    //}

    //public List<Product> GetAll()
    //{
    //    List<Product> products = new List<Product>();
    //    return products;
    //}
}


//Customer => Individual and Corporate sınıflarını oluşturunuz.
//Corporate sınıfında kapsüllemeyi deneyin.
//IndividualCustomerManager sınıfı oluşturunuz.
//Add,GetList,Delete,GetById metotlarını ekleyiniz.