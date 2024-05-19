using Microsoft.AspNetCore.Mvc;
using Question2.Models;
using System.Text;
using Newtonsoft.Json;

namespace Question2.Controllers
{
    public class WebServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WebServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Person person)
        {
            if (ModelState.IsValid)
            {
                var httpClient = _httpClientFactory.CreateClient();
                var jsonContent = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("http://localhost:5000/api/Person/Add", jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("List");
                }
            }
            return View(person);
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string name)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var jsonContent = new StringContent(JsonConvert.SerializeObject(name), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://localhost:5000/api/Person/Delete", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("List");
            }
            return View();
        }

        public async Task<IActionResult> List()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.GetAsync("http://localhost:5000/api/Person/List");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var people = JsonConvert.DeserializeObject<List<Person>>(jsonData);
                return View(people);
            }
            return View(new List<Person>());
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(string name)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var jsonContent = new StringContent(JsonConvert.SerializeObject(name), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://localhost:5000/api/Person/Search", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var people = JsonConvert.DeserializeObject<List<Person>>(jsonData);
                return View("List", people);
            }
            return View("List", new List<Person>());
        }

    }
}
