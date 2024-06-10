namespace RecordTaskBusiness;

public record ProductGetDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double SalePrice { get; set; }

}
