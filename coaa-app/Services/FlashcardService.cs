using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using coaa_app.Data;

namespace coaa_app.Services
{
    public class FlashcardService
    {
        private readonly HttpClient _http;
        public FlashcardService(HttpClient http)
        {
            _http = http;
        }

        public async Task<FlashcardJson> GetWeek1Async()
        {
            return await _http.GetFromJsonAsync<FlashcardJson>("data/week-1/qa.json");
        }
    }
}
