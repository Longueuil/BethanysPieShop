using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security;

namespace BethanysPieShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        public readonly IPieRepository _pieRepository;
        public readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(IPieRepository pieRepository, IShoppingCart shoppingCart)
        {
            _pieRepository = pieRepository;
            _shoppingCart = shoppingCart;

        }
    }
    
}
