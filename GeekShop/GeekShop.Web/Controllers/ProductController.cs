﻿using GeekShop.Web.Models;
using GeekShop.Web.Services.IServices;
using GeekShop.Web.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShop.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Authorize]
        public async Task<IActionResult> ProductIndex()
        {
            var products = await _productService.FindAllProducts();
            return View(products);
        }

        public IActionResult ProductCreate()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.CreateProduct(model);
                if (response != null)
                    return RedirectToAction(nameof(ProductIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> ProductUpdate(int id)
        {
            var model = await _productService.FindById(id);
            if (model != null)
                return View(model);
            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.UpdateProduct(model);
                if (response != null)
                    return RedirectToAction(nameof(ProductIndex));
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> ProductDelete(int id)
        {
            var model = await _productService.FindById(id);
            if (model != null)
                return View(model);
            return NotFound();
        }

        [HttpPost]
        [Authorize(Roles = Role.Admin)]
        public async Task<IActionResult> ProductDelete(ProductModel model)
        {
            var response = await _productService.DeleteProductById(model.Id);
            if (response)
                return RedirectToAction(nameof(ProductIndex));
            return View(model);
        }
    }
}