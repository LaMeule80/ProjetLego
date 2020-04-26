using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using LegoBlazor.API.Json;
using Microsoft.AspNetCore.Mvc.Localization;

namespace LegoBlazor.API
{
    public class PartsAPI
    {
        HttpClient client = new HttpClient();

        public void CallAPI()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
        async Task<List<PartsJson>> DeleteProductAsync(string id)
        {
            throw  new NotImplementedException();
        }
    }
}
