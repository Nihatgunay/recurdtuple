
using RecordTaskCore.Models;
using RecordTaskDatabase;

namespace RecordTaskBusiness;

public class ServiceMethod : IServiceMethods
{
    public void Create(ProductCreateDto productCreateDto)
    {
        Product product = new Product(productCreateDto.Name, productCreateDto.CostPrice, productCreateDto.SalePrice);
        Database.Products.Add(product);
    }

    public void Delete(int id)
    {
        Product? product = Database.Products.Find(x => x.Id == id);
        if (product != null)
        {
            Database.Products.Remove(product);
        }
        else
        {
            throw new NullReferenceException(); 
        }
    }

    public ProductGetDto Get(int id)
    {
        Product? product = Database.Products.Find(x => x.Id == id);
        if (product != null)
        {
            return new ProductGetDto { Id = product.Id, Name = product.Name, SalePrice = product.SalePrice };            
        }
        return null;
    }

    public List<ProductGetDto> GetAll()
    {
        return Database.Products.Select(x => new ProductGetDto
        { 
            Id = x.Id,
            Name = x.Name,
            SalePrice = x.SalePrice,
        }).ToList();
    }
}
