using System.Collections.Generic;
using bookpapp.webui.Models;
using bookpapp.webui.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bookpapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index(){
            return View();
        }
         public IActionResult List(){
             var product = new List<Product>(){
           new Product{Name="Iphone 8", Price=3000,Description="İyi telefon"},
           new Product{Name="Iphone X", Price=6000,Description="Güzel telefon"}
            };


            var category = new Category { Name = "Telefon", Description = "Telefon kateogrisi" };
            //paketleyip göndereceğim
            var productsViewModel = new ProductViewModel//her ikisinide kullanmak için progda viewmodels klasörü açtım içine category ve list ekledim
            {
                Category = category, //burada oluşturduğum category ve productu productview modele gönderdim
                Product = product
            };

            return View(productsViewModel);//burdanda viewe gönderdim ve şimdi productsviewmodeli @model ..... olarak başa yazacağım
        }
         public IActionResult Details(int id){
             var p=new Product();
             p.Name="Samsung s8";
             p.Price=2000;
             p.Description="Çok iyi";
            return View(p);
        }
    }
}