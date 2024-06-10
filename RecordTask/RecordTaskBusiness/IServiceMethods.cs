namespace RecordTaskBusiness;

public interface IServiceMethods
{
    public void Create(ProductCreateDto productCreateDto);
    public ProductGetDto Get(int id);
    public List<ProductGetDto> GetAll();
    public void Delete(int id);
}
