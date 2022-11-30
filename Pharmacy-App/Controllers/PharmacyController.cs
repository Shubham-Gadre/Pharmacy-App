using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Pharmacy_App.Models;

namespace Pharmacy_App.Controllers
{
    public class PharmacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDetailPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewProduct(MedicinesViewModel _medicinetModel)
        {

            
            if (ModelState.IsValid)
            {
               
                //getproduct
                //getproductbyid
                //deleteproduct
                //createproduct[Save]
                //update/editproduct
            }

            return View("Index");
        }
    }
}
