using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ProductAndOffersApplication.Model;
using ProductAndOffersApplication.Services;

namespace ProductAndOffersApplication.Controllers
{
    public class GetOffersDetails : ApiController
    {
        private readonly IOfferServices _offerService;
        public GetOffersDetails(IOfferServices offerService)
        {
            _offerService = offerService;
        }

        [HttpGet]
        public async Task<List<Offers>> GetOffers()
        {
            return _offerService.GetTodayOffers();
        }

        [HttpGet]
        public async Task<List<Product>> GetTopThreeLowestPriceProduct()
        {
            var product = _offerService.GetAllProducts();
            return product.OrderBy(q => q.Price).Take(3).ToList();
        }

        [HttpGet]
        public async Task<Product> GetSecondLowestPriceProduct()
        {
            var product = _offerService.GetAllProducts();
            var secondPRodcut = product.OrderByDescending(q => q.Price).Take(2).ToList();
            return secondPRodcut.OrderBy(q => q.Price).FirstOrDefault();
        }

        [HttpPost]
        public async Task<List<Product>> AddProduct([FromBody] Product request)
        {
            var product = _offerService.GetAllProducts();
            product.Add(request);
            return product;
        }


    }
}