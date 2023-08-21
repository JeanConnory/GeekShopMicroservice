﻿using GeekShop.Web.Models;
using GeekShop.Web.Services.IServices;
using GeekShop.Web.Utils;
using System.Net.Http.Headers;
using System.Reflection;

namespace GeekShop.Web.Services
{
    public class CartService : ICartService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/cart";

        public CartService(HttpClient client)
        {
            _client = client;
        }

        public async Task<CartViewModel> FindCartByUserId(string userId, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.GetAsync($"{BasePath}/find-cart/{userId}");
            return await response.ReadContentAs<CartViewModel>();
        }

        public async Task<CartViewModel> AddItemToCart(CartViewModel model, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.PostAsJson($"{BasePath}/add-cart/", model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CartViewModel>();
            else
                throw new Exception("Something went wrong when calling API");
        }

        public async Task<CartViewModel> UpdateCart(CartViewModel model, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.PuttAsJson($"{BasePath}/update-cart/", model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CartViewModel>();
            else
                throw new Exception("Something went wrong when calling API");
        }

        public async Task<bool> RemoveFromCart(long cartId, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.DeleteAsync($"{BasePath}/remove-cart/{cartId}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<bool>();
            else
                throw new Exception("Something went wrong when calling API");
        }

        public async Task<bool> ApplyCoupon(CartViewModel cart, string coupon, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<CartViewModel> Checkout(CartViewModel cartHeader, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ClearCart(string userId, string token)
        {
            throw new NotImplementedException();
        }        

        public async Task<bool> RemoveCoupon(string userId, string token)
        {
            throw new NotImplementedException();
        }       
    }
}
