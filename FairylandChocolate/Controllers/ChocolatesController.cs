using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FairylandChocolate.Models;

namespace FairylandChocolate.Controllers
{
    public class ChocolatesController : Controller
    {
        public ActionResult Index(string id)
        {
            ProductModel modelObject = new ProductModel();
            if(id=="Flower Pattern Box"){
				modelObject.ProductName = "Flower Pattern Blue Box";
				modelObject.CategoryName = "FriendShip Day Boxes";
				modelObject.ProductImageSrc = "/images/flower_pattern_blue_open_box.jpg";
				modelObject.ProductDesc = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque\n                    penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec,\n                    pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla\n                    vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae,\n                    justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt.";
				modelObject.ProductIsActive = true;
				modelObject.ProductPrice = 245.0;
			}
            else
                if(id=="Golden Dazzling Box"){
				modelObject.ProductName = "Golden Dazzling Box";
				modelObject.CategoryName = "FriendShip Day Boxes";
				modelObject.ProductImageSrc = "/images/Golden_Dazzling_fd_box.jpg";
				modelObject.ProductDesc = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque\n                    penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec,\n                    pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla\n                    vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae,\n                    justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt.";
                modelObject.ProductIsActive = false;
				modelObject.ProductPrice = 255.0;
                }
                    
            return View(modelObject);
        }

        public ActionResult Category(string id)
        {
            var categoryName = id;
			CategoryModel modelObject = new CategoryModel();
            modelObject.CategoryName = id;
            List<ProductModel> products = new List<ProductModel>();
			if (id == "FriendShip Day Boxes")
			{
                for (int i = 0; i < 20; i++)
                {
					ProductModel modelProduct = new ProductModel()
					{
						ProductName = "Flower Pattern Blue Box",
						CategoryName = "FriendShip Day Boxes",
						ProductImageSrc = "/images/flower_pattern_blue_open_box.jpg",
						ProductDesc = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque\n                    penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec,\n                    pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla\n                    vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae,\n                    justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt.",
						ProductIsActive = true,
						ProductPrice = 245.0
					};
					products.Add(modelProduct);
					ProductModel modelProduct2 = new ProductModel()
					{
						ProductName = "Golden Dazzling Box",
						CategoryName = "FriendShip Day Boxes",
						ProductImageSrc = "/images/Golden_Dazzling_fd_box.jpg",
						ProductDesc = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque\n                    penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec,\n                    pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla\n                    vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae,\n                    justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt.",
						ProductIsActive = true,
						ProductPrice = 245.0
					};
					products.Add(modelProduct2);
                }

				
			}
            modelObject.AllProducts = products;
			return View(modelObject);
		}
    }
}
