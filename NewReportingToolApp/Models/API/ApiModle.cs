using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NewReportingToolApp.Models.API.ApiMembers;

namespace NewReportingToolApp.Models.API
{
    public class ApiModle : IApiModel
    {
        public ApiModle() { 
        
        
        }

        public List<Class1> ReturnData()
        {
            string apiKey = ConfigurationManager.AppSettings["api_key"];

            TWFYAPI myAPI = new TWFYAPI(apiKey);

            //string temp = myAPI.query("getPerson", new string[] { "id:10900", "output:js" });
            string temp = myAPI.query("getMPs", new string[] { });

            //Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);

            List<Class1> deserialized = JsonConvert.DeserializeObject<List<Class1>>(temp);

            return deserialized;
        }
    }
}
