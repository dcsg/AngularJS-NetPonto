using Newtonsoft.Json;
using System.Web.Http;

namespace AngularJS_NetPonto
{
    public class ApiConfig
    {
        public static void ConfigureApi(HttpConfiguration config)
        {
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = 
                PreserveReferencesHandling.Objects;

            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }

}