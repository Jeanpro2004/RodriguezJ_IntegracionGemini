using Newtonsoft.Json;
using RodriguezJ_IntegracionGemini.Interfaces;
using RodriguezJ_IntegracionGemini.Models;
using System.Net.Http;
using System.Text;

namespace RodriguezJ_IntegracionGemini.Repositories
{
    public class GeminiRepository : IChatbotService
    {
        private HttpClient _httpClient;
        private string GeminiKey = "AIzaSyBo9-NrdS2HdN8AUPnWx1v3_4NWHUGSgnI";

            public GeminiRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> GetChatbotResponseAsync(string prompt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=" + GeminiKey;
            GeminiRequest request = new GeminiRequest
            {
                contents = new List<GeminiContent>
                {
                    new GeminiContent
                    {
                        parts = new List<GeminiPart>
                        {
                            new GeminiPart
                            {
                                text = prompt
                            }
                        }
                    }
                }
            };

            string requestJson = JsonConvert.SerializeObject(request);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);
            var answer = await response.Content.ReadAsStringAsync();
            return answer;

        }

        public Task<bool> SaveResponseInDatabase(string chatbotPrmompt, string chatbotResponse)
        {
            throw new NotImplementedException();
        }

     
    }
}
