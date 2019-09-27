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
    public class AsignaturaApiTest : TestFixture
    {
        [Test]
        public async Task GetAllAsignaturas()
        {
            // Act
            var response = await _client.GetAsync("api/ASignatura/GetAll");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<List<Asignatura>>(result);
        }

        [Test]
        public async Task AddAsignatura()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8,"application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/Asignatura/Add?Nombre=Ivan&Apellido=Barcia", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Asignatura>(result);
        }

        [Test]
        public async Task UpdateAsignatura()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await _client.PutAsync("api/Asignatura/Update?Nombre=Ivan&Apellido=Barcia", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Asignatura>(result);
        }

        [Test]
        public async Task DeleteAsignatura()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/Asignatura/Delete?Id=2", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Asignatura>(result);
        }

        [Test]
        public async Task GetAsignaturas()
        {
            // Act
            var response = await _client.GetAsync("api/Asignatura/Get?Nombre=Ivan&Apellido=Barcia");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject(result);
        }

        [Test]
        public async Task FindAsignatura()
        {
            // Act
            var response = await _client.GetAsync("api/Asignatura/Find?Id=3");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Asignatura>(result);
        }
    }
}
