namespace WhatsApp_WebHook.Service
{
    public interface IWebHookService
    {
    }

    public class WebHookService : IWebHookService
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<WebHookService> logger;

        public WebHookService(IConfiguration configuration, ILogger<WebHookService> logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }
    }
}
