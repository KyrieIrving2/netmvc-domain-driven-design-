using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManagementForQJDJ.Web.Areas.webapi.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductController : ApiController
    {
        static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Nokia Lumia 1520", Category = "移动电话", Price = 3500 },
            new Product { Id = 2, Name = "Lenovo Thinkpad T430S", Category = "便携式计算机", Price = 8000 },
            new Product { Id = 3, Name = "锤子手机", Category = "移动电话", Price = 3300 } ,
            new Product { Id = 4, Name = "Wii", Category = "电视游戏机", Price = 1000 },
            new Product { Id = 5, Name = "Xbox 360", Category = "电视游戏机", Price = 3200 }
        };
        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProducts()
        {
            return products.OrderBy(p => p.Id);
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound);
                throw new HttpResponseException(resp);
            }

            return product;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <param name="productName">产品名</param>
        /// <returns></returns>
        public Product GetProductByName(string productName)
        {
            Product product = products.FirstOrDefault(p => p.Name.Contains(productName));
            if (product == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound);
                throw new HttpResponseException(resp);
            }

            return product;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <param name="category">类型名称</param>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProductsByCategory(string category)
        {
            if (category.Equals("--请选择--"))
            {
                return products;
            }

            IEnumerable<Product> productList = products.Where(
                p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
            return productList.OrderBy(p => p.Id);
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <returns></returns>
        public bool PostProduct(Product product)
        {
            int index = products.FindIndex(p => p.Name == product.Name);
            if (index != -1)
            {
                return false;
            }
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);
            return true;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <returns></returns>
        public bool PutProduct(int id, [FromBody]Product product)
        {
            int index = products.FindIndex(p => p.Id == id);
            if (index == -1)
            {
                return false;
            }

            products.RemoveAt(index);
            products.Add(product);
            return true;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <returns></returns>
        public bool DeleteProduct(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return false;
            }

            products.Remove(product);
            return true;
        }
    }
}
