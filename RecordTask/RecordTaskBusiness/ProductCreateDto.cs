namespace RecordTaskBusiness;

public record ProductCreateDto
{
    public string Name { get; set; }
    public double SalePrice { get; set; }
    public double CostPrice { get; set; }

}
