using CatalogAPI.Application.DTOs;
using MediatR;
using SkeletonApi.Shared;
using System;

namespace CatalogAPI.Application.Products.Queries
{
    public class GetProductByIdQuery : IRequest<Result<ProductDto>>
    {
        public Guid Id { get; set; }
        public GetProductByIdQuery(Guid id) => Id = id;
    }
}
