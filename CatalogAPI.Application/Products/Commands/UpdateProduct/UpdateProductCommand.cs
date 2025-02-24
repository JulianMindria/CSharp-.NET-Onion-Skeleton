using CatalogAPI.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<ProductDto>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public Guid TypeId { get; set; }
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
    }
}
