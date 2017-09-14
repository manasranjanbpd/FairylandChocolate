using AppDataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppDataAccess
{
    public class ProductData
    {
        public async Task<bool> SaveProduct(ProductEntity prodData)
        {
            bool insertCheck = false;
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri("http://localhost:12461/");

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var values = CastFrom(prodData);
                var content = new FormUrlEncodedContent(values);

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpResponseMessage Res = await client.PostAsync("api/Product/SaveProduct", content);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var check = Res.Content.ReadAsStringAsync().Result;
                    insertCheck = check == "true" ? true : false;

                }
                //returning the employee list to view  
            }
            return insertCheck;
        }

        public async Task<string> GetAllProducts()
        {
            string allProduct = "";
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri("http://localhost:12461/");

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Product/GetAllProducts");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var check = Res.Content.ReadAsStringAsync().Result;
                    allProduct = check;
                }
            }
            return allProduct;
        }

        public async Task<string> GetProductById(string productId)
        {
            string productDetails = "";
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri("http://localhost:12461/");

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var values = CastFrom(new { productId = productId });
                var content = new FormUrlEncodedContent(values);

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.PostAsync("api/Product/GetProductById",content);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var check = Res.Content.ReadAsStringAsync().Result;
                    productDetails = check;
                }
            }
            return productDetails;
        }
        public async Task<bool> DeleteProductById(string productId)
        {
            bool insertCheck = false;
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri("http://localhost:12461/");

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var values = CastFrom(new { productId = productId });
                var content = new FormUrlEncodedContent(values);

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.PostAsync("api/Product/DeleteProductById", content);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var check = Res.Content.ReadAsStringAsync().Result;
                    insertCheck = check == "true" ? true : false;
                }
            }
            return insertCheck;
        }

        public async Task<bool> UpdateProduct(ProductEntity prodData)
        {
            bool insertCheck = false;
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri("http://localhost:12461/");

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var values = CastFrom(prodData);
                var content = new FormUrlEncodedContent(values);

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpResponseMessage Res = await client.PostAsync("api/Product/UpdateProduct", content);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var check = Res.Content.ReadAsStringAsync().Result;
                    insertCheck = check == "true" ? true : false;

                }
                //returning the employee list to view  
            }
            return insertCheck;
        }

        private static Dictionary<string, string> CastFrom(Object obj)
        {
            try
            {
                return (from x in obj.GetType().GetProperties() select x).ToDictionary(x => x.Name, x => (x.GetGetMethod().Invoke(obj, null) == null ? "" : x.GetGetMethod().Invoke(obj, null).ToString()));
            }
            catch (Exception)
            {                
                throw new ArgumentException(" ### -> public static KeyValuePair<object , object > CastFrom(Object obj) : Error : obj argument must be KeyValuePair<,>");
            }            
        }
    }
}
