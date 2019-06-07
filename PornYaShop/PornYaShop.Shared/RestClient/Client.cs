using Newtonsoft.Json;
using PornYaShop.Shared.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace PornYaShop.Shared.RestClient
{
    public static class RestClient
    {
        static HttpClientHandler httpClientHandler
        {
            get
            {
                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, cetChain, policyErrors) =>
                    {
                        return true;
                    };
                return handler;
            }
        }
        static HttpClient client = new HttpClient(httpClientHandler);

        public static async Task<BaseResponse<T>> Get<T>(string url)
        {
            var response = await client.GetAsync(url);
            try
            {
                return JsonConvert.DeserializeObject<BaseResponse<T>>(await response.Content.ReadAsStringAsync());
            }
            catch
            {
                return default;
            }
        }

        public static async Task<BaseResponse<T>> Post<T>(string url, object param)
        {
            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new LowercaseContractResolver();

            string jsonBody = JsonConvert.SerializeObject(param, Formatting.Indented, serializerSettings);

            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            try
            {
                return JsonConvert.DeserializeObject<BaseResponse<T>>(await response.Content.ReadAsStringAsync());
            }
            catch
            {
                return default;
            }
        }

        public static async Task<BaseResponse<T>> Put<T>(string url, object param)
        {
            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new LowercaseContractResolver();

            string jsonBody = JsonConvert.SerializeObject(param, Formatting.Indented, serializerSettings);

            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            var message = new HttpRequestMessage(new HttpMethod("PUT"), url);
            message.Content = content;

            var response = await client.SendAsync(message);

            try
            {
                return JsonConvert.DeserializeObject<BaseResponse<T>>(await response.Content.ReadAsStringAsync());
            }
            catch
            {
                return default;
            }

        }

    }
}
