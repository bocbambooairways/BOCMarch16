using BOC.Areas.E_Library.Models;
using BOC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BOC.Areas.E_Library.Controllers
{
    [Area("E-Library")]//Declare Area
    public class FolderController : Controller
    {
        public UriConfig UriConfig { get; }
        public FolderController(Microsoft.Extensions.Options.IOptions<UriConfig> _UriConfig)
        {
            UriConfig = _UriConfig.Value;
        }
        public IActionResult Index()
        {


            //string uri_GetSearch_Doc_Folder_Get = UriConfig.uri_GetSearch_Doc_Folder_Get;
            //List<Doc_Folder_Get> GetSearch_Doc_Folder_Get = new DataAPI().GetWebAPIWithoutParams<Doc_Folder_Get>(uri_GetSearch_Doc_Folder_Get,
            //                          HttpContext.Session.GetString("Token"),
            //                         string.Empty,
            //                         string.Empty).Result;




            string uri_GetSearch_Doc_Folder_Get = UriConfig.uri_GetSearch_Doc_Folder_Get;
            List<Doc_Folder_Get> GetSearch_Doc_Folder_Get = new DataAPI().GetListAPIWithoutParams<Doc_Folder_Get>(uri_GetSearch_Doc_Folder_Get,
                                      HttpContext.Session.GetString("Token"),HttpMethod.Post,false,"Data"
                                     ).Result;




            //return View(SampleData.TreeListEmployees);
            return View(GetSearch_Doc_Folder_Get);
        }

        //    public async Task<List<Doc_Folder_Get>> GetData(string uri,
        //                                     string Token,
        //                                     string param1,
        //                                     string _param1)
        //    {
        //        using (HttpClient _httpClient = new HttpClient())
        //        {
        //            _httpClient.DefaultRequestHeaders.Add("Authorization", Token);
        //            var _parameters = new List<KeyValuePair<string, string>>();
        //            _parameters.Add(new KeyValuePair<string, string>(param1, _param1));

        //            var req = new HttpRequestMessage(HttpMethod.Post, uri) { Content = new FormUrlEncodedContent(_parameters) };
        //            string _Content;
        //            HttpResponseMessage res;
        //            res = await _httpClient.SendAsync(req).ConfigureAwait(false);
        //            _Content = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
        //            var oData = JObject.Parse(_Content);
        //            var ConvertToObject = JsonConvert.SerializeObject(oData);
        //            List<Doc_Folder_Get> deserializeData = JsonConvert.DeserializeObject<List<Doc_Folder_Get>>(oData["Data"].ToString());
        //            return deserializeData;
        //        }
        //    }
    }
}
