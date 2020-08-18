using eRestoran.Model;
using System.Collections.Generic;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

 namespace eRestoran.MobileApp
{
    public class APIService
    {
        private readonly string _route;
        public static string _Username;
        public static string _Password;

#if DEBUG
        private string _apiUrl= "http://localhost:49947/api";
#endif

#if RELEASE
        private string _apiUrl="https://mywebsite.com/api";

#endif
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{_apiUrl}/{_route}";
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithBasicAuth(_Username, _Password).GetJsonAsync<T>();

            }
            catch (FlurlHttpException ex)
            {
                if(ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }
                throw;
            }
           
        }
        public async Task<T> GetById<T>(object id)
        {

            var url = $"{_apiUrl}/{_route}/{id}";


            var result = await url.WithBasicAuth(_Username, _Password).GetJsonAsync<T>();
            return result;

        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";
            return await url.WithBasicAuth(_Username, _Password).PostJsonAsync(request).ReceiveJson<T>();
        }
       
        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(_Username, _Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška!", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }
    }
}
