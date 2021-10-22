using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductAndOffersApplication.Model;

namespace ProductAndOffersApplication.Services
{

    public interface IOfferServices
    {
        List<Product> GetAllProducts();
        List<Offers> GetTodayOffers();

    }
    public class OfferServices : IOfferServices
    {
        private readonly List<Product> _inventory = new List<Product>();

        public OfferServices()
        {
            CreateProductList();
        }

        public List<Product> GetAllProducts()
        {
            if (_inventory.Count > 0)
                return _inventory;

            return new List<Product>();
        }

        public List<Offers> GetTodayOffers()
        {
            var offers = new List<Offers>();
            for (int i = 0; i < 4; i++)
            {
                offers.Add(new Offers()
                {
                    OfferName = "ComboPackage" + Convert.ToString(i),
                    Product = GetAllProducts().Take(4).ToList()
                });
            }
            return offers;
        }

        private List<Product> CreateProductList()
        {
            _inventory.Add(new Product()
            {
                Description = "P1 desc",
                Price = 1000,
                ProductName = "P1"
            });
            _inventory.Add(new Product()
            {
                Description = "P2 desc",
                Price = 200,
                ProductName = "P2"
            });
            _inventory.Add(new Product()
            {
                Description = "p3 desc",
                Price = 400,
                ProductName = "p3"
            });
            _inventory.Add(new Product()
            {
                Description = "P4 desc",
                Price = 700,
                ProductName = "P4"
            });
            _inventory.Add(new Product()
            {
                Description = "P5 desc",
                Price = 600,
                ProductName = "P5"
            });
            _inventory.Add(new Product()
            {
                Description = "P6 desc",
                Price = 800,
                ProductName = "P6"
            });

            return _inventory;
        }
    }
}