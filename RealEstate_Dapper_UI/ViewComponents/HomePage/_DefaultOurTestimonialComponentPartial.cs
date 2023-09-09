using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.PopularLocationsDtos;
using RealEstate_Dapper_UI.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultOurTestimonialComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultOurTestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/Testimonial");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(value);

            }


            return View();
        }
    }
}
