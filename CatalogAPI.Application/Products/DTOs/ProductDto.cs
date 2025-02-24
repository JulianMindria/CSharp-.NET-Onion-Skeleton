namespace CatalogAPI.Application.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? BrandId { get; set; }
        public Guid? CategoryId { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public List<PSubDetailDto> SubDetails { get; set; }
        public List<ProductImageDto> Images { get; set; }
        public ProductBrandDto Brand { get; set; }
        public ProductCategoryDto Category { get; set; }
        public ProductTypeDto Type { get; set; }
    }

    public class ProductBrandDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductCategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductTypeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductImageDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class PSubDetailTypeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class PSubDetailDto
    {
        public Guid Id { get; set; }
        public Guid TypeId { get; set; }
        public string TypeName { get; set; }
        public string Value { get; set; }
    }
}
