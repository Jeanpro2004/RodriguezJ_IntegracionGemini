namespace RodriguezJ_IntegracionGemini.Interfaces
{
    public interface IChatbotService
    {
        public Task <string> GetChatbotResponseAsync(string prompt);

        public Task <Boolean> SaveResponseInDatabase(string chatbotPrmompt, string chatbotResponse);
    }
}
