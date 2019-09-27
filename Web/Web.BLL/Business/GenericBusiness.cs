using Web.BLL.Interfaces;
using System.Configuration;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using Web.DAL.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Web.BLL.Business
{
    public abstract class GenericBusiness<T> : IGenericBusiness<T> where T : class
    {
        readonly static string uri = ConfigurationManager.AppSettings["WEBApi"].ToString();

        public T Find(int? id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var request = string.Format("alumno/Find?Id={0}", id);

                var result = JsonConvert.DeserializeObject<List<T>>(client.GetStringAsync(request).Result);

                if (result.Count > 0)
                {
                    return result[0];
                }

                return null;
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var request = string.Format("alumno/GetAll");

                var result = JsonConvert.DeserializeObject<List<T>>(client.GetStringAsync(request).Result);

                if (result.Count > 0)
                {
                    return result;
                }

                return null;
            }
        }

        public virtual void Insert(T entity)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var request = string.Format("alumno/Find?Id={0}", 1);

                var result = JsonConvert.DeserializeObject<List<T>>(client.GetStringAsync(request).Result);
                
            }
        }

        public virtual void Delete(T entity)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var request = string.Format("alumno/Find?Id={0}", 1);

                var result = JsonConvert.DeserializeObject<List<T>>(client.GetStringAsync(request).Result);
                
            }
        }

        public virtual void Update(T entity)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var request = string.Format("alumno/Find?Id={0}", 1);

                var result = JsonConvert.DeserializeObject<List<T>>(client.GetStringAsync(request).Result);
                
            }
        }
    }
}
