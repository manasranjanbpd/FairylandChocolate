using AppBusinessLogic;
using AppDataTransfer;
using FairylandChocolate.Models;
using System;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FairylandChocolate.Controllers
{
    public class RootController : Controller
    {

        ProductLogic prod = new ProductLogic();
        // GET: Root
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> GetAllProduct()
        {
            var allProduct = await prod.GetAllProduct();
            return Json(allProduct, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<JsonResult> SaveProduct(Product productData)
        {
            try
            {
                productData.ProductCode = prod.GenerateProductCode(productData.ProductName);

                ProductEntity prodEntity = new ProductEntity();
                prodEntity.ProductCode = productData.ProductCode;
                prodEntity.ProductName = productData.ProductName;
                prodEntity.Keywords = productData.Keywords;
                prodEntity.ShortDescription = productData.ShortDescription;
                prodEntity.LongDescription = productData.LongDescription;
                prodEntity.UnitCost = productData.UnitCost;
                prodEntity.UnitPrice = productData.UnitPrice;
                prodEntity.IsActive = productData.IsActive;
                prodEntity.CategoryId = productData.CategoryId;

                string msg;
                var check = await prod.SaveProducts(prodEntity);
                if (check)
                    msg = "Product successfully added";
                else
                    msg = "Product addition failed";

                return Json(new { message = msg, status = check }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { message = "Your request was not processed successfully! Please try again", status = false }, JsonRequestBehavior.AllowGet);
            }
        }
        
        [HttpPost]
        public async Task<JsonResult> GetProductById(string productId)
        {
            var productDetails = await prod.GetProductById(productId);
            return Json(productDetails, JsonRequestBehavior.AllowGet);
        }

        [HttpDelete]
        public async Task<JsonResult> DeleteProduct(string productId)
        {
            var productDetails = await prod.DeleteProductById(productId);
            return Json(productDetails, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<JsonResult> UpdateProduct(Product productData)
        {
            try
            {
                productData.ProductCode = prod.GenerateProductCode(productData.ProductName);

                ProductEntity prodEntity = new ProductEntity();
                prodEntity.ProductCode = productData.ProductCode;
                prodEntity.ProductName = productData.ProductName;
                prodEntity.Keywords = productData.Keywords;
                prodEntity.ShortDescription = productData.ShortDescription;
                prodEntity.LongDescription = productData.LongDescription;
                prodEntity.UnitCost = productData.UnitCost;
                prodEntity.UnitPrice = productData.UnitPrice;
                prodEntity.IsActive = productData.IsActive;
                prodEntity.CategoryId = productData.CategoryId;

                var check = await prod.UpdateProduct(prodEntity);

                return Json(check, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}