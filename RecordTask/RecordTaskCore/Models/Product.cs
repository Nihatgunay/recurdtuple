namespace RecordTaskCore.Models;

public class Product
{
    private static int _idcount = 1;
    public int Id { get; set; }
    public string Name { get; set; }
    public double CostPrice { get; set; }
    public double SalePrice { get; set; }
    public Product(string name, double costprice, double saleprice)
    {
        Id = _idcount++;
        Name = name;
        CostPrice = costprice;
        SalePrice = saleprice;

    }
}
