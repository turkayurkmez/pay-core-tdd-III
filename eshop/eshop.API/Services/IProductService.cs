﻿namespace eshop.API.Services
{
    public interface IProductService
    {
        IEnumerable<Product> SearchProductsByName(string productName);
    }
}