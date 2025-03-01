namespace OOP;

//Generic Class
public abstract class BaseEntity<TId>
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }
}

//bir class sadece bir class'tan ve abstract classtan miras alabilir.
//abstract classlar new'lenemezler. onu kalıtım alan classlar new'lenebilir.
//abstract classlar içerisinde abstract olmayan metotlar da tanımlanabilir.
//abstract classlar içerisinde abstract metotlar tanımlanabilir.
