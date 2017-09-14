using AppDataAccess;
using AppDataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusinessLogic
{
    public class ProductLogic
    {
        public string GenerateProductCode(string name)
        {
            string productCode = string.Empty;
            productCode = name.ToUpperInvariant().Substring(0, 4) + DateTime.Now.ToString("mmmddyyyy");
            return productCode;
        }

        public async Task<bool> SaveProducts(ProductEntity data)
        {
            try
            {
                bool check = false;
                ProductData prd = new ProductData();
                check = await prd.SaveProduct(data);
                return check;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public async Task<string> GetAllProduct()
        {
            try
            {
                ProductData prd = new ProductData();
                var allProduct = await prd.GetAllProducts();
                return allProduct;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> GetProductById(string productId)
        {
            try
            {
                ProductData prd = new ProductData();
                var product = await prd.GetProductById(productId);
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> DeleteProductById(string productId)
        {
            try
            {
                ProductData prd = new ProductData();
                var product = await prd.DeleteProductById(productId);
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateProduct(ProductEntity prodEntity)
        {
            try
            {
                bool check = false;
                ProductData prd = new ProductData();
                check = await prd.UpdateProduct(prodEntity);
                return check;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
