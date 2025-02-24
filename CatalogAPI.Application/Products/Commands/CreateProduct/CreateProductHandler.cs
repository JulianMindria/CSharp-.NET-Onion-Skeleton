using AutoMapper;
using MediatR;
using CatalogAPI.Domain.Repositories.ProductRepository;
using System;
using System.Threading;
using System.Threading.Tasks;
using CatalogAPI.Application.DTOs;
using CatalogAPI.Domain.Entities;
using CatalogAPI.Application.Common.Interfaces;

namespace CatalogAPI.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            product.Id = Guid.NewGuid();

            if (request.ProductImage != null)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var fileName = $"{product.Id}{Path.GetExtension(request.ProductImage.FileName)}";
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await request.ProductImage.CopyToAsync(stream);
                }

                product.ProductImage = $"/images/{fileName}"; 
            }

            await _productRepository.AddAsync(product, cancellationToken);
            return product.Id;
        }


    }
}
