using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestoran.Model;

namespace eRestoran.WinUI
{
    public class APIService
    {
        private string _route;

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            
            var url = $"{Properties.Settings.Default.APIurl}/{_route}";
            if(search!=null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.GetJsonAsync<T>();
            return result;

        }
    }
}
