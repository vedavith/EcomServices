using CrudUsingReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace CrudUsingReact.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        public List<Product> products { get; set; }
        Response setResponse;
        EcomEntities _product = new EcomEntities();
        
        [Route("all")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetAllProducts()
        {
            try
            {
                var products = _product.Products.ToList();
               return Request.CreateResponse(System.Net.HttpStatusCode.OK, products);
            }
            catch(Exception ex)
            {
                setResponse = new Response
                {
                    Status = "BadRequest",
                    Message = ex.Message
                };

                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, setResponse);
            }
        }

        [Route("product/{category}")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetProductsOnCategory(string category) 
        {
            try
            {
                this.products = _product.Products.Where(x => x.ProductCategory == category).ToList();
                return Request.CreateResponse(System.Net.HttpStatusCode.OK, this.products);
            }
            catch (Exception ex)
            {
                setResponse = new Response
                {
                    Status = "BadRequest",
                    Message = ex.Message
                };

                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, setResponse);
            } 
        }
        public string GetProductsOnRange(int fromRange, int toRange, string productCategory) { return "";  }
        public string GetProductsOnPagination(int page = 1) { return ""; }
    }
}
