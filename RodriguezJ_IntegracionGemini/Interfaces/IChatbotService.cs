namespace RodriguezJ_IntegracionGemini.Interfaces
{
    public interface IChatbotService
    {
        public Task <string> GetChatbotResponse(string prompt);

        public Task <Boolean> SaveResponseInDatabase(string chatbotPrmompt, string chatbotResponse);
    }
}
