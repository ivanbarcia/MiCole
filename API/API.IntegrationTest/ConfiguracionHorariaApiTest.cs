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
    public class ConfiguracionHorariaApiTest : TestFixture
    {
        [Test]
        public async Task GetAllConfiguracionHoraria()
        {
            // Act
            var response = await _client.GetAsync("api/ConfiguracionHoraria/GetAll");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<List<ConfiguracionHoraria>>(result);
        }

        [Test]
        public async Task AddConfiguracionHoraria()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8,"application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/ConfiguracionHoraria/Add?Nombre=Ivan&Apellido=Barcia", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<ConfiguracionHoraria>(result);
        }

        [Test]
        public async Task UpdateConfiguracionHoraria()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await _client.PutAsync("api/ConfiguracionHoraria/Update?Nombre=Ivan&Apellido=Barcia", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<ConfiguracionHoraria>(result);
        }

        [Test]
        public async Task DeleteConfiguracionHoraria()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/ConfiguracionHoraria/Delete?Id=2", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<ConfiguracionHoraria>(result);
        }

        [Test]
        public async Task GetConfiguracionHorarias()
        {
            // Act
            var response = await _client.GetAsync("api/ConfiguracionHoraria/Get?Nombre=Ivan&Apellido=Barcia");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject(result);
        }

        [Test]
        public async Task FindConfiguracionHoraria()
        {
            // Act
            var response = await _client.GetAsync("api/ConfiguracionHoraria/Find?Id=3");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<ConfiguracionHoraria>(result);
        }
    }
}
