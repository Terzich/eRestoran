using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.WinUI
{
    public class APIService
    {
        private string _route;

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>()
        {
            var result = await $"{Properties.Settings.Default.APIurl}/{_route}".GetJsonAsync<T>();
            return result;
        }
    }
}
