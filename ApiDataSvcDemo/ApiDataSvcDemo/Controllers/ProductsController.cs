using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace ApiDataSvcDemo.Controllers
{
    public class ProductsController : ODataController
    {
        ProductDb ctx = new ProductDb();
        private bool ProductExists(int key)
        {
            return ctx.Products.Any(p => p.ProductID == key);
        }
        [EnableQuery]
        public SingleResult<Product> Get([FromODataUri] int key)
        {
            IQueryable<Product> q = ctx.Products.Where(p => p.ProductID == key);
            return SingleResult.Create<Product>(q);
        }
        [EnableQuery]
        public IQueryable<Product> Get() {
            return ctx.Products;
        }
            
        public async Task<IHttpActionResult> Post(Product p)
        {
            ctx.Products.Add(p);
            await ctx.SaveChangesAsync(); return Created(p);
        }

    }
}
