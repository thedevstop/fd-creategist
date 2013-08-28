using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CreateGist.Helpers
{
    public static class HttpHelper
    {
        public static string Post<T>(string uri, object data)
        {
            var request = WebRequest.Create(uri);
            request.Method = "POST";

            var postData = JsonConvert.SerializeObject(data, typeof(T), Formatting.None, null);
            request.ContentLength = postData.Length;
            request.ContentType = "application/json";

            using (var requestStream = request.GetRequestStream())
            using (var requestWriter = new StreamWriter(requestStream))
            {
                requestWriter.Write(postData);
            }

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                var body = reader.ReadToEnd();
                var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(body);
                return (string)responseData["html_url"];
            }
        }
    }
}
