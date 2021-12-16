using AdvancedField.FunTranslation.IServices;
using AdvancedField.FunTranslation.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AdvancedField.FunTranslation.Services
{
    public class FunTranslationService : IFunTranslationService
    {
        public FunTranslationResponseModel GetConvertedString(string text)
        {

            var url = new Uri($"https://api.funtranslations.com/translate/");
            var client = new RestClient(url);

            var restRequest = new RestRequest("yoda", Method.GET) { Timeout = 10000 };

            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddQueryParameter("text", text);
            restRequest.AddHeader("X-Funtranslations-Api-Secret", "true");

            IRestResponse response = client.Execute(restRequest);

            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<FunTranslationResponseModel>(response.Content);
            else
                return null;
        }
    }
}
