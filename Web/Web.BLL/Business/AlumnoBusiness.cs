using Web.BLL.Interfaces;
using System.Configuration;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Web.DAL.Models;

namespace Web.BLL.Business
{
    public class AlumnoBusiness : IAlumnoBusiness
    {
        readonly static string uri = ConfigurationManager.AppSettings["WEBApi"].ToString();

        public Alumno Find(int? id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var request = string.Format("alumno/Find?Id={0}", id);

                var result = JsonConvert.DeserializeObject<List<Alumno>>(client.GetStringAsync(request).Result);

                if (result.Count > 0)
                {
                    return result[0];
                }

                return null;
            }
        }

        public IEnumerable<Alumno> GetAll()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var request = string.Format("alumno/GetAll");

                var result = JsonConvert.DeserializeObject<List<Alumno>>(client.GetStringAsync(request).Result);

                if (result.Count > 0)
                {
                    return result;
                }

                return null;
            }
        }

        public virtual void Insert(Alumno entity)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var request = string.Format("alumno/Insert?Id={0}", 1);

                var result = JsonConvert.DeserializeObject<List<Alumno>>(client.GetStringAsync(request).Result);

            }
        }

        public virtual void Delete(Alumno entity)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var request = string.Format("alumno/Delete?Id={0}", 1);

                var result = JsonConvert.DeserializeObject<List<Alumno>>(client.GetStringAsync(request).Result);

            }
        }

        public virtual void Update(Alumno entity)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var request = string.Format("alumno/Update?Id={0}", 1);

                var result = JsonConvert.DeserializeObject<List<Alumno>>(client.GetStringAsync(request).Result);

            }
        }
    }
}
