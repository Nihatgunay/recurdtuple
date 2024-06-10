using RecordTaskBusiness;

namespace RecordTaskCA;

internal class Program
{
    static void Main(string[] args)
    {
        IServiceMethods service = new ServiceMethod();
        ProductCreateDto productcreatedto1 = new ProductCreateDto();
        productcreatedto1.Name = "Iphone 15"; 
        productcreatedto1.CostPrice = 1000;
        productcreatedto1.SalePrice = 1500;
        service.Create(productcreatedto1);

        service.Get(1);
        Console.WriteLine(productcreatedto1);
        service.GetAll();
        service.Delete(1);
        
    }
}
