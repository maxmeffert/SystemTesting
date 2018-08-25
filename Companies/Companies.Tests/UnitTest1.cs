using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace Tests
{
    public class Tests
    {
        [OneTimeSetUp]
        public static async Task OneTimeSetup()
        {
            var t = new Thread(() => {
                Companies.Api.Program.Main(new string[0]);
            });
            t.Start();
            await Task.Delay(5000);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:5000/api/values");
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            Assert.AreEqual("[\"value1\",\"value2\"]", content);
        }
    }
}