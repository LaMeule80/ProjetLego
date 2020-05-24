using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace LegoAPI
{
    public abstract class ApiHelper
    {
        public string ApiKey = "df134229e22f0dac787fb8ed6973de97";

        public string UrlBase = "https://rebrickable.com/api/v3/lego";

        public abstract string Uri { get; }

        public string Adresse => $"{UrlBase}/{Uri}/?key={ApiKey}";

        public TData Get<TData>(List<KeyValuePair<string, object>> param = null) where TData : class, new()
        {
            string url = Adresse;
            if (param != null && param.Count > 0)
                param.ForEach(x => url += $"&{x.Key}={x.Value}");

            TData data;

            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = WebRequestMethods.Http.Get;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8))
                    {
                        string responseJSON = myStreamReader.ReadToEnd();
                        data = JsonConvert.DeserializeObject<TData>(responseJSON);
                    }
                }
            }

            return data;
        }
    }
}
