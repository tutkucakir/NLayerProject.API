using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    public interface IProductService:IService<Product>
    {
        //bool ControlInnerBarcode(Product product); Sadece örnek vermek için

        Task<Product> GetWithCategoryByIdAsync(int productId);

    }
}
