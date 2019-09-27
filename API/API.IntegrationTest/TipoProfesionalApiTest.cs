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
    public class TipoProfesionalApiTest : TestFixture
    {
        [Test]
        public async Task GetAllTipoProfesional()
        {
            // Act
            var response = await _client.GetAsync("api/TipoProfesional/GetAll");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<List<TipoProfesional>>(result);
        }

        [Test]
        public async Task AddTipoProfesional()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8,"application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/TipoProfesional/Add?Nombre=Ivan&Apellido=Barcia", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<TipoProfesional>(result);
        }

        [Test]
        public async Task UpdateTipoProfesional()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await _client.PutAsync("api/TipoProfesional/Update?Nombre=Ivan&Apellido=Barcia", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<TipoProfesional>(result);
        }

        [Test]
        public async Task DeleteTipoProfesional()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/TipoProfesional/Delete?Id=2", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<TipoProfesional>(result);
        }

        [Test]
        public async Task GetTipoProfesionals()
        {
            // Act
            var response = await _client.GetAsync("api/TipoProfesional/Get?Nombre=Ivan&Apellido=Barcia");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject(result);
        }

        [Test]
        public async Task FindTipoProfesional()
        {
            // Act
            var response = await _client.GetAsync("api/TipoProfesional/Find?Id=3");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<TipoProfesional>(result);
        }
    }
}
