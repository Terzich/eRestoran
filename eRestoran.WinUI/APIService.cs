﻿using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestoran.Model;
using System.Windows.Forms;

namespace eRestoran.WinUI
{
    public class APIService
    {
        private string _route;
        public static string _Username;
        public static string _Password;

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

            var result = await url.WithBasicAuth(_Username,_Password).GetJsonAsync<T>();
            return result;

        }
        public async Task<T> GetById<T>(object id)
        {

            var url = $"{Properties.Settings.Default.APIurl}/{_route}/{id}";
           

            var result = await url.WithBasicAuth(_Username, _Password).GetJsonAsync<T>();
            return result;

        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIurl}/{_route}";
            return await url.WithBasicAuth(_Username, _Password).PostJsonAsync(request).ReceiveJson<T>();
        }
        //public async Task<T> Update<T>(object id, object request)
        //{
        //    var url = $"{Properties.Settings.Default.APIurl}/{_route}/{id}";
        //    return await url.PutJsonAsync(request).ReceiveJson<T>();
        //}
        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIurl}/{_route}/{id}";

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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }
    }
}
