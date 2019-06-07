using Newtonsoft.Json.Serialization;

namespace PornYaShop.Shared.RestClient
{
    public class LowercaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }
    }
}