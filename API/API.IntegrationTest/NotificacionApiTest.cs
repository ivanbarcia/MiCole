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
    public class NotificacionApiTest : TestFixture
    {
        [Test]
        public async Task SendMessage()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/Notificacion/SendMessage?Fecha=20190919&FechaHora=20:30&UsuarioEmisorId=1&UsuarioReceptorId=1&Mensaje=Hola", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Notificacion>(result);
        }

        [Test]
        public async Task GetMessages()
        {
            // Act
            var response = await _client.GetAsync("api/Notificacion/GetMessages");

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject(result);
        }
    }
}
