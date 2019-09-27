using Newtonsoft.Json;
using NUnit.Framework;
using API.IntegrationTest;
using API.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SGMApi.IntegrationTest
{
    [TestFixture]
    public class AutorizacionApiTest : TestFixture
    {
        [Test]
        public async Task GetAllAutorizacion()
        {
            // Act
            var response = await _client.GetAsync("api/Autorizacion/GetAll");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<List<Autorizacion>>(result);
        }

        [Test]
        public async Task AddAutorizacion()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8,"application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/Autorizacion/Add?Nombre=Ivan&Apellido=Barcia", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Autorizacion>(result);
        }

        [Test]
        public async Task UpdateAutorizacion()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await _client.PutAsync("api/Autorizacion/Update?Nombre=Ivan&Apellido=Barcia", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Autorizacion>(result);
        }

        [Test]
        public async Task DeleteAutorizacion()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/Autorizacion/Delete?Id=2", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Autorizacion>(result);
        }

        [Test]
        public async Task GetAutorizacions()
        {
            // Act
            var response = await _client.GetAsync("api/Autorizacion/Get?Nombre=Ivan&Apellido=Barcia");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject(result);
        }

        [Test]
        public async Task FindAutorizacion()
        {
            // Act
            var response = await _client.GetAsync("api/Autorizacion/Find?Id=3");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Autorizacion>(result);
        }
    }
}
