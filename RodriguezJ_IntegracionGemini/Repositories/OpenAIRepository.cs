using RodriguezJ_IntegracionGemini.Interfaces;

namespace RodriguezJ_IntegracionGemini.Repositories
{
    public class OpenAIRepository : IChatbotService
    {
        public Task<string> GetChatbotResponse(string prompt)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveResponseInDatabase(string chatbotPrmompt, string chatbotResponse)
        {
            throw new NotImplementedException();
        }
    }
}
