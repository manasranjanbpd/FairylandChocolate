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
    }
}
