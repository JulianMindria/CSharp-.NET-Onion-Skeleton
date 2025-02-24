using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Application.Common.Interfaces
{
    public interface IFileService
    {
        Task<string> SaveFileAsync(byte[] fileData, string fileName);
    }
}

