namespace CatalogAPI.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? BrandId { get; set; }
        public Guid? CategoryId { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public ICollection<PSubDetail> SubDetails { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public ProductBrand Brand { get; set; }
        public ProductCategory Category { get; set; }
        public ProductType Type { get; set; }
    }

    public class ProductBrand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }

    public class ProductCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    public class ProductType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    public class ProductImage
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }  
        public string Name { get; set; }

        public Product Product { get; set; }
    }

    public class PSubDetailType
    {
        public Guid Id { get; set; }  
        public string Name { get; set; }
        public ICollection<PSubDetail> SubDetails { get; set; }
    }

    public class PSubDetail
    {
        public Guid Id { get; set; } 
        public Guid ProductId { get; set; }  
        public Guid TypeId { get; set; }  
        public string Value { get; set; }
        public Product Product { get; set; }
        public PSubDetailType Type { get; set; }
    }
}
