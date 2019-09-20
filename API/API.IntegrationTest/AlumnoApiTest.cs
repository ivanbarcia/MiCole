﻿using Newtonsoft.Json;
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
    public class AlumnoApiTest : TestFixture
    {
        [Test]
        public async Task AddAlumno()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8,"application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/Alumno/AddAlumno?Nombre=Ivan&Apellido=Barcia", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Alumno>(result);
        }

        [Test]
        public async Task AddPadre()
        {
            // Act
            var content = new StringContent("", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await _client.PostAsync("api/Alumno/AddAlumno?Nombre=Ivan&Apellido=Barcia", content);

            // Arrange
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Alumno>(result);
        }
    }
}
