using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class ProductRepository
    {
        public List<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product
                {
                    Name="1",
                    Price=100,
                    Imgurl="a.png",
                    UniQuality=1

                },
                 new Product
                {
                    Name="2",
                    Price=200,
                    Imgurl="a.png",
                    UniQuality=1

                },
                  new Product
                {
                    Name="3",
                    Price=300,
                    Imgurl="a.png",
                    UniQuality=1

                },
                 new Product
                {
                    Name="4",
                    Price=400,
                    Imgurl="a.png",
                    UniQuality=1

                }
            };
        }
    }
}