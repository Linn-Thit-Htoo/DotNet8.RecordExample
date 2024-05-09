namespace DotNet8.RecordExample;

public class Program
{
    public static void Main(string[] args)
    {
        Product product = new(10, "Product Sample", 10000, 10, true);
        Console.WriteLine(product.ProductName);

        ExampleModel model = new(10, "Linn Thit");
    }
}

public record Product(long ProductId, string ProductName, double Price, int Stock, bool IsActive);

//public class ExampleModel
//{
//    public ExampleModel(long id, string name)
//    {
//        UserId = id;
//        UserName = name;
//    }

//    public long UserId { get; set; }
//    public string UserName { get; set; } = null!;
//}

public record ExampleModel(long UserId, string UserName);