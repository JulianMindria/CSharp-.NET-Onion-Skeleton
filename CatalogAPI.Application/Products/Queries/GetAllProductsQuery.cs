using CatalogAPI.Application.DTOs;
using MediatR;
using SkeletonApi.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Application.Products.Queries
{
    public class GetAllProductsQuery : IRequest<Result<List<ProductDto>>> { }
}
