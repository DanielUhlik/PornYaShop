using System;
using System.Collections.Generic;
using System.Text;

namespace PornYaShop.Shared.RestClient
{
    public static class Endpoints
    {
        public static class Gateway
        {
            private static readonly string baseUrl = "https://pornyashop.gateway:443/api/";
            public static class Products
            {
                public static string GetAll = baseUrl + "products";
                public static string Create = baseUrl + "admin/products";
                public static string Edit = baseUrl + "admin/products";
            }

            public static class Categories
            {
                public static string Create = baseUrl + "admin/categories";
                public static string GetAllWithProducts = baseUrl + "categories/products";
                public static string GetAll = baseUrl + "categories";
            }
        }

        public static class Products
        {
            private static readonly string baseUrl = "https://pornyashop.products:443/api/products/";
            public static string Create = baseUrl;
            public static string GetAll = baseUrl;
            public static string Edit = baseUrl;
            public static string GetById(int id) => baseUrl + id;
        }

        public static class Categories
        {
            private static readonly string baseUrl = "https://pornyashop.products:443/api/categories/";
            public static string Create = baseUrl;
            public static string GetAll = baseUrl;
            public static string GetAllWithProducts = baseUrl + "products";
            public static string GetById(int id) => baseUrl + id;
        }

    }
}
